using AbstractFactory_CarFactory.Interfaces;
using AbstractFactory_CarFactory.Vehicles.Renault;

namespace AbstractFactory_CarFactory.Factorys
{
    class RenaultFactory : IAbstractFactory
    {
        public IAbstractCar CreateCar() => new RenaultCar();

        public IAbstractMoto CreateMoto() => new RenaultMoto();

        public IAbstractTractor CreateTractor() => new RenaultTractor();
    }
}