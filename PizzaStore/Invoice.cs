using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Invoice
    {
        #region Instance fields
        private Order _order;
        private AboutBigMamma _aboutBigMamma;
        private string _invoice;
        private DateTime _invoiceDateTime;
        //private DateTime _orderReady;

        #endregion


        #region Constructor
        public Invoice(DateTime invoiceDateTime, Order order, AboutBigMamma about)

        {
            _order = order;
            _invoiceDateTime = invoiceDateTime;
            _aboutBigMamma = about;            
            _invoice = "INVOICE";

        }
              
      #endregion

        #region Properties
        public Order Orders 
        { 
            get { return _order; } 
        }
         public AboutBigMamma AboutBigMamma
        {
            get { return _aboutBigMamma;}
        }
        public DateTime InvoiceDateTime 
        { 
            get { return DateTime.Now; } 
        }
        public string InvoicePrint
        { 
            get { return _invoice; } 
        }
        
        #endregion

        #region Method

        public override string ToString()
        {
            return $"\n\n {InvoicePrint}: {InvoiceDateTime}\n {Orders}\n {AboutBigMamma}\n\n ";
        }
        


        #endregion


    }
}
