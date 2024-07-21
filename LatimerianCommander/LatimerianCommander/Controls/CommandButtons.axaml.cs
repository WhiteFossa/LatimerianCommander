using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace LatimerianCommander.Controls;

public partial class CommandButtons : UserControl
{
    public static readonly RoutedEvent<RoutedEventArgs> RenameEvent = RoutedEvent.Register<CommandButtons, RoutedEventArgs>(nameof(Rename), RoutingStrategies.Direct);
    public static readonly RoutedEvent<RoutedEventArgs> ViewEvent = RoutedEvent.Register<CommandButtons, RoutedEventArgs>(nameof(View), RoutingStrategies.Direct);
    public static readonly RoutedEvent<RoutedEventArgs> EditEvent = RoutedEvent.Register<CommandButtons, RoutedEventArgs>(nameof(Edit), RoutingStrategies.Direct);
    
    public CommandButtons()
    {
        InitializeComponent();
    }
    
    public event EventHandler<RoutedEventArgs> Rename
    {
        add => AddHandler(RenameEvent, value);
        remove => RemoveHandler(RenameEvent, value);
    }
    
    public event EventHandler<RoutedEventArgs> View
    {
        add => AddHandler(ViewEvent, value);
        remove => RemoveHandler(ViewEvent, value);
    }
    
    public event EventHandler<RoutedEventArgs> Edit
    {
        add => AddHandler(EditEvent, value);
        remove => RemoveHandler(EditEvent, value);
    }

    protected virtual void OnRename()
    {
        RaiseEvent(new RoutedEventArgs(RenameEvent));
    }
    
    protected virtual void OnView()
    {
        RaiseEvent(new RoutedEventArgs(ViewEvent));
    }
    
    protected virtual void OnEdit()
    {
        RaiseEvent(new RoutedEventArgs(EditEvent));
    }

    private void OnRenameButtonClick(object? sender, RoutedEventArgs e)
    {
        OnRename();
    }

    private void OnViewButtonClick(object? sender, RoutedEventArgs e)
    {
        OnView();
    }

    private void OnEditButtonClick(object? sender, RoutedEventArgs e)
    {
        OnEdit();
    }
}