using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DarkSoulsSaveBackup
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        internal static string DarkSouls1SaveName = @"draks0005";
        internal static string DarkSouls2SaveName = @"DARKSII0000";


        private void btn_Drk1SavBrowse_Click(object sender, EventArgs e)
        {
            var dlg = GetValue(txt_Drk2SaveLoc);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_Drk1SaveLoc.Text = dlg.SelectedPath;
                LoadList(lstBox_Drk1SaveGames, dlg.SelectedPath);
            }
        }



        private void btn_Drk1BackupCurrentSave_Click(object sender, EventArgs e)
        {
            if (txt_Drk1SaveLoc.Equals(string.Empty))
            {
                MessageBox.Show("Please select a save folder first!");
                return;
            }
            var newSaveName = CopySave(txt_Drk1SaveLoc.Text, DarkSouls1SaveName);

            if (!newSaveName.Equals(string.Empty))
            {
                lstBox_Drk1SaveGames.Items.Add(newSaveName);
            }

        }


        private void btn_Drk1ClearBackups_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "Are you sure you wish to delete all your backup saves?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                ClearListBox(lstBox_Drk1SaveGames);

                LoadList(lstBox_Drk1SaveGames, txt_Drk1SaveLoc.Text);

            }
        }

        private void btn_Drk1LoadSelectedSave_Click(object sender, EventArgs e)
        {
            if (lstBox_Drk1SaveGames.SelectedItem != null)
            {
                LoadSave(lstBox_Drk1SaveGames.SelectedItem.ToString(), txt_Drk1SaveLoc.Text, DarkSouls1SaveName);

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
            var newSaveName = CopySave(txt_Drk2SaveLoc.Text, DarkSouls2SaveName);

            if (!newSaveName.Equals(string.Empty))
            {
                lstBox_Drk2SaveGames.Items.Add(newSaveName);
            }
        }

        private void btn_Drk2LoadSelectedSave_Click(object sender, EventArgs e)
        {
            if (lstBox_Drk2SaveGames.SelectedItem != null)
            {
                LoadSave(lstBox_Drk2SaveGames.SelectedItem.ToString(), txt_Drk2SaveLoc.Text, DarkSouls2SaveName);
            }
            else
            {
                MessageBox.Show("Please select a save to load.");
            }
        }

        private void btn_Drk2ClearBackups_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "Are you sure you wish to delete all your backup saves?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ClearListBox(lstBox_Drk2SaveGames);
                LoadList(lstBox_Drk2SaveGames, txt_Drk2SaveLoc.Text);
            }
        }



        private void btn_Drk2SavBrowse_Click(object sender, EventArgs e)
        {
            var dlg = GetValue(txt_Drk2SaveLoc);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_Drk2SaveLoc.Text = dlg.SelectedPath;
                LoadList(lstBox_Drk2SaveGames, dlg.SelectedPath);
            }
        }

        private static string CopySave(string saveLocation, string saveName)
        {
            var returnString = string.Empty;
            try
            {
                returnString = String.Format("{0}\\{1}_{2}.sl2", saveLocation, saveName,
                    DateTime.Now.ToString("MMddhmmss"));
                File.Copy(String.Format("{0}\\{1}.sl2", saveLocation, saveName), returnString);
            }
            catch
            {
                MessageBox.Show("Could not copy save!");
            }
            return returnString;
        }

        private static void ClearListBox(ListBox listBox)
        {
            foreach (var save in listBox.Items)
            {
                try
                {
                    File.Delete(save.ToString());
                }
                catch
                {
                    MessageBox.Show(String.Format("Could not delete {0}!", save));
                }
            }
        }
        private static FolderBrowserDialog GetValue(Control saveLoc)
        {
            var dlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = false,
                Description = @"Select Save Folder Location",
                RootFolder = Environment.SpecialFolder.MyComputer
            };

            if (!saveLoc.Text.Equals(string.Empty) && Directory.Exists(saveLoc.Text))
            {
                dlg.SelectedPath = saveLoc.Text;
            }

            return dlg;
        }

        private void LoadList(ListBox box, string folder)
        {
            box.Items.Clear();
            var files = Directory.GetFiles(folder);

            var drk1Save = String.Format("{0}\\{1}.sl2", txt_Drk1SaveLoc.Text, DarkSouls1SaveName);
            var drk2Save = String.Format("{0}\\{1}.sl2", txt_Drk2SaveLoc.Text, DarkSouls2SaveName);
            if (!files.Contains(drk1Save) && !files.Contains(drk2Save))
            {
                MessageBox.Show(this, @"Invalid Directory", @"The selected folder does not contain Dark Souls saves!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var str in files.Where(str => !str.Equals(drk1Save) && !str.Equals(drk2Save)))
            {
                box.Items.Add(str);
            }
        }


        private void LoadSave(string item, string saveLocation, string saveName)
        {
            var curSave = String.Format("{0}\\{1}.sl2", saveLocation, saveName);
            string newFileName = String.Format("{0}\\{1}_OriginalBak_{2}.sl2", saveLocation, saveName,
                DateTime.Now.ToString("MMddhmmss"));
            try
            {
                File.Copy(curSave, newFileName);
                lstBox_Drk2SaveGames.Items.Add(newFileName);

                File.Delete(curSave);
                File.Copy(item, curSave);
            }
            catch
            {
                MessageBox.Show(this, @"Loading Save Failure", @"Could not load the save file!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}
