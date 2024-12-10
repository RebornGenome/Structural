using PatternDecorator.Coffee;
using PatternDecorator.Decorators;

class Program
{
    static void Main(string[] args)
    {
        ICoffee simpleCoffee = new BaseCoffee();
        Console.WriteLine($"Вид Кофе: {simpleCoffee.GetDescription()}");
        Console.WriteLine($"Цена: {simpleCoffee.GetPrice()}\n");

        ICoffee coffeeWithSyrup = new BaseCoffee();
        coffeeWithSyrup = new SyrupDecorator(coffeeWithSyrup);
        Console.WriteLine($"Вид Кофе: {coffeeWithSyrup.GetDescription()}");
        Console.WriteLine($"Цена: {coffeeWithSyrup.GetPrice()}");

        ICoffee coffeeWithChocolate = new BaseCoffee();
        coffeeWithChocolate = new ChocolateDecorator(coffeeWithChocolate);
        Console.WriteLine($"Вид Кофе: {coffeeWithChocolate.GetDescription()}");
        Console.WriteLine($"Цена: {coffeeWithChocolate.GetPrice()}");

        ICoffee coffeeWithCream = new BaseCoffee();
        coffeeWithCream = new CreamDecorator(coffeeWithCream);
        Console.WriteLine($"Вид Кофе: {coffeeWithCream.GetDescription()}");
        Console.WriteLine($"Цена: {coffeeWithCream.GetPrice()}");
    }
}