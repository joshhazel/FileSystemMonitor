/*
 * Joshua Hazel
 * CSCD 306 .NET
 * Mid-Term: File System Watcher (GUI + DB)
 * 
 * Extras + Notes:
 * 1)   Menu/toolbar/buttons includes icons
 * 2)   Menu > Monitor > allow user to specify events to trigger monitoring
 * 3)   Menu > File > Save + Save As > Save Dialog
 * 4)   Menu > File > Select Folder > Open Folder Dialog
 * 5)   System Tray 
 * 6)   Masked TextBox (Query_
 * 7)   Tabs
 * 8)   ListView Control (For Query results)
 */

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Media; //Database

namespace File_System_Monitor
{
    public partial class formFSM : Form
    {
        //Member variables
        private bool _logSaved;
        private string _filename = "";
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        
        public formFSM()
        {
            InitializeComponent();
            StartFileWatcher();
            this.statusClock.Text = DateTime.Now.ToLongTimeString();
        }
        private void InitializeDB()
        {
            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source="+this.txtDatabase.Text+";Version=3;New=True;Compress=True;");

            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            //if (!File.Exists("database.db"))
            try
            {
                sqlite_cmd.CommandText = "CREATE TABLE data (id integer primary key, path varchar(100), filename varchar(100), ext varchar(5), event varchar(100), time varchar(25));";

                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
        }
        

        //
        // Status Bar
        //
        private void timerClock_Tick(object sender, EventArgs e)
        {
            //Set clock
            this.statusClock.Text = DateTime.Now.ToLongTimeString();
        }


        //
        // Toolbar
        //
        private void tbStart_Click(object sender, EventArgs e)
        {
            StartStopMonitoring();
        }
        private void tbOpenDirectory_Click(object sender, EventArgs e)
        {
            this.folderDialog.ShowDialog(this);
            this.txtFolder.Text = this.folderDialog.SelectedPath;
        }
        


        //
        // Menu
        //
        private void miFileOpen_Click(object sender, EventArgs e)
        {
            SetFolder();
        }
        private void mi_Click(object sender, EventArgs e)
        {
            OpenDB();
        }
        private void miFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void miFileStart_Click(object sender, EventArgs e)
        {
            StartStopMonitoring();
        }
        private void miEditSelect_Click(object sender, EventArgs e)
        {
            this.rtbLog.SelectAll();
        }
        private void miEditCut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.rtbLog.SelectedText);
        }



        //
        // UserForm
        //
        private void formFSM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Are you sure you want to exit?", "Exit Program?", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1))
            {
                e.Cancel = true;
                return;
            }

            //if (this.btnStart.Tag.ToString() == "Started")
               // e.Cancel = true;

            //Check if file has been saved before exit
            if (_logSaved == false)
            {
            //Goto: If unsaved, user chooses to save but doesnt, reprompt save
            Unsaved:
                //Prompt to save, not save, cancel
                DialogResult msgbox =
                    MessageBox.Show("You have not saved your log file. \n\nWould you like to save before exit?", "Log Not Saved",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                //Save dialog box
                if (msgbox == System.Windows.Forms.DialogResult.Yes)
                {
                    this.SaveDialog();
                    //User save log failed, reprompt
                    if (_logSaved == false)
                        goto Unsaved;
                }
                //Cancel and return to form
                if (msgbox == System.Windows.Forms.DialogResult.Cancel)
                    e.Cancel = true;
            }
            //Else: exit without prompt

            // We are ready, now lets cleanup and close our connection:
            //sqlite_conn.Close();
        }
        
        private void btnFolder_Click(object sender, EventArgs e)
        {
            SetFolder();
        }
        //Set the folder to monitor
        private void SetFolder()
        {
            //Make sure a folder is selected
            string temp = "";
            while(temp == "")
            {
                this.folderDialog.ShowDialog(this);
                temp = this.folderDialog.SelectedPath;
            }
            this.txtFolder.Text = temp;
        }

