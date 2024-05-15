using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Invoice
    {
        public string Account { get; init; }
        public string Customer { get; init; }
        public string Provider { get; init; }

        public string Article { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Invoice(string account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public decimal CostCalculation(bool needEDV) => needEDV ? (Price * Quantity) * 0.18m + (Price * Quantity) : Price * Quantity; 
    }
}
