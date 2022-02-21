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
            Console.Write("Enter W,P or M: ");
            string val = Console.ReadLine();
            if (val == "W")
            {
                Console.WriteLine("Wooden Factory");
                IFurnitureFactory woodenFurnitureFactory = new WoodenFurnitureFactory();
                FurnitureClient clientW = new FurnitureClient(woodenFurnitureFactory);
            } else if (val == "P") {
                Console.WriteLine("Plastic Factory");
                IFurnitureFactory plasticFurnitureFactory = new PlasticFurnitureFactory();
                FurnitureClient clientP = new FurnitureClient(plasticFurnitureFactory);
            } else if (val == "M") { 
                Console.WriteLine("Metal Factory");
                IFurnitureFactory metalFurnitureFactory = new MetalFurnitureFactory();
                FurnitureClient clientM = new FurnitureClient(metalFurnitureFactory);
            }
        // Wait for user input
            Console.ReadKey();
        }
    }
}
