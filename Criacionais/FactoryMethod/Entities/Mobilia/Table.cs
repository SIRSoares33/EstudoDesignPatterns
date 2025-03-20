namespace FactoryMethod.Entities
{
    /// <summary>
    /// Represents a table
    /// </summary>
    public class Table : IFurniture
    {
        public string Name => "Mesa";

        public string Color => "Marrom";
        public double Price => 2000.00;
        public string Material => "Madeira";
    }
}