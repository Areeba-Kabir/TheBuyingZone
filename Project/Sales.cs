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
using StoreManagementSystem;
using TheBuyingZone;

namespace TheBuyingZone
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            label14.Show();
            SalesBarChart.Hide();
            dataGridView1.Show();
            AddData();
        }

        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        String query;
        private void btnViewChart_Click(object sender, EventArgs e)
        {
            label2.Hide();
            label14.Hide();
            label1.Show();
            dataGridView1.Hide();
            SalesBarChart.Show();
            FillChart();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label14.Show();
            SalesBarChart.Hide();
            dataGridView1.Show();
            AddData();
        }
        private void AddData()
        {
            con.Open();
            query = "select * from orders";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void AddYearlyData()
        {
            con.Open();
            query = "select * from YearlySales";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void FillChart()
        {
            con.Open();
            DataTable dt = new DataTable();
            query = "Select Year, TotalSales from YearlySales";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            SalesBarChart.DataSource = dt;
            con.Close();
            SalesBarChart.Series["TotalAmount"].XValueMember = "Year";
            SalesBarChart.Series["TotalAmount"].YValueMembers = "TotalSales";
            SalesBarChart.Titles.Add("Yearly Sales");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {

            AdminForm aform = new AdminForm();
            this.Hide();
            aform.Show();
        }

        private void btnYearlySales_Click(object sender, EventArgs e)
        {
            label14.Hide();
            label1.Hide();
            label2.Show();
            AddYearlyData();
            SalesBarChart.Hide();
            dataGridView1.Show();
        }
    }
}
