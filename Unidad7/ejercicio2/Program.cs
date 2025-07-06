internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa que solicite 10  números enteros 
        //y los guarde en un vector. Luego recorrer ese vector 
        //para calcular el promedio. Mostrar por pantalla los 
        //valores que son mayores al promedio.

        int[] vector = new int[10];
        int numero, acu, promedio = 0;

        for (int x = 0; x < 10; x++)    
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            vector[x] = numero;
        }
        acu = 0;
        for (int x = 0; x < 10; x++)
        {
            acu += vector[x];
        }
        promedio = acu / 10;
        Console.WriteLine("Los numeros mayores al promedio son: ");
        for (int x = 0; x < 10; x++)
        {
            if (vector[x] > promedio){                
                Console.WriteLine(vector[x]);
            }
        }

        Console.WriteLine("Fin del Programa.");
    }
}