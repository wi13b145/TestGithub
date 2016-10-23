using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XORify.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private string inputTxt;

        public string InputTxt
        {
            get { return inputTxt; }
            set { inputTxt = value; OnPropertyChanged("InputTxt"); }
        }

        private string keyTxt;

        public string KeyTxt
        {
            get { return keyTxt; }
            set { keyTxt = value; OnPropertyChanged("KeyTxt"); }
        }

        private string outputTxt;

        public string OutputTxt
        {
            get { return outputTxt; }
            set { outputTxt = value; OnPropertyChanged("OutputTxt"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public MainViewModel()
        {
            this.OutputTxt = "Hello World!";
        }

    }
}
