using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPAbstractFactory.AbstractProduct;

namespace DPAbstractFactory.ConcreteProduct.MetalProduct
{
    class MetalChair : IChair
    {
        public MetalChair()
        {
            Console.WriteLine("Metal chair created");
        }
    }
}
