using System.Collections.Generic;

namespace Avalonia.ListBoxAnimation.Samples.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            for (int i = 0; i < 5; i++)
            {
                Tabs.Add("Tab " + i);
            }
            
            for (int i = 0; i < 30; i++)
            {
                var item = new ListBoxItemViewModel() {Caption = "Item " + i};
                Items.Add(item);
                if (i.ToString().EndsWith("5"))
                {
                    item.Caption += " (Header)";
                    item.IsHeader = true;
                }
            }
        }

        public List<string> Tabs { get; } = new();
        public List<ListBoxItemViewModel> Items { get; } = new();
    }
}