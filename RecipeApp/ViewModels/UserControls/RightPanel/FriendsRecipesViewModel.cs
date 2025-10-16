using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class FriendsRecipesViewModel : ViewModelBase
{
    [ObservableProperty] private bool _isVisible;
}