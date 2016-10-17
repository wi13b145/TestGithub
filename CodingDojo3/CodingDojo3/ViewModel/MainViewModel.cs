using CodingDojo4DataLib;
using CodingDojo4DataLib.Converter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3.ViewModel
{
    class MainViewModel : BaseViewModel
    {

        /* Currency stuff */
        public Array Currencies
        {
            get { return Enum.GetValues(typeof(Currencies)); }

        }

        public Currencies SelectedCurrency
        {
            get { return selectedCurrency; }
            set 
            {
                selectedCurrency = value;
                OnChange("SelectedCurrency");
                StartConversion();
               
            }
        }

        private void StartConversion()
        {
            
            foreach (var item in Items) {
                item.CalculateSalesPriceFromEuro(SelectedCurrency);
                item.CalculatePurchasePriceFromEuro(SelectedCurrency);
            }
        }


        /* List stuff */
        private List<StockEntry> stock;

        public static ObservableCollection<StockEntryViewModel> items = new ObservableCollection<StockEntryViewModel>();
        private CodingDojo4DataLib.Converter.Currencies selectedCurrency;
       
       

        public static  ObservableCollection<StockEntryViewModel> Items
        {
            get { return items; }
            set
            {
                items = value;
            }

        }

        private SampleManager manager = new SampleManager();

        public RelayCommand ButtonTest { get; set; }


        public MainViewModel()
        {

            selectedCurrency = CodingDojo4DataLib.Converter.Currencies.EUR;

            stock = manager.CurrentStock.OnStock;

            foreach (var item in manager.CurrentStock.OnStock)
            {
                Items.Add(new StockEntryViewModel(item));
            }

            ButtonTest = new RelayCommand(AddIt);

        }

        void AddIt(object parameter)
        {
            // do stuff
            Items.Add(new StockEntryViewModel(new StockEntry { Amount = 0, SoftwarePackage = new Software("", new Group()) }) { SalesPrice = 0, PurchasePrice = 0 });
            
        }


        
    }
}
