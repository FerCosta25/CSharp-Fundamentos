using DatosClimaticos;

ResetLogger limpiarLog = new ResetLogger();
limpiarLog.ResetLog("Estas son las ciudades que se consideran calidas:");

Console.WriteLine("Cuantas ciudades desae registrar?");
int NumCiudades = int.Parse(Console.ReadLine());

List<Ciudad> listaCiudades = new List<Ciudad>();

for (int i = 0; i < NumCiudades; i++)
{
    Ciudad crearCiudad = new Ciudad();

    Console.WriteLine($"Cual es el nombre de la ciudad #{i + 1}");
    crearCiudad.Nombre = Console.ReadLine();

    Console.WriteLine($"En que pais se encuentra {crearCiudad.Nombre}");
    crearCiudad.Pais = Console.ReadLine();

    crearCiudad.AgregarTemperatura();

    if (crearCiudad.EsClimaCalido())
    {
        ClimaLogger registrarClimaCalido = new ClimaLogger();
        registrarClimaCalido.GuardarClimasCalidos($"{crearCiudad.Nombre} tiene un clima calido");
    }

    listaCiudades.Add(crearCiudad);
}

Console.WriteLine("\nResumen de ciudades registradas:");
foreach (Ciudad ciudad in listaCiudades)
{
    ciudad.MostrarInformacion();
}