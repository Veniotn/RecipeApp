using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class AddRecipeViewModel : ViewModelBase
{
    [ObservableProperty] private bool _isVisible = true;
    [ObservableProperty] private string _headerText = "Add New Recipe";
    [ObservableProperty] private string _uploadBtnTxt = "Upload Recipe Card Image";
    [ObservableProperty] private string _uploadLinkBoxTxt = "Paste Link to Recipe";
    [ObservableProperty] private string _uploadLinkBtn = "Upload from Link";
    [ObservableProperty] private string _tags = "Tags: ";
    
    
    [ObservableProperty] private RecipeParameterViewModel _name = new("Name");
    [ObservableProperty] private RecipeParameterViewModel _protein = new("Protein");
    [ObservableProperty] private RecipeParameterViewModel _Time = new("Time (min)");
    
}