using AbstractFactory.Entities;

namespace AbstractFactory.Factories.Constructors.Ferrari
{
    public class FerrariFactory: IConstructorsFactory
    {
        public ISportCar CreateSportCar()
            => new FerrariSportCar();
        public ISuv CreateSuv()
            => new FerrariSuv();
    }

    internal class FerrariSuv : ISuv
    {
        public string ConstructorName => "Ferrari";
        public string Model => "Ferrari Purosangue";
        public int SeatingCapacity => 5;
        public double OffRoadCapability => 8.5;
    }

    internal class FerrariSportCar : ISportCar
    {
        public string ConstructorName => "Ferrari";
        public string Model => "Ferrari 488";
        public int HorsePower => 700;
        public double Acceleration => 3.2;
    }
}