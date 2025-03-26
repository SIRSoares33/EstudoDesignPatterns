namespace AbstractFactory.Entities
{
    public interface ISportCar
    {
        string ConstructorName { get; }
        string Model { get; }
        int HorsePower { get; }
        double Acceleration { get; } 
    }
}