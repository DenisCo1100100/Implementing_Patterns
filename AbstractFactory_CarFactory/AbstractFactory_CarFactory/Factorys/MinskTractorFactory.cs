using AbstractFactory_CarFactory.Interfaces;
using AbstractFactory_CarFactory.Vehicles.MTZ;

namespace AbstractFactory_CarFactory.Factorys
{
    class MinskTractorFactory : IAbstractFactory
    {
        public IAbstractCar CreateCar() => new GeelyCar();

        public IAbstractMoto CreateMoto() => new BlockMoto();

        public IAbstractTractor CreateTractor() => new BelarusTractor();
    }
}