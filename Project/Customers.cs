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
using System.Data.SqlClient;
using TheBuyingZone;


namespace TheBuyingZone
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            AddCustomers();
        }
        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        String query;
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm aform = new AdminForm();
            this.Hide();
            aform.Show();
        }

        private void btnViewCustomerx_Click(object sender, EventArgs e)
        {
            AddCustomers();
        }

        private void AddCustomers(){
            con.Open();
            query = "select * from Customerview";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btntopcust_Click(object sender, EventArgs e)
        {
            AddtopCust();
        }
        private void AddtopCust()
        {
            con.Open();
            query = "select * from topCustomers";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
