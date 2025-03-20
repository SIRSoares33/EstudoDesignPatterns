using FactoryMethod.Entities;

namespace FactoryMethod.Services
{
    public class TextRelatoryFormatter : IRelatoryFormatter
    {
        public Task Format(StreamWriter writer, List<IMobilia> mobList)
        {
            writer.WriteLine("Mobilia List");
            writer.WriteLine("-------------");

            foreach (var mobilia in mobList)
            {
                writer.WriteLine("Mobilia: " + mobilia.Name);
                writer.WriteLine("Price: " + mobilia.Price);
                writer.WriteLine("Material: " + mobilia.Material);
                writer.WriteLine("Color: " + mobilia.Color);
                writer.WriteLine("-------------");
            }

            writer.WriteLine("Total price: " + mobList.Sum(mob => mob.Price));

            return Task.CompletedTask;
        }
    }
}