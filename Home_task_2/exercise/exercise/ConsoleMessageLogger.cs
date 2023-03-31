namespace exercise
{
    public class ConsoleMessageLogger : IMessageLogger
    {
        public void Log(string message)
        {
            string separator = new string('_', 10);
            Console.WriteLine($"{DateTime.Now}: {message}");
            Console.WriteLine(separator);
        }
    }
}