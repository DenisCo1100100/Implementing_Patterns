using AbstractFactory_CarFactory.Interfaces;

namespace AbstractFactory_CarFactory.Vehicles
{
    class VolvoCar : IAbstractCar
    {
        public string UsefulFunction() => "Car VOLVO ready!";
    }
}