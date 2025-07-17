namespace Empresa
{
    public class Logger
    {
        public void Reporte(string Message)
        {
            File.WriteAllText("log.txt", Message);
        }
    }
}