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
        public static Form1 _form1;
        
        // the main entry point for the application.

        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            _form1 = new Form1();
            Application.Run(_form1);
        }
    }
}