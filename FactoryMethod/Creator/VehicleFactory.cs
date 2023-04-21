using FactoryMethod.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator
{
    abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string vehicle);
    }
}
