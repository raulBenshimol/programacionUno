internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa para ingresar cuatro números 
        //y luego mostrar por pantalla cuáles son mayores a 100.

        int n1, n2, n3, n4;
        
        Console.WriteLine("Ingrese Numero 1");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese Numero 2");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese Numero 3");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese Numero 4");
        n4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Mayor a 100:");

        if (n1 > 100)
            Console.WriteLine(n1);
        if (n2 > 100)
            Console.WriteLine(n2);
        if (n3 > 100)   
            Console.WriteLine(n3);
        if (n4 > 100)
            Console.WriteLine(n4);

        Console.WriteLine("Fin del Programa");
        }
}