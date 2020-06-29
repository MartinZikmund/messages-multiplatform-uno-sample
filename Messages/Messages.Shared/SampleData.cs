using Messages.Shared.ViewModels;
using System.Collections.ObjectModel;

namespace Messages.Shared
{
    public static class SampleData
    {
        public static ConversationViewModel[] CreateSampleConversations()
        {
            return new ConversationViewModel[]
            {
                new ConversationViewModel()
                {
                    Name = "Jerome Laban",
                    Messages = new ObservableCollection<MessageViewModel>()
                    {
                        MessageViewModel.CreateTo("the round pegs in the square holes"),
                        MessageViewModel.CreateFrom("the round pegs in the square holes"),
                    }
                }
            };
        }
    }
}
