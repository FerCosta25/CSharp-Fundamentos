namespace DatosClimaticos
{
    public class Ciudad
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }

        public List<double> TemperaturasMensuales = new List<double>();

        private readonly string[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        public void AgregarTemperatura()
        {
            foreach (string mes in Meses)
            {
                Console.WriteLine($"Indique la temperatura promedio en el mes de {mes}");
                double temperatura = double.Parse(Console.ReadLine());
                TemperaturasMensuales.Add(temperatura);
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Estos son los datos meteorologicos de temperatura de {Nombre}");
            Console.WriteLine($"Ciudad: {Nombre}");
            Console.WriteLine($"Pais: {Pais}");

            for (int i = 0; i < Meses.Length; i++)
            {
                Console.WriteLine($"La temperatura promedio durante el mes de {Meses[i]} fue de {TemperaturasMensuales[i]} grados");
            }

            Console.WriteLine($"{Nombre} tuvo una temperatura promedio de {CalcularPromedio()} durante el año");
            Console.WriteLine("-------------------------------------");
        }

        private double CalcularPromedio()
        {
            double Total = 0;
            foreach (double temperatura in TemperaturasMensuales)
            {
                Total += temperatura;
            }
            return Total / 12;
        }

        public bool EsClimaCalido()
        {

            double Promedio = CalcularPromedio();

            if (Promedio > 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}