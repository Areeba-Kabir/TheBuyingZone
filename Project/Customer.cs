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
using BuyingZone;
using BuyingZone.Models;

namespace WindowsFormsApp3
{
    public partial class Customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        string query;

        public Customer()
        {
            InitializeComponent();
            CatCB1();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        
        private void ProdCB()
        {
            con.Open();
            query = "Select distinct pname from products p inner join categories c on p.catid = c.catid where c.catid = (select catid from categories where cname = '" + cbcategory.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("pname", typeof(string));
            tbl.Load(rdr);
            cbcategory.ValueMember = "pname";
            cbcategory.DataSource = tbl;
            con.Close();
        }

        private void CatCB1()
        {
            con.Open();
            query = "Select distinct cname from categories";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("cname", typeof(string));
            tbl.Load(rdr);
            cbcategory.ValueMember = "cname";
            cbcategory.DataSource = tbl;
            con.Close();
        }


        private void cbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("prodgridviewfillcat '" + cbcategory.Text + "'", con);
                SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgv.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login cs = new Login();
            this.Hide();
            cs.Show();
        }

        //MessageBox.Show("Staff Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    }
}
