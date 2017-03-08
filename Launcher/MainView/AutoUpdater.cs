using Launcher.MainView;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace Launcher
{
    class AutoUpdater
    {
        main MainForm;
        WebClient _wc = new WebClient();
        BackgroundWorker Worker;
        /*******************************
            is there any new version
        /********************************/
        public bool IsNeweerThan(string ver)
        {
            string serverVer = "";
            try
            {
                serverVer = XmlParser.getLauncherVersion();
            }
            catch (WebException e)
            {
                MessageBox.Show(e.ToString());
                Application.Exit();
            }
            if (ver.Equals(serverVer))
            {
                return false;
            }
            return true;
        }
        /*******************************
            do the update
        /********************************/
        public void doUpdateLauncher(main mainView)
        {
            MainForm = mainView;
            Worker = new BackgroundWorker();
            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = true;
            Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            Worker.RunWorkerAsync();
        }
        /*******************************
            worker start
        /********************************/
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string path = System.IO.Path.GetFullPath("./");
            string _fileToDownload = NetworkThing.Info.getDownloadUrl() + Assembly.GetExecutingAssembly().GetName().Name + ".exe";
            string SaveFileToPath = path + "tmp.bin";

            startDownload(_fileToDownload, SaveFileToPath);
        }
        /*******************************
            worker update progress bar
        /********************************/
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // update GUI method.
            if (MainForm != null && MainForm.Created)
            {
                MainForm.Invoke(new Action(() => MainForm.updateProgressBarValue()));
            }
        }
        /*******************************
            worker completed
        /********************************/
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {

            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                Application.Exit();
            }
        }
        /*******************************
            start the download of x file at y location
        /********************************/
        public void startDownload(string fileToDownloadLink, string PathToSaveFile)
        {
            try
            {
                using (_wc = new WebClient())
                {
                    _wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    _wc.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    _wc.DownloadFileAsync(new Uri(fileToDownloadLink), PathToSaveFile);
                }
            }
            catch (WebException e)
            {
                MessageBox.Show(e.ToString());
                Application.Exit();
            }
        }
        /*******************************
            update progress bar
        /********************************/
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            MainForm.Invoke(new Action(() => MainForm.updateProgressBarValue()));
        }
        /*******************************
            file downloaded
        /********************************/
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                _wc.CancelAsync();
                MessageBox.Show(e.Error.ToString());
                Application.Exit();
            }
            else if (e.Error != null)
            {
                _wc.CancelAsync();
                MessageBox.Show(e.Error.ToString());
                Application.Exit();
            }
            else
            {
                _wc.CancelAsync();
                UpdateApplication();
            }
        }
        /*******************************
            update the .exe himself
        /********************************/
        public void UpdateApplication()
        {
            string argument = "/C Choice /C Y /N /D Y /T 4 & DEL /F /Q \"{0}\" & Choice /C Y /N /D Y /T 2 & MOVE /Y \"{1}\" \"{2}\" & Start \"\" /D \"{3}\" \"{4}\" {5}";
            string currentPath = System.IO.Path.GetFullPath("./") + Assembly.GetExecutingAssembly().GetName().Name + ".exe";
            string tmpFilePath = System.IO.Path.GetFullPath("./") + "tmp.bin";
            string newPath = System.IO.Path.GetFullPath("./") + Assembly.GetExecutingAssembly().GetName().Name + ".exe";

            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = string.Format(argument, currentPath, tmpFilePath, newPath, Path.GetDirectoryName(newPath), Path.GetFileName(newPath),"");
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.FileName = "cmd.exe";
            Process.Start(info);
            Application.Exit();
        }
    }
}
