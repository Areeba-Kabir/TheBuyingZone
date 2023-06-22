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
    public partial class AuditForm : Form
    {
        public AuditForm()
        {
            InitializeComponent();
            AddSupplyAudit();
        }

        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            this.Hide();
            af.Show();
        }

        private void btnViewChart_Click(object sender, EventArgs e)
        {
            AddDemandAudit();
        }

        private void AddDemandAudit()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getDemandAudit", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void supplyAudit_Click(object sender, EventArgs e)
        {
            AddSupplyAudit();
        }

        private void AddSupplyAudit()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getAuditSupply", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnYearlySales_Click(object sender, EventArgs e)
        {
            AddInvenAudit();
        }
        private void AddInvenAudit()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getAuditInventory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddstaffAudit();
                
        }

        private void AddstaffAudit()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getAuditStaff", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddsupAudit();   
        }

        private void AddsupAudit()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getAuditSupplier", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
