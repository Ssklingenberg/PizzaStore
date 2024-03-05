using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Pizza
    {
        /* 
         * Denne klasse er til at definere forskellige Pizzaer og deres toppeings. 
         * Topping indgår i Constructoren og skal derfor oprettes først i Topping Klassen
         * Denne klasse har også sin egen ToString metode.*/
        #region Instance fields
        private string _pizzaName;
        private double _price;
        private Topping _top1;
        private Topping _top2;
        private Topping _top3;
        private string _commment;
        #endregion

        #region
        public Pizza(string name, double price, Topping top1, Topping top2, Topping top3, string commment)

        {
            _pizzaName = name;
            _price = price;
            _top1 = top1;
            _top2 = top2;
            _top3 = top3;
            _commment = commment;
        }
        #endregion

        #region Properties
        public string PizzaName 
        { 
            get { return _pizzaName; } 
        }
        public double Price 
        { 
            get { return _price; } 
        }
        public string Comment
        {
            get { return _commment; }
        }
        #endregion


        #region Method         
        
        public override string ToString()
        {
            return $"PizzaName: {PizzaName}: {_top1}, {_top2}, {_top3}\n Comment: {Comment}\n\n PizzaPrice: {Price}" ;
        }
        #endregion

    }
}
