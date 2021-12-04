using AbstractFactory_CarFactory.Interfaces;

namespace AbstractFactory_CarFactory.Vehicles.MTZ
{
    class BelarusTractor : IAbstractTractor
    {
        public string UsefulFunction() => "Tractor BELARUS ready!";
    }
}