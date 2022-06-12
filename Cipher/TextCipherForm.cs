using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Cipher
{
    public partial class TextCipherForm : Form
    {
        private readonly NLog.Logger _logger;
        private readonly Crypto.CryptoMethods _crypto;
        private readonly Random _random;

        private Regex engLettersRegex = new Regex(@"[A-Za-z]");
        private Regex rusLettersRegex = new Regex(@"[А-Яа-я]");
        public TextCipherForm(NLog.Logger logger, Crypto.CryptoMethods crypto, Random random)
        {
            InitializeComponent();

            this._logger = logger;
            this._crypto = crypto;
            this._random = random;
        }

        private void TextCipherForm_Load(object sender, EventArgs e)
        {
            comboBoxSelectLang.Items.Add("eng");
            comboBoxSelectLang.Items.Add("rus");


            comboBoxSelectLang.SelectedIndex = 0;
            comboBoxSelectKey.SelectedIndex = 2;

            foreach(var cryptoMethod in Enum.GetValues(typeof(CryptoMethods)))
            {
                comboBoxSelectCipherMethod.Items.Add(cryptoMethod);
            }
            comboBoxSelectCipherMethod.SelectedIndex = 0;
        }

        #region Clicks
        private void buttonCipher_Click(object sender, EventArgs e)
        {
            if (!IsInputDataValid())
            {
                return;
            }

            switch (comboBoxSelectCipherMethod.SelectedItem) {
                case CryptoMethods.Caesor:
                    {
                        richTextBoxTargetText.Text = _crypto.CaesarCipher(
                            richTextBoxSourceText.Text,
                            Convert.ToInt32(comboBoxSelectKey.SelectedItem),
                            comboBoxSelectLang.SelectedItem.ToString());
                        break;
                    }
                case CryptoMethods.Vigenere:
                    {
                        // check if key is empty
                        if (String.IsNullOrEmpty(textBoxKey.Text))
                        {
                            MessageBox.Show("Key should not be empty");
                            return;
                        }
                        // check if key longer than source text
                        if (textBoxKey.Text.Length > richTextBoxSourceText.Text.Length)
                        {
                            MessageBox.Show("Key should not be longer than source text", "Invalid key");
                            return;
                        }
                    
                        // check if key language is different from cipher method settings language
                        if(comboBoxSelectLang.SelectedItem.ToString() == "eng")
                        {
                            if (rusLettersRegex.IsMatch(textBoxKey.Text))
                            {
                                // if key contains rus letters
                                MessageBox.Show("Wrong language of key");
                                return;
                            }
                        }
                        else if(comboBoxSelectLang.SelectedItem.ToString() == "rus")
                        {
                            
                            if (engLettersRegex.IsMatch(textBoxKey.Text))
                            {
                                // if key contains eng letters
                                MessageBox.Show("Wrong language of key");
                                return;
                            }
                        }

                        richTextBoxTargetText.Text = _crypto.VigenereCipher(
                            richTextBoxSourceText.Text,
                            textBoxKey.Text,
                            comboBoxSelectLang.SelectedItem.ToString());
                        break;
                    }

            }
        }

        private void buttonDecipher_Click(object sender, EventArgs e)
        {
            if (!IsInputDataValid())
            {
                return;
            }

            switch (comboBoxSelectCipherMethod.SelectedItem)
            {
                case CryptoMethods.Caesor:
                    {
                        richTextBoxTargetText.Text = _crypto.CaesarCipher(
                            richTextBoxSourceText.Text,
                            Convert.ToInt32(comboBoxSelectKey.SelectedItem),
                            comboBoxSelectLang.SelectedItem.ToString(), true);
                        break;
                    }
                case CryptoMethods.Vigenere:
                    {
                        // check if key is empty
                        if (String.IsNullOrEmpty(textBoxKey.Text))
                        {
                            MessageBox.Show("Key should not be empty");
                            return;
                        }
                        // check if key longer than source text
                        if (textBoxKey.Text.Length > richTextBoxSourceText.Text.Length)
                        {
                            MessageBox.Show("Key should not be longer than source text", "Invalid key");
                            return;
                        }

                        // check if key language is different from cipher method settings language
                        if (comboBoxSelectLang.SelectedItem.ToString() == "eng")
                        {
                            if (rusLettersRegex.IsMatch(textBoxKey.Text))
                            {
                                // if key contains rus letters
                                MessageBox.Show("Wrong language of key");
                                return;
                            }
                        }
                        else if (comboBoxSelectLang.SelectedItem.ToString() == "rus")
                        {

                            if (engLettersRegex.IsMatch(textBoxKey.Text))
                            {
                                // if key contains eng letters
                                MessageBox.Show("Wrong language of key");
                                return;
                            }
                        }

                        richTextBoxTargetText.Text = _crypto.VigenereCipher(
                            richTextBoxSourceText.Text,
                            textBoxKey.Text,
                            comboBoxSelectLang.SelectedItem.ToString(), true);
                        break;
                    }

            }
        }

        #endregion

        #region Cipher settings
        private void comboBoxSelectLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectKey.Items.Clear();
            if(comboBoxSelectLang.SelectedItem.ToString() == "eng")
            {
                for (int i = 0; i < 26; i++)
                {
                    comboBoxSelectKey.Items.Add(i);
                }
            }
            else if (comboBoxSelectLang.SelectedItem.ToString() == "rus")
            {
                for (int i = 0; i < 33; i++)
                {
                    comboBoxSelectKey.Items.Add(i);
                }
            }
            comboBoxSelectKey.SelectedIndex = 2;
        }
        private void comboBoxSelectCipherMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelectCipherMethod.SelectedItem)
            {
                case CryptoMethods.Caesor:
                    {
                        panelKeyString.Hide();
                        panelKeyNumber.Show();
                        break;
                    }
                case CryptoMethods.Vigenere:
                    {
                        panelKeyNumber.Hide();
                        panelKeyString.Show();
                        break;
                    }
            }
        }

        #endregion

        private bool IsInputDataValid()
        {
            // check if source text is empty
            if (String.IsNullOrEmpty(richTextBoxSourceText.Text))
            {
                MessageBox.Show("Source Text should not be empty");
                return false;
            }

            // check if source text is different from cipher method settings language
            if (comboBoxSelectLang.SelectedItem.ToString() == "eng")
            {

                if (rusLettersRegex.IsMatch(richTextBoxSourceText.Text))
                {
                    // if source text contains rus letters
                    MessageBox.Show("Wrong language of source text");
                    return false;
                }

            }
            else if (comboBoxSelectLang.SelectedItem.ToString() == "rus")
            {
                if (engLettersRegex.IsMatch(richTextBoxSourceText.Text))
                {
                    // if source text contains eng letters
                    MessageBox.Show("Wrong language of source text");
                    return false;
                }
            }
            return true;
        }

        private void textBoxKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)    // 8 - Backspace
            {
                e.Handled = true;
            }
        }

        enum CryptoMethods
        {
            Caesor,
            Vigenere
        }
        private String? GetCryptoMethodName(CryptoMethods cryptoMethods)
        {
            switch (cryptoMethods)
            {
                case CryptoMethods.Caesor: return "Caesor";
                case CryptoMethods.Vigenere: return "Vigenere";
                default: return null;
            }
        }

        private void sampleTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxSourceText.Text = "Cryptography is the study of secure communications techniques that allow only the sender and intended recipient of a message to view its contents. ";
            comboBoxSelectCipherMethod.SelectedIndex = _random.Next(comboBoxSelectCipherMethod.Items.Count);
                
            switch (comboBoxSelectCipherMethod.SelectedItem)
            {
                case CryptoMethods.Vigenere: textBoxKey.Text = "crypto"; break;
                case CryptoMethods.Caesor: comboBoxSelectKey.SelectedIndex = _random.Next(comboBoxSelectKey.Items.Count); break;
                }
            comboBoxSelectLang.SelectedIndex = 0;
            
            
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
