internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa para ingresar 10 números. 
        //El mismo debe analizar y mostrar por pantalla 
        //cuántos de esos números son primos.

        int n, cont, contadorPrimos = 0;

        for (int x = 0; x < 10; x++)
        {
           Console.WriteLine("Ingrese un numero: ");
           n = int.Parse(Console.ReadLine());

           cont = 0;

           for (int y = 1; y <= n; y++)
           {
            if (n % y == 0)
                cont++;           
           }
           if (cont == 2)
            contadorPrimos++;
        }
        Console.WriteLine("La cantidad de numeros primos es: " + contadorPrimos);
    }
}