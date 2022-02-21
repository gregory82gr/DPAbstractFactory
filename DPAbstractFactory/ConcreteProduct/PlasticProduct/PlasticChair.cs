using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPAbstractFactory.AbstractProduct;

namespace DPAbstractFactory.ConcreteProduct.PlasticProduct
{
    class PlasticChair : IChair
    {
        public PlasticChair()
        {
            Console.WriteLine("Plasti chair created");
        }
    }
}
