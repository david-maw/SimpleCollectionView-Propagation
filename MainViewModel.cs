
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SimpleCollectionView;
public partial class MainViewModel : ObservableObject
{
    public void ShowCommandInfo(string t, object? commandParam = null)
    {
        string CommandType = t, CommandParameter = "";
        if (commandParam is null)
            CommandParameter = "";
        else if (commandParam is string s)
            CommandParameter = s;
        else
            CommandParameter = "'" + (commandParam.ToString() ?? "") + "'";
        CommandLog += t + (string.IsNullOrWhiteSpace(CommandParameter) ? "" : ", " + CommandParameter) + "\n";
    }

    [RelayCommand]
    private void ClearLog() => CommandLog = "Log Cleared" + "\n";

    [RelayCommand]
    private void ShowTap(object commandParam) => ShowCommandInfo("Tap Command", commandParam);

    [ObservableProperty]
    private string? commandLog;
}
