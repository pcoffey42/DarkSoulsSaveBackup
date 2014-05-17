using System.Windows.Forms;

namespace DarkSoulsSaveBackup
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        #endregion
           private GroupBox grp_Drk2;
        private Button btn_Drk2SavBrowse;
        private TextBox txt_Drk2SaveLoc;
        private Label lbl_Drk2Sav;
        private Button btn_Drk1SavBrowse;
        private Label lbl_Drk1Sav;
        private TextBox txt_Drk1SaveLoc;
        private Button btn_Drk2BackupCurrentSave;
        private GroupBox grp_Drk1;
    


        private void InitializeComponent()
        {
            this.grp_Drk2 = new System.Windows.Forms.GroupBox();
            this.lstBox_Drk2SaveGames = new System.Windows.Forms.ListBox();
            this.btn_Drk2LoadSelectedSave = new System.Windows.Forms.Button();
            this.btn_Drk2BackupCurrentSave = new System.Windows.Forms.Button();
            this.btn_Drk2SavBrowse = new System.Windows.Forms.Button();
            this.txt_Drk2SaveLoc = new System.Windows.Forms.TextBox();
            this.lbl_Drk2Sav = new System.Windows.Forms.Label();
            this.grp_Drk1 = new System.Windows.Forms.GroupBox();
            this.lstBox_Drk1SaveGames = new System.Windows.Forms.ListBox();
            this.btn_Drk1LoadSelectedSave = new System.Windows.Forms.Button();
            this.btn_Drk1SavBrowse = new System.Windows.Forms.Button();
            this.btn_Drk1BackupCurrentSave = new System.Windows.Forms.Button();
            this.lbl_Drk1Sav = new System.Windows.Forms.Label();
            this.txt_Drk1SaveLoc = new System.Windows.Forms.TextBox();
            this.lbl_Drk1Warn = new System.Windows.Forms.Label();
            this.lbl_Drk2Warn = new System.Windows.Forms.Label();
            this.btn_Drk1ClearBackups = new System.Windows.Forms.Button();
            this.btn_Drk2ClearBackups = new System.Windows.Forms.Button();
            this.grp_Drk2.SuspendLayout();
            this.grp_Drk1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Drk2
            // 
            this.grp_Drk2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Drk2.Controls.Add(this.btn_Drk2ClearBackups);
            this.grp_Drk2.Controls.Add(this.lbl_Drk2Warn);
            this.grp_Drk2.Controls.Add(this.lstBox_Drk2SaveGames);
            this.grp_Drk2.Controls.Add(this.btn_Drk2LoadSelectedSave);
            this.grp_Drk2.Controls.Add(this.btn_Drk2BackupCurrentSave);
            this.grp_Drk2.Controls.Add(this.btn_Drk2SavBrowse);
            this.grp_Drk2.Controls.Add(this.txt_Drk2SaveLoc);
            this.grp_Drk2.Controls.Add(this.lbl_Drk2Sav);
            this.grp_Drk2.Location = new System.Drawing.Point(12, 216);
            this.grp_Drk2.Name = "grp_Drk2";
            this.grp_Drk2.Size = new System.Drawing.Size(741, 226);
            this.grp_Drk2.TabIndex = 1;
            this.grp_Drk2.TabStop = false;
            this.grp_Drk2.Text = "Dark Souls 2";
            // 
            // lstBox_Drk2SaveGames
            // 
            this.lstBox_Drk2SaveGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBox_Drk2SaveGames.FormattingEnabled = true;
            this.lstBox_Drk2SaveGames.Location = new System.Drawing.Point(9, 102);
            this.lstBox_Drk2SaveGames.Name = "lstBox_Drk2SaveGames";
            this.lstBox_Drk2SaveGames.Size = new System.Drawing.Size(729, 121);
            this.lstBox_Drk2SaveGames.TabIndex = 11;
            // 
            // btn_Drk2LoadSelectedSave
            // 
            this.btn_Drk2LoadSelectedSave.Location = new System.Drawing.Point(140, 73);
            this.btn_Drk2LoadSelectedSave.Name = "btn_Drk2LoadSelectedSave";
            this.btn_Drk2LoadSelectedSave.Size = new System.Drawing.Size(125, 23);
            this.btn_Drk2LoadSelectedSave.TabIndex = 7;
            this.btn_Drk2LoadSelectedSave.Text = "Load Selected Save";
            this.btn_Drk2LoadSelectedSave.UseVisualStyleBackColor = true;
            // 
            // btn_Drk2BackupCurrentSave
            // 
            this.btn_Drk2BackupCurrentSave.Location = new System.Drawing.Point(9, 73);
            this.btn_Drk2BackupCurrentSave.Name = "btn_Drk2BackupCurrentSave";
            this.btn_Drk2BackupCurrentSave.Size = new System.Drawing.Size(125, 23);
            this.btn_Drk2BackupCurrentSave.TabIndex = 6;
            this.btn_Drk2BackupCurrentSave.Text = "Backup Current Save";
            this.btn_Drk2BackupCurrentSave.UseVisualStyleBackColor = true;
            // 
            // btn_Drk2SavBrowse
            // 
            this.btn_Drk2SavBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Drk2SavBrowse.Location = new System.Drawing.Point(655, 23);
            this.btn_Drk2SavBrowse.Name = "btn_Drk2SavBrowse";
            this.btn_Drk2SavBrowse.Size = new System.Drawing.Size(65, 23);
            this.btn_Drk2SavBrowse.TabIndex = 5;
            this.btn_Drk2SavBrowse.Text = "Browse";
            this.btn_Drk2SavBrowse.UseVisualStyleBackColor = true;
            // 
            // txt_Drk2SaveLoc
            // 
            this.txt_Drk2SaveLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Drk2SaveLoc.Location = new System.Drawing.Point(88, 25);
            this.txt_Drk2SaveLoc.Name = "txt_Drk2SaveLoc";
            this.txt_Drk2SaveLoc.ReadOnly = true;
            this.txt_Drk2SaveLoc.Size = new System.Drawing.Size(561, 20);
            this.txt_Drk2SaveLoc.TabIndex = 3;
            // 
            // lbl_Drk2Sav
            // 
            this.lbl_Drk2Sav.AutoSize = true;
            this.lbl_Drk2Sav.Location = new System.Drawing.Point(6, 28);
            this.lbl_Drk2Sav.Name = "lbl_Drk2Sav";
            this.lbl_Drk2Sav.Size = new System.Drawing.Size(76, 13);
            this.lbl_Drk2Sav.TabIndex = 4;
            this.lbl_Drk2Sav.Text = "Save Location";
            // 
            // grp_Drk1
            // 
            this.grp_Drk1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Drk1.Controls.Add(this.btn_Drk1ClearBackups);
            this.grp_Drk1.Controls.Add(this.lbl_Drk1Warn);
            this.grp_Drk1.Controls.Add(this.lstBox_Drk1SaveGames);
            this.grp_Drk1.Controls.Add(this.btn_Drk1LoadSelectedSave);
            this.grp_Drk1.Controls.Add(this.btn_Drk1SavBrowse);
            this.grp_Drk1.Controls.Add(this.btn_Drk1BackupCurrentSave);
            this.grp_Drk1.Controls.Add(this.lbl_Drk1Sav);
            this.grp_Drk1.Controls.Add(this.txt_Drk1SaveLoc);
            this.grp_Drk1.Location = new System.Drawing.Point(12, 12);
            this.grp_Drk1.Name = "grp_Drk1";
            this.grp_Drk1.Size = new System.Drawing.Size(741, 198);
            this.grp_Drk1.TabIndex = 2;
            this.grp_Drk1.TabStop = false;
            this.grp_Drk1.Text = "Dark Souls";
            // 
            // lstBox_Drk1SaveGames
            // 
            this.lstBox_Drk1SaveGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBox_Drk1SaveGames.FormattingEnabled = true;
            this.lstBox_Drk1SaveGames.Location = new System.Drawing.Point(6, 103);
            this.lstBox_Drk1SaveGames.Name = "lstBox_Drk1SaveGames";
            this.lstBox_Drk1SaveGames.Size = new System.Drawing.Size(729, 82);
            this.lstBox_Drk1SaveGames.TabIndex = 10;
            // 
            // btn_Drk1LoadSelectedSave
            // 
            this.btn_Drk1LoadSelectedSave.Location = new System.Drawing.Point(140, 75);
            this.btn_Drk1LoadSelectedSave.Name = "btn_Drk1LoadSelectedSave";
            this.btn_Drk1LoadSelectedSave.Size = new System.Drawing.Size(125, 23);
            this.btn_Drk1LoadSelectedSave.TabIndex = 9;
            this.btn_Drk1LoadSelectedSave.Text = "Load Selected Save";
            this.btn_Drk1LoadSelectedSave.UseVisualStyleBackColor = true;
            this.btn_Drk1LoadSelectedSave.Click += new System.EventHandler(this.btn_Drk1LoadSelectedSave_Click);
            // 
            // btn_Drk1SavBrowse
            // 
            this.btn_Drk1SavBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Drk1SavBrowse.Location = new System.Drawing.Point(655, 21);
            this.btn_Drk1SavBrowse.Name = "btn_Drk1SavBrowse";
            this.btn_Drk1SavBrowse.Size = new System.Drawing.Size(65, 23);
            this.btn_Drk1SavBrowse.TabIndex = 2;
            this.btn_Drk1SavBrowse.Text = "Browse";
            this.btn_Drk1SavBrowse.UseVisualStyleBackColor = true;
            this.btn_Drk1SavBrowse.Click += new System.EventHandler(this.btn_Drk1SavBrowse_Click);
            // 
            // btn_Drk1BackupCurrentSave
            // 
            this.btn_Drk1BackupCurrentSave.Location = new System.Drawing.Point(9, 75);
            this.btn_Drk1BackupCurrentSave.Name = "btn_Drk1BackupCurrentSave";
            this.btn_Drk1BackupCurrentSave.Size = new System.Drawing.Size(125, 23);
            this.btn_Drk1BackupCurrentSave.TabIndex = 8;
            this.btn_Drk1BackupCurrentSave.Text = "Backup Current Save";
            this.btn_Drk1BackupCurrentSave.UseVisualStyleBackColor = true;
            this.btn_Drk1BackupCurrentSave.Click += new System.EventHandler(this.btn_Drk1BackupCurrentSave_Click);
            // 
            // lbl_Drk1Sav
            // 
            this.lbl_Drk1Sav.AutoSize = true;
            this.lbl_Drk1Sav.Location = new System.Drawing.Point(6, 26);
            this.lbl_Drk1Sav.Name = "lbl_Drk1Sav";
            this.lbl_Drk1Sav.Size = new System.Drawing.Size(76, 13);
            this.lbl_Drk1Sav.TabIndex = 1;
            this.lbl_Drk1Sav.Text = "Save Location";
            // 
            // txt_Drk1SaveLoc
            // 
            this.txt_Drk1SaveLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Drk1SaveLoc.Location = new System.Drawing.Point(88, 23);
            this.txt_Drk1SaveLoc.Name = "txt_Drk1SaveLoc";
            this.txt_Drk1SaveLoc.ReadOnly = true;
            this.txt_Drk1SaveLoc.Size = new System.Drawing.Size(561, 20);
            this.txt_Drk1SaveLoc.TabIndex = 0;
            // 
            // lbl_Drk1Warn
            // 
            this.lbl_Drk1Warn.AutoSize = true;
            this.lbl_Drk1Warn.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Drk1Warn.ForeColor = System.Drawing.Color.Red;
            this.lbl_Drk1Warn.Location = new System.Drawing.Point(85, 46);
            this.lbl_Drk1Warn.Name = "lbl_Drk1Warn";
            this.lbl_Drk1Warn.Size = new System.Drawing.Size(35, 13);
            this.lbl_Drk1Warn.TabIndex = 11;
            this.lbl_Drk1Warn.Text = "label1";
            this.lbl_Drk1Warn.Visible = false;
            // 
            // lbl_Drk2Warn
            // 
            this.lbl_Drk2Warn.AutoSize = true;
            this.lbl_Drk2Warn.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Drk2Warn.ForeColor = System.Drawing.Color.Red;
            this.lbl_Drk2Warn.Location = new System.Drawing.Point(85, 48);
            this.lbl_Drk2Warn.Name = "lbl_Drk2Warn";
            this.lbl_Drk2Warn.Size = new System.Drawing.Size(35, 13);
            this.lbl_Drk2Warn.TabIndex = 12;
            this.lbl_Drk2Warn.Text = "label2";
            this.lbl_Drk2Warn.Visible = false;
            // 
            // btn_Drk1ClearBackups
            // 
            this.btn_Drk1ClearBackups.Location = new System.Drawing.Point(271, 74);
            this.btn_Drk1ClearBackups.Name = "btn_Drk1ClearBackups";
            this.btn_Drk1ClearBackups.Size = new System.Drawing.Size(116, 23);
            this.btn_Drk1ClearBackups.TabIndex = 12;
            this.btn_Drk1ClearBackups.Text = "Clear Backups";
            this.btn_Drk1ClearBackups.UseVisualStyleBackColor = true;
            this.btn_Drk1ClearBackups.Click += new System.EventHandler(this.btn_Drk1ClearBackups_Click);
            // 
            // btn_Drk2ClearBackups
            // 
            this.btn_Drk2ClearBackups.Location = new System.Drawing.Point(271, 73);
            this.btn_Drk2ClearBackups.Name = "btn_Drk2ClearBackups";
            this.btn_Drk2ClearBackups.Size = new System.Drawing.Size(116, 23);
            this.btn_Drk2ClearBackups.TabIndex = 13;
            this.btn_Drk2ClearBackups.Text = "Clear Backups";
            this.btn_Drk2ClearBackups.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(765, 446);
            this.Controls.Add(this.grp_Drk1);
            this.Controls.Add(this.grp_Drk2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Dark Souls Save Backup";
            this.grp_Drk2.ResumeLayout(false);
            this.grp_Drk2.PerformLayout();
            this.grp_Drk1.ResumeLayout(false);
            this.grp_Drk1.PerformLayout();
            this.ResumeLayout(false);

        }

        private ListBox lstBox_Drk2SaveGames;
        private Button btn_Drk2LoadSelectedSave;
        private ListBox lstBox_Drk1SaveGames;
        private Button btn_Drk1LoadSelectedSave;
        private Button btn_Drk1BackupCurrentSave;
        private Label lbl_Drk2Warn;
        private Label lbl_Drk1Warn;
        private Button btn_Drk2ClearBackups;
        private Button btn_Drk1ClearBackups;
    }
}