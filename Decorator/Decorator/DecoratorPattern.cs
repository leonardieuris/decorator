using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class DecoratorPattern : ICoffee
    {
        private readonly ICoffee _coffee;

        protected string _name = "";
        protected double _price = 0;

        public DecoratorPattern(ICoffee coffee)
        {
            _coffee = coffee;
        }


        public string GetDescription() => $"{_coffee.GetDescription()} {_name}";

        public double GetCost() => _coffee.GetCost() + _price;
    }
}
