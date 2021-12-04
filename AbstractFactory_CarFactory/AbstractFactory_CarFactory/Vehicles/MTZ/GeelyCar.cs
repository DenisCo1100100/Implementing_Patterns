using AbstractFactory_CarFactory.Interfaces;

namespace AbstractFactory_CarFactory.Vehicles.MTZ
{
    class GeelyCar : IAbstractCar
    {
        public string UsefulFunction() => "Car BELARUS ready!";
    }
}