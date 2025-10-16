using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using DesktopApplications.Models.UserControls;

namespace DesktopApplications.ViewModels;

public partial class TopBarViewModel : ViewModelBase
{
    [ObservableProperty] private string _header;
    [ObservableProperty] private string _searchBarWatermark = "Search Recipes";
    [ObservableProperty] private string _searchText = "";
    
    private SavedRecipesViewModel _savedRecipesViewModel;
    
    // public string SearchText
    // {
    //     get => _searchText;
    //     set
    //     {
    //         FilterRecipes();
    //     }
    // }
    // private List<MenuItem> _menuItems;
    


    public TopBarViewModel(string header, SavedRecipesViewModel savedRecipesViewModel)
    {
        _header = header;
        _savedRecipesViewModel = savedRecipesViewModel;
        
    }
    
    
    // private void FilterRecipes()
    // {
    //     
    // }
    
    
    
}