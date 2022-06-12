namespace Cipher
{
    partial class PortalForm
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
            this.buttonFileCipher = new System.Windows.Forms.Button();
            this.buttonTextCipher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFileCipher
            // 
            this.buttonFileCipher.Location = new System.Drawing.Point(12, 36);
            this.buttonFileCipher.Name = "buttonFileCipher";
            this.buttonFileCipher.Size = new System.Drawing.Size(150, 46);
            this.buttonFileCipher.TabIndex = 0;
            this.buttonFileCipher.Text = "File Cipher";
            this.buttonFileCipher.UseVisualStyleBackColor = true;
            this.buttonFileCipher.Click += new System.EventHandler(this.buttonFileCipher_Click);
            // 
            // buttonTextCipher
            // 
            this.buttonTextCipher.Location = new System.Drawing.Point(226, 36);
            this.buttonTextCipher.Name = "buttonTextCipher";
            this.buttonTextCipher.Size = new System.Drawing.Size(150, 46);
            this.buttonTextCipher.TabIndex = 0;
            this.buttonTextCipher.Text = "Text Cipher";
            this.buttonTextCipher.UseVisualStyleBackColor = true;
            this.buttonTextCipher.Click += new System.EventHandler(this.buttonTextCipher_Click);
            // 
            // PortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 124);
            this.Controls.Add(this.buttonTextCipher);
            this.Controls.Add(this.buttonFileCipher);
            this.Name = "PortalForm";
            this.Text = "Cipher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFileCipher;
        private System.Windows.Forms.Button buttonTextCipher;
    }
}