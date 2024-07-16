using Avalonia.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace LatimerianCommanderBusinessLogic.Services.Abstract.Ui;

/// <summary>
/// Main UI builder
/// </summary>
public interface IUiBuilder
{
    /// <summary>
    /// UI generation entry point
    /// </summary>
    void BuildUi(Window mainWindow, ServiceProvider di);
}