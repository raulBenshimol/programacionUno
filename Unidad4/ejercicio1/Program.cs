internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa que solicite el ingreso de dos números y luego calcular:

        //La resta si el primero es mayor que el segundo.
        //La suma si son iguales.
        //El producto si el primero es menor.
        //Se deberá emitir un cartel por pantalla con el resultado correspondiente.
        //Console.WriteLine("Hello, World!");
        int a, b, r;

        Console.WriteLine("Ingrese primer numero:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        b = int.Parse(Console.ReadLine());

        if (a > b)
            r = a-b;
        else 
            r = b*a;
        if (a == b)
            r = a + b;

        Console.WriteLine("El resultado de. " + r);

        Console.WriteLine("Fin del Programa");
    }
}