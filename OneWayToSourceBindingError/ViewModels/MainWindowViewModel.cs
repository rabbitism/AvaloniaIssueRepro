namespace OneWayToSourceBindingError.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private decimal _decimalValue;

    public decimal DecimalValue
    {
        get => _decimalValue;
        set => SetProperty(ref _decimalValue, value);
    }
}