namespace ECommerce
{
    public class SalesTaxCalculator
    {
        public SalesTaxCalculator()
        {
        }

        public decimal CalculateSalesTaxOnAmount(decimal amountOfSale, string zipCode)
        {
           if(zipCode == "44107")
            {
                return amountOfSale * .072M;
            } else
            {
                return amountOfSale * .10M;
            }
            
        }
    }
}