using PatternDecorator.Coffee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Decorators
{
    public class SyrupDecorator : CoffeeDecorator
    {
        public SyrupDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + " -> + Персиковый Сироп";
        }

        public override double GetPrice()
        {
            return _coffee.GetPrice() + 7.0;
        }
    }
}
