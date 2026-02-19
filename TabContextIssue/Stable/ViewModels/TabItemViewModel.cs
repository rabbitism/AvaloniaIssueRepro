namespace TabContextStable.ViewModels;

public partial class TabItemViewModel : ViewModelBase
{
    private string _header = string.Empty;
    private string _content = string.Empty;

    public string Header
    {
        get => _header;
        set => SetProperty(ref _header, value);
    }

    public string Content
    {
        get => _content;
        set => SetProperty(ref _content, value);
    }
}
