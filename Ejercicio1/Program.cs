// 	1.	Pida al usuario su nombre, apellido y edad.
//	2.	Pida su nota final (con decimales).
//	3.	Pregunte si es estudiante de Platzi (respuesta esperada: true o false).
//	4.	Defina una constante con el nombre del curso (por ejemplo, "Fundamentos de C#").
//	5.	Al final, imprima un mensaje con toda esta información formateada.

// Variables

string nombre = "";
string apellido = "";
int edad;
double NotaFinal;
bool EstudiantePlatzi;
string NombreCurso = "";

// Preguntas

Console.WriteLine("Cual es tu nombre?");
nombre = Console.ReadLine();

Console.WriteLine("Cual es tu apellido?");
apellido = Console.ReadLine();

Console.WriteLine("Que edad tienes?");
edad = int.Parse(Console.ReadLine());

Console.WriteLine("Cual fue tu nota final?");
NotaFinal = double.Parse(Console.ReadLine());

Console.WriteLine("Eres estudiante de Platzi? (contesta con: true/false)");
EstudiantePlatzi = bool.Parse(Console.ReadLine());

Console.WriteLine("Cual es el nombre del curso que estas haciendo?");
NombreCurso = Console.ReadLine();

// Despliegue de texto 

Console.WriteLine("Hola " + nombre + " " + apellido + ", tienes " + edad + " años");

Console.WriteLine("Tu nota final fue de " + NotaFinal + ". Felicidades!");

Console.WriteLine("Eres estudiante de Platzi! " + EstudiantePlatzi);

Console.WriteLine("El nombre del curso que estas haciendo actualmente es: " + NombreCurso);