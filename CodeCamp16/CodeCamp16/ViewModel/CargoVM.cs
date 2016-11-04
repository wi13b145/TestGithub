using CodeCamp16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp16.ViewModel
{
    public class CargoVM
    {

        public Cargo cargo;

        public string ItemName
        {
            get { return cargo.ItemName; }
            set { cargo.ItemName = value; }
        }


        public int Weight
        {
            get { return cargo.Weight; }
            set { cargo.Weight = value; }
        }

        public int Amount
        {
            get { return cargo.Amount; }
            set { cargo.Amount = value; }
        }

        public CargoVM(string itemName, int weight, int amount)
        {
            //ItemName = itemName;
            //Weight = weight;
            //Amount = amount;
            cargo = new Cargo(itemName, weight, amount);
        }


    }
}
