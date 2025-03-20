namespace FactoryMethod.Entities
{
    public class Bed : IMobilia
    {
        public string Name => "Cama";

        public string Color => "Branco";

        public double Price => 500.00;

        public string Material => "Madeira";
    }
}