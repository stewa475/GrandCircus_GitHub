using System;
using System.Collections.Generic;
using System.Text;

namespace POS_Terminal
{
    public class Receipt
    {
        private Dictionary<string, int> rec = new Dictionary<string, int>();

        public Receipt()
        {
            this.rec = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Rec { get => rec; set => rec = value; }

        public static double GetGrandTotal(double subTotal, double tax)
        {
            double grandTotal = subTotal + tax;
            return grandTotal;
        }

        public static double GetTax(double subTotal)
        {
            double tax = subTotal * 0.06;
            return tax;
        }

        public Dictionary<string, int> AddToCart(string item, int qty)
        {
            rec.Add(item, qty);
            return rec;
        }

        public Dictionary<string, int> RemoveFromCart(string item)
        {
            rec.Remove(item);
            return rec;
        }

    }
}
