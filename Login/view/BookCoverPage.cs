using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Login.view
{
    public partial class BookCoverPage : Form
    {
        int id;
        private readonly MainPageOfLibrary page;
        private readonly string Book = "Books/";
        const string ConnectionString = "Data Source=Users.db";
        int iduser = 0;
        public BookCoverPage(int id, MainPageOfLibrary page)
        {
            InitializeComponent();
            this.id = id;
            this.DoubleBuffered = true;
            this.page = page;
            Read();
            if(iduser==page._login.id||iduser==0)status();
            else
            {
                btborrow.Enabled = false;
            }
            if (page.admin == true) removebt.Visible = true;
        }
        private void status()
        {
            if (lbstatus.Text != "Available")
            {
                btborrow.Visible = false;
                returnbt.Visible = true;
            }
            else
            {
                btborrow.Visible = true;
                returnbt.Visible = false;
            }
        }
        string covername;
        private void Read()
        {
            string sqlcommand = $"SELECT * FROM Books Where Id={id}";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand(sqlcommand, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Image image;
                        using (Stream stream = File.OpenRead($"{Book}{reader.GetString(7)}"))
                        {
                            image = System.Drawing.Image.FromStream(stream);
                        }
                        bookname.Text = reader.GetString(1);
                        lbisbn.Text = reader.GetString(2);
                        lbauthor.Text = reader.GetString(3);
                        lbtags.Text = reader.GetString(4);
                        lbreleasedt.Text = reader.GetString(5);
                        lbstatus.Text = reader.GetString(6);
                        covername=reader.GetString(7);
                        Coverbook.Image = image;
                        iduser=reader.GetInt32(8);
                    }
                }
            }
        }

        private void CloseBt_Click(object sender, EventArgs e)
        {
            this.Close();
            page.borrowedBooks();
            page.Visible = true;

        }

        private void btborrow_Click(object sender, EventArgs e)
        {
            if (page.nrofborrowedbooks() < 5)
            {
                string sqlcommand = $"UPDATE Books SET Status='Taken', IdUser={page._login.id} WHERE Id={id}";
                using (SqliteConnection conn = new SqliteConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new SqliteCommand(sqlcommand, conn);
                    command.ExecuteNonQuery();
                }
                lbstatus.Text = "Taken";
            }
            else MessageBox.Show("You can only borrow 5 books");
            btborrow.Visible = false;
            returnbt.Visible = true;
        }

        private void returnbt_Click(object sender, EventArgs e)
        {
            string sqlcommand = $"UPDATE Books SET Status='Available', IdUser=0 WHERE Id={id}";
            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var command = new SqliteCommand(sqlcommand, conn);
                command.ExecuteNonQuery();
            }
            lbstatus.Text = "Available";
            btborrow.Visible = true;
            returnbt.Visible = false;
        }
        private void removebt_click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure u want to delete this book?", "U sure?",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                page.Visible=false;
                Coverbook.Image.Dispose();
                this.Close();
                File.Delete($"{Book}{covername}");
                string sqlcommand = $"DELETE FROM Books WHERE id={id}";
                using (SqliteConnection conn = new SqliteConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new SqliteCommand(sqlcommand, conn);
                    command.ExecuteNonQuery();
                }
                page.borrowedBooks();
                page.Visible = true;
                page.deletedbook(id, $"{Book}{covername}");
                MessageBox.Show("Book deleted");
            }
        }
    }
}
