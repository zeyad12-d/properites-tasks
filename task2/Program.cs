namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product product=new product();

            product.Name = "product1";
            product.price = 10;
            product.stock = 5;
            Console.WriteLine(product.stock);
            product.updataStock(8);
            Console.WriteLine(product.stock);
            product.downdataStock(8);
            Console.WriteLine(product.stock);
            // thinks
            Console.ReadKey();



        }
    }
}
