using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ItemMgmt
{
    public partial class LoginWin : Form
    {

        SqlConnection conn = new SqlConnection();

        public LoginWin()
        {
            InitializeComponent();
        }

        private void LoginWin_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=(local); Initial Catalog= GoodsMgnt;Integrated Security=True";

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Item", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Fill sucess Welcome");
            }
            else
            {
                MessageBox.Show("No Data");
            }
            conn.Close();
        }

        private void printShip_Click(object sender, EventArgs e)
        {
            formViewer fw = new formViewer();
            fw.Show();

            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderImport", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"Items");
            shipmentReport sr = new shipmentReport();
            sr.SetDataSource(ds);
            fw.crystalReportViewer1.ReportSource = sr;
            fw.crystalReportViewer1.Refresh();
            conn.Close();
        }

        private void printOrder_Click(object sender, EventArgs e)
        {
            formViewer fw = new formViewer();
            fw.Show();

            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderSell WHERE agentID=00000000", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"Sales");
            orderReport or = new orderReport();
            or.SetDataSource(ds);
            fw.crystalReportViewer1.ReportSource = or;
            fw.crystalReportViewer1.Refresh();
            conn.Close();

        }

        private void printMonthly_Click(object sender, EventArgs e)
        {
            formViewer fw = new formViewer();
            fw.Show();

            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderSell", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"Orders");
            monthlyReport mr = new monthlyReport();
            mr.SetDataSource(ds);
            fw.crystalReportViewer1.ReportSource = mr;
            fw.crystalReportViewer1.Refresh();
            conn.Close();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Developed by DT SoftwareCo. Ltd.", "About this application");

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
