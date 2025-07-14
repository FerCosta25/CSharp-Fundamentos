//Crea un programa en C# que:
//	1.	Pida al usuario cuántos estudiantes va a registrar.
//	2.	Cree una lista para guardar los nombres de los estudiantes.
//	3.	Use un ciclo for para pedir el nombre de cada estudiante y guardarlo en la lista.
//	4.	Después, usa un foreach para imprimir los nombres y pedir la nota de cada estudiante (entre 0 y 10).
//	5.	Si la nota es menor a 0 o mayor a 10, muestra un mensaje de error y vuelve a pedir la nota.
//	6.	Usa un contador para contar cuántos estudiantes aprobaron (nota ≥ 7) y cuántos reprobaron.
//	7.	Al final, muestra:
//	•	El número total de estudiantes
//	•	El número de aprobados y reprobados
//	8.	Si el número de aprobados es mayor que el de reprobados, muestra un mensaje motivador con switch:


// VARIABLES

int NumEstudiantes;
int aprobados = 0;
int reprobados = 0;
bool mayor;

// LISTAS

List<string> Estudiantes = new List<string>();

List<double> Notas = new List<double>();



// CICLOS

Console.WriteLine("Cuantos estudiantes estan en tu clase?");
NumEstudiantes = int.Parse(Console.ReadLine());

for (int _ = 1; _ <= NumEstudiantes; _++)
{
    Console.WriteLine("Ingresa el nombre del estudiante");
    Estudiantes.Add(Console.ReadLine());
}


foreach (string name in Estudiantes)
{
    Console.WriteLine($"¿Cuál fue la nota de {name}? (0-10)");

    string input = Console.ReadLine();
    double notaInput = double.Parse(input);

    while (notaInput < 0 || notaInput > 10)
    {
        Console.WriteLine("Nota inválida. Debe estar entre 0 y 10. Intenta de nuevo:");
        input = Console.ReadLine();
        notaInput = double.Parse(input);
    }

    Notas.Add(notaInput);
}

foreach (double nota in Notas)
{
    if (nota >= 7)
    {
        aprobados++;
    }
    else
    {
        reprobados++;
    }
}

// OUTPUT

bool EsMayor(int aprobados, int reprobados)
{
    return aprobados > reprobados;
}

Console.WriteLine($"El numero total de estudiantes fue: {NumEstudiantes}");
Console.WriteLine($"El numero total de aprobados fue de {aprobados}, mientras que el total de reprobados fue {reprobados}");

switch (EsMayor(aprobados, reprobados))
{
    case true:
        Console.WriteLine("Felicitaciones estudiantes!");
        break;
    case false:
        Console.WriteLine("Toca mejorar para la proxima.");
        break;
}

