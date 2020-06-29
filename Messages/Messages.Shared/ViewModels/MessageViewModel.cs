namespace Messages.Shared.ViewModels
{
    public class MessageViewModel : BindableBase
    {
        public static MessageViewModel CreateFrom(string text)
        {
            return new MessageViewModel()
            {
                Text = text,
                IsFrom = true
            };
        }

        public static MessageViewModel CreateTo(string text)
        {
            return new MessageViewModel()
            {
                Text = text,
                IsFrom = false
            };
        }

        public string Text { get; set; }

        public bool IsFrom { get; set; }
    }
}
