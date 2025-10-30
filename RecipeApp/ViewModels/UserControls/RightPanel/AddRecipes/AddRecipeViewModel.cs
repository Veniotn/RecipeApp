using System;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using DesktopApplications.Models;
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
    [ObservableProperty] private string _linkTxt = "";
    [ObservableProperty] private string _overviewHeaderTxt = "Recipe Info";
    [ObservableProperty] private string _currentStep = "";
    [ObservableProperty] private string _currentIngredient = "";
    [ObservableProperty] private string _currentTag = "";
    [ObservableProperty] private string _stepWaterMark = "";
    [ObservableProperty] private string _addStepTxt = "Add Step";
    [ObservableProperty] private string _addTagTxt = "Add Step";
    [ObservableProperty] private string _stepParam = "Steps";
    [ObservableProperty] private string _ingredientParam = "Ingredients";
    [ObservableProperty] private string _tagParam = "Tags";
    
    
    
    [ObservableProperty] private RecipeParameterViewModel _name = new("Name");
    [ObservableProperty] private RecipeParameterViewModel _protein = new("Protein");
    [ObservableProperty] private RecipeParameterViewModel _Time = new("Time (min)");
    
    public ObservableCollection<RecipeItemUC> Steps { get; } = new();
    public ObservableCollection<RecipeItemUC> Ingredients { get; } = new();
    public ObservableCollection<RecipeItemUC> Tags { get; } = new();
    private int stepNumber = 0;
    private int ingredientNumber = 0;
    
    
    private RecipeParser parser = new RecipeParser();
    
    public void AddItem(string type)
    {
        switch (type)
        {
            case "Steps":
                AddToList( StepParam, Steps, CurrentStep);
                CurrentStep = String.Empty;
                break;
            case "Ingredients":
                AddToList(IngredientParam, Ingredients, CurrentIngredient);
                CurrentIngredient = String.Empty;
                break;
            case "Tags":
                AddToList(TagParam, Tags, CurrentTag);
                CurrentTag = String.Empty;
                break;
        }
    }
    
    private void AddToList(string type, ObservableCollection<RecipeItemUC> list, string text)
    {
        list.Add(new RecipeItemUC(type, text, list.Count+1, this));
    }

    public void DeleteStep(string type, int number)
    {
        switch (type)
        {
            case "Steps":
                RemoveFromList(Steps, number);
                break;
            case "Ingredients":
                RemoveFromListNoNumber(Ingredients, number);
                break;
            case "Tags":
                RemoveFromListNoNumber(Tags, number);
                break;
        }
    }
    
    
    private void RemoveFromList(ObservableCollection<RecipeItemUC> list, int number)
    {
        list.RemoveAt(number-1);

        for (int i = 0; i < list.Count; i++)
        {
            list[i].vm.StepNumber = i+1;
            list[i].vm.StepNumberText = i+1 + ". ";
        }
            
    }

    private void RemoveFromListNoNumber(ObservableCollection<RecipeItemUC> list, int number)
    {
        list.RemoveAt(number-1);

        for (int i = 0; i < list.Count; i++)
        {
            list[i].vm.StepNumber = i+1;
        }
    }


    public async void ParseRecipe(string origin)
    {
        switch (origin)
        {
            case "Link":
                await parser.ParseFromLink(LinkTxt);
                LinkTxt = String.Empty;
                break;
        }
    }
    
}