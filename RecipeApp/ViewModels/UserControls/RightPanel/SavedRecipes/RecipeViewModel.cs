using System;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class RecipeViewModel : ViewModelBase
{
    [ObservableProperty] private string _recipeName = "Name";
    [ObservableProperty] private string _ratingHeaderTxt = "Rating";
    [ObservableProperty] private string _ratingTxt = "10/10";
    [ObservableProperty] private string _timeHeaderTxt = "Estimated time:";
    [ObservableProperty] private string _timeTxt = "90min";
    [ObservableProperty] private string _recipeImage = "../../../Assets/avalonia-logo.ico";


    public RecipeViewModel(string name, string rating, string time)
    {
        _recipeName = name;
        _ratingTxt = rating;
        _timeTxt = time;
    }

    public RecipeViewModel(){}

    public void ViewRecipe()
    {
        Console.WriteLine("View Recipe");
    }
}