using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PeerTextEditor
{
    public partial class MainForm : Form
    {
        private Color formColor = Color.SeaShell;
        private Color formForeColor = Color.Black;
       
        private SettingsForm settings;

        private bool hideOnlyForm;
        private static int formsOpenedCount = 0;
        private static int autoSaveIntervalSeconds { get; set; }
        private static FileInfo compilerFile { get; set; }
        private int timePassed = 0;
        public MainForm(bool createNewFile = false, bool hideOnlyForm = true)
        {
            InitializeComponent();
            settings = new(this);
            
            this.BackColor = formColor;
            this.ForeColor = formForeColor;
            menuStrip.BackColor = formColor;
            this.hideOnlyForm = hideOnlyForm;
            formsOpenedCount += 1;
            autoSaveIntervalSeconds = 10;
            timerAutoSave.Start();
            menu_Compile_Run.Text = "Run (/w "+ compilerFile?.Name + ")";
            if (createNewFile)
                menu_File_New_Click(this, new EventArgs());
        }

        private TabPage newTabPage(string filePath = "C:/")
        {
            return new FileTabPage(new RichTextBox(), filePath);
        }

        private void menu_File_New_Click(object sender, EventArgs e)
        {
            TabPage tp = newTabPage();
            (tp as FileTabPage).Rtb.ContextMenuStrip = contextMenuStrip;
            tabControl.TabPages.Add(tp);
            tabControl.SelectedTab = tp;
        }

        private void menu_File_NewWindow_Click(object sender, EventArgs e)
        {
            new MainForm(createNewFile: true, hideOnlyForm: false).Show();
        }

        private void menu_File_Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "Text files (*.txt)|*.txt|Text in RTF format (*.rtf)|*.rtf|C# files (*.cs)|*.cs|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    TabPage tp = newTabPage(fileName);
                    (tp as FileTabPage).Rtb.ContextMenuStrip = contextMenuStrip;
                    tabControl.TabPages.Add(tp);
                    tabControl.SelectedTab = tp;
                }
            }
        }
        private void menu_File_Save_Click(object sender, EventArgs e)
        {
            (tabControl.SelectedTab as FileTabPage)?.SaveFile(showErrorMessages: true);
        }

        private void menu_File_SaveAs_Click(object sender, EventArgs e)
        {
            (tabControl.SelectedTab as FileTabPage)?.SaveFile(forceSaveAs: true, showErrorMessages: true);
        }

        private void menu_File_CloseFile_Click(object sender, EventArgs e)
        {
            TabPage tp = tabControl.SelectedTab;
            if (tp == null)
                return;
            FileTabPage ftp = tp as FileTabPage;
            if (!ftp.IsSaved)
                switch (askForSave(ftp))
                {
                    case DialogResult.Yes:
                        if (!ftp.SaveFile())
                            return;
                        break;
                    case DialogResult.No:
                        //pass
                        break;
                    default:
                        return;
                }


            tabControl.TabPages.Remove(tp);
        }

        private DialogResult askForSave(FileTabPage ftp)
        {
            string fileName = ftp.Text.Replace("*", "");
            string message = "Do you want to save " + fileName + " changes?";
            const string caption = "Save changes?";
            return MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Question);
        }

        private void menu_File_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_Edit_Copy_Click(object sender, EventArgs e)
        {
            TabPage fileTabPage = tabControl.SelectedTab;
            if (fileTabPage == null)
                return;
            string text = (fileTabPage as FileTabPage).Rtb.SelectedText;
            if (text.Length > 0)
                Clipboard.SetText(text);
        }

        private void menu_Edit_Paste_Click(object sender, EventArgs e)
        {
            TabPage fileTabPage = tabControl.SelectedTab;
            if (fileTabPage == null)
                return;
            if (Clipboard.ContainsText())
            {
                (fileTabPage as FileTabPage).Rtb.SelectedText = Clipboard.GetText();
            }
        }

        private void menu_Edit_Cut_Click(object sender, EventArgs e)
        {
            menu_Edit_Copy_Click(sender, e);
            menu_Edit_Delete_Click(sender, e);
        }

        private void menu_Edit_Delete_Click(object sender, EventArgs e)
        {
            TabPage fileTabPage = tabControl.SelectedTab;
            if (fileTabPage == null)
                return;
            (fileTabPage as FileTabPage).Rtb.SelectedText = "";
        }

        private void menu_Edit_SelectAll_Click(object sender, EventArgs e)
        {
            TabPage fileTabPage = tabControl.SelectedTab;
            if (fileTabPage == null)
                return;
            (fileTabPage as FileTabPage)?.Rtb.SelectAll();
        }

        private void menu_Format_Bold_Click(object sender, EventArgs e)
        {
            TabPage fileTabPage = tabControl.SelectedTab;
            if (fileTabPage == null)
                return;
            var rtb = (fileTabPage as FileTabPage)?.Rtb;
            rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size, rtb.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void menu_Format_Italic_Click(object sender, EventArgs e)
        {
            TabPage fileTabPage = tabControl.SelectedTab;
            if (fileTabPage == null)
                return;
            var rtb = (fileTabPage as FileTabPage)?.Rtb;
            rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size, rtb.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void menu_Format_Underlined_Click(object sender, EventArgs e)
        {
            TabPage fileTabPage = tabControl.SelectedTab;
            if (fileTabPage == null)
                return;
            var rtb = (fileTabPage as FileTabPage)?.Rtb;
            rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size, rtb.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void menu_Format_Strikeout_Click(object sender, EventArgs e)
        {
            TabPage fileTabPage = tabControl.SelectedTab;
            if (fileTabPage == null)
                return;
            var rtb = (fileTabPage as FileTabPage)?.Rtb;
            rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size, rtb.SelectionFont.Style ^ FontStyle.Strikeout);
        }

        private void menu_Format_Font_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new())
            {
                switch (fontDialog.ShowDialog())
                {
                    case DialogResult.OK:
                        TabPage fileTabPage = tabControl.SelectedTab;
                        if (fileTabPage == null)
                            return;
                        Font selFont = (fileTabPage as FileTabPage).Rtb.Font;
                        (fileTabPage as FileTabPage).Rtb.Font 
                            = new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size, selFont.Style);
                        //FileTabPage.DefaultFont = fontDialog.Font;
                        /*(tabControl.SelectedTab as FileTabPage).Rtb.SelectionFont = fontDialog.Font;*/
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        private void timerAutoSave_Tick(object sender, EventArgs e)
        {
            timePassed += 1;
            if (autoSaveIntervalSeconds <= timePassed)
            {
                timePassed = 0;
                foreach (var tab in tabControl.TabPages)
                {
                    (tab as FileTabPage).SaveFile(showErrorMessages: false, saveIfNeverSaved: false);
                }
            }
        }

        private void menu_Settings_Click(object sender, EventArgs e)
        {
            switch (settings.ShowDialog())
            {
                case DialogResult.OK:
                    autoSaveIntervalSeconds = settings.seconds;
                    compilerFile = settings.fileInfo;
                    menu_Compile_Run.Text = "Run (" + compilerFile?.Name + ")";
                    formColor = settings.color;
                    formForeColor = settings.foreColor;
                    this.BackColor = formColor;
                    this.ForeColor = formForeColor;
                    
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var tbps = tabControl.TabPages;

                if (File.Exists("settings.config"))
                {
                    File.Delete("settings.config");
                }
                using StreamWriter sw = new("settings.config");
                foreach (TabPage tab in tbps)
                {
                    if ((tab as FileTabPage).IsSaved)
                    {
                        sw.WriteLine("fileInfo " + (tab as FileTabPage).FileInfo.FullName);
                        continue;
                    }

                    tabControl.SelectedTab = tab;
                    switch (askForSave(tab as FileTabPage))
                    {
                        case DialogResult.Yes:
                            if (!(tab as FileTabPage).SaveFile())
                            {
                                e.Cancel = true;
                                return;
                            }
                            else
                            {
                                sw.WriteLine("fileInfo " + (tab as FileTabPage).FileInfo.FullName);
                            }
                            break;
                        case DialogResult.No:
                            tabControl.TabPages.Remove(tab);
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            return;
                    }
                }
                sw.WriteLine("backColor " + formColor.Name);
                sw.WriteLine("foreColor " + formForeColor.Name);
                sw.Close();
                formsOpenedCount -= 1;

                if (formsOpenedCount <= 0)
                    System.Environment.Exit(0);

                if (hideOnlyForm)
                {
                    this.Hide();
                    e.Cancel = true;
                }
            }catch(Exception)
            {

            }
            
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strCmdText;
            TabPage fileTabPage = tabControl.SelectedTab;
            if (fileTabPage == null)
                return;
            var rtb = (fileTabPage as FileTabPage)?.Rtb;
            string filePath = Directory.GetCurrentDirectory() + "/file.temp";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(rtb.Text);
            }
            ProcessStartInfo psi = new();
            if (compilerFile == null || compilerFile?.FullName == "C:/")
            {
                MessageBox.Show("Please select compiler file in settings", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                menu_Settings_Click(sender, e);
                return;
            }
                
            psi.FileName = @compilerFile.FullName;
            psi.Arguments = $"\"{filePath}";
            //psi.UseShellExecute = false;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            var results = "";
            var errors = "";
            try
            {
                using (var process = Process.Start(psi))
                {
                    results = process.StandardOutput.ReadToEnd();
                    errors = process.StandardError.ReadToEnd();
                }
                if(errors.Length > 0)
                    MessageBox.Show(errors, "Errors in program", icon: MessageBoxIcon.Error, buttons: MessageBoxButtons.OK);
                if(results.Length > 0)
                    MessageBox.Show(results, "Output", icon: MessageBoxIcon.Information, buttons: MessageBoxButtons.OK);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl.TabPages[e.Index];
            page.BackColor = formColor;
            Rectangle paddedBounds = e.Bounds;
            e.Graphics.FillRectangle(new SolidBrush(page.BackColor), paddedBounds);
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, page.ForeColor);
            
        }

        private void MainForm_BackColorChanged(object sender, EventArgs e)
        {
            menuStrip.BackColor = formColor;
            foreach(TabPage tp in tabControl.TabPages)
            {
                tp.BackColor = formColor;
                (tp as FileTabPage).Rtb.BackColor = formColor;
            }
        }

        private void MainForm_ForeColorChanged(object sender, EventArgs e)
        {
            menuStrip.ForeColor = formForeColor;
            foreach (TabPage tp in tabControl.TabPages)
            {
                tp.ForeColor = formForeColor;
                (tp as FileTabPage).Rtb.ForeColor = formForeColor;
            }
        }
        private void contextMenu_SelectionFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new())
            {
                switch (fontDialog.ShowDialog())
                {
                    case DialogResult.OK:
                        TabPage fileTabPage = tabControl.SelectedTab;
                        if (fileTabPage == null)
                            return;
                        Font selFont = (fileTabPage as FileTabPage).Rtb.SelectionFont;
                        (fileTabPage as FileTabPage).Rtb.SelectionFont
                            = new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size, selFont.Style);
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        private void menu_File_SaveAll_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl.TabPages)
            {
                if ((tab as FileTabPage).IsSaved)
                    continue;

                (tab as FileTabPage).SaveFile(showErrorMessages: true, saveIfNeverSaved: true);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!hideOnlyForm)
                return;
            try
            {
                if (!File.Exists("settings.config"))
                {
                    File.Create("settings.config");
                    File.SetAttributes("settings.config", FileAttributes.Hidden);
                }
                else
                {
                    string[] lines = File.ReadAllLines("settings.config");
                    foreach (string line in lines)
                    {
                        if (line.StartsWith("fileInfo"))
                        {
                            string filePath = line.Substring(9);
                            if (File.Exists(filePath))
                            {
                                TabPage tp = newTabPage(filePath);
                                (tp as FileTabPage).Rtb.ContextMenuStrip = contextMenuStrip;
                                tabControl.TabPages.Add(tp);
                                tabControl.SelectedTab = tp;
                            }
                        }
                        else if (line.StartsWith("backColor"))
                        {
                            string colorName = line.Substring(10);
                            BackColor = Color.FromName(colorName);
                            formColor = Color.FromName(colorName);
                        }
                        else if (line.StartsWith("foreColor"))
                        {
                            string colorName = line.Substring(10);
                            ForeColor = Color.FromName(colorName);
                            formForeColor = Color.FromName(colorName);
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}

