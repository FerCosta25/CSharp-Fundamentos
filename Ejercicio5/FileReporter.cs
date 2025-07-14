public class FileReporter : IReporter
{
    public void Report(string message)
    {
        File.WriteAllText("reporte.txt", message);
    }
}