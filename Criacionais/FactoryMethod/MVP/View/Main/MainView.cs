using FactoryMethod.MVP.View.Main;

namespace FactoryMethod;

public partial class MainView : Form, IMainView
{
    #region Constructor
    public MainView() => InitializeComponent();
    #endregion

    #region IMainView Attributes
    public List<string> FurnitureListInString { get => lstChosenFurniture.Items.Cast<string>().ToList(); }
    #endregion

    #region IMainView Events
    public event Action? SendFurniture;
    #endregion

    #region IMainView Methods
    public void ShowMessageBox(string message, string caption, MessageBoxIcon icon, MessageBoxButtons buttons) 
        => MessageBox.Show(message, caption, buttons, icon);
    #endregion

    #region Event Handlers
    private void AddChosenFurniture(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(cmbFurnitureAvaible.SelectedText))
        { 
            ShowMessageBox("Please select a mobilia", "Error", MessageBoxIcon.Error, MessageBoxButtons.OK);
            return;
        }
        lstChosenFurniture.Items.Add(cmbFurnitureAvaible.SelectedText);
    }
    private void RemoveChosenFurniture(object sender, EventArgs e) => lstChosenFurniture.Items.Remove(lstChosenFurniture.SelectedItem ?? string.Empty);
    private void SendingFurniture(object sender, EventArgs e)      => SendFurniture?.Invoke();
    private void Exit(object sender, EventArgs e)                  => Application.Exit();
    #endregion
}