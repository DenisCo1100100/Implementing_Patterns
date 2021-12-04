using AbstractFactory_CarFactory.Interfaces;

namespace AbstractFactory_CarFactory.Vehicles.Renault
{
    class RenaultMoto : IAbstractMoto
    {
        public string UsefulFunction() => "Moto RENAULT ready!";
    }
}