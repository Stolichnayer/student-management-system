using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace student_management_system.Controller
{
    public class DatabaseManager
    {
        private static DatabaseManager _instance;
        private string _username;
        private string _password;
        private string _ipAddress = "localhost";
        private DatabaseManager() {}

        public static DatabaseManager GetInstance()
        {
            return _instance ??= new DatabaseManager();
        }

        public bool ValidateAndSetCredentials(string username, string password)
        {
            _username = username;
            _password = password;
            
            //Connection string
            string connStr =
                $"server={_ipAddress};user={_username};database=students_schema;port=3306;password={_password}";
            
            //MySqlConnection object
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.Out.WriteLine(connStr);
                //Try to open connection
                conn.Open();

                string query = "SELECT * FROM students";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                
                DataSet dataset = new DataSet();

                //Fill dataset with query results
                mySqlDataAdapter.Fill(dataset);

                //Set DataGridView control to read-only
                Program._form1.DataGridView1.ReadOnly = true;
                
                //Set DataGridView data source to our dataset
                Program._form1.DataGridView1.DataSource = dataset.Tables[0];
                
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(e.Message);
                        break;
                }
                return false;
            }
            
        }
        
        public void ExecuteQuery(string query)
        {
            //MySqlConnection conn = new MySqlConnection(connStr);
        }
        
        
        
        
    }
}