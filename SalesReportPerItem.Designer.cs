namespace Assignment_4
{
    partial class SalesReportPerItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportPerItem));
            this.SaleStockGrid = new System.Windows.Forms.DataGridView();
            this.Small = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.large = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XLarge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockHeader = new System.Windows.Forms.Label();
            this.PriceHeader = new System.Windows.Forms.Label();
            this.NameDataGrid = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SaleStockGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SaleStockGrid
            // 
            this.SaleStockGrid.AllowUserToDeleteRows = false;
            this.SaleStockGrid.BackgroundColor = System.Drawing.Color.White;
            this.SaleStockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleStockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Small,
            this.Med,
            this.Regular,
            this.large,
            this.XLarge});
            this.SaleStockGrid.Location = new System.Drawing.Point(202, 151);
            this.SaleStockGrid.Name = "SaleStockGrid";
            this.SaleStockGrid.ReadOnly = true;
            this.SaleStockGrid.Size = new System.Drawing.Size(545, 333);
            this.SaleStockGrid.TabIndex = 0;
            this.SaleStockGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaleStockGrid_CellContentClick);
            // 
            // Small
            // 
            this.Small.HeaderText = "Small";
            this.Small.Name = "Small";
            this.Small.ReadOnly = true;
            // 
            // Med
            // 
            this.Med.HeaderText = "Medium";
            this.Med.Name = "Med";
            this.Med.ReadOnly = true;
            // 
            // Regular
            // 
            this.Regular.HeaderText = "Regular";
            this.Regular.Name = "Regular";
            this.Regular.ReadOnly = true;
            // 
            // large
            // 
            this.large.HeaderText = "Large";
            this.large.Name = "large";
            this.large.ReadOnly = true;
            // 
            // XLarge
            // 
            this.XLarge.HeaderText = "X-Large";
            this.XLarge.Name = "XLarge";
            this.XLarge.ReadOnly = true;
            // 
            // PriceDataGrid
            // 
            this.PriceDataGrid.AllowUserToDeleteRows = false;
            this.PriceDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.PriceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.PriceDataGrid.Location = new System.Drawing.Point(753, 151);
            this.PriceDataGrid.Name = "PriceDataGrid";
            this.PriceDataGrid.ReadOnly = true;
            this.PriceDataGrid.Size = new System.Drawing.Size(545, 333);
            this.PriceDataGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Small";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Medium";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Regular";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Large";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "X-Large";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // StockHeader
            // 
            this.StockHeader.AutoSize = true;
            this.StockHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockHeader.Location = new System.Drawing.Point(254, 121);
            this.StockHeader.Name = "StockHeader";
            this.StockHeader.Size = new System.Drawing.Size(417, 18);
            this.StockHeader.TabIndex = 2;
            this.StockHeader.Text = "Following are the tablular format for todays Bagel Sale";
            // 
            // PriceHeader
            // 
            this.PriceHeader.AutoSize = true;
            this.PriceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceHeader.Location = new System.Drawing.Point(783, 120);
            this.PriceHeader.Name = "PriceHeader";
            this.PriceHeader.Size = new System.Drawing.Size(461, 18);
            this.PriceHeader.TabIndex = 3;
            this.PriceHeader.Text = "Following are the tablular format for todays Bagel Sale Price\r\n";
            // 
            // NameDataGrid
            // 
            this.NameDataGrid.AllowUserToDeleteRows = false;
            this.NameDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.NameDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NameDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name});
            this.NameDataGrid.Location = new System.Drawing.Point(63, 151);
            this.NameDataGrid.Name = "NameDataGrid";
            this.NameDataGrid.ReadOnly = true;
            this.NameDataGrid.Size = new System.Drawing.Size(143, 333);
            this.NameDataGrid.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(1304, 451);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 33);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Close";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1091, 490);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(442, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // SalesReportPerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1443, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.NameDataGrid);
            this.Controls.Add(this.PriceHeader);
            this.Controls.Add(this.StockHeader);
            this.Controls.Add(this.PriceDataGrid);
            this.Controls.Add(this.SaleStockGrid);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            //this.Name = "SalesReportPerItem";
            this.Load += new System.EventHandler(this.SalesReportPerItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleStockGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SaleStockGrid;
        private System.Windows.Forms.DataGridView PriceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label StockHeader;
        private System.Windows.Forms.Label PriceHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Small;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regular;
        private System.Windows.Forms.DataGridViewTextBoxColumn large;
        private System.Windows.Forms.DataGridViewTextBoxColumn XLarge;
        private System.Windows.Forms.DataGridView NameDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}