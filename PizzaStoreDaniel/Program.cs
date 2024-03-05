namespace PizzaStoreDaniel
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Her kalder jeg på start metoden 
            Store pizzaStore = new Store();
            pizzaStore.Start();

            Console.ReadKey();

        }
    }
}
