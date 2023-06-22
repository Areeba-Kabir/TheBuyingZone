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

namespace StoreManagementSystem
{
    public partial class ViewCategories : Form
    {
        public ViewCategories()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string query;
        private void AddAllCategories()
        {
            con.Open();
            query = "Select * from categories";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVCategories.DataSource = ds.Tables[0];
            con.Close();
        }

        private void AddNoOfProds()
        {
            con.Open();
            query = "Select * from ProdCount";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVCategories.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ViewCategories_Load(object sender, EventArgs e)
        {
            AddAllCategories();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm aform = new AdminForm();
            this.Hide();
            aform.Show();
        }

        private void btnAllCategories_Click(object sender, EventArgs e)
        {
            AddAllCategories();
        }

        private void btnProductCount_Click(object sender, EventArgs e)
        {
            AddNoOfProds();
        }
    }
}
