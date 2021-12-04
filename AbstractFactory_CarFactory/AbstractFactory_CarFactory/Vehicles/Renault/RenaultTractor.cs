using AbstractFactory_CarFactory.Interfaces;

namespace AbstractFactory_CarFactory.Vehicles.Renault
{
    class RenaultTractor : IAbstractTractor
    {
        public string UsefulFunction() => "Tractor RENAULT ready!";
    }
}