namespace exercise_4
{
    //Дані події
    public class MessageSendedEventArgs : EventArgs
    {
        public MessageSendedEventArgs(string message) 
        {
            Message = message;
        }

        public DateTime Time { get; } = DateTime.Now;

        public string Message { get; }
    }
}