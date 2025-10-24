using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DesktopApplications.ViewModels.UserControls.RightPanel;

public partial class StepsUC : UserControl
{
    public StepsUC()
    {
        InitializeComponent();
    }

    public StepsUC(string currentStep, int stepNumber)
    {
        DataContext = new StepViewModel(currentStep, stepNumber);
        InitializeComponent();
    }
}