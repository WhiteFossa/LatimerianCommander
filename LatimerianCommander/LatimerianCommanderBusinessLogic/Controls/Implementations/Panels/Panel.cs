using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using LatimerianCommanderBusinessLogic.Controls.Abstract.Panels;

namespace LatimerianCommanderBusinessLogic.Controls.Implementations.Panels;

public class Panel : Grid, IPanel
{
    private Rectangle _placeholder;

    public Panel()
    {
        ColumnDefinitions = new ColumnDefinitions()
        {
            new ColumnDefinition(1, GridUnitType.Star)
        };

        RowDefinitions = new RowDefinitions()
        {
            new RowDefinition(1, GridUnitType.Star)
        };
        
        _placeholder = new Rectangle()
        {
            Fill = new SolidColorBrush(new Color((byte)new Random().Next(255), (byte)new Random().Next(255),(byte)new Random().Next(255),(byte)new Random().Next(255)))
        };
        
        this.Children.Add(_placeholder);
    }
}