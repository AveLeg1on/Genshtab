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
      public int QuantityItems { get; set; }    
        public double Weight
        {
            get { return _weight; } 
            set { _weight += value; }    
        }
        public double Calculation()
        {
           return _weight / _quantityItems;
        }
        public void StepToBack(double dubl)
        {
            _quantityItems--;
            Weight = Weight - dubl;
        }
      
    }
}
