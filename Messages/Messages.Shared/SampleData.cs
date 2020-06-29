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
                    Name = "Jérôme Laban",
                    Messages = new ObservableCollection<MessageViewModel>()
                    {
                        MessageViewModel.CreateTo("Here's to the crazy ones"),
                        MessageViewModel.CreateFrom("the misfits, the rebels, the troublemakers"),
                        MessageViewModel.CreateTo("the round pegs in the square holes..."),
                        MessageViewModel.CreateFrom("the ones who see things differently – they're not fond of rules..."),
                        MessageViewModel.CreateTo("You can quote them, disagree with them, glorify or vilify them"),
                        MessageViewModel.CreateFrom("but the only thing you can't do is ignore them because they change things..."),
                        MessageViewModel.CreateTo("they push the human race forward"),
                        MessageViewModel.CreateFrom("and while some may see them as the crazy ones"),
                        MessageViewModel.CreateTo("we see genius"),
                        MessageViewModel.CreateFrom("because the people who are crazy enough to think that they can change the world"),
                        MessageViewModel.CreateTo("are the ones who do."),
                    }
                },
                new ConversationViewModel()
                {
                    Name = "Francois Tanguay",
                    Messages = new ObservableCollection<MessageViewModel>()
                    {
                        MessageViewModel.CreateTo("Here's to the crazy ones"),
                        MessageViewModel.CreateFrom("the misfits, the rebels, the troublemakers"),
                        MessageViewModel.CreateTo("the round pegs in the square holes..."),
                        MessageViewModel.CreateFrom("the ones who see things differently – they're not fond of rules..."),
                        MessageViewModel.CreateTo("You can quote them, disagree with them, glorify or vilify them"),
                        MessageViewModel.CreateFrom("but the only thing you can't do is ignore them because they change things..."),
                        MessageViewModel.CreateTo("they push the human race forward"),
                        MessageViewModel.CreateFrom("and while some may see them as the crazy ones"),
                        MessageViewModel.CreateTo("we see genius"),
                        MessageViewModel.CreateFrom("because the people who are crazy enough to think that they can change the world"),
                        MessageViewModel.CreateTo("are the ones who do."),
                    }
                },
                new ConversationViewModel()
                {
                    Name = "David John Oliver",
                    Messages = new ObservableCollection<MessageViewModel>()
                    {
                        MessageViewModel.CreateTo("Here's to the crazy ones"),
                        MessageViewModel.CreateFrom("the misfits, the rebels, the troublemakers"),
                        MessageViewModel.CreateTo("the round pegs in the square holes..."),
                        MessageViewModel.CreateFrom("the ones who see things differently – they're not fond of rules..."),
                        MessageViewModel.CreateTo("You can quote them, disagree with them, glorify or vilify them"),
                        MessageViewModel.CreateFrom("but the only thing you can't do is ignore them because they change things..."),
                        MessageViewModel.CreateTo("they push the human race forward"),
                        MessageViewModel.CreateFrom("and while some may see them as the crazy ones"),
                        MessageViewModel.CreateTo("we see genius"),
                        MessageViewModel.CreateFrom("because the people who are crazy enough to think that they can change the world"),
                        MessageViewModel.CreateTo("are the ones who do."),
                    }
                },
                new ConversationViewModel()
                {
                    Name = "Carl de Billy",
                    Messages = new ObservableCollection<MessageViewModel>()
                    {
                        MessageViewModel.CreateTo("Here's to the crazy ones"),
                        MessageViewModel.CreateFrom("the misfits, the rebels, the troublemakers"),
                        MessageViewModel.CreateTo("the round pegs in the square holes..."),
                        MessageViewModel.CreateFrom("the ones who see things differently – they're not fond of rules..."),
                        MessageViewModel.CreateTo("You can quote them, disagree with them, glorify or vilify them"),
                        MessageViewModel.CreateFrom("but the only thing you can't do is ignore them because they change things..."),
                        MessageViewModel.CreateTo("they push the human race forward"),
                        MessageViewModel.CreateFrom("and while some may see them as the crazy ones"),
                        MessageViewModel.CreateTo("we see genius"),
                        MessageViewModel.CreateFrom("because the people who are crazy enough to think that they can change the world"),
                        MessageViewModel.CreateTo("are the ones who do."),
                    }
                },
                new ConversationViewModel()
                {
                    Name = "David R.",
                    Messages = new ObservableCollection<MessageViewModel>()
                    {
                        MessageViewModel.CreateTo("Here's to the crazy ones"),
                        MessageViewModel.CreateFrom("the misfits, the rebels, the troublemakers"),
                        MessageViewModel.CreateTo("the round pegs in the square holes..."),
                        MessageViewModel.CreateFrom("the ones who see things differently – they're not fond of rules..."),
                        MessageViewModel.CreateTo("You can quote them, disagree with them, glorify or vilify them"),
                        MessageViewModel.CreateFrom("but the only thing you can't do is ignore them because they change things..."),
                        MessageViewModel.CreateTo("they push the human race forward"),
                        MessageViewModel.CreateFrom("and while some may see them as the crazy ones"),
                        MessageViewModel.CreateTo("we see genius"),
                        MessageViewModel.CreateFrom("because the people who are crazy enough to think that they can change the world"),
                        MessageViewModel.CreateTo("are the ones who do."),
                    }
                },
                new ConversationViewModel()
                {
                    Name = "Mathieu Fillion",
                    Messages = new ObservableCollection<MessageViewModel>()
                    {
                        MessageViewModel.CreateTo("Here's to the crazy ones"),
                        MessageViewModel.CreateFrom("the misfits, the rebels, the troublemakers"),
                        MessageViewModel.CreateTo("the round pegs in the square holes..."),
                        MessageViewModel.CreateFrom("the ones who see things differently – they're not fond of rules..."),
                        MessageViewModel.CreateTo("You can quote them, disagree with them, glorify or vilify them"),
                        MessageViewModel.CreateFrom("but the only thing you can't do is ignore them because they change things..."),
                        MessageViewModel.CreateTo("they push the human race forward"),
                        MessageViewModel.CreateFrom("and while some may see them as the crazy ones"),
                        MessageViewModel.CreateTo("we see genius"),
                        MessageViewModel.CreateFrom("because the people who are crazy enough to think that they can change the world"),
                        MessageViewModel.CreateTo("are the ones who do."),
                    }
                }
            };
        }
    }
}
