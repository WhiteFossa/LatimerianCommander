using Avalonia.Controls;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui.MainMenu;

namespace LatimerianCommanderBusinessLogic.Services.Implementations.Ui.MainMenu;

public class MainMenuBuilder : IMainMenuBuilder
{
    #region File submenu
    
    /// <summary>
    /// File submenu
    /// </summary>
    private MenuItem _mainMenuFile;

    /// <summary>
    /// Exit
    /// </summary>
    private MenuItem _mainMenuFileExit;
    
    #endregion

    #region Settings submenu
    
    /// <summary>
    /// Settings submenu
    /// </summary>
    private MenuItem _mainMenuSettings;

    /// <summary>
    /// Preferences
    /// </summary>
    private MenuItem _mainMenuSettingsPreferences;
    
    #endregion
    
    public Menu BuildMainMenu()
    {
        var menu = new Menu()
        {
            [Grid.ColumnProperty] = 0,
            [Grid.RowProperty] = 0
        };

        #region Main menu -> File

        _mainMenuFile = new MenuItem()
        {
            Header = "File"
        };
        
        menu.Items.Add(_mainMenuFile);

        _mainMenuFile.Items.Add(new Separator());

        #region Main menu -> File -> Exit

        _mainMenuFileExit = new MenuItem()
        {
            Header = "Exit"
        };
        
        _mainMenuFile.Items.Add(_mainMenuFileExit);

        #endregion
        
        
        #endregion

        #region Settings

        _mainMenuSettings = new MenuItem()
        {
            Header = "Settings"
        };
        
        menu.Items.Add(_mainMenuSettings);

        _mainMenuSettings.Items.Add(new Separator());

        _mainMenuSettingsPreferences = new MenuItem()
        {
            Header = "Preferences"
        };

        _mainMenuSettings.Items.Add(_mainMenuSettingsPreferences);

        #endregion

        return menu;
    }

    public MenuItem GetFileExitMenuItem()
    {
        return _mainMenuFileExit;
    }
}