string nombre1 = "Fernando";
string nombre2 = "Ignacio";


string[] nombres = new string[4];
nombres[0] = "Fernando";
nombres[1] = "Ignacio";
nombres[2] = "Brenda";
nombres[3] = "khai";

Console.WriteLine("Los nombres de mi arreglo son: ");
foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}


List<string> nombres2 = new List<string>();
nombres2.Add("Fernando");
nombres2.Add("Ignacio");
nombres2.Add("Brenda");
nombres2.Add("Khai");

Console.WriteLine("Los nombres de mi lista son: ");
foreach (string nombre in nombres2)
{
    Console.WriteLine(nombre);
}

