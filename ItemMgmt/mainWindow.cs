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

        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public LoginWin()
        {
            InitializeComponent();
        }

        private void LoginWin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }
            conn.Close();
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
            conn.Close();
        }

        private void printOrder_Click(object sender, EventArgs e)
        {
            String order = orderSelect.SelectedValue.ToString();
            SqlConnection conn = new SqlConnection(strConn);
            formViewer fw = new formViewer();
            fw.Show();

            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("select * from [OrderSell] where orderID = '" + order + "'", conn);
            DataTable tablea = new DataTable();
            da.Fill(tablea);
            orderReport or = new orderReport();
            or.SetDataSource(tablea);
            fw.crystalReportViewer1.ReportSource = or;
            conn.Close();

        }

        private void printMonthly_Click(object sender, EventArgs e)
        {

            string dateStart = dateStartPick.Value.Date.ToString();
            string dateEnd = dateEndPick.Value.Date.ToString();
            SqlConnection conn = new SqlConnection(strConn);
            formViewer fw = new formViewer();
            fw.Show();

            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderSell where orderDate BETWEEN '" + dateStart + "' AND '" + dateEnd + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            monthlyReport mr = new monthlyReport();
            mr.SetDataSource(ds);
            fw.crystalReportViewer1.ReportSource = mr;
            fw.crystalReportViewer1.Refresh();
            conn.Close();

        }
        private void queryApplyImport_Click(object sender, EventArgs e)
        {
            //init dgv
            importDGV.DataSource = findImport().Tables[0];
        }
        DataSet findImport()
        {
            SqlConnection conn = new SqlConnection(strConn);
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand("select * from OrderImport", conn);
            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                conn.Close();
            }
            return ds;
        }

        private void queryApplyOrders_Click(object sender, EventArgs e)
        {
            String order = orderSelect.SelectedValue.ToString();
            ordersDGV.DataSource = findOrder(order).Tables[0];
        }

        DataSet findOrder(String order)
        {
            SqlConnection conn = new SqlConnection(strConn);
            DataSet ds = new DataSet();

            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from [OrderSell] where orderID = '" + order + "'", conn);
                da.Fill(ds);
                conn.Close();
            }
            return ds;
        }
        private void orderTab_Click(object sender, EventArgs e)
        {
            updateOrderSelection();
        }

        void updateOrderSelection()
        {
            SqlConnection conn = new SqlConnection(strConn);
            DataTable ds = new DataTable();

            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT orderID FROM OrderSell", conn);
                da.Fill(ds);
                orderSelect.ValueMember = "orderID";
                orderSelect.DisplayMember = "orderID";
                orderSelect.DataSource = ds;
            }
            conn.Close();
        }


        private void applyQueryMonthly_Click(object sender, EventArgs e)
        {
            string dateStart = dateStartPick.Value.Date.ToString();
            string dateEnd = dateEndPick.Value.Date.ToString();
            monthDGV.DataSource = findMonthly(dateStart,dateEnd).Tables[0];
        }

        DataSet findMonthly(string dateStart,string dateEnd)
        {
            SqlConnection conn = new SqlConnection(strConn);
            DataSet ds = new DataSet();

            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM OrderSell where orderDate BETWEEN '" + dateStart + "' AND '" + dateEnd + "'", conn);
                da.Fill(ds);
                conn.Close();
            }
            return ds;
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
