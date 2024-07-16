using Avalonia;
using Avalonia.ReactiveUI;
using System;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui.MainMenu;
using LatimerianCommanderBusinessLogic.Services.Implementations.Ui;
using LatimerianCommanderBusinessLogic.Services.Implementations.Ui.MainMenu;
using Microsoft.Extensions.DependencyInjection;

namespace LatimerianCommander;

sealed class Program
{
    /// <summary>
    /// Dependency injection service provider
    /// </summary>
    public static ServiceProvider Di { get; private set; }
    
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        #region DI setup
        
        Di = ConfigureServices()
            .BuildServiceProvider();
        
        #endregion
        
        BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace()
            .UseReactiveUI();
    
    /// <summary>
    /// DI setup
    /// </summary>
    public static IServiceCollection ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();
        
        services.AddSingleton<IUiBuilder, UiBuilder>();
        services.AddSingleton<IMainMenuBuilder, MainMenuBuilder>();
        
        return services;
    }
    
    /// <summary>
    /// Get app main window
    /// </summary>
    public static Window GetMainWindow()
    {
        if (Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopLifetime)
        {
            return desktopLifetime.MainWindow;
        }

        return null;
    }
}