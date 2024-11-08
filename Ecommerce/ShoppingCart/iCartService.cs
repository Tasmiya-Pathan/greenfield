using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public interface iCartService
    {
        List<Item> GetItems();
        bool AddToCart(Item item);
        bool RemoveFromCart(Item item);
        bool Clear();
    }
}
