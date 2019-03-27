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
    public partial class Reservation : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public Reservation()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:ReserveBook.accdb";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            BorrowertDashBoard frm = new BorrowertDashBoard();
            frm.Show();
            this.Close();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            disp_data1();
        }
        public void disp_data1()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ReserveBook";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dgvReserve.DataSource = dt;

            con.Close();
        }

        private void dgvReserve_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dgvReserve.SelectedRows[0].Cells[0].Value.ToString();
            txtFirstName.Text = dgvReserve.SelectedRows[0].Cells[1].Value.ToString();
            txtMiddleName.Text = dgvReserve.SelectedRows[0].Cells[2].Value.ToString();
            txtLastName.Text = dgvReserve.SelectedRows[0].Cells[3].Value.ToString();
            txtGrade.Text = dgvReserve.SelectedRows[0].Cells[4].Value.ToString();
            txtSection.Text = dgvReserve.SelectedRows[0].Cells[5].Value.ToString();
            txtBookID.Text = dgvReserve.SelectedRows[0].Cells[6].Value.ToString();
            txtBookname.Text = dgvReserve.SelectedRows[0].Cells[7].Value.ToString();
            dtpBorrow.Text = dgvReserve.SelectedRows[0].Cells[8].Value.ToString();
        }
    }
}
