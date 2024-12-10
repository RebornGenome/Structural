using PatternDecorator.Coffee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Decorators
{
    public class ChocolateDecorator : CoffeeDecorator
    {
        public ChocolateDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + " -> + Шоколадная Крошка";
        }

        public override double GetPrice()
        {
            return _coffee.GetPrice() + 5.0;
        }
    }
}
