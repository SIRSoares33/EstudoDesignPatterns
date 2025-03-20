using FactoryMethod.Entities;

namespace FactoryMethod.Services
{
    public class TextRelatoryFormatter : IRelatoryFormatter
    {
        public Task Format(StreamWriter writer, List<IFurniture> furnituries)
        {
            writer.WriteLine("Mobilia List");
            writer.WriteLine("-------------");

            foreach (IFurniture furniture in furnituries)
            {
                writer.WriteLine("Mobilia: " + furniture.Name);
                writer.WriteLine("Price: " + furniture.Price);
                writer.WriteLine("Material: " + furniture.Material);
                writer.WriteLine("Color: " + furniture.Color);
                writer.WriteLine("-------------");
            }

            writer.WriteLine("Total price: " + furnituries.Sum(mob => mob.Price));

            return Task.CompletedTask;
        }
    }
}