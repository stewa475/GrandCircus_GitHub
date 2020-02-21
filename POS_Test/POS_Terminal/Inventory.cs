using System;
using System.Collections.Generic;
using System.Text;

namespace POS_Terminal
{
    public class Inventory
    {
        private Dictionary<string, int> inv = new Dictionary<string, int>();
        private int quantity;
        private string name;

        public Dictionary<string, int> Inv { get => inv; set => inv = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Name { get => name; set => name = value; }

        public Inventory()
        {

        }

        public Inventory(int quantity, string name)
        {
            this.quantity = quantity;
            this.name = name;
        }

        public Inventory(Dictionary<string, int> inv)
        {
            this.inv = inv;
        }

        public Dictionary<string, int> AddProduct(string product, int qty)
        {
            inv.Add(product, qty);
            Quantity = qty;
            return inv;
        }

        public Dictionary<string, int> RemoveProduct(string product)
        {

            inv.Remove(product);

            return inv;
        }

        public Dictionary<string, int> RemoveQuantity(string product, int qty)
        {
            inv.TryGetValue(product, out int value);
            inv[product] = value - qty;
            Quantity = value - qty;
            Name = product;
            return inv;
        }

        public string SelectItem(int num)
        {
            Dictionary<int, string> menu = new Dictionary<int, string>();
            int count = 1;
            foreach (var item in inv)
            {
                menu.Add(count, item.Key);
                count++;
            }
            return menu[num];
        }

        public override string ToString()
        {
            return $"There are {Quantity} {Name}(s) left.";
        }
    }
}
