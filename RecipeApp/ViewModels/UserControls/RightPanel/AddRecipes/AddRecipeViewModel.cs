using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using DesktopApplications.UserControls;

namespace DesktopApplications.ViewModels;

public partial class AddRecipeViewModel : ViewModelBase
{
    
    [ObservableProperty] private bool _isVisible = true;
    [ObservableProperty] private string _headerText = "Import Recipe";
    [ObservableProperty] private string _optionTwoText = "Manually Add Recipe";
    [ObservableProperty] private string _uploadBtnTxt = "Upload Recipe Card Image";
    [ObservableProperty] private string _uploadLinkBoxTxt = "Paste Link to Recipe";
    [ObservableProperty] private string _uploadLinkBtn = "Upload from Link";
    [ObservableProperty] private string _tags = "Tags: ";
    [ObservableProperty] private string _currentStep = "";
    [ObservableProperty] private string _currentIngredient = "";
    [ObservableProperty] private string _stepWaterMark = "";
    [ObservableProperty] private string _addStepTxt = "Add Step";
    [ObservableProperty] private string _StepParam = "Step";
    [ObservableProperty] private string _IngredientParam = "Ingredient";
    
    
    
    [ObservableProperty] private RecipeParameterViewModel _name = new("Name");
    [ObservableProperty] private RecipeParameterViewModel _protein = new("Protein");
    [ObservableProperty] private RecipeParameterViewModel _Time = new("Time (min)");
    
    public ObservableCollection<StepsUC> Steps { get; } = new();
    public ObservableCollection<StepsUC> Ingredients { get; } = new();
    private int stepNumber = 0;
    private int ingredientNumber = 0;
    
    public void AddItem(string type)
    {
        switch (type)
        {
            case "Step":
                stepNumber++;
                AddToList( StepParam, Steps, CurrentStep, stepNumber);
                CurrentStep = "";
                break;
            case "Ingredient":
                ingredientNumber++;
                AddToList(IngredientParam, Ingredients, CurrentIngredient, ingredientNumber);
                CurrentIngredient = "";
                break;
        }
    }
    
    private void AddToList(string type, ObservableCollection<StepsUC> list, string text, int number)
    {
        list.Add(new StepsUC(type, text, number, this));
    }

    public void DeteleStep(string type, int number)
    {
        switch (type)
        {
            case "Step":
                RemoveFromList(Steps, number);
                break;
        }
    }
    
    
    private void RemoveFromList(ObservableCollection<StepsUC> list, int number)
    {
        list.RemoveAt(number);
    }
    
}