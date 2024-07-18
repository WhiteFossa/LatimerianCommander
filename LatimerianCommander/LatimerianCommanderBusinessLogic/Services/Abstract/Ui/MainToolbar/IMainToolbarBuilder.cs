using Avalonia.Controls;
using LatimerianCommanderBusinessLogic.Services.Enums.Ui;

namespace LatimerianCommanderBusinessLogic.Services.Abstract.Ui.MainToolbar;

/// <summary>
/// Builder for main toolbar
/// </summary>
public interface IMainToolbarBuilder
{
    /// <summary>
    /// Build main toolbar
    /// </summary>
    Grid BuildMainToolbar();
    
    /// <summary>
    /// Get main toolbar buttons
    /// </summary>
    Button GetButton(MainToolbarButtons button);
}