using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages.Shared.ViewModels
{
    public class ConversationViewModel : BindableBase 
    {
        public string Name { get; set; }

        public string LastMessage => Messages.LastOrDefault()?.Text ?? "Hello, world";

        public ObservableCollection<MessageViewModel> Messages { get; set; }
    }
}
