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
using WindowsFormsApp3;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=inventory;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            cbproduct();
        }
        private void cbproduct()
        {
            btnshow.Text = "Products";
            cb.Text = "Select";
            cb.Items.Clear();
            cb.Items.Add("View Products");
            cb.Items.Add("No of Products");
            cb.Items.Add("Total Products");
            dataGridView3.Columns.Clear();
        }
        private void btncat_Click(object sender, EventArgs e)
        {
            cbcat();
        }
        private void cbcat()
        {
            btnshow.Text = "Categories";
            cb.Text = "Select";
            cb.Items.Clear();
            cb.Items.Add("View Categories");
            cb.Items.Add("Total Categories");
            dataGridView3.Columns.Clear();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            cbcus();
        }
        private void cbcus()
        {
            btnshow.Text = "Customers";
            cb.Text = "Select";
            cb.Items.Clear();
            cb.Items.Add("View Customers");
            dataGridView3.Columns.Clear();
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb.SelectedItem == "View Products")
            {
                showproducts();
            }
            else if (cb.SelectedItem == "No of Products")
            {
                noofproducts();
            }
            else if (cb.SelectedItem == "Total Products")
            {
                totalproducts();
            }
            else if (cb.SelectedItem == "View Categories")
            {
                showcategories();
            }
            else if (cb.SelectedItem == "Total Categories")
            {
                totalcategories();
            }
            else if (cb.SelectedItem == "View Customers")
            {
                showcust();
            }
            else
            {
                MessageBox.Show("You have entered invalid category.");
            }
        }
        private void showproducts()
        {
            con.Open();
            string query = "select * from products";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            con.Close();
        }
        private void noofproducts()
        {
            con.Open();
            string query = "select * from noofproducts";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            con.Close();
        }
        private void totalproducts()
        {
            con.Open();
            string query = "select SUM(pstk) AS [Total Products] from products";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            con.Close();
        }
        private void showcategories()
        {
            con.Open();
            string query = "select * from categories";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            con.Close();
        }
        private void totalcategories()
        {
            con.Open();
            string query = "select * from countproducts";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            con.Close();
        }
        private void showcust()
        {
            con.Open();
            string query = "select * from customer";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            con.Close();
        }


        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
