using AbstractFactory_CarFactory.Interfaces;

namespace AbstractFactory_CarFactory.Vehicles.Renault
{
    class RenaultCar : IAbstractCar
    {
        public string UsefulFunction() => "Car RENAULT ready!";
    }
}