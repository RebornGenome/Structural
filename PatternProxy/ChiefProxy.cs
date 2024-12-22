using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProxy
{
    public class ChiefProxy : IChief
    {
        private readonly IChief _chief;


        //Кэширование - как буд-то нас об этом попросил Team-Lead
        //И мы такие: "Ооо, эту задачу и задачу ниже позволяет реализовать
        //Паттерн Proxy":
        private IDictionary<int, string> _statuses;

        public ChiefProxy(Chief chief)
        {
            _chief = chief;
        }

        public IEnumerable<Order> GetOrders()
        {
            //Типо залогировали обращение - как буд-то нас об этом тоже попросил Team-Lead:
            Console.WriteLine(new string(' ', 13) + $"[{DateTime.Now:dd.MM.yyyy HH.mm.ss}]\n");

            return _chief.GetOrders();
        }

        public IDictionary<int, string> GetStatuses()
        {
            //Т.к. мы выше Закэшировали Словарь статусов, если он не заполнен,
            //То нам нужно проксировать запрос к Шефу, либо в противном случаем возвращаем уже
            //Закэшированный словарь => Получается так, что мы за Статусами к Шефу обращаемся ЕДИНОЖДЫ
            if (_statuses == null)
            {
                _statuses = _chief.GetStatuses();
            }

            return _statuses;

            //return _chief.GetStatuses();
        }
    }
}
