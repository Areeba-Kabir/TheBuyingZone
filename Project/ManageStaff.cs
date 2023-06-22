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
using TheBuyingZone;
using StoreManagementSystem;

namespace StoreManagementSystem
{
    public partial class ManageStaff : Form
    {
        public ManageStaff()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");
        string query;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            if (fnametxt.Text == "" || txtemail.Text == "" || lnametxt.Text == "" || txtcity.Text == "" || txtcontact.Text == "" || cbRole.Text == "" || cbRole.Text == "Select Role")
            {
                MessageBox.Show("Missing Info!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("staffproc", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "insert");
                    cmd.Parameters.AddWithValue("@id", 1);
                    cmd.Parameters.AddWithValue("@fname", fnametxt.Text);
                    cmd.Parameters.AddWithValue("@lname", lnametxt.Text);
                    cmd.Parameters.AddWithValue("@role", cbRole.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@address", txtcity.Text);
                    cmd.Parameters.AddWithValue("@cont", txtcontact.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    AddData();
                    Clear();
                }
                catch (Exception excep)
                {
                    MessageBox.Show("Insertion Failed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void AddData()
        {
            con.Open();
            query = "select * from Staff";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {
            panelManageStaff.Show();
            PanelViewStaff.Hide();
            AddData();
        }

        private void DGVStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Delete()
        {
            try
            {
                if (fnametxt.Text == "" || txtemail.Text == "" || lnametxt.Text == "" || txtcity.Text == "" || txtcontact.Text == "" || cbRole.Text == "")
                {
                    MessageBox.Show("Select Staff to Delete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("staffproc", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "delete");
                    cmd.Parameters.AddWithValue("@id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@fname", fnametxt.Text);
                    cmd.Parameters.AddWithValue("@lname", lnametxt.Text);
                    cmd.Parameters.AddWithValue("@role", cbRole.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@address", txtcity.Text);
                    cmd.Parameters.AddWithValue("@cont", txtcontact.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    AddData();
                    Clear();
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Staff Deletion Failed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Update()
        {
            try
            {
                if (fnametxt.Text == "" || txtemail.Text == "" || lnametxt.Text == "" || txtcity.Text == "" || txtcontact.Text == "" || cbRole.Text == "")
                {
                    MessageBox.Show("Missing Info!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("staffproc", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "update");
                    cmd.Parameters.AddWithValue("@id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@fname", fnametxt.Text);
                    cmd.Parameters.AddWithValue("@lname", lnametxt.Text);
                    cmd.Parameters.AddWithValue("@role", cbRole.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@address", txtcity.Text);
                    cmd.Parameters.AddWithValue("@cont", txtcontact.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    AddData();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Staff Updation Failed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Clear()
        {
            fnametxt.Text = "";
            txtemail.Text = "";
            lnametxt.Text = "";
            txtcity.Text = "";
            txtcontact.Text = "";
            cbRole.Text = "Select Role";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm aform = new AdminForm();
            this.Hide();
            aform.Show();
        }

        private void managestaffbtn_Click(object sender, EventArgs e)
        {
            panelManageStaff.Show();
            PanelViewStaff.Hide();
        }

        private void DGVStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fnametxt.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            txtemail.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            lnametxt.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            txtcity.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            txtcontact.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            cbRole.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnViewSellers_Click(object sender, EventArgs e)
        {

        }
        //private void RolesCB()
        //{
        //    con.Open();
        //    query = "Select distinct Role from Staff";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    SqlDataReader rdr;
        //    rdr = cmd.ExecuteReader();
        //    DataTable tbl = new DataTable();
        //    tbl.Columns.Add("Role", typeof(string));
        //    tbl.Load(rdr);
        //    CbStaff.ValueMember = "Role";
        //    CbStaff.DataSource = tbl;
        //    con.Close();
        //}

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            panelManageStaff.Hide();
            PanelViewStaff.Show();
            label8.Hide();
            CbStaff.Hide();
            AddStaffData();
        }

        private void AddStaffData()
        {
            con.Open();
            query = "select * from Staffview";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void CbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbStaff.Text == "Select Role")
            {
                MessageBox.Show("Select Role!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                staff123();
            }
        }

        private void staff123()
        {
            query = "select * from Staffview where role = '" + CbStaff.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void PanelViewStaff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnrolewise_Click(object sender, EventArgs e)
        {
            panelManageStaff.Hide();
            PanelViewStaff.Show();
            label8.Show();
            CbStaff.Show();
            staff123();
            //RolesCB();
        }
    }
}
