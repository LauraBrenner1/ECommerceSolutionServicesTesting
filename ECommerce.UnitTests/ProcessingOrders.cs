global using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UnitTests;

public class ProcessingOrders
{
    [Fact]
    public void CanGiveMeATotalNumberOfItems()
    {
        // Given
        var orderProcessor = new OrderProcessor();

        var order = new ShoppingCart
        {
            Items = new List<ShoppingCartItem>
            {
                new ShoppingCartItem(),
                new ShoppingCartItem()
            }
        };
        // When
        OrderSummary summary = orderProcessor.ProcessOrder(order);
        // Then
        Assert.Equal(2, summary.NumberOfItems);

    }
    [Fact]
    public void CalculatesSubtotal()
    {
        var orderProcessor = new OrderProcessor();

        var order = new ShoppingCart
        {
            Items = new List<ShoppingCartItem>
            {
                new ShoppingCartItem() { Qty = 1, Price=1.99M},
                new ShoppingCartItem() { Qty = 3, Price=10.00M}
            }
        };
        // When
        OrderSummary summary = orderProcessor.ProcessOrder(order);


        decimal subTotal = summary.SubTotal;
        Assert.Equal(31.99M, subTotal);
    }
}
