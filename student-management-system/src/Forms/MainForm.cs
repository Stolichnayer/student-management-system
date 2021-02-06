using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
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

            //Set DataGridView data source to our dataset
            DataGridView1.DataSource = dataset.Tables[0];

            totalStudentsLabel.Text = $"Total students: {DataGridView1.Rows.Count}";

            DataGridView1.Columns[0].HeaderText = "Reg. ID";
            DataGridView1.Columns[1].HeaderText = "First name";
            DataGridView1.Columns[2].HeaderText = "Last name";
            DataGridView1.Columns[3].HeaderText = "Email";
            DataGridView1.Columns[4].HeaderText = "Birth date";
            DataGridView1.Columns[5].HeaderText = "Reg. date";
            DataGridView1.Columns[6].HeaderText = "GPA";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            dataGridView1.Enabled = true;
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                panel1.Show();
                removeStudentButton.Enabled = false;
                dataGridView1.Enabled = false;
                dataGridView1.ClearSelection();
                dataGridView1.CurrentCell = null;
            }
            else
            {
                panel1.Hide();
                dataGridView1.Enabled = true;
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearDataInAddStudentPanel();
        }

        private void ClearDataInAddStudentPanel()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            maleRadioButton.Checked = true;
            numericUpDown2.Value = Decimal.Zero;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = new DateTime(2003, 01, 01);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string email = textBox4.Text;
            string gender = maleRadioButton.Checked ? "Male" : femaleRadioButton.Checked ? "Female" : "Other";
            string birthDate = string.Format(dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            string regDate = string.Format(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            string gpa = numericUpDown2.Text;

            string query
                = "INSERT INTO students (firstName, lastName, email, gender, birthDate, regDate, gpa) VALUES (" +
                  $"\"{firstName}\", \"{lastName}\", \"{email}\", \"{gender}\", \"{birthDate}\", \"{regDate}\", {gpa})";

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
                ClearDataInAddStudentPanel();
                dataGridView1.ClearSelection();
                dataGridView1.Rows[^1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[^1].Cells[^1];
                MessageBox.Show("The student record was added in the database successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            var regID = dataGridView1.CurrentRow?.Cells[0].Value.ToString();
            var firstName = dataGridView1.CurrentRow?.Cells[1].Value.ToString();
            var lastName = dataGridView1.CurrentRow?.Cells[2].Value.ToString();

            var result = MessageBox.Show($"Are you sure you want to delete student {firstName} {lastName}?",
                "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query = $"DELETE FROM students WHERE regID = {regID}";
                DatabaseManager.GetInstance().ExecuteQuery(query);
                UpdateDataGrid();
                dataGridView1.ClearSelection();
                removeStudentButton.Enabled = false;
                dataGridView1.CurrentCell = null;
            }
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            removeStudentButton.Enabled = false;

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            removeStudentButton.Enabled = true;
        }

        private void panel1_Leave(object sender, EventArgs e)
        {

        }
    }
}