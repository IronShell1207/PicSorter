using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace PicSorter
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public string FolderPath { get; set; }
        public int TotalFiles { get; set; }
        public int timeSpent { get; set; }

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Select path and press \"Start\"");

        }
        void PicSorter(string path)
        {

            var files = new DirectoryInfo(path).GetFiles();
            TotalFiles = files.Length;
            int lans = 0;
            int verts = 0;
            int others = 0;
            if (InvokeRequired) progss.Invoke(new Action(() => progss.Maximum = TotalFiles));
            else progss.Maximum = TotalFiles;
            int val = 0;
            foreach (FileInfo fl in files)
            {
                if (fl.Extension == ".png" || fl.Extension == ".jpg")
                {
                    val++;
                    progress(val);
                    var img = Image.FromFile(fl.FullName);
                    if (img.Width > img.Height && cbLand.Checked == true) //широкая 
                    {
                        lans++;
                        img.Dispose();
                        fl.MoveTo(FolderLand(path, @"Landscape") + @"\" + fl.Name);
                        progressChanged(String.Format("Moved to Landscape: {0}", fl.Name));
                    }
                    else if (img.Width < img.Height && cbPort.Checked == true) //Высокая
                    {
                        verts++;
                        img.Dispose();
                        fl.MoveTo(FolderLand(path, @"Portrait") + @"\" + fl.Name);
                        progressChanged(String.Format("Moved to Portrait: {0}", fl.Name));
                    }
                    else if (img.Width == img.Height && cbSq.Checked == true)
                    {
                        img.Dispose();
                        fl.MoveTo(FolderLand(path, @"Square") + @"\" + fl.Name);
                        others++;
                        listAdd(String.Format("Square: {0}", fl.Name));
                    }
                }
                else { listAdd("Skiped: " + fl.Name); others++; }
            }
            timer1.Stop();
            MetroMessageBox.Show(this, String.Format("Complete! \nPortrait images: {0}      Landscape images: {1}\nSquare images: {2}              Total files: {3}\n\nTime spented: {4} sec", verts, lans, others, val, timeSpent),
                "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void listAdd(string message)
        {
            if (InvokeRequired) listBox1.Invoke(new Action(() => listBox1.Items.Insert(0, message)));
            else listBox1.Items.Insert(0, message);
        }
        void progressChanged(string name)
        {
            listAdd(name);
        }
        void progress(int vals)
        {
            if (InvokeRequired)
            {
                progss.Invoke(new Action(() => progss.Value = vals));
                labelStatus.Invoke(new Action(() => labelStatus.Text = "Status: " + vals + @"/" + TotalFiles));
            }
            else progss.Value = vals;
        }
        string FolderLand(string path, string orient)
        {
            if (!Directory.Exists(path + orient))
                Directory.CreateDirectory(path + orient);
            return path + orient;
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            var thrPic = new Thread(() =>
            {
                if (InvokeRequired) listAdd(String.Format("Current folder: {0}", FolderPath));
                PicSorter(FolderPath + @"\");
                metroButton2.Invoke(new Action(() => metroButton2.Enabled = true));
            })
            {
                IsBackground = true
            };
            if (Directory.Exists(FolderPath))
            {
                listAdd("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                timer1.Start();
                metroButton2.Enabled = false;
                thrPic.Start();

            }
            else MetroMessageBox.Show(this, "Folder don't exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog()
            {
                ValidateNames = false,
                CheckFileExists = false,
                InitialDirectory = FolderPath != null ? FolderPath : Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures),
                Title = "Choose folder with pictures to sort",
                CheckPathExists = true,
                Filter = "Picture Files (*.png, *.jpg)|*.png;*.jpg|All files|*.*"
            };
            Ookii.Dialogs.WinForms.VistaFolderBrowserDialog fBD = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog()
            {
                ShowNewFolderButton = true,
                Description = "Choose folder with pictures to sort",
                UseDescriptionForTitle = true,
                RootFolder = Environment.SpecialFolder.CommonPictures
            };
            if (DialogResult.OK == fBD.ShowDialog())
            {
                FolderPath = fBD.SelectedPath;
                tbfolderpath.Text = FolderPath;
            }
        }

        private void tbfolderpath_TextChanged(object sender, EventArgs e)
        {
            FolderPath = tbfolderpath.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeSpent += 1;
            var span = new TimeSpan(0, 0, timeSpent);
            metroLabel1.Text = "Time: " + String.Format("{0}:{1:00}", (int)span.TotalMinutes, span.Seconds);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelSettings.Location = new Point(200, 380);
            labelVer.Text = Application.ProductVersion + " by IronShell";
            chkupd = new EzShell.CheckUpdates(
                Application.ProductName,
                Application.ProductVersion,
                "/Files/PicSorter.zip",
                msgMaker,
                progss,
                nfIc,
                labelStatus);
            nfIc = new NotifyIcon()
            {
                Icon = Properties.Resources.PICSORT1,
                Text = "Image Sorter by IronShell"
            };
            var chupdt = new Thread(() =>
            {
                string Ver = chkupd.MsgUpdateAvailable();
                if (Ver != null)
                {
                    nfIc.Visible = true;
                    nfIc.BalloonTipClicked += NfIc_BalloonTipClicked;
                    nfIc.ShowBalloonTip(3000, "Update available " + Ver,
                        "PicSorter by IronShell", ToolTipIcon.Info);
                    Thread.Sleep(5000);
                    nfIc.Visible = false;
                    nfIc.Dispose();
                }
            }) { IsBackground = true };
            chupdt.Start();
        }

        private void NfIc_BalloonTipClicked(object sender, EventArgs e)
        {
            chkupd.UpdaterProg(msgMaker);
        }

        NotifyIcon nfIc;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var pOpened = new Point(200, 248);
            var pClosed = new Point(200, 380);
            var moving = new Thread(() =>
            {
                if (panelSettings.Location == pClosed)
                {
                    for (int i = pClosed.Y; i >= pOpened.Y; i -= 2)
                    {
                        Thread.Sleep(1);
                        panelSettings.Invoke(new Action(() => panelSettings.Location = new Point(200, i)));
                    }
                    pictureBox1.Image = Properties.Resources.arrowl;
                    pictureBox2.Image = Properties.Resources.arrowl;
                }
                else if (panelSettings.Location == pOpened)
                {
                    for (int i = pOpened.Y; i <= pClosed.Y; i += 2)
                    {
                        Thread.Sleep(2);
                        panelSettings.Invoke(new Action(() => panelSettings.Location = new Point(200, i)));
                    }
                    pictureBox1.Image = Properties.Resources.arrowup;
                    pictureBox2.Image = Properties.Resources.arrowup;
                }
            })
            { IsBackground = true };
            moving.Start();
        }
        public DialogResult msgMaker(string message, string header, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MetroMessageBox.Show(this, message, header, buttons, icon);
        }
        private EzShell.CheckUpdates chkupd;
        private void metroButton3_Click(object sender, EventArgs e)
        {
            chkupd.UpdaterProg(msgMaker);

        }
    }
}
