internal class Program
{
    private static void Main(string[] args)
    {
        // Hacer un programa que solicite 20 números 
        //y luego emitir por pantalla el máximo de los 
        //números pares y el mínimo de los números impares.

        int n, maxPar = 0, minImpar = 0;
        bool bPar = false, bImpar = false; 

        for (int x = 0; x < 5; x++)
        {
        Console.WriteLine("Ingrese un numero: ");
        n = int.Parse(Console.ReadLine());

        if (n % 2 == 0){
            if (!bPar){
                maxPar = n;
                bPar = true;
            }else if (n > maxPar){
                maxPar = n;
            }
        }else if (!bImpar){
            minImpar = n;
            bImpar = true;
            }else if (n < minImpar){
                minImpar = n;
            }

        }
        Console.WriteLine("El maximo Par es: " + maxPar);
        Console.WriteLine("El minimo Impar es: " + minImpar);
    }
}

