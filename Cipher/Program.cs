using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using Microsoft.Practices.Unity;

namespace Cipher
{
    internal static class Program
    {
        public static UnityContainer? Container { get; set; }
        private static Logger? logger;
        private static Crypto.CryptoMethods? crypto;
        private static Random? random;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region WinForms config

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #endregion

            Container = new UnityContainer();

            logger = NLog.LogManager.GetCurrentClassLogger();
            crypto = new Crypto.CryptoMethods();
            random = new Random();

            Container.RegisterInstance(logger);
            Container.RegisterInstance(crypto);
            Container.RegisterInstance(random);

            Application.Run(Container.Resolve<PortalForm>());
        }
    }
}
