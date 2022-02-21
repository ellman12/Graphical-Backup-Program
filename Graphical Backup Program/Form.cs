using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FileSystem = Microsoft.VisualBasic.FileIO.FileSystem;

namespace Graphical_Backup_Program
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string timestamp;
        private string logText;
        /// <summary>
        /// Provides reference/context to which directory this program is running from. If debugger is attached, set directory to base project directory. Else, set it to regular filepath of exe<para/>
        /// <see href="https://stackoverflow.com/questions/1343053/detecting-if-a-program-was-run-by-visual-studio-as-opposed-to-run-from-windows">Check if debugger is attached</see><para/>
        /// <see href="https://stackoverflow.com/a/11882118">Setting the directory depending on context (debugging or standalone exe)</see>
        /// </summary>
        private string projectDirectory { get { return Debugger.IsAttached ? Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName : Environment.CurrentDirectory; } }
        /// <summary>
        /// Reference to the config file location
        /// </summary>
        private string configFilePath { get { return projectDirectory + "/config.txt"; } }
        /// <summary>
        /// Reference to the paths file location
        /// </summary>
        private string pathsFilePath { get { return projectDirectory + "/paths.txt"; } }
        /// <summary>
        /// Reference to the log file
        /// </summary>
        private string logFilePath { get { return projectDirectory + "/GBP.log"; } }
        /// <summary>
        /// Divider line for use in the log file
        /// </summary>
        private const string dividerLine = "---------------------------------------------------------------------------------------------------";

        /// <summary>
        /// Program.cs enters here. Initialize components.
        /// </summary>
        public Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Represents a single path in the paths TextBox plus its group number.
        /// </summary>
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

        /// <summary>
        /// Append new text to the log
        /// </summary>
        /// <param name="text">The text to be appended</param>
        private void LogAppend(string text)
        {
            logText += text;
        }

        /// <summary>
        /// Verifies which path to back up to, and that the path string is not empty
        /// </summary>
        /// <param name="trimmedPath">The path without the group number at the beginning</param>
        private void CopyBackupPath(string trimmedPath)
        {
            if (path1Btn.Checked && path1TextBox.Text != String.Empty)
                CopyAndLog(trimmedPath, path1TextBox.Text, 1);
            else if (path2Btn.Checked && path2TextBox.Text != String.Empty)
                CopyAndLog(trimmedPath, path2TextBox.Text, 2);
        }

        /// <summary>
        /// Used for copying a single item to path1 or path2, and for putting some log output in the paths TextBox. pathNum is either 1 or 2.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        /// <param name="pathNum"></param>
        private void CopyAndLog(string src, string dest, int pathNum)
        {
            src = src.Trim(); //Remove pesky whitespace from start and end of path.
            dest = Path.Combine(dest, "GBP Backup " + timestamp);

            if (Path.HasExtension(src)) //if a file
            {
                string srcFileName = Path.GetFileName(src);
                string finalDest = Path.Combine(dest, srcFileName);

                if (!Directory.Exists(dest))
                    Directory.CreateDirectory(dest);

                try
                {
                    File.Copy(src, finalDest);
                }
                catch (DirectoryNotFoundException e)
                {
                    LogAppend("ERROR when trying to copy file " + src + "\r\nCould not find path. Did you enter the path correctly?\r\n" + e.Message + Environment.NewLine);
                    return;
                }
                catch (IOException e)
                {
                    LogAppend("ERROR when trying to copy file " + src + "\r\nMost likely the path already exists\r\n" + e.Message + Environment.NewLine);
                    return;
                }
                catch (Exception e)
                {
                    LogAppend("ERROR: " + e.Message);
                }

                if (File.Exists(finalDest))
                    LogAppend("\r\nSuccessfully copied file " + src + " to path" + pathNum + "\r\n");
                else
                    LogAppend("\r\nERROR. File " + src + " was NOT successfully copied to path" + pathNum + "\r\n");
            }
            else //if a folder
            {
                //Get the name of the folder and copy stuff there. CopyDirectory() doesn't do that automatically for some reason... https://stackoverflow.com/a/5229311
                string dirName = new DirectoryInfo(src).Name;
                string fullPath = Path.Combine(dest, dirName);

                if (!Directory.Exists(dest))
                    Directory.CreateDirectory(dest);

                try
                {
                    FileSystem.CopyDirectory(src, fullPath); //https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.fileio.filesystem.copydirectory?view=net-5.0
                }
                catch (DirectoryNotFoundException e)
                {
                    LogAppend("ERROR when trying to copy folder " + src + "\r\nCould not find path. Did you enter the path correctly?\r\n" + e.Message + Environment.NewLine);
                    return;
                }
                catch (IOException e)
                {
                    LogAppend("ERROR when trying to copy folder " + src + "\r\nMost likely the path already exists\r\n\r\n" + e.Message + Environment.NewLine);
                    return;
                }
                catch (Exception e)
                {
                    LogAppend("ERROR: " + e.Message);
                }

                if (Directory.Exists(fullPath))
                    LogAppend("\r\nSuccessfully copied folder " + src + " to path" + pathNum + "\r\n");
                else
                    LogAppend("\r\nERROR. Folder " + src + " was NOT successfully copied to path" + pathNum + "\r\n");
            }
        }

        /// <summary>
        /// When backup completes, open path1 and/or path2 in File Explorer if user checks the box to copy stuff there and to open it in File Explorer.
        /// </summary>
        private void ShowBackupPath()
        {
            if (openOnComplete.Checked)
            {
                if (path1Btn.Checked)
                    OpenInExplorer(zipCheckBox.Checked ? Path.Combine(path1TextBox.Text, "GBP Backup " + timestamp + ".zip") : Path.Combine(path1TextBox.Text, "GBP Backup " + timestamp));

                else if (path2Btn.Checked)
                    OpenInExplorer(zipCheckBox.Checked ? Path.Combine(path2TextBox.Text, "GBP Backup " + timestamp + ".zip") : Path.Combine(path2TextBox.Text, "GBP Backup " + timestamp));
            }
        }

        /// <summary>
        /// Open (and highlight) an item in Explorer.<para/>
        /// <see href="https://stackoverflow.com/a/13680458">Link to source.</see>
        /// </summary>
        /// <param name="path">The file path that needs to be opened</param>
        private static void OpenInExplorer(string path)
        {
            if (path != String.Empty)
            {
                path = Path.GetFullPath(path);
                Process.Start("explorer.exe", $"/select,\"{path}\"");
            }
        }

        /// <summary>
        /// Delete a single directory, ignoring exception about it not existing/found.
        /// </summary>
        /// <param name="dir">The directory to be deleted</param>
        /// <exception cref="UnauthorizedAccessException"/>
        /// <exception cref="DirectoryNotFoundException"/>
        private static void DeleteDirectory(string dir)
        {
            try
            {
                Directory.Delete(dir, true);
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("An error occurred: " + e.Message);
            }
            catch (DirectoryNotFoundException)
            {
                //Ignore error lol ;)
            }
        }

        /// <summary>
        /// If either/both clear path(s) are true, call DeleteDirectory() to delete all files in that directory
        /// </summary>
        /// <param name="clrPath1">If files and folders in path 1 need to be deleted</param>
        /// <param name="clrPath2">If files and folders in path 2 need to be deleted</param>
        private void DeletePath1AndOr2(bool clrPath1, bool clrPath2)
        {
            if (clrPath1)
                DeleteDirectory(path1TextBox.Text);
            if (clrPath2)
                DeleteDirectory(path2TextBox.Text);
        }

        /// <summary>
        /// Prompts the user with Yes/No/Cancel MessageBox if they would like to delete the contents of the folder defined by whichever path TextBox is checked
        /// </summary>
        /// <returns>
        /// True if the user accepted deletion of the contents of the folder before backup, or declined deletion before backup.<para/>
        /// False if the user cancels the backup.
        /// </returns>
        private bool ClearFolder()
        {
            //TODO: Rework the logic here. It is a bit redundant, and can probably be simplified.
            bool clrPath1 = false, clrPath2 = false;
            if (path1Btn.Checked && path1TextBox.Text != String.Empty) clrPath1 = true;
            if (path2Btn.Checked && path2TextBox.Text != String.Empty) clrPath2 = true;

            string text = "", caption = "";
            if (clrPath1)
            {
                text = $"Clear path1 ({path1TextBox.Text}) before backing up? This will delete all contents of \n{path1TextBox.Text}!!!";
                caption = "Clear path1?";
            }
            else if (clrPath2)
            {
                text = $"Clear path2 ({path2TextBox.Text}) before backing up? This will delete all contents of {path2TextBox.Text}!!!";
                caption = "Clear path2?";
            }

            DialogResult dialogResult = MessageBox.Show(text, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) //https://stackoverflow.com/a/3036851
                DeletePath1AndOr2(clrPath1, clrPath2); //User confirmed that they do want to clear path1/2, so do it.
            else if (dialogResult == DialogResult.Cancel)
                return false; //Signify pressing 'cancel' button.

            return true; //True means no errors happened or whatever.
        }

        /// <summary>
        /// Checks if a group is checkmarked/enabled
        /// </summary>
        /// <param name="group">The group to check</param>
        /// <returns>True if checked, false if not</returns>
        private bool GroupChecked(char group)
        {
			return group == '0' && checkBox0.Checked ||
                    group == '1' && checkBox1.Checked ||
                    group == '2' && checkBox2.Checked ||
                    group == '3' && checkBox3.Checked ||
                    group == '4' && checkBox4.Checked ||
                    group == '5' && checkBox5.Checked ||
                    group == '6' && checkBox6.Checked ||
                    group == '7' && checkBox7.Checked ||
                    group == '8' && checkBox8.Checked ||
                    group == '9' && checkBox9.Checked;
		}

		/// <summary>
		/// Quick check to make sure the group number is valid
		/// </summary>
		/// <param name="group">The group to check</param>
		/// <returns>True if valid, false if not</returns>
		private static bool ValidGroupChar(char group)
        {
            return (Char.GetNumericValue(group) >= 0 && Char.GetNumericValue(group) <= 9 && Char.IsNumber(group));
        }

        /// <summary>
        /// Opens a link in the default browser. Also checks for invalid ampersand char in URL, and attempts to correct it. <see href="https://stackoverflow.com/a/43232486">Reference for opening url in browser</see>
        /// </summary>
        /// <param name="url">The URL to attempt at opening</param>
        private static void OpenUrl(string url)
        {
			url = url.Replace("&", "^&"); //This is needed because command prompt needs to know that an ampersand in the url var is not to be parsed as a second command; it is part of the url

			if (url.StartsWith("http://"))
			{
                MessageBox.Show("The URL is not going to a secure version of the website, please double check the website loads as HTTPS", "SSL Site Not Requested", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else if (!url.StartsWith("https://"))
			{
                url = $"https://{url}";
			}

            //TODO: Possible malicious code execution point? are we parsing url well enough to prevent naughty commands?
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
        }

        /// <summary>
        /// Updates progress bar based on size of backup folder against the size of the folder to be backed up
        /// </summary>
        /// <param name="backupPath"></param>
        private void RunProgressBar(string backupPath)
        {
            double currentSize = 0;
            double finalSize = UpdateBackupSize();
            while (currentSize < finalSize)
            {
                currentSize = GetFolderSize(Path.Combine(backupPath, "GBP Backup " + timestamp));
                int progress = Convert.ToInt32((currentSize / finalSize) * 100);
                progressBar.Value = progress;
                TaskbarProgress.SetValue(Handle, progress, 100);
            }
        }

        /// <summary>
        /// Creates a compressed backup after all files/folders are copied to the backup folder
        /// </summary>
        /// <param name="textBoxText">Path of the Backup folder</param>
        /// <param name="pathNum">Only used in the log file to explain which pathTextBox was selected when backup was created</param>
        private void CompressBackup(string textBoxText, int pathNum)
        {
            string backupPath = Path.Combine(textBoxText, "GBP Backup " + timestamp);
            string zipPath = Path.Combine(textBoxText, "GBP Backup " + timestamp + ".zip");
            ZipFile.CreateFromDirectory(backupPath, zipPath);
            if (File.Exists(zipPath))
                LogAppend("\nSuccessfully compressed backup of path" + pathNum + '\n');
        }

        /// <summary>
        /// Ask the user if they want to delete the contents of the backup folder, then proceeds to create the backup if ClearFolder() returns true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackupBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(pathsFilePath, pathsTextBox.Text);
            if (ClearFolder() == false) //If user presses 'cancel' when asked if they want to clear, abort the entire process.
                return;

            backupBtn.Enabled = false;
            progressBar.Value = 0;
            timestamp = DateTime.Now.ToString("M-d-yyyy hh;mm;ss tt"); //'/' and ':' won't work in paths because Windows.
            logText = "GBP Backup " + timestamp + "\n" + dividerLine;
            stripLabel.Text = "Backing up...";

            string[] allPaths = pathsTextBox.Text.Split("\r\n");
            List<Thread> threads = new();

            foreach (string path in allPaths)
            {
                if (path == String.Empty) continue;

                string trimmedPath = path.Trim();
                char group = trimmedPath[0];
                trimmedPath = trimmedPath[2..];

                if (ValidGroupChar(group))
                {
                    if (GroupChecked(group))
                    {
                        Thread t = new(() => CopyBackupPath(trimmedPath));
                        t.Start();
                        threads.Add(t);
                    }
                }
                else if (Char.ToLower(path[0]) != '#') //# are used for comments
                    LogAppend($"\r\nGBP cannot understand this line: \"{path}\"\r\n");
            }

            if (path1Btn.Checked && path1TextBox.Text != String.Empty)
            {
                if (!Directory.Exists(Path.Combine(path1TextBox.Text, "GBP Backup " + timestamp)))
                    Directory.CreateDirectory(Path.Combine(path1TextBox.Text, "GBP Backup " + timestamp));
            }
            else if (path2Btn.Checked && path2TextBox.Text != String.Empty)
            {
                if (!Directory.Exists(Path.Combine(path2TextBox.Text, "GBP Backup " + timestamp)))
                    Directory.CreateDirectory(Path.Combine(path2TextBox.Text, "GBP Backup " + timestamp));
            }

            string backupPath = "";
            if (path1Btn.Checked && path1TextBox.Text != "")
                backupPath = path1TextBox.Text;
            else if (path2Btn.Checked && path2TextBox.Text != "")
                backupPath = path2TextBox.Text;

            Thread pThread = new(() => { progressBar.BeginInvoke(new Action(() => { RunProgressBar(backupPath); })); });
            pThread.Start();

            //This kind stranger's answer from long ago is how I finally got this stupid damn progress bar working after so, so very many hours... https://stackoverflow.com/a/1239662
            while (pThread.IsAlive)
                Application.DoEvents();

            pThread.Join();

            foreach (Thread thread in threads) //Wait for all threads to finish.
                thread.Join();

            if (urlCheckBox.Checked && urlTextBox.Text != "")
                OpenUrl(urlTextBox.Text);

            if (zipCheckBox.Checked)
            {
                if (path1Btn.Checked && path1TextBox.Text != "")
                    CompressBackup(path1TextBox.Text, 1);

                else if (path2Btn.Checked && path2TextBox.Text != "")
                    CompressBackup(path2TextBox.Text, 2);
            }

            ShowBackupPath();
            backupBtn.Enabled = true;
            stripLabel.Text = "Backup completed. Ready to exit or begin next backup.";
            LogAppend(dividerLine);

            File.WriteAllText(logFilePath, logText);
            Process.Start("notepad.exe", logFilePath); //Open log in Notepad.
        }

        /// <summary>
        /// Calls UpdateControls() when one of the two PathTextBoxes are changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        /// <summary>
        /// Gets the file size in bytes<para/>
        /// <see href="https://stackoverflow.com/questions/1380839/how-do-you-get-the-file-size-in-c/20863065">Get file size</see>
        /// </summary>
        /// <param name="path">The path of the file</param>
        /// <returns>Size in bytes</returns>
        private static long GetFileSize(string path)
        {
			if (File.Exists(path))
            {
                return new FileInfo(path).Length;
            }

			else
			{
                MessageBox.Show("Could not find file " + path, "Cannot Find File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// Gets the file sizes of all files in a folder<para/>
        /// <see href="https://stackoverflow.com/questions/12166404/how-do-i-get-folder-size-in-c">Get size of files in folder</see>
        /// </summary>
        /// <param name="path">The folder with the files to get the sizes</param>
        /// <returns>Size in bytes</returns>
        private static long GetFolderSize(string path)
        {
            try
            {
                DirectoryInfo di = new(path);

				if (di.Exists)
				{
                    return di.SafeGetFileInfosRecursive("*").Sum(x => x.Length);
                }

				else
				{
                    MessageBox.Show("Could not find folder " + path, "Cannot Find Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

			catch (UnauthorizedAccessException ex)
			{
                string errorPath = ex.Message;
                errorPath = errorPath.Substring(ex.Message.IndexOf('\'') + 1);
                errorPath = errorPath.Substring(0, errorPath.IndexOf('\''));

                MessageBox.Show("The user or program does not have permission to enter " + errorPath, "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

            return 0;
        }

        /// <summary>
        /// Calls UpdateControls() when the user changes something in the big PathsTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PathsTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        /// <summary>
        /// Gets the size of the backup as the user currently has it configured. Updates status strip with backup size, including setting the unit of measurement based on size.
        /// </summary>
        /// <returns>Backup size in bytes</returns>
        private double UpdateBackupSize()
        {
            double backupSize = 0;
            foreach (string line in pathsTextBox.Text.Split("\r\n"))
            {
                if (line == String.Empty || !GroupChecked(line[0])) continue;
                string path = line[2..];

                if (Path.HasExtension(path))
                    backupSize += GetFileSize(path);
                else
                    backupSize += GetFolderSize(path);
            }

            string unit;
            double convertedBackupSize;

            if (backupSize >= 1100000000000)
            {
                unit = "TB";
                convertedBackupSize = backupSize / 1100000000000;
            }
            else if (backupSize >= 1074000000)
            {
                unit = "GB";
                convertedBackupSize = backupSize / 1074000000;
            }
            else if (backupSize >= 1049000)
            {
                unit = "MB";
                convertedBackupSize = backupSize / 1049000;
            }
            else if (backupSize >= 1024)
            {
                unit = "KB";
                convertedBackupSize = backupSize / 1024;
            }
            else
            {
                unit = "bytes";
                convertedBackupSize = backupSize;
            }

            numberLabel.Text = Math.Round(convertedBackupSize, 3).ToString();
            unitLabel.Text = unit;

            return backupSize;
        }

        /// <summary>
        /// Event for when the user deselects the Paths To Backup TextBox, will call UpdateBackupSize()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PathsTextBox_Leave(object sender, EventArgs e)
        {
            UpdateBackupSize();
        }

        /// <summary>
        /// On startup, assign GUI controls values from files, and disable any controls, if necessary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(pathsFilePath))
                File.Create(pathsFilePath);
            else
                pathsTextBox.Text = File.ReadAllText(pathsFilePath);

            if (!File.Exists(configFilePath))
            {
                FileStream file = File.Create(configFilePath);
                file.Close();
            }

            if (!File.Exists(logFilePath))
            {
                FileStream file = File.Create(logFilePath);
                file.Close();
            }

            //TODO: Potentially convert the config file to XML for better usability/readability
            //Read in config stuff. Is this extremely stupid and sub-optimal? Yes. Does it work? Also yes.
            string configFileTxt = File.ReadAllText(configFilePath);

            //If config file has no text, write default values to file.
            if (configFileTxt == String.Empty)
            {
                const string defaultConfigValues = "false\r\nfalse\r\nfalse\r\nfalse\r\nfalse\r\nfalse\r\nfalse\r\nfalse\r\nfalse\r\nfalse\r\nUse these for...\r\n...labeling groups\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\ntrue\r\n\r\nfalse\r\n\r\ntrue\r\nfalse\r\n\r\nfalse";
                File.WriteAllText(configFilePath, defaultConfigValues);
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
            path1Btn.Checked = Boolean.Parse(config[20]);
            path1TextBox.Text = config[21];
            path2Btn.Checked = Boolean.Parse(config[22]);
            path2TextBox.Text = config[23];
            openOnComplete.Checked = Boolean.Parse(config[24]);
            urlCheckBox.Checked = Boolean.Parse(config[25]);
            urlTextBox.Text = config[26];
            zipCheckBox.Checked = Boolean.Parse(config[27]);

            UpdateBackupSize();
        }

        /// <summary>
        /// Calls SaveToFiles() before quitting application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveToFiles();
        }

        /// <summary>
        /// Clear the path1TextBox text, and UpdateControls()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearPath1_Click(object sender, EventArgs e)
        {
            path1TextBox.Text = String.Empty;
            UpdateControls();
        }

        /// <summary>
        /// Clear the path2TextBox text, and UpdateControls()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearPath2_Click(object sender, EventArgs e)
        {
            path2TextBox.Text = String.Empty;
            UpdateControls();
        }

        /// <summary>
        /// Save to the paths file, and save to the config file
        /// </summary>
        private void SaveToFiles()
        {
            File.WriteAllText(pathsFilePath, pathsTextBox.Text);
            string configFileText = checkBox0.Checked + "\r\n" + checkBox1.Checked + "\r\n" + checkBox2.Checked + "\r\n" + checkBox3.Checked + "\r\n" + checkBox4.Checked + "\r\n" + checkBox5.Checked + "\r\n" + checkBox6.Checked + "\r\n" + checkBox7.Checked + "\r\n" + checkBox8.Checked + "\r\n" + checkBox9.Checked + "\r\n" + textBox0.Text + "\r\n" + textBox1.Text + "\r\n" + textBox2.Text + "\r\n" + textBox3.Text + "\r\n" + textBox4.Text + "\r\n" + textBox5.Text + "\r\n" + textBox6.Text + "\r\n" + textBox7.Text + "\r\n" + textBox8.Text + "\r\n" + textBox9.Text + "\r\n" + path1Btn.Checked + "\r\n" + path1TextBox.Text + "\r\n" + path2Btn.Checked + "\r\n" + path2TextBox.Text + "\r\n" + openOnComplete.Checked + "\r\n" + urlCheckBox.Checked + "\r\n" + urlTextBox.Text + "\r\n" + zipCheckBox.Checked;
            File.WriteAllText(configFilePath, configFileText);
        }

        /// <summary>
        /// Sets all checkBoxes to true or false
        /// </summary>
        /// <param name="toggled">What to set the checkBoxes to</param>
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

        /// <summary>
        /// Sets all checkBoxes to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllBtn_Click(object sender, EventArgs e)
        {
            ToggleAllChecks(true);
            UpdateControls();
            UpdateBackupSize();
        }

        /// <summary>
        /// Sets all checkBoxes to false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeselectAllBtn_Click(object sender, EventArgs e)
        {
            ToggleAllChecks(false);
            UpdateControls();
            UpdateBackupSize();
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

        /// <summary>
        /// Determines what text to put in the StatusStrip label and if the Backup Button needs to be disabled
        /// </summary>
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

            else if (path1Btn.Checked && path1TextBox.Text == "")
            {
                stripLabel.Text = "Enter a backup path for path1";
                backupBtn.Enabled = false;
            }

            else if (path2Btn.Checked && path2TextBox.Text == "")
            {
                stripLabel.Text = "Enter a backup path for path2";
                backupBtn.Enabled = false;
            }

            else if (path1Btn.Checked && Path.HasExtension(path1TextBox.Text))
            {
                stripLabel.Text = "path1 cannot be a file!";
                backupBtn.Enabled = false;
            }

            else if (path2Btn.Checked && Path.HasExtension(path2TextBox.Text))
            {
                stripLabel.Text = "path2 cannot be a file!";
                backupBtn.Enabled = false;
            }

            else
            {
                stripLabel.Text = "Ready to begin backup";
                backupBtn.Enabled = true;
            }
        }

        /// <summary>
        /// When any of the 10 group CheckBoxes are (un)checked. Calls UpdateControls() and UpdateBackupSize()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupCheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControls();
            UpdateBackupSize();
        }

        /// <summary>
        /// Calls UpdateControls() when the checked PathsRadioBtn changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PathRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }
    }

    public static class MyExtensions
	{
        /// <summary>
        /// Extension to get FileInfo of all files/subfolders SAFELY since <![CDATA[IEnumerable<FileInfo>]]>.EnumerateFiles() completely collapses on first exception thrown with no way to handle the individual exception.<para/>
        /// <see href="https://stackoverflow.com/a/15179942">Error on getting DirectoryInfo with GetFileSystemInfos()</see>
        /// </summary>
        /// <param name="di">Makes this method an extension of <![CDATA[IEnumerable<FileInfo>]]> so we can call it just like a built-in method</param>
        /// <param name="searchPattern">The search pattern for which files need to be enumerated</param>
        /// <returns>Enumerable collection of FileInfo based on searchPattern, starting in the directory of this object</returns>
        public static IEnumerable<FileInfo> SafeGetFileInfosRecursive(this DirectoryInfo di, string searchPattern)
        {
            try
            {
                return di
                    .EnumerateFiles(searchPattern)
                    .Concat(
                        di
                            .EnumerateDirectories()
                            .SelectMany(x => x.SafeGetFileInfosRecursive(searchPattern))
                    );
            }
            catch (UnauthorizedAccessException)
            {
                return Enumerable.Empty<FileInfo>();
            }
        }
    }
}