using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XORify.Commands;

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


        public RelayCommand OnButtonClickedCommand { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        private bool CanExecuteButton()
        {
            return true;
        }

        public string EncryptOrDecrypt(string text, string key)
        {
            var result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
                result.Append((char)((uint)text[c] ^ (uint)key[c % key.Length]));

            return result.ToString();
        }

        private void DoItOnButtonClick()
        {
            // where encoding happens
            if(InputTxt == null || KeyTxt == null)
            {
                OutputTxt = "Error: Input or Key is 0";
            } else
            {
                OutputTxt = EncryptOrDecrypt(InputTxt, KeyTxt);
            }
            
        }


        public MainViewModel()
        {
            // OutputTxt = "Hello World!";

            OnButtonClickedCommand = new RelayCommand(
            new Action(DoItOnButtonClick),
            new Func<bool>(CanExecuteButton));
        }



    }
}
