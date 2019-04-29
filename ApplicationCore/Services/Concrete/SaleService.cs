using ApplicationCore.Exceptions;
using ApplicationCore.Models;
using ApplicationCore.Repositories.Interfaces;
using ApplicationCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCore.Services.Concrete
{
    public class SalesService : ISaleService
    {
        private IProductRepository productRepository;
        private ISalesRepository salesRepository;

        public SalesService(IProductRepository productRepository, ISalesRepository salesRepository)
        {
            this.productRepository = productRepository;
            this.salesRepository = salesRepository;
        }

        public void ExecuteSale(ShoppingCart shoppingCart)
        {
            if (shoppingCart == null || !shoppingCart.Products.Any())
            {
                throw new EmtpyShoppingCartSaleException();
            }
        }
    }
}
