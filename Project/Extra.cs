using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManagementSystem;
using TheBuyingZone;
using WindowsFormsApp3;

namespace TheBuyingZone
{
    public partial class Extra : Form
    {
        public Extra()
        {
            InitializeComponent();
        }

        private void Extra_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            this.Hide();
            af.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierForm sf = new SupplierForm();
            this.Hide();
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manager sf = new Manager();
            this.Hide();
            sf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HM h = new HM();
            this.Hide();
            h.Show();
        }
    }
}
