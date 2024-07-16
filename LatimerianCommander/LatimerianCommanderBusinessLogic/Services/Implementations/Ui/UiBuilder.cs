using Avalonia.Controls;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui;

namespace LatimerianCommanderBusinessLogic.Services.Implementations.Ui;

public class UiBuilder : IUiBuilder
{
    public void BuildUi(Window mainWindow)
    {
        var grid = new Grid();
        
        var button = new Button()
        {
            Content = "YIFF-YUFF"
        };
        
        grid.Children.Add(button);
        
        mainWindow.Content = grid;
    }
}