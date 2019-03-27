using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BorrowertDashBoard : Form
    {
        public BorrowertDashBoard()
        {
            InitializeComponent();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowBook frm = new BorrowBook();
            frm.Show();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnBook frm = new ReturnBook();
            frm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Logout?.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                Login frm = new Login();
                frm.Show();
                this.Close();

            }
            else
            { }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            TransactionHistory frm = new TransactionHistory();
            frm.Show();
            this.Close();
        }

        private void btnReserveList_Click(object sender, EventArgs e)
        {
            MyReservedBooks frm = new MyReservedBooks();
            frm.Show();
            this.Close();
        }
    }
}
