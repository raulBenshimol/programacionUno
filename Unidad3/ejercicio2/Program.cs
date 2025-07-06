internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa para ingresar un número y luego se emita 
        //un cartel por pantalla “Positivo” si el número es mayor a cero, 
        //“Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
        int numero;

        Console.WriteLine("Ingrese un Numero");
        numero = int.Parse(Console.ReadLine());

            if (numero == 0)
                Console.WriteLine("Cero");
            else if (numero > 0)
                Console.WriteLine("Positivo");
            else
                Console.WriteLine("Negativo");

    Console.WriteLine("Gracias");      
        
    }
}


//float n1, n2, n3, promedio;
//        Console.WriteLine("Nota 1: ");
//        n1 = float.Parse(Console.ReadLine());
//        Console.WriteLine("Nota 2: ");
//        n2 = float.Parse(Console.ReadLine());
//        Console.WriteLine("Nota 3:  ");
//        n3 = float.Parse(Console.ReadLine());
//
//        promedio = (n1 + n2 +n3) / 3;
//      Console.WriteLine("Promedio: " + promedio.ToString("0.00"));