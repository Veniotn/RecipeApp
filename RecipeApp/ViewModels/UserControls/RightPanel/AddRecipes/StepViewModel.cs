using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.ViewModels;

public partial class StepViewModel : ViewModelBase
{
    
    [ObservableProperty] private string _stepNumber;
    [ObservableProperty] private string _stepText = "";
    [ObservableProperty] private string _deleteText = "X";
    [ObservableProperty] private Image _deleteIcon;


    public StepViewModel(string stepText, int stepNumber)
    {
        _stepText = stepText;
        _stepNumber = stepNumber + ". ";
    }
    
    public void DeleteStep()
    {
        
    }
}