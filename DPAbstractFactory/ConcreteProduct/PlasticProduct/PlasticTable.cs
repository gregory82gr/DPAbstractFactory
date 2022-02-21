using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPAbstractFactory.AbstractProduct;

namespace DPAbstractFactory.ConcreteProduct.PlasticProduct
{
    class PlasticTable:ITable
    {
        public PlasticTable()
        {
            Console.WriteLine("Plastic Table created");
        }
    }
}
