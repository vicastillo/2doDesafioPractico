using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4AnalisisGuia6
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Identificador de múltiplos de 3 y de 5.";

        int mul3 = 0, mul5 = 0, suma;
         
        try
        {
        for (int i = 1; i <= 10; i++)
        {

        Console.WriteLine("Digite el número: ");
        int nu = int.Parse(Console.ReadLine());

        suma = nu;

        if (nu < 0)
        {
        Console.WriteLine("No se permiten números negativos. Por favor intente de nuevo.");
        }
        if (nu > 500)
        {
        Console.WriteLine("No se permiten números mayores a 500. Por favor intente de nuevo.");
        }

        if (nu % 3 == 0)
        {
        mul3 = mul3 + 1;
        }
        if (nu % 5 == 0)
        {
        mul5 = mul5 + 1;
        }
        }

        Console.WriteLine();
        Console.WriteLine("Cantidad de números múltiplos de 3: " + mul3);
        Console.WriteLine("Cantidad de números múltiplos de 5: " + mul5);
        }
        catch (Exception error)
        {
        Console.WriteLine("Error: " + error.Message);
        }

        Console.ReadKey();
        }
    }
}