using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using DesktopApplications.Models.UserControls;

namespace DesktopApplications.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private string _currentUserName = "Anonymous";
    
    [ObservableProperty] private LeftPanelViewModel _leftPanelViewModel;
    [ObservableProperty] private TopBarViewModel _topBarViewModel;
    [ObservableProperty] private RightPanelViewModel _rightPanelViewModel;
    
    [ObservableProperty] private SavedRecipesViewModel _savedRecipesViewModel;
    [ObservableProperty] private SuggestedRecipeViewModel _suggestedRecipeViewModel;
    [ObservableProperty] private FriendsRecipesViewModel _friendsRecipesViewModel;
    [ObservableProperty] private GroceryListViewModel _groceryListViewModel;
    [ObservableProperty] private AddRecipeViewModel _addRecipeViewModel;
    
   
   


    public MainWindowViewModel()
    {
        _savedRecipesViewModel = new SavedRecipesViewModel();
        _suggestedRecipeViewModel = new SuggestedRecipeViewModel();
        _friendsRecipesViewModel = new FriendsRecipesViewModel();
        _groceryListViewModel = new GroceryListViewModel();
        _addRecipeViewModel = new AddRecipeViewModel();
        
        _topBarViewModel = new TopBarViewModel("My Recipes", _savedRecipesViewModel);
        _leftPanelViewModel = new LeftPanelViewModel(_savedRecipesViewModel, _suggestedRecipeViewModel,
        _friendsRecipesViewModel, _groceryListViewModel, _addRecipeViewModel, _currentUserName);
        
        _rightPanelViewModel = new RightPanelViewModel(_savedRecipesViewModel, _suggestedRecipeViewModel,
            _friendsRecipesViewModel, _groceryListViewModel, _addRecipeViewModel);
        
    }
    


}