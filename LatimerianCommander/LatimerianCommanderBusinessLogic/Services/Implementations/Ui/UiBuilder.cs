using Avalonia.Controls;
using LatimerianCommanderBusinessLogic.Controls.Abstract.Panels;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui.MainMenu;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui.MainToolbar;
using Microsoft.Extensions.DependencyInjection;
using Panel = LatimerianCommanderBusinessLogic.Controls.Implementations.Panels.Panel;

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

    #region Main toolbar

    /// <summary>
    /// Main toolbar builder
    /// </summary>
    private IMainToolbarBuilder _mainToolbarBuilder;

    /// <summary>
    /// Main toolbar
    /// </summary>
    private Grid _mainToolbar;

    #endregion
    
    #region Two panels

    /// <summary>
    /// Panels container
    /// </summary>
    private Grid _panelsContainer;

    /// <summary>
    /// Moveable panels separator
    /// </summary>
    private GridSplitter _panelsSeparator;
    
    /// <summary>
    /// Left panel
    /// </summary>
    private IPanel _leftPanel;

    /// <summary>
    /// Right panel
    /// </summary>
    private IPanel _rightPanel;
    
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
            new RowDefinition(1, GridUnitType.Auto),
            new RowDefinition(1, GridUnitType.Star)
        };
        
        mainWindow.Content = _mainGrid;

        #endregion
        
        #region Main menu

        _mainMenuBuilder = _di.GetService<IMainMenuBuilder>();
        
        _mainMenu = _mainMenuBuilder.BuildMainMenu();
        _mainMenu[Grid.ColumnProperty] = 0;
        _mainMenu[Grid.RowProperty] = 0;
        
        _mainGrid.Children.Add(_mainMenu);

        #endregion

        #region Main toolbar

        _mainToolbarBuilder = _di.GetService<IMainToolbarBuilder>();
        
        _mainToolbar = _mainToolbarBuilder.BuildMainToolbar();
        _mainToolbar[Grid.ColumnProperty] = 0;
        _mainToolbar[Grid.RowProperty] = 1;
        
        _mainGrid.Children.Add(_mainToolbar);

        #endregion
        
        #region Two panels

        _panelsContainer = new Grid()
        {
            [Grid.ColumnProperty] = 0,
            [Grid.RowProperty] = 2
        };

        _panelsContainer.ColumnDefinitions = new ColumnDefinitions()
        {
            new ColumnDefinition(1, GridUnitType.Star),
            new ColumnDefinition(5, GridUnitType.Pixel), // TODO: Detect me
            new ColumnDefinition(1, GridUnitType.Star)
        };

        _panelsContainer.RowDefinitions = new RowDefinitions()
        {
            new RowDefinition(1, GridUnitType.Star)
        };
        
        _mainGrid.Children.Add(_panelsContainer);

        #region Panels separator

        _panelsSeparator = new GridSplitter()
        {
            [Grid.ColumnProperty] = 1,
            [Grid.RowProperty] = 0
        };
        
        _panelsContainer.Children.Add(_panelsSeparator);

        #endregion

        #region Left panel

        _leftPanel = new Panel();
        
        ((Panel)_leftPanel)[Grid.ColumnProperty] = 0;
        ((Panel)_leftPanel)[Grid.RowProperty] = 0;
        
        _panelsContainer.Children.Add((Panel)_leftPanel);
        
        #endregion
        
        #region Right panel

        _rightPanel = new Panel();
        
        ((Panel)_rightPanel)[Grid.ColumnProperty] = 2;
        ((Panel)_rightPanel)[Grid.RowProperty] = 0;
        
        _panelsContainer.Children.Add((Panel)_rightPanel);
        
        #endregion

        #endregion
    }

}