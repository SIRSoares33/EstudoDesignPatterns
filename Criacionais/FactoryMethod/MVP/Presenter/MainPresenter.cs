using FactoryMethod.MVP.View.Main;

namespace FactoryMethod.MVP.Presenter
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
            _view.SendMobilia += SendMobAsync;

            _model = model;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Send mobilia list to the Txt.
        /// </summary>
        private async void SendMobAsync()
        {
            try
            {
                var IMobiliaList = await _model.ConvertMobiliaListStringToIMobiliaList(_view.MobListInString);

                await _model.CreateRelatory(IMobiliaList);

                _view.ShowMessageBox("Mobilia list sent successfully", "Success", MessageBoxIcon.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                _view.ShowMessageBox(ex.Message, "Error", MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
        }
        #endregion
    }
}