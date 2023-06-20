namespace Assignment_4
{
    partial class MyBagelShopApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBagelShopApplication));
            this.BagleNameListBox = new System.Windows.Forms.ListBox();
            this.BagleSizeListBox = new System.Windows.Forms.ListBox();
            this.BagleOrderGB = new System.Windows.Forms.GroupBox();
            this.PriceTextbox = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayListView = new System.Windows.Forms.ListView();
            this.BagleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BagleSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BagleQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BaglePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceOutLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.MakeOrderBtn = new System.Windows.Forms.Button();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.OrderClearBtn = new System.Windows.Forms.Button();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.BagleSizeLabel = new System.Windows.Forms.Label();
            this.BagleNameHeader = new System.Windows.Forms.Label();
            this.SearchBtnForm = new System.Windows.Forms.Button();
            this.ButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.SalePerItemBtn = new System.Windows.Forms.Button();
            this.GenerateReportBtn = new System.Windows.Forms.Button();
            this.SummaryBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddToCarttoolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CleartoolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.searchtoolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SummarytoolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SalesReporttoolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GReporttoolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OrdertoolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BagleOrderGB.SuspendLayout();
            this.ButtonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BagleNameListBox
            // 
            this.BagleNameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagleNameListBox.FormattingEnabled = true;
            this.BagleNameListBox.ItemHeight = 18;
            this.BagleNameListBox.Location = new System.Drawing.Point(19, 41);
            this.BagleNameListBox.Name = "BagleNameListBox";
            this.BagleNameListBox.Size = new System.Drawing.Size(234, 256);
            this.BagleNameListBox.TabIndex = 1;
            this.BagleNameListBox.SelectedIndexChanged += new System.EventHandler(this.BagleNameListBox_SelectedIndexChanged);
            // 
            // BagleSizeListBox
            // 
            this.BagleSizeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagleSizeListBox.FormattingEnabled = true;
            this.BagleSizeListBox.ItemHeight = 18;
            this.BagleSizeListBox.Location = new System.Drawing.Point(288, 41);
            this.BagleSizeListBox.Name = "BagleSizeListBox";
            this.BagleSizeListBox.Size = new System.Drawing.Size(148, 94);
            this.BagleSizeListBox.TabIndex = 2;
            this.BagleSizeListBox.SelectedIndexChanged += new System.EventHandler(this.BagleSizeListBox_SelectedIndexChanged);
            // 
            // BagleOrderGB
            // 
            this.BagleOrderGB.Controls.Add(this.PriceTextbox);
            this.BagleOrderGB.Controls.Add(this.PriceLabel);
            this.BagleOrderGB.Controls.Add(this.label1);
            this.BagleOrderGB.Controls.Add(this.DisplayListView);
            this.BagleOrderGB.Controls.Add(this.TotalPriceOutLabel);
            this.BagleOrderGB.Controls.Add(this.TotalPriceLabel);
            this.BagleOrderGB.Controls.Add(this.MakeOrderBtn);
            this.BagleOrderGB.Controls.Add(this.QuantityTextBox);
            this.BagleOrderGB.Controls.Add(this.OrderClearBtn);
            this.BagleOrderGB.Controls.Add(this.AddToCartBtn);
            this.BagleOrderGB.Controls.Add(this.BagleSizeLabel);
            this.BagleOrderGB.Controls.Add(this.BagleNameHeader);
            this.BagleOrderGB.Controls.Add(this.BagleSizeListBox);
            this.BagleOrderGB.Controls.Add(this.BagleNameListBox);
            this.BagleOrderGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagleOrderGB.Location = new System.Drawing.Point(80, 144);
            this.BagleOrderGB.Name = "BagleOrderGB";
            this.BagleOrderGB.Size = new System.Drawing.Size(1011, 314);
            this.BagleOrderGB.TabIndex = 3;
            this.BagleOrderGB.TabStop = false;
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.AutoSize = true;
            this.PriceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextbox.Location = new System.Drawing.Point(382, 190);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(59, 20);
            this.PriceTextbox.TabIndex = 21;
            this.PriceTextbox.Text = "£ 0.00";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(287, 190);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(57, 18);
            this.PriceLabel.TabIndex = 20;
            this.PriceLabel.Text = "Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quantity:";
            // 
            // DisplayListView
            // 
            this.DisplayListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BagleName,
            this.BagleSize,
            this.BagleQuantity,
            this.BaglePrice});
            this.DisplayListView.HideSelection = false;
            this.DisplayListView.Location = new System.Drawing.Point(469, 23);
            this.DisplayListView.Name = "DisplayListView";
            this.DisplayListView.Size = new System.Drawing.Size(526, 230);
            this.DisplayListView.TabIndex = 6;
            this.DisplayListView.Tag = "NoClick";
            this.DisplayListView.UseCompatibleStateImageBehavior = false;
            this.DisplayListView.View = System.Windows.Forms.View.Details;
            // 
            // BagleName
            // 
            this.BagleName.Text = "Bagel_Name";
            this.BagleName.Width = 240;
            // 
            // BagleSize
            // 
            this.BagleSize.Text = "Size";
            this.BagleSize.Width = 100;
            // 
            // BagleQuantity
            // 
            this.BagleQuantity.Text = "Quantity";
            this.BagleQuantity.Width = 90;
            // 
            // BaglePrice
            // 
            this.BaglePrice.Text = "Price";
            this.BaglePrice.Width = 90;
            // 
            // TotalPriceOutLabel
            // 
            this.TotalPriceOutLabel.AutoSize = true;
            this.TotalPriceOutLabel.BackColor = System.Drawing.Color.Thistle;
            this.TotalPriceOutLabel.Location = new System.Drawing.Point(653, 265);
            this.TotalPriceOutLabel.MinimumSize = new System.Drawing.Size(200, 32);
            this.TotalPriceOutLabel.Name = "TotalPriceOutLabel";
            this.TotalPriceOutLabel.Size = new System.Drawing.Size(200, 32);
            this.TotalPriceOutLabel.TabIndex = 17;
            this.TotalPriceOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(472, 271);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(180, 18);
            this.TotalPriceLabel.TabIndex = 16;
            this.TotalPriceLabel.Text = "Total Price For Order -";
            // 
            // MakeOrderBtn
            // 
            this.MakeOrderBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.MakeOrderBtn.Location = new System.Drawing.Point(860, 259);
            this.MakeOrderBtn.Name = "MakeOrderBtn";
            this.MakeOrderBtn.Size = new System.Drawing.Size(135, 43);
            this.MakeOrderBtn.TabIndex = 6;
            this.MakeOrderBtn.Text = "Make &Order";
            this.OrdertoolTip1.SetToolTip(this.MakeOrderBtn, "Click to proceed to Complete the Order");
            this.MakeOrderBtn.UseVisualStyleBackColor = false;
            this.MakeOrderBtn.Click += new System.EventHandler(this.MakeOrderBtn_Click);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(367, 220);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(85, 24);
            this.QuantityTextBox.TabIndex = 10;
            this.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderClearBtn
            // 
            this.OrderClearBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.OrderClearBtn.Location = new System.Drawing.Point(381, 261);
            this.OrderClearBtn.Name = "OrderClearBtn";
            this.OrderClearBtn.Size = new System.Drawing.Size(85, 36);
            this.OrderClearBtn.TabIndex = 9;
            this.OrderClearBtn.Text = "&Clear";
            this.CleartoolTip1.SetToolTip(this.OrderClearBtn, "Click to clear the selected options");
            this.OrderClearBtn.UseVisualStyleBackColor = false;
            this.OrderClearBtn.Click += new System.EventHandler(this.OrderClearBtn_Click);
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.AddToCartBtn.Location = new System.Drawing.Point(259, 262);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(116, 36);
            this.AddToCartBtn.TabIndex = 5;
            this.AddToCartBtn.Text = "&Add To Cart";
            this.AddToCarttoolTip1.SetToolTip(this.AddToCartBtn, "Cick to add items to the cart");
            this.AddToCartBtn.UseVisualStyleBackColor = false;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // BagleSizeLabel
            // 
            this.BagleSizeLabel.AutoSize = true;
            this.BagleSizeLabel.Location = new System.Drawing.Point(315, 20);
            this.BagleSizeLabel.Name = "BagleSizeLabel";
            this.BagleSizeLabel.Size = new System.Drawing.Size(88, 18);
            this.BagleSizeLabel.TabIndex = 4;
            this.BagleSizeLabel.Text = "Bagel Size";
            this.BagleSizeLabel.Click += new System.EventHandler(this.BagleSizeLabel_Click);
            // 
            // BagleNameHeader
            // 
            this.BagleNameHeader.AutoSize = true;
            this.BagleNameHeader.Location = new System.Drawing.Point(69, 20);
            this.BagleNameHeader.Name = "BagleNameHeader";
            this.BagleNameHeader.Size = new System.Drawing.Size(99, 18);
            this.BagleNameHeader.TabIndex = 3;
            this.BagleNameHeader.Text = "Bagel Name";
            // 
            // SearchBtnForm
            // 
            this.SearchBtnForm.BackColor = System.Drawing.Color.LavenderBlush;
            this.SearchBtnForm.Location = new System.Drawing.Point(37, 33);
            this.SearchBtnForm.Name = "SearchBtnForm";
            this.SearchBtnForm.Size = new System.Drawing.Size(170, 50);
            this.SearchBtnForm.TabIndex = 4;
            this.SearchBtnForm.Text = "&Search";
            this.searchtoolTip1.SetToolTip(this.SearchBtnForm, "Click to naviagte to search window");
            this.SearchBtnForm.UseVisualStyleBackColor = false;
            this.SearchBtnForm.Click += new System.EventHandler(this.SearchBtnForm_Click);
            // 
            // ButtonsGroupBox
            // 
            this.ButtonsGroupBox.BackColor = System.Drawing.Color.White;
            this.ButtonsGroupBox.Controls.Add(this.SalePerItemBtn);
            this.ButtonsGroupBox.Controls.Add(this.GenerateReportBtn);
            this.ButtonsGroupBox.Controls.Add(this.SummaryBtn);
            this.ButtonsGroupBox.Controls.Add(this.SearchBtnForm);
            this.ButtonsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonsGroupBox.Location = new System.Drawing.Point(152, 491);
            this.ButtonsGroupBox.Name = "ButtonsGroupBox";
            this.ButtonsGroupBox.Size = new System.Drawing.Size(873, 100);
            this.ButtonsGroupBox.TabIndex = 5;
            this.ButtonsGroupBox.TabStop = false;
            // 
            // SalePerItemBtn
            // 
            this.SalePerItemBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.SalePerItemBtn.Location = new System.Drawing.Point(454, 33);
            this.SalePerItemBtn.Name = "SalePerItemBtn";
            this.SalePerItemBtn.Size = new System.Drawing.Size(170, 50);
            this.SalePerItemBtn.TabIndex = 7;
            this.SalePerItemBtn.Text = "Sales &Report";
            this.SalesReporttoolTip1.SetToolTip(this.SalePerItemBtn, "Click to Generate the Sales Report");
            this.SalePerItemBtn.UseVisualStyleBackColor = false;
            this.SalePerItemBtn.Click += new System.EventHandler(this.SalePerItemBtn_Click);
            // 
            // GenerateReportBtn
            // 
            this.GenerateReportBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.GenerateReportBtn.Location = new System.Drawing.Point(657, 33);
            this.GenerateReportBtn.Name = "GenerateReportBtn";
            this.GenerateReportBtn.Size = new System.Drawing.Size(170, 50);
            this.GenerateReportBtn.TabIndex = 6;
            this.GenerateReportBtn.Text = "&Generate Report";
            this.GReporttoolTip1.SetToolTip(this.GenerateReportBtn, "Click to navigate to Stock Report");
            this.GenerateReportBtn.UseVisualStyleBackColor = false;
            this.GenerateReportBtn.Click += new System.EventHandler(this.GenerateReportBtn_Click);
            // 
            // SummaryBtn
            // 
            this.SummaryBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.SummaryBtn.Location = new System.Drawing.Point(246, 33);
            this.SummaryBtn.Name = "SummaryBtn";
            this.SummaryBtn.Size = new System.Drawing.Size(170, 50);
            this.SummaryBtn.TabIndex = 5;
            this.SummaryBtn.Text = "S&ummary";
            this.SummarytoolTip1.SetToolTip(this.SummaryBtn, "Click to naviagte to summary window");
            this.SummaryBtn.UseVisualStyleBackColor = false;
            this.SummaryBtn.Click += new System.EventHandler(this.SummaryBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(35)))), ((int)(((byte)(104)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(35)))), ((int)(((byte)(104)))));
            this.panel1.Location = new System.Drawing.Point(83, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 21);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(994, 477);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(532, 257);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddToCarttoolTip1
            // 
            this.AddToCarttoolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.AddToCarttoolTip1.ToolTipTitle = "Info";
            // 
            // CleartoolTip1
            // 
            this.CleartoolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CleartoolTip1.ToolTipTitle = "Info";
            // 
            // searchtoolTip1
            // 
            this.searchtoolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.searchtoolTip1.ToolTipTitle = "Info";
            // 
            // SummarytoolTip1
            // 
            this.SummarytoolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SummarytoolTip1.ToolTipTitle = "Info";
            // 
            // SalesReporttoolTip1
            // 
            this.SalesReporttoolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SalesReporttoolTip1.ToolTipTitle = "Info";
            // 
            // GReporttoolTip1
            // 
            this.GReporttoolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.GReporttoolTip1.ToolTipTitle = "Info";
            // 
            // OrdertoolTip1
            // 
            this.OrdertoolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.OrdertoolTip1.ToolTipTitle = "Info";
            // 
            // MyBagelShopApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 733);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonsGroupBox);
            this.Controls.Add(this.BagleOrderGB);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBagelShopApplication";
            this.Text = "MyBagelShop - Application";
            this.Load += new System.EventHandler(this.MyBagelShopApplication_Load);
            this.BagleOrderGB.ResumeLayout(false);
            this.BagleOrderGB.PerformLayout();
            this.ButtonsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox BagleNameListBox;
        private System.Windows.Forms.ListBox BagleSizeListBox;
        private System.Windows.Forms.GroupBox BagleOrderGB;
        private System.Windows.Forms.Button MakeOrderBtn;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.Label BagleSizeLabel;
        private System.Windows.Forms.Label BagleNameHeader;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button OrderClearBtn;
        private System.Windows.Forms.Label TotalPriceOutLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Button SearchBtnForm;
        private System.Windows.Forms.GroupBox ButtonsGroupBox;
        private System.Windows.Forms.Button SummaryBtn;
        private System.Windows.Forms.Button GenerateReportBtn;
        private System.Windows.Forms.ListView DisplayListView;
        private System.Windows.Forms.ColumnHeader BagleName;
        private System.Windows.Forms.ColumnHeader BagleSize;
        private System.Windows.Forms.ColumnHeader BagleQuantity;
        private System.Windows.Forms.ColumnHeader BaglePrice;
        private System.Windows.Forms.Button SalePerItemBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip OrdertoolTip1;
        private System.Windows.Forms.ToolTip CleartoolTip1;
        private System.Windows.Forms.ToolTip AddToCarttoolTip1;
        private System.Windows.Forms.ToolTip searchtoolTip1;
        private System.Windows.Forms.ToolTip SalesReporttoolTip1;
        private System.Windows.Forms.ToolTip GReporttoolTip1;
        private System.Windows.Forms.ToolTip SummarytoolTip1;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label PriceTextbox;
    }
}

