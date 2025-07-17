using Empresa;

Console.WriteLine("Indique su nombre, edad y salario");
string Nombre = Console.ReadLine();
int Edad = int.Parse(Console.ReadLine());
double Salario = double.Parse(Console.ReadLine());

Empleado empleado = new Empleado();

empleado.Nombre = Nombre;
empleado.Edad = Edad;
empleado.Salario = Salario;

empleado.MostrarInformacion();

empleado.EsElegibleParaBono();

if (empleado.EsElegibleParaBono())
{
    Console.WriteLine($"El empleado {empleado.Nombre} es elegible para recibir bono");
    Logger logger = new Logger();
    logger.Reporte($"{Nombre} recibe bono");
}
else
{
    Console.WriteLine($"El empleado {empleado.Nombre} no es elegible para recibir bono");
}

