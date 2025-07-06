internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa que solicite UN número y luego calcule 
        //y emita un cartel aclaratorio si el mismo es primo o no es primo.  
        //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

        int n, conPrimos = 0;

        Console.WriteLine("Ingrese un NUmero: ");
        n = int.Parse(Console.ReadLine());

        for (int x = 1; x <= n; x++)
        {
            if (n % x == 0)
                conPrimos ++;   
        }
        if (conPrimos == 2)
            Console.WriteLine("En numero Es Primo...");
            else
                Console.WriteLine("El numero No es Promo...");
    }
}