using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SegundoDesafíoPráctico
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Ganancias de sucursales.";

        string nombretienda1, nombretienda2, nombretienda3, nombretienda4, nombretienda5;
        Double gananciastienda1, gananciastienda2, gananciastienda3, gananciastienda4, gananciastienda5, empleadostienda1, empleadostienda2, empleadostienda3, empleadostienda4, empleadostienda5, gananciatotaldelaempresa;

        try
        {
        Console.WriteLine("Ingrese el nombre de la tienda:");
        nombretienda1 = (Console.ReadLine());
        Console.WriteLine("Ingrese el monto de la ganancia de esta sucursal:");
        Console.Write("$");
        gananciastienda1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de empleados de esta sucursal:");
        empleadostienda1 = Double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Ingrese el nombre de la tienda:");
        nombretienda2 = (Console.ReadLine());
        Console.WriteLine("Ingrese el monto de la ganancia de esta sucursal:");
        Console.Write("$");
        gananciastienda2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de empleados de esta sucursal:");
        empleadostienda2 = Double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Ingrese el nombre de la tienda:");
        nombretienda3 = (Console.ReadLine());
        Console.WriteLine("Ingrese el monto de la ganancia de esta sucursal:");
        Console.Write("$");
        gananciastienda3 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de empleados de esta sucursal:");
        empleadostienda3 = Double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Ingrese el nombre de la tienda:");
        nombretienda4 = (Console.ReadLine());
        Console.WriteLine("Ingrese el monto de la ganancia de esta sucursal:");
        Console.Write("$");
        gananciastienda4 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de empleados de esta sucursal:");
        empleadostienda4 = Double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Ingrese el nombre de la tienda:");
        nombretienda5 = (Console.ReadLine());
        Console.WriteLine("Ingrese el monto de la ganancia de esta sucursal:");
        Console.Write("$");
        gananciastienda5 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de empleados de esta sucursal:");
        empleadostienda5 = Double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine();

        gananciatotaldelaempresa = gananciastienda1 + gananciastienda2 + gananciastienda3 + gananciastienda4 + gananciastienda5;


        if (gananciastienda1 < 1000 || gananciastienda2 < 1000 || gananciastienda3 < 1000 || gananciastienda4 < 1000 || gananciastienda5 < 1000)
        {
        Console.WriteLine("No pueden haber ganancias menores que $1000. Por favor intente de nuevo.");
        }
        if (gananciastienda1 < 0 || gananciastienda2 < 0 || gananciastienda3 < 0 || gananciastienda4 < 0 || gananciastienda5 < 0)
        {
        Console.WriteLine("No pueden haber ganancias negativas. Por favor intente de nuevo.");
        }
        if (empleadostienda1 < 10 || empleadostienda2 < 10 || empleadostienda3 < 10 || empleadostienda4 < 10 || empleadostienda5 < 10)
        {
        Console.WriteLine("No pueden haber menos de 10 empleados por sucursal. Por favor intente de nuevo.");
        }

        else
        {
        if (gananciastienda1 >= 30000)
        {
        Console.WriteLine();
        Console.WriteLine(nombretienda1 + " (Bien hecho).");
        Console.WriteLine("Ganancias: $" + gananciastienda1);
        Console.WriteLine("Empleados:" + empleadostienda1);
        }
        if (gananciastienda1 < 30000)
        {
        Console.WriteLine();
        Console.WriteLine(nombretienda1 + " (Regular).");
        Console.WriteLine("Ganancias: $" + gananciastienda1);
        Console.WriteLine("Empleados:" + empleadostienda1);
        }
        if (gananciastienda2 >= 30000)
        {
        Console.WriteLine();
        Console.WriteLine(nombretienda2 + " (Bien hecho).");
        Console.WriteLine("Ganancias: $" + gananciastienda2);
        Console.WriteLine("Empleados:" + empleadostienda2);
        }
        if (gananciastienda2 < 30000)
        {
        Console.WriteLine();
        Console.WriteLine(nombretienda2 + " (Regular).");
        Console.WriteLine("Ganancias: $" + gananciastienda2);
        Console.WriteLine("Empleados:" + empleadostienda2);
        }
        if (gananciastienda3 >= 30000)
        {
        Console.WriteLine();
        Console.WriteLine(nombretienda3 + " (Bien hecho).");
        Console.WriteLine("Ganancias: $" + gananciastienda3);
        Console.WriteLine("Empleados:" + empleadostienda3);
        }
        if (gananciastienda3 < 30000)
        {
        Console.WriteLine();
        Console.WriteLine(nombretienda3 + " (Regular).");
        Console.WriteLine("Ganancias: $" + gananciastienda3);
        Console.WriteLine("Empleados:" + empleadostienda3);
        }
        if (gananciastienda4 >= 30000)
        {
        Console.WriteLine();
        Console.WriteLine(nombretienda4 + " (Bien hecho).");
        Console.WriteLine("Ganancias: $" + gananciastienda4);
        Console.WriteLine("Empleados:" + empleadostienda4);
        }
        if (gananciastienda4 < 30000)
        {
        Console.WriteLine();
        Console.WriteLine(nombretienda4 + " (Regular).");
        Console.WriteLine("Ganancias: $" + gananciastienda4);
        Console.WriteLine("Empleados:" + empleadostienda4);
        }
        if (gananciastienda5 >= 30000)
        {
        Console.WriteLine();
        Console.WriteLine(nombretienda5 + " (Bien hecho).");
        Console.WriteLine("Ganancias: $" + gananciastienda5);
        Console.WriteLine("Empleados:" + empleadostienda5);
        }
        if (gananciastienda5 < 30000)
        {
        Console.WriteLine();
        Console.WriteLine(nombretienda5 + " (Regular).");
        Console.WriteLine("Ganancias: $" + gananciastienda5);
        Console.WriteLine("Empleados:" + empleadostienda5);
        }
        Console.WriteLine();
        

        if (gananciastienda1 < 30000 && gananciastienda2 < 30000 && gananciastienda3 < 30000 && gananciastienda4 < 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 0.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 < 30000 && gananciastienda3 < 30000 && gananciastienda4 < 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 1.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 >= 30000 && gananciastienda3 < 30000 && gananciastienda4 < 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 1.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 < 30000 && gananciastienda3 >= 30000 && gananciastienda4 < 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 1.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 < 30000 && gananciastienda3 > 30000 && gananciastienda4 >= 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 1.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 < 30000 && gananciastienda3 > 30000 && gananciastienda4 < 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 1.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 < 30000 && gananciastienda3 > 30000 && gananciastienda4 >= 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 2.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 < 30000 && gananciastienda3 >= 30000 && gananciastienda4 < 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 2.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 >= 30000 && gananciastienda3 < 30000 && gananciastienda4 < 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 2.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 >= 30000 && gananciastienda3 < 30000 && gananciastienda4 < 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 2.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 < 30000 && gananciastienda3 >= 30000 && gananciastienda4 < 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 2.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 >= 30000 && gananciastienda3 >= 30000 && gananciastienda4 < 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 2.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 < 30000 && gananciastienda3 < 30000 && gananciastienda4 < 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 2.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 < 30000 && gananciastienda3 < 30000 && gananciastienda4 >= 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 2.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 >= 30000 && gananciastienda3 < 30000 && gananciastienda4 >= 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 2.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 < 30000 && gananciastienda3 >= 30000 && gananciastienda4 >= 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 2.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 < 30000 && gananciastienda3 >= 30000 && gananciastienda4 >= 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 3.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 >= 30000 && gananciastienda3 < 30000 && gananciastienda4 >= 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 3.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 < 30000 && gananciastienda3 < 30000 && gananciastienda4 >= 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 3.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 >= 30000 && gananciastienda3 >= 30000 && gananciastienda4 < 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 3.");
        } 
        if (gananciastienda1 >= 30000 && gananciastienda2 < 30000 && gananciastienda3 >= 30000 && gananciastienda4 < 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 3.");
        }     
        if (gananciastienda1 >= 30000 && gananciastienda2 >= 30000 && gananciastienda3 < 30000 && gananciastienda4 < 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 3.");
        }  
        if (gananciastienda1 < 30000 && gananciastienda2 >= 30000 && gananciastienda3 >= 30000 && gananciastienda4 >= 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 3.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 < 30000 && gananciastienda3 >= 30000 && gananciastienda4 >= 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 3.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 >= 30000 && gananciastienda3 < 30000 && gananciastienda4 >= 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 3.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 >= 30000 && gananciastienda3 >= 30000 && gananciastienda4 < 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 3.");
        }
        if (gananciastienda1 < 30000 && gananciastienda2 >= 30000 && gananciastienda3 >= 30000 && gananciastienda4 >= 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 4.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 < 30000 && gananciastienda3 >= 30000 && gananciastienda4 >= 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 4.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 >= 30000 && gananciastienda3 < 30000 && gananciastienda4 >= 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 4.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 >= 30000 && gananciastienda3 >= 30000 && gananciastienda4 < 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 4.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 >= 30000 && gananciastienda3 >= 30000 && gananciastienda4 >= 30000 && gananciastienda5 < 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 4.");
        }
        if (gananciastienda1 >= 30000 && gananciastienda2 >= 30000 && gananciastienda3 >= 30000 && gananciastienda4 >= 30000 && gananciastienda5 >= 30000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias mayores de $30,000 son: 5.");
        }

        
        if (gananciastienda1 > 25000 && gananciastienda2 > 25000 && gananciastienda3 > 25000 && gananciastienda4 > 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 0.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 > 25000 && gananciastienda3 > 25000 && gananciastienda4 > 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 1.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 < 25000 && gananciastienda3 > 25000 && gananciastienda4 > 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 1.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 > 25000 && gananciastienda3 < 25000 && gananciastienda4 > 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 1.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 > 25000 && gananciastienda3 > 25000 && gananciastienda4 < 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 1.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 > 25000 && gananciastienda3 > 25000 && gananciastienda4 > 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 1.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 > 25000 && gananciastienda3 > 25000 && gananciastienda4 < 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 2.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 > 25000 && gananciastienda3 < 25000 && gananciastienda4 > 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 2.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 < 25000 && gananciastienda3 > 25000 && gananciastienda4 > 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 2.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 < 25000 && gananciastienda3 > 25000 && gananciastienda4 > 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 2.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 > 25000 && gananciastienda3 < 25000 && gananciastienda4 > 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 2.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 < 25000 && gananciastienda3 < 25000 && gananciastienda4 > 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 2.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 > 25000 && gananciastienda3 > 25000 && gananciastienda4 > 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 2.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 > 25000 && gananciastienda3 > 25000 && gananciastienda4 < 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 2.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 < 25000 && gananciastienda3 > 25000 && gananciastienda4 < 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 2.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 > 25000 && gananciastienda3 < 25000 && gananciastienda4 < 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 2.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 > 25000 && gananciastienda3 < 25000 && gananciastienda4 < 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 3.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 < 25000 && gananciastienda3 > 25000 && gananciastienda4 < 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 3.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 > 25000 && gananciastienda3 > 25000 && gananciastienda4 < 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 3.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 < 25000 && gananciastienda3 < 25000 && gananciastienda4 > 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 3.");
        } 
        if (gananciastienda1 < 25000 && gananciastienda2 > 25000 && gananciastienda3 < 25000 && gananciastienda4 > 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 3.");
        }     
        if (gananciastienda1 < 25000 && gananciastienda2 < 25000 && gananciastienda3 > 25000 && gananciastienda4 > 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 3.");
        }  
        if (gananciastienda1 > 25000 && gananciastienda2 < 25000 && gananciastienda3 < 25000 && gananciastienda4 < 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 3.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 > 25000 && gananciastienda3 < 25000 && gananciastienda4 < 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 3.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 < 25000 && gananciastienda3 > 25000 && gananciastienda4 < 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 3.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 < 25000 && gananciastienda3 < 25000 && gananciastienda4 > 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 3.");
        }
        if (gananciastienda1 > 25000 && gananciastienda2 < 25000 && gananciastienda3 < 25000 && gananciastienda4 < 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 4.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 > 25000 && gananciastienda3 < 25000 && gananciastienda4 < 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 4.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 < 25000 && gananciastienda3 > 25000 && gananciastienda4 < 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 4.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 < 25000 && gananciastienda3 < 25000 && gananciastienda4 > 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 4.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 < 25000 && gananciastienda3 < 25000 && gananciastienda4 < 25000 && gananciastienda5 > 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 4.");
        }
        if (gananciastienda1 < 25000 && gananciastienda2 < 25000 && gananciastienda3 < 25000 && gananciastienda4 < 25000 && gananciastienda5 < 25000)
        { 
        Console.WriteLine("Cantidad de sucursales que obtienen ganancias entre $1,000 y $25,000 son: 5.");
        }

        Console.WriteLine("Ganancia total de la empresa: $" + gananciatotaldelaempresa + ".");

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
