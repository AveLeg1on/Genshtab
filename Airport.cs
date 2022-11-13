using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Genshtab
{
     struct Airport
    {
        public int _quantityItems;
        public double _weight;
        public Airport(int quantityItems, double weigh)
        {
            _quantityItems = quantityItems;
            _weight = weigh;
            
        }
        public double Weight
        {
            get { return _weight; } 
            set { _weight += value; }    
        }
        public double Calculation()
        {
           return _weight / _quantityItems;
        }
      
    }
}
