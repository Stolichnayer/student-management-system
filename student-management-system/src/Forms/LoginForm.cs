using System;
using System.Windows.Forms;
using student_management_system.Controller;

namespace student_management_system.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            bool result = DatabaseManager.GetInstance()
                .LoginToDatabase("localhost", 3306, "students_schema", user, password);
            
            if (result) //Connection successful
            {
                new MainForm().Show();
                Hide();
            }
        }
    }
}