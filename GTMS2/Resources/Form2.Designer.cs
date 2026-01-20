namespace GTMS2.Resources
{
    partial class instructorForm
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.switchUser = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yearLevelPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.year1Student = new System.Windows.Forms.Button();
            this.year2Student = new System.Windows.Forms.Button();
            this.year3Student = new System.Windows.Forms.Button();
            this.year4Student = new System.Windows.Forms.Button();
            this.semesterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.semester1Student = new System.Windows.Forms.Button();
            this.semester2Student = new System.Windows.Forms.Button();
            this.returntoYear = new System.Windows.Forms.Button();
            this.periodPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.midtermsStudent = new System.Windows.Forms.Button();
            this.finalsStudent = new System.Windows.Forms.Button();
            this.returntoSemester = new System.Windows.Forms.Button();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.welcomeUpload = new System.Windows.Forms.Button();
            this.viewGrades = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.placeholderName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nonVerifiedGradesPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.searchBoxNonverified = new System.Windows.Forms.TextBox();
            this.cancelChangesNonverified = new System.Windows.Forms.Button();
            this.saveChangesNonverified = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.nonVerifiedPerformance = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonverifiedGrades = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadaswell = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.verifiedGradesPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.searchboxVerified = new System.Windows.Forms.TextBox();
            this.returnButton2 = new System.Windows.Forms.Button();
            this.cancelChangesVerified = new System.Windows.Forms.Button();
            this.saveChangesVerified = new System.Windows.Forms.Button();
            this.verifyButton = new System.Windows.Forms.Button();
            this.verifiedPerformance = new System.Windows.Forms.DataGridView();
            this.breakdownVerified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoringVerified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verifiedGrades = new System.Windows.Forms.DataGridView();
            this.subjectcodeVerified = new System.Windows.Forms.DataGridViewButtonColumn();
            this.subjectdescriptionVerified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentVerified = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gradeVerified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsVerified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.yearLevelPanel.SuspendLayout();
            this.semesterPanel.SuspendLayout();
            this.periodPanel.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.nonVerifiedGradesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nonVerifiedPerformance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonverifiedGrades)).BeginInit();
            this.verifiedGradesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verifiedPerformance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verifiedGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.LimeGreen;
            this.titlePanel.Controls.Add(this.switchUser);
            this.titlePanel.Controls.Add(this.logout);
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Controls.Add(this.panel1);
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1903, 136);
            this.titlePanel.TabIndex = 1;
            // 
            // switchUser
            // 
            this.switchUser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.switchUser.Font = new System.Drawing.Font("Franklin Gothic Demi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchUser.ForeColor = System.Drawing.Color.White;
            this.switchUser.Location = new System.Drawing.Point(1514, 28);
            this.switchUser.Name = "switchUser";
            this.switchUser.Size = new System.Drawing.Size(183, 76);
            this.switchUser.TabIndex = 4;
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
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(933, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grade Transparency and Management System";
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
            // yearLevelPanel
            // 
            this.yearLevelPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearLevelPanel.BackColor = System.Drawing.Color.Indigo;
            this.yearLevelPanel.Controls.Add(this.label2);
            this.yearLevelPanel.Controls.Add(this.year1Student);
            this.yearLevelPanel.Controls.Add(this.year2Student);
            this.yearLevelPanel.Controls.Add(this.year3Student);
            this.yearLevelPanel.Controls.Add(this.year4Student);
            this.yearLevelPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.yearLevelPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.yearLevelPanel.Location = new System.Drawing.Point(52, 202);
            this.yearLevelPanel.Margin = new System.Windows.Forms.Padding(10);
            this.yearLevelPanel.Name = "yearLevelPanel";
            this.yearLevelPanel.Padding = new System.Windows.Forms.Padding(10);
            this.yearLevelPanel.Size = new System.Drawing.Size(335, 769);
            this.yearLevelPanel.TabIndex = 10;
            this.yearLevelPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(18, 20, 0, 0);
            this.label2.Size = new System.Drawing.Size(309, 71);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select year level";
            // 
            // year1Student
            // 
            this.year1Student.BackColor = System.Drawing.Color.LimeGreen;
            this.year1Student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.year1Student.Font = new System.Drawing.Font("Franklin Gothic Demi", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year1Student.ForeColor = System.Drawing.Color.White;
            this.year1Student.Location = new System.Drawing.Point(65, 136);
            this.year1Student.Margin = new System.Windows.Forms.Padding(55, 55, 3, 3);
            this.year1Student.Name = "year1Student";
            this.year1Student.Size = new System.Drawing.Size(205, 73);
            this.year1Student.TabIndex = 0;
            this.year1Student.Text = "1st Year";
            this.year1Student.UseVisualStyleBackColor = false;
            this.year1Student.Click += new System.EventHandler(this.year1Student_Click);
            // 
            // year2Student
            // 
            this.year2Student.BackColor = System.Drawing.Color.LimeGreen;
            this.year2Student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.year2Student.Font = new System.Drawing.Font("Franklin Gothic Demi", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year2Student.ForeColor = System.Drawing.Color.White;
            this.year2Student.Location = new System.Drawing.Point(65, 267);
            this.year2Student.Margin = new System.Windows.Forms.Padding(55, 55, 3, 3);
            this.year2Student.Name = "year2Student";
            this.year2Student.Size = new System.Drawing.Size(205, 73);
            this.year2Student.TabIndex = 1;
            this.year2Student.Text = "2nd Year";
            this.year2Student.UseVisualStyleBackColor = false;
            this.year2Student.Click += new System.EventHandler(this.year2Student_Click);
            // 
            // year3Student
            // 
            this.year3Student.BackColor = System.Drawing.Color.LimeGreen;
            this.year3Student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.year3Student.Font = new System.Drawing.Font("Franklin Gothic Demi", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year3Student.ForeColor = System.Drawing.Color.White;
            this.year3Student.Location = new System.Drawing.Point(65, 398);
            this.year3Student.Margin = new System.Windows.Forms.Padding(55, 55, 3, 3);
            this.year3Student.Name = "year3Student";
            this.year3Student.Size = new System.Drawing.Size(205, 73);
            this.year3Student.TabIndex = 2;
            this.year3Student.Text = "3rd Year";
            this.year3Student.UseVisualStyleBackColor = false;
            this.year3Student.Click += new System.EventHandler(this.year3Student_Click);
            // 
            // year4Student
            // 
            this.year4Student.BackColor = System.Drawing.Color.LimeGreen;
            this.year4Student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.year4Student.Font = new System.Drawing.Font("Franklin Gothic Demi", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year4Student.ForeColor = System.Drawing.Color.White;
            this.year4Student.Location = new System.Drawing.Point(65, 529);
            this.year4Student.Margin = new System.Windows.Forms.Padding(55, 55, 3, 3);
            this.year4Student.Name = "year4Student";
            this.year4Student.Size = new System.Drawing.Size(205, 73);
            this.year4Student.TabIndex = 3;
            this.year4Student.Text = "4th Year";
            this.year4Student.UseVisualStyleBackColor = false;
            this.year4Student.Click += new System.EventHandler(this.year4Student_Click);
            // 
            // semesterPanel
            // 
            this.semesterPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.semesterPanel.BackColor = System.Drawing.Color.Indigo;
            this.semesterPanel.Controls.Add(this.label3);
            this.semesterPanel.Controls.Add(this.semester1Student);
            this.semesterPanel.Controls.Add(this.semester2Student);
            this.semesterPanel.Controls.Add(this.returntoYear);
            this.semesterPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.semesterPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.semesterPanel.Location = new System.Drawing.Point(52, 202);
            this.semesterPanel.Margin = new System.Windows.Forms.Padding(10);
            this.semesterPanel.Name = "semesterPanel";
            this.semesterPanel.Padding = new System.Windows.Forms.Padding(10, 50, 10, 10);
            this.semesterPanel.Size = new System.Drawing.Size(335, 769);
            this.semesterPanel.TabIndex = 11;
            this.semesterPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(18, 20, 0, 0);
            this.label3.Size = new System.Drawing.Size(200, 122);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Semester";
            // 
            // semester1Student
            // 
            this.semester1Student.BackColor = System.Drawing.Color.LimeGreen;
            this.semester1Student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.semester1Student.Font = new System.Drawing.Font("Franklin Gothic Demi", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester1Student.ForeColor = System.Drawing.Color.White;
            this.semester1Student.Location = new System.Drawing.Point(65, 227);
            this.semester1Student.Margin = new System.Windows.Forms.Padding(55, 55, 3, 3);
            this.semester1Student.Name = "semester1Student";
            this.semester1Student.Size = new System.Drawing.Size(215, 130);
            this.semester1Student.TabIndex = 0;
            this.semester1Student.Text = "1st Semester";
            this.semester1Student.UseVisualStyleBackColor = false;
            this.semester1Student.Click += new System.EventHandler(this.semester1Student_Click);
            // 
            // semester2Student
            // 
            this.semester2Student.BackColor = System.Drawing.Color.LimeGreen;
            this.semester2Student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.semester2Student.Font = new System.Drawing.Font("Franklin Gothic Demi", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester2Student.ForeColor = System.Drawing.Color.White;
            this.semester2Student.Location = new System.Drawing.Point(65, 415);
            this.semester2Student.Margin = new System.Windows.Forms.Padding(55, 55, 3, 3);
            this.semester2Student.Name = "semester2Student";
            this.semester2Student.Size = new System.Drawing.Size(215, 130);
            this.semester2Student.TabIndex = 1;
            this.semester2Student.Text = "2nd Semester";
            this.semester2Student.UseVisualStyleBackColor = false;
            this.semester2Student.Click += new System.EventHandler(this.semester2Student_Click);
            // 
            // returntoYear
            // 
            this.returntoYear.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returntoYear.Location = new System.Drawing.Point(132, 598);
            this.returntoYear.Margin = new System.Windows.Forms.Padding(122, 50, 3, 3);
            this.returntoYear.Name = "returntoYear";
            this.returntoYear.Size = new System.Drawing.Size(82, 28);
            this.returntoYear.TabIndex = 7;
            this.returntoYear.Text = "<- Back";
            this.returntoYear.UseVisualStyleBackColor = true;
            this.returntoYear.Click += new System.EventHandler(this.returntoYear_Click);
            // 
            // periodPanel
            // 
            this.periodPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.periodPanel.BackColor = System.Drawing.Color.Indigo;
            this.periodPanel.Controls.Add(this.label4);
            this.periodPanel.Controls.Add(this.midtermsStudent);
            this.periodPanel.Controls.Add(this.finalsStudent);
            this.periodPanel.Controls.Add(this.returntoSemester);
            this.periodPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.periodPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.periodPanel.Location = new System.Drawing.Point(52, 202);
            this.periodPanel.Margin = new System.Windows.Forms.Padding(10);
            this.periodPanel.Name = "periodPanel";
            this.periodPanel.Padding = new System.Windows.Forms.Padding(10, 50, 10, 10);
            this.periodPanel.Size = new System.Drawing.Size(335, 769);
            this.periodPanel.TabIndex = 12;
            this.periodPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(35, 20, 0, 0);
            this.label4.Size = new System.Drawing.Size(279, 71);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Period";
            // 
            // midtermsStudent
            // 
            this.midtermsStudent.BackColor = System.Drawing.Color.LimeGreen;
            this.midtermsStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.midtermsStudent.Font = new System.Drawing.Font("Franklin Gothic Demi", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtermsStudent.ForeColor = System.Drawing.Color.White;
            this.midtermsStudent.Location = new System.Drawing.Point(65, 176);
            this.midtermsStudent.Margin = new System.Windows.Forms.Padding(55, 55, 3, 3);
            this.midtermsStudent.Name = "midtermsStudent";
            this.midtermsStudent.Size = new System.Drawing.Size(215, 84);
            this.midtermsStudent.TabIndex = 0;
            this.midtermsStudent.Text = "Midterms";
            this.midtermsStudent.UseVisualStyleBackColor = false;
            this.midtermsStudent.Click += new System.EventHandler(this.midtermsStudent_Click);
            // 
            // finalsStudent
            // 
            this.finalsStudent.BackColor = System.Drawing.Color.LimeGreen;
            this.finalsStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finalsStudent.Font = new System.Drawing.Font("Franklin Gothic Demi", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalsStudent.ForeColor = System.Drawing.Color.White;
            this.finalsStudent.Location = new System.Drawing.Point(65, 318);
            this.finalsStudent.Margin = new System.Windows.Forms.Padding(55, 55, 3, 3);
            this.finalsStudent.Name = "finalsStudent";
            this.finalsStudent.Size = new System.Drawing.Size(215, 84);
            this.finalsStudent.TabIndex = 1;
            this.finalsStudent.Text = "Finals";
            this.finalsStudent.UseVisualStyleBackColor = false;
            this.finalsStudent.Click += new System.EventHandler(this.finalsStudent_Click);
            // 
            // returntoSemester
            // 
            this.returntoSemester.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8F);
            this.returntoSemester.Location = new System.Drawing.Point(132, 455);
            this.returntoSemester.Margin = new System.Windows.Forms.Padding(122, 50, 3, 3);
            this.returntoSemester.Name = "returntoSemester";
            this.returntoSemester.Size = new System.Drawing.Size(82, 28);
            this.returntoSemester.TabIndex = 5;
            this.returntoSemester.Text = "<- Back";
            this.returntoSemester.UseVisualStyleBackColor = true;
            this.returntoSemester.Click += new System.EventHandler(this.returntoSemester_Click);
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.Indigo;
            this.welcomePanel.Controls.Add(this.welcomeUpload);
            this.welcomePanel.Controls.Add(this.viewGrades);
            this.welcomePanel.Controls.Add(this.label6);
            this.welcomePanel.Controls.Add(this.placeholderName);
            this.welcomePanel.Controls.Add(this.label5);
            this.welcomePanel.ForeColor = System.Drawing.Color.White;
            this.welcomePanel.Location = new System.Drawing.Point(452, 200);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(1393, 769);
            this.welcomePanel.TabIndex = 13;
            // 
            // welcomeUpload
            // 
            this.welcomeUpload.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F);
            this.welcomeUpload.ForeColor = System.Drawing.Color.Black;
            this.welcomeUpload.Location = new System.Drawing.Point(734, 502);
            this.welcomeUpload.Name = "welcomeUpload";
            this.welcomeUpload.Size = new System.Drawing.Size(302, 73);
            this.welcomeUpload.TabIndex = 6;
            this.welcomeUpload.Text = "Upload";
            this.welcomeUpload.UseVisualStyleBackColor = true;
            this.welcomeUpload.Click += new System.EventHandler(this.welcomeUpload_Click);
            // 
            // viewGrades
            // 
            this.viewGrades.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F);
            this.viewGrades.ForeColor = System.Drawing.Color.Black;
            this.viewGrades.Location = new System.Drawing.Point(391, 502);
            this.viewGrades.Name = "viewGrades";
            this.viewGrades.Size = new System.Drawing.Size(302, 73);
            this.viewGrades.TabIndex = 5;
            this.viewGrades.Text = "View";
            this.viewGrades.UseVisualStyleBackColor = true;
            this.viewGrades.Click += new System.EventHandler(this.viewGrades_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F);
            this.label6.Location = new System.Drawing.Point(191, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(421, 65);
            this.label6.TabIndex = 4;
            this.label6.Text = "Upload grades now!";
            // 
            // placeholderName
            // 
            this.placeholderName.AutoSize = true;
            this.placeholderName.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderName.ForeColor = System.Drawing.Color.White;
            this.placeholderName.Location = new System.Drawing.Point(186, 208);
            this.placeholderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.placeholderName.Name = "placeholderName";
            this.placeholderName.Size = new System.Drawing.Size(362, 182);
            this.placeholderName.TabIndex = 3;
            this.placeholderName.Text = "placeholder\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 144);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(221, 65);
            this.label5.TabIndex = 0;
            this.label5.Text = "Welcome,";
            // 
            // nonVerifiedGradesPanel
            // 
            this.nonVerifiedGradesPanel.BackColor = System.Drawing.Color.Indigo;
            this.nonVerifiedGradesPanel.Controls.Add(this.label9);
            this.nonVerifiedGradesPanel.Controls.Add(this.searchBoxNonverified);
            this.nonVerifiedGradesPanel.Controls.Add(this.cancelChangesNonverified);
            this.nonVerifiedGradesPanel.Controls.Add(this.saveChangesNonverified);
            this.nonVerifiedGradesPanel.Controls.Add(this.returnButton);
            this.nonVerifiedGradesPanel.Controls.Add(this.nonVerifiedPerformance);
            this.nonVerifiedGradesPanel.Controls.Add(this.nonverifiedGrades);
            this.nonVerifiedGradesPanel.Controls.Add(this.uploadaswell);
            this.nonVerifiedGradesPanel.Controls.Add(this.label7);
            this.nonVerifiedGradesPanel.ForeColor = System.Drawing.Color.White;
            this.nonVerifiedGradesPanel.Location = new System.Drawing.Point(449, 200);
            this.nonVerifiedGradesPanel.Name = "nonVerifiedGradesPanel";
            this.nonVerifiedGradesPanel.Size = new System.Drawing.Size(1393, 769);
            this.nonVerifiedGradesPanel.TabIndex = 15;
            this.nonVerifiedGradesPanel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.label9.Location = new System.Drawing.Point(60, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 42);
            this.label9.TabIndex = 16;
            this.label9.Text = "Search student:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // searchBoxNonverified
            // 
            this.searchBoxNonverified.Location = new System.Drawing.Point(301, 184);
            this.searchBoxNonverified.Name = "searchBoxNonverified";
            this.searchBoxNonverified.Size = new System.Drawing.Size(764, 26);
            this.searchBoxNonverified.TabIndex = 15;
            this.searchBoxNonverified.TextChanged += new System.EventHandler(this.searchBoxNonverified_TextChanged);
            // 
            // cancelChangesNonverified
            // 
            this.cancelChangesNonverified.BackColor = System.Drawing.Color.Crimson;
            this.cancelChangesNonverified.Enabled = false;
            this.cancelChangesNonverified.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.cancelChangesNonverified.ForeColor = System.Drawing.Color.White;
            this.cancelChangesNonverified.Location = new System.Drawing.Point(1103, 416);
            this.cancelChangesNonverified.Name = "cancelChangesNonverified";
            this.cancelChangesNonverified.Size = new System.Drawing.Size(270, 59);
            this.cancelChangesNonverified.TabIndex = 14;
            this.cancelChangesNonverified.Text = "Cancel Changes";
            this.cancelChangesNonverified.UseVisualStyleBackColor = false;
            this.cancelChangesNonverified.Click += new System.EventHandler(this.cancelChangesNonverified_Click);
            // 
            // saveChangesNonverified
            // 
            this.saveChangesNonverified.BackColor = System.Drawing.Color.DarkGreen;
            this.saveChangesNonverified.Enabled = false;
            this.saveChangesNonverified.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesNonverified.ForeColor = System.Drawing.Color.White;
            this.saveChangesNonverified.Location = new System.Drawing.Point(1103, 300);
            this.saveChangesNonverified.Name = "saveChangesNonverified";
            this.saveChangesNonverified.Size = new System.Drawing.Size(270, 59);
            this.saveChangesNonverified.TabIndex = 13;
            this.saveChangesNonverified.Text = "Save Changes";
            this.saveChangesNonverified.UseVisualStyleBackColor = false;
            this.saveChangesNonverified.Click += new System.EventHandler(this.saveChangesNonverified_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F);
            this.returnButton.ForeColor = System.Drawing.Color.Black;
            this.returnButton.Location = new System.Drawing.Point(1297, 12);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(93, 67);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "<";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // nonVerifiedPerformance
            // 
            this.nonVerifiedPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nonVerifiedPerformance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.nonVerifiedPerformance.Location = new System.Drawing.Point(702, 229);
            this.nonVerifiedPerformance.Name = "nonVerifiedPerformance";
            this.nonVerifiedPerformance.RowHeadersWidth = 62;
            this.nonVerifiedPerformance.RowTemplate.Height = 28;
            this.nonVerifiedPerformance.Size = new System.Drawing.Size(363, 426);
            this.nonVerifiedPerformance.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Breakdown";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Marks";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // nonverifiedGrades
            // 
            this.nonverifiedGrades.AllowUserToOrderColumns = true;
            this.nonverifiedGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nonverifiedGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.nonverifiedGrades.Location = new System.Drawing.Point(67, 229);
            this.nonverifiedGrades.Name = "nonverifiedGrades";
            this.nonverifiedGrades.RowHeadersWidth = 62;
            this.nonverifiedGrades.RowTemplate.Height = 28;
            this.nonverifiedGrades.Size = new System.Drawing.Size(611, 426);
            this.nonverifiedGrades.TabIndex = 8;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Subject Code";
            this.dataGridViewButtonColumn1.MinimumWidth = 8;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Subject Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Student Number";
            this.dataGridViewButtonColumn2.MinimumWidth = 8;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Units";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // uploadaswell
            // 
            this.uploadaswell.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F);
            this.uploadaswell.ForeColor = System.Drawing.Color.Black;
            this.uploadaswell.Location = new System.Drawing.Point(514, 669);
            this.uploadaswell.Name = "uploadaswell";
            this.uploadaswell.Size = new System.Drawing.Size(302, 73);
            this.uploadaswell.TabIndex = 7;
            this.uploadaswell.Text = "Upload";
            this.uploadaswell.UseVisualStyleBackColor = true;
            this.uploadaswell.Click += new System.EventHandler(this.uploadaswell_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(45, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(583, 91);
            this.label7.TabIndex = 3;
            this.label7.Text = "Non-Verified Grades";
            // 
            // verifiedGradesPanel
            // 
            this.verifiedGradesPanel.BackColor = System.Drawing.Color.Indigo;
            this.verifiedGradesPanel.Controls.Add(this.label10);
            this.verifiedGradesPanel.Controls.Add(this.searchboxVerified);
            this.verifiedGradesPanel.Controls.Add(this.returnButton2);
            this.verifiedGradesPanel.Controls.Add(this.cancelChangesVerified);
            this.verifiedGradesPanel.Controls.Add(this.saveChangesVerified);
            this.verifiedGradesPanel.Controls.Add(this.verifyButton);
            this.verifiedGradesPanel.Controls.Add(this.verifiedPerformance);
            this.verifiedGradesPanel.Controls.Add(this.verifiedGrades);
            this.verifiedGradesPanel.Controls.Add(this.label8);
            this.verifiedGradesPanel.ForeColor = System.Drawing.Color.White;
            this.verifiedGradesPanel.Location = new System.Drawing.Point(455, 200);
            this.verifiedGradesPanel.Name = "verifiedGradesPanel";
            this.verifiedGradesPanel.Size = new System.Drawing.Size(1393, 769);
            this.verifiedGradesPanel.TabIndex = 14;
            this.verifiedGradesPanel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.label10.Location = new System.Drawing.Point(54, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 42);
            this.label10.TabIndex = 18;
            this.label10.Text = "Search student:";
            // 
            // searchboxVerified
            // 
            this.searchboxVerified.Location = new System.Drawing.Point(295, 183);
            this.searchboxVerified.Name = "searchboxVerified";
            this.searchboxVerified.Size = new System.Drawing.Size(764, 26);
            this.searchboxVerified.TabIndex = 17;
            this.searchboxVerified.TextChanged += new System.EventHandler(this.searchboxVerified_TextChanged);
            // 
            // returnButton2
            // 
            this.returnButton2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F);
            this.returnButton2.ForeColor = System.Drawing.Color.Black;
            this.returnButton2.Location = new System.Drawing.Point(1291, 12);
            this.returnButton2.Name = "returnButton2";
            this.returnButton2.Size = new System.Drawing.Size(93, 67);
            this.returnButton2.TabIndex = 11;
            this.returnButton2.Text = "<";
            this.returnButton2.UseVisualStyleBackColor = true;
            // 
            // cancelChangesVerified
            // 
            this.cancelChangesVerified.BackColor = System.Drawing.Color.Crimson;
            this.cancelChangesVerified.Enabled = false;
            this.cancelChangesVerified.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.cancelChangesVerified.ForeColor = System.Drawing.Color.White;
            this.cancelChangesVerified.Location = new System.Drawing.Point(1097, 416);
            this.cancelChangesVerified.Name = "cancelChangesVerified";
            this.cancelChangesVerified.Size = new System.Drawing.Size(270, 59);
            this.cancelChangesVerified.TabIndex = 10;
            this.cancelChangesVerified.Text = "Cancel Changes";
            this.cancelChangesVerified.UseVisualStyleBackColor = false;
            this.cancelChangesVerified.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveChangesVerified
            // 
            this.saveChangesVerified.BackColor = System.Drawing.Color.DarkGreen;
            this.saveChangesVerified.Enabled = false;
            this.saveChangesVerified.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesVerified.ForeColor = System.Drawing.Color.White;
            this.saveChangesVerified.Location = new System.Drawing.Point(1097, 300);
            this.saveChangesVerified.Name = "saveChangesVerified";
            this.saveChangesVerified.Size = new System.Drawing.Size(270, 59);
            this.saveChangesVerified.TabIndex = 9;
            this.saveChangesVerified.Text = "Save Changes";
            this.saveChangesVerified.UseVisualStyleBackColor = false;
            this.saveChangesVerified.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // verifyButton
            // 
            this.verifyButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26F);
            this.verifyButton.ForeColor = System.Drawing.Color.Black;
            this.verifyButton.Location = new System.Drawing.Point(508, 669);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(302, 73);
            this.verifyButton.TabIndex = 8;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // verifiedPerformance
            // 
            this.verifiedPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verifiedPerformance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.breakdownVerified,
            this.scoringVerified});
            this.verifiedPerformance.Location = new System.Drawing.Point(696, 229);
            this.verifiedPerformance.Name = "verifiedPerformance";
            this.verifiedPerformance.RowHeadersWidth = 62;
            this.verifiedPerformance.RowTemplate.Height = 28;
            this.verifiedPerformance.Size = new System.Drawing.Size(363, 403);
            this.verifiedPerformance.TabIndex = 5;
            // 
            // breakdownVerified
            // 
            this.breakdownVerified.HeaderText = "Breakdown";
            this.breakdownVerified.MinimumWidth = 8;
            this.breakdownVerified.Name = "breakdownVerified";
            this.breakdownVerified.ReadOnly = true;
            this.breakdownVerified.Width = 150;
            // 
            // scoringVerified
            // 
            this.scoringVerified.HeaderText = "Marks";
            this.scoringVerified.MinimumWidth = 8;
            this.scoringVerified.Name = "scoringVerified";
            this.scoringVerified.Width = 150;
            // 
            // verifiedGrades
            // 
            this.verifiedGrades.AllowUserToOrderColumns = true;
            this.verifiedGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verifiedGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectcodeVerified,
            this.subjectdescriptionVerified,
            this.studentVerified,
            this.gradeVerified,
            this.unitsVerified});
            this.verifiedGrades.Location = new System.Drawing.Point(60, 229);
            this.verifiedGrades.Name = "verifiedGrades";
            this.verifiedGrades.RowHeadersWidth = 62;
            this.verifiedGrades.RowTemplate.Height = 28;
            this.verifiedGrades.Size = new System.Drawing.Size(611, 403);
            this.verifiedGrades.TabIndex = 4;
            // 
            // subjectcodeVerified
            // 
            this.subjectcodeVerified.HeaderText = "Subject Code";
            this.subjectcodeVerified.MinimumWidth = 8;
            this.subjectcodeVerified.Name = "subjectcodeVerified";
            this.subjectcodeVerified.Width = 150;
            // 
            // subjectdescriptionVerified
            // 
            this.subjectdescriptionVerified.HeaderText = "Subject Description";
            this.subjectdescriptionVerified.MinimumWidth = 8;
            this.subjectdescriptionVerified.Name = "subjectdescriptionVerified";
            this.subjectdescriptionVerified.Width = 150;
            // 
            // studentVerified
            // 
            this.studentVerified.HeaderText = "Student Number";
            this.studentVerified.MinimumWidth = 8;
            this.studentVerified.Name = "studentVerified";
            this.studentVerified.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studentVerified.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.studentVerified.Width = 150;
            // 
            // gradeVerified
            // 
            this.gradeVerified.HeaderText = "Grade";
            this.gradeVerified.MinimumWidth = 8;
            this.gradeVerified.Name = "gradeVerified";
            this.gradeVerified.Width = 150;
            // 
            // unitsVerified
            // 
            this.unitsVerified.HeaderText = "Units";
            this.unitsVerified.MinimumWidth = 8;
            this.unitsVerified.Name = "unitsVerified";
            this.unitsVerified.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(398, 91);
            this.label8.TabIndex = 3;
            this.label8.Text = "Verify Grades";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // instructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.yearLevelPanel);
            this.Controls.Add(this.semesterPanel);
            this.Controls.Add(this.periodPanel);
            this.Controls.Add(this.verifiedGradesPanel);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.nonVerifiedGradesPanel);
            this.Name = "instructorForm";
            this.Text = "Employee Form";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.yearLevelPanel.ResumeLayout(false);
            this.yearLevelPanel.PerformLayout();
            this.semesterPanel.ResumeLayout(false);
            this.semesterPanel.PerformLayout();
            this.periodPanel.ResumeLayout(false);
            this.periodPanel.PerformLayout();
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.nonVerifiedGradesPanel.ResumeLayout(false);
            this.nonVerifiedGradesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nonVerifiedPerformance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonverifiedGrades)).EndInit();
            this.verifiedGradesPanel.ResumeLayout(false);
            this.verifiedGradesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verifiedPerformance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verifiedGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel yearLevelPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button year1Student;
        private System.Windows.Forms.Button year2Student;
        private System.Windows.Forms.Button year3Student;
        private System.Windows.Forms.Button year4Student;
        private System.Windows.Forms.FlowLayoutPanel semesterPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button semester1Student;
        private System.Windows.Forms.Button semester2Student;
        private System.Windows.Forms.Button returntoYear;
        private System.Windows.Forms.FlowLayoutPanel periodPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button midtermsStudent;
        private System.Windows.Forms.Button finalsStudent;
        private System.Windows.Forms.Button returntoSemester;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Button welcomeUpload;
        private System.Windows.Forms.Button viewGrades;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label placeholderName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel nonVerifiedGradesPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel verifiedGradesPanel;
        private System.Windows.Forms.DataGridView verifiedPerformance;
        private System.Windows.Forms.DataGridView verifiedGrades;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button uploadaswell;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.DataGridViewButtonColumn subjectcodeVerified;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectdescriptionVerified;
        private System.Windows.Forms.DataGridViewButtonColumn studentVerified;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeVerified;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsVerified;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakdownVerified;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoringVerified;
        private System.Windows.Forms.Button saveChangesVerified;
        private System.Windows.Forms.Button cancelChangesVerified;
        private System.Windows.Forms.DataGridView nonVerifiedPerformance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView nonverifiedGrades;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button returnButton2;
        private System.Windows.Forms.Button switchUser;
        private System.Windows.Forms.Button cancelChangesNonverified;
        private System.Windows.Forms.Button saveChangesNonverified;
        private System.Windows.Forms.TextBox searchBoxNonverified;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searchboxVerified;
    }
}