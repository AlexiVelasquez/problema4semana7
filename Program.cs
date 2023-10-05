using System;

namespace problema4semana7  
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingresa un número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break; 
                }

                for (int i = 0; i < numero; i++)
                {
                    for (int j = 0; j < numero; j++)
                    {
                        
                        Console.Write("**");

                    }
                    Console.WriteLine(); 
                    
                }
            }   Console.ReadKey();  
        }
    }
}

