using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LibrarySystem
{
    public partial class Login : Form
    {
        OleDbConnection con1;

        OleDbDataAdapter rs1;
        DataTable dt;

        public Login()
        {
            InitializeComponent();
            con1 = new OleDbConnection();
            con1.ConnectionString = "Provider = Microsoft.Ace.OleDb.12.0; Data Source=C:Accounts.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rs1 = new OleDbDataAdapter("Select * From Accounts Where Username = '" + txtUsername.Text + "' and Password= '" + txtPassword.Text + "'", con1);
            dt = new DataTable();
            rs1.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                string Type = dt.Rows[0][2].ToString();
                if (Type == "Librarian")
                {
                    MessageBox.Show("Welcome Librarian");
                    LibrarianDashBoard frm = new LibrarianDashBoard();
                    frm.Show();
                    this.Hide();
                }
                else if (Type == "Borrower")
                {
                    string Type1 = dt.Rows[0][2].ToString();
                    MessageBox.Show("Welcome Borrower");
                    BorrowertDashBoard frm = new BorrowertDashBoard();
                    frm.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Incorrect Username or Password");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
