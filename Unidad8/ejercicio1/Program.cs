internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer una función llamada “producto” que reciba 
        //dos números enteros y que devuelva el producto de ambos. 
        //Luego hacer un programa que pida el precio de un artículo 
        //y la cantidad vendida y muestre por pantalla el monto 
        //total a pagar. Usar la función.

        int precioArticulo, cantidadVendida, montoTotal;

        Console.WriteLine("Ingrese precio del articulo: ");
        precioArticulo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese cantidad vendida: ");
        cantidadVendida = int.Parse(Console.ReadLine());

        montoTotal = producto(precioArticulo, cantidadVendida);

        Console.WriteLine("El monto total vendido es: " + montoTotal);
    }

    static int producto(int a, int b){
        int r;
        r = a * b;
        return r;
    }
}
