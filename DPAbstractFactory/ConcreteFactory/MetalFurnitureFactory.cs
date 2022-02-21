using DPAbstractFactory.AbstractFactory;
using DPAbstractFactory.AbstractProduct;
using DPAbstractFactory.ConcreteProduct.MetalProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAbstractFactory.ConcreteFactory
{
    class MetalFurnitureFactory : IFurnitureFactory
    {
        public ITable CreateTable()
        {
            return new MetalTable();
        }

        public IChair CreateChair()
        {
            return new MetalChair();
        }
    }
}
