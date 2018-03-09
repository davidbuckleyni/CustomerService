using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CustomerService.Forms.Users;
using System.Threading;

namespace CustomerService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
  

            var frmLogin = new frmLogin();
            frmLogin.Show();
            Application.Run();
            }
            catch (Exception exc)
            {
                ShowExceptionDetails(exc);
            }
        }

        static void Application_ThreadException
      (object sender, System.Threading.ThreadExceptionEventArgs e)
        {// All exceptions thrown by the main thread are handled over this method

            ShowExceptionDetails(e.Exception);
        }

        static void CurrentDomain_UnhandledException
            (object sender, UnhandledExceptionEventArgs e)
        {// All exceptions thrown by additional threads are handled in this method

            ShowExceptionDetails(e.ExceptionObject as Exception);

            // Suspend the current thread for now to stop the exception from throwing.
            Thread.CurrentThread.Suspend();
        }

        static void ShowExceptionDetails(Exception Ex)
        {
            // Do logging of exception details
            MessageBox.Show(Ex.Message, Ex.TargetSite.ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
