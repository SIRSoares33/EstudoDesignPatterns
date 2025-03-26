using AbstractFactory.Entities;

namespace AbstractFactory.Services
{
    /// <summary>
    /// Cria relatórios sobre carros.
    /// </summary>
    public interface ICreateCarRelatory
    {
        /// <summary>
        /// Cria um relatório sobre um Suv.
        /// </summary>
        /// <param name="suv"></param>
        /// <returns></returns>
        Task CreateRelatorySuv(ISuv suv);
        /// <summary>
        /// Cria um relatório sobre um carro esportivo.
        /// </summary>
        /// <param name="sportCar"></param>
        /// <returns></returns>
        Task CreateRelatorySportCar(ISportCar sportCar);
    }
}