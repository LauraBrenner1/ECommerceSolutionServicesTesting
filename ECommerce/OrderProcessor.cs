namespace ECommerce
{
    public class OrderProcessor
    {
        public OrderProcessor()
        {
        }

        public OrderSummary ProcessOrder(ShoppingCart order)
        {

            var numberOfItems = order.Items.Count;
            if (numberOfItems == 0)
            {
                throw new CartCannotBeEmptyException();
            }
            var utils = new OrderProcessingUtilities();
            decimal subTotal = utils.GetSubtotalFromCart(order);

            var salesTax = new SalesTaxCalculator();
            decimal tax = salesTax.CalculateSalesTaxOnAmount(subTotal, order.ZipCode);
            return new OrderSummary
            {
                NumberOfItems = numberOfItems,
                SubTotal = subTotal,
                SalesTax = tax,
                Total = subTotal + tax
            };
        }

        
    }
}