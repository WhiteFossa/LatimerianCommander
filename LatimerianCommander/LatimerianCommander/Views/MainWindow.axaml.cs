using System;
using System.Reactive;
using Avalonia.Controls;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui.MainMenu;
using Microsoft.Extensions.DependencyInjection;
using ReactiveUI;

namespace LatimerianCommander.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        Opened += OnWindowOpened;
    }
    
    /// <summary>
    /// Called when window opened
    /// </summary>
    private void OnWindowOpened(object sender, EventArgs e)
    {
        Program.Di.GetService<IUiBuilder>().BuildUi(Program.GetMainWindow(), Program.Di);
        
        #region Main menu commands

        var mainMenuBuilder = Program.Di.GetService<IMainMenuBuilder>();

        mainMenuBuilder.GetFileExitMenuItem().Command = ReactiveCommand.Create(OnFileExitCommand);

        #endregion
    }

    /// <summary>
    /// Called on File -> Exit
    /// </summary>
    private void OnFileExitCommand()
    {
        Program.GetMainWindow().Close();
    }
}