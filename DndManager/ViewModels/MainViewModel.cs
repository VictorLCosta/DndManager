using CommunityToolkit.Mvvm.ComponentModel;

namespace DndManager.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public string greeting = "Welcome to avalonia";

}
