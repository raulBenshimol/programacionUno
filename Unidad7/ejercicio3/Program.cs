internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa que solicite una cadena de caracteres 
        //y dos caracteres sueltos (tres ingresos). El programa 
        //deberá generar una cadena donde todas las ocurrencias del 
        //primer carácter dado hayan sido reemplazadas por el segundo. 
        //Mostrar el resultado en pantalla. Ejemplo:
        //CADENA FUENTE: “La mar estaba serena"
        //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        //CADENA RESULTADO: “Li mir estibi sereni"

        char[] frase = new char[51];
        char letra0, letra1, letra2;
        int indice = 0;

        Console.WriteLine("Ingrese Cadena de caracteres, caracter por caracter, termina com punto...");
        letra0 = char.Parse(Console.ReadLine());

        while (letra0 != '.' && indice < 50){
            frase[indice] = letra0;
            letra0 = char.Parse(Console.ReadLine());
            indice++;
        }
        frase[indice] = '\0';

        Console.WriteLine("La Cadena sin modificar es: ");
        indice = 0;
        while (frase[indice] != '\0'){
            Console.Write(frase[indice]);
            indice++;
        }
        Console.WriteLine(" ");
        Console.WriteLine("Ingese caracter que quieres evaluar para cambiar: ");
        letra1 = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese caracter para cambiar: ");
        letra2 = char.Parse(Console.ReadLine());

        indice = 0;

        while (frase[indice] != '\0'){
            if (frase[indice] == letra1){
                frase[indice] = letra2;
            }
            indice++;
        }

        Console.WriteLine("La Cadena modificada es: ");
        indice = 0;
        while (frase[indice] != '\0'){
            Console.Write(frase[indice]);
            indice++;
        }
    }
}