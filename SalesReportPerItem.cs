using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class SalesReportPerItem : Form
    {
        // Array Used for Giving The Names to grid for proper row values
        string[] ArrayBagleName = {
            "Plain ", "Everything ", "Cinnamon Raisin ",
            "Blueberry ", "Chocolate Chip ","Onion ", "Asiago ", "Salt ",
            "Poppy Seed ", "French Toast ","Egg Bagels", "Pumpernickel ", " Wheat "
        };
        public SalesReportPerItem()
        {
            InitializeComponent();
        }

        // It will initiate the grid style report 
        private void SalesReportPerItem_Load(object sender, EventArgs e)
        {
            // WIll print the values for sold items of that size
            for(int i = 0; i < MyBagelShopApplication.StockSubstraction.GetLength(0); i++)
            {
                string[] row = new string[5];

                for(int j = 0; j < MyBagelShopApplication.StockSubstraction.GetLength(1); j++)
                {
                    row[j] = (MyBagelShopApplication.StockSubstraction[i,j]).ToString();
                }
                SaleStockGrid.Rows.Add(row);

            }

            // will show the sold bagle item price
            for (int i = 0; i < MyBagelShopApplication.PriceCalculation.GetLength(0); i++)
            {
                string[] row = new string[5];

                for (int j = 0; j < MyBagelShopApplication.PriceCalculation.GetLength(1); j++)
                {
                    row[j] = (MyBagelShopApplication.PriceCalculation[i, j]).ToString();
                }
                PriceDataGrid.Rows.Add(row);

            }

            // to create the name column 
            for (int i = 0; i < ArrayBagleName.Length; i++)
            {
                string row = ArrayBagleName[i];
                NameDataGrid.Rows.Add(row);
            }
        }

        private void SaleStockGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
