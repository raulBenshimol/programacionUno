internal class Program
{
    private static void Main(string[] args)
    {
 //Hacer un programa para ingresar tres números y emitir un 
 //cartel aclaratorio si la suma de los dos primeros es mayor 
 //al producto del segundo con el tercero.

        int a, b, c;

        Console.WriteLine("Ingre un numero:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el ultimo:");
        c = int.Parse(Console.ReadLine());
        a = a + b;
        b = b * c;

            if (a > b)
                Console.WriteLine("Primero mas el segundo es mayor que el segundo por el tercero");
            else
                Console.WriteLine("El segundo por el tercero es mayor que el primero mas el segundo");

        Console.WriteLine("Fin del programa");
    }
}