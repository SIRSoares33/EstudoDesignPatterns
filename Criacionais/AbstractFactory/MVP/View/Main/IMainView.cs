namespace AbstractFactory.MVP.View.Main
{
    public interface IMainView
    {
        string SelectedConstructor { get; }

        event Action? SaveSuv;
        event Action? SaveSportCar;

        void ShowMessageBox(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);
    }
}
