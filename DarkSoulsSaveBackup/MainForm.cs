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

        }


        private void btn_Drk1SavBrowse_Click(object sender, EventArgs e)
        {

            using (var dlg = new FolderBrowserDialog() { ShowNewFolderButton = false, Description = @"Select Save Folder Location" })
            {
                dlg.RootFolder = Environment.SpecialFolder.MyComputer;
                if(!txt_Drk1SaveLoc.Text.Equals(string.Empty) && Directory.Exists(txt_Drk1SaveLoc.Text))
                {
                    dlg.SelectedPath = txt_Drk1SaveLoc.Text;
                }
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txt_Drk1SaveLoc.Text = dlg.SelectedPath;
                    LoadList(lstBox_Drk1SaveGames, dlg.SelectedPath);
                }

            }
        }

        private void LoadList(ListBox box, string folder)
        {
            lstBox_Drk1SaveGames.Items.Clear();
            foreach(var str in Directory.GetFiles(folder))
            {
                if (!str.Equals(String.Format("{0}\\draks0005.sl2", txt_Drk1SaveLoc.Text)))
                {
                    box.Items.Add(str);
                }
            }
        }

        private void btn_Drk1BackupCurrentSave_Click(object sender, EventArgs e)
        {
            if(txt_Drk1SaveLoc.Equals(string.Empty))
            {
                MessageBox.Show("Please select a save folder first!");
                return;
            }
            try
            {
                string newFileName = String.Format("{0}\\draks0005_{1}.sl2", txt_Drk1SaveLoc.Text, DateTime.Now.ToString("MMddhmmss"));
                File.Copy(String.Format("{0}\\draks0005.sl2", txt_Drk1SaveLoc.Text), newFileName);
                lstBox_Drk1SaveGames.Items.Add(newFileName);
            }
            catch
            {
                MessageBox.Show("Could not copy save!");
            }
        }

        private void btn_Drk1ClearBackups_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Delete?", "Are you sure you wish to delete all your backup saves?",MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                foreach(var save in lstBox_Drk1SaveGames.Items)
                {
                    try
                    {
                        File.Delete(save.ToString());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(String.Format("Could not delete {0}!", save));
                    }
                }
                LoadList(lstBox_Drk1SaveGames, txt_Drk1SaveLoc.Text);

            }
        }

        private void btn_Drk1LoadSelectedSave_Click(object sender, EventArgs e)
        {
            if(lstBox_Drk1SaveGames.SelectedItem != null)
            {
                var item = lstBox_Drk1SaveGames.SelectedItem.ToString();
                var curSave = String.Format("{0}\\draks0005.sl2", txt_Drk1SaveLoc.Text);
                string newFileName = String.Format("{0}\\draks0005_OriginalBak_{1}.sl2", txt_Drk1SaveLoc.Text, DateTime.Now.ToString("MMddhmmss"));
                File.Copy(curSave, newFileName);
                lstBox_Drk1SaveGames.Items.Add(newFileName);
                
                File.Delete(curSave);
                File.Copy(item, curSave);
            }
            else
            {
                MessageBox.Show("Please select a save to load.");
            }
        }

        private void btn_Drk2BackupCurrentSave_Click(object sender, EventArgs e)
        {
            if (txt_Drk2SaveLoc.Equals(string.Empty))
            {
                MessageBox.Show("Please select a save folder first!");
                return;
            }
            try
            {
                string newFileName = String.Format("{0}\\DARKSII0000_{1}.sl2", txt_Drk2SaveLoc.Text, DateTime.Now.ToString("MMddhmmss"));
                File.Copy(String.Format("{0}\\DARKSII0000.sl2", txt_Drk2SaveLoc.Text), newFileName);
                lstBox_Drk2SaveGames.Items.Add(newFileName);
            }
            catch
            {
                MessageBox.Show("Could not copy save!");
            }
        }

        private void btn_Drk2LoadSelectedSave_Click(object sender, EventArgs e)
        {
            if (lstBox_Drk2SaveGames.SelectedItem != null)
            {
                var item = lstBox_Drk2SaveGames.SelectedItem.ToString();
                var curSave = String.Format("{0}\\DARKSII0000.sl2", txt_Drk2SaveLoc.Text);
                string newFileName = String.Format("{0}\\DARKSII0000_OriginalBak_{1}.sl2", txt_Drk2SaveLoc.Text, DateTime.Now.ToString("MMddhmmss"));
                File.Copy(curSave, newFileName);
                lstBox_Drk2SaveGames.Items.Add(newFileName);

                File.Delete(curSave);
                File.Copy(item, curSave);
            }
            else
            {
                MessageBox.Show("Please select a save to load.");
            }
        }

        private void btn_Drk2ClearBackups_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "Are you sure you wish to delete all your backup saves?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var save in lstBox_Drk2SaveGames.Items)
                {
                    try
                    {
                        File.Delete(save.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(String.Format("Could not delete {0}!", save));
                    }
                }
                LoadList(lstBox_Drk2SaveGames, txt_Drk2SaveLoc.Text);

            }
        }

        private void btn_Drk2SavBrowse_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog() { ShowNewFolderButton = false, Description = @"Select Save Folder Location" })
            {
                dlg.RootFolder = Environment.SpecialFolder.MyComputer;
                if (!txt_Drk2SaveLoc.Text.Equals(string.Empty) && Directory.Exists(txt_Drk2SaveLoc.Text))
                {
                    dlg.SelectedPath = txt_Drk2SaveLoc.Text;
                }
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txt_Drk2SaveLoc.Text = dlg.SelectedPath;
                    LoadList(lstBox_Drk2SaveGames, dlg.SelectedPath);
                }

            }
        }
    }
}
