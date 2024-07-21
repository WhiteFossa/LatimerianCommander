using System.Reactive;
using ReactiveUI;

namespace LatimerianCommander.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    #region Commands
    
    public ReactiveCommand<Unit, Unit> ExitCommand { get; }
    
    #endregion

    public MainWindowViewModel()
    {
        #region Commands binding

        ExitCommand = ReactiveCommand.Create(OnExitCommand);

        #endregion
    }
    
    #region Commands handlers

    private void OnExitCommand()
    {
        Program.GetMainWindow().Close();
    }
    
    #endregion
    
    #region Command buttons

    /// <summary>
    /// Called when Rename button is pressed
    /// </summary>
    public void OnRename()
    {
        int a = 10;
    }

    /// <summary>
    /// Called when View button is pressed
    /// </summary>
    public void OnView()
    {
        int a = 10;
    }
    
    /// <summary>
    /// Called when Edit button is pressed
    /// </summary>
    public void OnEdit()
    {
        int a = 10;
    }

    #endregion
}