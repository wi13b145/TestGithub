using CodingDojo4DataLib;
using CodingDojo4DataLib.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3.ViewModel
{
    class StockEntryViewModel : BaseViewModel
    {

        private StockEntry stockEntry;

        private double salespriceInEuro;
        private double purchasepriceInEuro;

        public String Name
        {
            get { return stockEntry.SoftwarePackage.Name; }

            set
            {
                stockEntry.SoftwarePackage.Name = value;
                OnChange("Name");
            }
        }


        public String Group
        {
            get { return stockEntry.SoftwarePackage.Category.Name; }

            set
            {
                stockEntry.SoftwarePackage.Category.Name = value;
                OnChange("Name");
            }
        }


        public double SalesPrice
        {
            get { return stockEntry.SoftwarePackage.SalesPrice; }
            set
            {
                stockEntry.SoftwarePackage.SalesPrice = value;
                OnChange("SalesPrice");
            }
        }



        public double PurchasePrice
        {
            get { return stockEntry.SoftwarePackage.PurchasePrice; }

            set
            {
                stockEntry.SoftwarePackage.PurchasePrice = value;
                OnChange("PurchasePrice");
            }
        }


        public int OnStock
        {
            get { return stockEntry.Amount; }

            set
            {
                stockEntry.Amount = value;
                OnChange("Name");
            }
        }

        public StockEntryViewModel(StockEntry entry)
        {
            stockEntry = entry;
            salespriceInEuro = entry.SoftwarePackage.SalesPrice;
            purchasepriceInEuro = entry.SoftwarePackage.PurchasePrice;
        }


        /* convert */
        public void CalculateSalesPriceFromEuro(Currencies currency)
        {
            this.SalesPrice = CurrencyConverter.ConvertFromEuroTo(currency, salespriceInEuro);

        }

        public void CalculatePurchasePriceFromEuro(Currencies currency)
        {

            this.PurchasePrice = CurrencyConverter.ConvertFromEuroTo(currency, purchasepriceInEuro);
        }


    }
}
