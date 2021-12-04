using AbstractFactory_CarFactory.Interfaces;

namespace AbstractFactory_CarFactory.Vehicles.Volvo
{
    class VolvoTractor : IAbstractTractor
    {
        public string UsefulFunction() => "Tractor VOLVO ready!";
    }
}