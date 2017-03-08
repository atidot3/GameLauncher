using System;
using System.Collections.Generic;
using System.Threading;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Reflection;
using Launcher.MainView;

namespace Launcher
{
    public class Updater
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
        public void Update(main MainfForm)
        {
            long TotalSize = 0;
            int counter = 0;
            string ServerManifest = wc.DownloadString(NetworkThing.Info.getManifestFileFromUrl());
            string path = System.IO.Path.GetFullPath("./");
            string line;
            

            string[] separators = { ":" };
            System.IO.StringReader file = new System.IO.StringReader(ServerManifest);
            while ((line = file.ReadLine()) != null)
            {
                if (Thread.CurrentThread.IsAlive== false)
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
                counter++;
            }
            if (MainfForm != null && MainfForm.Created)
                MainfForm.Invoke(new Action(() => MainfForm.updaterCallBack(fileToDownload, TotalSize)));
        }
    }
}