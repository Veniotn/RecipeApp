using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using DesktopApplications.Models.UserControls;

namespace DesktopApplications.ViewModels;

public partial class TopBarViewModel : ViewModelBase
{
    [ObservableProperty] private string _header;
    [ObservableProperty] private string _searchBarWatermark = "Search Recipes";
    private List<MenuItem> _menuItems;
    


    public TopBarViewModel(string header)
    {
        _header = header;
        
    }
    
    
    
}