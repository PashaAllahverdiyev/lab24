namespace lab24
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double CashBalance { get; set; }
        public double CardBalance { get; set; }

        public void InBasket(Product product, Payment paymentMethod)
        {
            if (product.AvailableCount > 0)
            {
                if (paymentMethod == Payment.CashBalance && CashBalance >= product.Price)
                {
                    CashBalance -= product.Price;
                    Console.WriteLine($"Purchased {product.ProductName} for {product.Price} from cash balance.");
                }
                else if (paymentMethod == Payment.CardBalance && CardBalance >= product.Price)
                {
                    CardBalance -= product.Price;
                    Console.WriteLine($"Purchased {product.ProductName} for {product.Price} from card balance.");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Product out of stock.");
            }

        }   
    }
}
