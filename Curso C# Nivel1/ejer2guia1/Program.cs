internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa para solicitar por teclado un número 
        //y luego devolver su valor elevado al cubo.
        int n, resultado;
   
        Console.WriteLine("Ingrese un numero:");
        n = int.Parse(Console.ReadLine());
       

        resultado = n * n * n;

        
        Console.WriteLine("El resultado es: " + resultado);
    }
}