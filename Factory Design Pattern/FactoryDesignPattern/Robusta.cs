namespace FactoryDesignPattern
{
    public class Robusta : ICoffee
    {
        public void milk()
        {
            Console.WriteLine("Preparing Milk for Robusta");
        }

        public void sugar()
        {
            Console.WriteLine("Preparing Sugar for Robusta");
        }
    }
}