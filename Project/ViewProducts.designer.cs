
namespace StoreManagementSystem
{
    partial class ViewProducts
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
            this.btnExpiredprods = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCategoryWise = new System.Windows.Forms.Button();
            this.btnAllProducts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelExpiredandAll = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVProducts = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelExpiredandAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnExpiredprods);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnCategoryWise);
            this.panel1.Controls.Add(this.btnAllProducts);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 418);
            this.panel1.TabIndex = 3;
            // 
            // btnExpiredprods
            // 
            this.btnExpiredprods.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpiredprods.Location = new System.Drawing.Point(0, 199);
            this.btnExpiredprods.Name = "btnExpiredprods";
            this.btnExpiredprods.Size = new System.Drawing.Size(169, 57);
            this.btnExpiredprods.TabIndex = 4;
            this.btnExpiredprods.Text = "Product Quantity in Inventory";
            this.btnExpiredprods.UseVisualStyleBackColor = true;
            this.btnExpiredprods.Click += new System.EventHandler(this.btnExpiredprods_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(169, 47);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCategoryWise
            // 
            this.btnCategoryWise.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryWise.Location = new System.Drawing.Point(0, 136);
            this.btnCategoryWise.Name = "btnCategoryWise";
            this.btnCategoryWise.Size = new System.Drawing.Size(169, 57);
            this.btnCategoryWise.TabIndex = 2;
            this.btnCategoryWise.Text = "Category Wise Products";
            this.btnCategoryWise.UseVisualStyleBackColor = true;
            this.btnCategoryWise.Click += new System.EventHandler(this.btnCategoryWise_Click);
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllProducts.Location = new System.Drawing.Point(0, 74);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(169, 57);
            this.btnAllProducts.TabIndex = 1;
            this.btnAllProducts.Text = "All Products";
            this.btnAllProducts.UseVisualStyleBackColor = true;
            this.btnAllProducts.Click += new System.EventHandler(this.btnAllProducts_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(167, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 58);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(148, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 43);
            this.label4.TabIndex = 1;
            this.label4.Text = "Products";
            // 
            // panelExpiredandAll
            // 
            this.panelExpiredandAll.Controls.Add(this.cbCategory);
            this.panelExpiredandAll.Controls.Add(this.label1);
            this.panelExpiredandAll.Controls.Add(this.DGVProducts);
            this.panelExpiredandAll.Location = new System.Drawing.Point(167, 64);
            this.panelExpiredandAll.Name = "panelExpiredandAll";
            this.panelExpiredandAll.Size = new System.Drawing.Size(496, 354);
            this.panelExpiredandAll.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(187, 7);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(216, 33);
            this.cbCategory.TabIndex = 8;
            this.cbCategory.Text = "Select Category";
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(83, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGVProducts
            // 
            this.DGVProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVProducts.BackgroundColor = System.Drawing.Color.White;
            this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProducts.Location = new System.Drawing.Point(8, 46);
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.ReadOnly = true;
            this.DGVProducts.Size = new System.Drawing.Size(475, 296);
            this.DGVProducts.TabIndex = 6;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 418);
            this.ControlBox = false;
            this.Controls.Add(this.panelExpiredandAll);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products View";
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelExpiredandAll.ResumeLayout(false);
            this.panelExpiredandAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExpiredprods;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCategoryWise;
        private System.Windows.Forms.Button btnAllProducts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelExpiredandAll;
        private System.Windows.Forms.DataGridView DGVProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}