        //Validate selected folder
        private void txtFolder_TextChanged(object sender, EventArgs e)
        {
            ValidateFolderPath();
        }
        private void ValidateFolderPath()
        {
            //Check if folder path given is valid
            if (Directory.Exists(this.txtFolder.Text))
            {
                //Check if relative path and convert to absolute path - //exclude : because of test case "c:" converts to .../Documents folder?
                if (!this.txtFolder.Text.Contains(":") && this.txtFolder.Text != Path.GetFullPath(this.txtFolder.Text))
                {   //Change relative to absolute path
                    this.txtFolder.Text = Path.GetFullPath(this.txtFolder.Text);
                    //After changing path, set cursor at end of text for user to continue typing
                    this.txtFolder.Select(this.txtFolder.Text.Length, 0);
                }

                //Change folder path text color green (valid directory path)
                this.txtFolder.ForeColor = Color.Green;
                //Enable start monitoring button (valid folder given)
                this.btnStart.Enabled = true;
                this.tbStart.Enabled = true;
                this.miFileStart.Enabled = true;
            }
            else
            {
                //Change folder path text color red (invalid directory path)
                this.txtFolder.ForeColor = Color.Red;
                //Disable start monitoring button (invalid folder given)
                this.btnStart.Enabled = false;
                this.tbStart.Enabled = false;
                this.miFileStart.Enabled = false;
            }//end if 
        }

