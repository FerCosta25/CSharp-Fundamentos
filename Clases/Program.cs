using Operaciones;

Operaciones.Calculadora calculadora = new Operaciones.Calculadora();

Console.WriteLine("Dime 2 numeros");

int num1;
int num2;

num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());

string ResultSuma = calculadora.Suma(num1, num2);
Console.WriteLine($"{ResultSuma}");


string ResultResta = calculadora.Resta(num1, num2);
Console.WriteLine($"La resta de {num1} y {num2} es {ResultResta}");


string ResultMultiplicacion = calculadora.Multiplicacion(num1, num2);
Console.WriteLine($"La multiplicacion de {num1} y {num2} es {ResultMultiplicacion}");


string ResultDivision = calculadora.Division(num1, num2);
Console.WriteLine($"La division de {num1} y {num2} es {ResultDivision}");
