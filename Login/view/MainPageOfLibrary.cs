using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Login.model;
using Microsoft.EntityFrameworkCore;

namespace Login.view
{
    public partial class MainPageOfLibrary : Form
    {
        const string ConnectionString = "Data Source=Users.db";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public loginform _login;
        struct BookCover
        {
            public PictureBox Book;
            public Label Title;
        };
        BookCover[] coverpanel;
        BookCover[] coverarray = new BookCover[8];
        const string BookStringLocation = "Books/";
        public bool admin = false;
        public MainPageOfLibrary(loginform login)
        {
            InitializeComponent();
            _login = login;
            this.DoubleBuffered = true;
            reader();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            CreateBookPicture();
            GenerateImage();
            SearchBook.Enter += TextBox_Enter;
            SearchBook.Leave += TextBox_Leave;
            borrowedBooks();
            if (lbname.Text == "Ako") { addbt.Visible = true; admin = true; }
            focus.Start();
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (SearchBook.Text == "Search Book")
            {
                SearchBook.Text = string.Empty; // Clear placeholder text
                SearchBook.ForeColor = System.Drawing.Color.Black; // Set text color to default
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBook.Text))
            {
                SearchBook.Text = "Search Book"; // Restore placeholder text with spaces
                SearchBook.ForeColor = System.Drawing.SystemColors.GrayText; // Set text color to gray
            }
        }
        private void lblMoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                this.Capture = false; //select control

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
        private void CreateBookPicture()
        {
            for (int i = 0; i < 4; i++)
            {
                coverarray[i].Title = new Label();
                coverarray[i].Book = new PictureBox();
                coverarray[i].Book.Location = new Point(i * 150 + 22, 22);
                coverarray[i].Book.Size = new Size(81, 125);
                coverarray[i].Title.Location = new Point(i * 150 + 22, 150);
            }
            for (int i = 4; i < 8; i++)
            {
                coverarray[i].Title = new Label();
                coverarray[i].Book = new PictureBox();
                coverarray[i].Book.Location = new Point((i - 4) * 150 + 22, 209);
                coverarray[i].Book.Size = new Size(81, 125);
                coverarray[i].Title.Location = new Point((i - 4) * 150 + 22, 337);
            }
        }
        private void reader()
        {
            string sqlcommand = $"SELECT Username FROM Users WHERE Id={_login.id}";
            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var command = new SqliteCommand(sqlcommand, conn);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lbname.Text = reader.GetString(0);
                    }
                }
            }
        }
        private int CountBooks()
        {
            string sqlcommand = "SELECT count(ID) from Books";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand(sqlcommand, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }
            return 0;
        }
        private string GetBookLocation(int id)
        {
            string sqlcommand = $"SELECT ROW_NUMBER() OVER (ORDER BY Id) AS IdNormal,Id As IdUnic,Photo FROM Books WHERE IdUnic={id}";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand(sqlcommand, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetString(2);
                    }
                }
            }
            return null;
        }
        private string GetBookTitle(int id)
        {
            string sqlcommand = $"SELECT Title FROM Books WHERE id={id}";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand(sqlcommand, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }
            }
            return null;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            _login.Close();
        }
        //book add
        private void addbooks(object sender, EventArgs e)
        {
            raportpanel.Visible = false;
            settingpage.Visible = false;
            addpanel.Visible = true;
            bar.Location = new Point(61, addbt.Location.Y);

        }
        //for admin
        private void Leave_Click(object sender, EventArgs e)
        {
            File.Delete("rem.in");
            _login.Visible = true;
            this.Close();
        }
        struct Cover
        {
            public int id;
            public string location;
        };
        Cover[] covers = new Cover[8];
        private void GenerateImage()
        {
            List<int> temp = new List<int>();
            Random random = new Random();
            while (true)
            {
                bool adevar = true;
                int numar = random.Next(1, CountBooks());
                foreach (int var in temp)
                {
                    if (numar == var) { adevar = false; }
                }
                if (adevar)
                {
                    temp.Add(numar);
                }
                if (temp.Count == 8) break;
            }
            for (int i = 0; i < temp.Count; i++)
            {
                covers[i].id = temp[i];
                covers[i].location = GetBookLocation(temp[i]);
            }
            for (int i = 0; i < 8; i++)
            {
                coverarray[i].Book.Name = $"{i}";
                coverarray[i].Title.Name = $"{i}";
                Image image;
                using (Stream stream = File.OpenRead($"{BookStringLocation}{covers[i].location}"))
                {
                    image = System.Drawing.Image.FromStream(stream);
                }
                coverarray[i].Book.Image = image;
                coverarray[i].Title.Text = GetBookTitle(covers[i].id);
                coverarray[i].Book.Parent = BookPanel;
                coverarray[i].Title.Parent = BookPanel;
                coverarray[i].Book.MouseHover += MouseHover;
                coverarray[i].Book.MouseLeave += MouseLeave;
                coverarray[i].Title.MouseHover += MouseHover;
                coverarray[i].Title.MouseLeave += MouseLeave;
                coverarray[i].Book.Click += CoverClick;
                coverarray[i].Book.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public void deletedbook(int id, string path)
        {
            for (int i = 0; i < 8; i++) if (covers[i].id == id) coverarray[i].Book.Dispose();
            foreach (var item in coverpanel)
            {
                if (item.Book.Name == Convert.ToString(id)) item.Book.Dispose();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.Delete(path);
        }
        private void CoverClick(object sender, EventArgs e)
        {
            var nr = (PictureBox)sender;
            BookCoverPage book = new BookCoverPage(Convert.ToInt32(covers[Convert.ToInt32(nr.Name)].id), this);
            this.Visible = false;

            book.ShowDialog();
        }
        private void PanelClick(object sender, EventArgs e)
        {
            int id = 0;
            if (sender is PictureBox)
            {
                var nr = (PictureBox)sender;
                id = Convert.ToInt32(nr.Parent.Name);
            }
            if (sender is Panel)
            {
                var nr = (Panel)sender;
                id = Convert.ToInt32(nr.Name);
            }
            if (sender is Label)
            {
                var nr = (Label)sender;
                id = Convert.ToInt32(nr.Parent.Name);
            }
            BookCoverPage idk = new BookCoverPage(id, this);
            this.Visible = false;
            idk.ShowDialog();
        }
        private void MouseHover(object sender, EventArgs e)
        {
            int id = 0;
            if (sender is Label label)
            {
                id = Convert.ToInt32(label.Name);
            }
            else if (sender is PictureBox picture)
            {
                id = Convert.ToInt32(picture.Name);
            }
            coverarray[id].Title.Size = new Size(coverarray[id].Title.Width, 50);
        }
        private void MouseLeave(object sender, EventArgs e)
        {
            int id = 0;
            if (sender is Label label)
            {
                id = Convert.ToInt32(label.Name);
            }
            else if (sender is PictureBox picture)
            {
                id = Convert.ToInt32(picture.Name);
            }
            coverarray[id].Title.Size = new Size(coverarray[id].Title.Width, 20);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            focus.Stop();
            this.ActiveControl = null;
        }

        private void SearchBook_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            if (SearchBook.Text != "Search Book" && SearchBook.Text != "" && SearchBook.Text != string.Empty)
            {
                //SELECT count(id) FROM Books WHERE title LIKE '%%';
                string sqlcommand = $"SELECT count(id) FROM Books WHERE title LIKE '%{SearchBook.Text}%' or tags like '%{SearchBook.Text}%' or Author like '%{SearchBook.Text}%'";
                using (SqliteConnection connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    var command = new SqliteCommand(sqlcommand, connection);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            count = reader.GetInt32(0);
                        }
                    }
                }
                searchpanel.Controls.Clear();
                if (count > 5) count = 5;
                Panel[] linkpanel = new Panel[count];
                coverpanel = new BookCover[count];
                searchpanel.Size = new Size(searchpanel.Width, count * 40);
                string sqlcommandtemp = $"SELECT * FROM Books WHERE title LIKE '%{SearchBook.Text}%' or tags like '%{SearchBook.Text}%' or Author like '%{SearchBook.Text}%'";
                using (SqliteConnection connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    var command = new SqliteCommand(sqlcommandtemp, connection);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        for (int i = 0; i < count; i++)
                        {
                            reader.Read();
                            linkpanel[i] = new Panel
                            {
                                Size = new Size(247, 33),
                                Location = new Point(3, (i * 38) + 3),
                                Name = reader.GetString(0),
                                Parent = searchpanel
                            };
                            linkpanel[i].Click += PanelClick;
                            Image image;
                            using (Stream stream = File.OpenRead($"{BookStringLocation}{reader.GetString(7)}"))
                            {
                                image = System.Drawing.Image.FromStream(stream);
                            }
                            coverpanel[i] = new BookCover
                            {
                                Book = new PictureBox
                                {
                                    Name = reader.GetString(0),
                                    Location = new Point(0, 0),
                                    Size = new Size(24, 33),
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    Image = image,
                                    Parent = linkpanel[i],
                                },
                                Title = new Label
                                {
                                    Text = reader.GetString(1),
                                    Location = new Point(30, 7),
                                    Size = new Size(220, 25),
                                    Parent = linkpanel[i]
                                }
                            };
                            coverpanel[i].Book.Click += PanelClick;
                            coverpanel[i].Title.Click += PanelClick;
                        }
                    }
                }
                searchpanel.Visible = true;
            }
            else
            {
                searchpanel.Controls.Clear();
                searchpanel.Visible = false;
            }
        }

        private void main_Click(object sender, EventArgs e)
        {
            addpanel.Visible = false;
            settingpage.Visible = false;
            raportpanel.Visible = false;
            bar.Location = new Point(61, main.Location.Y);
        }
        private void raport_Click(object sender, EventArgs e)
        {
            addpanel.Visible = false;
            settingpage.Visible = false;
            raportpanel.Visible = true;
            bar.Location = new Point(61, raport.Location.Y);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            addpanel.Visible = false;
            settingpage.Visible = true;
            raportpanel.Visible = false;
            bar.Location = new Point(61, settings.Location.Y);
        }

        private bool CheckPassword(string hash)
        {
            string sqlcommand = $"SELECT hashpswd from Users where Username='{lbname.Text}' ";
            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var command = new SqliteCommand(sqlcommand, conn);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == hash) return true;
                    }
                }
            }
            return false;
        }
        //username change
        private void Changeusrnm_Click(object sender, EventArgs e)
        {
            if (passwordusername.Text != string.Empty)
            {
                loginform login = new loginform();
                if (CheckPassword(login.QuickHash(passwordusername.Text)))
                {
                    Register tmp = new Register();
                    List<string> list = new List<string>();
                    list = tmp.readusername();
                    tmp.Close();
                    bool check = false;
                    foreach (var item in list)
                    {
                        if (item == usernametext.Text) check = true;
                    }
                    if (check)
                    {
                        MessageBox.Show("Username Already Taken, Try Another One");
                    }
                    else
                    {
                        //UPDATE Persons SET name = '{}' WHERE name = '{}';
                        string sqlcommand = $"UPDATE Users SET username = '{usernametext.Text}' WHERE username = '{lbname.Text}'";
                        using (SqliteConnection conn = new SqliteConnection(ConnectionString))
                        {
                            conn.Open();
                            var command = new SqliteCommand(sqlcommand, conn);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Username Changed");
                        lbname.Text = usernametext.Text;
                    }
                }
                else MessageBox.Show("Incorect Password");
                login.Close();
            }
            else MessageBox.Show("Insert the password");
        }
        //password change
        private void ChangePassword_Click(object sender, EventArgs e)
        {
            if (oldpassword.Text != string.Empty && newpassword.Text != string.Empty && rptnewpass.Text != string.Empty)
            {
                loginform login = new loginform();
                if (CheckPassword(login.QuickHash(oldpassword.Text)))
                {
                    if (newpassword.Text == rptnewpass.Text)
                    {
                        if (newpassword.Text.Length >= 6)
                        {
                            string sqlcommand = $"UPDATE Users SET hashpswd = '{login.QuickHash(newpassword.Text)}' WHERE username = '{lbname.Text}'";
                            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
                            {
                                conn.Open();
                                var command = new SqliteCommand(sqlcommand, conn);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Password Changed");
                        }
                        else MessageBox.Show("The password needs to be at least 6 characters long");
                    }
                    else MessageBox.Show("The new password doesn't match");
                }
                else MessageBox.Show("Incorect old Password");
                login.Close();
            }
            else MessageBox.Show("Dont leave blank boxes");
        }

        //Boroweed Books
        public int nrofborrowedbooks()
        {
            //SELECT count(Users.Username) FROM Users JOIN Books ON Users.Id = Books.IdUser WHERE Books.IdUser = {_login.id};
            string sqlcommand = $"SELECT count(Books.ID) FROM Users JOIN Books ON Users.Id = Books.IdUser WHERE Books.IdUser = {_login.id}";
            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var command = new SqliteCommand(sqlcommand, conn);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }
            return 0;
        }
        public void borrowedBooks()
        {
            borrowedbookspanel.Controls.Clear();
            int books = nrofborrowedbooks();
            BookCover[] borrowedbooks = new BookCover[books];
            Panel[] idk = new Panel[books];
            //SELECT Books.ID,Books.Title,Books.Photo FROM Users JOIN Books ON Users.Id = Books.IdUser WHERE Books.IdUser = 9;
            string sqlcommand = $"SELECT Books.ID,Books.Title,Books.Photo FROM Users JOIN Books ON Users.Id = Books.IdUser WHERE Books.IdUser = {_login.id};";
            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var command = new SqliteCommand(sqlcommand, conn);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    for (int i = 0; i < books; i++)
                    {
                        reader.Read();
                        idk[i] = new Panel
                        {
                            Size = new Size(181, 61),
                            Location = new Point(3, (i * 64) + 3),
                            Parent = borrowedbookspanel,
                            Name = reader.GetString(0)
                        };
                        idk[i].Click += PanelClick;
                        borrowedbooks[i] = new BookCover
                        {
                            Book = new PictureBox
                            {
                                Image = Image.FromFile($"{BookStringLocation}{reader.GetString(2)}"),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Size = new Size(38, 55),
                                Location = new Point(3, 3),
                                Parent = idk[i]
                            },
                            Title = new Label
                            {
                                Text = reader.GetString(1),
                                Size = new Size(140, 25),
                                Location = new Point(47, 21),
                                Parent = idk[i]
                            },

                        };
                        borrowedbooks[i].Book.Click += PanelClick;
                        borrowedbooks[i].Title.Click += PanelClick;
                    }
                }
            }
        }
        string path, name;
        private void selectfile_Click(object sender, EventArgs e)
        {
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = Path.GetFullPath(file.FileName);
                name = Path.GetFileName(file.FileName);
            }
            else MessageBox.Show("Select the cover photo for the book");
        }
        private bool verify()
        {
            string sqlcommand = $"SELECT Title FROM Books WHERE Title='{titletext.Text}'";
            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var command = new SqliteCommand(sqlcommand, conn);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == titletext.Text) return true;
                    }
                }
            }
            return false;
        }
        private void addbook_Click(object sender, EventArgs e)
        {
            if (path == string.Empty)
            {
                MessageBox.Show("Select the photo for the cover");
            }
            else if (titletext.Text == string.Empty || isbntext.Text == string.Empty || authortext.Text == string.Empty || tagstext.Text == string.Empty)
            {
                MessageBox.Show("Dont leave blank inputs");
            }
            else if (verify() == false)
            {

                string sqlcommand = $"INSERT INTO Books (Title,ISBN,Author,Tags,ReleaseDate,Status,Photo,IdUser) VALUES ('{titletext.Text}','{isbntext.Text}','{authortext.Text}','{tagstext.Text}','{daterelease.Value.Date.ToString("yyyy-MM-dd")}','Available','{name}','0')";
                using (SqliteConnection conn = new SqliteConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new SqliteCommand(sqlcommand, conn);
                    command.ExecuteNonQuery();
                }
                string startupPath = Environment.CurrentDirectory;
                File.Copy(path, $"{startupPath}\\Books\\{name}");
                MessageBox.Show("Book added");
            }
            else
            {
                MessageBox.Show("This book already exists");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Author")
            {
                datashow.Controls.Clear();
                using (var books = new BookContext())
                {
                    var bookshw = books.books.FromSql($"SELECT * FROM Books ORDER by Author").ToList();
                    datashow.DataSource = bookshw;
                }
                datashow.Columns[0].Visible = false;
            }
            else if (comboBox1.Text == "ReleaseDate")
            {
                datashow.Controls.Clear();
                using (var books = new BookContext())
                {
                    var bookshw = books.books.FromSql($"SELECT * FROM Books ORDER by ReleaseDate").ToList();
                    datashow.DataSource = bookshw;
                }
                datashow.Columns[0].Visible = false;
            }
            else if(comboBox1.Text == "Title")
            {
                datashow.Controls.Clear();
                using (var books = new BookContext())
                {
                    var bookshw = books.books.FromSql($"SELECT * FROM Books ORDER by Title").ToList();
                    datashow.DataSource = bookshw;
                }
                datashow.Columns[0].Visible = false;
            }
        }
    }
}