        //Set the file for database
        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            OpenDB();
        }

        private void OpenDB()
        {
            //Make sure a valid file is selected
            string temp = "";
            while (temp == "")
            {
                this.saveDatabase.ShowDialog(this);
                temp = this.saveDatabase.FileName;
            }
            this.txtDatabase.Text = temp;
        }

        //Start monitoring
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartStopMonitoring();
        }

        private void StartStopMonitoring()
        {
            //Make sure user is not an idiot
            if (Path.GetFullPath(".").Contains(Path.GetFullPath(this.txtFolder.Text))) //&& (future add exception when subdirectories checkbox not selected or *.db/*.* not selected)
            {
                MessageBox.Show("You idiot, your path cannot be a parent directory of your database!\n\n" +
                    "Your path: \n" + Path.GetFullPath(this.txtFolder.Text) + "\n\n" +
                    "DB path: \n" + Path.GetFullPath(".") + "\\Database.db",
                    "You Are An Idiot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Enable-Disable controls
            EnableDisableControls();

            //Change properties of program to STARTED
            if (this.btnStart.Tag.ToString()  == "Stopped")
            {
                //Setup DB
                InitializeDB();

                //Log start of monitoring
                this.rtbLog.AppendText("\n**** Begin Monitoring " + this.txtFolder.Text + "****   " + DateTime.Now + "\n");
                this.btnStart.Tag = "Started"; //Update button tag
                this.rtbLog.Focus(); //set focus to rich text box

                //Update images
                this.tbStart.Image = Properties.Resources.StatusAnnotations_Stop_32xLG_color;
                this.miFileStart.Image = Properties.Resources.StatusAnnotations_Stop_32xLG_color;
                this.btnStart.Image = Properties.Resources.StatusAnnotations_Stop_32xLG_color;
                this.contextStart.Image = Properties.Resources.StatusAnnotations_Stop_32xLG_color;
                
                //Update text + status bar
                this.contextStart.Text = "Stop Monitoring";
                this.statusText.Text = "Monitoring " + this.txtFolder.Text;

                //Flag log as unsaved
                _logSaved = false;

                //Start the FileWatcher
                Notifications();
                this.fsw.EnableRaisingEvents = true;
            }
            //Change properties of program to STOPPED
            else if (this.btnStart.Tag.ToString() == "Started")
            {
                //Log end of monitoring
                this.rtbLog.AppendText("**** End Monitoring " + this.txtFolder.Text + "****   " + DateTime.Now + "\n");
                this.btnStart.Tag = "Stopped"; //Update button tag

                //Update images
                this.tbStart.Image = Properties.Resources.StatusAnnotations_Play_32xLG_color;
                this.miFileStart.Image = Properties.Resources.StatusAnnotations_Play_32xLG_color;
                this.btnStart.Image = Properties.Resources.StatusAnnotations_Play_32xLG_color;
                this.contextStart.Image = Properties.Resources.StatusAnnotations_Play_32xLG_color;

                //Update text + status bar
                this.contextStart.Text = "Start Monitoring";
                this.statusText.Text = "Ready";

                //Stop the FileWatcher
                this.fsw.EnableRaisingEvents = false;
            }
            Console.Beep();
        }

        private void EnableDisableControls()
        {
            //Enable-Disable Controls
            //UserForm
            this.groupDirectory.Enabled = !this.groupDirectory.Enabled;
            this.groupDatabase.Enabled = !this.groupDatabase.Enabled; 
            //Toolbar
            this.tbEraseDB.Enabled = !this.tbEraseDB.Enabled;
            this.tbOpenDirectory.Enabled = !this.tbOpenDirectory.Enabled;
            this.tbQueryDB.Enabled = !this.tbQueryDB.Enabled;
            this.tbSave.Enabled = !this.tbSave.Enabled;
            //Menu-File
            this.miFileOpen.Enabled = !this.miFileOpen.Enabled;
            this.miFileSave.Enabled = !this.miFileSave.Enabled;
            this.miFileSaveAs.Enabled = !this.miFileSaveAs.Enabled;
            //Menu-Monitor
            this.miMonitorAccess.Enabled = !this.miMonitorAccess.Enabled;
            this.miMonitorAttributes.Enabled = !this.miMonitorAttributes.Enabled;
            this.miMonitorCreation.Enabled = !this.miMonitorCreation.Enabled;
            this.miMonitorDirectory.Enabled = !this.miMonitorDirectory.Enabled;
            this.miMonitorFilename.Enabled = !this.miMonitorFilename.Enabled;
            this.miMonitorSecurity.Enabled = !this.miMonitorSecurity.Enabled;
            this.miMonitorSize.Enabled = !this.miMonitorSize.Enabled;
            this.miMonitorWrite.Enabled = !this.miMonitorWrite.Enabled;
            this.miMonitorSubfolders.Enabled = !this.miMonitorSubfolders.Enabled;
            //Menu-Database
            this.miDatabaseLocation.Enabled = !this.miDatabaseLocation.Enabled;
            this.miDatabaseClear.Enabled = !this.miDatabaseClear.Enabled;
            this.miDatabaseQuery.Enabled = !this.miDatabaseQuery.Enabled;
        }

        private void Notifications()
        {
            this.fsw.Path = this.txtFolder.Text;
            this.fsw.Filter = this.cmbWatchExtension.Text;
            this.fsw.IncludeSubdirectories = this.miMonitorSubfolders.Checked;

            // Notification filters
            NotifyFilters notificationFilters = new NotifyFilters();
            if (this.miMonitorAttributes.Checked)
                notificationFilters = notificationFilters | NotifyFilters.Attributes;
            if (this.miMonitorCreation.Checked)
                notificationFilters = notificationFilters | NotifyFilters.CreationTime;
            if (this.miMonitorDirectory.Checked)
                notificationFilters = notificationFilters | NotifyFilters.DirectoryName;
            if (this.miMonitorFilename.Checked)
                notificationFilters = notificationFilters | NotifyFilters.FileName;
            if (this.miMonitorAccess.Checked)
                notificationFilters = notificationFilters | NotifyFilters.LastAccess;
            if (this.miMonitorWrite.Checked)
                notificationFilters = notificationFilters | NotifyFilters.LastWrite;
            if (this.miMonitorSecurity.Checked)
                notificationFilters = notificationFilters | NotifyFilters.Security;
            if (this.miMonitorSize.Checked)
                notificationFilters = notificationFilters | NotifyFilters.Size;

            this.fsw.NotifyFilter = notificationFilters;
        }

        /// <summary>
        /// Create a SaveFileDialog box.
        /// </summary>
        public void SaveDialog()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            // Set default filename, directory, extension, and initial directory.
            saveDialog.FileName = "FW_Log";
            saveDialog.InitialDirectory = "c:\\";
            saveDialog.DefaultExt = "*.log";
            saveDialog.Filter = "LOG Files|*.log";

            // Check if SAVE button pressed and filename was input.
            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveDialog.FileName.Length > 0)
            {
                // Save the Log data  in plain text to the .log file specified.
                rtbLog.SaveFile(saveDialog.FileName, RichTextBoxStreamType.PlainText);
                //Flag log as saved
                _logSaved = true;
                _filename = saveDialog.FileName;
            }
        }

        //Synchronize logging buttons <checked> values
        private void tbLogDB_Click(object sender, EventArgs e)
        {
            this.miDatabaseLogging.Checked = this.tbLogDB.Checked;
        }
        private void miDatabaseLogging_Click(object sender, EventArgs e)
        {
            this.tbLogDB.Checked = this.miDatabaseLogging.Checked;
        }

        private void miFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveDialog();
        }

        private void miFileSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void SaveFile()
        {
            if (_filename == "")
                SaveDialog();
            else
                this.rtbLog.SaveFile(_filename);
        }

        private void miEditCut_Click_1(object sender, EventArgs e)
        {
            Cut();
        }

        private void Cut()
        {
            rtbLog.Cut();
        }

        private void miEditCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void Copy()
        {
            rtbLog.Copy();
        }

        private void tbCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void tbCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }
        private void StartFileWatcher()
        {
            this.fsw = new FileSystemWatcher();
            this.fsw.SynchronizingObject = this;

            this.fsw.Changed += new FileSystemEventHandler(OnChanged);
            this.fsw.Created += new FileSystemEventHandler(OnChanged);
            this.fsw.Deleted += new FileSystemEventHandler(OnChanged);
            this.fsw.Renamed += new RenamedEventHandler(OnRenamed);
        }


        /// <summary>
        /// Define the event handlers for Changed, Created, Deleted events.
        /// </summary>
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            rtbLog.AppendText(e.Name + " | " + e.FullPath + " | " + e.ChangeType + "\n");

            string path, filename, ext;
            path = e.FullPath.Substring(0, e.FullPath.LastIndexOf("\\"));
            filename = e.FullPath.Substring(e.FullPath.LastIndexOf("\\"), e.FullPath.LastIndexOf(".") - e.FullPath.LastIndexOf("\\"));
            ext = e.FullPath.Substring(e.FullPath.LastIndexOf(".")+1);

            //Check if DB logging is on, if so then insert to DB
            if (this.miDatabaseLogging.Checked == true)
            {
                // Lets insert something into our new table:
                sqlite_cmd.CommandText =
                    @"INSERT INTO data VALUES (
                    NULL, '" +
                    path + "','" +
                    filename + "','" +
                    ext + "','" +
                    e.ChangeType + "','" +
                    DateTime.Now.ToString() + "');";

                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Define the event handlers for the renamed event.
        /// </summary>
        private void OnRenamed(object source, RenamedEventArgs e)
        {
            rtbLog.AppendText(e.Name + " | " + e.FullPath + " | " + e.ChangeType + "\n");

            string path, filename, ext;
            path = e.FullPath.Substring(0, e.FullPath.LastIndexOf("\\"));
            filename = e.FullPath.Substring(e.FullPath.LastIndexOf("\\"), e.FullPath.LastIndexOf(".") - e.FullPath.LastIndexOf("\\"));
            ext = e.FullPath.Substring(e.FullPath.LastIndexOf(".")+1);

            // Lets insert something into our new table:
            sqlite_cmd.CommandText =
                @"INSERT INTO data VALUES (
                NULL, '" +
                path + "','" +
                filename + "','" +
                ext + "','" +
                e.ChangeType + "','" +
                DateTime.Now.ToString() + "');";

            // And execute this again ;D
            sqlite_cmd.ExecuteNonQuery();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void contextShow_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void contextExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextStart_Click(object sender, EventArgs e)
        {
            this.StartStopMonitoring();
        }

        private void maskExtension_TextChanged(object sender, EventArgs e)
        {
            if (maskExtension.Text == "*.*")
                maskExtension.Mask = "*.&";
            else
                maskExtension.Mask = "*.&??";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryDB();
        }
        private void QueryDB()
        {
            //Check if database initialized
            if (sqlite_cmd == null)
            {
                if(DialogResult.Yes == MessageBox.Show("Do you want to use the database at:\n\n" + this.txtDatabase.Text,"DB",MessageBoxButtons.YesNo))
                {
                    InitializeDB();     
                }
                else
                {
                    MessageBox.Show("You must start logging the database before you can query!");
                    return;
                }
            }

            //Clear listview
            this.lvQuery.Items.Clear();

/*            //Validation -- Disable, consider *. equivalent to *.*
            if (maskExtension.Text == "*.")
            {
                MessageBox.Show("Valid extension required", "Invalid Extension");
                return;
            }
*/
            //Filter extension query
            if (maskExtension.Text == "*.*" || maskExtension.Text == "*.")
            {
                // First lets build a SQL-Query again:
                this.sqlite_cmd.CommandText = "SELECT * FROM data";
            }
            else
            {
                // First lets build a SQL-Query again:
                this.sqlite_cmd.CommandText = "SELECT * FROM data WHERE ext = '" + this.maskExtension.Text.Replace("*.", "") + "'";
            }

            // Now the SQLiteCommand object can give us a DataReader-Object:
            this.sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                // Print out the content of the text field:

                //Create ListView Item
                ListViewItem lvi = new ListViewItem(sqlite_datareader["id"].ToString());

                //Create ListView Item[SubItems]
                lvi.SubItems.Add(sqlite_datareader["path"].ToString());
                lvi.SubItems.Add(sqlite_datareader["filename"].ToString());
                lvi.SubItems.Add(sqlite_datareader["ext"].ToString());
                lvi.SubItems.Add(sqlite_datareader["event"].ToString());
                lvi.SubItems.Add(sqlite_datareader["time"].ToString());

                //Add new tuple to ListView
                this.lvQuery.Items.Add(lvi);
            }

            //Close the reader
            this.sqlite_datareader.Close();
        }

        private void miDatabaseQuery_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabQuery;
        }

        private void tbQueryDB_Click(object sender, EventArgs e)
        {
            this.tabQuery.Show();
        }

        private void tbEraseDB_Click(object sender, EventArgs e)
        {
            ClearDB();
        }

        private void miDatabaseClear_Click(object sender, EventArgs e)
        {
            ClearDB();
        }
        private void ClearDB()
        {
            //Check if database initialized
            if (sqlite_cmd == null)
            {
                if (DialogResult.Yes == MessageBox.Show("Database Not Initialized.\n\nDo you want to use the database at:\n\n" + this.txtDatabase.Text, "DB", MessageBoxButtons.YesNo))
                {
                    InitializeDB();
                }
                else
                {
                    MessageBox.Show("You must select the database before you can erase!");
                    return;
                }
            } 
            
            //Prompt to erase DB
            if (DialogResult.Yes == MessageBox.Show("Delete entire database entires and log?", "Clear Database", MessageBoxButtons.YesNo))
            {
                this.lvQuery.Items.Clear();
                this.rtbLog.Text = "";
                this.sqlite_cmd.CommandText = "DELETE FROM data";
                this.sqlite_cmd.ExecuteNonQuery();
            }
        }

        private void maskExtension_TextChanged_1(object sender, EventArgs e)
        {
            if (maskExtension.Text == "*.*")
                maskExtension.Mask = "*.&";
            else
                maskExtension.Mask = "*.&??";
        }

        private void miHelpAbout_Click(object sender, EventArgs e)
        {
            HelpAbout();
        }
        private void tbHelp_Click(object sender, EventArgs e)
        {
            HelpAbout();
        }

        private void HelpAbout()
        {
            string msg = "";
            msg += "File System Watcher\n";
            msg += "Version 2.09.13\n";
            msg += Environment.OSVersion.ToString()+"\n";
            if (Environment.Is64BitOperatingSystem)
                msg += "64-Bit OS";
            else
                msg += "32-Bit OS";
            MessageBox.Show(msg);
        }


    }
}
