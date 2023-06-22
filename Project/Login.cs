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
using BuyingZone.Models;
using BuyingZone;
using TheBuyingZone;
using WindowsFormsApp3;
using StoreManagementSystem;

namespace BuyingZone
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        SqlCommand cmd;SqlDataAdapter da;
        private bool validate(string name, string role)
        {
            try
            {
                con.Open();
                string query = "exec p_login @name , @role";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@role", role);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    int id = int.Parse(Convert.ToString(dt.Rows[0][0]));
                    Models.StaffInfo.Staff_Id = id;
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string name = UserNameTxt.Text; string pass = PasswordTxt.Text;
            string role = RoleCb.Text;
            if (name == "" || pass == "" || role == "" || role == "Select a Role")
            {
                Lblnotify.Text = "Fill complete information";
            }
            else if (name == "name" && pass == "1234")
            {
                 if (role == "Seller")
                {
                    Billing bil = new Billing();
                    bil.Show();
                Visible = false;
                    Models.StaffInfo.Staff_Id = 1;
                }
                else if (role == "Manager")
                {
                    Manager sf = new Manager();
                    this.Hide();
                    sf.Show();
                }
                if (role == "Supplier")
                {
                    SupplierForm sf = new SupplierForm();
                    this.Hide();
                    sf.Show();
                }
                else if (role == "Admin")
                {
                    AdminForm af = new AdminForm();
                    this.Hide();
                    af.Show();
                }
                else if (role == "Customer")
                {
                    Customer af = new Customer();
                    this.Hide();
                    af.Show();
                }

                else if (role == "HeadManager")
            {
                HM af = new HM();
                this.Hide();
                af.Show();
                }
                //MessageBox.Show("Login sucessfull");

            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
