using Login.model;

namespace Login.view
{
    partial class MainPageOfLibrary
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageOfLibrary));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CloseBt = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            paneluser = new RoundPanel();
            lbname = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            settings = new PictureBox();
            panel1 = new Panel();
            bar = new Panel();
            pictureBox4 = new PictureBox();
            addbt = new PictureBox();
            raport = new PictureBox();
            main = new PictureBox();
            BookPanel = new Panel();
            label3 = new Label();
            label4 = new Label();
            SearchBook = new RoundTextBoxSearch();
            focus = new System.Windows.Forms.Timer(components);
            searchpanel = new Panel();
            mainpage = new Panel();
            addpanel = new Panel();
            daterelease = new DateTimePicker();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            addbook = new RoundButton();
            selectfile = new RoundButton();
            label18 = new Label();
            tagstext = new RoundTextBox();
            authortext = new RoundTextBox();
            isbntext = new RoundTextBox();
            titletext = new RoundTextBox();
            settingpage = new Panel();
            ChangePassword = new RoundButton();
            Changeusrnm = new RoundButton();
            rptnewpass = new RoundTextBox();
            newpassword = new RoundTextBox();
            label10 = new Label();
            passwordusername = new RoundTextBox();
            label8 = new Label();
            label6 = new Label();
            oldpassword = new RoundTextBox();
            label7 = new Label();
            usernametext = new RoundTextBox();
            label5 = new Label();
            label9 = new Label();
            label2 = new Label();
            borrowedbookspanel = new Panel();
            label11 = new Label();
            opener = new FolderBrowserDialog();
            file = new OpenFileDialog();
            raportpanel = new Panel();
            label17 = new Label();
            comboBox1 = new ComboBox();
            datashow = new DataGridView();
            raportlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)CloseBt).BeginInit();
            paneluser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settings).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addbt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)raport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)main).BeginInit();
            mainpage.SuspendLayout();
            addpanel.SuspendLayout();
            settingpage.SuspendLayout();
            raportpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datashow).BeginInit();
            SuspendLayout();
            // 
            // CloseBt
            // 
            CloseBt.Image = (Image)resources.GetObject("CloseBt.Image");
            CloseBt.Location = new Point(19, 486);
            CloseBt.Name = "CloseBt";
            CloseBt.Size = new Size(31, 31);
            CloseBt.SizeMode = PictureBoxSizeMode.Zoom;
            CloseBt.TabIndex = 0;
            CloseBt.TabStop = false;
            CloseBt.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 38);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // paneluser
            // 
            paneluser.BackColor = Color.White;
            paneluser.BorderStyle = BorderStyle.Fixed3D;
            paneluser.Controls.Add(lbname);
            paneluser.Controls.Add(pictureBox2);
            paneluser.ForeColor = SystemColors.ControlText;
            paneluser.Location = new Point(657, 3);
            paneluser.Name = "paneluser";
            paneluser.Padding = new Padding(10, 5, 10, 5);
            paneluser.Size = new Size(162, 37);
            paneluser.TabIndex = 2;
            // 
            // lbname
            // 
            lbname.Location = new Point(44, 8);
            lbname.Name = "lbname";
            lbname.Size = new Size(96, 20);
            lbname.TabIndex = 1;
            lbname.Text = "Error";
            lbname.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Leave_Click;
            // 
            // settings
            // 
            settings.Image = (Image)resources.GetObject("settings.Image");
            settings.Location = new Point(19, 159);
            settings.Name = "settings";
            settings.Size = new Size(31, 31);
            settings.SizeMode = PictureBoxSizeMode.Zoom;
            settings.TabIndex = 0;
            settings.TabStop = false;
            settings.Click += settings_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(bar);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(CloseBt);
            panel1.Controls.Add(addbt);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(raport);
            panel1.Controls.Add(main);
            panel1.Controls.Add(settings);
            panel1.Location = new Point(-7, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(66, 533);
            panel1.TabIndex = 3;
            // 
            // bar
            // 
            bar.BackColor = Color.Black;
            bar.Location = new Point(61, 122);
            bar.Name = "bar";
            bar.Size = new Size(5, 31);
            bar.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 79);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // addbt
            // 
            addbt.Image = (Image)resources.GetObject("addbt.Image");
            addbt.Location = new Point(19, 233);
            addbt.Name = "addbt";
            addbt.Size = new Size(31, 31);
            addbt.SizeMode = PictureBoxSizeMode.Zoom;
            addbt.TabIndex = 0;
            addbt.TabStop = false;
            addbt.Visible = false;
            addbt.Click += addbooks;
            // 
            // raport
            // 
            raport.Image = (Image)resources.GetObject("raport.Image");
            raport.Location = new Point(19, 85);
            raport.Name = "raport";
            raport.Size = new Size(31, 31);
            raport.SizeMode = PictureBoxSizeMode.Zoom;
            raport.TabIndex = 0;
            raport.TabStop = false;
            raport.Click += raport_Click;
            // 
            // main
            // 
            main.Image = (Image)resources.GetObject("main.Image");
            main.Location = new Point(19, 122);
            main.Name = "main";
            main.Size = new Size(31, 31);
            main.SizeMode = PictureBoxSizeMode.Zoom;
            main.TabIndex = 0;
            main.TabStop = false;
            main.Click += main_Click;
            // 
            // BookPanel
            // 
            BookPanel.BackColor = Color.White;
            BookPanel.Location = new Point(7, 109);
            BookPanel.Name = "BookPanel";
            BookPanel.Size = new Size(571, 386);
            BookPanel.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 86);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 0;
            label3.Text = "Recommendation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 8);
            label4.Name = "label4";
            label4.Size = new Size(134, 27);
            label4.TabIndex = 5;
            label4.Text = "Dashboard";
            // 
            // SearchBook
            // 
            SearchBook.BackColor = SystemColors.GradientInactiveCaption;
            SearchBook.BorderStyle = BorderStyle.None;
            SearchBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBook.ForeColor = SystemColors.WindowText;
            SearchBook.Location = new Point(179, 7);
            SearchBook.Name = "SearchBook";
            SearchBook.Size = new Size(253, 27);
            SearchBook.TabIndex = 6;
            SearchBook.Text = "Search Book";
            SearchBook.TextAlign = HorizontalAlignment.Center;
            SearchBook.TextChanged += SearchBook_TextChanged;
            // 
            // focus
            // 
            focus.Tick += timer2_Tick;
            // 
            // searchpanel
            // 
            searchpanel.BackColor = SystemColors.GradientActiveCaption;
            searchpanel.Location = new Point(179, 38);
            searchpanel.Name = "searchpanel";
            searchpanel.Size = new Size(253, 39);
            searchpanel.TabIndex = 7;
            // 
            // mainpage
            // 
            mainpage.Controls.Add(addpanel);
            mainpage.Controls.Add(settingpage);
            mainpage.Controls.Add(borrowedbookspanel);
            mainpage.Controls.Add(label3);
            mainpage.Controls.Add(searchpanel);
            mainpage.Controls.Add(paneluser);
            mainpage.Controls.Add(label1);
            mainpage.Controls.Add(SearchBook);
            mainpage.Controls.Add(BookPanel);
            mainpage.Controls.Add(label11);
            mainpage.Controls.Add(label4);
            mainpage.Location = new Point(87, 12);
            mainpage.Name = "mainpage";
            mainpage.Size = new Size(822, 499);
            mainpage.TabIndex = 8;
            mainpage.MouseMove += lblMoveForm_MouseDown;
            // 
            // addpanel
            // 
            addpanel.Controls.Add(daterelease);
            addpanel.Controls.Add(label16);
            addpanel.Controls.Add(label15);
            addpanel.Controls.Add(label14);
            addpanel.Controls.Add(label13);
            addpanel.Controls.Add(label12);
            addpanel.Controls.Add(addbook);
            addpanel.Controls.Add(selectfile);
            addpanel.Controls.Add(label18);
            addpanel.Controls.Add(tagstext);
            addpanel.Controls.Add(authortext);
            addpanel.Controls.Add(isbntext);
            addpanel.Controls.Add(titletext);
            addpanel.Location = new Point(0, 0);
            addpanel.Name = "addpanel";
            addpanel.Size = new Size(819, 499);
            addpanel.TabIndex = 10;
            addpanel.Visible = false;
            // 
            // daterelease
            // 
            daterelease.Location = new Point(316, 329);
            daterelease.Name = "daterelease";
            daterelease.Size = new Size(200, 27);
            daterelease.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(151, 329);
            label16.Name = "label16";
            label16.Size = new Size(159, 27);
            label16.TabIndex = 9;
            label16.Text = "ReleaseData";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(247, 284);
            label15.Name = "label15";
            label15.Size = new Size(63, 27);
            label15.TabIndex = 9;
            label15.Text = "Tags";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(224, 232);
            label14.Name = "label14";
            label14.Size = new Size(87, 27);
            label14.TabIndex = 9;
            label14.Text = "Author";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(252, 182);
            label13.Name = "label13";
            label13.Size = new Size(59, 27);
            label13.TabIndex = 9;
            label13.Text = "ISBN";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(252, 129);
            label12.Name = "label12";
            label12.Size = new Size(58, 27);
            label12.TabIndex = 9;
            label12.Text = "Title";
            // 
            // addbook
            // 
            addbook.BackColor = Color.White;
            addbook.FlatStyle = FlatStyle.System;
            addbook.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbook.Location = new Point(316, 362);
            addbook.Name = "addbook";
            addbook.Padding = new Padding(10, 5, 10, 5);
            addbook.Size = new Size(200, 47);
            addbook.TabIndex = 8;
            addbook.Text = "Add";
            addbook.UseVisualStyleBackColor = false;
            addbook.Click += addbook_Click;
            // 
            // selectfile
            // 
            selectfile.BackColor = Color.White;
            selectfile.FlatStyle = FlatStyle.System;
            selectfile.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectfile.Location = new Point(316, 68);
            selectfile.Name = "selectfile";
            selectfile.Padding = new Padding(10, 5, 10, 5);
            selectfile.Size = new Size(200, 47);
            selectfile.TabIndex = 8;
            selectfile.Text = "Select";
            selectfile.UseVisualStyleBackColor = false;
            selectfile.Click += selectfile_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(7, 8);
            label18.Name = "label18";
            label18.Size = new Size(121, 27);
            label18.TabIndex = 5;
            label18.Text = "Add Book";
            // 
            // tagstext
            // 
            tagstext.BackColor = Color.White;
            tagstext.BorderStyle = BorderStyle.FixedSingle;
            tagstext.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagstext.ForeColor = SystemColors.ActiveCaptionText;
            tagstext.Location = new Point(316, 276);
            tagstext.Name = "tagstext";
            tagstext.Size = new Size(200, 47);
            tagstext.TabIndex = 6;
            tagstext.TextAlign = HorizontalAlignment.Center;
            // 
            // authortext
            // 
            authortext.BackColor = Color.White;
            authortext.BorderStyle = BorderStyle.FixedSingle;
            authortext.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authortext.ForeColor = SystemColors.ActiveCaptionText;
            authortext.Location = new Point(316, 227);
            authortext.Name = "authortext";
            authortext.Size = new Size(200, 47);
            authortext.TabIndex = 6;
            authortext.TextAlign = HorizontalAlignment.Center;
            // 
            // isbntext
            // 
            isbntext.BackColor = Color.White;
            isbntext.BorderStyle = BorderStyle.FixedSingle;
            isbntext.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isbntext.ForeColor = SystemColors.ActiveCaptionText;
            isbntext.Location = new Point(316, 174);
            isbntext.Name = "isbntext";
            isbntext.Size = new Size(200, 47);
            isbntext.TabIndex = 6;
            isbntext.TextAlign = HorizontalAlignment.Center;
            // 
            // titletext
            // 
            titletext.BackColor = Color.White;
            titletext.BorderStyle = BorderStyle.FixedSingle;
            titletext.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titletext.ForeColor = SystemColors.ActiveCaptionText;
            titletext.Location = new Point(316, 121);
            titletext.Name = "titletext";
            titletext.Size = new Size(200, 47);
            titletext.TabIndex = 6;
            titletext.TextAlign = HorizontalAlignment.Center;
            // 
            // settingpage
            // 
            settingpage.Controls.Add(ChangePassword);
            settingpage.Controls.Add(Changeusrnm);
            settingpage.Controls.Add(rptnewpass);
            settingpage.Controls.Add(newpassword);
            settingpage.Controls.Add(label10);
            settingpage.Controls.Add(passwordusername);
            settingpage.Controls.Add(label8);
            settingpage.Controls.Add(label6);
            settingpage.Controls.Add(oldpassword);
            settingpage.Controls.Add(label7);
            settingpage.Controls.Add(usernametext);
            settingpage.Controls.Add(label5);
            settingpage.Controls.Add(label9);
            settingpage.Controls.Add(label2);
            settingpage.Location = new Point(3, 0);
            settingpage.Name = "settingpage";
            settingpage.Size = new Size(819, 499);
            settingpage.TabIndex = 9;
            settingpage.Visible = false;
            settingpage.MouseMove += lblMoveForm_MouseDown;
            // 
            // ChangePassword
            // 
            ChangePassword.BackColor = Color.White;
            ChangePassword.FlatStyle = FlatStyle.System;
            ChangePassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangePassword.Location = new Point(340, 443);
            ChangePassword.Name = "ChangePassword";
            ChangePassword.Padding = new Padding(10, 5, 10, 5);
            ChangePassword.Size = new Size(200, 47);
            ChangePassword.TabIndex = 7;
            ChangePassword.Text = "Change";
            ChangePassword.UseVisualStyleBackColor = false;
            ChangePassword.Click += ChangePassword_Click;
            // 
            // Changeusrnm
            // 
            Changeusrnm.BackColor = Color.White;
            Changeusrnm.FlatStyle = FlatStyle.System;
            Changeusrnm.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Changeusrnm.Location = new Point(340, 162);
            Changeusrnm.Name = "Changeusrnm";
            Changeusrnm.Padding = new Padding(10, 5, 10, 5);
            Changeusrnm.Size = new Size(200, 47);
            Changeusrnm.TabIndex = 7;
            Changeusrnm.Text = "Change";
            Changeusrnm.UseVisualStyleBackColor = false;
            Changeusrnm.Click += Changeusrnm_Click;
            // 
            // rptnewpass
            // 
            rptnewpass.BackColor = Color.White;
            rptnewpass.BorderStyle = BorderStyle.FixedSingle;
            rptnewpass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rptnewpass.ForeColor = SystemColors.ActiveCaptionText;
            rptnewpass.Location = new Point(340, 390);
            rptnewpass.Name = "rptnewpass";
            rptnewpass.PasswordChar = '*';
            rptnewpass.Size = new Size(200, 47);
            rptnewpass.TabIndex = 6;
            rptnewpass.TextAlign = HorizontalAlignment.Center;
            // 
            // newpassword
            // 
            newpassword.BackColor = Color.White;
            newpassword.BorderStyle = BorderStyle.FixedSingle;
            newpassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newpassword.ForeColor = SystemColors.ActiveCaptionText;
            newpassword.Location = new Point(340, 337);
            newpassword.Name = "newpassword";
            newpassword.PasswordChar = '*';
            newpassword.Size = new Size(200, 47);
            newpassword.TabIndex = 6;
            newpassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(109, 402);
            label10.Name = "label10";
            label10.Size = new Size(208, 27);
            label10.TabIndex = 5;
            label10.Text = "Repeat Password";
            // 
            // passwordusername
            // 
            passwordusername.BackColor = Color.White;
            passwordusername.BorderStyle = BorderStyle.FixedSingle;
            passwordusername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordusername.ForeColor = SystemColors.ActiveCaptionText;
            passwordusername.Location = new Point(340, 109);
            passwordusername.Name = "passwordusername";
            passwordusername.PasswordChar = '*';
            passwordusername.Size = new Size(200, 47);
            passwordusername.TabIndex = 6;
            passwordusername.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(109, 349);
            label8.Name = "label8";
            label8.Size = new Size(176, 27);
            label8.TabIndex = 5;
            label8.Text = "New Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(109, 121);
            label6.Name = "label6";
            label6.Size = new Size(118, 27);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // oldpassword
            // 
            oldpassword.BackColor = Color.White;
            oldpassword.BorderStyle = BorderStyle.FixedSingle;
            oldpassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oldpassword.ForeColor = SystemColors.ActiveCaptionText;
            oldpassword.Location = new Point(340, 284);
            oldpassword.Name = "oldpassword";
            oldpassword.PasswordChar = '*';
            oldpassword.Size = new Size(200, 47);
            oldpassword.TabIndex = 6;
            oldpassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(109, 296);
            label7.Name = "label7";
            label7.Size = new Size(166, 27);
            label7.TabIndex = 5;
            label7.Text = "Old Password";
            // 
            // usernametext
            // 
            usernametext.BackColor = Color.White;
            usernametext.BorderStyle = BorderStyle.FixedSingle;
            usernametext.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametext.ForeColor = SystemColors.ActiveCaptionText;
            usernametext.Location = new Point(340, 56);
            usernametext.Name = "usernametext";
            usernametext.Size = new Size(200, 47);
            usernametext.TabIndex = 6;
            usernametext.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(109, 59);
            label5.Name = "label5";
            label5.Size = new Size(225, 27);
            label5.TabIndex = 5;
            label5.Text = "Change Username";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(268, 232);
            label9.Name = "label9";
            label9.Size = new Size(212, 27);
            label9.TabIndex = 5;
            label9.Text = "Change Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 8);
            label2.Name = "label2";
            label2.Size = new Size(201, 27);
            label2.TabIndex = 5;
            label2.Text = "Account Settings";
            // 
            // borrowedbookspanel
            // 
            borrowedbookspanel.Location = new Point(615, 134);
            borrowedbookspanel.Name = "borrowedbookspanel";
            borrowedbookspanel.Size = new Size(189, 361);
            borrowedbookspanel.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(610, 104);
            label11.Name = "label11";
            label11.Size = new Size(189, 27);
            label11.TabIndex = 5;
            label11.Text = "Borrowed Books";
            // 
            // file
            // 
            file.FileName = "openFileDialog1";
            // 
            // raportpanel
            // 
            raportpanel.Controls.Add(label17);
            raportpanel.Controls.Add(comboBox1);
            raportpanel.Controls.Add(datashow);
            raportpanel.Controls.Add(raportlabel);
            raportpanel.Location = new Point(84, 12);
            raportpanel.Name = "raportpanel";
            raportpanel.Size = new Size(825, 499);
            raportpanel.TabIndex = 11;
            raportpanel.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(609, 10);
            label17.Name = "label17";
            label17.Size = new Size(56, 20);
            label17.TabIndex = 8;
            label17.Text = "Sort By";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Author", "ReleaseDate", "Title" });
            comboBox1.Location = new Point(671, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // datashow
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            datashow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datashow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datashow.BackgroundColor = SystemColors.ButtonFace;
            datashow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            datashow.DefaultCellStyle = dataGridViewCellStyle2;
            datashow.Location = new Point(3, 46);
            datashow.Name = "datashow";
            datashow.ReadOnly = true;
            datashow.RowHeadersVisible = false;
            datashow.RowHeadersWidth = 51;
            datashow.Size = new Size(819, 442);
            datashow.TabIndex = 6;
            // 
            // raportlabel
            // 
            raportlabel.AutoSize = true;
            raportlabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            raportlabel.Location = new Point(7, 8);
            raportlabel.Name = "raportlabel";
            raportlabel.Size = new Size(84, 27);
            raportlabel.TabIndex = 5;
            raportlabel.Text = "Raport";
            // 
            // MainPageOfLibrary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(921, 523);
            Controls.Add(raportpanel);
            Controls.Add(mainpage);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPageOfLibrary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "`";
            MouseMove += lblMoveForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)CloseBt).EndInit();
            paneluser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)settings).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)addbt).EndInit();
            ((System.ComponentModel.ISupportInitialize)raport).EndInit();
            ((System.ComponentModel.ISupportInitialize)main).EndInit();
            mainpage.ResumeLayout(false);
            mainpage.PerformLayout();
            addpanel.ResumeLayout(false);
            addpanel.PerformLayout();
            settingpage.ResumeLayout(false);
            settingpage.PerformLayout();
            raportpanel.ResumeLayout(false);
            raportpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datashow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CloseBt;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label lbname;
        private PictureBox settings;
        private RoundPanel paneluser;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel BookPanel;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label4;
        private RoundTextBoxSearch SearchBook;
        private System.Windows.Forms.Timer focus;
        public Panel searchpanel;
        private PictureBox main;
        private Panel mainpage;
        private Panel settingpage;
        private Panel bar;
        private Label label2;
        private RoundTextBox usernametext;
        private RoundTextBox newpassword;
        private RoundTextBox passwordusername;
        private Label label8;
        private Label label6;
        private RoundTextBox oldpassword;
        private Label label7;
        private Label label5;
        private Label label9;
        private RoundTextBox rptnewpass;
        private Label label10;
        private RoundButton ChangePassword;
        private RoundButton Changeusrnm;
        private Panel borrowedbookspanel;
        private Label label11;
        private PictureBox addbt;
        private Panel addpanel;
        private Label label18;
        private RoundButton selectfile;
        private RoundTextBox titletext;
        private Label label12;
        private Label label13;
        private RoundTextBox isbntext;
        private DateTimePicker daterelease;
        private Label label16;
        private Label label15;
        private Label label14;
        private RoundButton addbook;
        private RoundTextBox tagstext;
        private RoundTextBox authortext;
        private FolderBrowserDialog opener;
        private OpenFileDialog file;
        private PictureBox raport;
        private Panel raportpanel;
        private Label raportlabel;
        private DataGridView datashow;
        private ComboBox comboBox1;
        private Label label17;
    }
}