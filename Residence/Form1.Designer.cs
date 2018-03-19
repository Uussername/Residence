namespace Residence
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.loginLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.UseLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.loginEnter = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.LogIn = new System.Windows.Forms.TabPage();
            this.loginError = new System.Windows.Forms.Label();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.NewTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.success = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RoomNum = new System.Windows.Forms.Label();
            this.Floor = new System.Windows.Forms.Label();
            this.ResidentType = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.newTitle = new System.Windows.Forms.Label();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.SRoom = new System.Windows.Forms.Label();
            this.SFloor = new System.Windows.Forms.Label();
            this.SResType = new System.Windows.Forms.Label();
            this.SStudID = new System.Windows.Forms.Label();
            this.SLname = new System.Windows.Forms.Label();
            this.SFname = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Tabs.SuspendLayout();
            this.LogIn.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.NewTab.SuspendLayout();
            this.SearchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(315, 171);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(96, 38);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(335, 225);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(170, 30);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(335, 263);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(170, 30);
            this.password.TabIndex = 2;
            // 
            // UseLabel
            // 
            this.UseLabel.AutoSize = true;
            this.UseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseLabel.Location = new System.Drawing.Point(214, 230);
            this.UseLabel.Name = "UseLabel";
            this.UseLabel.Size = new System.Drawing.Size(102, 25);
            this.UseLabel.TabIndex = 3;
            this.UseLabel.Text = "Username";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(214, 263);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(98, 25);
            this.PassLabel.TabIndex = 4;
            this.PassLabel.Text = "Password";
            // 
            // loginEnter
            // 
            this.loginEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEnter.Location = new System.Drawing.Point(335, 299);
            this.loginEnter.Name = "loginEnter";
            this.loginEnter.Size = new System.Drawing.Size(77, 32);
            this.loginEnter.TabIndex = 5;
            this.loginEnter.Text = "Enter";
            this.loginEnter.UseVisualStyleBackColor = true;
            this.loginEnter.Click += new System.EventHandler(this.loginEnter_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.LogIn);
            this.Tabs.Controls.Add(this.HomeTab);
            this.Tabs.Controls.Add(this.NewTab);
            this.Tabs.Controls.Add(this.SearchTab);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(786, 556);
            this.Tabs.TabIndex = 6;
            // 
            // LogIn
            // 
            this.LogIn.Controls.Add(this.loginError);
            this.LogIn.Controls.Add(this.loginLabel);
            this.LogIn.Controls.Add(this.username);
            this.LogIn.Controls.Add(this.loginEnter);
            this.LogIn.Controls.Add(this.password);
            this.LogIn.Controls.Add(this.PassLabel);
            this.LogIn.Controls.Add(this.UseLabel);
            this.LogIn.Location = new System.Drawing.Point(4, 25);
            this.LogIn.Name = "LogIn";
            this.LogIn.Padding = new System.Windows.Forms.Padding(3);
            this.LogIn.Size = new System.Drawing.Size(778, 527);
            this.LogIn.TabIndex = 3;
            this.LogIn.Text = "Login";
            this.LogIn.UseVisualStyleBackColor = true;
            // 
            // loginError
            // 
            this.loginError.AutoSize = true;
            this.loginError.ForeColor = System.Drawing.Color.Red;
            this.loginError.Location = new System.Drawing.Point(418, 299);
            this.loginError.Name = "loginError";
            this.loginError.Size = new System.Drawing.Size(166, 34);
            this.loginError.TabIndex = 7;
            this.loginError.Text = "Please provide a valid \r\nUsername and Password";
            this.loginError.Visible = false;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.button2);
            this.HomeTab.Controls.Add(this.button1);
            this.HomeTab.Controls.Add(this.logout);
            this.HomeTab.Location = new System.Drawing.Point(4, 25);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(778, 527);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search for a Resident";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create a New Resident";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(651, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(121, 40);
            this.logout.TabIndex = 0;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // NewTab
            // 
            this.NewTab.Controls.Add(this.button3);
            this.NewTab.Controls.Add(this.success);
            this.NewTab.Controls.Add(this.submit);
            this.NewTab.Controls.Add(this.comboBox3);
            this.NewTab.Controls.Add(this.comboBox2);
            this.NewTab.Controls.Add(this.comboBox1);
            this.NewTab.Controls.Add(this.textBox3);
            this.NewTab.Controls.Add(this.textBox2);
            this.NewTab.Controls.Add(this.textBox1);
            this.NewTab.Controls.Add(this.RoomNum);
            this.NewTab.Controls.Add(this.Floor);
            this.NewTab.Controls.Add(this.ResidentType);
            this.NewTab.Controls.Add(this.Lname);
            this.NewTab.Controls.Add(this.StudentID);
            this.NewTab.Controls.Add(this.Fname);
            this.NewTab.Controls.Add(this.newTitle);
            this.NewTab.Location = new System.Drawing.Point(4, 25);
            this.NewTab.Name = "NewTab";
            this.NewTab.Padding = new System.Windows.Forms.Padding(3);
            this.NewTab.Size = new System.Drawing.Size(778, 527);
            this.NewTab.TabIndex = 1;
            this.NewTab.Text = "New Resident";
            this.NewTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 40);
            this.button3.TabIndex = 16;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.Location = new System.Drawing.Point(247, 455);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(212, 32);
            this.success.TabIndex = 15;
            this.success.Text = "Student Added!";
            this.success.Visible = false;
            this.success.MouseClick += new System.Windows.Forms.MouseEventHandler(this.success_MouseClick);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(62, 446);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(179, 48);
            this.submit.TabIndex = 14;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(169, 371);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 33);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Student Worker",
            "Athlete",
            "Scholarship"});
            this.comboBox2.Location = new System.Drawing.Point(169, 275);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 33);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.DropDownClosed += new System.EventHandler(this.comboBox2_DropDownClosed);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 326);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(135, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 30);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(135, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 30);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(135, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 30);
            this.textBox1.TabIndex = 8;
            // 
            // RoomNum
            // 
            this.RoomNum.AutoSize = true;
            this.RoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNum.Location = new System.Drawing.Point(8, 374);
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.Size = new System.Drawing.Size(137, 25);
            this.RoomNum.TabIndex = 7;
            this.RoomNum.Text = "Room Number";
            // 
            // Floor
            // 
            this.Floor.AutoSize = true;
            this.Floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Floor.Location = new System.Drawing.Point(8, 322);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(56, 25);
            this.Floor.TabIndex = 6;
            this.Floor.Text = "Floor";
            // 
            // ResidentType
            // 
            this.ResidentType.AutoSize = true;
            this.ResidentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentType.Location = new System.Drawing.Point(7, 276);
            this.ResidentType.Name = "ResidentType";
            this.ResidentType.Size = new System.Drawing.Size(138, 25);
            this.ResidentType.TabIndex = 5;
            this.ResidentType.Text = "Resident Type";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(8, 140);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(106, 25);
            this.Lname.TabIndex = 4;
            this.Lname.Text = "Last Name";
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.Location = new System.Drawing.Point(8, 192);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(104, 25);
            this.StudentID.TabIndex = 3;
            this.StudentID.Text = "Student ID";
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(8, 94);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(106, 25);
            this.Fname.TabIndex = 2;
            this.Fname.Text = "First Name";
            // 
            // newTitle
            // 
            this.newTitle.AutoSize = true;
            this.newTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTitle.Location = new System.Drawing.Point(6, 3);
            this.newTitle.Name = "newTitle";
            this.newTitle.Size = new System.Drawing.Size(320, 36);
            this.newTitle.TabIndex = 0;
            this.newTitle.Text = "Create a New Resident";
            // 
            // SearchTab
            // 
            this.SearchTab.Controls.Add(this.label9);
            this.SearchTab.Controls.Add(this.SRoom);
            this.SearchTab.Controls.Add(this.SFloor);
            this.SearchTab.Controls.Add(this.SResType);
            this.SearchTab.Controls.Add(this.SStudID);
            this.SearchTab.Controls.Add(this.SLname);
            this.SearchTab.Controls.Add(this.SFname);
            this.SearchTab.Controls.Add(this.button5);
            this.SearchTab.Controls.Add(this.comboBox4);
            this.SearchTab.Controls.Add(this.label8);
            this.SearchTab.Controls.Add(this.button4);
            this.SearchTab.Controls.Add(this.textBox6);
            this.SearchTab.Controls.Add(this.label2);
            this.SearchTab.Controls.Add(this.label3);
            this.SearchTab.Controls.Add(this.label4);
            this.SearchTab.Controls.Add(this.label5);
            this.SearchTab.Controls.Add(this.label6);
            this.SearchTab.Controls.Add(this.label7);
            this.SearchTab.Controls.Add(this.label1);
            this.SearchTab.Location = new System.Drawing.Point(4, 25);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTab.Size = new System.Drawing.Size(778, 527);
            this.SearchTab.TabIndex = 2;
            this.SearchTab.Text = "Search Resident";
            this.SearchTab.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(107, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "No Resident Found";
            this.label9.Visible = false;
            // 
            // SRoom
            // 
            this.SRoom.AutoSize = true;
            this.SRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRoom.Location = new System.Drawing.Point(290, 452);
            this.SRoom.Name = "SRoom";
            this.SRoom.Size = new System.Drawing.Size(0, 25);
            this.SRoom.TabIndex = 26;
            // 
            // SFloor
            // 
            this.SFloor.AutoSize = true;
            this.SFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFloor.Location = new System.Drawing.Point(290, 400);
            this.SFloor.Name = "SFloor";
            this.SFloor.Size = new System.Drawing.Size(0, 25);
            this.SFloor.TabIndex = 25;
            // 
            // SResType
            // 
            this.SResType.AutoSize = true;
            this.SResType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SResType.Location = new System.Drawing.Point(290, 354);
            this.SResType.Name = "SResType";
            this.SResType.Size = new System.Drawing.Size(0, 25);
            this.SResType.TabIndex = 24;
            // 
            // SStudID
            // 
            this.SStudID.AutoSize = true;
            this.SStudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SStudID.Location = new System.Drawing.Point(290, 310);
            this.SStudID.Name = "SStudID";
            this.SStudID.Size = new System.Drawing.Size(0, 25);
            this.SStudID.TabIndex = 23;
            // 
            // SLname
            // 
            this.SLname.AutoSize = true;
            this.SLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLname.Location = new System.Drawing.Point(290, 258);
            this.SLname.Name = "SLname";
            this.SLname.Size = new System.Drawing.Size(0, 25);
            this.SLname.TabIndex = 22;
            // 
            // SFname
            // 
            this.SFname.AutoSize = true;
            this.SFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFname.Location = new System.Drawing.Point(290, 212);
            this.SFname.Name = "SFname";
            this.SFname.Size = new System.Drawing.Size(0, 25);
            this.SFname.TabIndex = 21;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(479, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 35);
            this.button5.TabIndex = 20;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Student ID"});
            this.comboBox4.Location = new System.Drawing.Point(112, 78);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(148, 33);
            this.comboBox4.TabIndex = 19;
            this.comboBox4.DropDownClosed += new System.EventHandler(this.comboBox4_DropDownClosed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Search by";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(651, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 40);
            this.button4.TabIndex = 17;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(266, 78);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(191, 30);
            this.textBox6.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Floor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Resident Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Student ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search for a Resident";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Residence.Form1);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(Residence.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Residence Hall";
            this.Tabs.ResumeLayout(false);
            this.LogIn.ResumeLayout(false);
            this.LogIn.PerformLayout();
            this.HomeTab.ResumeLayout(false);
            this.NewTab.ResumeLayout(false);
            this.NewTab.PerformLayout();
            this.SearchTab.ResumeLayout(false);
            this.SearchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label UseLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button loginEnter;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage NewTab;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage SearchTab;
        private System.Windows.Forms.Label loginError;
        private System.Windows.Forms.TabPage LogIn;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label newTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RoomNum;
        private System.Windows.Forms.Label Floor;
        private System.Windows.Forms.Label ResidentType;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label SRoom;
        private System.Windows.Forms.Label SFloor;
        private System.Windows.Forms.Label SResType;
        private System.Windows.Forms.Label SStudID;
        private System.Windows.Forms.Label SLname;
        private System.Windows.Forms.Label SFname;
        private System.Windows.Forms.Label label9;
    }
}

