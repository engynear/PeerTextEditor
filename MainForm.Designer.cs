namespace PeerTextEditor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_NewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_SaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_File_CloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Edit_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Edit_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Edit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Format_Bold = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Format_Italic = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Format_Underlined = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Format_Strikeout = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Format_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Format_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Compile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Compile_Run = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help_Readme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.timerAutoSave = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenu_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenu_SelectionFont = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenu_Bold = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_Italic = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_Underlined = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_Strikeout = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File,
            this.menu_Edit,
            this.menu_Format,
            this.menu_Compile,
            this.menu_Settings,
            this.menu_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip2";
            // 
            // menu_File
            // 
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File_New,
            this.menu_File_NewWindow,
            this.menu_File_Open,
            this.menu_File_Save,
            this.menu_File_SaveAs,
            this.menu_File_SaveAll,
            this.menu_File_Separator1,
            this.menu_File_CloseFile,
            this.menu_File_Separator2,
            this.menu_File_Exit});
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(37, 20);
            this.menu_File.Text = "File";
            // 
            // menu_File_New
            // 
            this.menu_File_New.Name = "menu_File_New";
            this.menu_File_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_File_New.Size = new System.Drawing.Size(220, 22);
            this.menu_File_New.Text = "New";
            this.menu_File_New.Click += new System.EventHandler(this.menu_File_New_Click);
            // 
            // menu_File_NewWindow
            // 
            this.menu_File_NewWindow.Name = "menu_File_NewWindow";
            this.menu_File_NewWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.menu_File_NewWindow.Size = new System.Drawing.Size(220, 22);
            this.menu_File_NewWindow.Text = "New Window";
            this.menu_File_NewWindow.Click += new System.EventHandler(this.menu_File_NewWindow_Click);
            // 
            // menu_File_Open
            // 
            this.menu_File_Open.Name = "menu_File_Open";
            this.menu_File_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menu_File_Open.Size = new System.Drawing.Size(220, 22);
            this.menu_File_Open.Text = "Open";
            this.menu_File_Open.Click += new System.EventHandler(this.menu_File_Open_Click);
            // 
            // menu_File_Save
            // 
            this.menu_File_Save.Name = "menu_File_Save";
            this.menu_File_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menu_File_Save.Size = new System.Drawing.Size(220, 22);
            this.menu_File_Save.Text = "Save";
            this.menu_File_Save.Click += new System.EventHandler(this.menu_File_Save_Click);
            // 
            // menu_File_SaveAs
            // 
            this.menu_File_SaveAs.Name = "menu_File_SaveAs";
            this.menu_File_SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menu_File_SaveAs.Size = new System.Drawing.Size(220, 22);
            this.menu_File_SaveAs.Text = "Save as...";
            this.menu_File_SaveAs.Click += new System.EventHandler(this.menu_File_SaveAs_Click);
            // 
            // menu_File_SaveAll
            // 
            this.menu_File_SaveAll.Name = "menu_File_SaveAll";
            this.menu_File_SaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.menu_File_SaveAll.Size = new System.Drawing.Size(220, 22);
            this.menu_File_SaveAll.Text = "Save All";
            this.menu_File_SaveAll.Click += new System.EventHandler(this.menu_File_SaveAll_Click);
            // 
            // menu_File_Separator1
            // 
            this.menu_File_Separator1.Name = "menu_File_Separator1";
            this.menu_File_Separator1.Size = new System.Drawing.Size(217, 6);
            // 
            // menu_File_CloseFile
            // 
            this.menu_File_CloseFile.Name = "menu_File_CloseFile";
            this.menu_File_CloseFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menu_File_CloseFile.Size = new System.Drawing.Size(220, 22);
            this.menu_File_CloseFile.Text = "Close file";
            this.menu_File_CloseFile.Click += new System.EventHandler(this.menu_File_CloseFile_Click);
            // 
            // menu_File_Separator2
            // 
            this.menu_File_Separator2.Name = "menu_File_Separator2";
            this.menu_File_Separator2.Size = new System.Drawing.Size(217, 6);
            // 
            // menu_File_Exit
            // 
            this.menu_File_Exit.Name = "menu_File_Exit";
            this.menu_File_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.menu_File_Exit.Size = new System.Drawing.Size(220, 22);
            this.menu_File_Exit.Text = "Exit";
            this.menu_File_Exit.Click += new System.EventHandler(this.menu_File_Exit_Click);
            // 
            // menu_Edit
            // 
            this.menu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Edit_Copy,
            this.menu_Edit_Paste,
            this.menu_Edit_Cut,
            this.menu_Edit_Delete,
            this.menu_Edit_Separator1,
            this.menu_Edit_SelectAll});
            this.menu_Edit.Name = "menu_Edit";
            this.menu_Edit.Size = new System.Drawing.Size(39, 20);
            this.menu_Edit.Text = "Edit";
            // 
            // menu_Edit_Copy
            // 
            this.menu_Edit_Copy.Name = "menu_Edit_Copy";
            this.menu_Edit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menu_Edit_Copy.Size = new System.Drawing.Size(180, 22);
            this.menu_Edit_Copy.Text = "Copy";
            this.menu_Edit_Copy.Click += new System.EventHandler(this.menu_Edit_Copy_Click);
            // 
            // menu_Edit_Paste
            // 
            this.menu_Edit_Paste.Name = "menu_Edit_Paste";
            this.menu_Edit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menu_Edit_Paste.Size = new System.Drawing.Size(180, 22);
            this.menu_Edit_Paste.Text = "Paste";
            this.menu_Edit_Paste.Click += new System.EventHandler(this.menu_Edit_Paste_Click);
            // 
            // menu_Edit_Cut
            // 
            this.menu_Edit_Cut.Name = "menu_Edit_Cut";
            this.menu_Edit_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menu_Edit_Cut.Size = new System.Drawing.Size(180, 22);
            this.menu_Edit_Cut.Text = "Cut";
            this.menu_Edit_Cut.Click += new System.EventHandler(this.menu_Edit_Cut_Click);
            // 
            // menu_Edit_Delete
            // 
            this.menu_Edit_Delete.Name = "menu_Edit_Delete";
            this.menu_Edit_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menu_Edit_Delete.Size = new System.Drawing.Size(180, 22);
            this.menu_Edit_Delete.Text = "Delete";
            this.menu_Edit_Delete.Click += new System.EventHandler(this.menu_Edit_Delete_Click);
            // 
            // menu_Edit_Separator1
            // 
            this.menu_Edit_Separator1.Name = "menu_Edit_Separator1";
            this.menu_Edit_Separator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menu_Edit_SelectAll
            // 
            this.menu_Edit_SelectAll.Name = "menu_Edit_SelectAll";
            this.menu_Edit_SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menu_Edit_SelectAll.Size = new System.Drawing.Size(180, 22);
            this.menu_Edit_SelectAll.Text = "Select All";
            this.menu_Edit_SelectAll.Click += new System.EventHandler(this.menu_Edit_SelectAll_Click);
            // 
            // menu_Format
            // 
            this.menu_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Format_Bold,
            this.menu_Format_Italic,
            this.menu_Format_Underlined,
            this.menu_Format_Strikeout,
            this.menu_Format_Separator1,
            this.menu_Format_Font});
            this.menu_Format.Name = "menu_Format";
            this.menu_Format.Size = new System.Drawing.Size(57, 20);
            this.menu_Format.Text = "Format";
            // 
            // menu_Format_Bold
            // 
            this.menu_Format_Bold.Name = "menu_Format_Bold";
            this.menu_Format_Bold.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menu_Format_Bold.Size = new System.Drawing.Size(180, 22);
            this.menu_Format_Bold.Text = "Bold";
            this.menu_Format_Bold.Click += new System.EventHandler(this.menu_Format_Bold_Click);
            // 
            // menu_Format_Italic
            // 
            this.menu_Format_Italic.Name = "menu_Format_Italic";
            this.menu_Format_Italic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menu_Format_Italic.Size = new System.Drawing.Size(180, 22);
            this.menu_Format_Italic.Text = "Italic";
            this.menu_Format_Italic.Click += new System.EventHandler(this.menu_Format_Italic_Click);
            // 
            // menu_Format_Underlined
            // 
            this.menu_Format_Underlined.Name = "menu_Format_Underlined";
            this.menu_Format_Underlined.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menu_Format_Underlined.Size = new System.Drawing.Size(180, 22);
            this.menu_Format_Underlined.Text = "Underlined";
            this.menu_Format_Underlined.Click += new System.EventHandler(this.menu_Format_Underlined_Click);
            // 
            // menu_Format_Strikeout
            // 
            this.menu_Format_Strikeout.Name = "menu_Format_Strikeout";
            this.menu_Format_Strikeout.Size = new System.Drawing.Size(180, 22);
            this.menu_Format_Strikeout.Text = "Strikeout";
            this.menu_Format_Strikeout.Click += new System.EventHandler(this.menu_Format_Strikeout_Click);
            // 
            // menu_Format_Separator1
            // 
            this.menu_Format_Separator1.Name = "menu_Format_Separator1";
            this.menu_Format_Separator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menu_Format_Font
            // 
            this.menu_Format_Font.Name = "menu_Format_Font";
            this.menu_Format_Font.Size = new System.Drawing.Size(180, 22);
            this.menu_Format_Font.Text = "Font...";
            this.menu_Format_Font.Click += new System.EventHandler(this.menu_Format_Font_Click);
            // 
            // menu_Compile
            // 
            this.menu_Compile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Compile_Run});
            this.menu_Compile.Name = "menu_Compile";
            this.menu_Compile.Size = new System.Drawing.Size(64, 20);
            this.menu_Compile.Text = "Compile";
            // 
            // menu_Compile_Run
            // 
            this.menu_Compile_Run.Name = "menu_Compile_Run";
            this.menu_Compile_Run.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menu_Compile_Run.Size = new System.Drawing.Size(180, 22);
            this.menu_Compile_Run.Text = "Run";
            this.menu_Compile_Run.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // menu_Settings
            // 
            this.menu_Settings.Name = "menu_Settings";
            this.menu_Settings.Size = new System.Drawing.Size(61, 20);
            this.menu_Settings.Text = "Settings";
            this.menu_Settings.Click += new System.EventHandler(this.menu_Settings_Click);
            // 
            // menu_Help
            // 
            this.menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Help_Readme,
            this.toolStripMenuItem5,
            this.menu_Help_About});
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.Size = new System.Drawing.Size(44, 20);
            this.menu_Help.Text = "Help";
            // 
            // menu_Help_Readme
            // 
            this.menu_Help_Readme.Name = "menu_Help_Readme";
            this.menu_Help_Readme.Size = new System.Drawing.Size(117, 22);
            this.menu_Help_Readme.Text = "Readme";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(114, 6);
            // 
            // menu_Help_About
            // 
            this.menu_Help_About.Name = "menu_Help_About";
            this.menu_Help_About.Size = new System.Drawing.Size(117, 22);
            this.menu_Help_About.Text = "About";
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 426);
            this.tabControl.TabIndex = 2;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            // 
            // timerAutoSave
            // 
            this.timerAutoSave.Enabled = true;
            this.timerAutoSave.Interval = 1000;
            this.timerAutoSave.Tick += new System.EventHandler(this.timerAutoSave_Tick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.contextMenu_Copy,
            this.contextMenu_Paste,
            this.contextMenu_Cut,
            this.contextMenu_Delete,
            this.toolStripMenuItem1,
            this.contextMenu_SelectionFont,
            this.contextMenu_SelectAll,
            this.toolStripMenuItem2,
            this.contextMenu_Bold,
            this.contextMenu_Italic,
            this.contextMenu_Underlined,
            this.contextMenu_Strikeout});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 308);
            // 
            // contextMenu_Copy
            // 
            this.contextMenu_Copy.Name = "contextMenu_Copy";
            this.contextMenu_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.contextMenu_Copy.Size = new System.Drawing.Size(180, 22);
            this.contextMenu_Copy.Text = "Copy";
            this.contextMenu_Copy.Click += new System.EventHandler(this.menu_Edit_Copy_Click);
            // 
            // contextMenu_Paste
            // 
            this.contextMenu_Paste.Name = "contextMenu_Paste";
            this.contextMenu_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.contextMenu_Paste.Size = new System.Drawing.Size(180, 22);
            this.contextMenu_Paste.Text = "Paste";
            this.contextMenu_Paste.Click += new System.EventHandler(this.menu_Edit_Paste_Click);
            // 
            // contextMenu_Cut
            // 
            this.contextMenu_Cut.Name = "contextMenu_Cut";
            this.contextMenu_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.contextMenu_Cut.Size = new System.Drawing.Size(180, 22);
            this.contextMenu_Cut.Text = "Cut";
            this.contextMenu_Cut.Click += new System.EventHandler(this.menu_Edit_Cut_Click);
            // 
            // contextMenu_Delete
            // 
            this.contextMenu_Delete.Name = "contextMenu_Delete";
            this.contextMenu_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.contextMenu_Delete.Size = new System.Drawing.Size(180, 22);
            this.contextMenu_Delete.Text = "Delete";
            this.contextMenu_Delete.Click += new System.EventHandler(this.menu_Edit_Delete_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // contextMenu_SelectionFont
            // 
            this.contextMenu_SelectionFont.Name = "contextMenu_SelectionFont";
            this.contextMenu_SelectionFont.Size = new System.Drawing.Size(180, 22);
            this.contextMenu_SelectionFont.Text = "Selection Font...";
            this.contextMenu_SelectionFont.Click += new System.EventHandler(this.contextMenu_SelectionFont_Click);
            // 
            // contextMenu_SelectAll
            // 
            this.contextMenu_SelectAll.Name = "contextMenu_SelectAll";
            this.contextMenu_SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.contextMenu_SelectAll.Size = new System.Drawing.Size(180, 22);
            this.contextMenu_SelectAll.Text = "Select All";
            this.contextMenu_SelectAll.Click += new System.EventHandler(this.menu_Edit_SelectAll_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // contextMenu_Bold
            // 
            this.contextMenu_Bold.Name = "contextMenu_Bold";
            this.contextMenu_Bold.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.contextMenu_Bold.Size = new System.Drawing.Size(180, 22);
            this.contextMenu_Bold.Text = "Bold";
            this.contextMenu_Bold.Click += new System.EventHandler(this.menu_Format_Bold_Click);
            // 
            // contextMenu_Italic
            // 
            this.contextMenu_Italic.Name = "contextMenu_Italic";
            this.contextMenu_Italic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.contextMenu_Italic.Size = new System.Drawing.Size(180, 22);
            this.contextMenu_Italic.Text = "Italic";
            this.contextMenu_Italic.Click += new System.EventHandler(this.menu_Format_Italic_Click);
            // 
            // contextMenu_Underlined
            // 
            this.contextMenu_Underlined.Name = "contextMenu_Underlined";
            this.contextMenu_Underlined.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.contextMenu_Underlined.Size = new System.Drawing.Size(180, 22);
            this.contextMenu_Underlined.Text = "Underlined";
            this.contextMenu_Underlined.Click += new System.EventHandler(this.menu_Format_Underlined_Click);
            // 
            // contextMenu_Strikeout
            // 
            this.contextMenu_Strikeout.Name = "contextMenu_Strikeout";
            this.contextMenu_Strikeout.Size = new System.Drawing.Size(180, 22);
            this.contextMenu_Strikeout.Text = "Strikeout";
            this.contextMenu_Strikeout.Click += new System.EventHandler(this.menu_Format_Strikeout_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "PeerTextEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BackColorChanged += new System.EventHandler(this.MainForm_BackColorChanged);
            this.ForeColorChanged += new System.EventHandler(this.MainForm_ForeColorChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;

        private System.Windows.Forms.ToolStripMenuItem menu_File;
        
        private System.Windows.Forms.ToolStripMenuItem menu_File_New;
        private System.Windows.Forms.ToolStripMenuItem menu_File_NewWindow;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Open;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Save;
        private System.Windows.Forms.ToolStripMenuItem menu_File_SaveAs;
        private System.Windows.Forms.ToolStripSeparator menu_File_Separator1;
        private System.Windows.Forms.ToolStripMenuItem menu_File_CloseFile;
        private System.Windows.Forms.ToolStripSeparator menu_File_Separator2;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Exit;


        private System.Windows.Forms.ToolStripMenuItem menu_Edit;
        private System.Windows.Forms.ToolStripMenuItem menu_Edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem menu_Edit_Paste;
        private System.Windows.Forms.ToolStripMenuItem menu_Edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem menu_Edit_Delete;
        private System.Windows.Forms.ToolStripSeparator menu_Edit_Separator1;
        private System.Windows.Forms.ToolStripMenuItem menu_Edit_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem menu_Format;
        private System.Windows.Forms.ToolStripMenuItem menu_Format_Bold;
        private System.Windows.Forms.ToolStripMenuItem menu_Format_Italic;
        private System.Windows.Forms.ToolStripMenuItem menu_Format_Underlined;
        private System.Windows.Forms.ToolStripMenuItem menu_Format_Strikeout;
        private System.Windows.Forms.ToolStripSeparator menu_Format_Separator1;
        private System.Windows.Forms.ToolStripMenuItem menu_Format_Font;
        private System.Windows.Forms.ToolStripMenuItem menu_Compile;
        private System.Windows.Forms.ToolStripMenuItem menu_Settings;
        private System.Windows.Forms.ToolStripMenuItem menu_Help;
        private System.Windows.Forms.ToolStripMenuItem menu_Help_Readme;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menu_Help_About;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem menu_Compile_Run;
        private System.Windows.Forms.Timer timerAutoSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Copy;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Paste;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Cut;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_SelectionFont;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_SelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Bold;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Italic;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Underlined;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Strikeout;
        private System.Windows.Forms.ToolStripMenuItem menu_File_SaveAll;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    }
}
