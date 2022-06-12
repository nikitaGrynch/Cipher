namespace Cipher
{
    partial class TextCipherForm
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
            this.richTextBoxSourceText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxTargetText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectLang = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectCipherMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSelectKey = new System.Windows.Forms.ComboBox();
            this.buttonCipher = new System.Windows.Forms.Button();
            this.panelKeyString = new System.Windows.Forms.Panel();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelKeyNumber = new System.Windows.Forms.Panel();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelKeyString.SuspendLayout();
            this.panelKeyNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxSourceText
            // 
            this.richTextBoxSourceText.Location = new System.Drawing.Point(12, 91);
            this.richTextBoxSourceText.Name = "richTextBoxSourceText";
            this.richTextBoxSourceText.Size = new System.Drawing.Size(350, 365);
            this.richTextBoxSourceText.TabIndex = 0;
            this.richTextBoxSourceText.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sampleTextToolStripMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sampleTextToolStripMenuItem
            // 
            this.sampleTextToolStripMenuItem.Name = "sampleTextToolStripMenuItem";
            this.sampleTextToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.sampleTextToolStripMenuItem.Text = "Sample Text";
            this.sampleTextToolStripMenuItem.Click += new System.EventHandler(this.sampleTextToolStripMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(276, 44);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // richTextBoxTargetText
            // 
            this.richTextBoxTargetText.Location = new System.Drawing.Point(662, 91);
            this.richTextBoxTargetText.Name = "richTextBoxTargetText";
            this.richTextBoxTargetText.ReadOnly = true;
            this.richTextBoxTargetText.Size = new System.Drawing.Size(350, 365);
            this.richTextBoxTargetText.TabIndex = 0;
            this.richTextBoxTargetText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Language:";
            // 
            // comboBoxSelectLang
            // 
            this.comboBoxSelectLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectLang.FormattingEnabled = true;
            this.comboBoxSelectLang.Location = new System.Drawing.Point(395, 138);
            this.comboBoxSelectLang.Name = "comboBoxSelectLang";
            this.comboBoxSelectLang.Size = new System.Drawing.Size(83, 40);
            this.comboBoxSelectLang.TabIndex = 5;
            this.comboBoxSelectLang.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectLang_SelectedIndexChanged);
            // 
            // comboBoxSelectCipherMethod
            // 
            this.comboBoxSelectCipherMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectCipherMethod.FormattingEnabled = true;
            this.comboBoxSelectCipherMethod.Location = new System.Drawing.Point(395, 294);
            this.comboBoxSelectCipherMethod.Name = "comboBoxSelectCipherMethod";
            this.comboBoxSelectCipherMethod.Size = new System.Drawing.Size(242, 40);
            this.comboBoxSelectCipherMethod.TabIndex = 6;
            this.comboBoxSelectCipherMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCipherMethod_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Crypto Method:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Key:";
            // 
            // comboBoxSelectKey
            // 
            this.comboBoxSelectKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectKey.FormattingEnabled = true;
            this.comboBoxSelectKey.Location = new System.Drawing.Point(30, 47);
            this.comboBoxSelectKey.Name = "comboBoxSelectKey";
            this.comboBoxSelectKey.Size = new System.Drawing.Size(65, 40);
            this.comboBoxSelectKey.TabIndex = 5;
            // 
            // buttonCipher
            // 
            this.buttonCipher.Location = new System.Drawing.Point(442, 340);
            this.buttonCipher.Name = "buttonCipher";
            this.buttonCipher.Size = new System.Drawing.Size(150, 46);
            this.buttonCipher.TabIndex = 7;
            this.buttonCipher.Text = "Cipher";
            this.buttonCipher.UseVisualStyleBackColor = true;
            this.buttonCipher.Click += new System.EventHandler(this.buttonCipher_Click);
            // 
            // panelKeyString
            // 
            this.panelKeyString.Controls.Add(this.textBoxKey);
            this.panelKeyString.Controls.Add(this.label6);
            this.panelKeyString.Location = new System.Drawing.Point(395, 195);
            this.panelKeyString.Name = "panelKeyString";
            this.panelKeyString.Size = new System.Drawing.Size(242, 50);
            this.panelKeyString.TabIndex = 8;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(67, 5);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(170, 39);
            this.textBoxKey.TabIndex = 9;
            this.textBoxKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKey_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Key:";
            // 
            // panelKeyNumber
            // 
            this.panelKeyNumber.Controls.Add(this.label5);
            this.panelKeyNumber.Controls.Add(this.comboBoxSelectKey);
            this.panelKeyNumber.Location = new System.Drawing.Point(537, 91);
            this.panelKeyNumber.Name = "panelKeyNumber";
            this.panelKeyNumber.Size = new System.Drawing.Size(100, 98);
            this.panelKeyNumber.TabIndex = 8;
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.Location = new System.Drawing.Point(442, 392);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(150, 46);
            this.buttonDecipher.TabIndex = 7;
            this.buttonDecipher.Text = "Decipher";
            this.buttonDecipher.UseVisualStyleBackColor = true;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // TextCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 469);
            this.Controls.Add(this.panelKeyNumber);
            this.Controls.Add(this.panelKeyString);
            this.Controls.Add(this.buttonDecipher);
            this.Controls.Add(this.buttonCipher);
            this.Controls.Add(this.comboBoxSelectCipherMethod);
            this.Controls.Add(this.comboBoxSelectLang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxTargetText);
            this.Controls.Add(this.richTextBoxSourceText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextCipherForm";
            this.Text = "TextCipherForm";
            this.Load += new System.EventHandler(this.TextCipherForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelKeyString.ResumeLayout(false);
            this.panelKeyString.PerformLayout();
            this.panelKeyNumber.ResumeLayout(false);
            this.panelKeyNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSourceText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sampleTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxTargetText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSelectLang;
        private System.Windows.Forms.ComboBox comboBoxSelectCipherMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSelectKey;
        private System.Windows.Forms.Button buttonCipher;
        private System.Windows.Forms.Panel panelKeyString;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelKeyNumber;
        private System.Windows.Forms.Button buttonDecipher;
    }
}