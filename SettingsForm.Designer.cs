namespace PeerTextEditor
{
    partial class SettingsForm
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
            this.label_AutoSaveInterval = new System.Windows.Forms.Label();
            this.numeric_AutoSaveHours = new System.Windows.Forms.NumericUpDown();
            this.label_AutoSaveHours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_AutoSaveMinutes = new System.Windows.Forms.NumericUpDown();
            this.label_AutoSaveSeconds = new System.Windows.Forms.Label();
            this.numeric_AutoSaveSeconds = new System.Windows.Forms.NumericUpDown();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label_PickCompilerFile = new System.Windows.Forms.Label();
            this.btn_PickCompilerFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AutoSaveHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AutoSaveMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AutoSaveSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // label_AutoSaveInterval
            // 
            this.label_AutoSaveInterval.AutoSize = true;
            this.label_AutoSaveInterval.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AutoSaveInterval.Location = new System.Drawing.Point(39, 9);
            this.label_AutoSaveInterval.Name = "label_AutoSaveInterval";
            this.label_AutoSaveInterval.Size = new System.Drawing.Size(151, 21);
            this.label_AutoSaveInterval.TabIndex = 1;
            this.label_AutoSaveInterval.Text = "Auto Save Interval";
            this.label_AutoSaveInterval.Click += new System.EventHandler(this.label_AutoSaveInterval_Click);
            // 
            // numeric_AutoSaveHours
            // 
            this.numeric_AutoSaveHours.Location = new System.Drawing.Point(36, 49);
            this.numeric_AutoSaveHours.Name = "numeric_AutoSaveHours";
            this.numeric_AutoSaveHours.Size = new System.Drawing.Size(39, 23);
            this.numeric_AutoSaveHours.TabIndex = 2;
            this.numeric_AutoSaveHours.ValueChanged += new System.EventHandler(this.numeric_AutoSaveHours_ValueChanged);
            // 
            // label_AutoSaveHours
            // 
            this.label_AutoSaveHours.AutoSize = true;
            this.label_AutoSaveHours.Location = new System.Drawing.Point(36, 31);
            this.label_AutoSaveHours.Name = "label_AutoSaveHours";
            this.label_AutoSaveHours.Size = new System.Drawing.Size(39, 15);
            this.label_AutoSaveHours.TabIndex = 3;
            this.label_AutoSaveHours.Text = "Hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Minutes";
            // 
            // numeric_AutoSaveMinutes
            // 
            this.numeric_AutoSaveMinutes.Location = new System.Drawing.Point(93, 49);
            this.numeric_AutoSaveMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numeric_AutoSaveMinutes.Name = "numeric_AutoSaveMinutes";
            this.numeric_AutoSaveMinutes.Size = new System.Drawing.Size(39, 23);
            this.numeric_AutoSaveMinutes.TabIndex = 4;
            this.numeric_AutoSaveMinutes.ValueChanged += new System.EventHandler(this.numeric_AutoSaveMinutes_ValueChanged);
            // 
            // label_AutoSaveSeconds
            // 
            this.label_AutoSaveSeconds.AutoSize = true;
            this.label_AutoSaveSeconds.Location = new System.Drawing.Point(144, 31);
            this.label_AutoSaveSeconds.Name = "label_AutoSaveSeconds";
            this.label_AutoSaveSeconds.Size = new System.Drawing.Size(51, 15);
            this.label_AutoSaveSeconds.TabIndex = 7;
            this.label_AutoSaveSeconds.Text = "Seconds";
            // 
            // numeric_AutoSaveSeconds
            // 
            this.numeric_AutoSaveSeconds.Location = new System.Drawing.Point(148, 49);
            this.numeric_AutoSaveSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numeric_AutoSaveSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_AutoSaveSeconds.Name = "numeric_AutoSaveSeconds";
            this.numeric_AutoSaveSeconds.Size = new System.Drawing.Size(39, 23);
            this.numeric_AutoSaveSeconds.TabIndex = 6;
            this.numeric_AutoSaveSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_AutoSaveSeconds.ValueChanged += new System.EventHandler(this.numeric_AutoSaveSeconds_ValueChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(125, 381);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(98, 23);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(12, 381);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(98, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label_PickCompilerFile
            // 
            this.label_PickCompilerFile.AutoSize = true;
            this.label_PickCompilerFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_PickCompilerFile.Location = new System.Drawing.Point(27, 89);
            this.label_PickCompilerFile.Name = "label_PickCompilerFile";
            this.label_PickCompilerFile.Size = new System.Drawing.Size(171, 21);
            this.label_PickCompilerFile.TabIndex = 10;
            this.label_PickCompilerFile.Text = "Choose Compiler File";
            // 
            // btn_PickCompilerFile
            // 
            this.btn_PickCompilerFile.Location = new System.Drawing.Point(39, 113);
            this.btn_PickCompilerFile.Name = "btn_PickCompilerFile";
            this.btn_PickCompilerFile.Size = new System.Drawing.Size(148, 34);
            this.btn_PickCompilerFile.TabIndex = 11;
            this.btn_PickCompilerFile.Text = "Open File Browser";
            this.btn_PickCompilerFile.UseVisualStyleBackColor = true;
            this.btn_PickCompilerFile.Click += new System.EventHandler(this.btn_PickCompilerFile_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 416);
            this.Controls.Add(this.btn_PickCompilerFile);
            this.Controls.Add(this.label_PickCompilerFile);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label_AutoSaveSeconds);
            this.Controls.Add(this.numeric_AutoSaveSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_AutoSaveMinutes);
            this.Controls.Add(this.label_AutoSaveHours);
            this.Controls.Add(this.numeric_AutoSaveHours);
            this.Controls.Add(this.label_AutoSaveInterval);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AutoSaveHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AutoSaveMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AutoSaveSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_AutoSaveInterval;
        private System.Windows.Forms.NumericUpDown numeric_AutoSaveHours;
        private System.Windows.Forms.Label label_AutoSaveHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_AutoSaveMinutes;
        private System.Windows.Forms.Label label_AutoSaveSeconds;
        private System.Windows.Forms.NumericUpDown numeric_AutoSaveSeconds;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label_PickCompilerFile;
        private System.Windows.Forms.Button btn_PickCompilerFile;
    }
}