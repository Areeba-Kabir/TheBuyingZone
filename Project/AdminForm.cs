using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBuyingZone;
using StoreManagementSystem;
using BuyingZone;
using BuyingZone.Models;

namespace StoreManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            HomePanel.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            AboutPanel.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AboutPanel.Hide();
            HomePanel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Shows login form and hides this
            //Application.Exit();
            Login af = new Login();
            this.Hide();
            af.Show();
        }

        private void AboutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageStaff stForm = new ManageStaff();
            this.Hide();
            stForm.Show();
        }

        private void BtnViewCategories_Click(object sender, EventArgs e)
        {
            ViewCategories vcForm = new ViewCategories();
            this.Hide();
            vcForm.Show();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            ViewProducts vpForm = new ViewProducts();
            this.Hide();
            vpForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sales vsForm = new Sales();
            this.Hide();
            vsForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            ManageInventory miform = new ManageInventory();
            this.Hide();
            miform.Show();
        }

        private void manageSupplierbtn_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();
            this.Hide();
            s.Show();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            viewInventory vi = new viewInventory();
            this.Hide();
            vi.Show();
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            this.Hide();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuditForm af = new AuditForm();
            this.Hide();
            af.Show();
        }

        private void SuppAudit_Click(object sender, EventArgs e)
        {
            Supplies s = new Supplies();
            this.Hide();
            s.Show();
        }

        private void HomePanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
