namespace Operaciones
{
    public class Calculadora
    {
        public string Suma(int numero1, int numero2)
        {
            int Result = numero1 + numero2;
            return ResultadoOperaciones(Result);
        }

        public string Resta(int numero1, int numero2)
        {
            int Result = numero1 - numero2;
            return ResultadoOperaciones(Result);
        }


        public string Multiplicacion(int numero1, int numero2)
        {
            int Result = numero1 * numero2;
            return ResultadoOperaciones(Result);
        }


        public string Division(int numero1, int numero2)
        {
            int Result = numero1 / numero2;
            return ResultadoOperaciones(Result);
        }

        private string ResultadoOperaciones(int Result)
        {
            return $"El resultado de la operacion es: {Result}";
        }
    }
}
