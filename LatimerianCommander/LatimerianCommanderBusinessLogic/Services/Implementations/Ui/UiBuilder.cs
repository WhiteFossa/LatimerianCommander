using Avalonia.Controls;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui.MainMenu;
using Microsoft.Extensions.DependencyInjection;

namespace LatimerianCommanderBusinessLogic.Services.Implementations.Ui;

public class UiBuilder : IUiBuilder
{
    private ServiceProvider _di;
    
    /// <summary>
    /// Main window main grid
    /// </summary>
    private Grid _mainGrid;

    #region Main menu

    /// <summary>
    /// Main menu builder
    /// </summary>
    private IMainMenuBuilder _mainMenuBuilder;
    
    /// <summary>
    /// Main menu
    /// </summary>
    private Menu _mainMenu;
    
    #endregion
    
    public void BuildUi(Window mainWindow, ServiceProvider di)
    {
        _di = di;
        
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
        
        #region Main menu

        _mainMenuBuilder = _di.GetService<IMainMenuBuilder>();
        _mainMenu = _mainMenuBuilder.BuildMainMenu();
        _mainGrid.Children.Add(_mainMenu);

        #endregion

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

}