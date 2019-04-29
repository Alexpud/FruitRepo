using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Services.Interfaces
{
    public interface ISaleService
    {
        void ExecuteSale(ShoppingCart shoppingCart);
    }
}
