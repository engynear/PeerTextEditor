using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeerTextEditor
{
    public partial class SettingsForm : Form
    {
        public FileInfo fileInfo
        {
            get; private set;
        }
        public int seconds {
            get; private set;
        }

        public Color color
        {
            get; private set;
        }

        public Color foreColor
        {
            get; private set;
        }
        public SettingsForm(Form owner)
        {
            InitializeComponent();
            numeric_AutoSaveSeconds.Value = 10;
            Owner = owner;
            seconds = 10;
            fileInfo = new("C:/");
            color = Owner.BackColor;
            foreColor = Owner.ForeColor;
            btn_PickBackColor.BackColor = color;
            btn_ForeColor.BackColor = foreColor;
        }

        private void label_AutoSaveInterval_Click(object sender, EventArgs e)
        {

        }

        private void numeric_AutoSaveSeconds_ValueChanged(object sender, EventArgs e)
        {
            if(numeric_AutoSaveSeconds.Value >= 60)
            {
                numeric_AutoSaveSeconds.Value = 0;
                numeric_AutoSaveMinutes.Value += 1;
            }
        }

        private void numeric_AutoSaveMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (numeric_AutoSaveMinutes.Value >= 60)
            {
                numeric_AutoSaveMinutes.Value = 0;
                numeric_AutoSaveHours.Value += 1;
            }
        }

        private void numeric_AutoSaveHours_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            seconds = (int)(numeric_AutoSaveSeconds.Value +
                    (numeric_AutoSaveMinutes.Value * 60) +
                    (numeric_AutoSaveHours.Value * 360));
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            seconds = 0;
            this.Close();
        }

        private void btn_PickCompilerFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new())
            {
                switch (openFileDialog.ShowDialog())
                {
                    case DialogResult.OK:
                        fileInfo = new FileInfo(openFileDialog.FileName);
                        btn_PickCompilerFile.Text = fileInfo.Name;
                        break;
                }
            }
        }

        private void btn_PickBackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new())
            {
                switch (colorDialog.ShowDialog())
                {
                    case DialogResult.OK:
                        color = colorDialog.Color;
                        btn_PickBackColor.BackColor = color;
                        break;
                }
            }
        }

        private void btn_ForeColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new())
            {
                switch (colorDialog.ShowDialog())
                {
                    case DialogResult.OK:
                        foreColor = colorDialog.Color;
                        btn_ForeColor.BackColor = foreColor;
                        break;
                }
            }
        }
    }
}
