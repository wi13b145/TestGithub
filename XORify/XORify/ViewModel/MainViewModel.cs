using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XORify.ViewModel
{
    class MainViewModel
    {
        private string inputTxt;

        public string InputTxt
        {
            get { return inputTxt; }
            set { inputTxt = value; }
        }

        private string keyTxt;

        public string KeyTxt
        {
            get { return keyTxt; }
            set { keyTxt = value; }
        }

        private string outputTxt;

        public string OutputTxt
        {
            get { return outputTxt; }
            set { outputTxt = value; }
        }


        public MainViewModel()
        {
           
        }

    }
}
