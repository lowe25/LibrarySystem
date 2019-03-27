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
    public partial class LibrarianDashBoard : Form
    {
        public LibrarianDashBoard()
        {
            InitializeComponent();
        }

        private void btnBookInventory_Click(object sender, EventArgs e)
        {
            BookInventory frm = new BookInventory();
            frm.Show();
            this.Close();
        }

        private void btnBorrowers_Click(object sender, EventArgs e)
        {
            BorrowerList frm = new BorrowerList();
            frm.Show();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnerList frm = new ReturnerList();
            frm.Show();
            this.Close();
        }

        private void btnPenalty_Click(object sender, EventArgs e)
        {
            PenaltyListcs frm = new PenaltyListcs();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservation frm = new Reservation();
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
    }
}
