namespace AbstractFactory.Entities
{
    public interface ISuv
    {
        string ConstructorName { get; }
        string Model { get; }       
        int SeatingCapacity { get; } 
        double OffRoadCapability { get; }
    }
}