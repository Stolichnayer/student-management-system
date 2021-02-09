using System.Windows.Forms;

namespace student_management_system.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
            
            Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addStudentButton = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.addPanel = new System.Windows.Forms.Panel();
            this.groupBox1_AddP = new System.Windows.Forms.GroupBox();
            this.otherRadioButton_AddP = new System.Windows.Forms.RadioButton();
            this.maleRadioButton_AddP = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton_AddP = new System.Windows.Forms.RadioButton();
            this.genderLabel_AddP = new System.Windows.Forms.Label();
            this.numericUpDownGPA_AddP = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerBirth_AddP = new System.Windows.Forms.DateTimePicker();
            this.clearButton_AddP = new System.Windows.Forms.Button();
            this.cancelButton_AddP = new System.Windows.Forms.Button();
            this.addButton_AddP = new System.Windows.Forms.Button();
            this.dateTimePickerReg_AddP = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmail_AddP = new System.Windows.Forms.TextBox();
            this.textBoxLname_AddP = new System.Windows.Forms.TextBox();
            this.textBoxFname_AddP = new System.Windows.Forms.TextBox();
            this.birthLabel_AddP = new System.Windows.Forms.Label();
            this.gpaLabel_AddP = new System.Windows.Forms.Label();
            this.regLabel_AddP = new System.Windows.Forms.Label();
            this.emailLabel_AddP = new System.Windows.Forms.Label();
            this.lnameLabel_AddP = new System.Windows.Forms.Label();
            this.fnameLabel_AddP = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalStudentsLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.editButton = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.groupBox1_EditP = new System.Windows.Forms.GroupBox();
            this.otherRadioButton_EditP = new System.Windows.Forms.RadioButton();
            this.maleRadioButton_EditP = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton_EditP = new System.Windows.Forms.RadioButton();
            this.genderLabel_EditP = new System.Windows.Forms.Label();
            this.numericUpDownGPA_EditP = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerBirth_EditP = new System.Windows.Forms.DateTimePicker();
            this.cancelButton_EditP = new System.Windows.Forms.Button();
            this.OKButton_EditP = new System.Windows.Forms.Button();
            this.dateTimePickerReg_EditP = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmail_EditP = new System.Windows.Forms.TextBox();
            this.textBoxLname_EditP = new System.Windows.Forms.TextBox();
            this.textBoxFname_EditP = new System.Windows.Forms.TextBox();
            this.birthLabel_EditP = new System.Windows.Forms.Label();
            this.gpaLabel_EditP = new System.Windows.Forms.Label();
            this.regLabel_EditP = new System.Windows.Forms.Label();
            this.emailLabel_EditP = new System.Windows.Forms.Label();
            this.lnameLabel_EditP = new System.Windows.Forms.Label();
            this.fnameLabel_EditP = new System.Windows.Forms.Label();
            this.addPanel.SuspendLayout();
            this.groupBox1_AddP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGPA_AddP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.editPanel.SuspendLayout();
            this.groupBox1_EditP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGPA_EditP)).BeginInit();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(35, 24);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(168, 39);
            this.addStudentButton.TabIndex = 3;
            this.addStudentButton.Text = "Add student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Location = new System.Drawing.Point(35, 70);
            this.removeStudentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(168, 39);
            this.removeStudentButton.TabIndex = 4;
            this.removeStudentButton.Text = "Remove student";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.SystemColors.Control;
            this.addPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPanel.Controls.Add(this.groupBox1_AddP);
            this.addPanel.Controls.Add(this.genderLabel_AddP);
            this.addPanel.Controls.Add(this.numericUpDownGPA_AddP);
            this.addPanel.Controls.Add(this.dateTimePickerBirth_AddP);
            this.addPanel.Controls.Add(this.clearButton_AddP);
            this.addPanel.Controls.Add(this.cancelButton_AddP);
            this.addPanel.Controls.Add(this.addButton_AddP);
            this.addPanel.Controls.Add(this.dateTimePickerReg_AddP);
            this.addPanel.Controls.Add(this.textBoxEmail_AddP);
            this.addPanel.Controls.Add(this.textBoxLname_AddP);
            this.addPanel.Controls.Add(this.textBoxFname_AddP);
            this.addPanel.Controls.Add(this.birthLabel_AddP);
            this.addPanel.Controls.Add(this.gpaLabel_AddP);
            this.addPanel.Controls.Add(this.regLabel_AddP);
            this.addPanel.Controls.Add(this.emailLabel_AddP);
            this.addPanel.Controls.Add(this.lnameLabel_AddP);
            this.addPanel.Controls.Add(this.fnameLabel_AddP);
            this.addPanel.Location = new System.Drawing.Point(210, 24);
            this.addPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(392, 434);
            this.addPanel.TabIndex = 5;
            this.addPanel.Visible = false;
            // 
            // groupBox1_AddP
            // 
            this.groupBox1_AddP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1_AddP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1_AddP.Controls.Add(this.otherRadioButton_AddP);
            this.groupBox1_AddP.Controls.Add(this.maleRadioButton_AddP);
            this.groupBox1_AddP.Controls.Add(this.femaleRadioButton_AddP);
            this.groupBox1_AddP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1_AddP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1_AddP.Location = new System.Drawing.Point(134, 150);
            this.groupBox1_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1_AddP.Name = "groupBox1_AddP";
            this.groupBox1_AddP.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1_AddP.Size = new System.Drawing.Size(206, 32);
            this.groupBox1_AddP.TabIndex = 20;
            this.groupBox1_AddP.TabStop = false;
            // 
            // otherRadioButton_AddP
            // 
            this.otherRadioButton_AddP.Location = new System.Drawing.Point(145, 9);
            this.otherRadioButton_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.otherRadioButton_AddP.Name = "otherRadioButton_AddP";
            this.otherRadioButton_AddP.Size = new System.Drawing.Size(59, 21);
            this.otherRadioButton_AddP.TabIndex = 23;
            this.otherRadioButton_AddP.Text = "Other";
            this.otherRadioButton_AddP.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton_AddP
            // 
            this.maleRadioButton_AddP.Checked = true;
            this.maleRadioButton_AddP.Location = new System.Drawing.Point(6, 9);
            this.maleRadioButton_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maleRadioButton_AddP.Name = "maleRadioButton_AddP";
            this.maleRadioButton_AddP.Size = new System.Drawing.Size(56, 21);
            this.maleRadioButton_AddP.TabIndex = 21;
            this.maleRadioButton_AddP.TabStop = true;
            this.maleRadioButton_AddP.Text = "Male";
            this.maleRadioButton_AddP.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton_AddP
            // 
            this.femaleRadioButton_AddP.Location = new System.Drawing.Point(66, 9);
            this.femaleRadioButton_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.femaleRadioButton_AddP.Name = "femaleRadioButton_AddP";
            this.femaleRadioButton_AddP.Size = new System.Drawing.Size(72, 21);
            this.femaleRadioButton_AddP.TabIndex = 22;
            this.femaleRadioButton_AddP.Text = "Female";
            this.femaleRadioButton_AddP.UseVisualStyleBackColor = true;
            // 
            // genderLabel_AddP
            // 
            this.genderLabel_AddP.Location = new System.Drawing.Point(44, 156);
            this.genderLabel_AddP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderLabel_AddP.Name = "genderLabel_AddP";
            this.genderLabel_AddP.Size = new System.Drawing.Size(83, 21);
            this.genderLabel_AddP.TabIndex = 19;
            this.genderLabel_AddP.Text = "Gender";
            // 
            // numericUpDownGPA_AddP
            // 
            this.numericUpDownGPA_AddP.DecimalPlaces = 2;
            this.numericUpDownGPA_AddP.Location = new System.Drawing.Point(135, 268);
            this.numericUpDownGPA_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownGPA_AddP.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownGPA_AddP.Name = "numericUpDownGPA_AddP";
            this.numericUpDownGPA_AddP.Size = new System.Drawing.Size(111, 23);
            this.numericUpDownGPA_AddP.TabIndex = 18;
            // 
            // dateTimePickerBirth_AddP
            // 
            this.dateTimePickerBirth_AddP.CustomFormat = "dd-MM-yyy";
            this.dateTimePickerBirth_AddP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBirth_AddP.Location = new System.Drawing.Point(135, 194);
            this.dateTimePickerBirth_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerBirth_AddP.Name = "dateTimePickerBirth_AddP";
            this.dateTimePickerBirth_AddP.Size = new System.Drawing.Size(110, 23);
            this.dateTimePickerBirth_AddP.TabIndex = 16;
            this.dateTimePickerBirth_AddP.Value = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            // 
            // clearButton_AddP
            // 
            this.clearButton_AddP.Location = new System.Drawing.Point(13, 392);
            this.clearButton_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearButton_AddP.Name = "clearButton_AddP";
            this.clearButton_AddP.Size = new System.Drawing.Size(79, 28);
            this.clearButton_AddP.TabIndex = 15;
            this.clearButton_AddP.Text = "Clear";
            this.clearButton_AddP.UseVisualStyleBackColor = true;
            this.clearButton_AddP.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cancelButton_AddP
            // 
            this.cancelButton_AddP.Location = new System.Drawing.Point(194, 392);
            this.cancelButton_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton_AddP.Name = "cancelButton_AddP";
            this.cancelButton_AddP.Size = new System.Drawing.Size(79, 28);
            this.cancelButton_AddP.TabIndex = 14;
            this.cancelButton_AddP.Text = "Cancel";
            this.cancelButton_AddP.UseVisualStyleBackColor = true;
            this.cancelButton_AddP.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton_AddP
            // 
            this.addButton_AddP.Location = new System.Drawing.Point(280, 392);
            this.addButton_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addButton_AddP.Name = "addButton_AddP";
            this.addButton_AddP.Size = new System.Drawing.Size(79, 28);
            this.addButton_AddP.TabIndex = 13;
            this.addButton_AddP.Text = "Add";
            this.addButton_AddP.UseVisualStyleBackColor = true;
            this.addButton_AddP.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dateTimePickerReg_AddP
            // 
            this.dateTimePickerReg_AddP.CustomFormat = "dd-MM-yyy";
            this.dateTimePickerReg_AddP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReg_AddP.Location = new System.Drawing.Point(135, 226);
            this.dateTimePickerReg_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerReg_AddP.Name = "dateTimePickerReg_AddP";
            this.dateTimePickerReg_AddP.Size = new System.Drawing.Size(110, 23);
            this.dateTimePickerReg_AddP.TabIndex = 11;
            this.dateTimePickerReg_AddP.Value = new System.DateTime(2021, 2, 5, 1, 7, 54, 0);
            // 
            // textBoxEmail_AddP
            // 
            this.textBoxEmail_AddP.Location = new System.Drawing.Point(135, 120);
            this.textBoxEmail_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEmail_AddP.Name = "textBoxEmail_AddP";
            this.textBoxEmail_AddP.Size = new System.Drawing.Size(205, 23);
            this.textBoxEmail_AddP.TabIndex = 10;
            // 
            // textBoxLname_AddP
            // 
            this.textBoxLname_AddP.Location = new System.Drawing.Point(135, 85);
            this.textBoxLname_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLname_AddP.Name = "textBoxLname_AddP";
            this.textBoxLname_AddP.Size = new System.Drawing.Size(205, 23);
            this.textBoxLname_AddP.TabIndex = 8;
            // 
            // textBoxFname_AddP
            // 
            this.textBoxFname_AddP.Location = new System.Drawing.Point(135, 46);
            this.textBoxFname_AddP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFname_AddP.Name = "textBoxFname_AddP";
            this.textBoxFname_AddP.Size = new System.Drawing.Size(205, 23);
            this.textBoxFname_AddP.TabIndex = 7;
            // 
            // birthLabel_AddP
            // 
            this.birthLabel_AddP.Location = new System.Drawing.Point(44, 194);
            this.birthLabel_AddP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthLabel_AddP.Name = "birthLabel_AddP";
            this.birthLabel_AddP.Size = new System.Drawing.Size(84, 17);
            this.birthLabel_AddP.TabIndex = 6;
            this.birthLabel_AddP.Text = "Birth Date";
            // 
            // gpaLabel_AddP
            // 
            this.gpaLabel_AddP.Location = new System.Drawing.Point(44, 270);
            this.gpaLabel_AddP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpaLabel_AddP.Name = "gpaLabel_AddP";
            this.gpaLabel_AddP.Size = new System.Drawing.Size(84, 17);
            this.gpaLabel_AddP.TabIndex = 5;
            this.gpaLabel_AddP.Text = "GPA";
            // 
            // regLabel_AddP
            // 
            this.regLabel_AddP.Location = new System.Drawing.Point(44, 232);
            this.regLabel_AddP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regLabel_AddP.Name = "regLabel_AddP";
            this.regLabel_AddP.Size = new System.Drawing.Size(84, 17);
            this.regLabel_AddP.TabIndex = 4;
            this.regLabel_AddP.Text = "Reg. Date";
            // 
            // emailLabel_AddP
            // 
            this.emailLabel_AddP.Location = new System.Drawing.Point(44, 126);
            this.emailLabel_AddP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel_AddP.Name = "emailLabel_AddP";
            this.emailLabel_AddP.Size = new System.Drawing.Size(84, 17);
            this.emailLabel_AddP.TabIndex = 3;
            this.emailLabel_AddP.Text = "Email";
            // 
            // lnameLabel_AddP
            // 
            this.lnameLabel_AddP.Location = new System.Drawing.Point(44, 85);
            this.lnameLabel_AddP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnameLabel_AddP.Name = "lnameLabel_AddP";
            this.lnameLabel_AddP.Size = new System.Drawing.Size(84, 17);
            this.lnameLabel_AddP.TabIndex = 1;
            this.lnameLabel_AddP.Text = "Last name";
            // 
            // fnameLabel_AddP
            // 
            this.fnameLabel_AddP.Location = new System.Drawing.Point(44, 46);
            this.fnameLabel_AddP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fnameLabel_AddP.Name = "fnameLabel_AddP";
            this.fnameLabel_AddP.Size = new System.Drawing.Size(84, 17);
            this.fnameLabel_AddP.TabIndex = 0;
            this.fnameLabel_AddP.Text = "First name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.Size = new System.Drawing.Size(834, 522);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // totalStudentsLabel
            // 
            this.totalStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalStudentsLabel.Location = new System.Drawing.Point(238, 547);
            this.totalStudentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalStudentsLabel.Name = "totalStudentsLabel";
            this.totalStudentsLabel.Size = new System.Drawing.Size(217, 33);
            this.totalStudentsLabel.TabIndex = 6;
            this.totalStudentsLabel.Text = "Total students:";
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(7, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 20);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(71, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 20);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(128, 9);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 20);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Other";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(35, 117);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(168, 39);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit Student";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.SystemColors.Control;
            this.editPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editPanel.Controls.Add(this.groupBox1_EditP);
            this.editPanel.Controls.Add(this.genderLabel_EditP);
            this.editPanel.Controls.Add(this.numericUpDownGPA_EditP);
            this.editPanel.Controls.Add(this.dateTimePickerBirth_EditP);
            this.editPanel.Controls.Add(this.cancelButton_EditP);
            this.editPanel.Controls.Add(this.OKButton_EditP);
            this.editPanel.Controls.Add(this.dateTimePickerReg_EditP);
            this.editPanel.Controls.Add(this.textBoxEmail_EditP);
            this.editPanel.Controls.Add(this.textBoxLname_EditP);
            this.editPanel.Controls.Add(this.textBoxFname_EditP);
            this.editPanel.Controls.Add(this.birthLabel_EditP);
            this.editPanel.Controls.Add(this.gpaLabel_EditP);
            this.editPanel.Controls.Add(this.regLabel_EditP);
            this.editPanel.Controls.Add(this.emailLabel_EditP);
            this.editPanel.Controls.Add(this.lnameLabel_EditP);
            this.editPanel.Controls.Add(this.fnameLabel_EditP);
            this.editPanel.Location = new System.Drawing.Point(610, 24);
            this.editPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(392, 434);
            this.editPanel.TabIndex = 21;
            this.editPanel.Visible = false;
            // 
            // groupBox1_EditP
            // 
            this.groupBox1_EditP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1_EditP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1_EditP.Controls.Add(this.otherRadioButton_EditP);
            this.groupBox1_EditP.Controls.Add(this.maleRadioButton_EditP);
            this.groupBox1_EditP.Controls.Add(this.femaleRadioButton_EditP);
            this.groupBox1_EditP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1_EditP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1_EditP.Location = new System.Drawing.Point(134, 150);
            this.groupBox1_EditP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1_EditP.Name = "groupBox1_EditP";
            this.groupBox1_EditP.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1_EditP.Size = new System.Drawing.Size(206, 32);
            this.groupBox1_EditP.TabIndex = 20;
            this.groupBox1_EditP.TabStop = false;
            // 
            // otherRadioButton_EditP
            // 
            this.otherRadioButton_EditP.Location = new System.Drawing.Point(145, 9);
            this.otherRadioButton_EditP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.otherRadioButton_EditP.Name = "otherRadioButton_EditP";
            this.otherRadioButton_EditP.Size = new System.Drawing.Size(59, 21);
            this.otherRadioButton_EditP.TabIndex = 23;
            this.otherRadioButton_EditP.Text = "Other";
            this.otherRadioButton_EditP.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton_EditP
            // 
            this.maleRadioButton_EditP.Checked = true;
            this.maleRadioButton_EditP.Location = new System.Drawing.Point(6, 9);
            this.maleRadioButton_EditP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maleRadioButton_EditP.Name = "maleRadioButton_EditP";
            this.maleRadioButton_EditP.Size = new System.Drawing.Size(56, 21);
            this.maleRadioButton_EditP.TabIndex = 21;
            this.maleRadioButton_EditP.TabStop = true;
            this.maleRadioButton_EditP.Text = "Male";
            this.maleRadioButton_EditP.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton_EditP
            // 
            this.femaleRadioButton_EditP.Location = new System.Drawing.Point(66, 9);
            this.femaleRadioButton_EditP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.femaleRadioButton_EditP.Name = "femaleRadioButton_EditP";
            this.femaleRadioButton_EditP.Size = new System.Drawing.Size(72, 21);
            this.femaleRadioButton_EditP.TabIndex = 22;
            this.femaleRadioButton_EditP.Text = "Female";
            this.femaleRadioButton_EditP.UseVisualStyleBackColor = true;
            // 
            // genderLabel_EditP
            // 
            this.genderLabel_EditP.Location = new System.Drawing.Point(44, 156);
            this.genderLabel_EditP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderLabel_EditP.Name = "genderLabel_EditP";
            this.genderLabel_EditP.Size = new System.Drawing.Size(83, 21);
            this.genderLabel_EditP.TabIndex = 19;
            this.genderLabel_EditP.Text = "Gender";
            // 
            // numericUpDownGPA_EditP
            // 
            this.numericUpDownGPA_EditP.DecimalPlaces = 2;
            this.numericUpDownGPA_EditP.Location = new System.Drawing.Point(135, 268);
            this.numericUpDownGPA_EditP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownGPA_EditP.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownGPA_EditP.Name = "numericUpDownGPA_EditP";
            this.numericUpDownGPA_EditP.Size = new System.Drawing.Size(111, 23);
            this.numericUpDownGPA_EditP.TabIndex = 18;
            // 
            // dateTimePickerBirth_EditP
            // 
            this.dateTimePickerBirth_EditP.CustomFormat = "dd-MM-yyy";
            this.dateTimePickerBirth_EditP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBirth_EditP.Location = new System.Drawing.Point(135, 194);
            this.dateTimePickerBirth_EditP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerBirth_EditP.Name = "dateTimePickerBirth_EditP";
            this.dateTimePickerBirth_EditP.Size = new System.Drawing.Size(110, 23);
            this.dateTimePickerBirth_EditP.TabIndex = 16;
            this.dateTimePickerBirth_EditP.Value = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            // 
            // cancelButton_EditP
            // 
            this.cancelButton_EditP.Location = new System.Drawing.Point(194, 392);
            this.cancelButton_EditP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton_EditP.Name = "cancelButton_EditP";
            this.cancelButton_EditP.Size = new System.Drawing.Size(79, 28);
            this.cancelButton_EditP.TabIndex = 14;
            this.cancelButton_EditP.Text = "Cancel";
            this.cancelButton_EditP.UseVisualStyleBackColor = true;
            // 
            // OKButton_EditP
            // 
            this.OKButton_EditP.Location = new System.Drawing.Point(280, 392);
            this.OKButton_EditP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OKButton_EditP.Name = "OKButton_EditP";
            this.OKButton_EditP.Size = new System.Drawing.Size(79, 28);
            this.OKButton_EditP.TabIndex = 13;
            this.OKButton_EditP.Text = "OK";
            this.OKButton_EditP.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerReg_EditP
            // 
            this.dateTimePickerReg_EditP.CustomFormat = "dd-MM-yyy";
            this.dateTimePickerReg_EditP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReg_EditP.Location = new System.Drawing.Point(135, 226);
            this.dateTimePickerReg_EditP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerReg_EditP.Name = "dateTimePickerReg_EditP";
            this.dateTimePickerReg_EditP.Size = new System.Drawing.Size(110, 23);
            this.dateTimePickerReg_EditP.TabIndex = 11;
            this.dateTimePickerReg_EditP.Value = new System.DateTime(2021, 2, 5, 1, 7, 54, 0);
            // 
            // textBoxEmail_EditP
            // 
            this.textBoxEmail_EditP.Location = new System.Drawing.Point(135, 120);
            this.textBoxEmail_EditP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEmail_EditP.Name = "textBoxEmail_EditP";
            this.textBoxEmail_EditP.Size = new System.Drawing.Size(205, 23);
            this.textBoxEmail_EditP.TabIndex = 10;
            // 
            // textBoxLname_EditP
            // 
            this.textBoxLname_EditP.Location = new System.Drawing.Point(135, 85);
            this.textBoxLname_EditP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLname_EditP.Name = "textBoxLname_EditP";
            this.textBoxLname_EditP.Size = new System.Drawing.Size(205, 23);
            this.textBoxLname_EditP.TabIndex = 8;
            // 
            // textBoxFname_EditP
            // 
            this.textBoxFname_EditP.Location = new System.Drawing.Point(135, 46);
            this.textBoxFname_EditP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFname_EditP.Name = "textBoxFname_EditP";
            this.textBoxFname_EditP.Size = new System.Drawing.Size(205, 23);
            this.textBoxFname_EditP.TabIndex = 7;
            // 
            // birthLabel_EditP
            // 
            this.birthLabel_EditP.Location = new System.Drawing.Point(44, 194);
            this.birthLabel_EditP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthLabel_EditP.Name = "birthLabel_EditP";
            this.birthLabel_EditP.Size = new System.Drawing.Size(84, 17);
            this.birthLabel_EditP.TabIndex = 6;
            this.birthLabel_EditP.Text = "Birth Date";
            // 
            // gpaLabel_EditP
            // 
            this.gpaLabel_EditP.Location = new System.Drawing.Point(44, 270);
            this.gpaLabel_EditP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpaLabel_EditP.Name = "gpaLabel_EditP";
            this.gpaLabel_EditP.Size = new System.Drawing.Size(84, 17);
            this.gpaLabel_EditP.TabIndex = 5;
            this.gpaLabel_EditP.Text = "GPA";
            // 
            // regLabel_EditP
            // 
            this.regLabel_EditP.Location = new System.Drawing.Point(44, 232);
            this.regLabel_EditP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regLabel_EditP.Name = "regLabel_EditP";
            this.regLabel_EditP.Size = new System.Drawing.Size(84, 17);
            this.regLabel_EditP.TabIndex = 4;
            this.regLabel_EditP.Text = "Reg. Date";
            // 
            // emailLabel_EditP
            // 
            this.emailLabel_EditP.Location = new System.Drawing.Point(44, 126);
            this.emailLabel_EditP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel_EditP.Name = "emailLabel_EditP";
            this.emailLabel_EditP.Size = new System.Drawing.Size(84, 17);
            this.emailLabel_EditP.TabIndex = 3;
            this.emailLabel_EditP.Text = "Email";
            // 
            // lnameLabel_EditP
            // 
            this.lnameLabel_EditP.Location = new System.Drawing.Point(44, 85);
            this.lnameLabel_EditP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnameLabel_EditP.Name = "lnameLabel_EditP";
            this.lnameLabel_EditP.Size = new System.Drawing.Size(84, 17);
            this.lnameLabel_EditP.TabIndex = 1;
            this.lnameLabel_EditP.Text = "Last name";
            // 
            // fnameLabel_EditP
            // 
            this.fnameLabel_EditP.Location = new System.Drawing.Point(44, 46);
            this.fnameLabel_EditP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fnameLabel_EditP.Name = "fnameLabel_EditP";
            this.fnameLabel_EditP.Size = new System.Drawing.Size(84, 17);
            this.fnameLabel_EditP.TabIndex = 0;
            this.fnameLabel_EditP.Text = "First name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1146, 653);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.totalStudentsLabel);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.groupBox1_AddP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGPA_AddP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.groupBox1_EditP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGPA_EditP)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button editButton;

        private System.Windows.Forms.GroupBox groupBox1_AddP;
        private System.Windows.Forms.RadioButton maleRadioButton_AddP;
        private System.Windows.Forms.RadioButton femaleRadioButton_AddP;
        private System.Windows.Forms.RadioButton otherRadioButton_AddP;

        private System.Windows.Forms.Label genderLabel_AddP;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;

        private System.Windows.Forms.Label totalStudentsLabel;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.NumericUpDown numericUpDownGPA_AddP;

        private System.Windows.Forms.DateTimePicker dateTimePickerBirth_AddP;

        private System.Windows.Forms.Button clearButton_AddP;

        private System.Windows.Forms.Button addButton_AddP;
        private System.Windows.Forms.Button cancelButton_AddP;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerReg_AddP;

        private System.Windows.Forms.TextBox textBoxFname_AddP;
        private System.Windows.Forms.TextBox textBoxLname_AddP;
        private System.Windows.Forms.TextBox textBoxEmail_AddP;

        private System.Windows.Forms.Label gpaLabel_AddP;
        private System.Windows.Forms.Label birthLabel_AddP;

        private System.Windows.Forms.Label fnameLabel_AddP;
        private System.Windows.Forms.Label lnameLabel_AddP;
        private System.Windows.Forms.Label emailLabel_AddP;
        private System.Windows.Forms.Label regLabel_AddP;

        private System.Windows.Forms.Panel addPanel;

        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button removeStudentButton;
        private Panel editPanel;
        private GroupBox groupBox1_EditP;
        private RadioButton otherRadioButton_EditP;
        private RadioButton maleRadioButton_EditP;
        private RadioButton femaleRadioButton_EditP;
        private Label genderLabel_EditP;
        private NumericUpDown numericUpDownGPA_EditP;
        private DateTimePicker dateTimePickerBirth_EditP;
        private Button cancelButton_EditP;
        private Button OKButton_EditP;
        private DateTimePicker dateTimePickerReg_EditP;
        private TextBox textBoxEmail_EditP;
        private TextBox textBoxLname_EditP;
        private TextBox textBoxFname_EditP;
        private Label birthLabel_EditP;
        private Label gpaLabel_EditP;
        private Label regLabel_EditP;
        private Label emailLabel_EditP;
        private Label lnameLabel_EditP;
        private Label fnameLabel_EditP;

        public DataGridView DataGridView1
        {
            get => dataGridView1;
            set => dataGridView1 = value;
        }

        #endregion
    }
}