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
using TheBuyingZone;
using BuyingZone;
using BuyingZone.Models;

namespace WindowsFormsApp3
{
    public partial class Manager : Form
    {
        string action,action1;
        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        public Manager()
        {
            InitializeComponent();
            panel2.Hide();
            Products.Hide();
            customers.Hide();
            well.Show();
        }

        private void btncadd_Click(object sender, EventArgs e)
        {
            action = "insert";
            action1 = "inserted";
            if (txtcid.Text == "" || txtcname.Text == "" || txtcdes.Text == "")
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationcategories();
            }
            clearcat();
        }

        private void btncupdate_Click(object sender, EventArgs e)
        {
            action = "update";
            action1 = "updated";
            if (txtcid.Text == "" || txtcname.Text == "" || txtcdes.Text == "")
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationcategories();
            }
            clearcat();
        }

        private void btncdelete_Click(object sender, EventArgs e)
        {
            action = "delete";
            action1 = "deleted";
            if (txtcid.Text == "" || txtcname.Text == "" || txtcdes.Text == "")
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationcategories();
            }
            clearcat();
        }

        private void btncclear_Click(object sender, EventArgs e)
        {
            clearcat();
        }

        private void clearcat()
        {
            txtcid.Text = "";
            txtcname.Text = "";
            txtcdes.Text = "";
        }

        private void operationcategories()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("p_cat",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action",action);
                cmd.Parameters.AddWithValue("@id",txtcid.Text);
                cmd.Parameters.AddWithValue("@cname",txtcname.Text);
                cmd.Parameters.AddWithValue("@description",txtcdes.Text);
                int res=cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Data "+ action1 +" successffully!");
                }
                else
                {
                    MessageBox.Show("There is something missing!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                getdata_categories();
            }
            
        }

        private void operationcustomer()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("p_customer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", action);
                cmd.Parameters.AddWithValue("@id", txtcus_id.Text);
                cmd.Parameters.AddWithValue("@fname", txtcusfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtcuslname.Text);
                cmd.Parameters.AddWithValue("@contact", txtcontact.Text);
                cmd.Parameters.AddWithValue("@email", txtcustemail.Text);
                cmd.Parameters.AddWithValue("@address", txtcustadd.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Data " + action1 + " successffully!");
                }
                else
                {
                    MessageBox.Show("There is something missing!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                getdata_customers();
            }
        }

        private void dgcate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcid.Text = dgcate.SelectedRows[0].Cells[0].Value.ToString();
            txtcname.Text = dgcate.SelectedRows[0].Cells[1].Value.ToString();
            txtcdes.Text = dgcate.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dgcustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcus_id.Text = dgcustomers.SelectedRows[0].Cells[0].Value.ToString();
            txtcusfname.Text = dgcustomers.SelectedRows[0].Cells[1].Value.ToString();
            txtcuslname.Text = dgcustomers.SelectedRows[0].Cells[2].Value.ToString();
            txtcontact.Text = dgcustomers.SelectedRows[0].Cells[3].Value.ToString();
            txtcustemail.Text = dgcustomers.SelectedRows[0].Cells[4].Value.ToString();
            txtcustadd.Text = dgcustomers.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void getdata_customers()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("p_customer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "getdata");
                cmd.Parameters.AddWithValue("@id", txtcid.Text);
                cmd.Parameters.AddWithValue("@fname", txtcusfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtcuslname.Text);
                cmd.Parameters.AddWithValue("@contact", txtcontact.Text);
                cmd.Parameters.AddWithValue("@email", txtcustemail.Text);
                cmd.Parameters.AddWithValue("@address", txtcustadd.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgcustomers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void getdata_categories()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("p_cat", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "getdata");
                cmd.Parameters.AddWithValue("@id", txtcid.Text);
                cmd.Parameters.AddWithValue("@cname", txtcname.Text);
                cmd.Parameters.AddWithValue("@description", txtcdes.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgcate.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            action = "insert";
            action1 = "inserted";
            if (txtcus_id.Text == "" || txtcusfname.Text == "" || txtcuslname.Text == "" || txtcontact.Text == "" || txtcustemail.Text == "" || txtcustadd.Text == "")
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationcustomer();
            }
            clearcust();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            action = "update";
            action1 = "updated";
            if (txtcus_id.Text == "" || txtcusfname.Text == "" || txtcuslname.Text == "" || txtcontact.Text == "" || txtcustemail.Text == "" || txtcustadd.Text == "")
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationcustomer();
            }
            clearcust();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            action = "delete";
            action1 = "deleted";
            if (txtcus_id.Text == "" || txtcusfname.Text == "" || txtcuslname.Text == "" || txtcontact.Text == "" || txtcustemail.Text == "" || txtcustadd.Text == "")
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationcustomer();
            }
            clearcust();
        }

        private void clearcust()
        {
            txtcus_id.Text = "";
            txtcusfname.Text = "";
            txtcuslname.Text = "";
            txtcontact.Text = "";
            txtcustemail.Text = "";
            txtcustadd.Text = "";
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            Products.Show();
            comboboxcatid();
            comboboxcatname();
            cbcatid.Text = "select id";
            cbcatname.Text = "view category name";
            getdata_products();
            //getdata_products();
            panel2.Hide();
            well.Hide();
            customers.Hide();
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            panel2.Show();
            getdata_categories();
            Products.Hide();
            well.Hide();
            customers.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customers.Show();
            getdata_customers();
            well.Hide();
            panel2.Hide();
            Products.Hide();
        }

        private void btnpadd_Click(object sender, EventArgs e)
        {
            action = "insert";
            action1 = "inserted";
            if (txtpid.Text == "" || txtpname.Text == "" || txtup.Text == "" || cbcatid.Text == "" || cbcatname.Text == "" || txtdes.Text == "")
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationproducts();
            }
            clearprod();
        }

        private void btnpupdate_Click(object sender, EventArgs e)
        {
            action = "update";
            action1 = "updated";
            if (txtpid.Text == "" || txtpname.Text == "" || txtup.Text == "" || cbcatid.Text == "" || cbcatname.Text == "" || txtdes.Text == "")
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationproducts();
            }
            clearprod();
        }

        private void btnpdelete_Click(object sender, EventArgs e)
        {
            action = "delete";
            action1 = "deleted";
            if (txtpid.Text == "" || txtpname.Text == "" || txtup.Text == "" || cbcatid.Text == "" || cbcatname.Text == "" || txtdes.Text == "")
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationproducts();
            }
            clearprod();
        }

        private void btnpclear_Click(object sender, EventArgs e)
        {
            clearprod();
        }

        private void clearprod()
        {
            txtpid.Text = "";
            txtpname.Text = "";
            txtup.Text = "";
            cbcatid.Text = "";
            cbcatname.Text = "";
            txtdes.Text = "";
        }

        private void operationproducts()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("p_prod", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", action);
                cmd.Parameters.AddWithValue("@id", txtpid.Text);
                cmd.Parameters.AddWithValue("@cid", cbcatid.Text);
                cmd.Parameters.AddWithValue("@pname", txtpname.Text);
                cmd.Parameters.AddWithValue("@price", txtup.Text);
                cmd.Parameters.AddWithValue("@description", txtdes.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Data " + action1 + " successffully!");
                }
                else
                {
                    MessageBox.Show("There is something missing!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                getdata_products();
            }
        }

        private void comboboxcatid()
        {
            try
            {
                con.Open();
                string query = "Select catid from categories";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable tbl = new DataTable();
                tbl.Columns.Add("catid", typeof(int));
                tbl.Load(rdr);
                cbcatid.ValueMember = "catid";
                cbcatid.DataSource = tbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void comboboxcatname()
        {
            try
            {
                con.Open();
                string query = "select cname from categories";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbcatname.Items.Add(reader[0]);
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Combobox Exception");
            }
            finally
            {
                con.Close();
            }
            //try
            //{
            //    con.Open();
            //    string query = "Select cname from categories";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    SqlDataReader rdr;
            //    rdr = cmd.ExecuteReader();
            //    DataTable tbl = new DataTable();
            //    tbl.Columns.Add("cname", typeof(string));
            //    tbl.Load(rdr);
            //    cbcatname.ValueMember = "catname";
            //    cbcatname.DataSource = tbl;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpid.Text = dgvprod.SelectedRows[0].Cells[0].Value.ToString();
            txtpname.Text = dgvprod.SelectedRows[0].Cells[2].Value.ToString();
            txtup.Text = dgvprod.SelectedRows[0].Cells[3].Value.ToString();
            cbcatid.Text = dgvprod.SelectedRows[0].Cells[1].Value.ToString();
            cbcatname.Text = "view category name";
            txtdes.Text = dgvprod.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login ex = new Login();
            this.Hide();
            ex.Show();
        }

        private void getdata_products()
        {
            try
            {
                con.Open();
                string newquery = "select * from products";
                SqlDataAdapter sqladapter = new SqlDataAdapter(newquery, con);
                SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sqladapter);
                var ds = new DataSet();
                sqladapter.Fill(ds);
                dgvprod.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            //try
            //{

            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("p_prod", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@action", "getdata");
            //    cmd.Parameters.AddWithValue("@id", txtpid.Text);
            //    cmd.Parameters.AddWithValue("@cid", cbcatid.Text);
            //    cmd.Parameters.AddWithValue("@pname", txtpname.Text);
            //    cmd.Parameters.AddWithValue("@price",txtup.Text);
            //    cmd.Parameters.AddWithValue("@description", txtdes.Text);
            //    //string query = "select * from products;";
            //    // SqlCommand cmd = new SqlCommand(query,con);
            //    // SqlDataReader reader = cmd.ExecuteReader();
            //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    //dt.Load(reader);
            //    sda.Fill(dt);
            //    dgcate.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
        }

    }
}
