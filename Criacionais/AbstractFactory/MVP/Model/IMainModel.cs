using AbstractFactory.Entities;
using AbstractFactory.Factories.Constructors;

namespace AbstractFactory.MVP.Model
{
    public interface IMainModel
    {
        /// <summary>
        /// Aponta para a Interface <c>IConstructorsFactoryCreator</c> para retornar a fábrica solicitada pelo nome da mesma.
        /// </summary>
        /// <param name="constructorName"></param>
        /// <returns></returns>
        IConstructorsFactory GetConstructorFactoryByString(string constructorName);
        /// <summary>
        /// Aponta para a Interface <c>ICreateCarRelatory</c> para criação de um relatório sobre um Suv.
        /// </summary>
        /// <param name="suv"></param>
        /// <returns></returns>
        Task CreateSuvRelatory(ISuv suv);
         /// <summary>
        /// Aponta para a Interface <c>ICreateCarRelatory</c> para criação de um relatório sobre um SportCar.
        /// </summary>
        /// <param name="sportCar"></param>
        /// <returns></returns>
        Task CreateSportCarRelatory(ISportCar sportCar);
    }
}