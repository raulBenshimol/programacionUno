internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa que permita ingresar los kilómetros 
        //existentes entre dos ciudades y la velocidad promedio 
        //de un vehículo. Calcular y emitir por pantalla el tiempo 
        //aproximado que demandará llegar de un punto a otro teniendo 
        //en cuenta los datos ingresados.
        float k, v, tiempo;

            Console.WriteLine("Distancia entre las Ciudades en Km: ");
            k = float.Parse(Console.ReadLine());

            Console.WriteLine("Velocidad Promedio en Km/H: ");
            v = float.Parse(Console.ReadLine());

                tiempo = k / v;

        Console.WriteLine("Tiempo de Viaje: " + tiempo.ToString("0.00") + " Horas");

    }
}