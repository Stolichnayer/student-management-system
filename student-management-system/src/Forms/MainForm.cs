using System;
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
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            const string query = "SELECT * FROM students";
            
            DataSet dataset = DatabaseManager.GetInstance().ExecuteQuery(query);

            DatabaseManager.GetInstance().RowCount = dataset.Tables[0].Rows.Count;
            
            //Set DataGridView data source to our dataset
            DataGridView1.DataSource = dataset.Tables[0]; 
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
         {
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Value = 0;
            textBox4.Text = "";
            numericUpDown2.Value = Decimal.Zero;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = new DateTime(2003, 01, 01);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id = DatabaseManager.GetInstance().RowCount + 1;
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string regNum = numericUpDown1.Text;
            string email = textBox4.Text;
            string regDate = string.Format(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            string gpa = numericUpDown2.Text;
            string birthDate = string.Format(dateTimePicker2.Value.ToString("yyyy-MM-dd"));

            string query 
                = "INSERT INTO students VALUES (" + 
                  $"{id}, \"{firstName}\", \"{lastName}\", {regNum}, \"{email}\", \"{regDate}\", {gpa}, \"{birthDate}\")";

            Console.Out.WriteLine(query);
            int result = DatabaseManager.GetInstance().ExecuteNonQuery(query);

            if (result == 0 || result == -1) //Something went wrong
            {
                MessageBox.Show("An error occured. The Student record was not added in the database.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UpdateDataGrid();
                panel1.Hide();
                MessageBox.Show("The student record was added in the database successfully.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            
        }
        
    }
}