internal class Program
{
    private static void Main(string[] args)
    {
    //Hacer un programa para recibir listas de números positivos 
    //que están separadas entre sí por un cero. El fin de la carga 
    //se notifica con un número negativo. Luego mostrar cuántos 
    //números tiene cada lista.

        int n = 1, contadorLista, numeroGrupo = 0;

        while (n >= 0)
        {
            Console.WriteLine("Ingrese un numero inicial: ");
            n = int.Parse(Console.ReadLine());
            numeroGrupo++;
            contadorLista = 0;
            while (n > 0){
                contadorLista++;
                Console.WriteLine("Ingrese otro numero: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La cantidad de numeros ingresados en El Gropo: " + numeroGrupo + "  es: " + contadorLista);
        }
        
    }
}