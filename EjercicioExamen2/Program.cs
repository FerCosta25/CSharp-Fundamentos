using Instituto;

ResetLogger resetLog = new ResetLogger();
resetLog.ResetLog("Estos son los estudiantes becados:"+ Environment.NewLine);

List<Curso> ListaDeCursos = new List<Curso>();

Console.WriteLine("Cuantos cursos tiene el instituto?");
int NumCursos = int.Parse(Console.ReadLine());

for (int i = 0; i < NumCursos; i++)
{
    Curso crearCurso = new Curso();

    Console.WriteLine($"Cuantos estudiantes tiene su curso {i + 1} ");
    crearCurso.NumEstudiantes = int.Parse(Console.ReadLine());

    crearCurso.CrearEstudiantes();

    ListaDeCursos.Add(crearCurso);
}

Alumno alumno = new Alumno();
Curso curso = new Curso();
int a = 0;

foreach (Curso crearCurso in ListaDeCursos)
{
    Console.WriteLine("----------------------------------");
    Console.WriteLine($"Estudiantes del curso {a + 1}");
    Console.WriteLine("----------------------------------");
    foreach (Alumno nuevoAlumno in crearCurso.EstudiantesDelCurso)
    {
        nuevoAlumno.MostrarInformacion();
    }

    a++;
}

foreach (Curso crearCurso in ListaDeCursos)
{
    foreach (Alumno nuevoAlumno in crearCurso.EstudiantesDelCurso)
    {
        if (nuevoAlumno.EsElegibleParaBeca())
        {
            Logger registro = new Logger();

            registro.GuardarLog($"El estudiante {nuevoAlumno.Nombre} ha recibido una beca.");
        }
    }
}
