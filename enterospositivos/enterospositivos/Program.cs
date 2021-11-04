using System;

namespace enterospositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 908,1, 2, 3, 5, 54, 87, 65, 234, 6, 7, 8, 34, 52, 67,1000 };
            int mayor=numbers[0];
            foreach (var numero in numbers)
            {
                if (numero>mayor)
                {
                    mayor = numero;
                }

            }

            Console.WriteLine(mayor);
        }
    }
}
