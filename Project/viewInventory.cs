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
    public partial class viewInventory : Form
    {
        public viewInventory()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");

        private void viewInventory_Load(object sender, EventArgs e)
        {
            AddData();
            ProductCB();
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

        private void ProductCB()
        {
            con.Open();
            string query = "Select distinct pname from products";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("pname", typeof(string));
            tbl.Load(rdr);
            comboBox2.ValueMember = "pname";
            comboBox2.DataSource = tbl;
            con.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AdminForm aform = new AdminForm();
            this.Hide();
            aform.Show();
        }

        private void demand_Click(object sender, EventArgs e)
        {
            insert();
        }
        private void clear()
        {
            comboBox2.Text = "Select Product";
            qtyTxt.Clear();
        }
        private void insert()
        {
            if (comboBox2.Text == "" || qtyTxt.Text == "")
            {
                MessageBox.Show("Missing information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddDemands", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "insert");
                    cmd.Parameters.AddWithValue("@id", 1);
                    cmd.Parameters.AddWithValue("@name", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@qty", qtyTxt.Text);
                    cmd.Parameters.AddWithValue("@d", DateTime.Now);
                    int numRes = cmd.ExecuteNonQuery();
                    con.Close();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Demand Inserted Successfully !!!");
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
        private void delete()
        {
            if (comboBox2.Text == "" || qtyTxt.Text == "")
            {
                MessageBox.Show("Missing information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value);
                    con.Open(); 
                    SqlCommand cmd = new SqlCommand("AddDemands", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "delete");
                    cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@name", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@qty", qtyTxt.Text);
                    cmd.Parameters.AddWithValue("@d", dt);
                    int numRes = cmd.ExecuteNonQuery();
                    con.Close();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully !!!");
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

        private void update()
        {
            if (comboBox2.Text == "" || qtyTxt.Text == "")
            {
                MessageBox.Show("Missing information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddDemands", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "update");
                    cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@name", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@qty", qtyTxt.Text);
                    cmd.Parameters.AddWithValue("@d", dt);
                    int numRes = cmd.ExecuteNonQuery();
                    con.Close();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Updated Successfully !!!");
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

        private void Update_Click(object sender, EventArgs e)
        {
            update();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            qtyTxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
