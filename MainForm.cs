using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PeerTextEditor
{
    public partial class MainForm : Form
    {
        private bool hideOnlyForm;
        private static int formsOpenedCount = 0;
        private static int autoSaveIntervalSeconds { get; set; }
        private static FileInfo compilerFile { get; set; }
        private int timePassed = 0;
        public MainForm(bool createNewFile = false, bool hideOnlyForm = true)
        {
            InitializeComponent();
            this.hideOnlyForm = hideOnlyForm;
            formsOpenedCount += 1;
            autoSaveIntervalSeconds = 120;
            timerAutoSave.Start();
            if (createNewFile)
                menu_File_New_Click(this, new EventArgs());
        }

        private TabPage newTabPage(string filePath = "X:/")
        {
            return new FileTabPage(new RichTextBox(), filePath);
        }

        private void menu_File_New_Click(object sender, EventArgs e)
        {
            TabPage tp = newTabPage();
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
            rtb.SelectionFont = new Font(rtb.Font.FontFamily, rtb.Font.Size, rtb.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void menu_Format_Italic_Click(object sender, EventArgs e)
        {
            TabPage fileTabPage = tabControl.SelectedTab;
            if (fileTabPage == null)
                return;
            var rtb = (fileTabPage as FileTabPage)?.Rtb;
            rtb.SelectionFont = new Font(rtb.Font.FontFamily, rtb.Font.Size, rtb.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void menu_Format_Underlined_Click(object sender, EventArgs e)
        {
            TabPage fileTabPage = tabControl.SelectedTab;
            if (fileTabPage == null)
                return;
            var rtb = (fileTabPage as FileTabPage)?.Rtb;
            rtb.SelectionFont = new Font(rtb.Font.FontFamily, rtb.Font.Size, rtb.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void menu_Format_Strikeout_Click(object sender, EventArgs e)
        {
            TabPage fileTabPage = tabControl.SelectedTab;
            if (fileTabPage == null)
                return;
            var rtb = (fileTabPage as FileTabPage)?.Rtb;
            rtb.SelectionFont = new Font(rtb.Font.FontFamily, rtb.Font.Size, rtb.SelectionFont.Style ^ FontStyle.Strikeout);
        }

        private void menu_Format_Font_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new())
            {
                switch (fontDialog.ShowDialog())
                {
                    case DialogResult.OK:
                        foreach (var tab in tabControl.TabPages)
                        {
                            (tab as FileTabPage).Rtb.Font = fontDialog.Font;
                        }
                        FileTabPage.DefaultFont = fontDialog.Font;
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
            SettingsForm settings = new(autoSaveIntervalSeconds);
            switch (settings.ShowDialog())
            {
                case DialogResult.OK:
                    autoSaveIntervalSeconds = settings.seconds;
                    compilerFile = settings.fileInfo;
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var tbps = tabControl.TabPages;
            foreach (TabPage tab in tbps)
            {
                if ((tab as FileTabPage).IsSaved)
                    continue;
                tabControl.SelectedTab = tab;
                switch(askForSave(tab as FileTabPage))
                {
                    case DialogResult.Yes:
                        if(!(tab as FileTabPage).SaveFile())
                        {
                            e.Cancel = true;
                            return;
                        }
                        else
                            tabControl.TabPages.Remove(tab);
                        break;
                    case DialogResult.No:
                        tabControl.TabPages.Remove(tab);
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                }
            }
            formsOpenedCount -= 1;

            if(formsOpenedCount <= 0)
                System.Environment.Exit(0);

            if (hideOnlyForm)
            {
                this.Hide();
                e.Cancel = true;
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
            if (compilerFile == null)
            {
                MessageBox.Show("Please select compiler file in settings", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
                
            psi.FileName = @compilerFile.FullName;
            psi.Arguments = $"\"{filePath}";
            //psi.UseShellExecute = false;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;

            var results = "";
            try
            {
                using (var process = Process.Start(psi))
                {
                    results = process.StandardOutput.ReadToEnd();
                }
                MessageBox.Show(results);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

