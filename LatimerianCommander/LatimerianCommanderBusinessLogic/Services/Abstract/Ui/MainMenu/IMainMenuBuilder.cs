using Avalonia.Controls;
using LatimerianCommanderBusinessLogic.Services.Enums.Ui;

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
    
    /// <summary>
    /// Get main menu item
    /// </summary>
    MenuItem GetMainMenuItem(MainMenuItems item);
}