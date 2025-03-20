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
        private readonly IMobiliaFactoryCreator _mobiliaFactoryCreator;
        /// <summary>
        /// Adapter to convert the mobilia list to a list of IMobilia objects
        /// </summary>
        private readonly IMobiliaAdapter _mobiliaAdapter;
        /// <summary>
        /// Service to create the relatory
        /// </summary>
        private readonly IMobiliaRelatory _createMobiliaRelatory;
        #endregion

        #region Constructor
        public MainModel(IMobiliaFactoryCreator mobiliaFactory, IMobiliaAdapter mobiliaAdapter, IMobiliaRelatory createMobiliaRelatory)
        {
            _mobiliaFactoryCreator = mobiliaFactory;
            _mobiliaAdapter        = mobiliaAdapter;
            _createMobiliaRelatory = createMobiliaRelatory;
        }
        #endregion

        #region IMainModel Methods
        public Task<List<IMobilia>> ConvertMobiliaListStringToIMobiliaList(List<string> mobList)
            => Task.Run(() => _mobiliaAdapter.ConvertMobiliaListStringToIMobiliaList(mobList, _mobiliaFactoryCreator));

        public Task CreateRelatory(List<IMobilia> mobList)
            => _createMobiliaRelatory.CreateRelatoryByList(mobList);
        #endregion
    }
} 