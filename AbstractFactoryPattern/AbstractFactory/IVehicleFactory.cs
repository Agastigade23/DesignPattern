using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.AbstractFactory
{
    public interface IVehicleFactory
    {
        IBike CreateBike();
        ICar CreateCar();
    }
}
