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
    public partial class Form3 : Form
    {
        string table;
        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        
        private void search(string table)
        {
            con.Open();
            string data = txtsearch.Text;
            SqlCommand cmd = new SqlCommand("viewdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@table", table);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            int r=da.Fill(dt);
            dataGridView3.DataSource = dt;
            if(r == 0)
            {
                MessageBox.Show("No Matches Found!");
            }
            else
            {
                MessageBox.Show("Here are the results!");
            }
            con.Close();
        }


        private void btnback_Click(object sender, EventArgs e)
        {
            HM m = new HM();
            this.Hide();
            m.Show();
        }

        private void btnviewproduct_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text=="")
            {
                MessageBox.Show("Please type something first!");
            }
            else
            {
                search("products");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                MessageBox.Show("Please type something first!");
            }
            else
            {
                search("categories");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                MessageBox.Show("Please type something first!");
            }
            else
            {
                search("customers");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                MessageBox.Show("Please type something first!");
            }
            else
            {
                search("staff");
            }
        }
    }
}
