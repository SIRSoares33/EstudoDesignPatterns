namespace FactoryMethod.Entities
{
    /// <summary>
    /// Interface for mobilia
    /// </summary>
    public interface IFurniture
    {
        string Name { get; }
        string Color { get; }
        double Price { get; }
        string Material { get; }
    }
}