﻿internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa para ingresar por teclado las 
        //tres notas de exámenes de un alumno y luego calcule 
        //y emita por pantalla el promedio final.


        float nota1, nota2, nota3;
        float promedio;

        Console.WriteLine("Nota 1: ");
        nota1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Nota 2: ");
        nota2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Nota 3: ");
        nota3 = float.Parse(Console.ReadLine());

        promedio = (nota1 + nota2 +nota3) / 3;

        Console.WriteLine("Promedio Final: " + promedio.ToString("0.00"));

        nota1 = int.

    }
}