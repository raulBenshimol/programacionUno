internal class Program
{
    private static void Main(string[] args)
    {
        // Una empresa comercializa 15 tipos de artículos y por cada venta 
        //realizada genera un registro con los siguientes datos:
        //- Número de Artículo (1 a 15)
        //- Cantidad Vendida 

        //Puede haber varios registros para el mismo artículo y el último se 
        //indica con número de artículo igual a 0.
        //Se pide determinar e informar:
        //a) El número de artículo que más se vendió en total.
        //b) Los números de artículos que no registraron ventas.
        //c) Cuantas unidades se vendieron del número de artículo 10.
//        int[] cantidadVendida = new int[15];
//        int numeroArticulo, cantida, i = 0, artMasVendido, numeroArtMasVendido;
//        for (int x = 0; x < 15; x++)
//        {
//           cantidadVendida[x] = 0;
//        }
//
//        Console.WriteLine("ingrese Numero de Articulo: ");
//        numeroArticulo = int.Parse(Console.ReadLine());
//        
//       i = numeroArticulo - 1;
//        while (numeroArticulo != 0){
//            Console.WriteLine("Ingrese Cantidad Vendidad: ");
//            cantida = int.Parse(Console.ReadLine());
//            cantidadVendida[i] += cantida;
//            Console.WriteLine("ingrese Numero de Articulo: ");
//            numeroArticulo = int.Parse(Console.ReadLine());
//            i = numeroArticulo - 1;
//        }
//       artMasVendido = cantidadVendida[0];
//       numeroArtMasVendido = 1;
//        for (int x = 0; x < 15; x++)
//        {
//            if (cantidadVendida[x] > artMasVendido){
//                artMasVendido = cantidadVendida[x];
//                numeroArtMasVendido = x + 1;                
//            }
//        }
//        Console.WriteLine("El numero de articulo mas vendido es: " +  numeroArtMasVendido  +  "con una cantidad de "  +  artMasVendido);
//        
//
//        Console.WriteLine("Los articulos que no registraron ventas son: ");
//        for (int x = 0; x < 15; x++)
//        {
//            if (cantidadVendida[x] == 0){
//                Console.WriteLine(x + 1);
//            }
//        }
//        Console.WriteLine(" ");
//        Console.WriteLine("Unidades vendidas del articulo 10 son: " + cantidadVendida[9]);



        int[] cantidadVendida = new int[15];
        int numeroArticulo, cantida, i = 0, artMasVendido, numeroArtMasVendido;
        for (int x = 0; x < 15; x++)
        {
            cantidadVendida[x] = 0;
        }

        Console.WriteLine("ingrese Numero de Articulo: ");
        numeroArticulo = int.Parse(Console.ReadLine());
        
        i = numeroArticulo - 1;
        while (numeroArticulo != 0){
            Console.WriteLine("Ingrese Cantidad Vendidad: ");
            cantida = int.Parse(Console.ReadLine());
            cantidadVendida[i] += cantida;
            Console.WriteLine("ingrese Numero de Articulo: ");
            numeroArticulo = int.Parse(Console.ReadLine());
            i = numeroArticulo - 1;
        }
        artMasVendido = cantidadVendida[0];
        numeroArtMasVendido = 1;
        for (int x = 0; x < 15; x++)
        {
            if (cantidadVendida[x] > artMasVendido){
                artMasVendido = cantidadVendida[x];
                numeroArtMasVendido = x + 1;                
            }
        }
        //Console.WriteLine("El numero de articulo mas vendido es: " +  numeroArtMasVendido  +  "con una cantidad de "  +  artMasVendido);

        Console.WriteLine("El numero de articulo mas vendido es: ");
        for (int x = 0; x < 15; x++)
        {
            if (cantidadVendida[x] == artMasVendido){
                Console.Write((x+1) + "  ");

            }
        }
        Console.WriteLine("y la cantidad vendida es: " + artMasVendido);
       
        Console.WriteLine("Los articulos que no registraron ventas son: ");
        for (int x = 0; x < 15; x++)
        {
            if (cantidadVendida[x] == 0){
                Console.Write((x + 1) + "  ");
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Unidades vendidas del articulo 10 son: " + cantidadVendida[9]);
    }
}