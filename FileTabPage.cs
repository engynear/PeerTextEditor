using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PeerTextEditor
{
    internal class FileTabPage : System.Windows.Forms.TabPage
    {
        public static new Font DefaultFont = new Font(FontFamily.GenericMonospace, 14f, FontStyle.Regular);
        public FileInfo FileInfo { set; get; }
        public bool IsSaved { set; get; }
        public RichTextBox Rtb { get; private set; }
        private bool isFileRtf
        {
            get { return FileInfo.Extension.ToLower().Equals(".rtf"); }
        }
        public FileTabPage(RichTextBox textBox, string filePath = "C:/") : base()
        {
            Rtb = textBox;
            Rtb.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            Rtb.Dock = DockStyle.Fill;
            Rtb.WordWrap = false;
            Rtb.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            Rtb.TextChanged += new System.EventHandler(rtb_TextChanged);
            Rtb.Font = DefaultFont;

            try
            {
                FileInfo = new FileInfo(filePath);
            }
            catch (Exception)
            {
                FileInfo = new FileInfo(Directory.GetCurrentDirectory());
            }


            if (FileInfo.Name.Length > 0)
                this.Text = FileInfo.Name;
            else
                this.Text = "Untitled";

            if (File.Exists(FileInfo.FullName))
            {
                try
                {
                    if (isFileRtf)
                    {
                        Rtb.LoadFile(FileInfo.FullName);
                    }
                    else
                    {
                        Rtb.Text = File.ReadAllText(FileInfo.FullName);
                    }
                    IsSaved = true;
                    Controls.Add(Rtb);
                }
                catch (ArgumentException e)
                {
                    string message;
                    if (isFileRtf)
                        message = "Rtf format is not valid";
                    else
                        message = e.Message;
                    MessageBox.Show(message, "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }

            }
            else
            {
                IsSaved = true;
                Controls.Add(Rtb);
            }


        }

        public bool SaveFile(bool forceSaveAs = false, string savePath = "", bool showErrorMessages = false, bool saveIfNeverSaved = true)
        {
            if(!FileInfo.Exists && !saveIfNeverSaved)
                return true;
            if (IsSaved && !forceSaveAs)
                return true;

            if ((!FileInfo.Exists && savePath.Equals("")) || forceSaveAs)
            {
                SaveFileDialog saveFileDialog = getSaveFileDialog();
                switch (saveFileDialog.ShowDialog())
                {
                    case DialogResult.OK:
                        savePath = saveFileDialog.FileName;
                        break;
                    default:
                        return false;
                }
            }

            if (savePath.Equals(""))
                savePath = FileInfo.FullName;
            try
            {
                if (savePath.EndsWith(".rtf"))
                    Rtb.SaveFile(savePath);
                else
                {
                    using (StreamWriter sw = new StreamWriter(savePath))
                    {
                        sw.Write(Rtb.Text);
                    }
                }
                FileInfo = new FileInfo(savePath);
                this.Text = FileInfo.Name;
            }
            catch (Exception e)
            {
                if (showErrorMessages)
                {
                    MessageBox.Show(e.Message, "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }
                return false;
            }
            IsSaved = true;
            return true;
        }

        private SaveFileDialog getSaveFileDialog()
        {
            SaveFileDialog saveFileDialog1 = new();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|Text in RTF format (*.rtf)|*.rtf|C# files (*.cs)|*.cs|All files (*.*)|*.*";
            saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(FileInfo.FullName);
            saveFileDialog1.InitialDirectory = FileInfo.FullName;
            saveFileDialog1.RestoreDirectory = true;

            return saveFileDialog1;
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;
            FileTabPage ftp = rtb.Parent as FileTabPage;
            if (ftp == null)
                return;
            if (ftp.IsSaved)
            {
                ftp.Text = ftp.Text.Trim() + "*";
            }
            ftp.IsSaved = false;
        }
    }
}
