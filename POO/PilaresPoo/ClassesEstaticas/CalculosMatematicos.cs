namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
       public static double PI = 3.14159265358979;

       public static float x;
       public static float y;

       public static void Somar()
        {
            Console.WriteLine();
            Console.WriteLine($"Soma de {x} + {y} é: {x + y}");
        }
       public static void Menos()
        {
            Console.WriteLine();
            Console.WriteLine($"A subtração de {x} - {y} é: {x - y}");
        }

        public static void Dividir()
        {
            Console.WriteLine();

            if(y == 0)
            {
                Console.WriteLine("Divisão inválida");
            }

            Console.WriteLine($"A divição de {x} / {y} é: {x / y}");
        }

        public static void Multiplicar()
        {
            Console.WriteLine();
            Console.WriteLine($"A Multiplicação de {x} X {y} é: {x * y}");
        }

        public static void MaiorouMenor()
        {
            Console.WriteLine($"O número maior é {Math.Max(x, y)}");
            Console.WriteLine($"O número menor é {Math.Min(x, y)}");
        }

    }
}