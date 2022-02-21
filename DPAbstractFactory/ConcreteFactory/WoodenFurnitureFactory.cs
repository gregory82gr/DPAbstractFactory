using DPAbstractFactory.AbstractFactory;
using DPAbstractFactory.AbstractProduct;
using DPAbstractFactory.ConcreteProduct.WoodenProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAbstractFactory.ConcreteFactory
{
    class WoodenFurnitureFactory: IFurnitureFactory
    {
        public ITable CreateTable()
        {
            return new WoodenTable();
        }

        public IChair CreateChair()
        {
            return new WoodenChair();
        }
    }
}
