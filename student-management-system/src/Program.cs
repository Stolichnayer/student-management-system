using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using student_management_system.Forms;

namespace student_management_system
{
    public static class Program
    {
        public static LoginForm LoginForm;

        // the main entry point for the application.

        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            LoginForm = new LoginForm();
            Application.Run(LoginForm);
        }
    }
}