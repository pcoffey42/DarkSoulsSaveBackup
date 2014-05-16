using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkSoulsSaveBackup
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitDefaults();
        }

        private void InitDefaults()
        {
            if (File.Exists("Config.Txt")) ;
        }


        private void btn_Drk1SavBrowse_Click(object sender, EventArgs e)
        {
 
            using (var dlg = new FolderBrowserDialog() {ShowNewFolderButton = false, Description = @"Select Save Folder Location"})
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Environment.SpecialFolder saveFolder = dlg.RootFolder;

                    txt_Drk1SaveLoc.Text = dlg.SelectedPath;
                }

            }


        }
    }
}
