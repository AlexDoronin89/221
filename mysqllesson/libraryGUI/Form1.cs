using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryGUI.Model;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace libraryGUI
{
    public partial class Form1 : Form
    {
        private string _connectionString = "Server=localhost;User=root;Password=1234;Database=library";
        private MySqlConnection _connection;
        public Form1()
        {
            InitializeComponent();
            _connection = new MySqlConnection(_connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
              InitializeBookPage();
              InitializeReaderPage();
                
            }
        }

        #region Book
        private List<Book> GetBooks(string filtersString="")
            {
            MySqlCommand command = new MySqlCommand();

            command.Connection = _connection;
                _connection.Open();

             command.CommandText = "SELECT b.id, b.title, b.author_id, b.pages_count, b.date, a.name AS 'author', bc.count " +
                "FROM book b " +
                "JOIN author a ON b.author_id=a.id " +
                "JOIN book_count bc ON b.id=bc.book_id" + filtersString +";"
                ;


                List<Book> books = new List<Book>();
             MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                books.Add(new Book
                {
                    Id = reader.GetInt32("id"),
                    Title = reader.GetString("title"),
                    AuthorId = reader.GetInt32("author_id"),
                    AuthorName = reader.GetString("author"),
                    PageCount = reader.GetInt32("pages_count"),
                    Count = reader.GetInt32("count")
                }) ;
                }

                _connection.Close();
            return books;

            }
        private List<Author> GetAuthors()
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;
            _connection.Open();

            command.CommandText = "SELECT * FROM author";


            List<Author> authors = new List<Author>();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                authors.Add(new Author
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name")
                });
            }

            _connection.Close();
            return authors;

        }
        private void InitializeBookPage()
        {
            RefreshBookData(GetBooks());
            
            comboBoxBookAuthors.DataSource=GetAuthors();
            comboBoxBookAuthors.SelectedIndex = -1;
        }
        private void RefreshBookData(List<Book> books)
        {
            dataGridViewBook.DataSource = books;
            dataGridViewBook.Columns["Id"].Visible = false;
            dataGridViewBook.Columns["AuthorId"].Visible = false;


        }
        private void buttonSelectBook_Click(object sender, EventArgs e)
        {
            string filtersString=string.Empty;
            List<string> filters = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxTitle.Text) == false)
                filters.Add($" b.title LIKE '%{textBoxTitle.Text}%'");

            if (numericUpDownPageCount.Value != 0)
                filters.Add($" b.pages_count = {numericUpDownPageCount.Value}");

            if(comboBoxBookAuthors.SelectedItem!=null)
                filters.Add($" a.id ={(comboBoxBookAuthors.SelectedItem as Author).Id }");

            if (numericUpDownBookCount.Value != 0)
                filters.Add($" bc.count {numericUpDownBookCount.Value}");

            if (dateTimePickerDate.Value.Date != DateTime.Now.Date)
                filters.Add($" b.date ='{dateTimePickerDate.Value.Date.ToString("yyyy-MM-dd")}'");


            if (filters.Count > 0)
                filtersString = " WHERE" + string.Join("AND", filters);

            RefreshBookData(GetBooks(filtersString));
        }
        private void buttonBookNewAuthor_Click(object sender, EventArgs e)
        {
            comboBoxBookAuthors.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Reader
        private List<Reader> GetReadersName()
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;
            _connection.Open();

            command.CommandText = "SELECT * FROM reader r;";

            MySqlDataReader reader = command.ExecuteReader();
            List<Reader> readers = new List<Reader>();

            while (reader.Read())
            {
                readers.Add(new Reader
                {
                    Name = reader.GetString("name")
                });
            }

            _connection.Close();
            return readers;
        }
        private List<Reader> GetReaders(string filtersString = "")
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;
                _connection.Open();

                command.CommandText = "SELECT * FROM reader r"+filtersString +";";

                MySqlDataReader reader = command.ExecuteReader();
                List<Reader> readers = new List<Reader>();

                while (reader.Read())
                {
                    readers.Add(new Reader
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        Birthday = reader.GetDateTime("birthday"),
                        Organization = reader.IsDBNull(3) ? "Null" : reader.GetString("organization")
                    });
                }

                _connection.Close();
                return readers;
        }
        private void InitializeReaderPage()
        {
            RefreshReaderData(GetReaders());
            
            comboBoxReaderName.DataSource = GetReadersName();
            comboBoxReaderName.SelectedIndex = -1;
        }
        private void RefreshReaderData(List<Reader> readers)
        {
            dataGridViewReader.DataSource = readers;
            dataGridViewReader.Columns["Id"].Visible = false;
        }
        private void buttonSelectReader_Click(object sender, EventArgs e)
        {
            string filtersString = string.Empty;
            List<string> filters = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxOrganization.Text) == false)
                filters.Add($" r.name LIKE '%{textBoxOrganization.Text}%'");

            if (comboBoxReaderName.SelectedItem != null)
                filters.Add($" r.id ={(comboBoxReaderName.SelectedItem as Reader).Id }");

            if (dateTimePickerBirthday.Value.Date != DateTime.Now.Date)
                filters.Add($" r.birthday ='{dateTimePickerBirthday.Value.Date.ToString("yyyy-MM-dd")}'");

            if (filters.Count > 0)
                filtersString = " WHERE" + string.Join("AND", filters);
            RefreshReaderData(GetReaders(filtersString));
        }
        private void buttonAddReader_Click(object sender, EventArgs e)
        {
            comboBoxReaderName.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Subscription
        private void GetSubscription()
            {
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;
            _connection.Open();

                command.CommandText = "SELECT * FROM subscription s;";

                MySqlDataReader reader = command.ExecuteReader();
                List<Subscription> subscriptions = new List<Subscription>();

                while (reader.Read())
                {
                    subscriptions.Add(new Subscription
                    {
                        Id = reader.GetInt32("id"),
                        ReaderId = reader.GetInt32("reader_id"),
                        BookId = reader.GetInt32("book_id"),
                        TakingDate = reader.GetDateTime("taking_date").Date,
                        BringDate = reader.GetDateTime("bring_date").Date,
                        IsReturn = reader.GetBoolean("is_return")
                    });
                }

                _connection.Close();

                dataGridViewSubscription.DataSource = subscriptions;
            }
        private void InitializeSubscriptionPage()
        {
           
        }
        


        #endregion











    }
}
