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
    public partial class PenaltyListcs : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public PenaltyListcs()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:PenaltyList.accdb";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LibrarianDashBoard frm = new LibrarianDashBoard();
            frm.Show();
            this.Close();
        }

        private void PenaltyListcs_Load(object sender, EventArgs e)
        {
            disp_data1();
        }
        public void disp_data1()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PenaltyList";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dgvPenaltyListFinal.DataSource = dt;

            con.Close();
        }

        private void dgvPenaltyListFinal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dgvPenaltyListFinal.SelectedRows[0].Cells[0].Value.ToString();
            txtFirstName.Text = dgvPenaltyListFinal.SelectedRows[0].Cells[1].Value.ToString();
            txtMiddleName.Text = dgvPenaltyListFinal.SelectedRows[0].Cells[2].Value.ToString();
            txtLastName.Text = dgvPenaltyListFinal.SelectedRows[0].Cells[3].Value.ToString();
            txtGrade.Text = dgvPenaltyListFinal.SelectedRows[0].Cells[4].Value.ToString();
            txtSection.Text = dgvPenaltyListFinal.SelectedRows[0].Cells[5].Value.ToString();
            txtBookID.Text = dgvPenaltyListFinal.SelectedRows[0].Cells[6].Value.ToString();
            txtBookname.Text = dgvPenaltyListFinal.SelectedRows[0].Cells[7].Value.ToString();
            dtpBorrow.Text = dgvPenaltyListFinal.SelectedRows[0].Cells[8].Value.ToString();
            dtpReturn.Text = dgvPenaltyListFinal.SelectedRows[0].Cells[9].Value.ToString();
            cboDays.Text = dgvPenaltyListFinal.SelectedRows[0].Cells[10].Value.ToString();
            txtPayment.Text = dgvPenaltyListFinal.SelectedRows[0].Cells[11].Value.ToString();
        }
    }
}
