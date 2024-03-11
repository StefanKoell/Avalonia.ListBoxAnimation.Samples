using ReactiveUI;

namespace Avalonia.ListBoxAnimation.Samples.ViewModels;

public class ListBoxItemViewModel : ViewModelBase
{
    private string _caption = string.Empty;
    public string Caption
    {
        get => _caption;
        set => this.RaiseAndSetIfChanged(ref _caption, value);
    }
    
    private bool _selected;
    public bool Selected
    {
        get => _selected;
        set => this.RaiseAndSetIfChanged(ref _selected, value);
    }
    
    private bool _isHeader;
    public bool IsHeader
    {
        get => _isHeader;
        set => this.RaiseAndSetIfChanged(ref _isHeader, value);
    }
    
}