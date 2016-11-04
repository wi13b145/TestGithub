using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp16.Models
{
    public class Truckload
    {


        public String Source { get; set; }
        public int TimeToReady { get; set; }

        public List<Cargo> Load { get; set; }


        public Truckload(string source, int timeToReady, List<Cargo> load)
        {
            Source = source;
            TimeToReady = timeToReady;
            Load = load;
        }


    }
}
