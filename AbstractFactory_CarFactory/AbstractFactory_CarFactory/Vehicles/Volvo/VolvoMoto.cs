using AbstractFactory_CarFactory.Interfaces;

namespace AbstractFactory_CarFactory.Vehicles.Volvo
{
    class VolvoMoto : IAbstractMoto
    {
        public string UsefulFunction() => "Moto VOLVO ready!";
    }
}