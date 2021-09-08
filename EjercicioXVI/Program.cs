using System;

namespace EjercicioXVI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isString;

            do
            {
                Console.WriteLine("Ingrese un número entero: ");
                string p = Console.ReadLine();

                isString = Int32.TryParse(p, out int q);

                if (isString == false)
                {
                    Console.WriteLine("No ingresó un valor válido");
                }
                else
                {
                    Console.WriteLine($"Ingresó el valor: {q}");
                }
            } while (isString == false);
           

            Console.ReadKey();
            Console.Clear();
        }
    }
}
