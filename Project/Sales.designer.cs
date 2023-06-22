
namespace TheBuyingZone
{
    partial class Sales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYearlySales = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewChart = new System.Windows.Forms.Button();
            this.PanelViewSales = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SalesBarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.PanelViewSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBarChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnYearlySales);
            this.panel1.Controls.Add(this.btnViewSales);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnViewChart);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 449);
            this.panel1.TabIndex = 3;
            // 
            // btnYearlySales
            // 
            this.btnYearlySales.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearlySales.Location = new System.Drawing.Point(0, 127);
            this.btnYearlySales.Name = "btnYearlySales";
            this.btnYearlySales.Size = new System.Drawing.Size(174, 47);
            this.btnYearlySales.TabIndex = 5;
            this.btnYearlySales.Text = "Yearly Sales";
            this.btnYearlySales.UseVisualStyleBackColor = true;
            this.btnYearlySales.Click += new System.EventHandler(this.btnYearlySales_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSales.Location = new System.Drawing.Point(0, 74);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(174, 47);
            this.btnViewSales.TabIndex = 4;
            this.btnViewSales.Text = "Sales";
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(174, 50);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewChart
            // 
            this.btnViewChart.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewChart.Location = new System.Drawing.Point(0, 180);
            this.btnViewChart.Name = "btnViewChart";
            this.btnViewChart.Size = new System.Drawing.Size(174, 47);
            this.btnViewChart.TabIndex = 1;
            this.btnViewChart.Text = "Yearly Sales Chart";
            this.btnViewChart.UseVisualStyleBackColor = true;
            this.btnViewChart.Click += new System.EventHandler(this.btnViewChart_Click);
            // 
            // PanelViewSales
            // 
            this.PanelViewSales.BackColor = System.Drawing.Color.White;
            this.PanelViewSales.Controls.Add(this.SalesBarChart);
            this.PanelViewSales.Controls.Add(this.dataGridView1);
            this.PanelViewSales.Controls.Add(this.panel4);
            this.PanelViewSales.Location = new System.Drawing.Point(183, 2);
            this.PanelViewSales.Name = "PanelViewSales";
            this.PanelViewSales.Size = new System.Drawing.Size(634, 446);
            this.PanelViewSales.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(570, 351);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(0, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 61);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yearly Sales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Chart";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(242, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 43);
            this.label14.TabIndex = 1;
            this.label14.Text = "Sales";
            // 
            // SalesBarChart
            // 
            chartArea1.Name = "ChartArea1";
            this.SalesBarChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SalesBarChart.Legends.Add(legend1);
            this.SalesBarChart.Location = new System.Drawing.Point(13, 74);
            this.SalesBarChart.Name = "SalesBarChart";
            this.SalesBarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "TotalAmount";
            this.SalesBarChart.Series.Add(series1);
            this.SalesBarChart.Size = new System.Drawing.Size(592, 369);
            this.SalesBarChart.TabIndex = 8;
            this.SalesBarChart.Text = "chart1";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelViewSales);
            this.Controls.Add(this.panel1);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.panel1.ResumeLayout(false);
            this.PanelViewSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBarChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnYearlySales;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewChart;
        private System.Windows.Forms.Panel PanelViewSales;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesBarChart;
    }
}