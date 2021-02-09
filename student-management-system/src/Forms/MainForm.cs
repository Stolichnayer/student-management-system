using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
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
            const string query = "SELECT * FROM students_copy1";

            DataSet dataset = DatabaseManager.GetInstance().ExecuteQuery(query);

            //Set DataGridView data source to our dataset
            DataGridView1.DataSource = dataset.Tables[0];

            //Disable buttons if there are no data
            if (DataGridView1.Rows.Count == 0)
            {
                removeButton.Enabled = false;
                editButton.Enabled = false;
            }

            totalStudentsLabel.Text = $"Total students: {DataGridView1.Rows.Count}";

            DataGridView1.Columns[0].HeaderText = "Reg. ID";
            DataGridView1.Columns[1].HeaderText = "First name";
            DataGridView1.Columns[2].HeaderText = "Last name";
            DataGridView1.Columns[3].HeaderText = "Email";
            DataGridView1.Columns[4].HeaderText = "Birth date";
            DataGridView1.Columns[5].HeaderText = "Reg. date";
            DataGridView1.Columns[6].HeaderText = "GPA";
        }

        private void SetColorEverySecondRow()
        {
            for (int i = 0; i < DataGridView1.Rows.Count; i += 2)
            {
                DataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private void cancelButton_AddP_Click(object sender, EventArgs e)
        {
            addPanel.Hide();
            dataGridView1.Enabled = true;
        }

        private void cancelButton_EditP_Click(object sender, EventArgs e)
        {
            editPanel.Hide();
            
            //Enable other buttons & grid
            addButton.Enabled = true;
            removeButton.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Hide all other panels
            editPanel.Hide();

            if (!addPanel.Visible)
            {
                addPanel.Show();
                removeButton.Enabled = false;
                editButton.Enabled = false;
                dataGridView1.Enabled = false;
                dataGridView1.ClearSelection();
                dataGridView1.CurrentCell = null;
            }
            else
            {
                addPanel.Hide();
                dataGridView1.Enabled = true;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //Hide all other panels
            addPanel.Hide();

            if (!editPanel.Visible)
            {
                string regID = dataGridView1.CurrentRow?.Cells[0].Value.ToString();
                string firstName = dataGridView1.CurrentRow?.Cells[1].Value.ToString();
                string lastName = dataGridView1.CurrentRow?.Cells[2].Value.ToString();
                string email = dataGridView1.CurrentRow?.Cells[3].Value.ToString();
                string gender = (dataGridView1.CurrentRow?.Cells[4].Value.ToString());
                string regDate = dataGridView1.CurrentRow?.Cells[5].Value.ToString().Substring(0,9);
                string birthDate = dataGridView1.CurrentRow?.Cells[6].Value.ToString().Substring(0, 9);
                Decimal gpa = Convert.ToDecimal(dataGridView1.CurrentRow?.Cells[7].Value.ToString());

                textBoxFname_EditP.Text = firstName;
                textBoxLname_EditP.Text = lastName;
                textBoxEmail_EditP.Text = email;

                switch (gender)
                {
                    case "Male":
                        maleRadioButton_EditP.Checked = true;
                        break;
                    case "Female":
                        femaleRadioButton_EditP.Checked = true;
                        break;
                    default:
                        otherRadioButton_EditP.Checked = true;
                        break;
                }

                dateTimePickerReg_EditP.Value =
                    DateTime.ParseExact($"{regDate}", "dd-MMM-yy", CultureInfo.InvariantCulture);

                dateTimePickerBirth_EditP.Value =
                    DateTime.ParseExact($"{birthDate}", "dd-MMM-yy", CultureInfo.InvariantCulture);

                numericUpDownGPA_EditP.Value = gpa;

                editPanel.Show();

                //Disable other buttons & grid
                removeButton.Enabled = false;
                addButton.Enabled = false;
                dataGridView1.Enabled = false;

                //dataGridView1.ClearSelection();
                //dataGridView1.CurrentCell = null;
            }
            else
            {
                editPanel.Hide();

                //Enable other buttons & grid
                dataGridView1.Enabled = true;
                removeButton.Enabled = true;
                addButton.Enabled = true;
            }
        }

        private void clearButton_AddP_Click(object sender, EventArgs e)
        {
            ClearDataInAddStudentPanel();
        }

        private void ClearDataInAddStudentPanel()
        {
            textBoxFname_AddP.Text = "";
            textBoxLname_AddP.Text = "";
            textBoxEmail_AddP.Text = "";
            maleRadioButton_AddP.Checked = true;
            numericUpDownGPA_AddP.Value = Decimal.Zero;
            dateTimePickerReg_AddP.Value = DateTime.Now;
            dateTimePickerBirth_AddP.Value = new DateTime(2003, 01, 01);
        }

        private void addButton_AddP_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

            string firstName = textBoxFname_AddP.Text;
            string lastName = textBoxLname_AddP.Text;
            string email = textBoxEmail_AddP.Text;
            string gender = maleRadioButton_AddP.Checked ? "Male" : femaleRadioButton_AddP.Checked ? "Female" : "Other";
            string birthDate = string.Format(dateTimePickerBirth_AddP.Value.ToString("yyyy-MM-dd"));
            string regDate = string.Format(dateTimePickerReg_AddP.Value.ToString("yyyy-MM-dd"));
            string gpa = numericUpDownGPA_AddP.Text;

            string query
                = "INSERT INTO students_copy1 (firstName, lastName, email, gender, birthDate, regDate, gpa) VALUES (" +
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
                addPanel.Hide();
                ClearDataInAddStudentPanel();
                dataGridView1.ClearSelection();
                dataGridView1.Rows[^1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.Rows.Count - 1];

                MessageBox.Show("The student record was added in the database successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var regID = dataGridView1.CurrentRow?.Cells[0].Value.ToString();
            var firstName = dataGridView1.CurrentRow?.Cells[1].Value.ToString();
            var lastName = dataGridView1.CurrentRow?.Cells[2].Value.ToString();

            var result = MessageBox.Show($"Are you sure you want to delete student {firstName} {lastName}?",
                "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query = $"DELETE FROM students_copy1 WHERE regID = {regID}";
                DatabaseManager.GetInstance().ExecuteNonQuery(query);

                int? row = dataGridView1.CurrentRow?.Index;
                UpdateDataGrid();

                if (row > 0)
                {
                    dataGridView1.CurrentCell = dataGridView1[0, (int)(row - 1)];
                    dataGridView1.Rows[(int) (row - 1)].Selected = true;

                }
            }
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            removeButton.Enabled = true;
            editButton.Enabled = true;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SetColorEverySecondRow();
            SetRowHeaderNumber();
        }

        private void SetRowHeaderNumber()
        {
            Console.Out.Write("ti fasi?");

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Added this to solve flickering issue at the DataGrid. Works like a charm and also fixed the flickering
            //when the Add Student panel opens. 10/10.
            //Source:
            //stackoverflow.com/questions/41893708/how-to-prevent-datagridview-from-flickering-when-scrolling-horizontally

            DataGridView1.GetType()
                .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                ?.SetValue(DataGridView1, true, null);
        }

        private void OKButton_EditP_Click(object sender, EventArgs e)
        {
            // TODO: paging

            string regID = dataGridView1.CurrentRow?.Cells[0].Value.ToString();
            string firstName = textBoxFname_EditP.Text;
            string lastName = textBoxLname_EditP.Text;
            string email = textBoxEmail_EditP.Text;
            string gender = maleRadioButton_EditP.Checked ? "Male" :
                femaleRadioButton_EditP.Checked ? "Female" : "Other";
            string regDate = dateTimePickerReg_EditP.Value.ToString("yyyy-MM-dd");

            string birthDate = dateTimePickerBirth_EditP.Value.ToString("yyyy-MM-dd");
            Decimal gpa = numericUpDownGPA_EditP.Value;

            string query = $"UPDATE students_copy1 " +
                           $"SET " +
                               $"firstName = \"{firstName}\", " +
                               $"lastName = \"{lastName}\", " +
                               $"email = \"{email}\", " +
                               $"gender = \"{gender}\", " +
                               $"regDate = \"{regDate}\", " +
                               $"birthDate = \"{birthDate}\", " +
                               $"gpa = {gpa} " +
                           $"WHERE regID = {regID}";

            int result = DatabaseManager.GetInstance().ExecuteNonQuery(query);

            if (result == 0 || result == -1) //Something went wrong
            {
                MessageBox.Show("An error occured. The Student record was not updated in the database.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The student record was updated successfully.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int index = dataGridView1.CurrentRow.Index;

            UpdateDataGrid();

            dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
           // dataGridView1.SelectedCells

            editPanel.Hide();

            //Enable other buttons & grid
            addButton.Enabled = true;
            editButton.Enabled = true;
            dataGridView1.Enabled = true;
        }
    }
}