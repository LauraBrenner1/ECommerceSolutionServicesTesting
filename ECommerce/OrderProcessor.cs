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
            return new OrderSummary
            {
                NumberOfItems = numberOfItems,
                SubTotal = subTotal,
            };
        }

        
    }
}