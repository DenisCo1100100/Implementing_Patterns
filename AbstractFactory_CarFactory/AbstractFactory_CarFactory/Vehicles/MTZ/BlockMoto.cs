using AbstractFactory_CarFactory.Interfaces;

namespace AbstractFactory_CarFactory.Vehicles.MTZ
{
    class BlockMoto : IAbstractMoto
    {
        public string UsefulFunction() => "Moto BELARUS ready!";
    }
}