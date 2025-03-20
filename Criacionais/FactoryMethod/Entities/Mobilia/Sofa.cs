namespace FactoryMethod.Entities
{
    /// <summary>
    /// Represents a sofa
    /// </summary>
    public class Sofa : IMobilia
    {
        public string Name => "Sofá";
        public string Color => "Preto";
        public double Price => 4000.00;
        public string Material => "Couro";
    }
}