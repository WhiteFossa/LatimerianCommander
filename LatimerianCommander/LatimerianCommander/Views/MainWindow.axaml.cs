using Avalonia.Controls;
using Avalonia.Interactivity;
using LatimerianCommander.ViewModels;

namespace LatimerianCommander.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnRename(object? sender, RoutedEventArgs e)
    {
        ((MainWindowViewModel)DataContext).OnRename();
    }

    private void OnView(object? sender, RoutedEventArgs e)
    {
        ((MainWindowViewModel)DataContext).OnView();
    }

    private void OnEdit(object? sender, RoutedEventArgs e)
    {
        ((MainWindowViewModel)DataContext).OnEdit();
    }
}