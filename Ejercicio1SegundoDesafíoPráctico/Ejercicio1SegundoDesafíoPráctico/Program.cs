using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1SegundoDesafíoPráctico
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Promedios de alumnos.";

        String nombrealumno1, nombrealumno2, nombrealumno3, nombrealumno4, nombrealumno5;
        Double nota1alumno1, nota2alumno1, nota3alumno1, nota4alumno1, nota5alumno1, nota1alumno2, nota2alumno2, nota3alumno2, nota4alumno2, nota5alumno2, nota1alumno3, nota2alumno3, nota3alumno3, nota4alumno3, nota5alumno3, nota1alumno4, nota2alumno4, nota3alumno4, nota4alumno4, nota5alumno4, nota1alumno5, nota2alumno5, nota3alumno5, nota4alumno5, nota5alumno5, promedioalumno1, promedioalumno2, promedioalumno3, promedioalumno4, promedioalumno5;

        try
        {
        Console.WriteLine("Ingrese el nombre del primer estudiante:");
        nombrealumno1 = (Console.ReadLine());

        Console.WriteLine("Ingrese las notas de " + nombrealumno1 + ":" );
        nota1alumno1 = Double.Parse(Console.ReadLine());
        nota2alumno1 = Double.Parse(Console.ReadLine());
        nota3alumno1 = Double.Parse(Console.ReadLine());
        nota4alumno1 = Double.Parse(Console.ReadLine());
        nota5alumno1 = Double.Parse(Console.ReadLine());

        promedioalumno1 = (nota1alumno1 + nota2alumno1 + nota3alumno1 + nota4alumno1 + nota5alumno1) / 5;

        Console.WriteLine();
        Console.WriteLine("Ingrese el nombre del segundo estudiante:");
        nombrealumno2 = (Console.ReadLine());

        Console.WriteLine("Ingrese las notas de " + nombrealumno2 + ":" );
        nota1alumno2 = Double.Parse(Console.ReadLine());
        nota2alumno2 = Double.Parse(Console.ReadLine());
        nota3alumno2 = Double.Parse(Console.ReadLine());
        nota4alumno2 = Double.Parse(Console.ReadLine());
        nota5alumno2 = Double.Parse(Console.ReadLine());

        promedioalumno2 = (nota1alumno2 + nota2alumno2 + nota3alumno2 + nota4alumno2 + nota5alumno2) / 5;

        Console.WriteLine();
        Console.WriteLine("Ingrese el nombre del tercer estudiante:");
        nombrealumno3 = (Console.ReadLine());

        Console.WriteLine("Ingrese las notas de " + nombrealumno3 + ":" );
        nota1alumno3 = Double.Parse(Console.ReadLine());
        nota2alumno3 = Double.Parse(Console.ReadLine());
        nota3alumno3 = Double.Parse(Console.ReadLine());
        nota4alumno3 = Double.Parse(Console.ReadLine());
        nota5alumno3 = Double.Parse(Console.ReadLine());

        promedioalumno3 = (nota1alumno3 + nota2alumno3 + nota3alumno3 + nota4alumno3 + nota5alumno3) / 5;

        Console.WriteLine();
        Console.WriteLine("Ingrese el nombre del cuarto estudiante:");
        nombrealumno4 = (Console.ReadLine());

        Console.WriteLine("Ingrese las notas de " + nombrealumno4 + ":" );
        nota1alumno4 = Double.Parse(Console.ReadLine());
        nota2alumno4 = Double.Parse(Console.ReadLine());
        nota3alumno4 = Double.Parse(Console.ReadLine());
        nota4alumno4 = Double.Parse(Console.ReadLine());
        nota5alumno4 = Double.Parse(Console.ReadLine());

        promedioalumno4 = (nota1alumno4 + nota2alumno4 + nota3alumno4 + nota4alumno4 + nota5alumno4) / 5;

        Console.WriteLine();
        Console.WriteLine("Ingrese el nombre del quinto estudiante:");
        nombrealumno5 = (Console.ReadLine());

        Console.WriteLine("Ingrese las notas de " + nombrealumno5 + ":" );
        nota1alumno5 = Double.Parse(Console.ReadLine());
        nota2alumno5 = Double.Parse(Console.ReadLine());
        nota3alumno5 = Double.Parse(Console.ReadLine());
        nota4alumno5 = Double.Parse(Console.ReadLine());
        nota5alumno5 = Double.Parse(Console.ReadLine());

        promedioalumno5 = (nota1alumno5 + nota2alumno5 + nota3alumno5 + nota4alumno5 + nota5alumno5) / 5;

        Console.WriteLine();
        Console.WriteLine();

        if (nota1alumno1 < 0 || nota2alumno1 < 0 || nota3alumno1 < 0 || nota4alumno1 < 0 || nota5alumno1 < 0 || nota1alumno2 < 0 || nota2alumno2 < 0 || nota3alumno2 < 0 || nota4alumno2 < 0 || nota5alumno2 < 0 || nota1alumno3 < 0 || nota2alumno3 < 0 || nota3alumno3 < 0 || nota4alumno3 < 0 || nota5alumno3 < 0 || nota1alumno4 < 0 || nota2alumno4 < 0 || nota3alumno4 < 0 || nota4alumno4 < 0 || nota5alumno4 < 0 || nota1alumno5 < 0 || nota2alumno5 < 0 || nota3alumno5 < 0 || nota4alumno5 < 0 || nota5alumno5 < 0)
        {
        Console.WriteLine("No puede haber ninguna nota negativa. Por favor intente de nuevo.");
        }
        if (nota1alumno1 > 10 || nota2alumno1 > 10 || nota3alumno1 > 10 || nota4alumno1 > 10 || nota5alumno1 > 10 || nota1alumno2 > 10 || nota2alumno2 > 10 || nota3alumno2 > 10 || nota4alumno2 > 10 || nota5alumno2 > 10 || nota1alumno3 > 10 || nota2alumno3 > 10 || nota3alumno3 > 10 || nota4alumno3 > 10 || nota5alumno3 > 10 || nota1alumno4 > 10 || nota2alumno4 > 10 || nota3alumno4 > 10 || nota4alumno4 > 10 || nota5alumno4 > 10 || nota1alumno5 > 10 || nota2alumno5 > 10 || nota3alumno5 > 10 || nota4alumno5 > 10 || nota5alumno5 > 10)
        {
        Console.WriteLine("No puede haber ninguna nota mayor que 10. Por favor intente de nuevo.");
        }

        else
        {
        if (promedioalumno1 >= 7)
        {
        Console.WriteLine("Promedio de " + nombrealumno1 + ": " + promedioalumno1 + " (Aprobado).");
        }
        if (promedioalumno1 >= 4 && promedioalumno1 < 7)
        {
        Console.WriteLine("Promedio de " + nombrealumno1 + ": " + promedioalumno1 + " (Regular).");
        }
        if (promedioalumno1 < 4)
        {
        Console.WriteLine("Promedio de " + nombrealumno1 + ": " + promedioalumno1 + " (Reprobado).");
        }

        if (promedioalumno2 >= 7)
        {
        Console.WriteLine("Promedio de " + nombrealumno2 + ": " + promedioalumno2 + " (Aprobado).");
        }
        if (promedioalumno2 >= 4 && promedioalumno2 < 7)
        {
        Console.WriteLine("Promedio de " + nombrealumno2 + ": " + promedioalumno2 + " (Regular).");
        }
        if (promedioalumno2 < 4)
        {
        Console.WriteLine("Promedio de " + nombrealumno2 + ": " + promedioalumno2 + " (Reprobado).");
        }

        if (promedioalumno3 >= 7)
        {
        Console.WriteLine("Promedio de " + nombrealumno3 + ": " + promedioalumno3 + " (Aprobado).");
        }
        if (promedioalumno3 >= 4 && promedioalumno3 < 7)
        {
        Console.WriteLine("Promedio de " + nombrealumno3 + ": " + promedioalumno3 + " (Regular).");
        }
        if (promedioalumno3 < 4)
        {
        Console.WriteLine("Promedio de " + nombrealumno3 + ": " + promedioalumno3 + " (Reprobado).");
        }
        
        if (promedioalumno4 >= 7)
        {
        Console.WriteLine("Promedio de " + nombrealumno4 + ": " + promedioalumno4 + " (Aprobado).");
        }
        if (promedioalumno4 >= 4 && promedioalumno4 < 7)
        {
        Console.WriteLine("Promedio de " + nombrealumno4 + ": " + promedioalumno4 + " (Regular).");
        }
        if (promedioalumno4 < 4)
        {
        Console.WriteLine("Promedio de " + nombrealumno4 + ": " + promedioalumno4 + " (Reprobado).");
        }

        if (promedioalumno5 >= 7)
        {
        Console.WriteLine("Promedio de " + nombrealumno5 + ": " + promedioalumno5 + " (Aprobado).");
        }
        if (promedioalumno5 >= 4 && promedioalumno5 < 7)
        {
        Console.WriteLine("Promedio de " + nombrealumno5 + ": " + promedioalumno5 + " (Regular).");
        }
        if (promedioalumno5 < 4)
        {
        Console.WriteLine("Promedio de " + nombrealumno5 + ": " + promedioalumno5 + " (Reprobado).");
        }

        
        if (promedioalumno1 > promedioalumno2 && promedioalumno1 > promedioalumno3 && promedioalumno1 > promedioalumno4 && promedioalumno1 > promedioalumno5)
        {
        Console.WriteLine();
        Console.WriteLine(nombrealumno1 + " es el alumno con mayor promedio.");
        }
        if (promedioalumno2 > promedioalumno1 && promedioalumno2 > promedioalumno3 && promedioalumno2 > promedioalumno4 && promedioalumno2 > promedioalumno5)
        {
        Console.WriteLine();
        Console.WriteLine(nombrealumno2 + " es el alumno con mayor promedio.");
        }
        if (promedioalumno3 > promedioalumno1 && promedioalumno3 > promedioalumno2 && promedioalumno3 > promedioalumno4 && promedioalumno3 > promedioalumno5)
        {
        Console.WriteLine();
        Console.WriteLine(nombrealumno3 + " es el alumno con mayor promedio.");
        }
        if (promedioalumno4 > promedioalumno1 && promedioalumno4 > promedioalumno2 && promedioalumno4 > promedioalumno3 && promedioalumno4 > promedioalumno5)
        {
        Console.WriteLine();
        Console.WriteLine(nombrealumno4 + " es el alumno con mayor promedio.");
        }
        if (promedioalumno5 > promedioalumno1 && promedioalumno5 > promedioalumno2 && promedioalumno5 > promedioalumno3 && promedioalumno5 > promedioalumno4)
        {
        Console.WriteLine();
        Console.WriteLine(nombrealumno5 + " es el alumno con mayor promedio.");
        }

        if (promedioalumno1 < promedioalumno2 && promedioalumno1 < promedioalumno3 && promedioalumno1 < promedioalumno4 && promedioalumno1 < promedioalumno5)
        {
        Console.WriteLine(nombrealumno1 + " es el alumno con menor promedio.");
        }
        if (promedioalumno2 < promedioalumno1 && promedioalumno2 < promedioalumno3 && promedioalumno2 < promedioalumno4 && promedioalumno2 < promedioalumno5)
        {
        Console.WriteLine(nombrealumno2 + " es el alumno con menor promedio.");
        }
        if (promedioalumno3 < promedioalumno1 && promedioalumno3 < promedioalumno2 && promedioalumno3 < promedioalumno4 && promedioalumno3 < promedioalumno5)
        {
        Console.WriteLine(nombrealumno3 + " es el alumno con menor promedio.");
        }
        if (promedioalumno4 < promedioalumno1 && promedioalumno4 < promedioalumno2 && promedioalumno4 < promedioalumno3 && promedioalumno4 < promedioalumno5)
        {
        Console.WriteLine(nombrealumno4 + " es el alumno con menor promedio.");
        }
        if (promedioalumno5 < promedioalumno1 && promedioalumno5 < promedioalumno2 && promedioalumno5 < promedioalumno3 && promedioalumno5 < promedioalumno4)
        {
        Console.WriteLine(nombrealumno5 + " es el alumno con menor promedio.");
        }

        }
        }
        catch (Exception error)
        {
        Console.WriteLine("Error: " + error.Message);
        }
       Console.ReadKey();
        }
    }
}
