internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer una función llamada “primo” que reciba un número entero 
        //y devuelva 1 si el número es primo o cero si no lo es. 
        //Hacer un programa para ingresar números. El lote corta cuando se 
        //ingresa un número cero. Informar el promedio teniendo 
        //en cuenta sólo los números primos.

        int n;
        float porcentajePrimo = 0, acuPrimo = 0, conPrimo = 0;
        bool r;
        Console.WriteLine("Ingrese un numero entero: ");
        n = int.Parse(Console.ReadLine());  
        while (n != 0){
            r = primo(n);
            if (r){
                acuPrimo += n;
                conPrimo ++;
            }
            Console.WriteLine("Ingrese un  otro numero entero: ");
            n = int.Parse(Console.ReadLine());
        }
        porcentajePrimo = acuPrimo / conPrimo;
        Console.WriteLine("El promedio de numeros primos ingresados es: " + porcentajePrimo);
    }
    static bool primo(int a){
        int con = 0;
        for (int x = 1; x <= a; x++)
        {if (a % x == 0)
                con++;
        }if (con == 2)
            return true;
        else
            return false;
    }
}