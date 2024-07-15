using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Adminstrator : Form
    {
        String user = " ";
        public Adminstrator()
        {
            InitializeComponent();
        }
        public String ID
        {
            get { return user.ToString(); }
        }
        public Adminstrator(String username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            user = username;
            uC_ViewUser1.ID = ID;
            uC_Profile1.ID = ID;
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            uC_Home2.Visible = true;
            uC_Home2.BringToFront();
        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            uC_Home2.Visible = false;          
            uC_User1.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_Report1.Visible = false;
           //tnHome.PerformClick();
            
           
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            uC_User1.Visible = true;
            uC_User1.BringToFront();
        }

        private void btnViewuser_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            uC_Report1.Visible = true;
            uC_Report1.BringToFront();
        }

       
       
    }
}
