namespace FactoryDesignPattern
{
    public class CoffeeFactory
    {
        public ICoffee createCoffee(string coffeeType)
        {
            if (coffeeType == "Cappuccino")
                return new Cappuccino();
            else if (coffeeType == "Espresso")
                return new Espresso();
            else if (coffeeType == "Robusta")
                return new Robusta();
            else
                throw new Exception("Invalid Coffee Type");
        }
    }
}