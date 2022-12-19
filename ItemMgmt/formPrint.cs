using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ItemMgmt
{
    public partial class formViewer : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public formViewer()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //Using an SQL DataReader from a SQL Commant execution, we can use
            //that to forward to parameter fields for specific report fields, which are parameter fields.

            //The code here can explain it
            /*
            SqlCommand cmd = new SqlCommand("select * from [Order] where oid = '" + _id + "'", connection);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                gdn1.SetParameterValue("agName", sdr["agentname"].ToString());
                gdn1.SetParameterValue("agNumber", sdr["agentphone"].ToString());
                gdn1.SetParameterValue("agAddress", sdr["agentaddress"].ToString());
                gdn1.SetParameterValue("orderID", _id);
                gdn1.SetParameterValue("date", sdr["delidate"].ToString());
                gdn1.SetParameterValue("total", sdr["total"].ToString());
                gdn1.SetParameterValue("method", sdr["paidmethod"].ToString());

            }
            sdr.Close();


            SqlConnection conn = new SqlConnection(strConn);

            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }

            int aid = 000001;

            DataSet dtb = new DataSet();

            //SqlDataAdapter da = new SqlDataAdapter("select Orderprod.prodid, Product.prodname, Orderprod.quantity, Product.price from Product join Orderprod on Product.prodid = Orderprod.prodid where Orderprod.oid = '" + _id + "'", connection);
            //da.Fill(dtb);

            SqlDataAdapter da = new SqlDataAdapter("select * from Product", conn);
            SqlDataAdapter db = new SqlDataAdapter("select * from Orderprod where Orderprod.oid = '" + aid + "'", conn);

            DataTable taba = new DataTable("Product");
            DataTable tabb = new DataTable("Orderprod");

            da.Fill(taba);
            db.Fill(tabb);

            dtb.Tables.Add(taba);
            dtb.Tables.Add(tabb);


            SqlCommand cmd = new SqlCommand("select * from [OrderSell] where agentID = " + aid, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ds.Tables.Add(da);
            orderReport or = new orderReport();
            or.SetDataSource(ds);

             */
        }
    }
}
