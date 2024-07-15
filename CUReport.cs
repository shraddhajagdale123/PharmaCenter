using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;

namespace PharmacyManagementSystem
{
    public partial class CUReport : Form
    {
        function fn = new function();
        String query;

        public CUReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            UserReport1 cr = new UserReport1();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["PharmacyManagementSystem.Properties.Settings.Database1ConnectionString"].ToString();

            query = "Select * from User_Table ";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            adapter.Fill(ds, "User_Table");
            DataTable dt = ds.Tables["User_Table"];

            cr.SetDataSource(ds.Tables["User_Table"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
