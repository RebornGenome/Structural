using PatternProxy;

class Program
{
    static void Main(string[] args)
    {   
        //Chief chief = new Chief();
        IChief chief = new ChiefProxy(new Chief());

        while (true)
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("{0, -25}\t{1}", "Название Заказа", "Статус");
            Console.WriteLine(new string('-', 50)+ "\n");

            IEnumerable<Order> orders = chief.GetOrders();

            foreach (Order order in orders)
            {
                string status = chief.GetStatuses().First(s => s.Key == order.StatusId).Value;

                Console.WriteLine($"{order.Name, -25}\t{status}");
            }
        }
    }
}