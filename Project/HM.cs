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
    public partial class HM : Form
    {
        string cb;
        string action=null,action1;
        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        public HM()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            well.Hide();
            panel1.Show();
            well.Hide();
            btnproceed.Hide();
            dgv.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            back();
            btn_m_s.Text = "Manage Staff";
        }

        private void btnstaffaudit_Click(object sender, EventArgs e)
        {
            action = "action";
            btn_m_s.Text = "Staff Audit";
            btnactionbefore();
            showstaffaudit();
        }

        private void back()
        {
            if (action == "action")
            {
                btnaction();
                action = null;
            }
            else if(action == null)
            {
                panel1.Hide();
                well.Show();
                btnproceed.Show();
            }
        }

        private void btnaction()
        {
            dgv.Hide();
            btnstaffaudit.Show();
            btnauditproduct.Show();
            btnviewproduct.Show();
            btnvmpackage.Show();
            btnviewstaff.Show();
            btnmakepackage.Show();
            btncustaudit.Show();
            btncataudit.Show();
            btnviewstaff.Show();
            btnviewcust.Show();
            button5.Show();
            button3.Show();
            button6.Show();
        }

        private void btnactionbefore()
        {
            btnstaffaudit.Hide();
            btnauditproduct.Hide();
            btnviewproduct.Hide();
            btnvmpackage.Hide();
            btnviewstaff.Hide();
            btnmakepackage.Hide();
            btncustaudit.Hide();
            btncataudit.Hide();
            btnviewstaff.Hide();
            btnviewcust.Hide();
            button3.Hide();
            button5.Hide();
            button6.Hide();
            dgv.Show();
        }

        private void btncustaudit_Click(object sender, EventArgs e)
        {
            action = "action";
            btn_m_s.Text = "Customer Audit";
            btnactionbefore();
            showcustaudit();
        }

        private void btncataudit_Click(object sender, EventArgs e)
        {
            action = "action";
            btn_m_s.Text = "Categories Audit";
            btnactionbefore();
            categoriesaudit();
        }

        private void btnviewstaff_Click(object sender, EventArgs e)
        {
            action = "action";
            btn_m_s.Text = "View Staff";
            btnactionbefore();
            viewstaff();
        }

        private void btnviewcust_Click(object sender, EventArgs e)
        {
            action = "action";
            btn_m_s.Text = "View Customers";
            btnactionbefore();
            viewcustomers();
        }

        private void viewcustomers()
        {
            try
            {
                con.Open();
                string query = "select * from customers";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
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

        private void categoriesaudit()
        {

            try
            {
                con.Open();
                string query = "select * from audit_categories";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
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

        private void viewstaff()
        {

            try
            {
                con.Open();
                string query = "select * from staff";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
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

        private void showcustaudit()
        {
            try
            {
                con.Open();
                string query = "select * from customer_audit";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
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

        private void showstaffaudit()
        {

            try
            {
                con.Open();
                string query = "select * from staff_audit";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
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

        private void btn_m_s_Click(object sender, EventArgs e)
        {
            well.Hide();
            panel1.Hide();
            panel2.Show();
            getdata_staff();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            well.Hide();
            panel1.Show();
            dgv.Hide();
            btnaction();
        }

        private void btnpadd_Click(object sender, EventArgs e)
        {
            action = "insert";
            action1 = "inserted";
            if (txtsid.Text == "" || txtfname.Text == "" || txtlname.Text == "" || txtcon.Text == "" || txtemail.Text == "" || txtaddress.Text == "" || txtrole.Text == "")
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationstaff();
            }
            clear();
        }

        private void btnpupdate_Click(object sender, EventArgs e)
        {
            action = "update";
            action1 = "updated";
            if (txtsid.Text == "" || txtfname.Text == "" || txtlname.Text == "" || txtcon.Text == "" || txtemail.Text == "" || txtaddress.Text == "" || txtrole.Text == "")
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationstaff();
            }
            clear();
        }

        private void btnpdelete_Click(object sender, EventArgs e)
        {
            action = "delete";
            action1 = "deleted";
            if (txtsid.Text == "" || txtfname.Text == "" || txtlname.Text == "" || txtcon.Text == "" || txtemail.Text == "" || txtaddress.Text == "" || txtrole.Text == "")
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationstaff();
            }
            clear();
        }

        private void btnpclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtsid.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtcon.Text = "";
            txtemail.Text = "";
            txtaddress.Text = "";
            txtrole.Text = "";
        }

         private void operationstaff()
         {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("p_staff", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", action);
                cmd.Parameters.AddWithValue("@id", txtsid.Text);
                cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@contact", txtcon.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@role", txtrole.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
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
                getdata_staff();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            this.Hide();
            m.Show();

        }

        private void dgstaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsid.Text = dgstaff.SelectedRows[0].Cells[0].Value.ToString();
            txtfname.Text = dgstaff.SelectedRows[0].Cells[1].Value.ToString();
            txtlname.Text = dgstaff.SelectedRows[0].Cells[2].Value.ToString();
            txtcon.Text = dgstaff.SelectedRows[0].Cells[3].Value.ToString();
            txtemail.Text = dgstaff.SelectedRows[0].Cells[4].Value.ToString();
            txtaddress.Text = dgstaff.SelectedRows[0].Cells[5].Value.ToString();
            txtrole.Text = dgstaff.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            action = "action";
            btn_m_s.Text = "View Products";
            dgv.Show();
            btnactionbefore();
            viewproductswithcategory();
        }

        private void viewproductswithcategory()
        {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select prodid,pname,price,c.cname from products p inner join categories c on p.catid=c.catid", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv.DataSource = dt;
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
            //    SqlCommand cmd = new SqlCommand("prodgridviewfillcat", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@cname", cbcatname.SelectedItem);
            //    SqlDataAdapter sda = new SqlDataAdapter();
            //    //cmd.ExecuteNonQuery();
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    dgvpack.DataSource = dt;
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

      
        private void viewproductsdt()
        {
            try
            {
                con.Open();
                string query = "select * from audit_products";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
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

        private void getdata_staff()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("p_staff", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "getdata");
                cmd.Parameters.AddWithValue("@id", txtsid.Text);
                cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@contact", txtcon.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@role", txtrole.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgstaff.DataSource = dt;
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

        private void btnauditproduct_Click(object sender, EventArgs e)
        {
            action = "action";
            btn_m_s.Text = "View Products";
            btnactionbefore();
            viewproductsdt();
        }

        private void btnmakepackage_Click(object sender, EventArgs e)
        {
            action = "action";
            btn_m_s.Text = "Make Package";
            btnactionbefore();
            makepackage();
        }

        private void makepackage()
        {
            panel3.Show();
            getdata_package();
            comboboxproducts();
            panel1.Hide();
            panel2.Hide();
            well.Hide();
        }

        private void btnvmpackage_Click(object sender, EventArgs e)
        {
            action = "action";
            btn_m_s.Text = "View Packages";
            btnactionbefore();
            viewpackage();
        }

        private void viewpackage()
        {

            try
            {
                con.Open();
                string query = "select * from package";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
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

        private void button4_Click(object sender, EventArgs e)
        {
             panel2.Hide();
            panel3.Hide();
            well.Hide();
            panel1.Show();
            dgv.Hide();
            btnaction();
        }

        private void btnpackadd_Click(object sender, EventArgs e)
        {
            action = "insert";
            action1 = "inserted";
            if (txtpackid.Text == "" || txtpackname.Text == "" || txtdis.Text == "" )
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationspack();
            }
            clear();
        }

        private void btnpackupdate_Click(object sender, EventArgs e)
        {
            action = "update";
            action1 = "updated";
            if (txtpackid.Text == "" || txtpackname.Text == "" || txtdis.Text == ""  )
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationspack();
            }
            clear();
        }

        private void btndeletepack_Click(object sender, EventArgs e)
        {
            action = "delete";
            action1 = "deleted";
            if (txtpackid.Text == "" || txtpackname.Text == "" || txtdis.Text == "" )
            {
                MessageBox.Show("Something is Missing!");
            }
            else
            {
                operationspack();
            }
            clear();
        }

        private void comboboxproducts()
        {
            con.Open();
            string query = "Select distinct prodid from products p inner join categories c on p.catid = c.catid ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("prodid", typeof(int));
            tbl.Load(rdr);
            cbproduct.ValueMember = "prodid";
            cbproduct.DataSource = tbl;
            con.Close();

        }

        private void operationspack()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("p_package", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", action);
                cmd.Parameters.AddWithValue("@id", txtpackid.Text);
                cmd.Parameters.AddWithValue("@prodid", 1);
                cmd.Parameters.AddWithValue("@pname", txtpackname.Text);
                cmd.Parameters.AddWithValue("@miniamount", txtdis.Text);
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
                getdata_package();
                clear();
            }
        }

        private void getdata_package()
        {
            try
            {
                con.Open();
                string newquery = "select * from package;";
                SqlDataAdapter sqladapter = new SqlDataAdapter(newquery, con);
                SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sqladapter);
                var ds = new DataSet();
                sqladapter.Fill(ds);
                dgvpack.DataSource = ds.Tables[0];
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

        private void btnclearpack_Click(object sender, EventArgs e)
        {
            clearpack();
        }

        private void dgvpack_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpackid.Text = dgvpack.SelectedRows[0].Cells[0].Value.ToString();
            txtpackname.Text = dgvpack.SelectedRows[0].Cells[1].Value.ToString();
            txtdis.Text = dgvpack.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Shippers sh = new Shippers();
            this.Hide();
            sh.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void clearpack()
        {
            txtpackid.Text = "";
            txtpackname.Text = "";
            txtdis.Text = "";
        }
       
    }
}
