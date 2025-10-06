using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class LeftPanelViewModel : ViewModelBase
{
    [ObservableProperty] private string _userName;


    public LeftPanelViewModel(string userName)
    {
        _userName = userName;
    }
}