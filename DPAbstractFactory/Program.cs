using DPAbstractFactory.AbstractFactory;
using DPAbstractFactory.Client;
using DPAbstractFactory.ConcreteFactory;
using System;

namespace DPAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Wooden Factory");
            IFurnitureFactory woodenFurnitureFactory = new WoodenFurnitureFactory();
            FurnitureClient clientW = new FurnitureClient(woodenFurnitureFactory);

            Console.WriteLine("Plastic Factory");
            IFurnitureFactory plasticFurnitureFactory = new PlasticFurnitureFactory();
            FurnitureClient clientP = new FurnitureClient(plasticFurnitureFactory);

            Console.WriteLine("Metal Factory");
            IFurnitureFactory metalFurnitureFactory = new MetalFurnitureFactory();
            FurnitureClient clientM = new FurnitureClient(metalFurnitureFactory);
            // Wait for user input
            Console.ReadKey();
        }
    }
}
