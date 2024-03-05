using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    /* Denne klasse er til at definere oplysninger om kunden, 
     * denne klasse indgår i Order klassen både i 
     * construktoren og i ToString metoden*/
    internal class Customer 
    {
        #region Instance fields

        private string _name;
        private string _email;
        private string _phone;
        private string _address;

        #endregion

        #region Constructor

        public Customer(string name, string email, string phone, string address)

        {
            _name = name;
            _email = email;
            _phone = phone;
            _address = address;
        }
        #endregion

        #region Properties
        public string Name 
        { 
            get { return _name; } 
        }

        public string Email 
        {  
            get { return _email; } 
        }

        public string Phone
        { 
            get { return _phone; }
        }

        public string Address 
        
        { 
            get { return _address; } 
        }
        #endregion


        #region Method 

        public override string ToString()
        {
            return $"Name: {Name},\n Email: {Email},\n Phone: {Phone},\n Address: {Address}\n";
        }
        #endregion


    }
}
