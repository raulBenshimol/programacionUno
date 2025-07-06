internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa que solicite 10 números enteros y 
        //los guarde en un vector. Luego recorrer los elementos 
        //y determinar e informar cuál es el valor máximo y 
        //su posición dentro del vector.

        int[] vector = new int[10];
        int numeros, maximo, posicion;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingre un numero: ");
            numeros = int.Parse(Console.ReadLine());
            vector[x] = numeros;
        }
        maximo = vector[0];
        posicion = 1;
        for (int x = 0; x < 10; x++)
        {
            if (vector[x] > maximo){
                maximo = vector[x];
                posicion = x + 1;
            }
        }
        Console.WriteLine("El maximo numero imgresado es: " + maximo  + "  en la posicion: " + posicion);
    }
}
