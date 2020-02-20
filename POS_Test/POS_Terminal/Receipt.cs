using System;
using System.Collections.Generic;
using System.Text;

namespace POS_Terminal
{
    public class Receipt
    {
        private Dictionary<string, int> rec = new Dictionary<string, int>();
        private string item;
        private int quantity;
        private double subTotal;
        private double tax;
        private double grandTotal;

        public Receipt()
        {
            this.rec = new Dictionary<string, int>();
        }

        //public Receipt(string item, int quantity, double subTotal, double tax, double grandTotal)
        //{
        //    this.Item = item;
        //    this.Quantity = quantity;
        //    this.SubTotal = subTotal;
        //    this.Tax = tax;
        //    this.GrandTotal = grandTotal;
        //}

        public string Item { get => item; set => item = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double SubTotal { get => subTotal; set => subTotal = value; }
        public double Tax { get => tax; set => tax = value; }
        public double GrandTotal { get => grandTotal; set => grandTotal = value; }

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
            Quantity = qty;
            return rec;
        }

        public Dictionary<string, int> RemoveFromCart(string item)
        {
            rec.Remove(item);
            return rec;
        }

    }
}
