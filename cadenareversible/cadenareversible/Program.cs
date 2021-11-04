using System;

namespace cadenareversible
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "hello world Mareigua";
            cadena.ToCharArray();
            int maximo = cadena.Length;
            for (int i = (maximo-1); i >=0; i--)
            {
                Console.WriteLine(cadena[i]);
            }

            
        }
    }
}
