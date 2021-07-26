using System;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;

namespace Graphical_Backup_Program
{
    public partial class Form : System.Windows.Forms.Form
    {
        //https://stackoverflow.com/a/11882118
        private readonly string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

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
            File.WriteAllText(_projectDirectory + "/paths.txt", pathsTextBox.Text);

            if (pathsTextBox.Text == string.Empty)
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

        //Perform some necessary initialization stuff when program is ran.
        private void Form_Shown(object sender, EventArgs e)
        {
            if (File.Exists(_projectDirectory + "/App.config"))
            {
                path1CheckBox.Checked = bool.Parse(ConfigurationManager.AppSettings.Get("path1Checked") ?? throw new InvalidOperationException()); //https://stackoverflow.com/questions/446835/what-do-two-question-marks-together-mean-in-c
                path1TextBox.Text = ConfigurationManager.AppSettings.Get("path1Text");
                path2CheckBox.Checked = bool.Parse(ConfigurationManager.AppSettings.Get("path2Checked") ?? throw new InvalidOperationException());
                path2TextBox.Text = ConfigurationManager.AppSettings.Get("path2Text");

                autoClearRadio.Checked = bool.Parse(ConfigurationManager.AppSettings.Get("autoClearRadioChecked") ?? throw new InvalidOperationException());
                clearWithPromptRadio.Checked = bool.Parse(ConfigurationManager.AppSettings.Get("clearWithPromptRadioChecked") ?? throw new InvalidOperationException());
                dontClearRadio.Checked = bool.Parse(ConfigurationManager.AppSettings.Get("dontClearRadioChecked") ?? throw new InvalidOperationException());
            }

            if (pathsTextBox.Text == string.Empty || (path1TextBox.Text == string.Empty && path2TextBox.Text == string.Empty) || (path1CheckBox.Checked == false && path2CheckBox.Checked == false))
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

        //On exit, write stuff to config file for next time.
        private void Form_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            File.WriteAllText(_projectDirectory + "/paths.txt", pathsTextBox.Text);

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["path1Checked"].Value = path1CheckBox.Checked.ToString();
            config.AppSettings.Settings["path1Text"].Value = path1TextBox.Text;
            config.AppSettings.Settings["path2Checked"].Value = path2CheckBox.Checked.ToString();
            config.AppSettings.Settings["path2Text"].Value = path2TextBox.Text;

            config.AppSettings.Settings["autoClearRadioChecked"].Value = autoClearRadio.Checked.ToString();
            config.AppSettings.Settings["clearWithPromptRadioChecked"].Value = clearWithPromptRadio.Checked.ToString();
            config.AppSettings.Settings["dontClearRadioChecked"].Value = dontClearRadio.Checked.ToString();

            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
