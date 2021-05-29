using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador=0, numero;

            Console.Write("Números pares entre 0 e: ");
            numero = int.Parse(Console.ReadLine());

            while (contador <= numero)
            {
                Console.Write($"{contador} ");
                contador= contador +2;
            }   
        }
    }
}
