using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ManifestTool
{
    public partial class Form1 : Form
    {
        private string path = "";
        private int fileAmout = 0;
        public List<String> files = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Log(string line)
        {
            Logging.AppendText(line + "\n");
        }
        private void DirSearch(string sDir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    files.Add(f);
                    fileAmout++;
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DirectoryPath.Text = fbd.SelectedPath;
                    path = fbd.SelectedPath;
                    Log("Discovering file...");
                    DirSearch(path);
                    Log(fileAmout + " file, please press start to launch the process.");
                    this.progressBar1.Maximum = fileAmout;
                }
            }
        }
        private string GetFileHash(string from)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(from))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }
        private long GetFileSize(string from)
        {
            return new System.IO.FileInfo(from).Length;
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                if (!File.Exists("manifest.dat"))
                {
                    StreamWriter writetext = new StreamWriter("manifest.dat");
                    foreach (string s in files)
                    {
                        // Keep only root path selected
                        string file = s.Remove(0, path.Length);
                        this.progressBar1.Increment(1);
                        Log(file);
                        // start writing on file
                        writetext.WriteLine(file + ":" + GetFileHash(s) + ":" + GetFileSize(s));
                    }
                    writetext.Close();
                    MessageBox.Show("Manifest file generated!.", "Done", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Manifest file already exist.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("The path specified is invalid, please select an other one.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
