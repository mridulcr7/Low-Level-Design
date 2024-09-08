namespace FactoryDesignPattern
{
    public class CoffeeServer
    {
       
        public ICoffee serveCoffee(string coffeeType)
        {
            ICoffee coffee = new CoffeeFactory().createCoffee(coffeeType);
            coffee.milk();
            coffee.sugar();
            return coffee;
        }

    }
}