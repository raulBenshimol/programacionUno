internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer una función llamada “par” que reciba un número entero 
        //y devuelva 1 si es par o cero si no lo es. Hacer un programa 
        //para ingresar 20 números y mostrar por pantalla cuántos son pares.

        int n, conPar = 0, conImpar = 0; 
        bool resultado;

        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("Ingrese un numero entero: ");
            n = int.Parse(Console.ReadLine());

            resultado = par(n);
            if (resultado){
                conPar++;
            }
            else
                conImpar++;
        }
        Console.WriteLine("La cantidad de Pares ingresados es: " + conPar);
        Console.WriteLine("La cantidad de Impares ingresados es: " + conImpar);
    }

    static bool par(int a){
        //bool b;
        return a % 2 == 0;
        //{
           // b = true;
        //}
        //else{
           // b = false;
        //}
        //return b;
    }
    
}