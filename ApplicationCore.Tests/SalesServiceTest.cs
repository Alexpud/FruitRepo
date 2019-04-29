using ApplicationCore.Exceptions;
using ApplicationCore.Models;
using ApplicationCore.Repositories.Interfaces;
using ApplicationCore.Services.Concrete;
using ApplicationCore.Services.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCore.Tests
{
    public class SalesServiceTest
    {
        [TestCase]
        public void Should_Not_Execute_Sale_For_Empty_Bascket()
        {
            // Arrange
            ISaleService saleService = new SalesService(null, null);

            // Act
            Action act = () => saleService.ExecuteSale(null);

            // Assert
            Assert.Throws<EmtpyShoppingCartSaleException>(() => act.Invoke());
        }
    }
}
