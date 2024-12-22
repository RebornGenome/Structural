using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProxy
{
    public class Chief : IChief 
    {
        public IDictionary<int, string> GetStatuses()
        {
            Dictionary<int, string> statuses = new Dictionary<int, string>();

            statuses.Add(1, "Готово");
            statuses.Add(2, "Не Готово");
            statuses.Add(3, "Готовится");

            //Иммитируем задрежку, которую нужно решить путем Кэширования
            Thread.Sleep(3000);

            return statuses;
        }

        public IEnumerable<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();

            orders.Add(new Order() { Name = "Пицца Сицилиана", StatusId = RandomizeStatus() });
            orders.Add(new Order() { Name = "Кофе Латте", StatusId = RandomizeStatus() });
            orders.Add(new Order() { Name = "Кофе Капучино", StatusId = RandomizeStatus() });
            orders.Add(new Order() { Name = "Бокал Пива", StatusId = RandomizeStatus() });
            orders.Add(new Order() { Name = "Картошка-Фри", StatusId = RandomizeStatus() });
            orders.Add(new Order() { Name = "Салат Цезарь", StatusId = RandomizeStatus() });
            orders.Add(new Order() { Name = "Шампанское MiPiece", StatusId = RandomizeStatus() });
            orders.Add(new Order() { Name = "Фруктовое Мороженное", StatusId = RandomizeStatus() });

            return orders;
        }

        public static int RandomizeStatus() => new Random().Next(1, 4);
    }
}
