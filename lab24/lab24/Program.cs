using lab24;

internal class Program
{
    static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product("Test",10,5),
            new Product("Salvar",30,3)
        };
        Market market = new Market(products);
        market.Kassa();

        Customer customer = new Customer
        {
            Name = "Ali",
            Surname = "Aliyev",
            CashBalance = 100,
            CardBalance = 200
        };
        customer.InBasket(products[0], Payment.CashBalance);
    }
}

