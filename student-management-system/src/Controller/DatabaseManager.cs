using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace student_management_system.Controller
{
    // Singleton DatabaseManager class
    public class DatabaseManager
    {
        private static DatabaseManager _instance;

        private string _server;
        private int _port;
        private string _database;
        private string _user;
        private string _password;
        private DatabaseManager() {}

        public static DatabaseManager GetInstance()
        {
            return _instance ??= new DatabaseManager();
        }

        public bool LoginToDatabase(string server, int port, string database, string user, string password)
        {
            _server = server;
            _port = port;
            _database = database;
            _user = user;
            _password = password;
            
            //Connection string
            string connStr =
                $"server={_server};user={_user};database={_database};port={_port};password={_password}";
            
            //MySqlConnection object
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.Out.WriteLine(connStr);
                //Try to open connection
                conn.Open();

                const string query = "SELECT * FROM students";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                
                DataSet dataset = new DataSet();

                //Fill dataset with query results
                mySqlDataAdapter.Fill(dataset);

                //Set DataGridView control to read-only
                //Program._form1.DataGridView1.ReadOnly = true;
                
                //Set DataGridView data source to our dataset
                //Program._form1.DataGridView1.DataSource = dataset.Tables[0];

                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Number == 0 ? "Invalid username/password!" : "Could not find server!",
                    $"Error Number {e.Number}!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
        
        public DataSet ExecuteQuery(string query)
        {
            //Connection string
            string connStr =
                $"server={_server};user={_user};database={_database};port={_port};password={_password}";
            
            //MySqlConnection object
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                //Try to open connection
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                
                DataSet dataset = new DataSet();

                //Fill dataset with query results
                mySqlDataAdapter.Fill(dataset);

                return dataset;
            }
            catch
            {
                MessageBox.Show("Server disconnected...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        
        
        
        
    }
}