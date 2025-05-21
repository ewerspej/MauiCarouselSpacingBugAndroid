using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace CarouselSpacingBugAndroid;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<string> _items = [];

    public MainViewModel()
    {
        for (var i = 0; i < 20; i++)
        {
            Items.Add($"Item {i}");
        }
    }
}