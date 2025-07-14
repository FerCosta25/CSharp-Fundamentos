int Suma(int numero1, int numero2)
{
    Console.WriteLine($"La suma de {numero1} + {numero2} es igual a {numero1 + numero2}");
    int Result = numero1 + numero2;
    return Result;
}

int NumResult = Suma(5, 10);

Console.WriteLine($"El resultado de la suma es: {NumResult}");

