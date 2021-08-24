
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
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.zipCheckBox = new System.Windows.Forms.CheckBox();
            this.backupBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlCheckBox = new System.Windows.Forms.CheckBox();
            this.whereToBackupBox.SuspendLayout();
            this.clearingFoldersGroupBox.SuspendLayout();
            this.groupsGroupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxLabel
            // 
            this.TextBoxLabel.AutoSize = true;
            this.TextBoxLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxLabel.Location = new System.Drawing.Point(8, 4);
            this.TextBoxLabel.Name = "TextBoxLabel";
            this.TextBoxLabel.Size = new System.Drawing.Size(451, 20);
            this.TextBoxLabel.TabIndex = 2;
            this.TextBoxLabel.Text = "Paths to Backup. Add a path to a group by adding 0-9 in front of it.";
            // 
            // pathsTextBox
            // 
            this.pathsTextBox.AcceptsReturn = true;
            this.pathsTextBox.Location = new System.Drawing.Point(8, 28);
            this.pathsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathsTextBox.Multiline = true;
            this.pathsTextBox.Name = "pathsTextBox";
            this.pathsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pathsTextBox.Size = new System.Drawing.Size(732, 275);
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
            this.whereToBackupBox.Location = new System.Drawing.Point(8, 316);
            this.whereToBackupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.whereToBackupBox.Name = "whereToBackupBox";
            this.whereToBackupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.whereToBackupBox.Size = new System.Drawing.Size(733, 109);
            this.whereToBackupBox.TabIndex = 5;
            this.whereToBackupBox.TabStop = false;
            this.whereToBackupBox.Text = "Where to Backup";
            // 
            // openPath2Box
            // 
            this.openPath2Box.AutoSize = true;
            this.openPath2Box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.openPath2Box.Location = new System.Drawing.Point(574, 68);
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
            this.openPath1Box.Location = new System.Drawing.Point(574, 27);
            this.openPath1Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openPath1Box.Name = "openPath1Box";
            this.openPath1Box.Size = new System.Drawing.Size(170, 24);
            this.openPath1Box.TabIndex = 6;
            this.openPath1Box.Text = "Open on Completion";
            this.openPath1Box.UseVisualStyleBackColor = true;
            // 
            // clearPath2
            // 
            this.clearPath2.Location = new System.Drawing.Point(497, 64);
            this.clearPath2.Name = "clearPath2";
            this.clearPath2.Size = new System.Drawing.Size(70, 33);
            this.clearPath2.TabIndex = 5;
            this.clearPath2.Text = "Clear";
            this.clearPath2.UseVisualStyleBackColor = true;
            this.clearPath2.Click += new System.EventHandler(this.clearPath2_Click);
            // 
            // clearPath1
            // 
            this.clearPath1.Location = new System.Drawing.Point(497, 23);
            this.clearPath1.Name = "clearPath1";
            this.clearPath1.Size = new System.Drawing.Size(70, 33);
            this.clearPath1.TabIndex = 4;
            this.clearPath1.Text = "Clear";
            this.clearPath1.UseVisualStyleBackColor = true;
            this.clearPath1.Click += new System.EventHandler(this.clearPath1_Click);
            // 
            // path2TextBox
            // 
            this.path2TextBox.Location = new System.Drawing.Point(99, 65);
            this.path2TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path2TextBox.Name = "path2TextBox";
            this.path2TextBox.Size = new System.Drawing.Size(390, 27);
            this.path2TextBox.TabIndex = 3;
            this.path2TextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // path2CheckBox
            // 
            this.path2CheckBox.AutoSize = true;
            this.path2CheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.path2CheckBox.Location = new System.Drawing.Point(7, 68);
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
            this.path1TextBox.Location = new System.Drawing.Point(99, 24);
            this.path1TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path1TextBox.Name = "path1TextBox";
            this.path1TextBox.Size = new System.Drawing.Size(390, 27);
            this.path1TextBox.TabIndex = 1;
            this.path1TextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // path1CheckBox
            // 
            this.path1CheckBox.AutoSize = true;
            this.path1CheckBox.Checked = true;
            this.path1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.path1CheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.path1CheckBox.Location = new System.Drawing.Point(7, 27);
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
            this.clearingFoldersGroupBox.Location = new System.Drawing.Point(14, 472);
            this.clearingFoldersGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearingFoldersGroupBox.Name = "clearingFoldersGroupBox";
            this.clearingFoldersGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearingFoldersGroupBox.Size = new System.Drawing.Size(450, 61);
            this.clearingFoldersGroupBox.TabIndex = 0;
            this.clearingFoldersGroupBox.TabStop = false;
            this.clearingFoldersGroupBox.Text = "Clearing Backup Folders";
            // 
            // dontClearRadio
            // 
            this.dontClearRadio.AutoSize = true;
            this.dontClearRadio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dontClearRadio.Location = new System.Drawing.Point(305, 29);
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
            this.clearWithPromptRadio.Location = new System.Drawing.Point(160, 29);
            this.clearWithPromptRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearWithPromptRadio.Name = "clearWithPromptRadio";
            this.clearWithPromptRadio.Size = new System.Drawing.Size(149, 24);
            this.clearWithPromptRadio.TabIndex = 2;
            this.clearWithPromptRadio.Text = "Clear with Prompt";
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
            this.autoClearRadio.Size = new System.Drawing.Size(160, 24);
            this.autoClearRadio.TabIndex = 0;
            this.autoClearRadio.TabStop = true;
            this.autoClearRadio.Text = "Clear Automatically";
            this.autoClearRadio.UseVisualStyleBackColor = true;
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
            this.groupsGroupBox.Location = new System.Drawing.Point(747, 17);
            this.groupsGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupsGroupBox.Name = "groupsGroupBox";
            this.groupsGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupsGroupBox.Size = new System.Drawing.Size(183, 447);
            this.groupsGroupBox.TabIndex = 11;
            this.groupsGroupBox.TabStop = false;
            this.groupsGroupBox.Text = "Groups to Back up";
            // 
            // deselectAllBtn
            // 
            this.deselectAllBtn.Location = new System.Drawing.Point(91, 408);
            this.deselectAllBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deselectAllBtn.Name = "deselectAllBtn";
            this.deselectAllBtn.Size = new System.Drawing.Size(88, 31);
            this.deselectAllBtn.TabIndex = 15;
            this.deselectAllBtn.Text = "Deselect All";
            this.deselectAllBtn.UseVisualStyleBackColor = true;
            this.deselectAllBtn.Click += new System.EventHandler(this.deselectAllBtn_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(41, 371);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(134, 27);
            this.textBox9.TabIndex = 19;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(7, 375);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(39, 24);
            this.checkBox9.TabIndex = 18;
            this.checkBox9.Text = "9";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(41, 332);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(134, 27);
            this.textBox8.TabIndex = 17;
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.Location = new System.Drawing.Point(3, 408);
            this.selectAllBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(88, 31);
            this.selectAllBtn.TabIndex = 13;
            this.selectAllBtn.Text = "Select All";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            this.selectAllBtn.Click += new System.EventHandler(this.selectAllBtn_Click);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(7, 336);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(39, 24);
            this.checkBox8.TabIndex = 16;
            this.checkBox8.Text = "8";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(41, 295);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(134, 27);
            this.textBox7.TabIndex = 15;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(7, 299);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(39, 24);
            this.checkBox7.TabIndex = 14;
            this.checkBox7.Text = "7";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(41, 256);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(134, 27);
            this.textBox6.TabIndex = 13;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(7, 260);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(39, 24);
            this.checkBox6.TabIndex = 12;
            this.checkBox6.Text = "6";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(41, 217);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 27);
            this.textBox5.TabIndex = 11;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 221);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(39, 24);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(41, 179);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 27);
            this.textBox4.TabIndex = 9;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 183);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(39, 24);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(41, 140);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 27);
            this.textBox3.TabIndex = 7;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 144);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(39, 24);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 101);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 27);
            this.textBox2.TabIndex = 5;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 105);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(39, 24);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "...labelling groups";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 67);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(39, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(41, 24);
            this.textBox0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(134, 27);
            this.textBox0.TabIndex = 1;
            this.textBox0.Text = "Use these for...";
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.Location = new System.Drawing.Point(7, 28);
            this.checkBox0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(39, 24);
            this.checkBox0.TabIndex = 0;
            this.checkBox0.Text = "0";
            this.checkBox0.UseVisualStyleBackColor = true;
            this.checkBox0.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel,
            this.progressBar});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 542);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(939, 27);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
            // 
            // stripLabel
            // 
            this.stripLabel.Name = "stripLabel";
            this.stripLabel.Size = new System.Drawing.Size(120, 21);
            this.stripLabel.Text = "Ready to Backup";
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Margin = new System.Windows.Forms.Padding(1, 3, 0, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(183, 21);
            // 
            // zipCheckBox
            // 
            this.zipCheckBox.AutoSize = true;
            this.zipCheckBox.Location = new System.Drawing.Point(582, 436);
            this.zipCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zipCheckBox.Name = "zipCheckBox";
            this.zipCheckBox.Size = new System.Drawing.Size(148, 24);
            this.zipCheckBox.TabIndex = 0;
            this.zipCheckBox.Text = "Compress Backup";
            this.zipCheckBox.UseVisualStyleBackColor = true;
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(706, 481);
            this.backupBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(229, 52);
            this.backupBtn.TabIndex = 15;
            this.backupBtn.Text = "Backup";
            this.backupBtn.UseVisualStyleBackColor = true;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(471, 481);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(229, 52);
            this.sortBtn.TabIndex = 16;
            this.sortBtn.Text = "Sort Paths";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(198, 433);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(300, 27);
            this.urlTextBox.TabIndex = 9;
            // 
            // urlCheckBox
            // 
            this.urlCheckBox.AutoSize = true;
            this.urlCheckBox.Checked = true;
            this.urlCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.urlCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.urlCheckBox.Location = new System.Drawing.Point(15, 436);
            this.urlCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.urlCheckBox.Name = "urlCheckBox";
            this.urlCheckBox.Size = new System.Drawing.Size(203, 24);
            this.urlCheckBox.TabIndex = 8;
            this.urlCheckBox.Text = "Open URL on Completion:";
            this.urlCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.urlCheckBox);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.backupBtn);
            this.Controls.Add(this.zipCheckBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupsGroupBox);
            this.Controls.Add(this.pathsTextBox);
            this.Controls.Add(this.whereToBackupBox);
            this.Controls.Add(this.clearingFoldersGroupBox);
            this.Controls.Add(this.TextBoxLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphical Backup Program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.whereToBackupBox.ResumeLayout(false);
            this.whereToBackupBox.PerformLayout();
            this.clearingFoldersGroupBox.ResumeLayout(false);
            this.clearingFoldersGroupBox.PerformLayout();
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
        private System.Windows.Forms.CheckBox path2CheckBox;
        private System.Windows.Forms.TextBox path1TextBox;
        private System.Windows.Forms.CheckBox path1CheckBox;
        private System.Windows.Forms.GroupBox clearingFoldersGroupBox;
        private System.Windows.Forms.RadioButton dontClearRadio;
        private System.Windows.Forms.RadioButton clearWithPromptRadio;
        private System.Windows.Forms.RadioButton autoClearRadio;
        private System.Windows.Forms.Button clearPath2;
        private System.Windows.Forms.Button clearPath1;
        private System.Windows.Forms.CheckBox openPath2Box;
        private System.Windows.Forms.CheckBox openPath1Box;
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
        private System.Windows.Forms.CheckBox zipCheckBox;
        private System.Windows.Forms.Button deselectAllBtn;
        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.CheckBox urlCheckBox;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
    }
}

