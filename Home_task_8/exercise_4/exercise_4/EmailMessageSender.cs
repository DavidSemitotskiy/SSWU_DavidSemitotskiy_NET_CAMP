namespace exercise_4
{
    public class EmailMessageSender : MessageSender
    {
        public override void SendMessage(string message)
        {
            //логіка відправлення повідомлення поштою
            //генерація події батьківського класу
            OnMessageSended(new MessageSendedEventArgs(message));
        }

        protected override void OnMessageSended(MessageSendedEventArgs args)
        {
            //Якась додактова логіка
            base.OnMessageSended(args);
        }
    }
}