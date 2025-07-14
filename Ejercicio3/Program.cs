//Crea un programa en C# que:
//	1.	Pida al usuario:
//	•	Su nombre y apellido
//	•	Su edad
//	•	Su nota promedio (decimal)
//	•	Si está registrado (true/false)
//	2.	Si no está registrado, muestra el mensaje:
//Debes registrarte primero para continuar.
//y termina el programa.
//
//	3.	Si sí está registrado:
//	•	Muestra un saludo con su nombre completo y edad.
//	•	Si su edad es mayor o igual a 18, dile que puede ingresar al sistema.
//	•	Si es menor de edad, dile que no tiene acceso.
//	4.	Luego, usa un ciclo for para imprimir la nota promedio 5 veces como repaso.
//	5.	Finalmente, usa un while que reste 1 a la edad del usuario hasta que llegue a 0, y muestre cada número en pantalla.


// variables

string nombre = "";
int edad;
double nota;
bool registro;
int contador = 5;

// preguntas

Console.WriteLine("Indique su nombre: ");
 nombre = Console.ReadLine();

Console.WriteLine("Indique su edad: ");
edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Indique su nota promedio: ");
nota = double.Parse(Console.ReadLine());

Console.WriteLine("Esta registrado? Responda con true/false");
registro = bool.Parse(Console.ReadLine());

// acciones

if (registro == false)
{
    Console.WriteLine("Debes registrarte primero para continuar.");
}
else
{
    Console.WriteLine($"Hola {nombre}, de edad: {edad} años.");

    if (edad >= 18)
    {
        Console.WriteLine("Tiene permitido el ingreso al sistema.");
    }
    else
    {
        Console.WriteLine("No tiene acceso al sistema.");
    }

    for ( int i = 1; i <= contador; i++)
    {
        Console.WriteLine($"Su nota es: {nota}");
    }

    while (edad > 0)
    {
        Console.WriteLine(edad);
        edad--;
    }   
}