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
using BuyingZone;
using BuyingZone.Models;

namespace TheBuyingZone
{
    public partial class SupplierForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        public SupplierForm()
        {
            InitializeComponent();
            AddData();
            SuppCB();
            panel1.Hide();
        }

        private void AddData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getdemands", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        int id;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void SupplierCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SuppCB()
        {
            con.Open();
            string query = "Select sname from supplier";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("sname", typeof(string));
            tbl.Load(rdr);
            SupplierCb.ValueMember = "sname";
            SupplierCb.DataSource = tbl;
            con.Close();
        }

        private void insert()
        {
            if (SupplierCb.Text == "" || qtyTxt.Text == "" || nametxt.Text == "")
            {
                MessageBox.Show("Missing information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "select suppid from supplier where sname = '" + SupplierCb.Text + "'";
                    SqlCommand c = con.CreateCommand();
                    c.CommandText = query;
                    int sup = (int)c.ExecuteScalar();
                    con.Close();

                    con.Open();
                    string query1 = "select prodid from products where pname = '" + nametxt.Text + "'";
                    SqlCommand c1 = con.CreateCommand();
                    c.CommandText = query;
                    int prod = (int)c.ExecuteScalar();
                    con.Close();

                    con.Open();
                    SqlCommand cmd = new SqlCommand("Supp", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@qty", qtyTxt.Text);
                    cmd.Parameters.AddWithValue("@expdate", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@supid", sup);
                    int numRes = cmd.ExecuteNonQuery();
                    con.Close();
                    if (numRes > 0)
                    {
                        con.Open();
                        string q = "insert into inventory (prodid, quantity, expdate) values ('" + prod + "', '" + Convert.ToInt32(qtyTxt.Text) + "','" + dateTimePicker1.Value.Date + "')";
                        SqlCommand sq = new SqlCommand(q, con);
                        sq.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        string q1 = "delete from Demand where Demand_ID = '"+id+"'";
                        SqlCommand sq1 = new SqlCommand(q1, con);
                        sq1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Product Supplied Successfully !!!");
                        clear();
                    }
                    else
                        MessageBox.Show("Something went wrong.\nPlease Try Again !!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                AddData();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            nametxt.Clear();
            SupplierCb.Text = "Select Supplier";
            qtyTxt.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            qtyTxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string id1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            id = Convert.ToInt32(id1);
        }

        private void supply_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login af = new Login();
            this.Hide();
            af.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            AddAudit();
        }
        private void AddAudit()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getDemandAudit", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}