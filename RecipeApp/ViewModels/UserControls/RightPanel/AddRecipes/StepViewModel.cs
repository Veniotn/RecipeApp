using System;
using System.Windows.Input;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class StepViewModel : ViewModelBase
{
    
    private string type;
    [ObservableProperty] private int _stepNumber;
    [ObservableProperty] private string _stepNumberText;
    [ObservableProperty] private string _text = "";
    [ObservableProperty] private string _deleteText = "X";
    [ObservableProperty] private Image _deleteIcon;
    [ObservableProperty] private AddRecipeViewModel _addRecipeViewModel;
    


    public StepViewModel(string type, string stepText, int stepNumber, AddRecipeViewModel addRecipeViewModel)
    {
        this.type = type;
        _text = stepText;
        _stepNumber = stepNumber;
        _stepNumberText = stepNumber + ". ";
        _addRecipeViewModel = addRecipeViewModel;
        
    }
    
    
    public void DeleteStep()
    {
        AddRecipeViewModel.DeteleStep(type, StepNumber);
    }
    
}