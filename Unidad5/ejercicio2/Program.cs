internal class Program
{
    private static void Main(string[] args)
    {   // Hacer un programa que solicite el ingreso de 10 números 
        //y que muestre el mayor de ellos por pantalla. Solo se debe 
        //emitir UN valor por pantalla.

        int n, mayor = 0;
        bool b = false;

        for (int x = 0; x < 10; x++)
        {
        Console.WriteLine("Ingrese nemero: ");
        n = int.Parse(Console.ReadLine());

        if (!b){
            mayor = n;
            b = true;
        }
        else{ 
            if (n > mayor)
            mayor = n;
        }

        }
        Console.WriteLine("El numero mayor es: " + mayor);
    }
}