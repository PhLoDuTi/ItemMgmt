using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ItemMgmt
{
    public partial class LoginWin : Form
    {

        //SqlConnection conn = new SqlConnection();

        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public LoginWin()
        {
            InitializeComponent();
        }

        private void LoginWin_Load(object sender, EventArgs e)
        {
            //conn.Open();
            //conn.ConnectionString = @"Data Source=(local); Initial Catalog= GoodsMgnt;Integrated Security=True";
        }

        private void printShip_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(strConn);
            formViewer fw = new formViewer();
            fw.Show();

            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from [OrderImport]", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            shipmentReport sr = new shipmentReport();
            sr.SetDataSource(ds);
            fw.crystalReportViewer1.ReportSource = sr;
            //fw.crystalReportViewer1.Refresh();
            conn.Close();
        }

        private void printOrder_Click(object sender, EventArgs e)
        {

            string aid = "000001";
            SqlConnection conn = new SqlConnection(strConn);
            formViewer fw = new formViewer();
            fw.Show();

            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }
            //The problem section
            //SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("select * from [OrderSell] where agentID = '" + aid + "'", conn);
            //SqlDataAdapter da = new SqlDataAdapter("select * from OrderSell", conn);
            DataTable tablea = new DataTable();
            da.Fill(tablea);
            orderReport or = new orderReport();
            or.SetDataSource(tablea);
            fw.crystalReportViewer1.ReportSource = or;
            //fw.crystalReportViewer1.Refresh();
            //SqlCommand cmd = new SqlCommand("select * from [OrderSell] where agentID = '000001'", conn);
            //SqlDataReader sdr = cmd.ExecuteReader();
            conn.Close();

        }

        private void printMonthly_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(strConn);
            formViewer fw = new formViewer();
            fw.Show();

            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderSell where orderDate BETWEEN '2022-12-01' AND '2022-12-31'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            DataTable ds = new DataTable();
            da.Fill(ds);
            monthlyReport mr = new monthlyReport();
            mr.SetDataSource(ds);
            fw.crystalReportViewer1.ReportSource = mr;
            fw.crystalReportViewer1.Refresh();
            conn.Close();

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
