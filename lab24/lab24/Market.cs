namespace lab24
{
    public class Market
    {
        Product[] products ;
        public Market(Product[] products)
        {
            this.products = products;
        }

        public void Kassa()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductName} - Price: {product.Price} - Available Count: {product.AvailableCount}");

            }
        }
    }
}
