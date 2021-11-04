using System;

namespace numeros1al100
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <101 ; i++)
            {
                 if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Mareigua");
                }
                else if (i%3==0)
                {
                    Console.WriteLine("mare");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("igua");
                }
                else
                {
                    Console.WriteLine(i);
                }
                


                                }
         
        }
    }
}
