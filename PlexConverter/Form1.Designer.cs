namespace PlexConverter
{
    partial class frmMainForm
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
            this.btnDirectory = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.chkTwoPass = new System.Windows.Forms.CheckBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbRemoveOriginal = new System.Windows.Forms.CheckBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.pbFile = new System.Windows.Forms.ProgressBar();
            this.ProgressBarUpdater = new System.Windows.Forms.Timer(this.components);
            this.cbOverwrite = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAllFiles = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(12, 12);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(94, 23);
            this.btnDirectory.TabIndex = 0;
            this.btnDirectory.Text = "Browse Input";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.BtnDirectory_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(112, 14);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(675, 20);
            this.tbPath.TabIndex = 1;
            // 
            // chkTwoPass
            // 
            this.chkTwoPass.AutoSize = true;
            this.chkTwoPass.Location = new System.Drawing.Point(12, 65);
            this.chkTwoPass.Name = "chkTwoPass";
            this.chkTwoPass.Size = new System.Drawing.Size(73, 17);
            this.chkTwoPass.TabIndex = 2;
            this.chkTwoPass.Text = "Two Pass";
            this.chkTwoPass.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(713, 167);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // cbRemoveOriginal
            // 
            this.cbRemoveOriginal.AutoSize = true;
            this.cbRemoveOriginal.Location = new System.Drawing.Point(91, 65);
            this.cbRemoveOriginal.Name = "cbRemoveOriginal";
            this.cbRemoveOriginal.Size = new System.Drawing.Size(104, 17);
            this.cbRemoveOriginal.TabIndex = 4;
            this.cbRemoveOriginal.Text = "Remove Original";
            this.cbRemoveOriginal.UseVisualStyleBackColor = true;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(12, 36);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(94, 23);
            this.btnOutput.TabIndex = 5;
            this.btnOutput.Text = "Browse Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.BtnOutput_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(112, 38);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(675, 20);
            this.tbOutput.TabIndex = 6;
            // 
            // pbFile
            // 
            this.pbFile.Location = new System.Drawing.Point(12, 127);
            this.pbFile.Name = "pbFile";
            this.pbFile.Size = new System.Drawing.Size(775, 23);
            this.pbFile.TabIndex = 7;
            // 
            // ProgressBarUpdater
            // 
            this.ProgressBarUpdater.Tick += new System.EventHandler(this.ProgressBarUpdater_Tick);
            // 
            // cbOverwrite
            // 
            this.cbOverwrite.AutoSize = true;
            this.cbOverwrite.Location = new System.Drawing.Point(201, 65);
            this.cbOverwrite.Name = "cbOverwrite";
            this.cbOverwrite.Size = new System.Drawing.Size(71, 17);
            this.cbOverwrite.TabIndex = 8;
            this.cbOverwrite.Text = "Overwrite";
            this.cbOverwrite.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(738, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "This File:";
            // 
            // pbAllFiles
            // 
            this.pbAllFiles.Location = new System.Drawing.Point(12, 85);
            this.pbAllFiles.Name = "pbAllFiles";
            this.pbAllFiles.Size = new System.Drawing.Size(775, 23);
            this.pbAllFiles.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(709, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Progress:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(632, 167);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Cancel";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 153);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(93, 13);
            this.lblFileName.TabIndex = 13;
            this.lblFileName.Text = "File Name Here :P";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 202);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbAllFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOverwrite);
            this.Controls.Add(this.pbFile);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.cbRemoveOriginal);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.chkTwoPass);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnDirectory);
            this.Name = "frmMainForm";
            this.Text = "Plex Pre Converter";
            this.Load += new System.EventHandler(this.FrmMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.CheckBox chkTwoPass;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.CheckBox cbRemoveOriginal;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.ProgressBar pbFile;
        private System.Windows.Forms.Timer ProgressBarUpdater;
        private System.Windows.Forms.CheckBox cbOverwrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbAllFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblFileName;
    }
}

