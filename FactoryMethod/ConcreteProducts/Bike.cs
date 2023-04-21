﻿using FactoryMethod.ProductInterface;

namespace FactoryMethod.ConcreteProducts
{
    internal class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }
}
