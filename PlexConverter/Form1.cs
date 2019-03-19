using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HandbrakeCLIwrapper;
using System.IO;
using System.IO.Compression;
using System.Net;
namespace PlexConverter
{
    public partial class frmMainForm : Form
    {
        static HandbrakeCli conv = new HandbrakeCli();
        static HandbrakeCliConfigBuilder HBConfig = new HandbrakeCliConfigBuilder();
        static bool wait = false;
        public frmMainForm()
        {
            InitializeComponent();
        }
        private void FrmMainForm_Load(object sender, EventArgs e)
        {

            if (!File.Exists("./HandbrakeCLI.exe"))
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://download2.handbrake.fr/1.2.2/HandBrakeCLI-1.2.2-win-x86_64.zip", "./CLI.zip");
                    ZipFile.ExtractToDirectory("./CLI.zip", "./");
                    File.Delete("./CLI.zip");
                    System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo("./doc");
                    Empty(directory);
                    Directory.Delete("./doc");
                }
            }

            conv.TranscodingStarted += Conv_TranscodingStarted;
            conv.TranscodingCompleted += Conv_TranscodingCompleted;
            conv.TranscodingError += Conv_TranscodingError;

            HandbrakeCliConfigBuilder config = new HandbrakeCliConfigBuilder();
            config.Encoder = HandbrakeCLIwrapper.Encoder.x264;
            config.AudioCopyMask.Add(AudioCopyMask.aac);
            config.AudioEncoder = AudioEncoder.av_aac;
            config.Format = Format.av_mp4;
            config.WebOptimize = true;
            HBConfig = config;
        }

        public static void Empty(System.IO.DirectoryInfo directory)
        {
            foreach (System.IO.FileInfo file in directory.GetFiles()) file.Delete();
            foreach (System.IO.DirectoryInfo subDirectory in directory.GetDirectories()) subDirectory.Delete(true);
        }

        private void Conv_TranscodingError(object sender, HandbrakeTranscodingEventArgs e)
        {

        }

        private void Conv_TranscodingCompleted(object sender, HandbrakeTranscodingEventArgs e)
        {
            wait = false;
        }

        private void Conv_TranscodingStarted(object sender, HandbrakeTranscodingEventArgs e)
        {

        }

        private void BtnDirectory_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if(result == DialogResult.OK)
            {
                tbPath.Text = fbd.SelectedPath;
            };
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            HBConfig.TwoPass = chkTwoPass.Checked;
            HBConfig.Build();
            DirectoryInfo info = new DirectoryInfo(tbPath.Text);
            List<string> files = GetFilesByExtensions(info, ".mp4",".mkv",".m4a",".avi",".3gp",".flv",".m4v",".mov",".wmv");
            ProgressBarUpdater.Enabled = true;
            pbAllFiles.Value = 0;
            pbAllFiles.Maximum = files.Count();
            foreach (var file in files)
            {
                conv.Transcode(HBConfig, file, tbOutput.Text, null, cbOverwrite.Checked, cbRemoveOriginal.Checked);
                lblFileName.Text = Path.GetFileName(file);
                wait = true;
                while (wait)
                {
                    System.Threading.Thread.Sleep(100);
                    Application.DoEvents();
                }
                pbAllFiles.Value += 1;
            }
        }
        public static List<string> GetFilesByExtensions(DirectoryInfo dir, params string[] extensions)
        {
            List<string> files = Directory.GetFiles(dir.FullName, "*.*", SearchOption.AllDirectories).Where(s => extensions.Contains(Path.GetExtension(s))).ToList();
            return files;
        }
        
       
        private void BtnOutput_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbOutput.Text = fbd.SelectedPath;
            };
        }

        private void ProgressBarUpdater_Tick(object sender, EventArgs e)
        {
            pbFile.Value = (int)conv.Status.Percentage;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            conv.StopTranscoding();
        }
    }
}
