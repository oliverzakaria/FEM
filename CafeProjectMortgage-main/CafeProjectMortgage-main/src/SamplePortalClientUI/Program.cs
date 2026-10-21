using SamplePortalClientUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamplePortalClient.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FNumDial());
            Application.Run(new FToolbar());
        }
    }

    public class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        private static CApp _cApp = null;
        private static bool isRunning = false;
        private Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }

                    if (_cApp == null)
                    {
                        BackgroundWorker bgWorker = new BackgroundWorker();
                        bgWorker.DoWork += (sender, e) =>
                        {
                            isRunning = true;
                            _cApp = new CApp();
                        };
                        bgWorker.RunWorkerCompleted += (sender, e) =>
                        {
                            isRunning = false;
                        };
                        bgWorker.RunWorkerAsync();
                    }

                    return instance;
                }
            }
        }
        public CApp CApp
        {
            get { return _cApp; }
        }
        public bool IsAuthenticated
        {
            get { return _cApp != null && !isRunning && _cApp.CurrentState is CStateAuthenticated; }
        }
        public bool IsRunning
        {
            get { return isRunning; }
        }
    }
}
