using AbstractFactory.Factories.Constructors;
using AbstractFactory.MVP.Model;
using AbstractFactory.MVP.View.Main;

namespace AbstractFactory.MVP.Presenter
{
    public class MainPresenter
    {
        #region Entities
        private readonly IMainView _view;
        private readonly IMainModel _model;
        #endregion

        #region Constructor
        public MainPresenter(IMainView view, IMainModel model)
        {
            _view = view;
            _view.SaveSuv       += CreateSuvRelatoryAsync;
            _view.SaveSportCar  += CreateSportCarRelatoryAsync;

            _model = model;
        }
        #endregion

        #region Methods
        private IConstructorsFactory GetCurrentFactory()
        {
            if (string.IsNullOrEmpty(_view.SelectedConstructor))
                throw new Exception("Please, choose your constructor!");

            return _model.GetConstructorFactoryByString(_view.SelectedConstructor);
        }

        private async void CreateSuvRelatoryAsync()
        {
            try
            {
                await _model.CreateSuvRelatory(GetCurrentFactory().CreateSuv());
            }
            catch(Exception ex)
            {
                _view.ShowMessageBox(ex.Message, "Erro ao criar o relatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CreateSportCarRelatoryAsync()
        {
            try
            {
                await _model.CreateSportCarRelatory(GetCurrentFactory().CreateSportCar());
            }
            catch(Exception ex)
            {
                _view.ShowMessageBox(ex.Message, "Erro ao criar o relatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}