using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class SuggestedRecipeViewModel : ViewModelBase
{
    [ObservableProperty] private bool _isVisible;
}