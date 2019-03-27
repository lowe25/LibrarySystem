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
    public partial class TransactionHistory : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public TransactionHistory()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:ReserveBook.accdb";
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookInventoryDataSet1.BookInventory' table. You can move, or remove it, as needed.
            this.bookInventoryTableAdapter.Fill(this.bookInventoryDataSet1.BookInventory);

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into ReserveBook values('" + txtID.Text + "','" + txtFirstName.Text + "','" + txtMiddleName.Text + "','" + txtLastName.Text + "','" + txtGrade.Text + "','" + txtSection.Text + "','" + txtBookID.Text + "','" + txtBookname.Text + "','" + dtpBorrow.Value.ToShortDateString() + "')";

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            BorrowertDashBoard frm = new BorrowertDashBoard();
            frm.Show();
            this.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtBookID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtBookname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Are you sure you want to Delete this book?.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           // if (dr == DialogResult.Yes)
           // {
            //    string st = "DELETE FROM ReserveBook WHERE BookName='" + txtFirstName.Text + "'";
             //   con.Open();
            //    OleDbCommand cmd = new OleDbCommand(st, con);
             //   try
             //   {
              //      cmd.ExecuteNonQuery();
              //      MessageBox.Show("Book Succesfully Deleted");
              //  }
              //  catch (OleDbException ex)
              //  {
               //     MessageBox.Show(ex.Message);
               // }
              //  con.Close();

                //disp_data1();

               // foreach (Control c in groupBox3.Controls)
               // {
                //    if (c is TextBox)
                 //   {
                 //       c.Text = "";
                  //  }
                }
            }
        }
    //}
//}
