using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Launcher
{
    public class Downloader
    {
        private main MainView;
        private BackgroundWorker Worker;
        private WebClient _wc = new WebClient();
        private List<string> downloadList;
        public bool downloadInProgress = false;
        private long downloadedAmount = 0;
        private NetworkInterface inter;
        private int currentFile = 0;
        private string currentFileString = "";
        /*******************************
            prepare the download (view, list to download)
            then prepare the worker
        /********************************/
        public void PrepareDownload(main fromMain, List<string> _downloadList)
        {
            MainView = fromMain;
            downloadList = _downloadList;
            Worker = new BackgroundWorker();
            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = true;
            Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            inter = new NetworkInterface(fromMain);
            Worker.RunWorkerAsync();
        }
        /*******************************
            we need to know if we are downloading or not for the exit window form to stop the worker etc
        /********************************/
        public bool getIsDownloading()
        {
            if (Worker != null)
                return Worker.IsBusy;
            return false;
        }
        /*******************************
            stop the worker
        /********************************/
        public void CancelWorker()
        {
            _wc.Dispose();
            Worker.CancelAsync();
            inter.StopNetworkInterface();
        }
        /*******************************
            simple function to check if a file exist
        /********************************/
        public bool isFileExist(string pathFile)
        {
            string path = System.IO.Path.GetFullPath("./");
            bool isPathExist = System.IO.File.Exists(path + pathFile);
            return isPathExist;
        }
        /*******************************
            Worker work
        /********************************/
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // no GUI method !
            for (int i = 0; i < downloadList.Count;)
            {
                // handle closing form during download
                if (Worker.CancellationPending)
                {
                    MainView = null;
                    _wc.CancelAsync();
                    e.Cancel = true;
                }
                else
                {
                    if (downloadInProgress == false)
                    {
                        downloadInProgress = true;
                        string path = System.IO.Path.GetFullPath("./");
                        string fileToDownloadPath = NetworkThing.Info.getDownloadUrl() + downloadList[i];
                        string SaveFileToPath = path + downloadList[i];
                        if (isFileExist(SaveFileToPath) == true)
                            System.IO.File.Delete(SaveFileToPath); // remove file if extist
                        else
                            // create directory where the file will be created (use api this don't do anything on existing directory)
                            System.IO.Directory.CreateDirectory(Path.GetDirectoryName(SaveFileToPath));
                        startDownload(fileToDownloadPath, SaveFileToPath);
                        currentFile = i;
                        currentFileString = Path.GetFileName(downloadList[i]);
                        i++;
                        int downloadProgress = (i * 100 / downloadList.Count);
                        Worker.ReportProgress(downloadProgress);
                    }
                }
            }
        }
        /*******************************
            Worker update progress
        /********************************/
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // update GUI method.
            if (MainView != null && MainView.Created)
            {
                MainView.Invoke(new Action(() => MainView.updateDownloadingInfo(currentFile, downloadList.Count, currentFileString)));
                MainView.Invoke(new Action(() => MainView.updateDownloadedAmount(downloadedAmount)));
            }
        }
        /*******************************
            Worker completed
        /********************************/
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {

            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.ToString());
            }
            else
            {
                if (MainView != null && MainView.Created)
                {
                    MainView.Invoke(new Action(() => MainView.UpdateCompleted()));
                }
            }
            inter.StopNetworkInterface();
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
                MessageBox.Show(fileToDownloadLink);
                MessageBox.Show(e.ToString());
                Worker.CancelAsync();
                Application.Exit();
            }
        }
        /*******************************
            update the progress of the download
        /********************************/
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 100)
            {
                downloadedAmount = e.TotalBytesToReceive;
            }
            if (MainView != null && MainView.Created)
            {
                MainView.Invoke(new Action(() => MainView.updateProgressBarValue()));
            }
        }
        /*******************************
            file downloaded
        /********************************/
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                _wc.CancelAsync();
            }
            else if (e.Error != null)
            {
                _wc.CancelAsync();
            }
            downloadInProgress = false;
        }
    }
}
