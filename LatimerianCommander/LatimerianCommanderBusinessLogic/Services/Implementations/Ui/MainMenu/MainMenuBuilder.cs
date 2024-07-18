using Avalonia.Controls;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui.MainMenu;
using LatimerianCommanderBusinessLogic.Services.Enums.Ui;

namespace LatimerianCommanderBusinessLogic.Services.Implementations.Ui.MainMenu;

public class MainMenuBuilder : IMainMenuBuilder
{
    /// <summary>
    /// Menu items are stored here
    /// </summary>
    private readonly Dictionary<MainMenuItems, MenuItem> _mainMenuItems = new Dictionary<MainMenuItems, MenuItem>();
    
    public Menu BuildMainMenu()
    {
        var menu = new Menu()
        {
            [Grid.ColumnProperty] = 0,
            [Grid.RowProperty] = 0
        };

        #region Main menu -> File

        _mainMenuItems.Add
        (
            MainMenuItems.File,
            new MenuItem()
            {
                Header = "File"
            }
        );
        
        menu.Items.Add(GetMainMenuItem(MainMenuItems.File));

        GetMainMenuItem(MainMenuItems.File).Items.Add(new Separator());

        #region Main menu -> File -> Exit

        _mainMenuItems.Add(MainMenuItems.FileExit, new MenuItem()
        {
            Header = "Exit"
        });
        
        GetMainMenuItem(MainMenuItems.File).Items.Add(GetMainMenuItem(MainMenuItems.FileExit));

        #endregion
        
        
        #endregion

        #region Settings

        _mainMenuItems.Add(MainMenuItems.Settings, new MenuItem()
        {
            Header = "Settings"
        });
        
        menu.Items.Add(GetMainMenuItem(MainMenuItems.Settings));

        GetMainMenuItem(MainMenuItems.Settings).Items.Add(new Separator());

        _mainMenuItems.Add(MainMenuItems.SettingsPreferences, new MenuItem()
        {
            Header = "Preferences"
        });

        GetMainMenuItem(MainMenuItems.Settings).Items.Add(GetMainMenuItem(MainMenuItems.SettingsPreferences));

        #endregion

        return menu;
    }

    public MenuItem GetMainMenuItem(MainMenuItems item)
    {
        return _mainMenuItems[item];
    }
}