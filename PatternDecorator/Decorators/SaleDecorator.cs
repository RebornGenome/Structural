using PatternDecorator.Coffee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Decorators
{
    public class SaleDecorator : CoffeeDecorator
    {
        public SaleDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + " -> + Скидка 25%";
        }

        public override double GetPrice()
        {
            return _coffee.GetPrice() * 0.75;
        }
    }
}
