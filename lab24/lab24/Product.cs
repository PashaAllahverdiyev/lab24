namespace lab24
{
    public class Product

    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int AvailableCount { get; set; }
        public int InStockCount { get; set; }
        public Product(string productname, double price,int availableCount)
        {
            ProductName = productname;
            Price = price;
            AvailableCount = availableCount;
            InStockCount = InStockCount;
        }
    }
}
