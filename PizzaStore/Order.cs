using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    
    /* Denne Klasse er først og fremmest lavet således der kan oprettes Order i Store klassen.
     */
    internal class Order
    {
        #region Instance fields
        private static int _orderId = 1000; // ordreId er har jeg sat til at starte på 1000
        private Customer _customer; /* Her er Customer klassen blevet til datatypen for _customer, og indgår i constructoren,
                                     * således at efter kunden er oprettet, blot skrive kundens navn ind i
                                     * constructoren til orderen. I ToString metoden i Order Klassen indgår
                                     * {Customer} og her vil den kunne indhente samtlige informationer om kunden. */

        private double _deliveryPrice = 40; // leveringsprisen er sat til 40 kroner
        private double _tax = 1.25; // tax er defineret til 25 % af totalprisen 
        private double _totalPrice; // totalprisen er betinget af om det er en levering som koster 40 kroner eller om det er Takeaway
        private Pizza _pizza;      // her er det på samme måde som Customer
        private bool _takeAway; // Denne er en bool fordi hvis ISTakeAway er "true" som skal være et svar til "bool takeaway" i contructoren når Order objektet bliver oprettet
        private string _thankYou; // blot en tekst til kunden
        
        
        #endregion

        #region Constructor

        public Order(Customer customer, Pizza pizza, bool takeAway)
        {
            _orderId = OrderId(); // = en metode - se under metoden OrderId
            _customer = customer;
            _pizza = pizza;        
            _takeAway = takeAway;
            _thankYou = "Thank you for the order";        
        }

        #endregion

        #region Properties
        
        public double Delivery
        {
            get { return _deliveryPrice; }
        }
        public Customer Customer
        {
            get { return _customer; }
        }
        public double Tax
        {
            get { return _tax; }
        }
        public double TotalPrice
        {
            get { return _totalPrice; }
        }
        public Pizza Pizza
        {
            get { return _pizza; }
        }
        
        public bool IsTakeAway
        {
            get { return _takeAway; }
        }
        public string ThankYou 
        { 
            get { return _thankYou; }
        }
        #endregion


        #region Method 
                       
        public double CalculateTotalPrice() // denne metode udregner totalprisen og betinget af om det er TakeAway eller levering
        {
            if (_takeAway == true)

                _totalPrice = (Tax * Pizza.Price);
            else
            {
                _totalPrice = (Tax * Pizza.Price) + _deliveryPrice;
            }
            return _totalPrice;
        }
        public int OrderId() // denne metode plusser _orderId med 1 hver gang en ny order oprettes
        {
            int OrderId = _orderId++;
            return OrderId;      
        }
               
        public override string ToString()
        {
            if (_takeAway == true)
            {
                return $"\n {ThankYou}\n\n OrderID:{OrderId()}\n\n Customer:\n\n {Customer.ToString()}\n Your Order:\n\n {Pizza.ToString()}\n\n TotalPrice incl tax (25 %): {CalculateTotalPrice()}\n\n\n"; 
            }
            else
            {
                return $"\n {ThankYou}\n\n OrderID:{OrderId()}\n\n Customer\n\n {Customer.ToString()}\n Your Order:\n\n {Pizza.ToString()}\n\n Delivery price: {Delivery}\n\n\n TotalPrice incl tax (25 %): {CalculateTotalPrice()}\n\n\n";
            }
        }

        #endregion






    }

}