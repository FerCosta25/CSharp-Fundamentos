namespace Instituto
{
    public class Alumno : IAlumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Curso { get; set; }
        public double NotaPromedio { get; set; }

        public bool EsElegibleParaBeca()
        {
            if (NotaPromedio >= 9 && Edad < 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"----------------------------------------------------------");
            Console.WriteLine($"Datos del Estudiante: ");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Promedio: {NotaPromedio}");
            if (EsElegibleParaBeca())
            {
                Console.WriteLine($"El estudiante {Nombre} recibe beca");
            }
            else
            {
                Console.WriteLine($"El estudiante {Nombre} no recibe beca");
            }
        }

    }
}