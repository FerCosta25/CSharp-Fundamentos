
//Crea un programa en C# que haga lo siguiente:
//	1.	Define una interfaz llamada IReporter con un único método:
//void Report(string message);
//	2.	Crea dos clases que implementen la interfaz:
//	•	ConsoleReporter: escribe el mensaje en consola.
//	•	FileReporter: guarda el mensaje en un archivo llamado reporte.txt.
//	3.	En el Program.cs, el usuario debe:
//	•	Escribir un mensaje.
//	•	Elegir si quiere mostrarlo en consola o guardarlo en archivo (opción 1 o 2).
//	4.	Según la elección, se debe crear el objeto adecuado y llamar al método Report.

Console.WriteLine("Escribe un mensaje: ");
string message = Console.ReadLine();

int Opcion;

Console.WriteLine("¿Desea mostrarlo en la consola o guardarlo en un archivo? Responda con 1 o 2:");
Opcion = int.Parse(Console.ReadLine());

while (Opcion < 1 || Opcion > 2)
{
    Console.WriteLine("Opción inválida. Por favor seleccione 1 o 2:");
    Opcion = int.Parse(Console.ReadLine());
}

if (Opcion == 1)
{
    IReporter consoleReporter = new ConsoleReporter();
    consoleReporter.Report(message);
}
else
{
    IReporter fileReporter = new FileReporter();
    fileReporter.Report(message);
}



