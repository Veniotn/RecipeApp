using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DesktopApplications.ViewModels;

namespace DesktopApplications.UserControls;

public partial class StepsUC : UserControl
{
    public StepsUC()
    {
        InitializeComponent();
    }

    public StepsUC(string type, string currentStep, int stepNumber, AddRecipeViewModel addRecipeViewModel)
    {
        DataContext = new StepViewModel(type, currentStep, stepNumber, addRecipeViewModel);
        InitializeComponent();
    }
}