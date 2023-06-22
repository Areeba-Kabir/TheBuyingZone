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
using System.Data.SqlClient;

namespace TheBuyingZone
{
    public partial class Supplies : Form
    {
        public Supplies()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        string query;
        private void Supplies_Load(object sender, EventArgs e)
        {
            AddSupplyData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            this.Hide();
            af.Show();
        }

        private void AddSupplyData()
        {
            con.Open();
            query = "select * from Supply";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
