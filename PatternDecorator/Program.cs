using PatternDecorator.Coffee;
using PatternDecorator.Decorators;

class Program
{
    static void Main(string[] args)
    {
        ICoffee simpleCoffee = new BaseCoffee();
        simpleCoffee = new SaleDecorator(simpleCoffee);
        Console.WriteLine($"Вид Кофе: {simpleCoffee.GetDescription()}");
        Console.WriteLine($"Цена: {simpleCoffee.GetPrice()}\n");

        ICoffee coffeeWithSyrup = new BaseCoffee();
        coffeeWithSyrup = new SyrupDecorator(coffeeWithSyrup);
        coffeeWithSyrup = new SaleDecorator(coffeeWithSyrup);
        Console.WriteLine($"Вид Кофе: {coffeeWithSyrup.GetDescription()}");
        Console.WriteLine($"Цена: {coffeeWithSyrup.GetPrice()}");

        ICoffee coffeeWithChocolate = new BaseCoffee();
        coffeeWithChocolate = new ChocolateDecorator(coffeeWithChocolate);
        coffeeWithChocolate = new SaleDecorator(coffeeWithChocolate);
        Console.WriteLine($"Вид Кофе: {coffeeWithChocolate.GetDescription()}");
        Console.WriteLine($"Цена: {coffeeWithChocolate.GetPrice()}");

        ICoffee coffeeWithCream = new BaseCoffee();
        coffeeWithCream = new CreamDecorator(coffeeWithCream);
        coffeeWithCream = new SaleDecorator(coffeeWithCream);
        Console.WriteLine($"Вид Кофе: {coffeeWithCream.GetDescription()}");
        Console.WriteLine($"Цена: {coffeeWithCream.GetPrice()}");
    }
}