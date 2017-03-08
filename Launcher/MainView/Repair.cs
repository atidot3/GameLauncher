using System;
using System.Collections.Generic;
using System.Threading;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Launcher
{
    class Repair
    {
        WebClient wc = new WebClient();
        List<string> fileToDownload = new List<string>();

        private string GetMD5HashFromFile(string fileName)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }
        public bool isFileExist(string pathFile)
        {
            string path = System.IO.Path.GetFullPath("./");
            bool isPathExist = System.IO.File.Exists(path + pathFile);
            return isPathExist;
        }
        public void PerformRepair(main MainfForm)
        {
            string ServerManifest = "";
            long TotalSize = 0;
            double counter = 0;
            string path = System.IO.Path.GetFullPath("./");
            string line;

            try
            {
                ServerManifest = wc.DownloadString(NetworkThing.Info.getManifestFileFromUrl());
            }
            catch (WebException e)
            {
                MessageBox.Show(e.ToString());
                Application.Exit();
            }

            if (isFileExist(path + NetworkThing.Info.getManifestFile())) { }
            else
            {
                FileStream ss = File.Create(path + NetworkThing.Info.getManifestFile());
                ss.Close();
                System.IO.File.WriteAllText(path + NetworkThing.Info.getManifestFile(), ServerManifest);
            }

            string[] separators = { ":" };
            System.IO.StringReader file = new System.IO.StringReader(ServerManifest);
            int Totalcount = File.ReadAllLines(NetworkThing.Info.getManifestFile()).Length;
            while ((line = file.ReadLine()) != null)
            {
                if (Thread.CurrentThread.IsAlive == false)
                    return;
                string[] converted = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string FilePath = converted[0]; // path of the file: C/etc
                string FileHash = converted[1]; // md5 hash of the file
                if (isFileExist(FilePath) == false)
                {
                    fileToDownload.Add(FilePath);
                    TotalSize += long.Parse(converted[2]); // size of the file
                }
                else
                {
                    string md5Local = GetMD5HashFromFile(path + FilePath); // here we check if the md5 from the server match with our local file (player modification ?)
                    if (md5Local.Equals(converted[1]) == false)
                    {
                        fileToDownload.Add(FilePath);
                        TotalSize += long.Parse(converted[2]); // size of the file
                    }
                }
                counter+=1;
                if (MainfForm != null && MainfForm.Created)
                {
                    double value = ((counter / Totalcount));
                    int final = (int)Math.Truncate(value * 100);
                    MainfForm.Invoke(new Action(() => MainfForm.updateProgressBarValue(final)));
                }
            }
            if (MainfForm != null && MainfForm.Created)
            {
                MainfForm.Invoke(new Action(() => MainfForm.updaterCallBack(fileToDownload, TotalSize, true)));
            }
        }
    }
}
