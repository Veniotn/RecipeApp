using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class RecipeParameterViewModel : ViewModelBase
{
    [ObservableProperty] private string _parameterName;
    [ObservableProperty] private string _parameterInput;

    public RecipeParameterViewModel(string name)
    {
        _parameterName = name;
    }
}