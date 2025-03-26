using AbstractFactory.Entities;

namespace AbstractFactory.Services.Relatory.RelatoryFormatters
{
    /// <summary>
    /// Cria relatórios de carro do tipo .txt
    /// </summary>
    public class RelatoryTextCarFormatter : IRelatoryCarFormatter
    {
        public Task CreateRelatorySportCar(ISportCar sportCar)
        {
            using(var sw = new StreamWriter("SportCar.txt"))
            {
                sw.WriteLine("SportCar Details:");
                sw.WriteLine("Constructor: " + sportCar.ConstructorName);
                sw.WriteLine("Model: " + sportCar.Model);
                sw.WriteLine("Acceleration: " + sportCar.Acceleration);
                sw.WriteLine("HorsePower: " + sportCar.HorsePower);
            }

            return Task.CompletedTask;
        }

        public Task CreateRelatorySuv(ISuv suv)
        {
            using(var sw = new StreamWriter("Suv.txt"))
            {
                sw.WriteLine("Suv Details:");
                sw.WriteLine("Constructor: " + suv.ConstructorName);
                sw.WriteLine("Model: " + suv.Model);
                sw.WriteLine("Seating Capacity: " + suv.SeatingCapacity);
                sw.WriteLine("OffRoadCapability: " + suv.OffRoadCapability);
            }

            return Task.CompletedTask;
        }
    }
}