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
    public partial class PenaltyAdd : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public PenaltyAdd()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:PenaltyList.accdb";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LibrarianDashBoard frm = new LibrarianDashBoard();
            frm.Show();
            this.Close();
        }

        private void PenaltyAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'borrowerListDataSet1.BorrowerList' table. You can move, or remove it, as needed.
            this.borrowerListTableAdapter.Fill(this.borrowerListDataSet1.BorrowerList);

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            switch (cboDays.SelectedIndex)
            {
                case 0:
                    txtPayment.Text = "10.00";
                    break;
                case 1:
                    txtPayment.Text = "20.00";
                    break;
                case 2:
                    txtPayment.Text = "30.00";
                    break;
                case 3:
                    txtPayment.Text = "40.00";
                    break;
                case 4:
                    txtPayment.Text = "50.00";
                    break;
                case 5:
                    txtPayment.Text = "60.00";
                    break;
                case 6:
                    txtPayment.Text = "70.00";
                    break;
                case 7:
                    txtPayment.Text = "80.00";
                    break;
                case 8:
                    txtPayment.Text = "90.00";
                    break;
                case 9:
                    txtPayment.Text = "100.00";
                    break;
                case 10:
                    txtPayment.Text = "110.00";
                    break;
                case 11:
                    txtPayment.Text = "120.00";
                    break;
                case 12:
                    txtPayment.Text = "130.00";
                    break;
                case 13:
                    txtPayment.Text = "140.00";
                    break;
                case 14:
                    txtPayment.Text = "150.00";
                    break;
                case 15:
                    txtPayment.Text = "160.00";
                    break;
                case 16:
                    txtPayment.Text = "170.00";
                    break;
                case 17:
                    txtPayment.Text = "180.00";
                    break;
                case 18:
                    txtPayment.Text = "190.00";
                    break;
                case 19:
                    txtPayment.Text = "200.00";
                    break;
                case 20:
                    txtPayment.Text = "210.00";
                    break;
                case 21:
                    txtPayment.Text = "220.00";
                    break;
                case 22:
                    txtPayment.Text = "230.00";
                    break;
                case 23:
                    txtPayment.Text = "240.00";
                    break;
                case 24:
                    txtPayment.Text = "250.00";
                    break;
                case 25:
                    txtPayment.Text = "260.00";
                    break;
                case 26:
                    txtPayment.Text = "270.00";
                    break;
                case 27:
                    txtPayment.Text = "280.00";
                    break;
                case 28:
                    txtPayment.Text = "290.00";
                    break;
                case 29:
                    txtPayment.Text = "300.00";
                    break;
                case 30:
                    txtPayment.Text = "310.00";
                    break;
            }
        }

        private void btnPenalty_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into PenaltyList values('" + txtID.Text + "','" + txtFirstName.Text + "','" + txtMiddleName.Text + "','" + txtLastName.Text + "','" + txtGrade.Text + "','" + txtSection.Text + "','" + txtBookID.Text + "','" + txtBookname.Text + "','" + dtpBorrow.Value.ToShortDateString() + "','" + dtpReturn.Value.ToShortDateString() + "','" + cboDays.Text + "','" + txtPayment.Text + "')";

            cmd.ExecuteNonQuery();
            MessageBox.Show(" Succesfully Added");
            con.Close();


            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void dgvBorrowers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dgvBorrowers.SelectedRows[0].Cells[0].Value.ToString();
            txtFirstName.Text = dgvBorrowers.SelectedRows[0].Cells[1].Value.ToString();
            txtMiddleName.Text = dgvBorrowers.SelectedRows[0].Cells[2].Value.ToString();
            txtLastName.Text = dgvBorrowers.SelectedRows[0].Cells[3].Value.ToString();
            txtGrade.Text = dgvBorrowers.SelectedRows[0].Cells[4].Value.ToString();
            txtSection.Text = dgvBorrowers.SelectedRows[0].Cells[5].Value.ToString();
            txtBookID.Text = dgvBorrowers.SelectedRows[0].Cells[6].Value.ToString();
            txtBookname.Text = dgvBorrowers.SelectedRows[0].Cells[7].Value.ToString();
            dtpBorrow.Text = dgvBorrowers.SelectedRows[0].Cells[8].Value.ToString();
            dtpReturn.Text = dgvBorrowers.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void cboDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDays.SelectedIndex)
            {
                case 0:
                    txtPayment.Text = "10.00";
                    break;
                case 1:
                    txtPayment.Text = "20.00";
                    break;
                case 2:
                    txtPayment.Text = "30.00";
                    break;
                case 3:
                    txtPayment.Text = "40.00";
                    break;
                case 4:
                    txtPayment.Text = "50.00";
                    break;
                case 5:
                    txtPayment.Text = "60.00";
                    break;
                case 6:
                    txtPayment.Text = "70.00";
                    break;
                case 7:
                    txtPayment.Text = "80.00";
                    break;
                case 8:
                    txtPayment.Text = "90.00";
                    break;
                case 9:
                    txtPayment.Text = "100.00";
                    break;
                case 10:
                    txtPayment.Text = "110.00";
                    break;
                case 11:
                    txtPayment.Text = "120.00";
                    break;
                case 12:
                    txtPayment.Text = "130.00";
                    break;
                case 13:
                    txtPayment.Text = "140.00";
                    break;
                case 14:
                    txtPayment.Text = "150.00";
                    break;
                case 15:
                    txtPayment.Text = "160.00";
                    break;
                case 16:
                    txtPayment.Text = "170.00";
                    break;
                case 17:
                    txtPayment.Text = "180.00";
                    break;
                case 18:
                    txtPayment.Text = "190.00";
                    break;
                case 19:
                    txtPayment.Text = "200.00";
                    break;
                case 20:
                    txtPayment.Text = "210.00";
                    break;
                case 21:
                    txtPayment.Text = "220.00";
                    break;
                case 22:
                    txtPayment.Text = "230.00";
                    break;
                case 23:
                    txtPayment.Text = "240.00";
                    break;
                case 24:
                    txtPayment.Text = "250.00";
                    break;
                case 25:
                    txtPayment.Text = "260.00";
                    break;
                case 26:
                    txtPayment.Text = "270.00";
                    break;
                case 27:
                    txtPayment.Text = "280.00";
                    break;
                case 28:
                    txtPayment.Text = "290.00";
                    break;
                case 29:
                    txtPayment.Text = "300.00";
                    break;
                case 30:
                    txtPayment.Text = "310.00";
                    break;
            }
        }
    }
}
