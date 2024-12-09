using PatternAdapter.RealizationAdapter;
using PatternAdapter.Targets;

class Program
{
    static void Main(string[] args)
    {
        IDuck duck = new Duck();
        IFrog frog = new Frog();

        Console.WriteLine("Демонстрация Утки:");
        duck.Quack();
        duck.Fly();

        Console.WriteLine("\nДемонстрация Лягушки:");
        frog.Croak();
        frog.Jump();

        Console.WriteLine("\nДемонстрация Адаптируемой Лягушки:");
        IDuck adaptedFrog = new FrogAdapter(frog);
        adaptedFrog.Quack();
        adaptedFrog.Fly();
    }
}