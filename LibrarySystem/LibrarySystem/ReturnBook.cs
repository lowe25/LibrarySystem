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
    public partial class ReturnBook : Form
    {
        private OleDbConnection con = new OleDbConnection();


        OleDbDataAdapter sda;


        DataTable dt;

        public ReturnBook()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:ReturnerList.accdb";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            BorrowertDashBoard frm = new BorrowertDashBoard();
            frm.Show();
            this.Close();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'borrowerListDataSet.BorrowerList' table. You can move, or remove it, as needed.
            this.borrowerListTableAdapter.Fill(this.borrowerListDataSet.BorrowerList);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
             con.Open();
             OleDbCommand cmd = new OleDbCommand();
             cmd.Connection = con;
             cmd.CommandText = "insert into ReturnerList values('" + txtID.Text + "','" + txtFirstName.Text + "','" + txtMiddleName.Text + "','" + txtLastName.Text + "','" + txtGrade.Text + "','" + txtSection.Text + "','" + txtBookID.Text + "','" + txtBookname.Text + "','" + dtpBorrow.Value.ToShortDateString() + "','" + dtpBorrow.Value.ToShortDateString() + "')";

             cmd.ExecuteNonQuery();
             MessageBox.Show("Book Succesfully Returned");
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
            txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtMiddleName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtLastName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtGrade.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtSection.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtBookID.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtBookname.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            dtpBorrow.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            dtpReturn.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }
    }
}
