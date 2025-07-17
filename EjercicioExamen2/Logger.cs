namespace Instituto
{
    public class Logger
    {
        public void GuardarLog(string message)
        {
            File.AppendAllText("log.txt", message + Environment.NewLine);
        }
    }

    public class ResetLogger
    {
        public void ResetLog(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}