using System.Collections.ObjectModel;

namespace TabContextStable.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<TabItemViewModel> Tabs { get; }

    public MainWindowViewModel()
    {
        Tabs = new ObservableCollection<TabItemViewModel>
        {
            new TabItemViewModel { Header = "Tab 1", Content = "Content from Tab 1" },
            new TabItemViewModel { Header = "Tab 2", Content = "Content from Tab 2" },
            new TabItemViewModel { Header = "Tab 3", Content = "Content from Tab 3" }
        };
    }
}
