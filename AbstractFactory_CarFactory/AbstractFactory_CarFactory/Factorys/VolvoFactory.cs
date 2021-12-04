using AbstractFactory_CarFactory.Interfaces;
using AbstractFactory_CarFactory.Vehicles;
using AbstractFactory_CarFactory.Vehicles.Volvo;

namespace AbstractFactory_CarFactory.Factorys
{
    class VolvoFactory : IAbstractFactory
    {
        public IAbstractCar CreateCar() => new VolvoCar();

        public IAbstractMoto CreateMoto() => new VolvoMoto();

        public IAbstractTractor CreateTractor() => new VolvoTractor();
    }
}