using System;
using System.Threading;
using System.Net;
using System.IO;

namespace Launcher
{
    class Uninstall
    {
        WebClient wc = new WebClient();

        public bool isFileExist(string pathFile)
        {
            FileInfo fileInfo = new FileInfo(pathFile);
            return fileInfo.Exists;
        }
        public void PerformUninstall()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            if (isFileExist(path + NetworkThing.Info.getManifestFile()) == false)
            {
                string ver = wc.DownloadString(NetworkThing.Info.getManifestFileFromUrl());
                System.IO.FileStream ss = System.IO.File.Create(path + NetworkThing.Info.getManifestFile());
                ss.Close();
                System.IO.File.WriteAllText(path + NetworkThing.Info.getManifestFile(), ver);
                System.IO.File.SetAttributes(path + NetworkThing.Info.getManifestFile(), FileAttributes.Normal);
            }
            string text = System.IO.File.ReadAllText(path + NetworkThing.Info.getManifestFile());
            string line;
            string[] separators = { ":" };
            System.IO.StringReader file = new System.IO.StringReader(text);
            while ((line = file.ReadLine()) != null)
            {
                if (Thread.CurrentThread.IsAlive == false)
                    return;
                string[] converted = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string FilePath = converted[0]; // path of the file: C/etc
                if (Directory.Exists(Path.GetDirectoryName(path + FilePath)))
                {
                    if (Path.GetDirectoryName(path + FilePath).Equals(path) == true) // prevent to delete the current folder
                    {
                        File.Delete(path + FilePath);
                    }
                    else
                    {
                        Directory.Delete(Path.GetDirectoryName(path + FilePath), true);
                    }
                }
            }
            if (isFileExist(path + NetworkThing.Info.getXmlFile()) == true)
                File.Delete(path + NetworkThing.Info.getXmlFile());
            System.Windows.Forms.MessageBox.Show("Uninstall completed");
        }
    }
}
