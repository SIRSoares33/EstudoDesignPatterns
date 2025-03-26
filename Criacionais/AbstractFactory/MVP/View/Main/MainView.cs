using AbstractFactory.MVP.View.Main;

namespace AbstractFactory;

public partial class MainView : Form, IMainView
{
    #region Constructor
    public MainView() => InitializeComponent();
    #endregion

    #region IMainView Attributes
    public string SelectedConstructor => cmbConstructor.Text;
    #endregion

    #region IMainView Events
    public event Action? SaveSuv;
    public event Action? SaveSportCar;
    #endregion

    #region IMainView Methods
    public void ShowMessageBox(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        => MessageBox.Show(message, caption, buttons, icon);
    #endregion

    #region Event Handlers
    private void SavingSuv(object sender, EventArgs e)      => SaveSuv?.Invoke();
    private void SavingSportCar(object sender, EventArgs e) => SaveSportCar?.Invoke();
    #endregion
}