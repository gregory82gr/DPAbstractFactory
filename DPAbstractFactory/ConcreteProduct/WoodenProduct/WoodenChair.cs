using DPAbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAbstractFactory.ConcreteProduct.WoodenProduct
{
    class WoodenChair: IChair
    {
        public WoodenChair()
        {
            Console.WriteLine("Wooden chair created");
        }
    }
}
