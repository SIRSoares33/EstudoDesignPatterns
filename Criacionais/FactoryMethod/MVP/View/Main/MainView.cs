using FactoryMethod.MVP.View.Main;

namespace FactoryMethod;

public partial class MainView : Form, IMainView
{
    #region Constructor
    public MainView() => InitializeComponent();
    #endregion

    #region IMainView Attributes
    public List<string> MobListInString { get => lstMob.Items.Cast<string>().ToList(); }
    #endregion

    #region IMainView Events
    public event Action? SendMobilia;
    #endregion

    #region IMainView Methods
    public void ShowMessageBox(string message, string caption, MessageBoxIcon icon, MessageBoxButtons buttons) 
        => MessageBox.Show(message, caption, buttons, icon);
    #endregion

    #region Event Handlers
    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(cmbMob.SelectedText))
        { 
            ShowMessageBox("Please select a mobilia", "Error", MessageBoxIcon.Error, MessageBoxButtons.OK);
            return;
        }
        lstMob.Items.Add(cmbMob.SelectedText);
    }
    private void btnRemove_Click(object sender, EventArgs e) => lstMob.Items.Remove(lstMob.SelectedItem ?? string.Empty);
    private void btnSend_Click(object sender, EventArgs e)   => SendMobilia?.Invoke();
    private void Exit(object sender, EventArgs e)            => Application.Exit();
    #endregion
}