using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher
{
    public partial class PortalForm : Form
    {
        private readonly NLog.Logger _logger;
        public PortalForm(NLog.Logger logger)
        {
            InitializeComponent();
            this._logger = logger;
        }

        private void buttonFileCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Container.Resolve<FileCipherForm>().ShowDialog();
            this.Show();
            
        }

        private void buttonTextCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Container.Resolve<TextCipherForm>().ShowDialog();
            this.Show();
        }
    }
}
