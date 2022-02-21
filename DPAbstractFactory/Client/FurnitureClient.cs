using DPAbstractFactory.AbstractFactory;
using DPAbstractFactory.AbstractProduct;
using DPAbstractFactory.ConcreteProduct.MetalProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAbstractFactory.Client
{
    class FurnitureClient
    {
        private IChair _chair;
        private ITable _table;

        public FurnitureClient(IFurnitureFactory factory)
        {
            _chair = factory.CreateChair();
            _table = factory.CreateTable();
        }

    }
}
