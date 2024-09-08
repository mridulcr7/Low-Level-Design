namespace FactoryDesignPattern
{
    public class Cappuccino : ICoffee
    {
        public void milk()
        {
            Console.WriteLine("Preparing Milk for Cappuccino");
        }

        public void sugar()
        {
            Console.WriteLine("Preparing Sugar for Cappuccino");
        }
    }
}