using AbstractFactory.Entities;
using AbstractFactory.Factories.Constructors;
using AbstractFactory.Services;

namespace AbstractFactory.MVP.Model
{
    public class MainModel(IConstructorsFactoryCreator constructorsFactoryCreator, ICreateCarRelatory createCarRelatory): IMainModel
    {
        #region Dependencies
        private readonly IConstructorsFactoryCreator _constructorsFactoryCreator = constructorsFactoryCreator;
        private readonly ICreateCarRelatory _createCarRelatory = createCarRelatory;
        #endregion

        #region IMainModel Methods
        public IConstructorsFactory GetConstructorFactoryByString(string constructorName) 
            => _constructorsFactoryCreator.GetConstructorFactoryByString(constructorName);

        public Task CreateSuvRelatory(ISuv suv)
            => _createCarRelatory.CreateRelatorySuv(suv);
        
        public Task CreateSportCarRelatory(ISportCar sportCar)
            => _createCarRelatory.CreateRelatorySportCar(sportCar);
        #endregion
    }
}