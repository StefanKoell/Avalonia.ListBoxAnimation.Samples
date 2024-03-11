using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.ListBoxAnimation.Samples.ViewModels;

namespace Avalonia.ListBoxAnimation.Samples
{
    public class ViewLocator : IDataTemplate
    {
        public Control Build(object data)
        {
            var name = data.GetType().FullName!.Replace("ViewModel", "View");
            var type = Type.GetType(name);

            if (data is ListBoxItemViewModel vm)
            {
                return new TextBlock() {Text = vm.Caption};
            }

            if (type != null)
            {
                return (Control) Activator.CreateInstance(type)!;
            }
            else
            {
                return new TextBlock {Text = "Not Found: " + name};
            }
        }

        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}