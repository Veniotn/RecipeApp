using System;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class LeftPanelViewModel : ViewModelBase
{
    [ObservableProperty] public SavedRecipesViewModel _SavedRecipesViewModel;
    private SuggestedRecipeViewModel _suggestedRecipeViewModel;
    private FriendsRecipesViewModel _friendsRecipesViewModel;
    private GroceryListViewModel _groceryListViewModel;
    private AddRecipeViewModel _addRecipeViewModel;
    
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
            Console.WriteLine(btn.Name);
            
            
            switch (btn.Name)
            {
                case "SaveRecipesBtn":
                    break;
                case "SuggestedRecipesBtn":
                    break;
                case "FriendsRecipesBtn":
                    break;
                case "GroceryListBtn":
                    break;
                case "AddRecipeBtn":
                    break;
                    
            }
        }
    }
}