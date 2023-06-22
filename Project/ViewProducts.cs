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
using TheBuyingZone;
using StoreManagementSystem;

namespace StoreManagementSystem
{
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        string query;
        private void AddProductsQty()
        { 
            con.Open();
            query = "Select * from prodQty";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVProducts.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnExpiredprods_Click(object sender, EventArgs e)
        {
            label1.Hide();
            cbCategory.Hide();
            AddProductsQty();
        }

        private void AddAllProducts()
        {
            con.Open();
            query = "Select * from Products";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVProducts.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            label1.Hide();
            cbCategory.Hide();
            //panelcatWise.Hide();
            //panelExpiredandAll.Show();
            AddAllProducts();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            //panelcatWise.Hide();
            //panelExpiredandAll.Show();
            label1.Hide();
            cbCategory.Hide();
            AddAllProducts();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm aform = new AdminForm();
            this.Hide();
            aform.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select c.catid,p.prodid, pname, price from products p inner join categories c on p.catid = c.catid where cname = '" + cbCategory.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVProducts.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategoryCB()
        {
            con.Open();
            query = "Select distinct cname from categories";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("cname", typeof(string));
            tbl.Load(rdr);
            cbCategory.ValueMember = "cname";
            cbCategory.DataSource = tbl;
            con.Close();
        }

        private void CategoryWiseProducts()
        {

        }

        private void btnCategoryWise_Click(object sender, EventArgs e)
        {
            label1.Show();
            cbCategory.Show();
            CategoryCB();
        }
    }
}
