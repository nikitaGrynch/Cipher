namespace Cipher
{
    partial class FileCipherForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSourceFilename = new System.Windows.Forms.TextBox();
            this.buttonSelectSourceFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonCipher = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSampleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSourceFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxTargetFilename = new System.Windows.Forms.TextBox();
            this.panelTarget = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSelectTargetFile = new System.Windows.Forms.Button();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.progressBarCiphering = new System.Windows.Forms.ProgressBar();
            this.buttonCancelProgress = new System.Windows.Forms.Button();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panelTarget.SuspendLayout();
            this.panelProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a file";
            // 
            // textBoxSourceFilename
            // 
            this.textBoxSourceFilename.Location = new System.Drawing.Point(193, 79);
            this.textBoxSourceFilename.Name = "textBoxSourceFilename";
            this.textBoxSourceFilename.Size = new System.Drawing.Size(200, 39);
            this.textBoxSourceFilename.TabIndex = 1;
            // 
            // buttonSelectSourceFile
            // 
            this.buttonSelectSourceFile.AutoSize = true;
            this.buttonSelectSourceFile.Location = new System.Drawing.Point(399, 77);
            this.buttonSelectSourceFile.Name = "buttonSelectSourceFile";
            this.buttonSelectSourceFile.Size = new System.Drawing.Size(45, 42);
            this.buttonSelectSourceFile.TabIndex = 2;
            this.buttonSelectSourceFile.Text = "...";
            this.buttonSelectSourceFile.UseVisualStyleBackColor = true;
            this.buttonSelectSourceFile.Click += new System.EventHandler(this.buttonSelectSourceFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(193, 173);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(200, 39);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonCipher
            // 
            this.buttonCipher.AutoSize = true;
            this.buttonCipher.Location = new System.Drawing.Point(881, 215);
            this.buttonCipher.Name = "buttonCipher";
            this.buttonCipher.Size = new System.Drawing.Size(116, 42);
            this.buttonCipher.TabIndex = 2;
            this.buttonCipher.Text = "Cipher";
            this.buttonCipher.UseVisualStyleBackColor = true;
            this.buttonCipher.Click += new System.EventHandler(this.buttonCipher_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 42);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeSampleMenuItem,
            this.selectSourceFileToolStripMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // makeSampleMenuItem
            // 
            this.makeSampleMenuItem.Name = "makeSampleMenuItem";
            this.makeSampleMenuItem.Size = new System.Drawing.Size(359, 44);
            this.makeSampleMenuItem.Text = "Make sample";
            this.makeSampleMenuItem.Click += new System.EventHandler(this.makeSampleMenuItem_Click);
            // 
            // selectSourceFileToolStripMenuItem
            // 
            this.selectSourceFileToolStripMenuItem.Name = "selectSourceFileToolStripMenuItem";
            this.selectSourceFileToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.selectSourceFileToolStripMenuItem.Text = "Select Source File";
            this.selectSourceFileToolStripMenuItem.Click += new System.EventHandler(this.selectSourceFileToolStripMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxTargetFilename
            // 
            this.textBoxTargetFilename.Location = new System.Drawing.Point(115, 25);
            this.textBoxTargetFilename.Name = "textBoxTargetFilename";
            this.textBoxTargetFilename.Size = new System.Drawing.Size(263, 39);
            this.textBoxTargetFilename.TabIndex = 6;
            // 
            // panelTarget
            // 
            this.panelTarget.Controls.Add(this.textBoxTargetFilename);
            this.panelTarget.Controls.Add(this.label4);
            this.panelTarget.Controls.Add(this.buttonSelectTargetFile);
            this.panelTarget.Location = new System.Drawing.Point(523, 54);
            this.panelTarget.Name = "panelTarget";
            this.panelTarget.Size = new System.Drawing.Size(474, 82);
            this.panelTarget.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Target";
            // 
            // buttonSelectTargetFile
            // 
            this.buttonSelectTargetFile.AutoSize = true;
            this.buttonSelectTargetFile.Location = new System.Drawing.Point(384, 23);
            this.buttonSelectTargetFile.Name = "buttonSelectTargetFile";
            this.buttonSelectTargetFile.Size = new System.Drawing.Size(45, 42);
            this.buttonSelectTargetFile.TabIndex = 2;
            this.buttonSelectTargetFile.Text = "...";
            this.buttonSelectTargetFile.UseVisualStyleBackColor = true;
            this.buttonSelectTargetFile.Click += new System.EventHandler(this.buttonSelectTargetFile_Click);
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.AutoSize = true;
            this.buttonShowPassword.Location = new System.Drawing.Point(399, 171);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(57, 42);
            this.buttonShowPassword.TabIndex = 2;
            this.buttonShowPassword.Text = "👁";
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonShowPassword_MouseDown);
            this.buttonShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonShowPassword_MouseUp);
            // 
            // panelProgress
            // 
            this.panelProgress.Controls.Add(this.progressBarCiphering);
            this.panelProgress.Controls.Add(this.buttonCancelProgress);
            this.panelProgress.Location = new System.Drawing.Point(523, 306);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(474, 76);
            this.panelProgress.TabIndex = 9;
            // 
            // progressBarCiphering
            // 
            this.progressBarCiphering.Location = new System.Drawing.Point(3, 3);
            this.progressBarCiphering.Name = "progressBarCiphering";
            this.progressBarCiphering.Size = new System.Drawing.Size(299, 68);
            this.progressBarCiphering.TabIndex = 1;
            // 
            // buttonCancelProgress
            // 
            this.buttonCancelProgress.Location = new System.Drawing.Point(333, 15);
            this.buttonCancelProgress.Name = "buttonCancelProgress";
            this.buttonCancelProgress.Size = new System.Drawing.Size(116, 46);
            this.buttonCancelProgress.TabIndex = 0;
            this.buttonCancelProgress.Text = "Cancel";
            this.buttonCancelProgress.UseVisualStyleBackColor = true;
            this.buttonCancelProgress.Click += new System.EventHandler(this.buttonCancelProgress_Click);
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.AutoSize = true;
            this.buttonDecipher.Location = new System.Drawing.Point(738, 215);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(120, 42);
            this.buttonDecipher.TabIndex = 10;
            this.buttonDecipher.Text = "Decipher";
            this.buttonDecipher.UseVisualStyleBackColor = true;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // FileCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 469);
            this.Controls.Add(this.buttonDecipher);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.panelTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonShowPassword);
            this.Controls.Add(this.buttonCipher);
            this.Controls.Add(this.buttonSelectSourceFile);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxSourceFilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileCipherForm";
            this.Text = "FileCipherForm";
            this.Load += new System.EventHandler(this.FileCipherForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTarget.ResumeLayout(false);
            this.panelTarget.PerformLayout();
            this.panelProgress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSourceFilename;
        private System.Windows.Forms.Button buttonSelectSourceFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonCipher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeSampleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxTargetFilename;
        private System.Windows.Forms.Panel panelTarget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSelectTargetFile;
        private System.Windows.Forms.Button buttonShowPassword;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.ProgressBar progressBarCiphering;
        private System.Windows.Forms.Button buttonCancelProgress;
        private System.Windows.Forms.Button buttonDecipher;
        private System.Windows.Forms.ToolStripMenuItem selectSourceFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}