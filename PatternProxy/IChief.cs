using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProxy
{
    public interface IChief
    {
         IDictionary<int, string> GetStatuses();

         IEnumerable<Order> GetOrders();
    }
}
