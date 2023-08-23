using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Interface;


namespace AbstractFactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory _RegularVehicleFactory = new RegularVehicleFactory();

            IBike regularbike=_RegularVehicleFactory.CreateBike();
            regularbike.GetDetails();

            ICar regularCar = _RegularVehicleFactory.CreateCar();
            regularCar.GetDetails();

            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();

            IBike sportsBike = sportsVehicleFactory.CreateBike();
            sportsBike.GetDetails();

            ICar sportsCar = sportsVehicleFactory.CreateCar();
            sportsCar.GetDetails();
            Console.ReadKey();
        }
    }
}