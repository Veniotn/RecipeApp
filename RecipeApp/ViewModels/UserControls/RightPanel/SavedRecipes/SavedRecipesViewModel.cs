using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class SavedRecipesViewModel : ViewModelBase
{

    [ObservableProperty] private ObservableCollection<RecipeViewModel> _recipes= new();
    [ObservableProperty] private ObservableCollection<RecipeViewModel> _filteredRecipes = new();
    [ObservableProperty] public bool _isVisible ;


    public SavedRecipesViewModel()
    {
        Recipes.Add(new RecipeViewModel("Spaghetti Bolognese", "9", "60"));
    }



}