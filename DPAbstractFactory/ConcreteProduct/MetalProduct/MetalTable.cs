using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPAbstractFactory.AbstractProduct;

namespace DPAbstractFactory.ConcreteProduct.MetalProduct
{
    class MetalTable : ITable
    {
        public MetalTable()
        {
            Console.WriteLine("Metal Table created");
        }
    }
}
