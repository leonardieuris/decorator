using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ChoccolateDecorator : DecoratorPattern
    {
        public ChoccolateDecorator(ICoffee coffee) : base(coffee)
        {
            _name = "Choccolate";
            _price = 0.30;
        }
    }
}
