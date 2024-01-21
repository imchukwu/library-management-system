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

namespace lms
{
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into librarian values(@id,@name, @age, @address)", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
            cnn.Parameters.AddWithValue("@Name", txtName.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
            cnn.Parameters.AddWithValue("@Address", txtAddress.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Saved");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Update librarian set name=@name, age=@age, address=@address where id=@id", con);


            cnn.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
            cnn.Parameters.AddWithValue("@Name", txtName.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
            cnn.Parameters.AddWithValue("@Address", txtAddress.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Updated");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("Select * from librarian", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridViewBook.DataSource = table;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Delete librarian where id=@id", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Deleted");
        }
    }
}
