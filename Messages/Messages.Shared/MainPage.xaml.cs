using Messages.Shared;
using Messages.Shared.ViewModels;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Messages
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public MainViewModel ViewModel { get; } = new MainViewModel();

        private void PaneToggle(object sender, PointerRoutedEventArgs e) => Split.IsPaneOpen = !Split.IsPaneOpen;
    }
}
