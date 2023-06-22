
namespace StoreManagementSystem
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCust = new System.Windows.Forms.Button();
            this.manageSupplierbtn = new System.Windows.Forms.Button();
            this.SuppAudit = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnViewInventory = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.manageStaffBtn = new System.Windows.Forms.Button();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.BtnViewCategories = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 412);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Audit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(0, 145);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(166, 47);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(0, 92);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(166, 47);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // AboutPanel
            // 
            this.AboutPanel.Controls.Add(this.listBox1);
            this.AboutPanel.Location = new System.Drawing.Point(166, 1);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(601, 397);
            this.AboutPanel.TabIndex = 1;
            this.AboutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AboutPanel_Paint);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "",
            "This store provides a variety of products both in shop and online. ",
            "You can visit the shop or just order straight away by sitting at home. ",
            "For order you just have to download the application and we will ",
            "deliever at your place."});
            this.listBox1.Location = new System.Drawing.Point(42, 162);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(498, 213);
            this.listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(166, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 122);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "The Buying Zone";
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.label5);
            this.HomePanel.Controls.Add(this.btnCust);
            this.HomePanel.Controls.Add(this.manageSupplierbtn);
            this.HomePanel.Controls.Add(this.SuppAudit);
            this.HomePanel.Controls.Add(this.btnViewCustomers);
            this.HomePanel.Controls.Add(this.btnViewInventory);
            this.HomePanel.Controls.Add(this.btnSales);
            this.HomePanel.Controls.Add(this.manageStaffBtn);
            this.HomePanel.Controls.Add(this.btnViewProducts);
            this.HomePanel.Controls.Add(this.BtnViewCategories);
            this.HomePanel.Controls.Add(this.panel4);
            this.HomePanel.Location = new System.Drawing.Point(166, 1);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(607, 407);
            this.HomePanel.TabIndex = 2;
            this.HomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePanel_Paint_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(153, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reportings and Manage:";
            // 
            // btnCust
            // 
            this.btnCust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCust.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCust.ForeColor = System.Drawing.Color.Black;
            this.btnCust.Location = new System.Drawing.Point(411, 311);
            this.btnCust.Name = "btnCust";
            this.btnCust.Size = new System.Drawing.Size(161, 76);
            this.btnCust.TabIndex = 9;
            this.btnCust.Text = "View Customers";
            this.btnCust.UseVisualStyleBackColor = false;
            this.btnCust.Click += new System.EventHandler(this.btnCust_Click);
            // 
            // manageSupplierbtn
            // 
            this.manageSupplierbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.manageSupplierbtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSupplierbtn.ForeColor = System.Drawing.Color.Black;
            this.manageSupplierbtn.Location = new System.Drawing.Point(42, 216);
            this.manageSupplierbtn.Name = "manageSupplierbtn";
            this.manageSupplierbtn.Size = new System.Drawing.Size(188, 76);
            this.manageSupplierbtn.TabIndex = 8;
            this.manageSupplierbtn.Text = "Manage Suppliers";
            this.manageSupplierbtn.UseVisualStyleBackColor = false;
            this.manageSupplierbtn.Click += new System.EventHandler(this.manageSupplierbtn_Click);
            // 
            // SuppAudit
            // 
            this.SuppAudit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SuppAudit.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppAudit.ForeColor = System.Drawing.Color.Black;
            this.SuppAudit.Location = new System.Drawing.Point(236, 216);
            this.SuppAudit.Name = "SuppAudit";
            this.SuppAudit.Size = new System.Drawing.Size(169, 76);
            this.SuppAudit.TabIndex = 7;
            this.SuppAudit.Text = "View Supplies ";
            this.SuppAudit.UseVisualStyleBackColor = false;
            this.SuppAudit.Click += new System.EventHandler(this.SuppAudit_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewCustomers.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnViewCustomers.Location = new System.Drawing.Point(236, 125);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(169, 76);
            this.btnViewCustomers.TabIndex = 6;
            this.btnViewCustomers.Text = "Demand Inventory";
            this.btnViewCustomers.UseVisualStyleBackColor = false;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewInventory.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInventory.ForeColor = System.Drawing.Color.Black;
            this.btnViewInventory.Location = new System.Drawing.Point(42, 125);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(188, 76);
            this.btnViewInventory.TabIndex = 5;
            this.btnViewInventory.Text = "View/Manage Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = false;
            this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSales.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.Black;
            this.btnSales.Location = new System.Drawing.Point(411, 216);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(161, 76);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "View Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.button5_Click);
            // 
            // manageStaffBtn
            // 
            this.manageStaffBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.manageStaffBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStaffBtn.ForeColor = System.Drawing.Color.Black;
            this.manageStaffBtn.Location = new System.Drawing.Point(42, 311);
            this.manageStaffBtn.Name = "manageStaffBtn";
            this.manageStaffBtn.Size = new System.Drawing.Size(186, 76);
            this.manageStaffBtn.TabIndex = 3;
            this.manageStaffBtn.Text = "Manage/View Staff";
            this.manageStaffBtn.UseVisualStyleBackColor = false;
            this.manageStaffBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewProducts.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProducts.ForeColor = System.Drawing.Color.Black;
            this.btnViewProducts.Location = new System.Drawing.Point(238, 311);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(167, 76);
            this.btnViewProducts.TabIndex = 2;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = false;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // BtnViewCategories
            // 
            this.BtnViewCategories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnViewCategories.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewCategories.ForeColor = System.Drawing.Color.Black;
            this.BtnViewCategories.Location = new System.Drawing.Point(411, 125);
            this.BtnViewCategories.Name = "BtnViewCategories";
            this.BtnViewCategories.Size = new System.Drawing.Size(161, 76);
            this.BtnViewCategories.TabIndex = 1;
            this.BtnViewCategories.Text = "View Categories";
            this.BtnViewCategories.UseVisualStyleBackColor = false;
            this.BtnViewCategories.Click += new System.EventHandler(this.BtnViewCategories_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 70);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(141, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Store Management System";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.store_commercial_symbol1;
            this.pictureBox1.Location = new System.Drawing.Point(356, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 410);
            this.ControlBox = false;
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AboutPanel);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AboutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button manageStaffBtn;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button BtnViewCategories;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.Button manageSupplierbtn;
        private System.Windows.Forms.Button SuppAudit;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Button btnCust;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

