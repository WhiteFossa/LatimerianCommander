using System.Reactive;
using ReactiveUI;

namespace LatimerianCommander.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    #region Commands
    
    public ReactiveCommand<Unit, Unit> CommandExit { get; }
    
    #endregion

    public MainWindowViewModel()
    {
        #region Commands binding

        CommandExit = ReactiveCommand.Create(OnExitCommand);

        #endregion
    }
    
    #region Commands handlers

    private void OnExitCommand()
    {
        Program.GetMainWindow().Close();
    }

    #endregion
}