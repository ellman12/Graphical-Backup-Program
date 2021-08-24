using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSystem = Microsoft.VisualBasic.FileIO.FileSystem;
using Timer = System.Threading.Timer;

namespace Graphical_Backup_Program
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly string _projectDirectory;
        private readonly string _configFilePath;
        private readonly string _pathsFilePath;

        public Form()
        {
            //https://stackoverflow.com/questions/1343053/detecting-if-a-program-was-run-by-visual-studio-as-opposed-to-run-from-windows
            //https://stackoverflow.com/a/11882118
            //The folder structure for where the .exe is stored varies between these two.
            //If you're compiling and running this through Visual Studio 2019, this ↓ needs to be used. If you're running this .exe outside of VS, use this ↓.
            _projectDirectory = Debugger.IsAttached ? Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName : Environment.CurrentDirectory;

            _configFilePath = _projectDirectory + "/config.txt"; //I added these cuz all the "_projectDirectory + "/config.txt"" everywhere seemed inefficient and dumb.
            _pathsFilePath = _projectDirectory + "/paths.txt";

            InitializeComponent();
        }

        //Represents a single path in the paths TextBox plus its group number.
        private readonly struct GroupPath
        {
            public readonly char group;
            public readonly string path;

            public GroupPath(char g, string p)
            {
                group = g;
                path = p;
            }
        }

        private void LogAppend(string text)
        {
            //_logText += text;
        }

        //Used in the foreach loops in the 2 backup button functions for determining which action to take.
        private void CopyOrOpenAndLog(string trimmedPath, string timestamp)
        {
            //if (backupModeBtn.Checked)
            //{
            //Copy each item to path1 and/or path2, as long as the box is checked AND the TextBox isn't blank.
            //if (path1CheckBox.Checked && path1TextBox.Text != String.Empty)
            //CopyAndLog(trimmedPath, path1TextBox.Text, 1, timestamp);

            //if (path2CheckBox.Checked && path2TextBox.Text != String.Empty)
            //CopyAndLog(trimmedPath, path2TextBox.Text, 2, timestamp);
            //}
            //else if (fileExplorerBtn.Checked)
            //OpenInExplorer(trimmedPath);
        }

        //Used for copying a single item to path1 and/or path2, and for putting some log output in the paths TextBox. pathNum is either 1 or 2.
        private void CopyAndLog(string src, string dest, int pathNum, string timestamp)
        {
            //            src = src.Trim(); //Remove pesky whitespace from start and end of path.

            //            //If user wants stuff to be copied to a special timestamp folder, this is where it's done at.
            //            //It also marks this backup folder as a "Common" or "Full" backup.
            //            if (createTimestampFolderBtn.Checked)
            //            {
            //                if (_backupType is "Common")
            //                    dest = Path.Combine(dest, "GBP Backup " + timestamp + " (Common Items)");
            //                else if (_backupType is "Full")
            //                    dest = Path.Combine(dest, "GBP Backup " + timestamp + " (All Items)");
            //            }

            //            if (Path.HasExtension(src)) //if a file
            //            {
            //                string srcFileName = Path.GetFileName(src);
            //                string finalDest = Path.Combine(dest, srcFileName);

            //                if (!Directory.Exists(dest))
            //                    Directory.CreateDirectory(dest);

            //                try
            //                {
            //                    File.Copy(src, finalDest);
            //                }
            //                catch (DirectoryNotFoundException e)
            //                {
            //                    LogAppend("ERROR when trying to copy file " + src + "\r\nCould not find path. Did you enter the path correctly?\r\n" + e.Message + Environment.NewLine);
            //                    return;
            //                }
            //                catch (IOException e)
            //                {
            //                    LogAppend("ERROR when trying to copy file " + src + "\r\nMost likely the path already exists\r\n" + e.Message + Environment.NewLine);
            //                    return;
            //                }
            //                catch (Exception e)
            //                {
            //                    LogAppend("ERROR: " + e.Message);
            //                }

            //                if (File.Exists(finalDest))
            //                    LogAppend("\r\nSuccessfully copied file " + src + " to path" + pathNum + "\r\n");
            //                else
            //                    LogAppend("\r\nERROR. File " + src + " was NOT successfully copied to path" + pathNum + "\r\n");
            //            }
            //            else //if a folder
            //            {
            //                //Get the name of the folder and copy stuff there. CopyDirectory() doesn't do that automatically for some reason... https://stackoverflow.com/a/5229311
            //                string dirName = new DirectoryInfo(src).Name;
            //                string fullPath = Path.Combine(dest, dirName);

            //                if (!Directory.Exists(dest))
            //                    Directory.CreateDirectory(dest);

            //                try
            //                {
            //                    FileSystem.CopyDirectory(src, fullPath); //https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.fileio.filesystem.copydirectory?view=net-5.0
            //                }
            //                catch (DirectoryNotFoundException e)
            //                {
            //                    LogAppend("ERROR when trying to copy folder " + src + "\r\nCould not find path. Did you enter the path correctly?\r\n" + e.Message + Environment.NewLine);
            //                    return;
            //                }
            //                catch (IOException e)
            //                {
            //                    LogAppend("ERROR when trying to copy folder " + src + "\r\nMost likely the path already exists\r\n\r\n" + e.Message + Environment.NewLine);
            //                    return;
            //                }
            //                catch (Exception e)
            //                {
            //                    LogAppend("ERROR: " + e.Message);
            //                }

            //                if (Directory.Exists(fullPath))
            //                    LogAppend("\r\nSuccessfully copied folder " + src + " to path" + pathNum + "\r\n");
            //                else
            //                    LogAppend("\r\nERROR. Folder " + src + " was NOT successfully copied to path" + pathNum + "\r\n");
            //            }
        }

        //When backup completes, open path1 and/or path2 in File Explorer if user checks the box to copy stuff there and to open it in File Explorer.
        private void ShowPath1And2(string timestamp)
        {
            //            if (fileExplorerBtn.Checked) return;

            //            if (path1CheckBox.Checked && openPath1Box.Checked)
            //                OpenInExplorer(createTimestampFolderBtn.Checked ? Path.Combine(path1TextBox.Text, "GBP backup " + timestamp) : path1TextBox.Text);

            //            if (path2CheckBox.Checked && openPath2Box.Checked)
            //                OpenInExplorer(createTimestampFolderBtn.Checked ? Path.Combine(path2TextBox.Text, "GBP backup " + timestamp) : path2TextBox.Text);
        }

        //Open an item in Explorer. https://stackoverflow.com/a/13680458
        private void OpenInExplorer(string path)
        {
            //            if (path != String.Empty)
            //            {
            //                path = Path.GetFullPath(path);
            //                Process.Start("explorer.exe", $"/select,\"{path}\"");
            //            }
            //        }

            //        //Delete a single directory, ignoring exception about it not existing/found.
            //        private void DeleteDirectory(string dir)
            //        {
            //            try
            //            {
            //                Directory.Delete(dir, true);
            //            }
            //            catch (UnauthorizedAccessException e)
            //            {
            //                MessageBox.Show("An error occurred: " + e.Message);
            //            }
            //            catch (DirectoryNotFoundException)
            //            {
            //                //Ignore error lol ;)
            //            }
            //        }

            //        private void DeletePath1AndOr2(bool clrPath1, bool clrPath2)
            //        {
            //            if (clrPath1)
            //                DeleteDirectory(path1TextBox.Text);
            //            if (clrPath2)
            //                DeleteDirectory(path2TextBox.Text);
        }

        //Does something based on which of the 3 buttons is selected.
        //Returns false if user presses 'Cancel'; true otherwise (false is what really matters).
        private bool ClearFolders()
        {
            //            bool clrPath1 = false, clrPath2 = false;
            //            if (path1CheckBox.Checked && path1TextBox.Text != String.Empty) clrPath1 = true;
            //            if (path2CheckBox.Checked && path2TextBox.Text != String.Empty) clrPath2 = true;

            //            if (autoClearRadio.Checked) //Clear them without any prompt/warning.
            //            {
            //                DeletePath1AndOr2(clrPath1, clrPath2);
            //            }
            //            else if (clearWithPromptRadio.Checked)
            //            {
            //                string text = "";
            //                if (clrPath1 && clrPath2) text = "Clear path1 and path2 before backing up?";
            //                else if (clrPath1) text = "Clear just path1 before backing up?";
            //                else if (clrPath2) text = "Clear just path2 before backing up?";
            //                DialogResult dialogResult = MessageBox.Show(text, "Clear Folders", MessageBoxButtons.YesNoCancel);

            //                if (dialogResult == DialogResult.Yes) //https://stackoverflow.com/a/3036851
            //                {
            //                    DeletePath1AndOr2(clrPath1, clrPath2);
            //                }
            //                else if (dialogResult == DialogResult.Cancel)
            //                    return false; //Signify pressing 'cancel' button.
            //            }
            return true;
        }

        //Yells at the user if they try to be an idiot and put the same path for path1 and 2 (but only if they're both checked).
        private bool SamePaths()
        {
            if (path1CheckBox.Checked && path2CheckBox.Checked)
            {
                if (path1TextBox.Text == path2TextBox.Text)
                {
                    MessageBox.Show("You cannot have the same path for path1 and path2!", "Error: Duplicate Paths", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        //Returns true if path1 or path2 is a file instead of a folder (as long as they're checked though).
        private bool Path1Or2Invalid()
        {
            if (path1CheckBox.Checked && Path.HasExtension(path1TextBox.Text))
            {
                MessageBox.Show("path1 cannot be a file!", "Error: File Path Specified for path1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (path2CheckBox.Checked && Path.HasExtension(path2TextBox.Text))
            {
                MessageBox.Show("path2 cannot be a file!", "Error: File Path Specified for path2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (path1CheckBox.Checked && path1TextBox.Text == String.Empty)
            {
                MessageBox.Show("If you want to copy items to path1, enter a folder path. If not, uncheck the box.", "Error: No folder path specified for path1 but box checked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (path2CheckBox.Checked && path2TextBox.Text == String.Empty)
            {
                MessageBox.Show("If you want to copy items to path2, enter a folder path. If not, uncheck the box.", "Error: No folder path specified for path2 but box checked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void AllPathsBtn_Click(object sender, EventArgs e)
        {
            //            //Idiot-proofing
            //            if (SamePaths()) return;
            //            if (Path1Or2Invalid()) return;

            //            TextBoxLabel.Hide();
            //            File.WriteAllText(_pathsFilePath, pathsTextBox.Text);
            //            if (ClearFolders() == false) //Cancel the backup and clearing of folders.
            //                return;

            //            allPathsBtn.Enabled = true;
            //            commonPathsBtn.Enabled = true;
            //            resetBtn.Enabled = false;

            //            _backupType = "Full";
            //            string timestamp = ""; //Create timestamp if needed.
            //            if (createTimestampFolderBtn.Checked)
            //                timestamp = DateTime.Now.ToString("M-d-yyyy hh;mm;ss tt"); //'/' and ':' won't work in paths because Windows.

            //            //When user wants to begin copying all C and U paths, go through line by line and determine which ones are marked C or U.
            //            string[] allPaths = pathsTextBox.Text.Split("\r\n");
            //            pathsTextBox.Text = backupModeBtn.Checked ? "Backing up all items..." : "Opening all items in File Explorer...";
            //            pathsTextBox.Text += "\r\n---------------------------------------------------------------------------------------------------------------------------------";

            //            List<Thread> threads = new();
            //            foreach (string path in allPaths)
            //            {
            //                string trimmedPath = path.Substring(2); //path without char and ' '.

            //                if (Char.ToLower(path[0]) is 'c' or 'u')
            //                {
            //                    Thread t = new(() => CopyOrOpenAndLog(trimmedPath, timestamp));
            //                    t.Start();
            //                    threads.Add(t);
            //                }
            //                else if (Char.ToLower(path[0]) is not '#')
            //                    LogAppend($"\r\nGBP cannot understand this line: \"{path}\"\r\n");
            //            }

            //            foreach (Thread thread in threads) //Wait for all threads to finish.
            //                thread.Join();

            //            LogAppend("---------------------------------------------------------------------------------------------------------------------------------\r\n");
            //            LogAppend(backupModeBtn.Checked ? "Backup completed" : "Opened all items");
            //            pathsTextBox.Text += _logText;
            //            allPathsBtn.Enabled = false;
            //            commonPathsBtn.Enabled = false;
            //            resetBtn.Enabled = true;
            //            ShowPath1And2(timestamp);
        }

        private void CommonPathsBtn_Click(object sender, EventArgs e)
        {
            ////Idiot-proofing
            //if (SamePaths()) return;
            //if (Path1Or2Invalid()) return;

            //TextBoxLabel.Hide();
            //File.WriteAllText(_pathsFilePath, pathsTextBox.Text);
            //if (ClearFolders() == false)
            //    return;

            //allPathsBtn.Enabled = true;
            //commonPathsBtn.Enabled = true;
            //resetBtn.Enabled = false;

            //_backupType = "Common";
            //string timestamp = "";
            //if (createTimestampFolderBtn.Checked)
            //    timestamp = DateTime.Now.ToString("M-d-yyyy hh;mm;ss tt"); //'/' and ':' won't work in paths because Windows.

            ////When user wants to begin copying just the Common Paths, go through line by line and determine which ones are marked 'common' (c).
            //string[] allPaths = pathsTextBox.Text.Split("\r\n");
            //pathsTextBox.Text = backupModeBtn.Checked ? "Backing up just common items..." : "Opening just common items in File Explorer...";
            //pathsTextBox.Text += "\r\n---------------------------------------------------------------------------------------------------------------------------------";

            //List<Thread> threads = new();
            //foreach (string path in allPaths)
            //{
            //    string trimmedPath = path.Substring(2); //path without char and ' '.

            //    if (Char.ToLower(path[0]) is 'c')
            //    {
            //        Thread t = new(() => CopyOrOpenAndLog(trimmedPath, timestamp));
            //        t.Start();
            //        threads.Add(t);
            //    }
            //    else if (Char.ToLower(path[0]) is not '#' and not 'u')
            //        LogAppend($"\r\nGBP cannot understand this line: \"{path}\"\r\n");
            //}

            //foreach (Thread thread in threads) //Wait for all threads to finish.
            //    thread.Join();

            //LogAppend("---------------------------------------------------------------------------------------------------------------------------------\r\n");
            //LogAppend(backupModeBtn.Checked ? "Common items backup completed" : "Opened all common items");
            //pathsTextBox.Text += _logText;
            //allPathsBtn.Enabled = false;
            //commonPathsBtn.Enabled = false;
            //resetBtn.Enabled = true;
            //ShowPath1And2(timestamp);
        }

        //For path1/2 CheckBoxes
        private void Path12CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //If both of these are disabled, don't allow user to push backup btn cuz that doesn't make any sense.
            if (path1CheckBox.Checked == false && path2CheckBox.Checked == false)
                backupBtn.Enabled = false;
            else
                backupBtn.Enabled = true;
        }

        //For path1/2 TextBoxes
        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void PathsTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        //On startup, assign GUI controls values from files, and disable any controls, if necessary.
        private void Form_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(_pathsFilePath))
                File.Create(_pathsFilePath);
            else
                pathsTextBox.Text = File.ReadAllText(_pathsFilePath);

            if (!File.Exists(_configFilePath))
            {
                FileStream file = File.Create(_configFilePath);
                file.Close();
            }

            //Read in config stuff. Is this extremely stupid and sub-optimal? Yes. Does it work? Also yes.
            string configFileTxt = File.ReadAllText(_configFilePath);

            //If config file has no text, write default values to file.
            if (configFileTxt == String.Empty)
            {
                const string defaultConfigValues = "false\r\nfalse\r\nfalse\r\nfalse\r\nfalse\r\nfalse\r\nfalse\r\nfalse\r\nfalse\r\nfalse\r\nUse these for...\r\n...labeling groups\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\ntrue\r\n\r\ntrue\r\nfalse\r\n\r\nfalse\r\nfalse\r\n\r\nfalse\r\nfalse\r\ntrue\r\nfalse";
                File.WriteAllText(_configFilePath, defaultConfigValues);
                configFileTxt = defaultConfigValues; //Process like normal, even though technically it didn't read anything in from the file.
            }

            string[] config = configFileTxt.Split("\r\n");
            checkBox0.Checked = Boolean.Parse(config[0]);
            checkBox1.Checked = Boolean.Parse(config[1]);
            checkBox2.Checked = Boolean.Parse(config[2]);
            checkBox3.Checked = Boolean.Parse(config[3]);
            checkBox4.Checked = Boolean.Parse(config[4]);
            checkBox5.Checked = Boolean.Parse(config[5]);
            checkBox6.Checked = Boolean.Parse(config[6]);
            checkBox7.Checked = Boolean.Parse(config[7]);
            checkBox8.Checked = Boolean.Parse(config[8]);
            checkBox9.Checked = Boolean.Parse(config[9]);
            textBox0.Text = config[10];
            textBox1.Text = config[11];
            textBox2.Text = config[12];
            textBox3.Text = config[13];
            textBox4.Text = config[14];
            textBox5.Text = config[15];
            textBox6.Text = config[16];
            textBox7.Text = config[17];
            textBox8.Text = config[18];
            textBox9.Text = config[19];
            path1CheckBox.Checked = Boolean.Parse(config[20]);
            path1TextBox.Text = config[21];
            openPath1Box.Checked = Boolean.Parse(config[22]);
            path2CheckBox.Checked = Boolean.Parse(config[23]);
            path2TextBox.Text = config[24];
            openPath2Box.Checked = Boolean.Parse(config[25]);
            urlCheckBox.Checked = Boolean.Parse(config[26]);
            urlTextBox.Text = config[27];
            zipCheckBox.Checked = Boolean.Parse(config[28]);
            autoClearRadio.Checked = Boolean.Parse(config[29]);
            clearWithPromptRadio.Checked = Boolean.Parse(config[30]);
            dontClearRadio.Checked = Boolean.Parse(config[31]);

            //if (pathsTextBox.Text == String.Empty || (path1TextBox.Text == String.Empty && path2TextBox.Text == String.Empty) || (path1CheckBox.Checked == false && path2CheckBox.Checked == false))
            //{
            //    backupBtn.Enabled = false;
            //    stripLabel.Text = "Enter at least 1 path to begin backup.";
            //}
            //else
            //{
            //    backupBtn.Enabled = true;
            //    stripLabel.Text = "Ready to backup";
            //}
        }

        //On exit, save config stuff for next time.
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveToFiles();
        }

        private void ClearPath1_Click(object sender, EventArgs e)
        {
            path1TextBox.Text = String.Empty;
            UpdateControls();
        }

        private void ClearPath2_Click(object sender, EventArgs e)
        {
            path2TextBox.Text = String.Empty;
            UpdateControls();
        }

        private void SaveToFiles()
        {
            File.WriteAllText(_pathsFilePath, pathsTextBox.Text);
            string configFileText = checkBox0.Checked + "\r\n" + checkBox1.Checked + "\r\n" + checkBox2.Checked + "\r\n" + checkBox3.Checked + "\r\n" + checkBox4.Checked + "\r\n" + checkBox5.Checked + "\r\n" + checkBox6.Checked + "\r\n" + checkBox7.Checked + "\r\n" + checkBox8.Checked + "\r\n" + checkBox9.Checked + "\r\n" + textBox0.Text + "\r\n" + textBox1.Text + "\r\n" + textBox2.Text + "\r\n" + textBox3.Text + "\r\n" + textBox4.Text + "\r\n" + textBox5.Text + "\r\n" + textBox6.Text + "\r\n" + textBox7.Text + "\r\n" + textBox8.Text + "\r\n" + textBox9.Text + "\r\n" + path1CheckBox.Checked + "\r\n" + path1TextBox.Text + "\r\n" + openPath1Box.Checked + "\r\n" + path2CheckBox.Checked + "\r\n" + path2TextBox.Text + "\r\n" + openPath2Box.Checked + "\r\n" + urlCheckBox.Checked + "\r\n" + urlTextBox.Text + "\r\n" + zipCheckBox.Checked + "\r\n" + autoClearRadio.Checked + "\r\n" + clearWithPromptRadio.Checked + "\r\n" + dontClearRadio.Checked;
            File.WriteAllText(_configFilePath, configFileText);
        }

        private void ToggleAllChecks(bool toggled)
        {
            checkBox0.Checked = toggled;
            checkBox1.Checked = toggled;
            checkBox2.Checked = toggled;
            checkBox3.Checked = toggled;
            checkBox4.Checked = toggled;
            checkBox5.Checked = toggled;
            checkBox6.Checked = toggled;
            checkBox7.Checked = toggled;
            checkBox8.Checked = toggled;
            checkBox9.Checked = toggled;
        }

        private void SelectAllBtn_Click(object sender, EventArgs e)
        {
            ToggleAllChecks(true);
            UpdateControls();
        }

        private void DeselectAllBtn_Click(object sender, EventArgs e)
        {
            ToggleAllChecks(false);
            UpdateControls();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            List<GroupPath> groupPaths = new();
            List<GroupPath> otherGroupPaths = new(); //Stores GroupPaths that aren't legal, like "# I am illegal"
            string[] lines = pathsTextBox.Text.Split("\r\n");

            foreach (string line in lines)
            {
                if (line == String.Empty || line.Length < 3) continue;
                string trimmed = line.Trim();
                char group = trimmed[0];
                string path = trimmed[2..];

                if (Char.GetNumericValue(group) >= 0 && Char.GetNumericValue(group) <= 9 && Char.IsNumber(trimmed[0]))
                    groupPaths.Add(new(group, path));
                else
                    otherGroupPaths.Add(new(group, path));
            }

            //I love how simple this is. Found on StackOverflow somewhere.
            groupPaths = groupPaths.OrderBy(g => g.group).ThenBy(g => g.path).ToList();
            otherGroupPaths = otherGroupPaths.OrderBy(g => g.group).ThenBy(g => g.path).ToList();
            pathsTextBox.Text = String.Empty;

            foreach (GroupPath groupPath in groupPaths)
                pathsTextBox.Text += groupPath.group + " " + groupPath.path + Environment.NewLine;

            foreach (GroupPath groupPath in otherGroupPaths)
                pathsTextBox.Text += groupPath.group + " " + groupPath.path + Environment.NewLine;
        }

        //Determines what text to put in the StatusStrip label and if the Backup Button needs to be disabled.
        private void UpdateControls()
        {
            if (pathsTextBox.Text == String.Empty)
            {
                stripLabel.Text = "Enter at least 1 path in the big TextBox that you want backed up.";
                backupBtn.Enabled = false;
            }

            //I don't like how long this is and how inefficient it seems.
            else if (checkBox0.Checked == false && checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false && checkBox7.Checked == false && checkBox8.Checked == false && checkBox9.Checked == false)
            {
                stripLabel.Text = "At least one group needs to be checked to begin backup";
                backupBtn.Enabled = false;
            }

            //If both of these are blank, don't allow user to push backup btn cuz that doesn't make any sense.
            else if (path1TextBox.Text == String.Empty && path2TextBox.Text == String.Empty)
            {
                stripLabel.Text = "Enter 1 or 2 paths where backup should be stored";
                backupBtn.Enabled = false;
            }

            else
            {
                stripLabel.Text = "Ready to begin backup";
                backupBtn.Enabled = true;
            }
        }

        //When any of the 10 group CheckBoxes are (un)checked.
        private void GroupCheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {

        }
    }
}