using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace Avalonia.ListBoxAnimation.Samples.Views;

public class EnhancedListBox : ListBox
{
    protected override Type StyleKeyOverride => typeof(ListBox);

    public EnhancedListBox()
    {
    }
}