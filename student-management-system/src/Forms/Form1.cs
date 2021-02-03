using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using student_management_system.Controller;

namespace student_management_system.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.Out.WriteLine("Hello brother");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Out.WriteLine("Button clicked!");
            label1.Text = "Connected!";
            DatabaseManager.GetInstance().ValidateAndSetCredentials("root", "root");
        }
        
    }
}