using DPAbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAbstractFactory.AbstractFactory
{
    interface IFurnitureFactory
    {
        ITable CreateTable();
        IChair CreateChair();
    }
}
