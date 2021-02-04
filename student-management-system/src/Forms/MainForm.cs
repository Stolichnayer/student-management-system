using System.Data;
using System.Windows.Forms;
using student_management_system.Controller;

namespace student_management_system.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillDataGridWithStudents();
        }

        private void FillDataGridWithStudents()
        {
            const string query = "SELECT * FROM students";
            
            DataSet dataset = DatabaseManager.GetInstance().ExecuteQuery(query);
            
            //Set DataGridView data source to our dataset
            DataGridView1.DataSource = dataset.Tables[0]; 
            
        }
        
    }
}