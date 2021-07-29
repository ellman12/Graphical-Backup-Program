
namespace Graphical_Backup_Program
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.allPathsBtn = new System.Windows.Forms.Button();
            this.commonPathsBtn = new System.Windows.Forms.Button();
            this.TextBoxLabel = new System.Windows.Forms.Label();
            this.pathsTextBox = new System.Windows.Forms.TextBox();
            this.whereToBackupBox = new System.Windows.Forms.GroupBox();
            this.openPath2Box = new System.Windows.Forms.CheckBox();
            this.openPath1Box = new System.Windows.Forms.CheckBox();
            this.clearPath2 = new System.Windows.Forms.Button();
            this.clearPath1 = new System.Windows.Forms.Button();
            this.path2TextBox = new System.Windows.Forms.TextBox();
            this.path2CheckBox = new System.Windows.Forms.CheckBox();
            this.path1TextBox = new System.Windows.Forms.TextBox();
            this.path1CheckBox = new System.Windows.Forms.CheckBox();
            this.clearingFoldersGroupBox = new System.Windows.Forms.GroupBox();
            this.dontClearRadio = new System.Windows.Forms.RadioButton();
            this.clearWithPromptRadio = new System.Windows.Forms.RadioButton();
            this.autoClearRadio = new System.Windows.Forms.RadioButton();
            this.backupMode = new System.Windows.Forms.GroupBox();
            this.dontCreateFolderBtn = new System.Windows.Forms.RadioButton();
            this.createTimestampFolderBtn = new System.Windows.Forms.RadioButton();
            this.modeBox = new System.Windows.Forms.GroupBox();
            this.fileExplorerBtn = new System.Windows.Forms.RadioButton();
            this.backupModeBtn = new System.Windows.Forms.RadioButton();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.whereToBackupBox.SuspendLayout();
            this.clearingFoldersGroupBox.SuspendLayout();
            this.backupMode.SuspendLayout();
            this.modeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // allPathsBtn
            // 
            this.allPathsBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.allPathsBtn.Location = new System.Drawing.Point(8, 337);
            this.allPathsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allPathsBtn.Name = "allPathsBtn";
            this.allPathsBtn.Size = new System.Drawing.Size(254, 53);
            this.allPathsBtn.TabIndex = 0;
            this.allPathsBtn.Text = "Backup All Paths";
            this.allPathsBtn.UseVisualStyleBackColor = true;
            this.allPathsBtn.Click += new System.EventHandler(this.AllPathsBtn_Click);
            // 
            // commonPathsBtn
            // 
            this.commonPathsBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.commonPathsBtn.Location = new System.Drawing.Point(267, 337);
            this.commonPathsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commonPathsBtn.Name = "commonPathsBtn";
            this.commonPathsBtn.Size = new System.Drawing.Size(254, 53);
            this.commonPathsBtn.TabIndex = 1;
            this.commonPathsBtn.Text = "Backup Just Common Paths";
            this.commonPathsBtn.UseVisualStyleBackColor = true;
            this.commonPathsBtn.Click += new System.EventHandler(this.CommonPathsBtn_Click);
            // 
            // TextBoxLabel
            // 
            this.TextBoxLabel.AutoSize = true;
            this.TextBoxLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxLabel.Location = new System.Drawing.Point(8, 4);
            this.TextBoxLabel.Name = "TextBoxLabel";
            this.TextBoxLabel.Size = new System.Drawing.Size(535, 20);
            this.TextBoxLabel.TabIndex = 2;
            this.TextBoxLabel.Text = "Paths to Backup. C for Common, U for Uncommon, other characters are ignored.";
            // 
            // pathsTextBox
            // 
            this.pathsTextBox.AcceptsReturn = true;
            this.pathsTextBox.Location = new System.Drawing.Point(8, 28);
            this.pathsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathsTextBox.Multiline = true;
            this.pathsTextBox.Name = "pathsTextBox";
            this.pathsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pathsTextBox.Size = new System.Drawing.Size(772, 301);
            this.pathsTextBox.TabIndex = 3;
            this.pathsTextBox.WordWrap = false;
            this.pathsTextBox.TextChanged += new System.EventHandler(this.PathsTextBox_TextChanged);
            // 
            // whereToBackupBox
            // 
            this.whereToBackupBox.Controls.Add(this.openPath2Box);
            this.whereToBackupBox.Controls.Add(this.openPath1Box);
            this.whereToBackupBox.Controls.Add(this.clearPath2);
            this.whereToBackupBox.Controls.Add(this.clearPath1);
            this.whereToBackupBox.Controls.Add(this.path2TextBox);
            this.whereToBackupBox.Controls.Add(this.path2CheckBox);
            this.whereToBackupBox.Controls.Add(this.path1TextBox);
            this.whereToBackupBox.Controls.Add(this.path1CheckBox);
            this.whereToBackupBox.Location = new System.Drawing.Point(8, 421);
            this.whereToBackupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.whereToBackupBox.Name = "whereToBackupBox";
            this.whereToBackupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.whereToBackupBox.Size = new System.Drawing.Size(744, 103);
            this.whereToBackupBox.TabIndex = 5;
            this.whereToBackupBox.TabStop = false;
            this.whereToBackupBox.Text = "Where to Backup";
            // 
            // openPath2Box
            // 
            this.openPath2Box.AutoSize = true;
            this.openPath2Box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.openPath2Box.Location = new System.Drawing.Point(571, 67);
            this.openPath2Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openPath2Box.Name = "openPath2Box";
            this.openPath2Box.Size = new System.Drawing.Size(170, 24);
            this.openPath2Box.TabIndex = 7;
            this.openPath2Box.Text = "Open on Completion";
            this.openPath2Box.UseVisualStyleBackColor = true;
            // 
            // openPath1Box
            // 
            this.openPath1Box.AutoSize = true;
            this.openPath1Box.Checked = true;
            this.openPath1Box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openPath1Box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.openPath1Box.Location = new System.Drawing.Point(571, 26);
            this.openPath1Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openPath1Box.Name = "openPath1Box";
            this.openPath1Box.Size = new System.Drawing.Size(170, 24);
            this.openPath1Box.TabIndex = 6;
            this.openPath1Box.Text = "Open on Completion";
            this.openPath1Box.UseVisualStyleBackColor = true;
            // 
            // clearPath2
            // 
            this.clearPath2.Location = new System.Drawing.Point(495, 65);
            this.clearPath2.Name = "clearPath2";
            this.clearPath2.Size = new System.Drawing.Size(70, 27);
            this.clearPath2.TabIndex = 5;
            this.clearPath2.Text = "Clear";
            this.clearPath2.UseVisualStyleBackColor = true;
            this.clearPath2.Click += new System.EventHandler(this.clearPath2_Click);
            // 
            // clearPath1
            // 
            this.clearPath1.Location = new System.Drawing.Point(495, 24);
            this.clearPath1.Name = "clearPath1";
            this.clearPath1.Size = new System.Drawing.Size(70, 27);
            this.clearPath1.TabIndex = 4;
            this.clearPath1.Text = "Clear";
            this.clearPath1.UseVisualStyleBackColor = true;
            this.clearPath1.Click += new System.EventHandler(this.clearPath1_Click);
            // 
            // path2TextBox
            // 
            this.path2TextBox.Location = new System.Drawing.Point(104, 65);
            this.path2TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path2TextBox.Name = "path2TextBox";
            this.path2TextBox.Size = new System.Drawing.Size(385, 27);
            this.path2TextBox.TabIndex = 3;
            this.path2TextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // path2CheckBox
            // 
            this.path2CheckBox.AutoSize = true;
            this.path2CheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.path2CheckBox.Location = new System.Drawing.Point(3, 65);
            this.path2CheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path2CheckBox.Name = "path2CheckBox";
            this.path2CheckBox.Size = new System.Drawing.Size(102, 24);
            this.path2CheckBox.TabIndex = 2;
            this.path2CheckBox.Text = "Use Path 2:";
            this.path2CheckBox.UseVisualStyleBackColor = true;
            this.path2CheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // path1TextBox
            // 
            this.path1TextBox.Location = new System.Drawing.Point(104, 24);
            this.path1TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path1TextBox.Name = "path1TextBox";
            this.path1TextBox.Size = new System.Drawing.Size(385, 27);
            this.path1TextBox.TabIndex = 1;
            this.path1TextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // path1CheckBox
            // 
            this.path1CheckBox.AutoSize = true;
            this.path1CheckBox.Checked = true;
            this.path1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.path1CheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.path1CheckBox.Location = new System.Drawing.Point(3, 27);
            this.path1CheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path1CheckBox.Name = "path1CheckBox";
            this.path1CheckBox.Size = new System.Drawing.Size(102, 24);
            this.path1CheckBox.TabIndex = 0;
            this.path1CheckBox.Text = "Use Path 1:";
            this.path1CheckBox.UseVisualStyleBackColor = true;
            this.path1CheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // clearingFoldersGroupBox
            // 
            this.clearingFoldersGroupBox.Controls.Add(this.dontClearRadio);
            this.clearingFoldersGroupBox.Controls.Add(this.clearWithPromptRadio);
            this.clearingFoldersGroupBox.Controls.Add(this.autoClearRadio);
            this.clearingFoldersGroupBox.Location = new System.Drawing.Point(8, 532);
            this.clearingFoldersGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearingFoldersGroupBox.Name = "clearingFoldersGroupBox";
            this.clearingFoldersGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearingFoldersGroupBox.Size = new System.Drawing.Size(310, 123);
            this.clearingFoldersGroupBox.TabIndex = 0;
            this.clearingFoldersGroupBox.TabStop = false;
            this.clearingFoldersGroupBox.Text = "Clearing Backup Folders";
            // 
            // dontClearRadio
            // 
            this.dontClearRadio.AutoSize = true;
            this.dontClearRadio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dontClearRadio.Location = new System.Drawing.Point(6, 95);
            this.dontClearRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dontClearRadio.Name = "dontClearRadio";
            this.dontClearRadio.Size = new System.Drawing.Size(156, 24);
            this.dontClearRadio.TabIndex = 3;
            this.dontClearRadio.Text = "Don\'t Clear Folders";
            this.dontClearRadio.UseVisualStyleBackColor = true;
            // 
            // clearWithPromptRadio
            // 
            this.clearWithPromptRadio.AutoSize = true;
            this.clearWithPromptRadio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clearWithPromptRadio.Location = new System.Drawing.Point(6, 62);
            this.clearWithPromptRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearWithPromptRadio.Name = "clearWithPromptRadio";
            this.clearWithPromptRadio.Size = new System.Drawing.Size(201, 24);
            this.clearWithPromptRadio.TabIndex = 2;
            this.clearWithPromptRadio.Text = "Clear Folders with Prompt";
            this.clearWithPromptRadio.UseVisualStyleBackColor = true;
            // 
            // autoClearRadio
            // 
            this.autoClearRadio.AutoSize = true;
            this.autoClearRadio.Checked = true;
            this.autoClearRadio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.autoClearRadio.Location = new System.Drawing.Point(6, 28);
            this.autoClearRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.autoClearRadio.Name = "autoClearRadio";
            this.autoClearRadio.Size = new System.Drawing.Size(299, 24);
            this.autoClearRadio.TabIndex = 0;
            this.autoClearRadio.TabStop = true;
            this.autoClearRadio.Text = "Clear Folders Automatically (No Prompt)";
            this.autoClearRadio.UseVisualStyleBackColor = true;
            // 
            // backupMode
            // 
            this.backupMode.Controls.Add(this.dontCreateFolderBtn);
            this.backupMode.Controls.Add(this.createTimestampFolderBtn);
            this.backupMode.Location = new System.Drawing.Point(324, 532);
            this.backupMode.Name = "backupMode";
            this.backupMode.Size = new System.Drawing.Size(205, 86);
            this.backupMode.TabIndex = 7;
            this.backupMode.TabStop = false;
            this.backupMode.Text = "Backup Mode";
            // 
            // dontCreateFolderBtn
            // 
            this.dontCreateFolderBtn.AutoSize = true;
            this.dontCreateFolderBtn.Location = new System.Drawing.Point(6, 56);
            this.dontCreateFolderBtn.Name = "dontCreateFolderBtn";
            this.dontCreateFolderBtn.Size = new System.Drawing.Size(159, 24);
            this.dontCreateFolderBtn.TabIndex = 2;
            this.dontCreateFolderBtn.Text = "Don\'t Create Folder";
            this.dontCreateFolderBtn.UseVisualStyleBackColor = true;
            // 
            // createTimestampFolderBtn
            // 
            this.createTimestampFolderBtn.AutoSize = true;
            this.createTimestampFolderBtn.Checked = true;
            this.createTimestampFolderBtn.Location = new System.Drawing.Point(6, 26);
            this.createTimestampFolderBtn.Name = "createTimestampFolderBtn";
            this.createTimestampFolderBtn.Size = new System.Drawing.Size(197, 24);
            this.createTimestampFolderBtn.TabIndex = 2;
            this.createTimestampFolderBtn.TabStop = true;
            this.createTimestampFolderBtn.Text = "Create Timestamp Folder";
            this.createTimestampFolderBtn.UseVisualStyleBackColor = true;
            // 
            // modeBox
            // 
            this.modeBox.Controls.Add(this.fileExplorerBtn);
            this.modeBox.Controls.Add(this.backupModeBtn);
            this.modeBox.Location = new System.Drawing.Point(535, 532);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(197, 86);
            this.modeBox.TabIndex = 6;
            this.modeBox.TabStop = false;
            this.modeBox.Text = "GBP Mode";
            // 
            // fileExplorerBtn
            // 
            this.fileExplorerBtn.AutoSize = true;
            this.fileExplorerBtn.Location = new System.Drawing.Point(6, 54);
            this.fileExplorerBtn.Name = "fileExplorerBtn";
            this.fileExplorerBtn.Size = new System.Drawing.Size(190, 24);
            this.fileExplorerBtn.TabIndex = 1;
            this.fileExplorerBtn.Text = "Open All in File Explorer";
            this.fileExplorerBtn.UseVisualStyleBackColor = true;
            this.fileExplorerBtn.CheckedChanged += new System.EventHandler(this.fileExplorerBtn_CheckedChanged);
            // 
            // backupModeBtn
            // 
            this.backupModeBtn.AutoSize = true;
            this.backupModeBtn.Checked = true;
            this.backupModeBtn.Location = new System.Drawing.Point(6, 24);
            this.backupModeBtn.Name = "backupModeBtn";
            this.backupModeBtn.Size = new System.Drawing.Size(185, 24);
            this.backupModeBtn.TabIndex = 0;
            this.backupModeBtn.TabStop = true;
            this.backupModeBtn.Text = "Normal Mode (Backup)";
            this.backupModeBtn.UseVisualStyleBackColor = true;
            this.backupModeBtn.CheckedChanged += new System.EventHandler(this.backupModeBtn_CheckedChanged);
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Location = new System.Drawing.Point(8, 397);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(61, 20);
            this.optionsLabel.TabIndex = 8;
            this.optionsLabel.Text = "Options";
            // 
            // resetBtn
            // 
            this.resetBtn.Enabled = false;
            this.resetBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resetBtn.Location = new System.Drawing.Point(526, 337);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(254, 53);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "Reset GBP";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 663);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.backupMode);
            this.Controls.Add(this.modeBox);
            this.Controls.Add(this.pathsTextBox);
            this.Controls.Add(this.whereToBackupBox);
            this.Controls.Add(this.clearingFoldersGroupBox);
            this.Controls.Add(this.TextBoxLabel);
            this.Controls.Add(this.commonPathsBtn);
            this.Controls.Add(this.allPathsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Graphical Backup Program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.whereToBackupBox.ResumeLayout(false);
            this.whereToBackupBox.PerformLayout();
            this.clearingFoldersGroupBox.ResumeLayout(false);
            this.clearingFoldersGroupBox.PerformLayout();
            this.backupMode.ResumeLayout(false);
            this.backupMode.PerformLayout();
            this.modeBox.ResumeLayout(false);
            this.modeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allPathsBtn;
        private System.Windows.Forms.Button commonPathsBtn;
        private System.Windows.Forms.Label TextBoxLabel;
        private System.Windows.Forms.TextBox pathsTextBox;
        private System.Windows.Forms.GroupBox whereToBackupBox;
        private System.Windows.Forms.TextBox path2TextBox;
        private System.Windows.Forms.CheckBox path2CheckBox;
        private System.Windows.Forms.TextBox path1TextBox;
        private System.Windows.Forms.CheckBox path1CheckBox;
        private System.Windows.Forms.GroupBox clearingFoldersGroupBox;
        private System.Windows.Forms.RadioButton dontClearRadio;
        private System.Windows.Forms.RadioButton clearWithPromptRadio;
        private System.Windows.Forms.RadioButton autoClearRadio;
        private System.Windows.Forms.GroupBox modeBox;
        private System.Windows.Forms.RadioButton fileExplorerBtn;
        private System.Windows.Forms.RadioButton backupModeBtn;
        private System.Windows.Forms.GroupBox backupMode;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.RadioButton dontCreateFolderBtn;
        private System.Windows.Forms.RadioButton createTimestampFolderBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button clearPath2;
        private System.Windows.Forms.Button clearPath1;
        private System.Windows.Forms.CheckBox openPath2Box;
        private System.Windows.Forms.CheckBox openPath1Box;
    }
}

