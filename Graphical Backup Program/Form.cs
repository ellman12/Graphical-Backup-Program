using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //If both of these are disabled, don't allow user to push buttons cuz that doesn't make sense.
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
    }
}
