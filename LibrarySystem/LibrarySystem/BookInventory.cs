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
    public partial class BookInventory : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public BookInventory()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:BookInventory.accdb";
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            LibrarianDashBoard frm = new LibrarianDashBoard();
            frm.Show();
            this.Close();
        }
        private void BookInventory_Load(object sender, EventArgs e)
        {
            disp_data1();
        }
        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into BookInventory values('" + txtBookID.Text + "','" + txtBookName.Text + "','" + txtBookAuthor.Text + "','" + txtBookPages.Text + "','" + txtISBN.Text + "','" + txtVolume.Text + "')";

            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Succesfully Added");
            con.Close();
            disp_data1();

            foreach (Control c in groupBox3.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }   
        }
        public void disp_data1()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BookInventory";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dgvBookInventory.DataSource = dt;

            con.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Delete this book?.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string st = "DELETE FROM BookInventory WHERE BookName='" + txtBookName.Text + "'";
                con.Open();
                OleDbCommand cmd = new OleDbCommand(st, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Succesfully Deleted");
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

                disp_data1();

                foreach (Control c in groupBox3.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }
        }
        private void txtBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789- ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }
        private void txtBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz- ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }
        private void txtBookAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz- ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }
        private void txtBookPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789- ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }
        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789- ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }
        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789- ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }
    }
}
