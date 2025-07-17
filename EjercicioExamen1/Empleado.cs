namespace Empresa
{
    public class Empleado : IEmpleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre del empleado: {Nombre}, de edad: {Edad}, con un salario de: ${Salario}");
        }

        public bool EsElegibleParaBono()
        {
            if (Salario < 1000 && Edad > 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
