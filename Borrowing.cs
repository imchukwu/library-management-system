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

namespace lms
{
    public partial class Borrowing : Form
    {
        public Borrowing()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into borrow values(@id, @studentname, @book, @dateborrowed, @datereturn)", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(txtBookId.Text));
            cnn.Parameters.AddWithValue("@StudentName", txtName.Text);
            cnn.Parameters.AddWithValue("@Book", txtBook.Text);
            cnn.Parameters.AddWithValue("@DateBorrowed", DateTime.Parse(txtDateBorrowed.Text));
            cnn.Parameters.AddWithValue("@DateReturn", DateTime.Parse(txtDateReturned.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Saved");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("Select * from borrow", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridViewBook.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Update borrow set studentname=@studentname, book=@book, dateborrowed=@dateborrowed, datereturn=@datereturn where id=@id", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(txtBookId.Text));
            cnn.Parameters.AddWithValue("@StudentName", txtName.Text);
            cnn.Parameters.AddWithValue("@Book", txtBook.Text);
            cnn.Parameters.AddWithValue("@DateBorrowed", DateTime.Parse(txtDateBorrowed.Text));
            cnn.Parameters.AddWithValue("@DateReturn", DateTime.Parse(txtDateReturned.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Delete borrow where id=@id", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(txtBookId.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Deleted");
        }
    }
}
