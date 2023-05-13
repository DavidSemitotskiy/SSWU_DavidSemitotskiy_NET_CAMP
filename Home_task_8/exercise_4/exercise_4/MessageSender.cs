namespace exercise_4
{
    public abstract class MessageSender
    {
        //Краще не оголошувати віртуальні події у базовому класі та не перевизначати їх у похідному класі
        //Компілятор С# не обробляє їх коректно
        public event EventHandler<MessageSendedEventArgs> MessageSended;

        public abstract void SendMessage(string message);

        //Викликаючи або перевизначаючи цей метод, похідні класи зможуть генерувати подію базового класу
        protected virtual void OnMessageSended(MessageSendedEventArgs args)
        {
            MessageSended?.Invoke(this, args);
        }
    }
}