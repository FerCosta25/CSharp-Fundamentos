using Operations;

public class CalculatorServices : ICalculatorServices
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        Console.WriteLine("En una implementacion de metodo de resta diferente");
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        int result = a * b;
        return result;
    }

    public double Divide(int a, int b)
    {
        return a / b;
    }
}