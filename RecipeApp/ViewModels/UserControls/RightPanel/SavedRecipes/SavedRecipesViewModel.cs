using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class SavedRecipesViewModel : ViewModelBase
{

    public ObservableCollection<RecipeViewModel> Recipes { get; } = new();

    [ObservableProperty] private RecipeViewModel vm = new RecipeViewModel("Quick Irish Stew", "10/10", "90min");

    public SavedRecipesViewModel()
    {
        Recipes.Add(new RecipeViewModel("Quick Irish Stew", "10/10", "90min"));
    }
    
    
}