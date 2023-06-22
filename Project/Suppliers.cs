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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
            AddData();
        }

        SqlConnection con = new SqlConnection(@"Data Source=AREEBA-KABIR\AREEBAKABIR;Initial Catalog=StoreDB;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void insert()
        {
            if (NameTxt.Text == "" || contactTxt.Text == "" || emailtxt.Text == "")
            {
                MessageBox.Show("Missing information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddSupplier", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "insert");
                    cmd.Parameters.AddWithValue("@id", 1);
                    cmd.Parameters.AddWithValue("@name", NameTxt.Text);
                    cmd.Parameters.AddWithValue("@contact", contactTxt.Text);
                    cmd.Parameters.AddWithValue("@email", emailtxt.Text);
                    int numRes = cmd.ExecuteNonQuery();
                    con.Close();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Inserted Successfully !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (NameTxt.Text == "" || contactTxt.Text == "" || emailtxt.Text == "")
            {
                MessageBox.Show("Missing information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddSupplier", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "delete");
                    cmd.Parameters.AddWithValue("@id", DGVSupplier.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@name", NameTxt.Text);
                    cmd.Parameters.AddWithValue("@contact", contactTxt.Text);
                    cmd.Parameters.AddWithValue("@email", emailtxt.Text);
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

        private void AddData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getSupplier", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVSupplier.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }
        private void update()
        {
            if (NameTxt.Text == "" || contactTxt.Text == "" || emailtxt.Text == "")
            {
                MessageBox.Show("Missing information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddSupplier", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "update");
                    cmd.Parameters.AddWithValue("@id", DGVSupplier.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@name", NameTxt.Text);
                    cmd.Parameters.AddWithValue("@contact", contactTxt.Text);
                    cmd.Parameters.AddWithValue("@email", emailtxt.Text);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void clear()
        {
            contactTxt.Clear();
            NameTxt.Clear();
            emailtxt.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void DGVSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTxt.Text = DGVSupplier.SelectedRows[0].Cells[1].Value.ToString();
            contactTxt.Text = DGVSupplier.SelectedRows[0].Cells[2].Value.ToString();
            emailtxt.Text = DGVSupplier.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
                    }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminForm aform = new AdminForm();
            this.Hide();
            aform.Show();
        }
    }
}
