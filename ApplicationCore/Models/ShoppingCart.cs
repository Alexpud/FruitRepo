using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Models
{
    public class ShoppingCart
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
