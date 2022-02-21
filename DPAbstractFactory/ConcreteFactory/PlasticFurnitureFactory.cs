using DPAbstractFactory.AbstractFactory;
using DPAbstractFactory.AbstractProduct;
using DPAbstractFactory.ConcreteProduct.PlasticProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAbstractFactory.ConcreteFactory
{
    class PlasticFurnitureFactory : IFurnitureFactory
    {
        public ITable CreateTable()
        {
            return new PlasticTable();
        }

        public IChair CreateChair()
        {
            return new PlasticChair();
        }
    }
}
