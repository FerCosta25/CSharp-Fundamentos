namespace Institucion
{
    public class Estudiantes
    {
        string nombre;
        int edad;

        public void MostrarInformacion(string nombre, int edad)
        {
            Console.WriteLine($"Su nombre es {nombre} y tiene {edad} años.");
        }

        public bool EsMayorDeEdad(int edad)
        {
            if (edad >= 18)
                return true;
            else
                return false;
        }
    }
}