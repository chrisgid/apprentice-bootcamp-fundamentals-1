using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Item
    {
        public string Sku { get; }

        public Item(string sku)
        {
            this.Sku = sku;
        }
    }
}
