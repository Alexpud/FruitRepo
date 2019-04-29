using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
