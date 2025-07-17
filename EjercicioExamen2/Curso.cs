namespace Instituto
{
    public class Curso
    {
        public List<Alumno> EstudiantesDelCurso = new List<Alumno>();

        public int NumEstudiantes { get; set; }

        public void CrearEstudiantes()
        {
            for (int i = 0; i < NumEstudiantes; i++)
            {
                Alumno nuevoAlumno = new Alumno();
                Console.WriteLine($"Ingrese el nombre del estudiante #{i + 1}");
                nuevoAlumno.Nombre = Console.ReadLine();

                Console.WriteLine("Edad:");
                nuevoAlumno.Edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Promedio:");
                nuevoAlumno.NotaPromedio = double.Parse(Console.ReadLine());

                EstudiantesDelCurso.Add(nuevoAlumno);
            }
        }
    }
}