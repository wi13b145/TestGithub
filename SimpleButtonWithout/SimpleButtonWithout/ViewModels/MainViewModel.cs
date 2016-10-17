using SimpleButtonWithout.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleButtonWithout.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        private String output;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnChange(string propertyname)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public bool IsClickable { get; set; }

        public RelayCommand OnButtonClickedCommand { get; set; }

        public String Output
        {
            get { return output; }
            set { output = value; OnChange("Output"); }
        }

        public MainViewModel()
        {
            OnButtonClickedCommand = new RelayCommand(
                new Action(DoItOnButtonClick), 
                new Func<bool>(CanExecuteButton));
        }

        private bool CanExecuteButton()
        {
            return IsClickable;
        }

        private void DoItOnButtonClick()
        {
            Output += "clicked!";
        }
    }
}
