internal class Program
{
    private static void Main(string[] args)
    {
        // Una casa de video juegos otorga un descuento dependiendo 
        //del importe de la compra realizada según los siguientes valores:
        //Si el importe es menor a ARS 1000, no hay descuento.
        //Si el importe es ARS 1000 o más pero menor a ARS 5000, 
        //aplica un descuento del 10%.
        //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
        //Hacer un programa para ingresar un importe de venta y luego 
        //muestre por pantalla el importe final con el descuento que corresponda.
        float compra, importeFinal;

        Console.WriteLine("Ingrese Importe de Compra");
        compra = float.Parse(Console.ReadLine());

            if (compra > 5000)
                importeFinal = compra * 82 / 100;
            else if (compra > 1000)
                importeFinal = compra * 90 / 100;    
            else
                importeFinal = compra;
            
        Console.WriteLine("Importe Final con Descuesto " + importeFinal.ToString("0.00"));  
            
    }
}