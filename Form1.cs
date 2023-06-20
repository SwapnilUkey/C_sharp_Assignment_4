using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using File = System.IO.File;

namespace Assignment_4
{
    public partial class MyBagelShopApplication : Form
    {
        // Geting locaiotn for base dir
        string DirLocation = System.AppDomain.CurrentDomain.BaseDirectory;

        // vars for generating uni code
        const string UniChar = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" ;
        const int UniKeyLen = 7 ;

        // Constants required for accessing name and sizes 
        const char delimiterChars = ',';
        const string File_Bagle_Name = "Bagle_Name.txt" , File_Bagle_Prices = "Bagle_Prices.txt" , File_Bagle_Sizes = "Bagle_Sizes.txt",File_Bagle_Stock = "Bagle_Stock.txt",Complete_Order_Report= "Complete_Order_Report.txt",Generate_Report_Stock = "Generate_Report_Stock.txt";
        static string[] BagleSizes = {
            "Small", "Medium", "Regular", "Large", "ExtraLarge"
        };        
        static string[] BagleSizesAbbrivated = {
            "S", "M", "R", "L", "XL"
        };

        // Quantity orders number 
        int QuantityOrder;
        string[] ArrayBagleName = { };
        decimal[,] ArrayBagelPriceTxt = new decimal[13,5];
        int[,] StockOpening = new int[13,5];
        int[,] StockOpeningCopy = new int[13,5];
        int[,] StockDummyVar = new int[13,5];

        //
        int[,] StockDummyCheckerMedia = new int[13,5];

        // Array used for Stock Report Generation
        public static int[,] StockSubstraction { get; private set; } = new int[13, 5];
        public static decimal[,] PriceCalculation { get; private set; } = new decimal[13, 5];

        //Vars used for Summary Report 
        decimal TotalProceForOrder = 0;
        int SelectedBagleNameIndex = 0, SelectedBagleSizeIndex = 0;
        int SumTNumBag = 0;
        decimal SumTSale = 0;

        // Passing summary vars to summary file
        public static int SumTotalNumberOfBagleSold { get; private set; } = 0;
        public static decimal SumTotalSalesValue { get; private set; } = 0;
        public static int SumTotalNumTransaction { get; private set; } = 0;

        // list used for managing and adding the all report in txt file
        List<string> OrderBagleNameQunatity  = new List<string>();
        List<decimal> BagleTotalOrderPrice = new List<decimal>();


