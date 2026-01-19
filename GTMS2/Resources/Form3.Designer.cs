namespace GTMS2.Resources
{
    partial class adminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.switchUser = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.changeAdminPasskey = new System.Windows.Forms.Button();
            this.changeInstructorPasskey = new System.Windows.Forms.Button();
            this.manageCourses = new System.Windows.Forms.Button();
            this.manageUsers = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.placeholderName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userControl = new System.Windows.Forms.Panel();
            this.searchBoxUsers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userRoles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.returnButton1 = new System.Windows.Forms.Button();
            this.cancelChangesUser = new System.Windows.Forms.Button();
            this.saveChangesUser = new System.Windows.Forms.Button();
            this.employeeInfo = new System.Windows.Forms.DataGridView();
            this.employeeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isInstructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfo = new System.Windows.Forms.DataGridView();
            this.studentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.courseControl = new System.Windows.Forms.Panel();
            this.searchBoxCourses = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.returnButton2 = new System.Windows.Forms.Button();
            this.cancelChangesCourses = new System.Windows.Forms.Button();
            this.saveChangesCourses = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.courses = new System.Windows.Forms.DataGridView();
            this.courseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlePanel.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.userControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfo)).BeginInit();
            this.courseControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courses)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.LimeGreen;
            this.titlePanel.Controls.Add(this.switchUser);
            this.titlePanel.Controls.Add(this.logout);
            this.titlePanel.Controls.Add(this.label2);
            this.titlePanel.Controls.Add(this.panel1);
            this.titlePanel.Location = new System.Drawing.Point(0, 1);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1903, 136);
            this.titlePanel.TabIndex = 2;
            // 
            // switchUser
            // 
            this.switchUser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.switchUser.Font = new System.Drawing.Font("Franklin Gothic Demi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchUser.ForeColor = System.Drawing.Color.White;
            this.switchUser.Location = new System.Drawing.Point(1514, 28);
            this.switchUser.Name = "switchUser";
            this.switchUser.Size = new System.Drawing.Size(183, 76);
            this.switchUser.TabIndex = 3;
            this.switchUser.Text = "Switch";
            this.switchUser.UseVisualStyleBackColor = false;
            this.switchUser.Visible = false;
            this.switchUser.Click += new System.EventHandler(this.switchUser_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Crimson;
            this.logout.Font = new System.Drawing.Font("Franklin Gothic Demi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(1703, 28);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(183, 76);
            this.logout.TabIndex = 2;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(933, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade Transparency and Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GTMS2.Properties.Resources.gtms_logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(52, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 133);
            this.panel1.TabIndex = 0;
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.Indigo;
            this.welcomePanel.Controls.Add(this.changeAdminPasskey);
            this.welcomePanel.Controls.Add(this.changeInstructorPasskey);
            this.welcomePanel.Controls.Add(this.manageCourses);
            this.welcomePanel.Controls.Add(this.manageUsers);
            this.welcomePanel.Controls.Add(this.label6);
            this.welcomePanel.Controls.Add(this.placeholderName);
            this.welcomePanel.Controls.Add(this.label5);
            this.welcomePanel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F);
            this.welcomePanel.ForeColor = System.Drawing.Color.White;
            this.welcomePanel.Location = new System.Drawing.Point(44, 184);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(1805, 795);
            this.welcomePanel.TabIndex = 3;
            // 
            // changeAdminPasskey
            // 
            this.changeAdminPasskey.BackColor = System.Drawing.Color.Crimson;
            this.changeAdminPasskey.Location = new System.Drawing.Point(861, 600);
            this.changeAdminPasskey.Name = "changeAdminPasskey";
            this.changeAdminPasskey.Size = new System.Drawing.Size(609, 91);
            this.changeAdminPasskey.TabIndex = 11;
            this.changeAdminPasskey.Text = "Change Admin Passkey";
            this.changeAdminPasskey.UseVisualStyleBackColor = false;
            this.changeAdminPasskey.Click += new System.EventHandler(this.changeAdminPasskey_Click);
            // 
            // changeInstructorPasskey
            // 
            this.changeInstructorPasskey.BackColor = System.Drawing.Color.SteelBlue;
            this.changeInstructorPasskey.Location = new System.Drawing.Point(861, 474);
            this.changeInstructorPasskey.Name = "changeInstructorPasskey";
            this.changeInstructorPasskey.Size = new System.Drawing.Size(609, 91);
            this.changeInstructorPasskey.TabIndex = 10;
            this.changeInstructorPasskey.Text = "Change Instructor Passkey";
            this.changeInstructorPasskey.UseVisualStyleBackColor = false;
            this.changeInstructorPasskey.Click += new System.EventHandler(this.changeInstructorPasskey_Click);
            // 
            // manageCourses
            // 
            this.manageCourses.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.manageCourses.Location = new System.Drawing.Point(367, 600);
            this.manageCourses.Name = "manageCourses";
            this.manageCourses.Size = new System.Drawing.Size(397, 91);
            this.manageCourses.TabIndex = 9;
            this.manageCourses.Text = "Manage Courses";
            this.manageCourses.UseVisualStyleBackColor = false;
            this.manageCourses.Click += new System.EventHandler(this.manageCourses_Click);
            // 
            // manageUsers
            // 
            this.manageUsers.BackColor = System.Drawing.Color.DarkGreen;
            this.manageUsers.Location = new System.Drawing.Point(367, 474);
            this.manageUsers.Name = "manageUsers";
            this.manageUsers.Size = new System.Drawing.Size(397, 91);
            this.manageUsers.TabIndex = 8;
            this.manageUsers.Text = "Manage Users";
            this.manageUsers.UseVisualStyleBackColor = false;
            this.manageUsers.Click += new System.EventHandler(this.manageUsers_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1147, 120);
            this.label6.TabIndex = 7;
            this.label6.Text = "What do you want to do today?\r\n";
            // 
            // placeholderName
            // 
            this.placeholderName.AutoSize = true;
            this.placeholderName.BackColor = System.Drawing.Color.Transparent;
            this.placeholderName.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderName.ForeColor = System.Drawing.Color.White;
            this.placeholderName.Location = new System.Drawing.Point(509, 73);
            this.placeholderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.placeholderName.Name = "placeholderName";
            this.placeholderName.Size = new System.Drawing.Size(657, 328);
            this.placeholderName.TabIndex = 6;
            this.placeholderName.Text = "placeholder\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 106);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(409, 120);
            this.label5.TabIndex = 5;
            this.label5.Text = "Welcome,";
            // 
            // userControl
            // 
            this.userControl.BackColor = System.Drawing.Color.Indigo;
            this.userControl.Controls.Add(this.searchBoxUsers);
            this.userControl.Controls.Add(this.label4);
            this.userControl.Controls.Add(this.userRoles);
            this.userControl.Controls.Add(this.label3);
            this.userControl.Controls.Add(this.returnButton1);
            this.userControl.Controls.Add(this.cancelChangesUser);
            this.userControl.Controls.Add(this.saveChangesUser);
            this.userControl.Controls.Add(this.employeeInfo);
            this.userControl.Controls.Add(this.studentInfo);
            this.userControl.Controls.Add(this.label1);
            this.userControl.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl.ForeColor = System.Drawing.Color.White;
            this.userControl.Location = new System.Drawing.Point(44, 184);
            this.userControl.Name = "userControl";
            this.userControl.Size = new System.Drawing.Size(1805, 795);
            this.userControl.TabIndex = 10;
            // 
            // searchBoxUsers
            // 
            this.searchBoxUsers.Location = new System.Drawing.Point(761, 208);
            this.searchBoxUsers.Name = "searchBoxUsers";
            this.searchBoxUsers.Size = new System.Drawing.Size(843, 48);
            this.searchBoxUsers.TabIndex = 19;
            this.searchBoxUsers.TextChanged += new System.EventHandler(this.searchBoxUsers_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 42);
            this.label4.TabIndex = 18;
            this.label4.Text = "Search:";
            // 
            // userRoles
            // 
            this.userRoles.FormattingEnabled = true;
            this.userRoles.Items.AddRange(new object[] {
            "Students",
            "Employees"});
            this.userRoles.Location = new System.Drawing.Point(319, 211);
            this.userRoles.Name = "userRoles";
            this.userRoles.Size = new System.Drawing.Size(248, 50);
            this.userRoles.TabIndex = 16;
            this.userRoles.SelectedIndexChanged += new System.EventHandler(this.userRoles_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 42);
            this.label3.TabIndex = 15;
            this.label3.Text = "Now viewing:";
            // 
            // returnButton1
            // 
            this.returnButton1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F);
            this.returnButton1.ForeColor = System.Drawing.Color.Black;
            this.returnButton1.Location = new System.Drawing.Point(1695, 19);
            this.returnButton1.Name = "returnButton1";
            this.returnButton1.Size = new System.Drawing.Size(93, 67);
            this.returnButton1.TabIndex = 13;
            this.returnButton1.Text = "<";
            this.returnButton1.UseVisualStyleBackColor = true;
            // 
            // cancelChangesUser
            // 
            this.cancelChangesUser.BackColor = System.Drawing.Color.Crimson;
            this.cancelChangesUser.Enabled = false;
            this.cancelChangesUser.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.cancelChangesUser.ForeColor = System.Drawing.Color.White;
            this.cancelChangesUser.Location = new System.Drawing.Point(1420, 535);
            this.cancelChangesUser.Name = "cancelChangesUser";
            this.cancelChangesUser.Size = new System.Drawing.Size(270, 59);
            this.cancelChangesUser.TabIndex = 12;
            this.cancelChangesUser.Text = "Cancel Changes";
            this.cancelChangesUser.UseVisualStyleBackColor = false;
            this.cancelChangesUser.Click += new System.EventHandler(this.cancelChangesUser_Click);
            // 
            // saveChangesUser
            // 
            this.saveChangesUser.BackColor = System.Drawing.Color.DarkGreen;
            this.saveChangesUser.Enabled = false;
            this.saveChangesUser.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesUser.ForeColor = System.Drawing.Color.White;
            this.saveChangesUser.Location = new System.Drawing.Point(1420, 419);
            this.saveChangesUser.Name = "saveChangesUser";
            this.saveChangesUser.Size = new System.Drawing.Size(270, 59);
            this.saveChangesUser.TabIndex = 11;
            this.saveChangesUser.Text = "Save Changes";
            this.saveChangesUser.UseVisualStyleBackColor = false;
            this.saveChangesUser.Click += new System.EventHandler(this.saveChangesUser_Click);
            // 
            // employeeInfo
            // 
            this.employeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNumber,
            this.employeeName,
            this.employeeEmail,
            this.department,
            this.isAdmin,
            this.isInstructor});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeInfo.DefaultCellStyle = dataGridViewCellStyle5;
            this.employeeInfo.Location = new System.Drawing.Point(319, 315);
            this.employeeInfo.Name = "employeeInfo";
            this.employeeInfo.RowHeadersWidth = 62;
            this.employeeInfo.RowTemplate.Height = 28;
            this.employeeInfo.Size = new System.Drawing.Size(968, 429);
            this.employeeInfo.TabIndex = 17;
            this.employeeInfo.Visible = false;
            // 
            // employeeNumber
            // 
            this.employeeNumber.HeaderText = "Employee Number";
            this.employeeNumber.MinimumWidth = 8;
            this.employeeNumber.Name = "employeeNumber";
            this.employeeNumber.Width = 150;
            // 
            // employeeName
            // 
            this.employeeName.HeaderText = "Name";
            this.employeeName.MinimumWidth = 8;
            this.employeeName.Name = "employeeName";
            this.employeeName.Width = 150;
            // 
            // employeeEmail
            // 
            this.employeeEmail.HeaderText = "Email";
            this.employeeEmail.MinimumWidth = 8;
            this.employeeEmail.Name = "employeeEmail";
            this.employeeEmail.Width = 150;
            // 
            // department
            // 
            this.department.HeaderText = "Department";
            this.department.MinimumWidth = 8;
            this.department.Name = "department";
            this.department.Width = 150;
            // 
            // isAdmin
            // 
            this.isAdmin.HeaderText = "isAdmin";
            this.isAdmin.MinimumWidth = 8;
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Width = 150;
            // 
            // isInstructor
            // 
            this.isInstructor.HeaderText = "isInstructor";
            this.isInstructor.MinimumWidth = 8;
            this.isInstructor.Name = "isInstructor";
            this.isInstructor.Width = 150;
            // 
            // studentInfo
            // 
            this.studentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNumber,
            this.firstnameStudent,
            this.lastnameStudent,
            this.studentEmail,
            this.roleStudents});
            this.studentInfo.Location = new System.Drawing.Point(463, 315);
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.RowHeadersWidth = 62;
            this.studentInfo.RowTemplate.Height = 28;
            this.studentInfo.Size = new System.Drawing.Size(817, 429);
            this.studentInfo.TabIndex = 14;
            this.studentInfo.Visible = false;
            // 
            // studentNumber
            // 
            this.studentNumber.HeaderText = "Student Number";
            this.studentNumber.MinimumWidth = 8;
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Width = 150;
            // 
            // firstnameStudent
            // 
            this.firstnameStudent.HeaderText = "First Name";
            this.firstnameStudent.MinimumWidth = 8;
            this.firstnameStudent.Name = "firstnameStudent";
            this.firstnameStudent.Width = 150;
            // 
            // lastnameStudent
            // 
            this.lastnameStudent.HeaderText = "Last Name";
            this.lastnameStudent.MinimumWidth = 8;
            this.lastnameStudent.Name = "lastnameStudent";
            this.lastnameStudent.Width = 150;
            // 
            // studentEmail
            // 
            this.studentEmail.HeaderText = "Email";
            this.studentEmail.MinimumWidth = 8;
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.Width = 150;
            // 
            // roleStudents
            // 
            this.roleStudents.HeaderText = "Role";
            this.roleStudents.MinimumWidth = 8;
            this.roleStudents.Name = "roleStudents";
            this.roleStudents.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 360);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage Users\r\n\r\n\r\n";
            // 
            // courseControl
            // 
            this.courseControl.BackColor = System.Drawing.Color.Indigo;
            this.courseControl.Controls.Add(this.searchBoxCourses);
            this.courseControl.Controls.Add(this.label7);
            this.courseControl.Controls.Add(this.returnButton2);
            this.courseControl.Controls.Add(this.cancelChangesCourses);
            this.courseControl.Controls.Add(this.saveChangesCourses);
            this.courseControl.Controls.Add(this.label9);
            this.courseControl.Controls.Add(this.courses);
            this.courseControl.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseControl.ForeColor = System.Drawing.Color.White;
            this.courseControl.Location = new System.Drawing.Point(41, 184);
            this.courseControl.Name = "courseControl";
            this.courseControl.Size = new System.Drawing.Size(1805, 795);
            this.courseControl.TabIndex = 20;
            // 
            // searchBoxCourses
            // 
            this.searchBoxCourses.Location = new System.Drawing.Point(347, 208);
            this.searchBoxCourses.Name = "searchBoxCourses";
            this.searchBoxCourses.Size = new System.Drawing.Size(1257, 48);
            this.searchBoxCourses.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 42);
            this.label7.TabIndex = 18;
            this.label7.Text = "Search:";
            // 
            // returnButton2
            // 
            this.returnButton2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F);
            this.returnButton2.ForeColor = System.Drawing.Color.Black;
            this.returnButton2.Location = new System.Drawing.Point(1695, 19);
            this.returnButton2.Name = "returnButton2";
            this.returnButton2.Size = new System.Drawing.Size(93, 67);
            this.returnButton2.TabIndex = 13;
            this.returnButton2.Text = "<";
            this.returnButton2.UseVisualStyleBackColor = true;
            // 
            // cancelChangesCourses
            // 
            this.cancelChangesCourses.BackColor = System.Drawing.Color.Crimson;
            this.cancelChangesCourses.Enabled = false;
            this.cancelChangesCourses.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.cancelChangesCourses.ForeColor = System.Drawing.Color.White;
            this.cancelChangesCourses.Location = new System.Drawing.Point(1420, 535);
            this.cancelChangesCourses.Name = "cancelChangesCourses";
            this.cancelChangesCourses.Size = new System.Drawing.Size(270, 59);
            this.cancelChangesCourses.TabIndex = 12;
            this.cancelChangesCourses.Text = "Cancel Changes";
            this.cancelChangesCourses.UseVisualStyleBackColor = false;
            this.cancelChangesCourses.Click += new System.EventHandler(this.cancelChangesCourses_Click);
            // 
            // saveChangesCourses
            // 
            this.saveChangesCourses.BackColor = System.Drawing.Color.DarkGreen;
            this.saveChangesCourses.Enabled = false;
            this.saveChangesCourses.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesCourses.ForeColor = System.Drawing.Color.White;
            this.saveChangesCourses.Location = new System.Drawing.Point(1420, 419);
            this.saveChangesCourses.Name = "saveChangesCourses";
            this.saveChangesCourses.Size = new System.Drawing.Size(270, 59);
            this.saveChangesCourses.TabIndex = 11;
            this.saveChangesCourses.Text = "Save Changes";
            this.saveChangesCourses.UseVisualStyleBackColor = false;
            this.saveChangesCourses.Click += new System.EventHandler(this.saveChangesCourses_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(659, 120);
            this.label9.TabIndex = 7;
            this.label9.Text = "Manage Courses";
            // 
            // courses
            // 
            this.courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseCode,
            this.courseDescription,
            this.units,
            this.scheduleCode,
            this.instructor});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courses.DefaultCellStyle = dataGridViewCellStyle6;
            this.courses.Location = new System.Drawing.Point(319, 315);
            this.courses.Name = "courses";
            this.courses.RowHeadersWidth = 62;
            this.courses.RowTemplate.Height = 28;
            this.courses.Size = new System.Drawing.Size(814, 429);
            this.courses.TabIndex = 17;
            this.courses.Visible = false;
            // 
            // courseCode
            // 
            this.courseCode.HeaderText = "Course Code";
            this.courseCode.MinimumWidth = 8;
            this.courseCode.Name = "courseCode";
            this.courseCode.Width = 150;
            // 
            // courseDescription
            // 
            this.courseDescription.HeaderText = "Course Description";
            this.courseDescription.MinimumWidth = 8;
            this.courseDescription.Name = "courseDescription";
            this.courseDescription.Width = 150;
            // 
            // units
            // 
            this.units.HeaderText = "Units";
            this.units.MinimumWidth = 8;
            this.units.Name = "units";
            this.units.Width = 150;
            // 
            // scheduleCode
            // 
            this.scheduleCode.HeaderText = "Schedule Code";
            this.scheduleCode.MinimumWidth = 8;
            this.scheduleCode.Name = "scheduleCode";
            this.scheduleCode.Width = 150;
            // 
            // instructor
            // 
            this.instructor.HeaderText = "Instructor";
            this.instructor.MinimumWidth = 8;
            this.instructor.Name = "instructor";
            this.instructor.Width = 150;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.courseControl);
            this.Controls.Add(this.userControl);
            this.Name = "adminForm";
            this.Text = "Admin Form";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.userControl.ResumeLayout(false);
            this.userControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfo)).EndInit();
            this.courseControl.ResumeLayout(false);
            this.courseControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label placeholderName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button manageUsers;
        private System.Windows.Forms.Button manageCourses;
        private System.Windows.Forms.Panel userControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelChangesUser;
        private System.Windows.Forms.Button saveChangesUser;
        private System.Windows.Forms.Button returnButton1;
        private System.Windows.Forms.DataGridView studentInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox userRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleStudents;
        private System.Windows.Forms.DataGridView employeeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn isInstructor;
        private System.Windows.Forms.Button changeAdminPasskey;
        private System.Windows.Forms.Button changeInstructorPasskey;
        private System.Windows.Forms.Button switchUser;
        private System.Windows.Forms.TextBox searchBoxUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel courseControl;
        private System.Windows.Forms.TextBox searchBoxCourses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button returnButton2;
        private System.Windows.Forms.Button cancelChangesCourses;
        private System.Windows.Forms.Button saveChangesCourses;
        private System.Windows.Forms.DataGridView courses;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn units;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructor;
    }
}