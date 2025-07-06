internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa para ingresar cuatro 
        //números distintos y luego mostrar por 
        //pantalla el menor de ellos.

        int n1, n2, n3, n4, menor;

        Console.WriteLine("Ingrese Numero 1");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese Numero 1");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese Numero 1");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese Numero 1");
        n4 = int.Parse(Console.ReadLine());

            if (n1 < n2)
                menor = n1;
            else
                menor = n2;
            if (n3 < menor)
                menor = n3;
            if (n4 < menor)
                menor = n4;

        Console.WriteLine("El Menor es: " + menor);   
    }
}