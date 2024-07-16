using Avalonia.Controls;

namespace LatimerianCommanderBusinessLogic.Services.Abstract.Ui.MainMenu;

/// <summary>
/// Main menu builder
/// </summary>
public interface IMainMenuBuilder
{
    /// <summary>
    /// Build main menu
    /// </summary>
    Menu BuildMainMenu();
    
    #region File

    /// <summary>
    /// Get File -> Exit
    /// </summary>
    MenuItem GetFileExitMenuItem();

    #endregion
}