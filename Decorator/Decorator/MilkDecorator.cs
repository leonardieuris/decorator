using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MilkDecorator : DecoratorPattern
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
            _name = " milk";
            _price = 0.20;
        }
    }
}
