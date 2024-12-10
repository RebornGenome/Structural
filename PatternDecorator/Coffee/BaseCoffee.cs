using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Coffee
{
    public class BaseCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Простое Кофе";
        }

        public double GetPrice()
        {
            return 20.0;
        }
    }
}
