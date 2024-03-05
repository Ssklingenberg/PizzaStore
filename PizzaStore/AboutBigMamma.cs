using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{

    /* Denne klasses formål er at definere forskellige informationer 
     * om Big Mamma, som indgår i ToString metoden i Invoice Klassen*/
    internal class AboutBigMamma 
    {
        #region Instance fields

        private string _pizzaeriaName;
        private string _phoneNo;
        private string _addres;
        private string _openHours;
        

        #endregion
      
        #region Constructor

        public AboutBigMamma()
        {
            _pizzaeriaName = "BIG MAMMA GASTRONOMIA";
            _phoneNo = "40 12 40 03";
            _addres = "Address: Frederiksværksgade 4 - 3400 Hillerød";
            _openHours = "Open hours: Tuesday- Friday 11-21 Saturday-Sunday 12-21";
        }

        #endregion

        #region Properties
        public string PizzaeriaName 
        { 
           get {  return _pizzaeriaName; } 
        }
        public string PhoneNo
        {
           get { return _phoneNo; }
        }
        public string Addres 
        { 
           get { return _addres; } 
        }
        public string OpenHours 
        { 
           get { return _openHours; }      
        }
       
        
        #endregion

        #region Method


        public override string ToString()
        {
            return $"{PizzaeriaName}\n\n Phone No: {PhoneNo}\n\n Address: {Addres}\n Open hours: {OpenHours}\n";
        }

        #endregion




    }
}
