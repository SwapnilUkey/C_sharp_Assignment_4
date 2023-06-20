using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class SearchForm : Form
    {
        string DirLocation = System.AppDomain.CurrentDomain.BaseDirectory;
        const string Complete_Order_Report = "Complete_Order_Report.txt";
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            SearchInputTextBox.Focus();
        }

        private void ExitSearchBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SearchViaTransaction(string SearchItem)
        {
            try
            {
                // 
                string FileLoaction = Path.Combine(DirLocation, Complete_Order_Report);
                string[] Record, AllRecords;
                AllRecords = File.ReadAllLines(FileLoaction);
                bool RecordPresent = false;
                for (int row = 0; row < AllRecords.Length; row++)
                {
                    Record = AllRecords[row].Split(',');
                    if (SearchItem == Record[0])
                    {
                        RecordPresent = true;
                        SearchListBox.Items.Add("------------------------------");
                        SearchListBox.Items.Add("Transaction Id :  " + Record[0]);
                        SearchListBox.Items.Add("------------------------------");
                        SearchListBox.Items.Add("Order Date     :  " + Record[1]);
                        SearchListBox.Items.Add("------------------------------");
                        for (int col = 2; col < Record.Length - 1; col++)
                        {
                            SearchListBox.Items.Add(Record[col]);
                        }
                        SearchListBox.Items.Add("------------------------------");
                        SearchListBox.Items.Add("Total Cost : "  +" £ " +Record[Record.Length - 1]);

                    }
                }
                if (!RecordPresent)
                {
                    MessageBox.Show("record Not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Message Box File Not Found" + e + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // WIllused for gettig all the data according to date of transaction
        public void SearchViaDate(string SearchItem)
        {
            try
            {
                decimal TotalProceForOrder = 0m;
                List<decimal> BagleTotalOrderPrice = new List<decimal>();

                // Used to check is record is present or not
                bool RecordPresent = false;
                try
                {
                    // getting all the records from txt file
                    string FileLoaction = Path.Combine(DirLocation, Complete_Order_Report);
                    string[] Record, AllRecords;
                    AllRecords = File.ReadAllLines(FileLoaction);
                    for (int row = 0; row < AllRecords.Length; row++)
                    {
                        // spliting single record 
                        Record = AllRecords[row].Split(',');
                        if (SearchItem == Record[1])
                        {
                            RecordPresent = true;
                            SearchListBox.Items.Add("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            SearchListBox.Items.Add("Order Date     :  " + Record[1]);
                            SearchListBox.Items.Add("Transaction ID :  " + Record[0]);
                            SearchListBox.Items.Add("------------------------------");
                            for (int col = 2; col < Record.Length - 1; col++)
                            {
                                SearchListBox.Items.Add(Record[col]);
                            }
                            SearchListBox.Items.Add("------------------------------");
                            SearchListBox.Items.Add("Order Cost : " + " £ "+Record[Record.Length - 1]);
                            BagleTotalOrderPrice.Add(decimal.Parse(Record[Record.Length - 1]));
                        }
                    }
                    TotalProceForOrder = BagleTotalOrderPrice.Sum(x => Convert.ToDecimal(x));
                    SearchListBox.Items.Add("------------------------------"); 
                    SearchListBox.Items.Add("Total Cost : " + TotalProceForOrder.ToString("C", new CultureInfo("en-GB")));
                    if (!RecordPresent)
                    {
                        MessageBox.Show("record Not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    if (RecordPresent)
                    {
                        TotalProceForOrder = BagleTotalOrderPrice.Sum(x => Convert.ToDecimal(x));
                        SearchListBox.Items.Add("------------------------------");
                        SearchListBox.Items.Add("Total Cost : " + TotalProceForOrder.ToString("C", new CultureInfo("en-GB")));
                    }
                    else
                    {
                        SearchListBox.Items.Clear();
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Message Box File Not Found" + e + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            private void SubmitSearchBtn_Click(object sender, EventArgs e)
            {
            try
            {
                // calling function and checking which button pressed and calling fuction accordingly 
                SearchListBox.Items.Clear();
                if (TransactionIDRadioBtn.Checked)
                {
                    string SeachTerm = SearchInputTextBox.Text;
                    SearchViaTransaction(SeachTerm);
                }
                if (DateRadioBtn.Checked)
                {
                    string SeachTerm = SearchInputTextBox.Text;
                    SearchViaDate(SeachTerm);
                }

            }
            catch
            {
                MessageBox.Show("Something Went Wrong","Message Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearSearchBtn_Click(object sender, EventArgs e)
        {
            // clearing listbox and input fields and other radiobutton that used had choosed 
            SearchListBox.Items.Clear();
            DateRadioBtn.Checked = false;
            TransactionIDRadioBtn.Checked = true;
            SearchInputTextBox.Clear();
            SearchInputTextBox.Focus();

        }
    }
}
