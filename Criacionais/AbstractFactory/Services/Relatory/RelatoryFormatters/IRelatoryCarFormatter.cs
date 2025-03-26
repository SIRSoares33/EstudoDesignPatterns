using AbstractFactory.Entities;

namespace AbstractFactory.Services.Relatory.RelatoryFormatters
{
    /// <summary>
    /// Interface que define como o relatório é criado (.txt, .json. xml...)
    /// </summary>
    public interface IRelatoryCarFormatter
    {
        /// <summary>
        /// Cria um relatório sobre o Suv.
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