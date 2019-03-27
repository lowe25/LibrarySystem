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
    public partial class BorrowerList : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public BorrowerList()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:BorrowerList.accdb";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LibrarianDashBoard frm = new LibrarianDashBoard();
            frm.Show();
            this.Close();
        }

        private void BorrowerList_Load(object sender, EventArgs e)
        {
            disp_data1();
        }
        public void disp_data1()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BorrowerList";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dgvBorrowerList.DataSource = dt;

            con.Close();
        }

        private void dgvBorrowerList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dgvBorrowerList.SelectedRows[0].Cells[0].Value.ToString();
            txtFirstName.Text = dgvBorrowerList.SelectedRows[0].Cells[1].Value.ToString();
            txtMiddleName.Text = dgvBorrowerList.SelectedRows[0].Cells[2].Value.ToString();
            txtLastName.Text = dgvBorrowerList.SelectedRows[0].Cells[3].Value.ToString();
            txtGrade.Text = dgvBorrowerList.SelectedRows[0].Cells[4].Value.ToString();
            txtSection.Text = dgvBorrowerList.SelectedRows[0].Cells[5].Value.ToString();
            txtBookID.Text = dgvBorrowerList.SelectedRows[0].Cells[6].Value.ToString();
            txtBookname.Text = dgvBorrowerList.SelectedRows[0].Cells[7].Value.ToString();
            dtpBorrow.Text = dgvBorrowerList.SelectedRows[0].Cells[8].Value.ToString();
            dtpReturn.Text = dgvBorrowerList.SelectedRows[0].Cells[9].Value.ToString();
        }
    }
}
