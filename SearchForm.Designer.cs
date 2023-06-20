namespace Assignment_4
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.TransactionIDRadioBtn = new System.Windows.Forms.RadioButton();
            this.RadioBtnGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearSearchBtn = new System.Windows.Forms.Button();
            this.SubmitSearchBtn = new System.Windows.Forms.Button();
            this.SearchInputTextBox = new System.Windows.Forms.TextBox();
            this.DateRadioBtn = new System.Windows.Forms.RadioButton();
            this.ExitSearchBtn = new System.Windows.Forms.Button();
            this.SearchListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchFormSearchToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearSearchtoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchExittoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RadioBtnGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionIDRadioBtn
            // 
            this.TransactionIDRadioBtn.AutoSize = true;
            this.TransactionIDRadioBtn.Location = new System.Drawing.Point(25, 44);
            this.TransactionIDRadioBtn.Name = "TransactionIDRadioBtn";
            this.TransactionIDRadioBtn.Size = new System.Drawing.Size(133, 22);
            this.TransactionIDRadioBtn.TabIndex = 0;
            this.TransactionIDRadioBtn.TabStop = true;
            this.TransactionIDRadioBtn.Text = "Transaction Id";
            this.TransactionIDRadioBtn.UseVisualStyleBackColor = true;
            // 
            // RadioBtnGroupBox
            // 
            this.RadioBtnGroupBox.Controls.Add(this.ClearSearchBtn);
            this.RadioBtnGroupBox.Controls.Add(this.SubmitSearchBtn);
            this.RadioBtnGroupBox.Controls.Add(this.SearchInputTextBox);
            this.RadioBtnGroupBox.Controls.Add(this.DateRadioBtn);
            this.RadioBtnGroupBox.Controls.Add(this.TransactionIDRadioBtn);
            this.RadioBtnGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnGroupBox.Location = new System.Drawing.Point(84, 132);
            this.RadioBtnGroupBox.Name = "RadioBtnGroupBox";
            this.RadioBtnGroupBox.Size = new System.Drawing.Size(208, 283);
            this.RadioBtnGroupBox.TabIndex = 1;
            this.RadioBtnGroupBox.TabStop = false;
            this.RadioBtnGroupBox.Text = "Search Btn";
            // 
            // ClearSearchBtn
            // 
            this.ClearSearchBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClearSearchBtn.Location = new System.Drawing.Point(26, 229);
            this.ClearSearchBtn.Name = "ClearSearchBtn";
            this.ClearSearchBtn.Size = new System.Drawing.Size(132, 38);
            this.ClearSearchBtn.TabIndex = 4;
            this.ClearSearchBtn.Text = "Clear";
            this.ClearSearchtoolTip.SetToolTip(this.ClearSearchBtn, "Click To Clear Search Item and ListBox");
            this.ClearSearchBtn.UseVisualStyleBackColor = false;
            this.ClearSearchBtn.Click += new System.EventHandler(this.ClearSearchBtn_Click);
            // 
            // SubmitSearchBtn
            // 
            this.SubmitSearchBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.SubmitSearchBtn.Location = new System.Drawing.Point(26, 183);
            this.SubmitSearchBtn.Name = "SubmitSearchBtn";
            this.SubmitSearchBtn.Size = new System.Drawing.Size(133, 40);
            this.SubmitSearchBtn.TabIndex = 3;
            this.SubmitSearchBtn.Text = "Search";
            this.SearchFormSearchToolTip.SetToolTip(this.SubmitSearchBtn, "Click To Search Transaction Using Date or ID");
            this.SubmitSearchBtn.UseVisualStyleBackColor = false;
            this.SubmitSearchBtn.Click += new System.EventHandler(this.SubmitSearchBtn_Click);
            // 
            // SearchInputTextBox
            // 
            this.SearchInputTextBox.Location = new System.Drawing.Point(26, 129);
            this.SearchInputTextBox.Name = "SearchInputTextBox";
            this.SearchInputTextBox.Size = new System.Drawing.Size(133, 24);
            this.SearchInputTextBox.TabIndex = 2;
            this.SearchInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DateRadioBtn
            // 
            this.DateRadioBtn.AutoSize = true;
            this.DateRadioBtn.Location = new System.Drawing.Point(25, 72);
            this.DateRadioBtn.Name = "DateRadioBtn";
            this.DateRadioBtn.Size = new System.Drawing.Size(177, 22);
            this.DateRadioBtn.TabIndex = 1;
            this.DateRadioBtn.TabStop = true;
            this.DateRadioBtn.Text = "Date(MM-DD-YYYY)";
            this.DateRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ExitSearchBtn
            // 
            this.ExitSearchBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.ExitSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitSearchBtn.Location = new System.Drawing.Point(651, 371);
            this.ExitSearchBtn.Name = "ExitSearchBtn";
            this.ExitSearchBtn.Size = new System.Drawing.Size(135, 44);
            this.ExitSearchBtn.TabIndex = 5;
            this.ExitSearchBtn.Text = "Exit";
            this.SearchExittoolTip.SetToolTip(this.ExitSearchBtn, "Click To Exit This Window");
            this.ExitSearchBtn.UseVisualStyleBackColor = false;
            this.ExitSearchBtn.Click += new System.EventHandler(this.ExitSearchBtn_Click);
            // 
            // SearchListBox
            // 
            this.SearchListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchListBox.FormattingEnabled = true;
            this.SearchListBox.ItemHeight = 18;
            this.SearchListBox.Location = new System.Drawing.Point(316, 145);
            this.SearchListBox.Name = "SearchListBox";
            this.SearchListBox.Size = new System.Drawing.Size(470, 220);
            this.SearchListBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(607, 421);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(442, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // SearchFormSearchToolTip
            // 
            this.SearchFormSearchToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SearchFormSearchToolTip.ToolTipTitle = "Info";
            // 
            // ClearSearchtoolTip
            // 
            this.ClearSearchtoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ClearSearchtoolTip.ToolTipTitle = "Info";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 594);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchListBox);
            this.Controls.Add(this.ExitSearchBtn);
            this.Controls.Add(this.RadioBtnGroupBox);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "SearchForm - MyBagelShopApplication";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.RadioBtnGroupBox.ResumeLayout(false);
            this.RadioBtnGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton TransactionIDRadioBtn;
        private System.Windows.Forms.GroupBox RadioBtnGroupBox;
        private System.Windows.Forms.Button ClearSearchBtn;
        private System.Windows.Forms.Button SubmitSearchBtn;
        private System.Windows.Forms.TextBox SearchInputTextBox;
        private System.Windows.Forms.RadioButton DateRadioBtn;
        private System.Windows.Forms.Button ExitSearchBtn;
        private System.Windows.Forms.ListBox SearchListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip SearchFormSearchToolTip;
        private System.Windows.Forms.ToolTip ClearSearchtoolTip;
        private System.Windows.Forms.ToolTip SearchExittoolTip;
    }
}