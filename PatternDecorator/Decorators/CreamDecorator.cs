using PatternDecorator.Coffee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Decorators
{
    public class CreamDecorator : CoffeeDecorator
    {
        public CreamDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + " -> + Сливки";
        }

        public override double GetPrice()
        {
            return _coffee.GetPrice() + 2.0;
        }
    }
}
