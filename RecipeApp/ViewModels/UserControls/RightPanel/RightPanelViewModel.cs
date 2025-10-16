using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class RightPanelViewModel : ViewModelBase
{    
    [ObservableProperty] public SavedRecipesViewModel _SavedRecipesViewModel;
    [ObservableProperty] private SuggestedRecipeViewModel _suggestedRecipesViewModel;
    [ObservableProperty] private FriendsRecipesViewModel _friendsRecipesViewModel;
    [ObservableProperty] private GroceryListViewModel _groceryListViewModel;
    [ObservableProperty] private AddRecipeViewModel _addRecipeViewModel;
    public RightPanelViewModel( SavedRecipesViewModel savedRecipesViewModel,
        SuggestedRecipeViewModel suggestedRecipeViewModel, FriendsRecipesViewModel friendsRecipesViewModel,
        GroceryListViewModel groceryListViewModel, AddRecipeViewModel addRecipeViewModel)
    {
        _SavedRecipesViewModel = savedRecipesViewModel;
        _suggestedRecipesViewModel = suggestedRecipeViewModel;
        _friendsRecipesViewModel = friendsRecipesViewModel;
        _groceryListViewModel = groceryListViewModel;
        _addRecipeViewModel = addRecipeViewModel;
    }
    
    
    
    
}