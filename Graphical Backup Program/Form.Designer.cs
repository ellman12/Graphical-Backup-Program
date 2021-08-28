
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
            this.TextBoxLabel = new System.Windows.Forms.Label();
            this.pathsTextBox = new System.Windows.Forms.TextBox();
            this.whereToBackupBox = new System.Windows.Forms.GroupBox();
            this.path2Btn = new System.Windows.Forms.RadioButton();
            this.path1Btn = new System.Windows.Forms.RadioButton();
            this.zipCheckBox = new System.Windows.Forms.CheckBox();
            this.openOnComplete = new System.Windows.Forms.CheckBox();
            this.clearPath2 = new System.Windows.Forms.Button();
            this.clearPath1 = new System.Windows.Forms.Button();
            this.path2TextBox = new System.Windows.Forms.TextBox();
            this.path1TextBox = new System.Windows.Forms.TextBox();
            this.groupsGroupBox = new System.Windows.Forms.GroupBox();
            this.deselectAllBtn = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.selectAllBtn = new System.Windows.Forms.Button();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backupSizeLabelLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.numberLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.unitLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backupBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlCheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.whereToBackupBox.SuspendLayout();
            this.groupsGroupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxLabel
            // 
            this.TextBoxLabel.AutoSize = true;
            this.TextBoxLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxLabel.Location = new System.Drawing.Point(7, 3);
            this.TextBoxLabel.Name = "TextBoxLabel";
            this.TextBoxLabel.Size = new System.Drawing.Size(359, 15);
            this.TextBoxLabel.TabIndex = 2;
            this.TextBoxLabel.Text = "Paths to Backup. Add a path to a group by adding 0-9 in front of it.";
            // 
            // pathsTextBox
            // 
            this.pathsTextBox.AcceptsReturn = true;
            this.pathsTextBox.Location = new System.Drawing.Point(7, 21);
            this.pathsTextBox.Multiline = true;
            this.pathsTextBox.Name = "pathsTextBox";
            this.pathsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pathsTextBox.Size = new System.Drawing.Size(641, 207);
            this.pathsTextBox.TabIndex = 3;
            this.pathsTextBox.WordWrap = false;
            this.pathsTextBox.TextChanged += new System.EventHandler(this.PathsTextBox_TextChanged);
            this.pathsTextBox.Leave += new System.EventHandler(this.PathsTextBox_Leave);
            // 
            // whereToBackupBox
            // 
            this.whereToBackupBox.Controls.Add(this.path2Btn);
            this.whereToBackupBox.Controls.Add(this.path1Btn);
            this.whereToBackupBox.Controls.Add(this.zipCheckBox);
            this.whereToBackupBox.Controls.Add(this.openOnComplete);
            this.whereToBackupBox.Controls.Add(this.clearPath2);
            this.whereToBackupBox.Controls.Add(this.clearPath1);
            this.whereToBackupBox.Controls.Add(this.path2TextBox);
            this.whereToBackupBox.Controls.Add(this.path1TextBox);
            this.whereToBackupBox.Location = new System.Drawing.Point(7, 237);
            this.whereToBackupBox.Name = "whereToBackupBox";
            this.whereToBackupBox.Size = new System.Drawing.Size(641, 82);
            this.whereToBackupBox.TabIndex = 5;
            this.whereToBackupBox.TabStop = false;
            this.whereToBackupBox.Text = "Where to Backup";
            // 
            // path2Btn
            // 
            this.path2Btn.AutoSize = true;
            this.path2Btn.Location = new System.Drawing.Point(6, 51);
            this.path2Btn.Name = "path2Btn";
            this.path2Btn.Size = new System.Drawing.Size(83, 19);
            this.path2Btn.TabIndex = 18;
            this.path2Btn.Text = "Use Path 2:";
            this.path2Btn.UseVisualStyleBackColor = true;
            // 
            // path1Btn
            // 
            this.path1Btn.AutoSize = true;
            this.path1Btn.Checked = true;
            this.path1Btn.Location = new System.Drawing.Point(6, 20);
            this.path1Btn.Name = "path1Btn";
            this.path1Btn.Size = new System.Drawing.Size(83, 19);
            this.path1Btn.TabIndex = 17;
            this.path1Btn.TabStop = true;
            this.path1Btn.Text = "Use Path 1:";
            this.path1Btn.UseVisualStyleBackColor = true;
            // 
            // zipCheckBox
            // 
            this.zipCheckBox.AutoSize = true;
            this.zipCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zipCheckBox.Location = new System.Drawing.Point(502, 51);
            this.zipCheckBox.Name = "zipCheckBox";
            this.zipCheckBox.Size = new System.Drawing.Size(121, 19);
            this.zipCheckBox.TabIndex = 7;
            this.zipCheckBox.Text = "Compress Backup";
            this.zipCheckBox.UseVisualStyleBackColor = true;
            // 
            // openOnComplete
            // 
            this.openOnComplete.AutoSize = true;
            this.openOnComplete.Checked = true;
            this.openOnComplete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openOnComplete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.openOnComplete.Location = new System.Drawing.Point(502, 20);
            this.openOnComplete.Name = "openOnComplete";
            this.openOnComplete.Size = new System.Drawing.Size(138, 19);
            this.openOnComplete.TabIndex = 6;
            this.openOnComplete.Text = "Open on Completion";
            this.openOnComplete.UseVisualStyleBackColor = true;
            // 
            // clearPath2
            // 
            this.clearPath2.Location = new System.Drawing.Point(435, 48);
            this.clearPath2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearPath2.Name = "clearPath2";
            this.clearPath2.Size = new System.Drawing.Size(61, 25);
            this.clearPath2.TabIndex = 5;
            this.clearPath2.Text = "Clear";
            this.clearPath2.UseVisualStyleBackColor = true;
            this.clearPath2.Click += new System.EventHandler(this.ClearPath2_Click);
            // 
            // clearPath1
            // 
            this.clearPath1.Location = new System.Drawing.Point(435, 17);
            this.clearPath1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearPath1.Name = "clearPath1";
            this.clearPath1.Size = new System.Drawing.Size(61, 25);
            this.clearPath1.TabIndex = 4;
            this.clearPath1.Text = "Clear";
            this.clearPath1.UseVisualStyleBackColor = true;
            this.clearPath1.Click += new System.EventHandler(this.ClearPath1_Click);
            // 
            // path2TextBox
            // 
            this.path2TextBox.Location = new System.Drawing.Point(89, 49);
            this.path2TextBox.Name = "path2TextBox";
            this.path2TextBox.Size = new System.Drawing.Size(340, 23);
            this.path2TextBox.TabIndex = 3;
            this.path2TextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // path1TextBox
            // 
            this.path1TextBox.Location = new System.Drawing.Point(89, 18);
            this.path1TextBox.Name = "path1TextBox";
            this.path1TextBox.Size = new System.Drawing.Size(340, 23);
            this.path1TextBox.TabIndex = 1;
            this.path1TextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // groupsGroupBox
            // 
            this.groupsGroupBox.Controls.Add(this.deselectAllBtn);
            this.groupsGroupBox.Controls.Add(this.textBox9);
            this.groupsGroupBox.Controls.Add(this.checkBox9);
            this.groupsGroupBox.Controls.Add(this.textBox8);
            this.groupsGroupBox.Controls.Add(this.selectAllBtn);
            this.groupsGroupBox.Controls.Add(this.checkBox8);
            this.groupsGroupBox.Controls.Add(this.textBox7);
            this.groupsGroupBox.Controls.Add(this.checkBox7);
            this.groupsGroupBox.Controls.Add(this.textBox6);
            this.groupsGroupBox.Controls.Add(this.checkBox6);
            this.groupsGroupBox.Controls.Add(this.textBox5);
            this.groupsGroupBox.Controls.Add(this.checkBox5);
            this.groupsGroupBox.Controls.Add(this.textBox4);
            this.groupsGroupBox.Controls.Add(this.checkBox4);
            this.groupsGroupBox.Controls.Add(this.textBox3);
            this.groupsGroupBox.Controls.Add(this.checkBox3);
            this.groupsGroupBox.Controls.Add(this.textBox2);
            this.groupsGroupBox.Controls.Add(this.checkBox2);
            this.groupsGroupBox.Controls.Add(this.textBox1);
            this.groupsGroupBox.Controls.Add(this.checkBox1);
            this.groupsGroupBox.Controls.Add(this.textBox0);
            this.groupsGroupBox.Controls.Add(this.checkBox0);
            this.groupsGroupBox.Location = new System.Drawing.Point(654, 13);
            this.groupsGroupBox.Name = "groupsGroupBox";
            this.groupsGroupBox.Size = new System.Drawing.Size(160, 335);
            this.groupsGroupBox.TabIndex = 11;
            this.groupsGroupBox.TabStop = false;
            this.groupsGroupBox.Text = "Groups to Back up";
            // 
            // deselectAllBtn
            // 
            this.deselectAllBtn.Location = new System.Drawing.Point(80, 306);
            this.deselectAllBtn.Name = "deselectAllBtn";
            this.deselectAllBtn.Size = new System.Drawing.Size(77, 23);
            this.deselectAllBtn.TabIndex = 15;
            this.deselectAllBtn.Text = "Deselect All";
            this.deselectAllBtn.UseVisualStyleBackColor = true;
            this.deselectAllBtn.Click += new System.EventHandler(this.DeselectAllBtn_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(36, 278);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(118, 23);
            this.textBox9.TabIndex = 19;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(6, 281);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(32, 19);
            this.checkBox9.TabIndex = 18;
            this.checkBox9.Text = "9";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.GroupCheckBoxes_CheckedChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(36, 249);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(118, 23);
            this.textBox8.TabIndex = 17;
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.Location = new System.Drawing.Point(3, 306);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(77, 23);
            this.selectAllBtn.TabIndex = 13;
            this.selectAllBtn.Text = "Select All";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            this.selectAllBtn.Click += new System.EventHandler(this.SelectAllBtn_Click);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(6, 252);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(32, 19);
            this.checkBox8.TabIndex = 16;
            this.checkBox8.Text = "8";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.GroupCheckBoxes_CheckedChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(36, 221);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(118, 23);
            this.textBox7.TabIndex = 15;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(6, 224);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(32, 19);
            this.checkBox7.TabIndex = 14;
            this.checkBox7.Text = "7";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.GroupCheckBoxes_CheckedChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(36, 192);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(118, 23);
            this.textBox6.TabIndex = 13;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 195);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(32, 19);
            this.checkBox6.TabIndex = 12;
            this.checkBox6.Text = "6";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.GroupCheckBoxes_CheckedChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(36, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 23);
            this.textBox5.TabIndex = 11;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 166);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(32, 19);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.GroupCheckBoxes_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(36, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 23);
            this.textBox4.TabIndex = 9;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 137);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(32, 19);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.GroupCheckBoxes_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 23);
            this.textBox3.TabIndex = 7;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 108);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(32, 19);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.GroupCheckBoxes_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 23);
            this.textBox2.TabIndex = 5;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 79);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 19);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.GroupCheckBoxes_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "...labelling groups";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.GroupCheckBoxes_CheckedChanged);
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(36, 18);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(118, 23);
            this.textBox0.TabIndex = 1;
            this.textBox0.Text = "Use these for...";
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.Location = new System.Drawing.Point(6, 21);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(32, 19);
            this.checkBox0.TabIndex = 0;
            this.checkBox0.Text = "0";
            this.checkBox0.UseVisualStyleBackColor = true;
            this.checkBox0.CheckedChanged += new System.EventHandler(this.GroupCheckBoxes_CheckedChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel,
            this.backupSizeLabelLabel,
            this.numberLabel,
            this.unitLabel});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 362);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(822, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
            // 
            // stripLabel
            // 
            this.stripLabel.AutoSize = false;
            this.stripLabel.Name = "stripLabel";
            this.stripLabel.Size = new System.Drawing.Size(440, 17);
            this.stripLabel.Spring = true;
            this.stripLabel.Text = "Ready to Backup";
            this.stripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backupSizeLabelLabel
            // 
            this.backupSizeLabelLabel.Margin = new System.Windows.Forms.Padding(0, 3, -2, 2);
            this.backupSizeLabelLabel.Name = "backupSizeLabelLabel";
            this.backupSizeLabelLabel.Size = new System.Drawing.Size(72, 17);
            this.backupSizeLabelLabel.Text = "Backup Size:";
            // 
            // numberLabel
            // 
            this.numberLabel.Margin = new System.Windows.Forms.Padding(0, 3, -2, 2);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(13, 17);
            this.numberLabel.Text = "0";
            // 
            // unitLabel
            // 
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(35, 17);
            this.unitLabel.Text = "bytes";
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(547, 323);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(102, 32);
            this.backupBtn.TabIndex = 15;
            this.backupBtn.Text = "Backup";
            this.backupBtn.UseVisualStyleBackColor = true;
            this.backupBtn.Click += new System.EventHandler(this.BackupBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(442, 323);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(102, 32);
            this.sortBtn.TabIndex = 16;
            this.sortBtn.Text = "Sort Paths";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(173, 327);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(263, 23);
            this.urlTextBox.TabIndex = 9;
            // 
            // urlCheckBox
            // 
            this.urlCheckBox.AutoSize = true;
            this.urlCheckBox.Checked = true;
            this.urlCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.urlCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.urlCheckBox.Location = new System.Drawing.Point(13, 329);
            this.urlCheckBox.Name = "urlCheckBox";
            this.urlCheckBox.Size = new System.Drawing.Size(165, 19);
            this.urlCheckBox.TabIndex = 8;
            this.urlCheckBox.Text = "Open URL on Completion:";
            this.urlCheckBox.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(654, 367);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(160, 15);
            this.progressBar.TabIndex = 17;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 384);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.urlCheckBox);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.backupBtn);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupsGroupBox);
            this.Controls.Add(this.pathsTextBox);
            this.Controls.Add(this.whereToBackupBox);
            this.Controls.Add(this.TextBoxLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphical Backup Program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.whereToBackupBox.ResumeLayout(false);
            this.whereToBackupBox.PerformLayout();
            this.groupsGroupBox.ResumeLayout(false);
            this.groupsGroupBox.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextBoxLabel;
        private System.Windows.Forms.TextBox pathsTextBox;
        private System.Windows.Forms.GroupBox whereToBackupBox;
        private System.Windows.Forms.TextBox path2TextBox;
        private System.Windows.Forms.TextBox path1TextBox;
        private System.Windows.Forms.Button clearPath2;
        private System.Windows.Forms.Button clearPath1;
        private System.Windows.Forms.CheckBox openOnComplete;
        private System.Windows.Forms.GroupBox groupsGroupBox;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.CheckBox checkBox0;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel stripLabel;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button selectAllBtn;
        private System.Windows.Forms.Button deselectAllBtn;
        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.CheckBox urlCheckBox;
        private System.Windows.Forms.ToolStripStatusLabel numberLabel;
        private System.Windows.Forms.ToolStripStatusLabel backupSizeLabelLabel;
        private System.Windows.Forms.ToolStripStatusLabel unitLabel;
        private System.Windows.Forms.RadioButton path2Btn;
        private System.Windows.Forms.RadioButton path1Btn;
        private System.Windows.Forms.CheckBox zipCheckBox;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

