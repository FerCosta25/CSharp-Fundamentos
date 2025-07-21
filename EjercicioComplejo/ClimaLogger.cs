namespace DatosClimaticos
{
    public class ClimaLogger
    {
        public void GuardarClimasCalidos(string message)
        {
            File.AppendAllText("Climas_Calidos.txt", message + Environment.NewLine);
        }
    }
    public class ResetLogger
    {
        public void ResetLog(string message)
        {
            File.WriteAllText("Climas_Calidos.txt", message + Environment.NewLine);
        }
    }
}