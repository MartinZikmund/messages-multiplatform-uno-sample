using Messages.Shared;
using Messages.Shared.ViewModels;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace Messages
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public ObservableCollection<ConversationViewModel> Conversations { get; } = 
            new ObservableCollection<ConversationViewModel>(SampleData.CreateSampleConversations());
    }
}
