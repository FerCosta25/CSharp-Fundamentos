List<string> ListaNombres = new List<string>();
List<string> ListaApellidos = new List<string>();

ListaNombres.Add("Juan");
ListaNombres.Add("Pedro");
ListaNombres.Add("Maria");
ListaNombres.Add("Ana");
ListaNombres.Add("Luis");

ListaApellidos.Add("Gomez");
ListaApellidos.Add("Lopez");
ListaApellidos.Add("Martinez");
ListaApellidos.Add("Hernandez");
ListaApellidos.Add("Garcia");

foreach (string nombre in ListaNombres)
{
    foreach (string apellido in ListaApellidos)
    {
        Console.WriteLine($"{nombre} {apellido}");
    }
}

