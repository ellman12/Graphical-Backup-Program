
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
            this.AllFilesBtn = new System.Windows.Forms.Button();
            this.CommonFilesBtn = new System.Windows.Forms.Button();
            this.TextBoxLabel = new System.Windows.Forms.Label();
            this.pathsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.whereToBackupBox = new System.Windows.Forms.GroupBox();
            this.path2TextBox = new System.Windows.Forms.TextBox();
            this.path2CheckBox = new System.Windows.Forms.CheckBox();
            this.path1TextBox = new System.Windows.Forms.TextBox();
            this.path1CheckBox = new System.Windows.Forms.CheckBox();
            this.clearingFoldersGroupBox = new System.Windows.Forms.GroupBox();
            this.dontClearRadio = new System.Windows.Forms.RadioButton();
            this.clearWithPromptRadio = new System.Windows.Forms.RadioButton();
            this.autoClearRadio = new System.Windows.Forms.RadioButton();
            this.whereToBackupBox.SuspendLayout();
            this.clearingFoldersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllFilesBtn
            // 
            this.AllFilesBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AllFilesBtn.Location = new System.Drawing.Point(8, 337);
            this.AllFilesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllFilesBtn.Name = "AllFilesBtn";
            this.AllFilesBtn.Size = new System.Drawing.Size(197, 53);
            this.AllFilesBtn.TabIndex = 0;
            this.AllFilesBtn.Text = "Backup All Files";
            this.AllFilesBtn.UseVisualStyleBackColor = true;
            this.AllFilesBtn.Click += new System.EventHandler(this.AllFilesBtn_Click);
            // 
            // CommonFilesBtn
            // 
            this.CommonFilesBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CommonFilesBtn.Location = new System.Drawing.Point(206, 337);
            this.CommonFilesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CommonFilesBtn.Name = "CommonFilesBtn";
            this.CommonFilesBtn.Size = new System.Drawing.Size(197, 53);
            this.CommonFilesBtn.TabIndex = 1;
            this.CommonFilesBtn.Text = "Backup Only Common Files";
            this.CommonFilesBtn.UseVisualStyleBackColor = true;
            this.CommonFilesBtn.Click += new System.EventHandler(this.CommonFilesBtn_Click);
            // 
            // TextBoxLabel
            // 
            this.TextBoxLabel.AutoSize = true;
            this.TextBoxLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxLabel.Location = new System.Drawing.Point(8, 4);
            this.TextBoxLabel.Name = "TextBoxLabel";
            this.TextBoxLabel.Size = new System.Drawing.Size(341, 20);
            this.TextBoxLabel.TabIndex = 2;
            this.TextBoxLabel.Text = "Paths to Backup. C for Common; U for Uncommon.";
            // 
            // pathsTextBox
            // 
            this.pathsTextBox.AcceptsReturn = true;
            this.pathsTextBox.Location = new System.Drawing.Point(8, 28);
            this.pathsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathsTextBox.Multiline = true;
            this.pathsTextBox.Name = "pathsTextBox";
            this.pathsTextBox.Size = new System.Drawing.Size(394, 301);
            this.pathsTextBox.TabIndex = 3;
            this.pathsTextBox.TextChanged += new System.EventHandler(this.PathsTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Options";
            // 
            // whereToBackupBox
            // 
            this.whereToBackupBox.Controls.Add(this.path2TextBox);
            this.whereToBackupBox.Controls.Add(this.path2CheckBox);
            this.whereToBackupBox.Controls.Add(this.path1TextBox);
            this.whereToBackupBox.Controls.Add(this.path1CheckBox);
            this.whereToBackupBox.Location = new System.Drawing.Point(8, 420);
            this.whereToBackupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.whereToBackupBox.Name = "whereToBackupBox";
            this.whereToBackupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.whereToBackupBox.Size = new System.Drawing.Size(394, 103);
            this.whereToBackupBox.TabIndex = 5;
            this.whereToBackupBox.TabStop = false;
            this.whereToBackupBox.Text = "Where to Backup";
            // 
            // path2TextBox
            // 
            this.path2TextBox.Location = new System.Drawing.Point(104, 65);
            this.path2TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path2TextBox.Name = "path2TextBox";
            this.path2TextBox.Size = new System.Drawing.Size(277, 27);
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
            this.path1TextBox.Size = new System.Drawing.Size(277, 27);
            this.path1TextBox.TabIndex = 1;
            this.path1TextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // path1CheckBox
            // 
            this.path1CheckBox.AutoSize = true;
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
            this.clearingFoldersGroupBox.Location = new System.Drawing.Point(8, 528);
            this.clearingFoldersGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearingFoldersGroupBox.Name = "clearingFoldersGroupBox";
            this.clearingFoldersGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearingFoldersGroupBox.Size = new System.Drawing.Size(394, 133);
            this.clearingFoldersGroupBox.TabIndex = 0;
            this.clearingFoldersGroupBox.TabStop = false;
            this.clearingFoldersGroupBox.Text = "Clearing Backup Folders";
            // 
            // dontClearRadio
            // 
            this.dontClearRadio.AutoSize = true;
            this.dontClearRadio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dontClearRadio.Location = new System.Drawing.Point(3, 96);
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
            this.clearWithPromptRadio.Location = new System.Drawing.Point(3, 63);
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
            this.autoClearRadio.Location = new System.Drawing.Point(3, 29);
            this.autoClearRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.autoClearRadio.Name = "autoClearRadio";
            this.autoClearRadio.Size = new System.Drawing.Size(299, 24);
            this.autoClearRadio.TabIndex = 0;
            this.autoClearRadio.TabStop = true;
            this.autoClearRadio.Text = "Clear Folders Automatically (No Prompt)";
            this.autoClearRadio.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 668);
            this.Controls.Add(this.clearingFoldersGroupBox);
            this.Controls.Add(this.whereToBackupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathsTextBox);
            this.Controls.Add(this.TextBoxLabel);
            this.Controls.Add(this.CommonFilesBtn);
            this.Controls.Add(this.AllFilesBtn);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AllFilesBtn;
        private System.Windows.Forms.Button CommonFilesBtn;
        private System.Windows.Forms.Label TextBoxLabel;
        private System.Windows.Forms.TextBox pathsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox whereToBackupBox;
        private System.Windows.Forms.TextBox path2TextBox;
        private System.Windows.Forms.CheckBox path2CheckBox;
        private System.Windows.Forms.TextBox path1TextBox;
        private System.Windows.Forms.CheckBox path1CheckBox;
        private System.Windows.Forms.GroupBox clearingFoldersGroupBox;
        private System.Windows.Forms.RadioButton dontClearRadio;
        private System.Windows.Forms.RadioButton clearWithPromptRadio;
        private System.Windows.Forms.RadioButton autoClearRadio;
    }
}

