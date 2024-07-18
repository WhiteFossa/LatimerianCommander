using Avalonia.Controls;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui.MainToolbar;
using LatimerianCommanderBusinessLogic.Services.Enums.Ui;

namespace LatimerianCommanderBusinessLogic.Services.Implementations.Ui.MainToolbar;

public class MainToolbarBuilder : IMainToolbarBuilder
{
    private Grid _mainToolbar;

    private readonly Dictionary<MainToolbarButtons, Button> _buttons = new Dictionary<MainToolbarButtons, Button>();
    
    public Grid BuildMainToolbar()
    {
        _mainToolbar = new Grid()
        {
            [Grid.ColumnProperty] = 0,
            [Grid.RowProperty] = 1
        };

        _mainToolbar.ColumnDefinitions = new ColumnDefinitions()
        {
            // 3 buttons for example
            new ColumnDefinition(1, GridUnitType.Auto),
            new ColumnDefinition(1, GridUnitType.Auto),
            new ColumnDefinition(1, GridUnitType.Auto),
        };

        _mainToolbar.RowDefinitions = new RowDefinitions()
        {
            new RowDefinition(1, GridUnitType.Auto)
        };
        
        // Button 1
        _buttons.Add
        (
            MainToolbarButtons.Button1, new Button()
            {
                Content = "Btn1",
                [Grid.RowProperty] = 0,
                [Grid.ColumnProperty] = 0
            }
        );
        _mainToolbar.Children.Add(GetButton(MainToolbarButtons.Button1));
        
        // Button 2
        _buttons.Add
        (
            MainToolbarButtons.Button2, new Button()
            {
                Content = "Btn2",
                [Grid.RowProperty] = 0,
                [Grid.ColumnProperty] = 1
            }
        );
        _mainToolbar.Children.Add(GetButton(MainToolbarButtons.Button2));
        
        // Button 3
        _buttons.Add
        (
            MainToolbarButtons.Button3, new Button()
            {
                Content = "Btn3",
                [Grid.RowProperty] = 0,
                [Grid.ColumnProperty] = 2
            }
        );
        _mainToolbar.Children.Add(GetButton(MainToolbarButtons.Button3));
        
        return _mainToolbar;
    }

    public Button GetButton(MainToolbarButtons button)
    {
        return _buttons[button];
    }
}