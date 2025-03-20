using FactoryMethod.Entities;

namespace FactoryMethod.MVP.View.Main
{
    public interface IMainView
    {
        /// <summary>
        /// List of mobilia in string format
        /// </summary>
        List<string> FurnitureListInString { get; }

        /// <summary>
        /// Event to send the mobilia list
        /// </summary>
        event Action? SendFurniture;

        /// <summary>
        /// Show a message box
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"></param>
        /// <param name="icon"></param>
        /// <param name="buttons"></param>
        void ShowMessageBox(string message, string caption, MessageBoxIcon icon, MessageBoxButtons buttons);
    }
}