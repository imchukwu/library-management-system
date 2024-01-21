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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into student values(@studentnumber,@studentname, @age, @phone, @email)", con);

            cnn.Parameters.AddWithValue("@StudentNumber", int.Parse(txtNumber.Text));
            cnn.Parameters.AddWithValue("@StudentName", txtName.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
            cnn.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cnn.Parameters.AddWithValue("@Email", txtEmail.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Saved");

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("Select * from student", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridViewStudent.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Update student set studentname=@studentname, age=@age, phone=@phone, email=@email where studentnumber=@studentnumber", con);

            cnn.Parameters.AddWithValue("@StudentNumber", int.Parse(txtNumber.Text));
            cnn.Parameters.AddWithValue("@StudentName", txtName.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
            cnn.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cnn.Parameters.AddWithValue("@Email", txtEmail.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Delete student where studentnumber=@studentnumber", con);

            cnn.Parameters.AddWithValue("@StudentNumber", int.Parse(txtNumber.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Deleted");
        }
    }
}
