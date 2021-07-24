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

namespace Graphical_Backup_Program
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        //Struct representing each path in the TextBox.
        public struct Path
        {
            public char type; //Either 'c' or 'u'
            public string path;

            public Path(char t, string p)
            {
                type = t;
                path = p;
            }
        }

        public Path[] CreateStructArray(string[] textBoxPaths)
        {
            throw new NotImplementedException();
            return new Path[10];
        }

        private void AllFilesBtn_Click(object sender, EventArgs e)
        {

        }

        private void CommonFilesBtn_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //If both of these are disabled, don't allow user to push buttons cuz that doesn't make any sense.
            if (path1CheckBox.Checked == false && path2CheckBox.Checked == false)
            {
                AllFilesBtn.Enabled = false;
                CommonFilesBtn.Enabled = false;
            }
            else
            {
                AllFilesBtn.Enabled = true;
                CommonFilesBtn.Enabled = true;
            }
        }

        public void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            //If both of these are blank, don't allow user to push buttons cuz that doesn't make any sense.
            if (path1TextBox.Text == string.Empty && path2TextBox.Text == string.Empty)
            {
                AllFilesBtn.Enabled = false;
                CommonFilesBtn.Enabled = false;
            }
            else
            {
                AllFilesBtn.Enabled = true;
                CommonFilesBtn.Enabled = true;
            }
        }

        private void PathsTextBox_TextChanged(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GBP", "paths.txt");
            File.WriteAllText(filePath, pathsTextBox.Text);
        }

        //Perform some necessary initialization stuff when program is ran.
        private void Form_Shown(object sender, EventArgs e)
        {
            //Create necessary folders and files, if they don't already exist.
            //Path to GBP folder in AppData/Local. Stores files used by GBP.
            string appDataPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GBP");
            if (!Directory.Exists(appDataPath))
                Directory.CreateDirectory(System.IO.Path.Combine(appDataPath));

            //Path to paths.txt in this ↑ folder. Stores what user wants backed up.
            //If exists already, pfor the paths in the TextBox.
            string pathsTxtPath = System.IO.Path.Combine(appDataPath, "paths.txt");
            if (!File.Exists(pathsTxtPath))
                File.Create(pathsTxtPath);
            else
                pathsTextBox.Text = File.ReadAllText(pathsTxtPath);

            //If the config file doesn't exist, create it. If it does, read its contents and apply them to the GUI.
            string configPath = System.IO.Path.Combine(appDataPath, "App.config");
            if (!File.Exists(configPath))
                File.Create(configPath);
            else
            {

            }
        }
    }
}
