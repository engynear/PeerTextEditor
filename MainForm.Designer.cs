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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_NewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
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
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help_Readme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.timerAutoSave = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File,
            this.menu_Edit,
            this.menu_Format,
            this.menu_Compile,
            this.menu_Settings,
            this.menu_Help});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // menu_File
            // 
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File_New,
            this.menu_File_NewWindow,
            this.menu_File_Open,
            this.menu_File_Save,
            this.menu_File_SaveAs,
            this.menu_File_Separator1,
            this.menu_File_CloseFile,
            this.menu_File_Separator2,
            this.menu_File_Exit});
            this.menu_File.Name = "menu_File";
            resources.ApplyResources(this.menu_File, "menu_File");
            // 
            // menu_File_New
            // 
            this.menu_File_New.Name = "menu_File_New";
            resources.ApplyResources(this.menu_File_New, "menu_File_New");
            this.menu_File_New.Click += new System.EventHandler(this.menu_File_New_Click);
            // 
            // menu_File_NewWindow
            // 
            this.menu_File_NewWindow.Name = "menu_File_NewWindow";
            resources.ApplyResources(this.menu_File_NewWindow, "menu_File_NewWindow");
            this.menu_File_NewWindow.Click += new System.EventHandler(this.menu_File_NewWindow_Click);
            // 
            // menu_File_Open
            // 
            this.menu_File_Open.Name = "menu_File_Open";
            resources.ApplyResources(this.menu_File_Open, "menu_File_Open");
            this.menu_File_Open.Click += new System.EventHandler(this.menu_File_Open_Click);
            // 
            // menu_File_Save
            // 
            this.menu_File_Save.Name = "menu_File_Save";
            resources.ApplyResources(this.menu_File_Save, "menu_File_Save");
            this.menu_File_Save.Click += new System.EventHandler(this.menu_File_Save_Click);
            // 
            // menu_File_SaveAs
            // 
            this.menu_File_SaveAs.Name = "menu_File_SaveAs";
            resources.ApplyResources(this.menu_File_SaveAs, "menu_File_SaveAs");
            this.menu_File_SaveAs.Click += new System.EventHandler(this.menu_File_SaveAs_Click);
            // 
            // menu_File_Separator1
            // 
            this.menu_File_Separator1.Name = "menu_File_Separator1";
            resources.ApplyResources(this.menu_File_Separator1, "menu_File_Separator1");
            // 
            // menu_File_CloseFile
            // 
            this.menu_File_CloseFile.Name = "menu_File_CloseFile";
            resources.ApplyResources(this.menu_File_CloseFile, "menu_File_CloseFile");
            this.menu_File_CloseFile.Click += new System.EventHandler(this.menu_File_CloseFile_Click);
            // 
            // menu_File_Separator2
            // 
            this.menu_File_Separator2.Name = "menu_File_Separator2";
            resources.ApplyResources(this.menu_File_Separator2, "menu_File_Separator2");
            // 
            // menu_File_Exit
            // 
            this.menu_File_Exit.Name = "menu_File_Exit";
            resources.ApplyResources(this.menu_File_Exit, "menu_File_Exit");
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
            resources.ApplyResources(this.menu_Edit, "menu_Edit");
            // 
            // menu_Edit_Copy
            // 
            this.menu_Edit_Copy.Name = "menu_Edit_Copy";
            resources.ApplyResources(this.menu_Edit_Copy, "menu_Edit_Copy");
            this.menu_Edit_Copy.Click += new System.EventHandler(this.menu_Edit_Copy_Click);
            // 
            // menu_Edit_Paste
            // 
            this.menu_Edit_Paste.Name = "menu_Edit_Paste";
            resources.ApplyResources(this.menu_Edit_Paste, "menu_Edit_Paste");
            this.menu_Edit_Paste.Click += new System.EventHandler(this.menu_Edit_Paste_Click);
            // 
            // menu_Edit_Cut
            // 
            this.menu_Edit_Cut.Name = "menu_Edit_Cut";
            resources.ApplyResources(this.menu_Edit_Cut, "menu_Edit_Cut");
            this.menu_Edit_Cut.Click += new System.EventHandler(this.menu_Edit_Cut_Click);
            // 
            // menu_Edit_Delete
            // 
            this.menu_Edit_Delete.Name = "menu_Edit_Delete";
            resources.ApplyResources(this.menu_Edit_Delete, "menu_Edit_Delete");
            this.menu_Edit_Delete.Click += new System.EventHandler(this.menu_Edit_Delete_Click);
            // 
            // menu_Edit_Separator1
            // 
            this.menu_Edit_Separator1.Name = "menu_Edit_Separator1";
            resources.ApplyResources(this.menu_Edit_Separator1, "menu_Edit_Separator1");
            // 
            // menu_Edit_SelectAll
            // 
            this.menu_Edit_SelectAll.Name = "menu_Edit_SelectAll";
            resources.ApplyResources(this.menu_Edit_SelectAll, "menu_Edit_SelectAll");
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
            resources.ApplyResources(this.menu_Format, "menu_Format");
            // 
            // menu_Format_Bold
            // 
            this.menu_Format_Bold.Name = "menu_Format_Bold";
            resources.ApplyResources(this.menu_Format_Bold, "menu_Format_Bold");
            this.menu_Format_Bold.Click += new System.EventHandler(this.menu_Format_Bold_Click);
            // 
            // menu_Format_Italic
            // 
            this.menu_Format_Italic.Name = "menu_Format_Italic";
            resources.ApplyResources(this.menu_Format_Italic, "menu_Format_Italic");
            this.menu_Format_Italic.Click += new System.EventHandler(this.menu_Format_Italic_Click);
            // 
            // menu_Format_Underlined
            // 
            this.menu_Format_Underlined.Name = "menu_Format_Underlined";
            resources.ApplyResources(this.menu_Format_Underlined, "menu_Format_Underlined");
            this.menu_Format_Underlined.Click += new System.EventHandler(this.menu_Format_Underlined_Click);
            // 
            // menu_Format_Strikeout
            // 
            this.menu_Format_Strikeout.Name = "menu_Format_Strikeout";
            resources.ApplyResources(this.menu_Format_Strikeout, "menu_Format_Strikeout");
            this.menu_Format_Strikeout.Click += new System.EventHandler(this.menu_Format_Strikeout_Click);
            // 
            // menu_Format_Separator1
            // 
            this.menu_Format_Separator1.Name = "menu_Format_Separator1";
            resources.ApplyResources(this.menu_Format_Separator1, "menu_Format_Separator1");
            // 
            // menu_Format_Font
            // 
            this.menu_Format_Font.Name = "menu_Format_Font";
            resources.ApplyResources(this.menu_Format_Font, "menu_Format_Font");
            this.menu_Format_Font.Click += new System.EventHandler(this.menu_Format_Font_Click);
            // 
            // menu_Compile
            // 
            this.menu_Compile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem});
            this.menu_Compile.Name = "menu_Compile";
            resources.ApplyResources(this.menu_Compile, "menu_Compile");
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            resources.ApplyResources(this.runToolStripMenuItem, "runToolStripMenuItem");
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // menu_Settings
            // 
            this.menu_Settings.Name = "menu_Settings";
            resources.ApplyResources(this.menu_Settings, "menu_Settings");
            this.menu_Settings.Click += new System.EventHandler(this.menu_Settings_Click);
            // 
            // menu_Help
            // 
            this.menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Help_Readme,
            this.toolStripMenuItem5,
            this.menu_Help_About});
            this.menu_Help.Name = "menu_Help";
            resources.ApplyResources(this.menu_Help, "menu_Help");
            // 
            // menu_Help_Readme
            // 
            this.menu_Help_Readme.Name = "menu_Help_Readme";
            resources.ApplyResources(this.menu_Help_Readme, "menu_Help_Readme");
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // menu_Help_About
            // 
            this.menu_Help_About.Name = "menu_Help_About";
            resources.ApplyResources(this.menu_Help_About, "menu_Help_About");
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // timerAutoSave
            // 
            this.timerAutoSave.Enabled = true;
            this.timerAutoSave.Interval = 1000;
            this.timerAutoSave.Tick += new System.EventHandler(this.timerAutoSave_Tick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.Timer timerAutoSave;
    }
}
