using Login.model;

namespace Login.view
{
    partial class BookCoverPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCoverPage));
            CloseBt = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            BookPanel = new Panel();
            removebt = new Button();
            returnbt = new Button();
            btborrow = new Button();
            lbtags = new Label();
            lbstatus = new Label();
            lbauthor = new Label();
            lbreleasedt = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label3 = new Label();
            lbisbn = new Label();
            label2 = new Label();
            Coverbook = new PictureBox();
            bookname = new Label();
            ((System.ComponentModel.ISupportInitialize)CloseBt).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            BookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Coverbook).BeginInit();
            SuspendLayout();
            // 
            // CloseBt
            // 
            CloseBt.Image = (Image)resources.GetObject("CloseBt.Image");
            CloseBt.Location = new Point(19, 340);
            CloseBt.Name = "CloseBt";
            CloseBt.Size = new Size(38, 37);
            CloseBt.SizeMode = PictureBoxSizeMode.Zoom;
            CloseBt.TabIndex = 0;
            CloseBt.TabStop = false;
            CloseBt.Click += CloseBt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 52);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(CloseBt);
            panel1.Location = new Point(-7, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(75, 533);
            panel1.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(75, 79);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // BookPanel
            // 
            BookPanel.BackColor = Color.White;
            BookPanel.Controls.Add(removebt);
            BookPanel.Controls.Add(returnbt);
            BookPanel.Controls.Add(btborrow);
            BookPanel.Controls.Add(lbtags);
            BookPanel.Controls.Add(lbstatus);
            BookPanel.Controls.Add(lbauthor);
            BookPanel.Controls.Add(lbreleasedt);
            BookPanel.Controls.Add(label5);
            BookPanel.Controls.Add(label4);
            BookPanel.Controls.Add(label7);
            BookPanel.Controls.Add(label3);
            BookPanel.Controls.Add(lbisbn);
            BookPanel.Controls.Add(label2);
            BookPanel.Controls.Add(Coverbook);
            BookPanel.Location = new Point(86, 75);
            BookPanel.Name = "BookPanel";
            BookPanel.Size = new Size(405, 296);
            BookPanel.TabIndex = 4;
            // 
            // removebt
            // 
            removebt.BackColor = Color.WhiteSmoke;
            removebt.FlatStyle = FlatStyle.Flat;
            removebt.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removebt.ForeColor = SystemColors.ActiveCaptionText;
            removebt.Location = new Point(187, 259);
            removebt.Name = "removebt";
            removebt.Size = new Size(94, 29);
            removebt.TabIndex = 9;
            removebt.Text = "Remove";
            removebt.UseVisualStyleBackColor = false;
            removebt.Visible = false;
            removebt.Click += removebt_click;
            // 
            // returnbt
            // 
            returnbt.BackColor = Color.WhiteSmoke;
            returnbt.FlatStyle = FlatStyle.Flat;
            returnbt.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnbt.ForeColor = SystemColors.ActiveCaptionText;
            returnbt.Location = new Point(287, 259);
            returnbt.Name = "returnbt";
            returnbt.Size = new Size(94, 29);
            returnbt.TabIndex = 9;
            returnbt.Text = "Return";
            returnbt.UseVisualStyleBackColor = false;
            returnbt.Visible = false;
            returnbt.Click += returnbt_Click;
            // 
            // btborrow
            // 
            btborrow.BackColor = Color.WhiteSmoke;
            btborrow.FlatStyle = FlatStyle.Flat;
            btborrow.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btborrow.ForeColor = SystemColors.ActiveCaptionText;
            btborrow.Location = new Point(287, 259);
            btborrow.Name = "btborrow";
            btborrow.Size = new Size(94, 29);
            btborrow.TabIndex = 8;
            btborrow.Text = "Borrow";
            btborrow.UseVisualStyleBackColor = false;
            btborrow.Click += btborrow_Click;
            // 
            // lbtags
            // 
            lbtags.AutoSize = true;
            lbtags.Location = new Point(192, 110);
            lbtags.Name = "lbtags";
            lbtags.Size = new Size(89, 20);
            lbtags.TabIndex = 7;
            lbtags.Text = "1293810293";
            // 
            // lbstatus
            // 
            lbstatus.AutoSize = true;
            lbstatus.Location = new Point(249, 142);
            lbstatus.Name = "lbstatus";
            lbstatus.Size = new Size(89, 20);
            lbstatus.TabIndex = 7;
            lbstatus.Text = "1293810293";
            // 
            // lbauthor
            // 
            lbauthor.AutoSize = true;
            lbauthor.Location = new Point(75, 212);
            lbauthor.Name = "lbauthor";
            lbauthor.Size = new Size(89, 20);
            lbauthor.TabIndex = 7;
            lbauthor.Text = "1293810293";
            // 
            // lbreleasedt
            // 
            lbreleasedt.AutoSize = true;
            lbreleasedt.Location = new Point(249, 79);
            lbreleasedt.Name = "lbreleasedt";
            lbreleasedt.Size = new Size(89, 20);
            lbreleasedt.TabIndex = 7;
            lbreleasedt.Text = "1293810293";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(143, 110);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 6;
            label5.Text = "Tags:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(143, 142);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 212);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 6;
            label7.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(143, 79);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 6;
            label3.Text = "Release Date:";
            // 
            // lbisbn
            // 
            lbisbn.AutoSize = true;
            lbisbn.Location = new Point(249, 46);
            lbisbn.Name = "lbisbn";
            lbisbn.Size = new Size(89, 20);
            lbisbn.TabIndex = 7;
            lbisbn.Text = "1293810293";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 46);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "ISBN:";
            // 
            // Coverbook
            // 
            Coverbook.Location = new Point(12, 15);
            Coverbook.Name = "Coverbook";
            Coverbook.Size = new Size(125, 178);
            Coverbook.SizeMode = PictureBoxSizeMode.StretchImage;
            Coverbook.TabIndex = 0;
            Coverbook.TabStop = false;
            // 
            // bookname
            // 
            bookname.AutoSize = true;
            bookname.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookname.Location = new Point(86, 22);
            bookname.Name = "bookname";
            bookname.Size = new Size(137, 27);
            bookname.TabIndex = 5;
            bookname.Text = "BookName";
            // 
            // BookCoverPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(526, 383);
            Controls.Add(bookname);
            Controls.Add(BookPanel);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookCoverPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "`";
            ((System.ComponentModel.ISupportInitialize)CloseBt).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            BookPanel.ResumeLayout(false);
            BookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Coverbook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CloseBt;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Panel panel1;
        private Panel BookPanel;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer focus;
        private PictureBox Coverbook;
        private Label lbreleasedt;
        private Label label3;
        private Label lbisbn;
        private Label label2;
        private Label bookname;
        private Label lbtags;
        private Label lbauthor;
        private Label label5;
        private Label label7;
        private Label lbstatus;
        private Label label4;
        private Button btborrow;
        private Button returnbt;
        private Button removebt;
    }
}