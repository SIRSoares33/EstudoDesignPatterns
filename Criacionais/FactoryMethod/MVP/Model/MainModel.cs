using FactoryMethod.Adapters.Mobilia;
using FactoryMethod.Entities;
using FactoryMethod.factories;
using FactoryMethod.Services;

namespace FactoryMethod.MVP.Model
{
    public class MainModel : IMainModel
    {
        #region Dependencies
        /// <summary>
        /// Factory creator to create the mobilia factory
        /// </summary>
        private readonly IFurnitureFactoryCreator _furnitureFactoryCreator;
        /// <summary>
        /// Adapter to convert the mobilia list to a list of IMobilia objects
        /// </summary>
        private readonly IFurnitureAdapter _furnitureAdapter;
        /// <summary>
        /// Service to create the relatory
        /// </summary>
        private readonly IFurnitureRelatory _furnitureRelatory;
        #endregion

        #region Constructor
        public MainModel(IFurnitureFactoryCreator furnitureFactory, IFurnitureAdapter furnitureAdapter, IFurnitureRelatory furnitureRelatory)
        {
            _furnitureFactoryCreator = furnitureFactory;
            _furnitureAdapter        = furnitureAdapter;
            _furnitureRelatory       = furnitureRelatory;
        }
        #endregion

        #region IMainModel Methods
        public Task<List<IFurniture>> ConvertMobiliaListStringToIFurnitureList(List<string> furnitureListInString)
            => Task.Run(() => _furnitureAdapter.ConvertMobiliaListStringToIMobiliaList(furnitureListInString, _furnitureFactoryCreator));

        public Task CreateFurnitureRelatory(List<IFurniture> furnituries)
            => _furnitureRelatory.CreateRelatoryByList(furnituries);
        #endregion
    }
} 