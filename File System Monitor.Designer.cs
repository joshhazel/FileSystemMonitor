namespace File_System_Monitor
{
    partial class formFSM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFSM));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileStart = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.miFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.miEditSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.miMonitorSubfolders = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.miMonitorAttributes = new System.Windows.Forms.ToolStripMenuItem();
            this.miMonitorCreation = new System.Windows.Forms.ToolStripMenuItem();
            this.miMonitorDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.miMonitorFilename = new System.Windows.Forms.ToolStripMenuItem();
            this.miMonitorAccess = new System.Windows.Forms.ToolStripMenuItem();
            this.miMonitorWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.miMonitorSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.miMonitorSize = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDatabaseLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.miDatabaseLogging = new System.Windows.Forms.ToolStripMenuItem();
            this.miDatabaseQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.miDatabaseClear = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.tbStart = new System.Windows.Forms.ToolStripButton();
            this.tbOpenDirectory = new System.Windows.Forms.ToolStripButton();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbCut = new System.Windows.Forms.ToolStripButton();
            this.tbCopy = new System.Windows.Forms.ToolStripButton();
            this.tbPaste = new System.Windows.Forms.ToolStripButton();
            this.tbHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbLogDB = new System.Windows.Forms.ToolStripButton();
            this.tbQueryDB = new System.Windows.Forms.ToolStripButton();
            this.tbEraseDB = new System.Windows.Forms.ToolStripButton();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextStart = new System.Windows.Forms.ToolStripMenuItem();
            this.contextShow = new System.Windows.Forms.ToolStripMenuItem();
            this.contextHide = new System.Windows.Forms.ToolStripMenuItem();
            this.contextExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fsw = new System.IO.FileSystemWatcher();
            this.saveFolder = new System.Windows.Forms.SaveFileDialog();
            this.lblExtension = new System.Windows.Forms.Label();
            this.cmbWatchExtension = new System.Windows.Forms.ComboBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.cmbWriteExtension = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveDatabase = new System.Windows.Forms.SaveFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupDirectory = new System.Windows.Forms.GroupBox();
            this.groupDatabase = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.systemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMonitor = new System.Windows.Forms.TabPage();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.lvQuery = new System.Windows.Forms.ListView();
            this.colIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskExtension = new System.Windows.Forms.MaskedTextBox();
            this.mainMenu.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.status.SuspendLayout();
            this.context.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).BeginInit();
            this.groupDirectory.SuspendLayout();
            this.groupDatabase.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMonitor.SuspendLayout();
            this.tabQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuMonitor,
            this.databaseToolStripMenuItem,
            this.help});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(572, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileStart,
            this.miFileOpen,
            this.toolStripSeparator,
            this.miFileSave,
            this.miFileSaveAs,
            this.toolStripSeparator1,
            this.miFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // miFileStart
            // 
            this.miFileStart.Image = global::File_System_Monitor.Properties.Resources.StatusAnnotations_Play_32xLG_color;
            this.miFileStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miFileStart.Name = "miFileStart";
            this.miFileStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.miFileStart.Size = new System.Drawing.Size(189, 22);
            this.miFileStart.Text = "Start &Monitor";
            this.miFileStart.ToolTipText = "Start Monitoring Folder";
            this.miFileStart.Click += new System.EventHandler(this.miFileStart_Click);
            // 
            // miFileOpen
            // 
            this.miFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("miFileOpen.Image")));
            this.miFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miFileOpen.Name = "miFileOpen";
            this.miFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miFileOpen.Size = new System.Drawing.Size(189, 22);
            this.miFileOpen.Text = "Select &Folder";
            this.miFileOpen.ToolTipText = "Select Folder to Monitor";
            this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(186, 6);
            // 
            // miFileSave
            // 
            this.miFileSave.Image = ((System.Drawing.Image)(resources.GetObject("miFileSave.Image")));
            this.miFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miFileSave.Name = "miFileSave";
            this.miFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miFileSave.Size = new System.Drawing.Size(189, 22);
            this.miFileSave.Text = "&Save Log";
            this.miFileSave.ToolTipText = "Save Log";
            this.miFileSave.Click += new System.EventHandler(this.miFileSave_Click);
            // 
            // miFileSaveAs
            // 
            this.miFileSaveAs.Name = "miFileSaveAs";
            this.miFileSaveAs.Size = new System.Drawing.Size(189, 22);
            this.miFileSaveAs.Text = "Save Log &As";
            this.miFileSaveAs.Click += new System.EventHandler(this.miFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // miFileExit
            // 
            this.miFileExit.Image = global::File_System_Monitor.Properties.Resources.Close_16xMD;
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.miFileExit.Size = new System.Drawing.Size(189, 22);
            this.miFileExit.Text = "E&xit";
            this.miFileExit.Click += new System.EventHandler(this.miFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEditCut,
            this.miEditCopy,
            this.miEditPaste,
            this.toolStripSeparator4,
            this.miEditSelect});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            // 
            // miEditCut
            // 
            this.miEditCut.Image = ((System.Drawing.Image)(resources.GetObject("miEditCut.Image")));
            this.miEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miEditCut.Name = "miEditCut";
            this.miEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.miEditCut.Size = new System.Drawing.Size(164, 22);
            this.miEditCut.Text = "Cu&t";
            this.miEditCut.Click += new System.EventHandler(this.miEditCut_Click_1);
            // 
            // miEditCopy
            // 
            this.miEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("miEditCopy.Image")));
            this.miEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miEditCopy.Name = "miEditCopy";
            this.miEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.miEditCopy.Size = new System.Drawing.Size(164, 22);
            this.miEditCopy.Text = "&Copy";
            this.miEditCopy.Click += new System.EventHandler(this.miEditCopy_Click);
            // 
            // miEditPaste
            // 
            this.miEditPaste.Enabled = false;
            this.miEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("miEditPaste.Image")));
            this.miEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miEditPaste.Name = "miEditPaste";
            this.miEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.miEditPaste.Size = new System.Drawing.Size(164, 22);
            this.miEditPaste.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // miEditSelect
            // 
            this.miEditSelect.Name = "miEditSelect";
            this.miEditSelect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.miEditSelect.Size = new System.Drawing.Size(164, 22);
            this.miEditSelect.Text = "Select &All";
            this.miEditSelect.Click += new System.EventHandler(this.miEditSelect_Click);
            // 
            // menuMonitor
            // 
            this.menuMonitor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMonitorSubfolders,
            this.toolStripSeparator3,
            this.miMonitorAttributes,
            this.miMonitorCreation,
            this.miMonitorDirectory,
            this.miMonitorFilename,
            this.miMonitorAccess,
            this.miMonitorWrite,
            this.miMonitorSecurity,
            this.miMonitorSize});
            this.menuMonitor.Name = "menuMonitor";
            this.menuMonitor.Size = new System.Drawing.Size(62, 20);
            this.menuMonitor.Text = "&Monitor";
            this.menuMonitor.ToolTipText = "Set Log Options";
            // 
            // miMonitorSubfolders
            // 
            this.miMonitorSubfolders.Checked = true;
            this.miMonitorSubfolders.CheckOnClick = true;
            this.miMonitorSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miMonitorSubfolders.Name = "miMonitorSubfolders";
            this.miMonitorSubfolders.Size = new System.Drawing.Size(172, 22);
            this.miMonitorSubfolders.Text = "&Include Subfolders";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // miMonitorAttributes
            // 
            this.miMonitorAttributes.CheckOnClick = true;
            this.miMonitorAttributes.Name = "miMonitorAttributes";
            this.miMonitorAttributes.Size = new System.Drawing.Size(172, 22);
            this.miMonitorAttributes.Text = "&Attributes";
            // 
            // miMonitorCreation
            // 
            this.miMonitorCreation.Checked = true;
            this.miMonitorCreation.CheckOnClick = true;
            this.miMonitorCreation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miMonitorCreation.Name = "miMonitorCreation";
            this.miMonitorCreation.Size = new System.Drawing.Size(172, 22);
            this.miMonitorCreation.Text = "&Creation Time";
            // 
            // miMonitorDirectory
            // 
            this.miMonitorDirectory.Checked = true;
            this.miMonitorDirectory.CheckOnClick = true;
            this.miMonitorDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miMonitorDirectory.Name = "miMonitorDirectory";
            this.miMonitorDirectory.Size = new System.Drawing.Size(172, 22);
            this.miMonitorDirectory.Text = "&Directory Name";
            // 
            // miMonitorFilename
            // 
            this.miMonitorFilename.Checked = true;
            this.miMonitorFilename.CheckOnClick = true;
            this.miMonitorFilename.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miMonitorFilename.Name = "miMonitorFilename";
            this.miMonitorFilename.Size = new System.Drawing.Size(172, 22);
            this.miMonitorFilename.Text = "&File Name";
            // 
            // miMonitorAccess
            // 
            this.miMonitorAccess.CheckOnClick = true;
            this.miMonitorAccess.Name = "miMonitorAccess";
            this.miMonitorAccess.Size = new System.Drawing.Size(172, 22);
            this.miMonitorAccess.Text = "&Last Access";
            // 
            // miMonitorWrite
            // 
            this.miMonitorWrite.Checked = true;
            this.miMonitorWrite.CheckOnClick = true;
            this.miMonitorWrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miMonitorWrite.Name = "miMonitorWrite";
            this.miMonitorWrite.Size = new System.Drawing.Size(172, 22);
            this.miMonitorWrite.Text = "Last &Write";
            // 
            // miMonitorSecurity
            // 
            this.miMonitorSecurity.CheckOnClick = true;
            this.miMonitorSecurity.Name = "miMonitorSecurity";
            this.miMonitorSecurity.Size = new System.Drawing.Size(172, 22);
            this.miMonitorSecurity.Text = "Securit&y";
            // 
            // miMonitorSize
            // 
            this.miMonitorSize.CheckOnClick = true;
            this.miMonitorSize.Name = "miMonitorSize";
            this.miMonitorSize.Size = new System.Drawing.Size(172, 22);
            this.miMonitorSize.Text = "Si&ze";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDatabaseLocation,
            this.miDatabaseLogging,
            this.miDatabaseQuery,
            this.miDatabaseClear});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "&Database";
            // 
            // miDatabaseLocation
            // 
            this.miDatabaseLocation.Image = global::File_System_Monitor.Properties.Resources.FolderOpen_16x16_72;
            this.miDatabaseLocation.Name = "miDatabaseLocation";
            this.miDatabaseLocation.Size = new System.Drawing.Size(211, 22);
            this.miDatabaseLocation.Text = "Database Location";
            this.miDatabaseLocation.Click += new System.EventHandler(this.mi_Click);
            // 
            // miDatabaseLogging
            // 
            this.miDatabaseLogging.Checked = true;
            this.miDatabaseLogging.CheckOnClick = true;
            this.miDatabaseLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miDatabaseLogging.Image = global::File_System_Monitor.Properties.Resources.appwindow_database_16;
            this.miDatabaseLogging.Name = "miDatabaseLogging";
            this.miDatabaseLogging.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.miDatabaseLogging.Size = new System.Drawing.Size(211, 22);
            this.miDatabaseLogging.Text = "&Database Logging";
            this.miDatabaseLogging.Click += new System.EventHandler(this.miDatabaseLogging_Click);
            // 
            // miDatabaseQuery
            // 
            this.miDatabaseQuery.Image = global::File_System_Monitor.Properties.Resources.search;
            this.miDatabaseQuery.Name = "miDatabaseQuery";
            this.miDatabaseQuery.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.miDatabaseQuery.Size = new System.Drawing.Size(211, 22);
            this.miDatabaseQuery.Text = "&Query Database";
            this.miDatabaseQuery.Click += new System.EventHandler(this.miDatabaseQuery_Click);
            // 
            // miDatabaseClear
            // 
            this.miDatabaseClear.Image = global::File_System_Monitor.Properties.Resources.Erase;
            this.miDatabaseClear.Name = "miDatabaseClear";
            this.miDatabaseClear.Size = new System.Drawing.Size(211, 22);
            this.miDatabaseClear.Text = "&Clear database";
            this.miDatabaseClear.Click += new System.EventHandler(this.miDatabaseClear_Click);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelpAbout});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 20);
            this.help.Text = "&Help";
            // 
            // miHelpAbout
            // 
            this.miHelpAbout.Image = global::File_System_Monitor.Properties.Resources.Help;
            this.miHelpAbout.Name = "miHelpAbout";
            this.miHelpAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.miHelpAbout.Size = new System.Drawing.Size(159, 22);
            this.miHelpAbout.Text = "&About...";
            this.miHelpAbout.Click += new System.EventHandler(this.miHelpAbout_Click);
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbStart,
            this.tbOpenDirectory,
            this.tbSave,
            this.toolStripSeparator5,
            this.tbCut,
            this.tbCopy,
            this.tbPaste,
            this.tbHelp,
            this.toolStripSeparator6,
            this.tbLogDB,
            this.tbQueryDB,
            this.tbEraseDB});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(572, 25);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "toolStrip1";
            // 
            // tbStart
            // 
            this.tbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbStart.Image = global::File_System_Monitor.Properties.Resources.StatusAnnotations_Play_32xLG_color;
            this.tbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(23, 22);
            this.tbStart.Text = "&Start Monitoring";
            this.tbStart.Click += new System.EventHandler(this.tbStart_Click);
            // 
            // tbOpenDirectory
            // 
            this.tbOpenDirectory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpenDirectory.Image = ((System.Drawing.Image)(resources.GetObject("tbOpenDirectory.Image")));
            this.tbOpenDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpenDirectory.Name = "tbOpenDirectory";
            this.tbOpenDirectory.Size = new System.Drawing.Size(23, 22);
            this.tbOpenDirectory.Text = "Select &Folder";
            this.tbOpenDirectory.ToolTipText = "Select Directory to Monitor";
            this.tbOpenDirectory.Click += new System.EventHandler(this.tbOpenDirectory_Click);
            // 
            // tbSave
            // 
            this.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSave.Image = ((System.Drawing.Image)(resources.GetObject("tbSave.Image")));
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(23, 22);
            this.tbSave.Text = "&Save";
            this.tbSave.ToolTipText = "Save Log";
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tbCut
            // 
            this.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCut.Image = ((System.Drawing.Image)(resources.GetObject("tbCut.Image")));
            this.tbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCut.Name = "tbCut";
            this.tbCut.Size = new System.Drawing.Size(23, 22);
            this.tbCut.Text = "C&ut";
            this.tbCut.Click += new System.EventHandler(this.tbCut_Click);
            // 
            // tbCopy
            // 
            this.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tbCopy.Image")));
            this.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new System.Drawing.Size(23, 22);
            this.tbCopy.Text = "&Copy";
            this.tbCopy.Click += new System.EventHandler(this.tbCopy_Click);
            // 
            // tbPaste
            // 
            this.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPaste.Enabled = false;
            this.tbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tbPaste.Image")));
            this.tbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPaste.Name = "tbPaste";
            this.tbPaste.Size = new System.Drawing.Size(23, 22);
            this.tbPaste.Text = "&Paste";
            // 
            // tbHelp
            // 
            this.tbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tbHelp.Image")));
            this.tbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbHelp.Name = "tbHelp";
            this.tbHelp.Size = new System.Drawing.Size(23, 22);
            this.tbHelp.Text = "He&lp";
            this.tbHelp.Click += new System.EventHandler(this.tbHelp_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tbLogDB
            // 
            this.tbLogDB.Checked = true;
            this.tbLogDB.CheckOnClick = true;
            this.tbLogDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLogDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbLogDB.Image = global::File_System_Monitor.Properties.Resources.appwindow_database_16;
            this.tbLogDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbLogDB.Name = "tbLogDB";
            this.tbLogDB.Size = new System.Drawing.Size(23, 22);
            this.tbLogDB.Text = "Log DB";
            this.tbLogDB.ToolTipText = "Log to Database";
            this.tbLogDB.Click += new System.EventHandler(this.tbLogDB_Click);
            // 
            // tbQueryDB
            // 
            this.tbQueryDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbQueryDB.Image = global::File_System_Monitor.Properties.Resources.search;
            this.tbQueryDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbQueryDB.Name = "tbQueryDB";
            this.tbQueryDB.Size = new System.Drawing.Size(23, 22);
            this.tbQueryDB.Text = "Query DB";
            this.tbQueryDB.Click += new System.EventHandler(this.tbQueryDB_Click);
            // 
            // tbEraseDB
            // 
            this.tbEraseDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbEraseDB.Image = global::File_System_Monitor.Properties.Resources.Erase;
            this.tbEraseDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEraseDB.Name = "tbEraseDB";
            this.tbEraseDB.Size = new System.Drawing.Size(23, 22);
            this.tbEraseDB.Text = "Erase DB";
            this.tbEraseDB.Click += new System.EventHandler(this.tbEraseDB_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusClock});
            this.status.Location = new System.Drawing.Point(0, 444);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(572, 22);
            this.status.SizingGrip = false;
            this.status.TabIndex = 2;
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(512, 17);
            this.statusText.Spring = true;
            this.statusText.Text = "Ready";
            this.statusText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // statusClock
            // 
            this.statusClock.AutoToolTip = true;
            this.statusClock.Name = "statusClock";
            this.statusClock.Size = new System.Drawing.Size(45, 17);
            this.statusClock.Text = "CLOCK";
            this.statusClock.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // context
            // 
            this.context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextStart,
            this.contextShow,
            this.contextHide,
            this.contextExit});
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(145, 92);
            // 
            // contextStart
            // 
            this.contextStart.Image = global::File_System_Monitor.Properties.Resources.StatusAnnotations_Play_32xLG_color;
            this.contextStart.Name = "contextStart";
            this.contextStart.Size = new System.Drawing.Size(144, 22);
            this.contextStart.Text = "&Start Monitor";
            this.contextStart.Click += new System.EventHandler(this.contextStart_Click);
            // 
            // contextShow
            // 
            this.contextShow.Name = "contextShow";
            this.contextShow.Size = new System.Drawing.Size(144, 22);
            this.contextShow.Text = "Sho&w";
            this.contextShow.Click += new System.EventHandler(this.contextShow_Click);
            // 
            // contextHide
            // 
            this.contextHide.Name = "contextHide";
            this.contextHide.Size = new System.Drawing.Size(144, 22);
            this.contextHide.Text = "&Hide";
            this.contextHide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // contextExit
            // 
            this.contextExit.Image = global::File_System_Monitor.Properties.Resources.Close_16xMD;
            this.contextExit.Name = "contextExit";
            this.contextExit.Size = new System.Drawing.Size(144, 22);
            this.contextExit.Text = "E&xit";
            this.contextExit.Click += new System.EventHandler(this.contextExit_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // folderDialog
            // 
            this.folderDialog.Description = "Select Folder to Monitor";
            // 
            // fsw
            // 
            this.fsw.EnableRaisingEvents = true;
            this.fsw.SynchronizingObject = this;
            // 
            // saveFolder
            // 
            this.saveFolder.FileName = "File_System_Monitor.log";
            this.saveFolder.Filter = "Log files (*.log)|*.log";
            this.saveFolder.InitialDirectory = "C:\\";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(361, 13);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(53, 13);
            this.lblExtension.TabIndex = 3;
            this.lblExtension.Text = "Extension";
            // 
            // cmbWatchExtension
            // 
            this.cmbWatchExtension.FormattingEnabled = true;
            this.cmbWatchExtension.ItemHeight = 13;
            this.cmbWatchExtension.Items.AddRange(new object[] {
            "*.txt",
            "*.log",
            "*.exe",
            "*.bat",
            "*.jpg",
            "*.avi"});
            this.cmbWatchExtension.Location = new System.Drawing.Point(364, 29);
            this.cmbWatchExtension.Name = "cmbWatchExtension";
            this.cmbWatchExtension.Size = new System.Drawing.Size(50, 21);
            this.cmbWatchExtension.TabIndex = 2;
            this.cmbWatchExtension.Text = "*.*";
            // 
            // txtFolder
            // 
            this.txtFolder.AcceptsTab = true;
            this.txtFolder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtFolder.ForeColor = System.Drawing.Color.Green;
            this.txtFolder.Location = new System.Drawing.Point(6, 30);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(320, 20);
            this.txtFolder.TabIndex = 0;
            this.txtFolder.Text = "C:\\Test\\";
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // btnFolder
            // 
            this.btnFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnFolder.Image")));
            this.btnFolder.Location = new System.Drawing.Point(332, 30);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(25, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenDB.Image")));
            this.btnOpenDB.Location = new System.Drawing.Point(332, 27);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(25, 23);
            this.btnOpenDB.TabIndex = 1;
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.AcceptsTab = true;
            this.txtDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtDatabase.Location = new System.Drawing.Point(6, 27);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.ReadOnly = true;
            this.txtDatabase.Size = new System.Drawing.Size(320, 20);
            this.txtDatabase.TabIndex = 0;
            this.txtDatabase.TabStop = false;
            this.txtDatabase.Text = "C:\\FileWatcher.db";
            // 
            // cmbWriteExtension
            // 
            this.cmbWriteExtension.FormattingEnabled = true;
            this.cmbWriteExtension.ItemHeight = 13;
            this.cmbWriteExtension.Items.AddRange(new object[] {
            "*.txt",
            "*.log",
            "*.exe",
            "*.bat",
            "*.jpg",
            "*.avi"});
            this.cmbWriteExtension.Location = new System.Drawing.Point(364, 26);
            this.cmbWriteExtension.Name = "cmbWriteExtension";
            this.cmbWriteExtension.Size = new System.Drawing.Size(50, 21);
            this.cmbWriteExtension.TabIndex = 5;
            this.cmbWriteExtension.Text = "*.*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Extension";
            // 
            // saveDatabase
            // 
            this.saveDatabase.FileName = "FileWatcher.db";
            this.saveDatabase.Filter = "Database files|*.db";
            this.saveDatabase.Title = "Database Save Location";
            // 
            // btnStart
            // 
            this.btnStart.Image = global::File_System_Monitor.Properties.Resources.StatusAnnotations_Play_32xLG_color;
            this.btnStart.Location = new System.Drawing.Point(431, 33);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(32, 27);
            this.btnStart.TabIndex = 1;
            this.btnStart.Tag = "Stopped";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupDirectory
            // 
            this.groupDirectory.Controls.Add(this.txtFolder);
            this.groupDirectory.Controls.Add(this.lblExtension);
            this.groupDirectory.Controls.Add(this.cmbWatchExtension);
            this.groupDirectory.Controls.Add(this.btnFolder);
            this.groupDirectory.Location = new System.Drawing.Point(2, 4);
            this.groupDirectory.Name = "groupDirectory";
            this.groupDirectory.Size = new System.Drawing.Size(423, 56);
            this.groupDirectory.TabIndex = 0;
            this.groupDirectory.TabStop = false;
            this.groupDirectory.Text = "Directory to Monitor";
            // 
            // groupDatabase
            // 
            this.groupDatabase.Controls.Add(this.txtDatabase);
            this.groupDatabase.Controls.Add(this.label2);
            this.groupDatabase.Controls.Add(this.cmbWriteExtension);
            this.groupDatabase.Controls.Add(this.btnOpenDB);
            this.groupDatabase.Location = new System.Drawing.Point(2, 66);
            this.groupDatabase.Name = "groupDatabase";
            this.groupDatabase.Size = new System.Drawing.Size(423, 53);
            this.groupDatabase.TabIndex = 2;
            this.groupDatabase.TabStop = false;
            this.groupDatabase.Text = "Database Logging";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(3, 126);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(558, 234);
            this.rtbLog.TabIndex = 3;
            this.rtbLog.Text = "";
            // 
            // systemTray
            // 
            this.systemTray.ContextMenuStrip = this.context;
            this.systemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTray.Icon")));
            this.systemTray.Text = "File System Monitor";
            this.systemTray.Visible = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMonitor);
            this.tabControl.Controls.Add(this.tabQuery);
            this.tabControl.Location = new System.Drawing.Point(0, 52);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(572, 389);
            this.tabControl.TabIndex = 7;
            // 
            // tabMonitor
            // 
            this.tabMonitor.Controls.Add(this.rtbLog);
            this.tabMonitor.Controls.Add(this.btnStart);
            this.tabMonitor.Controls.Add(this.groupDirectory);
            this.tabMonitor.Controls.Add(this.groupDatabase);
            this.tabMonitor.Location = new System.Drawing.Point(4, 22);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonitor.Size = new System.Drawing.Size(564, 363);
            this.tabMonitor.TabIndex = 0;
            this.tabMonitor.Text = "Monitor";
            this.tabMonitor.UseVisualStyleBackColor = true;
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.lvQuery);
            this.tabQuery.Controls.Add(this.btnQuery);
            this.tabQuery.Controls.Add(this.label1);
            this.tabQuery.Controls.Add(this.maskExtension);
            this.tabQuery.Location = new System.Drawing.Point(4, 22);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuery.Size = new System.Drawing.Size(564, 363);
            this.tabQuery.TabIndex = 1;
            this.tabQuery.Text = "Query";
            this.tabQuery.UseVisualStyleBackColor = true;
            // 
            // lvQuery
            // 
            this.lvQuery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colPath,
            this.colFilename,
            this.colExt,
            this.colEvent,
            this.colTime});
            this.lvQuery.FullRowSelect = true;
            this.lvQuery.GridLines = true;
            this.lvQuery.Location = new System.Drawing.Point(2, 56);
            this.lvQuery.Name = "lvQuery";
            this.lvQuery.Size = new System.Drawing.Size(562, 304);
            this.lvQuery.TabIndex = 2;
            this.lvQuery.UseCompatibleStateImageBehavior = false;
            this.lvQuery.View = System.Windows.Forms.View.Details;
            // 
            // colIndex
            // 
            this.colIndex.Text = "Index";
            this.colIndex.Width = 41;
            // 
            // colPath
            // 
            this.colPath.Text = "Path";
            this.colPath.Width = 133;
            // 
            // colFilename
            // 
            this.colFilename.Text = "Filename";
            this.colFilename.Width = 89;
            // 
            // colExt
            // 
            this.colExt.Text = "Ext";
            this.colExt.Width = 44;
            // 
            // colEvent
            // 
            this.colEvent.Text = "Event";
            this.colEvent.Width = 69;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 95;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(62, 27);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(48, 23);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Extension";
            // 
            // maskExtension
            // 
            this.maskExtension.Location = new System.Drawing.Point(8, 27);
            this.maskExtension.Mask = "*.&";
            this.maskExtension.Name = "maskExtension";
            this.maskExtension.Size = new System.Drawing.Size(48, 20);
            this.maskExtension.TabIndex = 0;
            this.maskExtension.TextChanged += new System.EventHandler(this.maskExtension_TextChanged_1);
            // 
            // formFSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 466);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.status);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "formFSM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   File System Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formFSM_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.context.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).EndInit();
            this.groupDirectory.ResumeLayout(false);
            this.groupDirectory.PerformLayout();
            this.groupDatabase.ResumeLayout(false);
            this.groupDatabase.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMonitor.ResumeLayout(false);
            this.tabQuery.ResumeLayout(false);
            this.tabQuery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem miFileStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem miFileSave;
        private System.Windows.Forms.ToolStripMenuItem miFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem miEditCut;
        private System.Windows.Forms.ToolStripMenuItem miEditCopy;
        private System.Windows.Forms.ToolStripMenuItem miEditPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem miEditSelect;
        private System.Windows.Forms.ToolStripMenuItem menuMonitor;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem miHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem miMonitorSubfolders;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem miMonitorAttributes;
        private System.Windows.Forms.ToolStripMenuItem miMonitorCreation;
        private System.Windows.Forms.ToolStripMenuItem miMonitorDirectory;
        private System.Windows.Forms.ToolStripMenuItem miMonitorFilename;
        private System.Windows.Forms.ToolStripMenuItem miMonitorAccess;
        private System.Windows.Forms.ToolStripMenuItem miMonitorWrite;
        private System.Windows.Forms.ToolStripMenuItem miMonitorSecurity;
        private System.Windows.Forms.ToolStripMenuItem miMonitorSize;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton tbStart;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tbCut;
        private System.Windows.Forms.ToolStripButton tbCopy;
        private System.Windows.Forms.ToolStripButton tbPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tbHelp;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusClock;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.ToolStripMenuItem contextStart;
        private System.Windows.Forms.ToolStripMenuItem contextShow;
        private System.Windows.Forms.ToolStripMenuItem contextHide;
        private System.Windows.Forms.ToolStripMenuItem contextExit;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.ToolStripMenuItem miFileOpen;
        private System.Windows.Forms.ToolStripButton tbOpenDirectory;
        private System.IO.FileSystemWatcher fsw;
        private System.Windows.Forms.SaveFileDialog saveFolder;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tbLogDB;
        private System.Windows.Forms.ToolStripMenuItem miDatabaseLogging;
        private System.Windows.Forms.ToolStripMenuItem miDatabaseQuery;
        private System.Windows.Forms.ToolStripMenuItem miDatabaseClear;
        private System.Windows.Forms.ToolStripButton tbEraseDB;
        private System.Windows.Forms.ToolStripButton tbQueryDB;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.ComboBox cmbWatchExtension;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.ComboBox cmbWriteExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.SaveFileDialog saveDatabase;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripMenuItem miDatabaseLocation;
        private System.Windows.Forms.GroupBox groupDirectory;
        private System.Windows.Forms.GroupBox groupDatabase;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.NotifyIcon systemTray;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMonitor;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.ListView lvQuery;
        private System.Windows.Forms.ColumnHeader colIndex;
        private System.Windows.Forms.ColumnHeader colPath;
        private System.Windows.Forms.ColumnHeader colFilename;
        private System.Windows.Forms.ColumnHeader colExt;
        private System.Windows.Forms.ColumnHeader colEvent;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskExtension;
    }
}

