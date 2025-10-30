using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DesktopApplications.ViewModels;

namespace DesktopApplications.UserControls;

public partial class RecipeItemUC : UserControl
{
    public RecipeItemViewModel vm;
    public RecipeItemUC()
    {
        InitializeComponent();
    }

    public RecipeItemUC(string type, string currentStep, int stepNumber, AddRecipeViewModel addRecipeViewModel)
    {
        
        vm = new RecipeItemViewModel(type, currentStep, stepNumber, addRecipeViewModel);
        DataContext = vm;
        InitializeComponent();
    }
}