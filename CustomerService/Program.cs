using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CustomerService.Forms.Users;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
  

            var frmLogin = new frmLogin();
            frmLogin.Show();
            Application.Run();
        }
    }
}
