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
            var subTotal = order.Items.Sum(i => i.Qty * i.Price);
            return new OrderSummary { 
                NumberOfItems = numberOfItems,
                SubTotal = subTotal,
            };
        }
    }
}