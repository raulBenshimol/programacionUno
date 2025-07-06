internal class Program
{
    private static void Main(string[] args)
    {
        // Hacer un programa que solicite 20 edades 
        //y luego calcule el promedio de edad de 
        //aquellas personas mayores a 18 años.

        int edad, conMayores = 0;
        float acuMayores = 0, promedio;

        for (int x = 0; x < 20; x++)
        {
        Console.WriteLine("Ingrese edad: "); 
        edad = int.Parse(Console.ReadLine());

            if (edad > 18){
                acuMayores += edad;
                conMayores ++;
            }
        }
        promedio = acuMayores / conMayores;

        Console.WriteLine("El promedio de edad de personas mayores de 18 es: " + promedio.ToString("0.00") + "años");
    }
}