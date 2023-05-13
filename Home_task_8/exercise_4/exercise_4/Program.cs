namespace exercise_4
{
    public class Program
    {
        public static void Main()
        {
            MessageSender messageSender = new EmailMessageSender();
            messageSender.MessageSended += (object sender, MessageSendedEventArgs args) =>
            {
                Console.WriteLine($"Sender: {sender} - ({args.Time}, {args.Message})");
            };

            messageSender.SendMessage("Hello world");
        }
    }
}