namespace exercise
{
    public interface IMessageLogger
    {
        public void Log(string message, string? mark = null);
    }
}