internal class Program
{
    private static void Main(string[] args)
    {
//Un importante negocio de desinfectante líquido realiza descuentos 
//dependiendo de la cantidad de litros vendidos según la siguiente escala:
//Si vende menos de 100 litros, no hay descuento.
//Si vende entre 101 y 300 litros, el descuento es del 10%.
//Si vende entre 301 y 500 litros, el descuento es del 15%.
//Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
//Hacer un programa que solicite el ingreso del importe total de la venta y 
//la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
        
        float importeTotal;
        int litros;

        Console.WriteLine("Ingrese Importe Total:");
        importeTotal = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese Litros Vendidos:");
        litros = int.Parse(Console.ReadLine());

            if (litros > 500)
                importeTotal = importeTotal * 0.75F;
            else if (litros > 300)
                importeTotal = importeTotal * 0.85F;
            else if (litros > 100)
                importeTotal = importeTotal *0.95F;
            
        Console.WriteLine("Importe Total con Descuento: " + importeTotal.ToString("0.00") + "Pesos ARS");
    }
}