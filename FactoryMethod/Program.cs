using FactoryMethod.Creator;
using FactoryMethod.Creator.ConcreteCreator;
using FactoryMethod.ProductInterface;

VehicleFactory factory = new ConcreteVehicleFactory();

IFactory scooter = factory.GetVehicle("Scooter");
scooter.Drive(10);

IFactory bike = factory.GetVehicle("Bike");
bike.Drive(20);

Console.ReadKey();