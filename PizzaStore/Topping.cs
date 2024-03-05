using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    /* Denne klasse definere Toppings, denne KLasse bruges når jeg 
     * opretter nye Toppings objekter og definere deres navne */
    internal class Topping
    {
        #region Instance fields
        private string _topping;
        
        #endregion

        #region Constructor
        public Topping(string topping) 
        { 
            _topping = topping;
         
        }

        #endregion
        public string ToppingOnPizza
        { 
            get { return _topping; } 
        }
        
        #region Properties
        public string Name
        { 
            get { return _topping; } 
        }

        #endregion


        #region Method 
        public override string ToString()
        {
            return $"Name: {Name}";
        }
        #endregion

    }
}
