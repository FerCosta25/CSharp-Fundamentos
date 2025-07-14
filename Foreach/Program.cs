Console.WriteLine("Indique su nombre: ");
string nombre = Console.ReadLine();

foreach (char letra in nombre)
{
    Console.Write(letra);
}

int contador = 10;

foreach (int i in Enumerable.Range(1, contador))
{
    Console.WriteLine($"Contador: {contador}");
    contador--;
}

