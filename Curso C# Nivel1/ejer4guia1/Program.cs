internal class Program
{
    private static void Main(string[] args)
    {
        //Una casa de computación paga a sus empleados un sueldo
        //fijo de ARS15000 más una comisión del 5% sobre el total 
        //facturado por cada empleado. Hacer un programa para ingresar 
        //el total facturado por un empleado y que luego calcule y 
        //emita por pantalla el sueldo total a cobrar por el mismo.
        float tf, sf;
        const float sueldoFijo = 15000;
        const float porcentajeComicion = 0.05F;
       
        Console.WriteLine("Total Facturado: ");
         tf = float.Parse(Console.ReadLine());
        
             sf = sueldoFijo + (porcentajeComicion*tf);

         Console.WriteLine("Sueldo Final: " + sf+"Pesos");
    }
}