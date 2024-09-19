using Microsoft.VisualBasic;
using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        string F="v";
        Double v1=0,v2=0,v3=0,d=0;
        Console.WriteLine("Para comenzar ingrese (v/f)");
        F=Console.ReadLine();
        while (F=="v") { 
           
            Console.WriteLine("Ingrese el el ultimo dijito de la placa:");
            d=double.Parse(Console.ReadLine());
            if (d>=0&&d<=3)
            {
                v1++;
            }
            if (d >= 4 && d <= 6)
            {
                v2++;
            }
            if (d >= 7 && d <= 9)
            {
                v3++;
            }
           
            Console.WriteLine("Para comenzar ingrese (v/f)");
            F = Console.ReadLine();
        }
        Console.WriteLine($"Carros verdes:{v1++}");
        Console.WriteLine($"Carros azules{v2++}");
        Console.WriteLine($"Carros rojos{v3++}");




    }



    
}