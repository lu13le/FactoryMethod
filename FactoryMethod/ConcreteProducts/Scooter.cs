using FactoryMethod.ProductInterface;

namespace FactoryMethod.ConcreteProducts
{
    internal class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }
}
