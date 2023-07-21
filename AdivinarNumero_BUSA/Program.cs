
    /*
    Ejercicio:
    ----------
    - Programa para adivinar un numero entero aleatorio en el rango entre 1 y 100. 
    - Se utiliza control de excepciones para evitar ingresar un dato no numérico.
    - Se coloca un condicional para validar que el número se encuentre en el rango.
    */

Console.WriteLine("Programa para adivinar un número aleatorio entre 1 y 50");

Random aleatorio = new Random();
int numeroBuscado = aleatorio.Next(1, 51);
//Console.WriteLine("\nEl número que buscamos es {0}", numeroBuscado);

int contadorIntentos = 0;
int numeroIngresado = 0;
bool estaOK = false;

while (numeroBuscado != numeroIngresado)
{
    estaOK = false;

    while (estaOK == false)
    {
        try
        {
            Console.WriteLine("\nAdivina el numero!");
            numeroIngresado = int.Parse(Console.ReadLine());

            estaOK = true;

            if (numeroIngresado >= 1 && numeroIngresado <= 100)
            {
                contadorIntentos++;

                //Aqui identificamos si estamos por encima, por debajo o igual
                if (numeroIngresado > numeroBuscado)
                    Console.WriteLine("El número buscado es menor!");

                if (numeroIngresado < numeroBuscado)
                    Console.WriteLine("El número buscado es mayor!");

                if (numeroIngresado == numeroBuscado)
                    Console.WriteLine("\nEncontraste el número!");
            }
            else
            {
                Console.WriteLine("El número ingresado está fuera del rango. Intenta otra vez!");
            }
        }
        catch (FormatException elError)
        {
            Console.WriteLine("No ingresaste un número. Intenta nuevamente!");
            Console.WriteLine(elError.Message + "\n");
        }
    }
}
