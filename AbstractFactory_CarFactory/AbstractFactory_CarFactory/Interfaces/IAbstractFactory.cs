namespace AbstractFactory_CarFactory.Interfaces
{
    interface IAbstractFactory
    {
        IAbstractCar CreateCar();
        IAbstractTractor CreateTractor();
        IAbstractMoto CreateMoto();
    }
}
