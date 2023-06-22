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
    public partial class ManageInventory : Form
    {
        public ManageInventory()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        String query;
        private void DGVSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void clear()
        {
            qtytxt.Clear();
            //exptxt.Clear();
            dateTimePicker1.Value = DateTime.Now;
            catcb.Text = "";
            prodcb.Text = "";
        }

        private void AddData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getInventory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVInventory.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            AddData();
            CategoryCB();
            ProductCB();
            panel2.Show();
            panel3.Show();
            panel4.Hide();
            label6.Show();
            label9.Hide();
        }


        private void insert()
        {
            if (catcb.Text == "" || prodcb.Text == "" || qtytxt.Text == "" )
            {
                MessageBox.Show("Missing information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "select prodid from products where pname = '" + prodcb.Text + "'";
                    SqlCommand c = con.CreateCommand();
                    c.CommandText = query;
                    int p = (int)c.ExecuteScalar();
                    con.Close();

                    con.Open();
                    SqlCommand cmd = new SqlCommand("InventoryOpr", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "insert");
                    cmd.Parameters.AddWithValue("@id", 1); 
                    cmd.Parameters.AddWithValue("@pid", p);
                    cmd.Parameters.AddWithValue("@qty", qtytxt.Text);
                    cmd.Parameters.AddWithValue("@expire", dateTimePicker1.Value.Date);
                    int numRes = cmd.ExecuteNonQuery();
                    con.Close();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Inventory Inserted Successfully !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                        MessageBox.Show("Something went wrong.\nPlease Try Again !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (catcb.Text == "" || prodcb.Text == "" || qtytxt.Text == "" )
            {
                MessageBox.Show("Missing information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "select prodid from products where pname = '" + prodcb.Text + "'";
                    SqlCommand c = con.CreateCommand();
                    c.CommandText = query;
                    int p = (int)c.ExecuteScalar();
                    con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("InventoryOpr", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "delete");
                    cmd.Parameters.AddWithValue("@id", DGVInventory.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@pid", p);
                    cmd.Parameters.AddWithValue("@qty", qtytxt.Text);
                    cmd.Parameters.AddWithValue("@expire", dateTimePicker1.Value.Date);
                    int numRes = cmd.ExecuteNonQuery();
                    con.Close();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                        MessageBox.Show("Something went wrong.\nPlease Try Again !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (catcb.Text == "" || prodcb.Text == "" || qtytxt.Text == "" )
            {
                MessageBox.Show("Missing information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "select prodid from products where pname = '" + prodcb.Text + "'";
                    SqlCommand c = con.CreateCommand();
                    c.CommandText = query;
                    int p = (int)c.ExecuteScalar();
                    con.Close();

                    con.Open();
                    SqlCommand cmd = new SqlCommand("InventoryOpr", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "update");
                    cmd.Parameters.AddWithValue("@id", DGVInventory.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@pid", p);
                    cmd.Parameters.AddWithValue("@qty", qtytxt.Text);
                    cmd.Parameters.AddWithValue("@expire", dateTimePicker1.Value.Date);
                    int numRes = cmd.ExecuteNonQuery();
                    con.Close();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Updated Successfully !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                        MessageBox.Show("Something went wrong.\nPlease Try Again !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void catcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (catcb.Text == "Select Category")
            {
                MessageBox.Show("Select Category!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Close();
                ProductCB();
            }
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
            catcb.ValueMember = "cname";
            catcb.DataSource = tbl;
            con.Close();
        }

        private void ProductCB()
        {
            con.Open();
            query = "Select distinct pname from products p inner join categories c on p.catid = c.catid where c.catid = (select catid from categories where cname = '" + catcb.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("pname", typeof(string));
            tbl.Load(rdr);
            prodcb.ValueMember = "pname";
            prodcb.DataSource = tbl;
            con.Close();
        }

        private void DGVInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            //panel2.Hide();
            panel4.Show();
            comboBox1.Hide();
            comboBox2.Hide();
            label7.Hide();
            label8.Hide(); label9.Show();
            label6.Hide(); //dataGridView1.Show();
            filter.Show();
            AddData1();
        }

        private void AddData1()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getInventory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void managebtn_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel4.Hide();
            label6.Show();
            label9.Hide();
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
            comboBox1.ValueMember = "cname";
            comboBox1.DataSource = tbl;
            con.Close();
        }

        private void ProdCB()
        {
            con.Open();
            query = "Select distinct pname from products p inner join categories c on p.catid = c.catid where c.catid = (select catid from categories where cname = '" + comboBox1.Text + "')";
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

        private void viewInventory()
        {
            con.Open();
            string query = "select * from inventory where prodid = (select prodid from products where pname = '"+comboBox2.Text+"')";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void BtnInsert_Click_1(object sender, EventArgs e)
        {
            insert();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            delete();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            update();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void filter_Click_2(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            this.Hide();
            af.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnexp_Click(object sender, EventArgs e)
        {
            filter.Hide();
            panel4.Show();
            comboBox1.Hide();
            comboBox2.Hide();
            label7.Hide();
            label8.Hide();
            label9.Show();
            label6.Hide();
            AddExpired();
        }

        private void AddExpired()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getExpired", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void AddShortstock()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getShort", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnshort_Click(object sender, EventArgs e)
        {
            filter.Hide(); 
            panel4.Show();
            comboBox1.Hide();
            comboBox2.Hide();
            label7.Hide();
            label8.Hide(); 
            label9.Show();
            label6.Hide();
            AddShortstock();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            con.Close();
            ProdCB();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            con.Close();
            viewInventory();
        }

        private void catcb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            con.Close();
            ProductCB();
        }

        private void prodcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGVInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            string query = "select distinct c.cname from categories c inner join products p on p.catid=c.catid where prodid = '" + DGVInventory.SelectedRows[0].Cells[1].Value.ToString() + "'";
            SqlCommand c = con.CreateCommand();
            c.CommandText = query;
            string cat = (string)c.ExecuteScalar();
            catcb.Text = cat;
            con.Close();
            con.Open();

            string query1 = "select distinct p.pname from products p where prodid = '" + DGVInventory.SelectedRows[0].Cells[1].Value.ToString() + "'";
            SqlCommand c1 = con.CreateCommand();
            c1.CommandText = query1;
            string prod = (string)c1.ExecuteScalar();
            prodcb.Text = prod;
            con.Close();
            qtytxt.Text = DGVInventory.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(DGVInventory.SelectedRows[0].Cells[3].Value);
            //exptxt.Text = DGVInventory.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void filter_Click(object sender, EventArgs e)
        {
            comboBox1.Show();
            comboBox2.Show();
            CatCB1();
            ProdCB();
            label8.Show();
            label7.Show();
            viewInventory();
        }
    }
}
