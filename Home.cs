using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrowing_Click(object sender, EventArgs e)
        {
            Borrowing borrow = new Borrowing();
            borrow.Show();
        }

        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            Librarian lib = new Librarian();
            lib.Show();

        }
    }
}
