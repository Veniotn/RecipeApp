using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApplications.Models.UserControls;

public class MenuItem
{
    private string headerText;


    public MenuItem(string headerText)
    {
        this.headerText = headerText;
    }
}