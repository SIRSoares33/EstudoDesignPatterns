using AbstractFactory.Entities;

namespace AbstractFactory.Factories.Constructors
{   
    /// <summary>
    /// Interface que define o contrato para as demais fábricas.
    /// </summary>
    public interface IConstructorsFactory
    {
        /// <summary>
        /// Cria um Suv.
        /// </summary>
        /// <returns></returns>
        ISuv CreateSuv();
        /// <summary>
        /// Cria um SportCar.
        /// </summary>
        /// <returns></returns>
        ISportCar CreateSportCar();
    }
}