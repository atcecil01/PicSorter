using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicSorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SortMethod = "Month";
        }

        private string SortMethod { get; set; }
        private string DirPath { get; set; }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Operation in Process, Please wait...";
            string[] AllFiles  = Directory.GetFiles(DirPath);
            Helpers.MoveImages(AllFiles, SortMethod, DirPath);
            textBox1.Text = "Operation has completed";
        }

        private void btn_ChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            //Show the FolderBrowserDialog
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirPath = folderDlg.SelectedPath;
                textBox1.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void rdobtn_ByMonth_CheckedChanged(object sender, EventArgs e)
        {
            SortMethod = "Month";
        }
        private void rdobtn_ByDay_CheckedChanged(object sender, EventArgs e)
        {
            SortMethod = "Day";
        }
    }
}
