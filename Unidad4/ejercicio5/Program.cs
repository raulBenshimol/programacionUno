﻿internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa para ingresar 4 números. 
        //Luego analizar e informar por pantalla si los 
        //mismos se encuentran ordenados de forma decreciente.

        int a, b, c, d;

        Console.WriteLine("Ingre un numero:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro:");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el ultimo:");
        d = int.Parse(Console.ReadLine());

        if (a>b && b>c && c>d)
            Console.WriteLine("Estan ordenador decreciente");
        else
            Console.WriteLine("No estan Ordenados decreciente");

        Console.WriteLine("Fin del pregrama");
    }
}