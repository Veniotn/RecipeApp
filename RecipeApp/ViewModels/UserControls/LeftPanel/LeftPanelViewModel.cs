using System;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class LeftPanelViewModel : ViewModelBase
{
    [ObservableProperty] public SavedRecipesViewModel _SavedRecipesViewModel;
    [ObservableProperty] private SuggestedRecipeViewModel _suggestedRecipeViewModel;
    [ObservableProperty] private FriendsRecipesViewModel _friendsRecipesViewModel;
    [ObservableProperty] private GroceryListViewModel _groceryListViewModel;
    [ObservableProperty] private AddRecipeViewModel _addRecipeViewModel;
    
    [ObservableProperty] private string _userName;
    [ObservableProperty] private string _savedRecipeBtnTxt     = "Saved Recipes";
    [ObservableProperty] private string _suggestedRecipeBtnTxt = "Suggested Recipes";
    [ObservableProperty] private string _friendsRecipeBtnTxt   = "Friends Recipes";
    [ObservableProperty] private string _groceryListBtnTxt     = "Grocery List";
    [ObservableProperty] private string _addRecipeBtnTxt       = "Add Recipe";


    public LeftPanelViewModel( SavedRecipesViewModel savedRecipesViewModel,
        SuggestedRecipeViewModel suggestedRecipeViewModel, FriendsRecipesViewModel friendsRecipesViewModel,
        GroceryListViewModel groceryListViewModel, AddRecipeViewModel addRecipeViewModel, string userName)
    {
        _SavedRecipesViewModel = savedRecipesViewModel;
        _suggestedRecipeViewModel = suggestedRecipeViewModel;
        _friendsRecipesViewModel = friendsRecipesViewModel;
        _groceryListViewModel = groceryListViewModel;
        _addRecipeViewModel = addRecipeViewModel;
        _userName = userName;
    }


    public void ActionBtnClick(object sender)
    {
        if (sender is Button btn)
        {
            SavedRecipesViewModel.IsVisible = false;
            SuggestedRecipeViewModel.IsVisible = false;
            FriendsRecipesViewModel.IsVisible = false;
            GroceryListViewModel.IsVisible = false;
            AddRecipeViewModel.IsVisible = false;
            
            switch (btn.Name)
            {
                case "SavedRecipesBtn":
                    SavedRecipesViewModel.IsVisible = true;
                    break;
                case "SuggestedRecipesBtn":
                    SuggestedRecipeViewModel.IsVisible = true;
                    break;
                case "FriendsRecipesBtn":
                    FriendsRecipesViewModel.IsVisible = true;
                    break;
                case "GroceryListBtn":
                    GroceryListViewModel.IsVisible = true;
                    break;
                case "AddRecipeBtn":
                    AddRecipeViewModel.IsVisible = true;
                    break;
            }
        }
    }
    
}