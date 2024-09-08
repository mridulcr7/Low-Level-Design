namespace FactoryDesignPattern
{
    public class Espresso : ICoffee
    {
        public void milk()
        {
            Console.WriteLine("Preparing Milk for Espresso");
        }

        public void sugar()
        {
            Console.WriteLine("Preparing Sugar for Espresso");
        }
    }
}