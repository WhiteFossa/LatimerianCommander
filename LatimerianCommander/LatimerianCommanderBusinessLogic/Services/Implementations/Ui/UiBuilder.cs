using Avalonia.Controls;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui;
using ReactiveUI;

namespace LatimerianCommanderBusinessLogic.Services.Implementations.Ui;

public class UiBuilder : IUiBuilder
{
    /// <summary>
    /// Main window main grid
    /// </summary>
    private Grid _mainGrid;

    #region Main menu
    
    /// <summary>
    /// Main menu
    /// </summary>
    private Menu _mainMenu;

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
    
    #endregion
    
    public void BuildUi(Window mainWindow)
    {
        #region Main grid setup

        _mainGrid = new Grid();
        
        _mainGrid.ColumnDefinitions = new ColumnDefinitions()
        {
            new ColumnDefinition(1, GridUnitType.Star)
        };

        _mainGrid.RowDefinitions = new RowDefinitions()
        {
            new RowDefinition(1, GridUnitType.Auto),
            new RowDefinition(1, GridUnitType.Star)
        };
        
        mainWindow.Content = _mainGrid;

        #endregion
        
        BuildMainMenu(_mainGrid);
        
        /*var button1 = new Button()
        {
            Content = "YIFF",
            [Grid.ColumnProperty] = 0,
            [Grid.RowProperty] = 0
        };

        var button2 = new Button()
        {
            Content = "YUFF",
            [Grid.ColumnProperty] = 0,
            [Grid.RowProperty] = 1
        };

        _mainGrid.Children.Add(button1);
        _mainGrid.Children.Add(button2);*/

    }

    private void BuildMainMenu(Grid mainGrid)
    {
        _mainMenu = new Menu()
        {
            [Grid.ColumnProperty] = 0,
            [Grid.RowProperty] = 0
        };

        #region Main menu -> File

        _mainMenuFile = new MenuItem()
        {
            Header = "File"
        };
        
        _mainMenu.Items.Add(_mainMenuFile);

        _mainMenuFile.Items.Add(new Separator());

        #region Main menu -> File -> Exit

        _mainMenuFileExit = new MenuItem()
        {
            Header = "Exit",
            Command = ReactiveCommand.Create(OnExitCommand)
        };
        
        _mainMenuFile.Items.Add(_mainMenuFileExit);

        #endregion
        
        
        #endregion

        #region Settings

        _mainMenuSettings = new MenuItem()
        {
            Header = "Settings"
        };
        
        _mainMenu.Items.Add(_mainMenuSettings);

        _mainMenuSettings.Items.Add(new Separator());

        _mainMenuSettingsPreferences = new MenuItem()
        {
            Header = "Preferences"
        };

        _mainMenuSettings.Items.Add(_mainMenuSettingsPreferences);

        #endregion

        mainGrid.Children.Add(_mainMenu);
    }

    private void OnExitCommand()
    {
        int a = 10;
    }
}