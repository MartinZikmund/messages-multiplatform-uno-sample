using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages.Shared.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public ObservableCollection<ConversationViewModel> Conversations { get; } =
            new ObservableCollection<ConversationViewModel>(SampleData.CreateSampleConversations());

        public ConversationViewModel SelectedConversation { get; set; }
    }
}