        // Function used for getting name array
        public Boolean Array_Bagle_Name_GetData()
        {
            try
            {
                string FileLoaction = Path.Combine(DirLocation, File_Bagle_Name);
                string[] readText = File.ReadAllLines(FileLoaction);
                foreach (string s in readText)
                {
                    ArrayBagleName = s.Split(delimiterChars);
                }
                return true;
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Message Box File Not Found" + e + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        // Fuction used for getting all prices in array
        public Boolean Array_Bagle_Prices_GetData()
        {
            try
            {
                string FileLoaction = Path.Combine(DirLocation, File_Bagle_Prices);
                string[] Record, AllRecords;
                AllRecords = File.ReadAllLines(FileLoaction);

                for (int row = 0; row < AllRecords.Length; row++)
                {
                    Record = AllRecords[row].Split(',');
                    for (int col = 0; col < Record.Length; col++)
                    {
                        ArrayBagelPriceTxt[row, col] = decimal.Parse(Record[col]);
                    }
                }
                return true;
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Message Box File Not Found" + e + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        // Getting stock data from txt file 
        public Boolean ArrayOpeningStock()
        {
            try
            {
                string FileLoaction = Path.Combine(DirLocation, File_Bagle_Stock);
                string[] Record, AllRecords;
                AllRecords = File.ReadAllLines(FileLoaction);

                for (int row = 0; row < AllRecords.Length; row++)
                {
                    Record = AllRecords[row].Split(',');
                    for (int col = 0; col < Record.Length; col++)
                    {
                        StockOpening[row, col] = int.Parse(Record[col]);
                    }
                }
                return true;
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Message Box File Not Found" + e + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        // Fuction used for adding selected data in Listview after adding order in cart
        private void AddItemToCart(string NameOfBegal , string BagleSize, int Qunatity , decimal PriceOrder)
        {

            ListViewItem item = new ListViewItem(NameOfBegal);
            item.SubItems.Add(BagleSize);
            item.SubItems.Add(Qunatity.ToString());
            item.SubItems.Add(PriceOrder.ToString("C", new CultureInfo("en-GB")));
            DisplayListView.Items.Add(item);

        }
    
        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                QuantityOrder = int.Parse(QuantityTextBox.Text);
                try
                {
                    if ((BagleNameListBox.SelectedIndex != -1))
                    {
                        if(BagleSizeListBox.SelectedIndex != -1)
                        {
                            //selecting index from listbox
                            SelectedBagleNameIndex = BagleNameListBox.SelectedIndex;
                            SelectedBagleSizeIndex = BagleSizeListBox.SelectedIndex;
                            if (QuantityOrder > 0)
                            {

                                //checking the qunatity added is greater that stock available
                                if (StockDummyCheckerMedia[SelectedBagleNameIndex, SelectedBagleSizeIndex] >= QuantityOrder )
                                {

                                    AddItemToCart(ArrayBagleName[SelectedBagleNameIndex], BagleSizesAbbrivated[SelectedBagleSizeIndex],
                                       QuantityOrder, QuantityOrder * ArrayBagelPriceTxt[SelectedBagleNameIndex, SelectedBagleSizeIndex]);

                                    StockDummyVar[SelectedBagleNameIndex, SelectedBagleSizeIndex] += QuantityOrder;

                                    StockDummyCheckerMedia[SelectedBagleNameIndex, SelectedBagleSizeIndex] -= QuantityOrder;

                                    OrderBagleNameQunatity.Add(ArrayBagleName[SelectedBagleNameIndex] + "   -    "
                                        + BagleSizesAbbrivated[SelectedBagleSizeIndex] + "    -    " + QuantityOrder);

                                    BagleTotalOrderPrice.Add(QuantityOrder * ArrayBagelPriceTxt[SelectedBagleNameIndex, SelectedBagleSizeIndex]);

                                    //TotalProceForOrder = BagleTotalOrderPrice.Sum(x => Convert.ToDecimal(x));

                                    TotalProceForOrder += (QuantityOrder * ArrayBagelPriceTxt[SelectedBagleNameIndex, SelectedBagleSizeIndex]);
                                    TotalPriceOutLabel.Text = TotalProceForOrder.ToString("C", new CultureInfo("en-GB"));

                                    //
                                    SumTNumBag += QuantityOrder;
                                    //SumTSale += TotalProceForOrder;

                                    // Enable order buton after adding items to listview box 
                                    MakeOrderBtn.Enabled = true;

                                    // Clearing Qunatity Text Box
                                    QuantityTextBox.Text = "";
                                    // reseting data for next input
                                    BagleNameListBox.ClearSelected();
                                    BagleSizeListBox.ClearSelected();

                                }
                                // check ing if their are any invalid inputs from user
                                else
                                {
                                    if (StockDummyCheckerMedia[SelectedBagleNameIndex, SelectedBagleSizeIndex] > 0)
                                    {
                                        QuantityTextBox.Text = StockDummyCheckerMedia[SelectedBagleNameIndex, SelectedBagleSizeIndex].ToString();
                                        MessageBox.Show(ArrayBagleName[SelectedBagleNameIndex] + " for " + BagleSizes[SelectedBagleSizeIndex] + " size " +
                                            StockDummyCheckerMedia[SelectedBagleNameIndex, SelectedBagleSizeIndex] + " are only " 
                                            + " Available in Stock" , "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        
                                    }
                                    else
                                    {
                                        QuantityTextBox.Text = StockDummyCheckerMedia[SelectedBagleNameIndex, SelectedBagleSizeIndex].ToString();
                                        MessageBox.Show(ArrayBagleName[SelectedBagleNameIndex] + " " + BagleSizes[SelectedBagleSizeIndex] + " Is not in stock", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show(" Quantity Can not Be Zero", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                QuantityTextBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Choose appropriate Option from Bagle Size", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            BagleSizeListBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Choose appropriate Option from Bagle Name", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BagleNameListBox.Focus();
                    }
                }
                catch
                {

                }
            }
            catch
            {
                MessageBox.Show("Invalid Input" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Fuction used for checking uni code is already present in order txt file or not
        public Boolean KeyUniFinder(string UniKey)
        {
            try
            {
                string FileLoaction = Path.Combine(DirLocation, Complete_Order_Report);
                if (!File.Exists(FileLoaction))
                {
                    return false;
                }
                else
                {
                    string[] Record, AllRecords;
                    AllRecords = File.ReadAllLines(FileLoaction);
                    for (int row = 0; row < AllRecords.Length; row++)
                    {
                        Record = AllRecords[row].Split(',');
                        if (Record[0] == UniKey)
                        {
                            return true;
                        }
                        //Console.WriteLine(Record[0]);  
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        // generating Uni Code for each transacction of order
        public string GenerateUniKey()
        {
            Random rnd = new Random();
            string UniKey = "";
            for (int UniLoop = 0; UniLoop < UniKeyLen; UniLoop++)
            {
                int number = rnd.Next(1, UniChar.Length);
                char SingleUni = UniChar[number];
                UniKey += SingleUni;
            }
            return UniKey;
        }


        // function for updating  the txt file 
        public void CompleteOrderReport()
        {
            string FileLoaction = Path.Combine(DirLocation, Complete_Order_Report);
            string DataToWrite = string.Join(",", OrderBagleNameQunatity);
            if (!File.Exists(FileLoaction))
            {
                using (StreamWriter writer = File.AppendText(FileLoaction))
                {
                    writer.WriteLine(DataToWrite);
                    writer.Close();
                }
            }
            else
            {
                using (StreamWriter writer = File.AppendText(FileLoaction))
                {
                    writer.WriteLine(DataToWrite);
                    writer.Close();
                }
            }
        }

        // Upadating all the stock data into a txt file 
        public void UpdateStockDataTxt()
        {
            string FileLoaction = Path.Combine(DirLocation, File_Bagle_Stock);
            string DataToWrite = "";
            File.Delete(FileLoaction);
            using (StreamWriter writer = File.AppendText(FileLoaction))
            {
                for (int ith = 0; ith < StockOpening.GetLength(0); ith++ )
                {
                    List<string> StockArrayMid = new List<string>();
                    for (int jth = 0; jth < StockOpening.GetLength(1); jth++ )
                    {
                        StockArrayMid.Add((StockOpening[ith, jth]).ToString());
                    }
                    //writer.WriteLine();
                    DataToWrite = string.Join(",", StockArrayMid);
                    writer.WriteLine(DataToWrite);
                }
                writer.Close();
            }
        }

        // Button to make an order 
        private void MakeOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {               
                // calling fuction to get Unique key
                string UniKeyOrder = GenerateUniKey();

                // checking if the unicode is repeted of its different 
                while (KeyUniFinder(UniKeyOrder))
                {
                    UniKeyOrder = GenerateUniKey();
                }

                // meesage box that will use in messagebox popup
                string MeesageBoxString = String.Join("\n", OrderBagleNameQunatity);

                //  getting the data and inserting and changing the index 
                string now = DateTime.Now.ToString("MM/dd/yyyy");
                OrderBagleNameQunatity.Insert(0, now);
                OrderBagleNameQunatity.Insert(0, UniKeyOrder);
                OrderBagleNameQunatity.Insert(OrderBagleNameQunatity.Count, TotalProceForOrder.ToString());

                String CompanyName = "My Bagel Shop";

                // Messageebox after completing the order
                MessageBox.Show(
                "Following are the Order Information" + "\n"
                + " Company Name: " + CompanyName + "\n" 
                + " Transaction Code : " + OrderBagleNameQunatity[0] + "\n" 
                + " Date : " + OrderBagleNameQunatity[1] + "\n" +
                MeesageBoxString + "\n"
                + "Price :  £  " + OrderBagleNameQunatity.Last() + "\n"
                + "Your Food Is Ordered"
                    , "Boking Information Confrimation", MessageBoxButtons.OK);
                
                // Generating and updating the txt file which contain all transaction data 
                CompleteOrderReport();

                // Update the txt file which contains stock information
                StockOpening = StockDummyCheckerMedia;
                UpdateStockDataTxt();
                Array.Clear(StockDummyVar, 0, StockDummyVar.Length);
                StockDummyCheckerMedia = StockOpening;

                // calulcating all the vars for summary 
                SumTotalNumTransaction += 1;
                SumTotalNumberOfBagleSold += SumTNumBag;
                SumTotalSalesValue += BagleTotalOrderPrice.Sum(x => Convert.ToDecimal(x)); ;

                // reseting data for next order
                BagleNameListBox.ClearSelected();
                BagleSizeListBox.ClearSelected();
                DisplayListView.Items.Clear();
                TotalPriceOutLabel.Text = "";
                QuantityTextBox.Clear();

                OrderBagleNameQunatity.Clear();
                BagleTotalOrderPrice.Clear();
                SummaryBtn.Enabled = true;
                SumTNumBag = 0;
                SumTSale = 0;
                TotalProceForOrder = 0;
                MakeOrderBtn.Enabled = false;
                SummaryBtn.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Please Choose appropriate Option from Bagle Name", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BagleNameListBox.Focus();
            }
        }

        private void SearchBtnForm_Click(object sender, EventArgs e)
        {
            // for new form SearchForm
            SearchForm MySearchForm = new SearchForm();
            MySearchForm.ShowDialog();
        }

        private void SummaryBtn_Click(object sender, EventArgs e)
        {
            // for new form Summary Form
            SummaryForm MySummaryForm = new SummaryForm();
            MySummaryForm.ShowDialog();

        }

        private void BagleNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //checking if user have chossen the inputs 
                if ((BagleNameListBox.SelectedIndex != -1) && (BagleSizeListBox.SelectedIndex != -1))
                {
                    PriceTextbox.Text = (ArrayBagelPriceTxt[BagleNameListBox.SelectedIndex, BagleSizeListBox.SelectedIndex]).ToString("C", new CultureInfo("en-GB"));
                }
            }
            catch 
            {
                ;
            }

        }

        private void BagleSizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Updating the lsit price 
            try
            {
                //checking if user have chossen the inputs 
                if ((BagleNameListBox.SelectedIndex != -1) && (BagleSizeListBox.SelectedIndex != -1))
                {
                    PriceTextbox.Text = (ArrayBagelPriceTxt[BagleNameListBox.SelectedIndex, BagleSizeListBox.SelectedIndex]).ToString("C", new CultureInfo("en-GB"));
                }
            }
            catch
            {
                ;
            }
        }

        private void SalePerItemBtn_Click(object sender, EventArgs e)
        {
            if (SumTotalNumTransaction > 0)
            {

                //Calculating the quantity of each sold bagel
                for (int x = 0; x < StockOpeningCopy.GetLength(0); ++x)
                {
                    for (int y = 0; y < StockOpeningCopy.GetLength(1); ++y)
                    {
                        StockSubstraction[x, y] = StockOpeningCopy[x, y] - StockOpening[x, y];
                    }
                }

                // prices fr each sold bagels
                for (int x = 0; x < StockOpeningCopy.GetLength(0); ++x)
                {
                    for (int y = 0; y < StockOpeningCopy.GetLength(1); ++y)
                    {
                        PriceCalculation[x, y] = StockSubstraction[x, y] * ArrayBagelPriceTxt[x, y];
                    }
                }

                // calling new form SalesReportPerItem
                SalesReportPerItem MySalesReportForm = new SalesReportPerItem();
                MySalesReportForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Not A Single Bael Has Sold Today", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OrderClearBtn_Click(object sender, EventArgs e)
        {
            BagleNameListBox.ClearSelected();
            BagleSizeListBox.ClearSelected();
            DisplayListView.Items.Clear();
            TotalPriceOutLabel.Text = "";
            QuantityTextBox.Clear();
            TotalProceForOrder = 0;
            OrderBagleNameQunatity.Clear();
            BagleTotalOrderPrice.Clear();
            SumTNumBag = 0;
            SumTSale = 0;
            StockDummyCheckerMedia = StockOpening;            

        }

        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string FileLoaction = Path.Combine(DirLocation, Generate_Report_Stock);
                File.Delete(FileLoaction);
                using (StreamWriter writer = File.AppendText(FileLoaction))
                {

                    writer.Write("\t");
                    for (int i = 0; i < BagleSizesAbbrivated.Length; i++)
                    {
                        writer.Write("\t");
                        writer.Write(BagleSizesAbbrivated[i]);


                        if (i == BagleSizesAbbrivated.Length - 1)
                        {
                            writer.Write("\n");
                        }
                    }

                    // Printing product headers and stock array values to Inventory management file
                    for (int i = 0; i < ArrayBagleName.Length; i++)
                    {

                        writer.Write(ArrayBagleName[i] + "\t");

                        for (int j = 0; j < BagleSizesAbbrivated.Length; j++)
                        {
                            writer.Write(StockOpening[i, j] + "\t");
                        }

                        writer.Write("\n");
                    }

                    writer.Close();
                }
                Process.Start(FileLoaction);
            }
            catch
            {

            }
        }
        
        public MyBagelShopApplication()
        {
            InitializeComponent();
        }

        private void MyBagelShopApplication_Load(object sender, EventArgs e)
        {
            // calling to get the data for bagel names
            if (Array_Bagle_Name_GetData())
            {
                for (int i = 0; i < ArrayBagleName.Length; i++)
                {
                    BagleNameListBox.Items.Add(ArrayBagleName[i].ToString());
                }
            }

            // gettting prices from txt to an array
            if (Array_Bagle_Prices_GetData())
            {
                for (int i = 0; i < BagleSizes.Length; i++)
                {
                    BagleSizeListBox.Items.Add(BagleSizes[i].ToString());
                }
            }
            // getting opening stock and making copy of it
            ArrayOpeningStock();
            Array_Bagle_Prices_GetData();
            StockOpeningCopy = StockOpening.Clone() as int[,];
            StockDummyCheckerMedia = StockOpening;


            MakeOrderBtn.Enabled = false;
            SummaryBtn.Enabled = false;
        }

        private void BagleSizeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
