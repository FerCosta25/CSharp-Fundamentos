public class ConsoleReporter : IReporter
{
    public void Report(string message)
    {
        Console.WriteLine(message);
    }
}
