namespace Operaciones
{
    public static class Calculadora
    {
        public static string Suma(int numero1, int numero2)
        {
            int Result = numero1 + numero2;
            return ResultadoOperaciones(Result);
        }

        public static string Resta(int numero1, int numero2)
        {
            int Result = numero1 - numero2;
            return ResultadoOperaciones(Result);
        }


        public static string Multiplicacion(int numero1, int numero2)
        {
            int Result = numero1 * numero2;
            return ResultadoOperaciones(Result);
        }


        public static string Division(int numero1, int numero2)
        {
            int Result = numero1 / numero2;
            return ResultadoOperaciones(Result);
        }

        private static string ResultadoOperaciones(int Result)
        {
            return $"El resultado de la operacion es: {Result}";
        }
    }
}
