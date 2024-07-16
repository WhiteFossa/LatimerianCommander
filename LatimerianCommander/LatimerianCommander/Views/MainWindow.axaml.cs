using System;
using Avalonia.Controls;
using LatimerianCommanderBusinessLogic.Services.Abstract.Ui;
using Microsoft.Extensions.DependencyInjection;

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
        Program.Di.GetService<IUiBuilder>().BuildUi(Program.GetMainWindow());
    }
}