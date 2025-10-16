using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class GroceryListViewModel : ViewModelBase
{
    [ObservableProperty] private bool _isVisible;
}