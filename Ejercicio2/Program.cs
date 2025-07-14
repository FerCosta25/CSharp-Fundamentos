// Crea un programa en C# que le pida al usuario los siguientes datos:
//	1.	Nombre completo (nombre y apellido).
//	2.	Edad (entero).
//	3.	Nota del examen de ingreso (decimal).
//	4.	¿Tiene beca? (true o false).
//	5.	Nombre de la carrera a la que desea ingresar.
//	6.	Define una constante con el nombre de la universidad (por ejemplo, "Universidad Central de Programación").
//
// Después, muestra este mensaje personalizado:

// Hola [nombre completo], tu edad es [edad] años y postulaste a la carrera de [carrera].
// Tu nota de ingreso fue [nota]. ¿Tienes beca?: [valor].
// Te damos la bienvenida a la [nombre universidad] 🎓



// variables

string NombreCompleto = "";
int edad;
double nota;
bool beca;
string carrera = "";
const string universidad = "UEES";

// preguntas

Console.WriteLine("Indique su nombre completo: ");
NombreCompleto = Console.ReadLine();

Console.WriteLine("Indique su edad: ");
edad = int.Parse(Console.ReadLine());

Console.WriteLine("Indique la nota de su examen de admision: ");
nota = double.Parse(Console.ReadLine());

Console.WriteLine("Tiene beca? (Conteste con true/false) ");
beca = bool.Parse(Console.ReadLine());

Console.WriteLine("Indique la carrera a la que postulo: ");
carrera = Console.ReadLine();

// mensaje

Console.WriteLine("Hola " + NombreCompleto + ", tu edad es de " + edad + " años y postulaste a la carrera de " + carrera);
Console.WriteLine("La nota de tu examen de admision fue: " + nota + " y has sido aceptado. Tienes beca? " + beca);
Console.WriteLine("Felicitaciones! Te damos la bienvenida a la " + universidad + "! Muchos exitos.");