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
    public partial class BorrowBook : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public BorrowBook()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:BorrowerList.accdb";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            BorrowertDashBoard frm = new BorrowertDashBoard();
            frm.Show();
            this.Close();
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookInventoryDataSet.BookInventory' table. You can move, or remove it, as needed.
            this.bookInventoryTableAdapter.Fill(this.bookInventoryDataSet.BookInventory);

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into BorrowerList values('" + txtID.Text + "','" + txtFirstName.Text + "','" + txtMiddleName.Text + "','" + txtLastName.Text + "','" + txtGrade.Text + "','" + txtSection.Text + "','" + txtBookID.Text + "','" + txtBookname.Text + "','" + dtpBorrow.Value.ToShortDateString() + "','" + dtpReturn.Value.ToShortDateString() + "')";

            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Succesfully Borrowed");
            con.Close();


            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtBookID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtBookname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789- ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz- ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }

        private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz- ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz- ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }

        private void txtGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789- ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }

        private void txtSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz- ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }
    }
}
