using AbstractFactory_CarFactory.Factorys;
using AbstractFactory_CarFactory.Interfaces;
using System;

namespace AbstractFactory_CarFactory
{
    class Client
    {
        public void Main()
        {
            IAbstractFactory[] factories = new IAbstractFactory[]
            {
                new MinskTractorFactory(),
                new RenaultFactory(),
                new VolvoFactory()
            };

            foreach (var factory in factories)
            {
                Console.WriteLine($"Start factory: ");
                ClientMethod(factory);
                Console.WriteLine();
            }
        }

        private static void ClientMethod(IAbstractFactory factory)
        {
            var car = factory.CreateCar();
            var tractor = factory.CreateTractor();
            var moto = factory.CreateMoto();

            Console.WriteLine(car.UsefulFunction());
            Console.WriteLine(tractor.UsefulFunction());
            Console.WriteLine(moto.UsefulFunction());
        }
    }
}