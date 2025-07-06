internal class Program
{
    private static void Main(string[] args)
    {
//Se dispone de una lista de 5 listas de números 
//enteros separados entre ellos por ceros. Se pide 
//determinar e informar:

//El número de grupo con mayor porcentaje de números 
//impares respecto al total de números que forman el grupo.

//Informar cuántos grupos están formados por todos 
//números ordenados de mayor a menor.

        int n, contadorTotal, contadorImpares, porcentajeImpares, porcentajeImparesMaximo = 0, grupoMaximo = 0;
        int mayor, contadorOrdenados = 0;
        bool bInicial, bOrdenados;

        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("Ingrese un Numero Inicial para el grupo: " + (x + 1));
            n = int.Parse(Console.ReadLine());
            
            contadorTotal = 0;
            contadorImpares = 0;
            porcentajeImpares = 0;

            bInicial = false; 
            bOrdenados = false;
            mayor = 0;

            while (n != 0)
            {
                contadorTotal++;
                if (n % 2 != 0)
                    contadorImpares++;
                if (!bInicial){
                    mayor = n;
                    bInicial = true;
                }
                else if (n < mayor){
                    mayor = n;
                }else
                    bOrdenados = true;  
                Console.WriteLine("Ingrese un Otro Numero: ");
                n = int.Parse(Console.ReadLine());              
            }
            porcentajeImpares = contadorImpares * 100 / contadorTotal;
            if (porcentajeImpares > porcentajeImparesMaximo){
                porcentajeImparesMaximo = porcentajeImpares;
                grupoMaximo = x+1;
            }
            if (!bOrdenados)
                contadorOrdenados ++;
        }
        Console.WriteLine("Numero de grupo con mayor % de impares es: " + grupoMaximo);
        Console.WriteLine("La cantidad de grupos ordenados de mayor a menor es: " + contadorOrdenados);
    }
}