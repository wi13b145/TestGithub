using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCamp16.Models;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace CodeCamp16.ViewModel
{
    public class TruckLoadVM : ViewModelBase
    {

        private Truckload truckload { get; set; }

        public string Source
        {
            get { return truckload.Source; }
            set { truckload.Source = value; RaisePropertyChanged("Source"); }
        }

        public int TimeToReady
        {
            get { return truckload.TimeToReady; }
            set { truckload.TimeToReady = value; RaisePropertyChanged("TimeToReady"); }
        }

        private ObservableCollection<CargoVM> load;

        public ObservableCollection<CargoVM> Load
        {
            get { return load; }
            set { load = value; RaisePropertyChanged("ItemName");  }
        }

        public TruckLoadVM(string source, int timeToReady, List<Cargo> load)
        {
            truckload = new Truckload(source, TimeToReady, load);

            foreach (var item in load)
            {
                this.load.Add(new CargoVM(item.ItemName, item.Weight, item.Amount));
            }

        }

    }
}
