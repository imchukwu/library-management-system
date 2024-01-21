using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace lms
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into book values(@bookid,@book, @number, @author, @publisher)", con);

            cnn.Parameters.AddWithValue("@BookId", int.Parse(txtBookId.Text));
            cnn.Parameters.AddWithValue("@Book", txtBook.Text);
            cnn.Parameters.AddWithValue("@Number", int.Parse(txtBookNumber.Text));
            cnn.Parameters.AddWithValue("@Author", txtAuthor.Text);
            cnn.Parameters.AddWithValue("@Publisher", txtPublisher.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Saved");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("Select * from book", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridViewBook.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Update book set book=@book, number=@number, author=@author, publisher=@publisher where bookid=@bookid", con);

            cnn.Parameters.AddWithValue("@BookId", int.Parse(txtBookId.Text));
            cnn.Parameters.AddWithValue("@Book", txtBook.Text);
            cnn.Parameters.AddWithValue("@Number", int.Parse(txtBookNumber.Text));
            cnn.Parameters.AddWithValue("@Author", txtAuthor.Text);
            cnn.Parameters.AddWithValue("@Publisher", txtPublisher.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Delete book where bookid=@bookid", con);

            cnn.Parameters.AddWithValue("@BookId", int.Parse(txtBookId.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Deleted");
        }
    }
}
