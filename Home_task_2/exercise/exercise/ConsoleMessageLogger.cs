namespace exercise
{
    public class ConsoleMessageLogger : IMessageLogger
    {
        public void Log(string message, string? mark)
        {
            Console.WriteLine($"{mark}---{DateTime.Now}: {message}");
            Console.WriteLine();
        }
    }
}