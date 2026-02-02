using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLiabraryApp
{
    public partial class Form1 : Form
    {
        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void AddToDatabase(string title, string author)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Books (Title, Author) VALUES (@t, @a)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@t", title);
                cmd.Parameters.AddWithValue("@a", author);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Books", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBooks.DataSource = dt;
            }
        }

        
            private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. Run the save tool
            AddToDatabase(txtTitle.Text, txtAuthor.Text);

            // 2. Tell the user it worked
            MessageBox.Show("Saved!");

            // 3. Refresh the table so you see it
            LoadData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

