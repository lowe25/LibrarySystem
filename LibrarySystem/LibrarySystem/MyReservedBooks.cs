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
    public partial class MyReservedBooks : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public MyReservedBooks()
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

        private void MyReservedBooks_Load(object sender, EventArgs e)
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
    }
}
