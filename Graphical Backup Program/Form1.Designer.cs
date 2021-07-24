
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
            this.AllFilesBtn = new System.Windows.Forms.Button();
            this.CommonFilesBtn = new System.Windows.Forms.Button();
            this.TextBoxLabel = new System.Windows.Forms.Label();
            this.pathsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AllFilesBtn
            // 
            this.AllFilesBtn.Location = new System.Drawing.Point(10, 254);
            this.AllFilesBtn.Name = "AllFilesBtn";
            this.AllFilesBtn.Size = new System.Drawing.Size(140, 40);
            this.AllFilesBtn.TabIndex = 0;
            this.AllFilesBtn.Text = "Backup All Files";
            this.AllFilesBtn.UseVisualStyleBackColor = true;
            // 
            // CommonFilesBtn
            // 
            this.CommonFilesBtn.Location = new System.Drawing.Point(150, 254);
            this.CommonFilesBtn.Name = "CommonFilesBtn";
            this.CommonFilesBtn.Size = new System.Drawing.Size(140, 40);
            this.CommonFilesBtn.TabIndex = 1;
            this.CommonFilesBtn.Text = "Backup Only Common Files";
            this.CommonFilesBtn.UseVisualStyleBackColor = true;
            // 
            // TextBoxLabel
            // 
            this.TextBoxLabel.AutoSize = true;
            this.TextBoxLabel.Location = new System.Drawing.Point(10, 3);
            this.TextBoxLabel.Name = "TextBoxLabel";
            this.TextBoxLabel.Size = new System.Drawing.Size(280, 15);
            this.TextBoxLabel.TabIndex = 2;
            this.TextBoxLabel.Text = "Paths to Backup. C for Common; U for Uncommon.";
            // 
            // pathsTextBox
            // 
            this.pathsTextBox.AcceptsReturn = true;
            this.pathsTextBox.Location = new System.Drawing.Point(10, 21);
            this.pathsTextBox.Multiline = true;
            this.pathsTextBox.Name = "pathsTextBox";
            this.pathsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pathsTextBox.Size = new System.Drawing.Size(280, 227);
            this.pathsTextBox.TabIndex = 3;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 497);
            this.Controls.Add(this.pathsTextBox);
            this.Controls.Add(this.TextBoxLabel);
            this.Controls.Add(this.CommonFilesBtn);
            this.Controls.Add(this.AllFilesBtn);
            this.Name = "Form";
            this.Text = "Graphical Backup Program (GBP)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AllFilesBtn;
        private System.Windows.Forms.Button CommonFilesBtn;
        private System.Windows.Forms.Label TextBoxLabel;
        private System.Windows.Forms.TextBox pathsTextBox;
    }
}

