using AbstractFactory.Entities;
using AbstractFactory.Services.Relatory.RelatoryFormatters;

namespace AbstractFactory.Services
{
    /// <summary>
    /// Classe responsável por criar relatórios de carros.
    /// </summary>
    /// <param name="relatoryCarFormatter"></param>
    public class CreateCarRelatory(IRelatoryCarFormatter relatoryCarFormatter) : ICreateCarRelatory
    {
        #region Formatter
        private readonly IRelatoryCarFormatter _relatoryFormatter = relatoryCarFormatter;
        #endregion
        
        #region ICreateCarRelatory Methods
        public Task CreateRelatorySuv(ISuv suv) 
            => _relatoryFormatter.CreateRelatorySuv(suv);
        public Task CreateRelatorySportCar(ISportCar sportCar) 
            => _relatoryFormatter.CreateRelatorySportCar(sportCar);
        #endregion
    }
}