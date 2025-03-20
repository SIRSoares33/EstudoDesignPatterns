namespace FactoryMethod.Entities
{
    /// <summary>
    /// Represents a chair
    /// </summary>
    public class Chair : IMobilia
    {
        public string Name => "Cadeira";
        public string Color => "Branco";
        public double Price => 1000.00;
        public string Material => "Plástico";
    }
}