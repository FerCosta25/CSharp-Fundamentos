int edad = 18;

Console.WriteLine("Introduce tu edad: ");
edad = Convert.ToInt32(Console.ReadLine());


if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");
    Console.WriteLine("Puedes conducir");
}
else
    Console.WriteLine("Eres menos de edad");
