using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using DesktopApplications.Models.UserControls;

namespace DesktopApplications.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";

    [ObservableProperty] private TopBarViewModel _topBarViewModel = new("Test");
    [ObservableProperty] private LeftPanelViewModel _leftPanelViewModel = new ("Nick Veniot");


}