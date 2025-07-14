//Crea un programa en C# que:
//	1.	Tenga un namespace llamado Institucion.
//	2.	Dentro de ese namespace, crea una clase Estudiante con las siguientes características:
//	•	Propiedades:
//	•	Nombre (string)
//	•	Edad (int)
//	•	Métodos:
//	•	MostrarInformacion() → imprime el nombre y la edad del estudiante.
//	•	EsMayorDeEdad() → retorna true si la edad es mayor o igual a 18, y false si no.
//	3.	En tu Program.cs:
//	•	Pide al usuario nombre y edad.
//	•	Crea un objeto Estudiante con esos datos.
//	•	Llama a MostrarInformacion().
//	•	Usa el método EsMayorDeEdad() y muestra un mensaje:
//	•	“Es mayor de edad” o
//	•	“Es menor de edad”.

using Institucion;

Institucion.Estudiantes estudiantes = new Institucion.Estudiantes();

Console.WriteLine("Indique el nombre del estudiante");
string nombre = Console.ReadLine();

Console.WriteLine("Indique su edad");
int edad = int.Parse(Console.ReadLine());

estudiantes.MostrarInformacion(nombre, edad);

bool CompararEdad = estudiantes.EsMayorDeEdad(edad);
if (CompararEdad == true)
{
    Console.WriteLine($"{nombre} es mayor de edad");
}
else
{
    Console.WriteLine($"{nombre} es menor de edad");
}
