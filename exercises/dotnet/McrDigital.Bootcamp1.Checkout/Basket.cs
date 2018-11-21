using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    class Basket
    {
        private readonly List<Item> basketItems;

        public Basket()
        {
            basketItems = new List<Item>();
        }

        public void AddItem(Item item)
        {
            basketItems.Add(item);
        }

        public Item RemoveLastItem()
        {
            int lastIndex = basketItems.Count - 1;
            Item removedItem = basketItems[lastIndex];
            basketItems.RemoveAt(lastIndex);
            return removedItem;
        }
    }
}
