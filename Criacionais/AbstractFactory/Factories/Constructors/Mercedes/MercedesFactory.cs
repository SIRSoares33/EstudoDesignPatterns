using AbstractFactory.Entities;

namespace AbstractFactory.Factories.Constructors.Mercedes
{
    public class MercedesFactory : IConstructorsFactory
    {
        public ISportCar CreateSportCar() 
            => new W11();
        public ISuv CreateSuv() 
            => new MercedesGLE();
    }

    internal class MercedesGLE : ISuv
    {
        public string ConstructorName => "Mercedes Benz";
        public string Model => "GLE";
        public int SeatingCapacity => 5;
        public double OffRoadCapability => 2.4;
    }

    internal class W11 : ISportCar
    {
        public string ConstructorName => "Mercedes-AMG-Petronas";
        public string Model => "W11 (F1 Car)";
        public int HorsePower => 1200;
        public double Acceleration => 2.3;
    }
}