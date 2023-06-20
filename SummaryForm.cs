using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void ExitSummaryBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            try
            {
                // will calculate all the details for summary
                TNBOut.Text = MyBagelShopApplication.SumTotalNumberOfBagleSold.ToString("N0");
                TSVOut.Text = MyBagelShopApplication.SumTotalSalesValue.ToString("C", new CultureInfo("en-GB"));
                TNTOut.Text = MyBagelShopApplication.SumTotalNumTransaction.ToString("N0");
                AVDOut.Text = (MyBagelShopApplication.SumTotalSalesValue / MyBagelShopApplication.SumTotalNumTransaction).ToString("C", new CultureInfo("en-GB"));
            }
            catch
            {
                MessageBox.Show("Zero Order Had Placed Today" ,"Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
