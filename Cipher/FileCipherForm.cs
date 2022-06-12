using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Cipher
{
    public partial class FileCipherForm : Form
    {
        #region Vars and Consts

        private readonly NLog.Logger _logger;

        private const String SAMPLE_FILENAME = "sample.txt";
        private const String SAMPLE_CONTENT  = "Hello, Max!";
        private const String EXTENSION       = ".cod";
        private char PASSWORD_CHAR;

        private CipherData cipherData;
        private CancellationTokenSource cancellationTokenSource;
        private int progressValue;      // exchange variable - to show from other thread

        private Operation? operation;   // ciphering / deciphering

        #endregion
        public FileCipherForm(NLog.Logger logger)
        {
            InitializeComponent();
            this._logger = logger;
            cipherData = new CipherData();
            cancellationTokenSource = null!;
        }

        private void FileCipherForm_Load(object sender, EventArgs e)
        {
            panelProgress.Visible = false;
            panelTarget.Visible = false;
            PASSWORD_CHAR = textBoxPassword.PasswordChar;
            if (PASSWORD_CHAR == '\0') PASSWORD_CHAR = '●';
        }

        #region Select files

        /// <summary>
        /// Selects file (name) for ciphering - source file
        /// using fileOpenDialog resource
        /// </summary>
        private void SelectSourceFile()
        {

            openFileDialog1.FileName = SAMPLE_FILENAME;
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|Ciphered files (*.cod)|*.cod|All files (*.*)|*.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String fullPath = openFileDialog1.FileName;
                String name = Path.GetFileNameWithoutExtension(fullPath);
                String nameExt = Path.GetFileName(fullPath);
                String dir = Path.GetDirectoryName(fullPath) ?? String.Empty;

                panelTarget.Visible = true;
                textBoxSourceFilename.Text = nameExt;
                // Form target filename: source name + ".cod"
                textBoxTargetFilename.Text = name + EXTENSION;

                cipherData.SourceFile = fullPath;
                cipherData.TargetFile = Path.Combine(dir, textBoxTargetFilename.Text);
            }
            else
            {
                textBoxSourceFilename.Text = String.Empty;
                panelTarget.Visible = false;
            }
        }

        /// <summary>
        /// Selects file (name) for ciphering - target (destination) file
        /// using fileSaveDialog resource
        /// </summary>
        private void SelectTargetFile()
        {
            if(cipherData.SourceFile == String.Empty)
            {
                MessageBox.Show("Please, select source file", "No source file");
                return;
            }
            saveFileDialog1.FileName = textBoxTargetFilename.Text;
            saveFileDialog1.InitialDirectory = Application.StartupPath;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // windows itself warns if file exists
                /*
                if (File.Exists(saveFileDialog1.FileName))
                {
                    if(MessageBox.Show("This file already exists. Do you want to overwrite it?", "File exists", MessageBoxButtons.YesNo)
                        == DialogResult.No)
                    {
                        return;
                    }
                }
                */
                String fullPath = saveFileDialog1.FileName;
                String name = Path.GetFileNameWithoutExtension(fullPath);
                String nameExt = Path.GetFileName(fullPath);
                String dir = Path.GetDirectoryName(fullPath) ?? String.Empty;

                textBoxTargetFilename.Text = nameExt;
                cipherData.TargetFile = Path.Combine(dir, textBoxTargetFilename.Text);
            }
        }

        #endregion

        #region Button Clicks

        /// <summary>
        /// Creates file "sample.txt" in application startup folder
        /// </summary>
        private void makeSampleMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(SAMPLE_FILENAME, SAMPLE_CONTENT);
        }


        private void buttonSelectSourceFile_Click(object sender, EventArgs e)
        {
            SelectSourceFile();
        }

        private void buttonSelectTargetFile_Click(object sender, EventArgs e)
        {
            SelectTargetFile();
        }

        private void buttonCipher_Click(object sender, EventArgs e)
        {
            // Check if all data is entered
            if(textBoxSourceFilename.Text == String.Empty)
            {
                MessageBox.Show("Cannot start ciphering without source file.\nSelect source file and try again", "No source file");
                return;
            }
            if (textBoxTargetFilename.Text == String.Empty)
            {
                if(DialogResult.Yes == MessageBox.Show("Select default target file?", "No target file", MessageBoxButtons.YesNo))
                {
                    textBoxTargetFilename.Text = Path.GetFileName(cipherData.TargetFile);
                }
                else
                    return;
            }
            if (textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Cannot start ciphering without password.\nEnter password and try again", "No password");
                return;
            }
            cipherData.Password = textBoxPassword.Text;
            cancellationTokenSource = new CancellationTokenSource();
            progressValue = 0;
            panelProgress.Visible = true;

            operation = Operation.Ciphering;
            new Thread(Cipher).Start(new ThreadData
            {
                CipherData = cipherData,
                Token = cancellationTokenSource.Token
            });
        }

        private void buttonDecipher_Click(object sender, EventArgs e)
        {
            // Check if all data is entered
            if (textBoxSourceFilename.Text == String.Empty)
            {
                MessageBox.Show("Cannot start deciphering without source file.\nSelect source file and try again", "No source file");
                return;
            }
            if (textBoxTargetFilename.Text == String.Empty)
            {
                if (DialogResult.Yes == MessageBox.Show("Select default target file?", "No target file", MessageBoxButtons.YesNo))
                {
                    textBoxTargetFilename.Text = Path.GetFileName(cipherData.TargetFile);
                }
                else
                    return;
            }
            if (textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Cannot start deciphering without password.\nEnter password and try again", "No password");
                return;
            }
            cipherData.Password = textBoxPassword.Text;
            cancellationTokenSource = new CancellationTokenSource();
            progressValue = 0;
            panelProgress.Visible = true;

            operation = Operation.Deciphering;
            new Thread(Cipher).Start(new ThreadData
            {
                CipherData = cipherData,
                Token = cancellationTokenSource.Token
            });
        }

        private void buttonCancelProgress_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void selectSourceFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectSourceFile();
        }

        #endregion

        #region Show/Hide UI elements

        /// <summary>
        /// Cross-thread method for setting panel invisible
        /// </summary>
        private void HidePanelProgress()
        {
            lock (panelProgress)
            {
                panelProgress.Visible = false;
            }
        }

        /// <summary>
        /// Hide cipher button when progress starts and show when it ends - from any thread
        /// </summary>
        private void ShowHideCipherButton()
        {
            lock (buttonCipher)
            {
                buttonCipher.Visible = !buttonCipher.Visible;
            }
        }

        #region Show/Hide password button
        // Show password when button was pressed
        private void buttonShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
        }

        // Hide password when button was released
        private void buttonShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = PASSWORD_CHAR;
        }
        #endregion

        private void HideTargetFileBox()
        {
            lock (textBoxTargetFilename)
            {
                panelTarget.Visible = false;
            }
        }

        #endregion

        /// <summary>
        /// Clear textBoxes: sourceFilename, targetFilename, password after ciphering
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxSourceFilename.Text = "";
            textBoxTargetFilename.Text = "";
            textBoxPassword.Text = "";
        }

        #region Ciphering process

        private void Cipher(object data)
        {
            if (data is null || data is not ThreadData) return;
            ThreadData tdata = (ThreadData)data;

            if (tdata.CipherData is null) return;

            Invoke((Action)ShowHideCipherButton);

            try
            {
                // Source File size - for progress bar scaling
                long fileSize = new FileInfo(tdata.CipherData.SourceFile).Length;
                // open source file for reading
                using(var reader = new StreamReader(tdata.CipherData.SourceFile))
                {
                    // open destination file for writing
                    using(var writer = new StreamWriter(tdata.CipherData.TargetFile))
                    {
                        int cnt = 0;
                        while (!reader.EndOfStream)
                        {
                            char symT = (char)reader.Read();    // text symbol = read from file
                            char symP = tdata.CipherData.Password[cnt % tdata.CipherData.Password.Length];  // password symbol
                            char symC = (char)(symT ^ symP);    // cipher symbol
                            writer.Write(symC);                 // write to file
                            ++cnt;                              // symbol counter

                            // display progress
                            progressValue = (int)(cnt * 100 / fileSize);
                            Invoke((Action)UpdateProgress);

                            Thread.Sleep(300);
                            if (tdata.Token.IsCancellationRequested)
                            {
                                if (DialogResult.Yes == MessageBox.Show("Sure?", "Cancel", MessageBoxButtons.YesNo))
                                    tdata.Token.ThrowIfCancellationRequested();
                                else
                                {
                                    // regenerate token for pause thread
                                    cancellationTokenSource = new CancellationTokenSource();
                                    tdata.Token = cancellationTokenSource.Token;
                                }
                                
                                
                            }
                        }
                    }
                }
                if (DialogResult.Yes == MessageBox.Show("Open in notepad?",
                    $"{(operation == Operation.Ciphering? "Ciphering": "Deciphering")} finished successfully",
                    MessageBoxButtons.YesNo))
                {
                    Process.Start("notepad.exe", tdata.CipherData.TargetFile);
                }

            }
            catch(IOException ex) // IO problem - file reading / writing
            {
                _logger.Error(ex, "IO problem");
                MessageBox.Show(ex.Message);
            }
            catch (OperationCanceledException ex)  // Cancellation
            {
                _logger.Trace(ex, "Cancelation ciphering");
                // Here confirmed concellation
                // delete target file
                try { File.Delete(tdata.CipherData.TargetFile); } catch { }
            }
            finally
            {
                // Chiphering finished with any state
                Invoke((Action)HidePanelProgress);
                Invoke((Action)ShowHideCipherButton);
                Invoke((Action)ClearTextBoxes);
                Invoke((Action)HideTargetFileBox);
            }
            
            
        }

        /// <summary>
        /// Set ProgressBar to progressValue - from any thread
        /// </summary>
        private void UpdateProgress()
        {
            lock (progressBarCiphering)
            {
                progressBarCiphering.Value = progressValue;
            }
        }


        #endregion

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    #region Data
    // Data to pass in cipher thread
    class ThreadData
    {
        public CipherData? CipherData { get; set; }
        public CancellationToken Token { get; set; }

    }


    class CipherData
    {
        public String SourceFile { get; set; } = String.Empty;
        public String TargetFile { get; set; } = String.Empty;
        public String Password { get; set; } = String.Empty;
    }

    enum Operation
    {
        Ciphering,
        Deciphering
    }

    #endregion
}
