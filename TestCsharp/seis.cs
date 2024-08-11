/*
* EJERCICIO:
* Entiende el concepto de recursividad creando una función recursiva que imprima
* números del 100 al 0.
*
* DIFICULTAD EXTRA (opcional):
* Utiliza el concepto de recursividad para:
* - Calcular el factorial de un número concreto (la función recibe ese número).
* - Calcular el valor de un elemento concreto (según su posición) en la 
*   sucesión de Fibonacci (la función recibe la posición).
*/

namespace Program 
{
    class Recursividad
    {
        static void ImprimirNumeros(int num)
        {
            if (num > 1)
            {
                Console.WriteLine("Numero: "+ num);
                ImprimirNumeros(num-1);
            } else 
            {
                Console.WriteLine("Numero:" + num);
            }
        }
        static int Factorial(int num)
        {
            if (num > 1)
            {
                return num*Factorial(num-1);

            } else if (num == 1 || num == 0)
            {
                return 1;
            } else 
            {
                Console.WriteLine("Debe ser un numero entero positivo");
                return 0;
            }
        }

        static int Fibonacci(int num)
        {
           if (num == 1) 
           {
                return 0;
           } else if (num == 2)
           {
            return 1;
           } else
           {
            return Fibonacci(num-1)+ Fibonacci(num-2);
           }
        }
        static void Main(string[] args)
        {
            ImprimirNumeros(100);
            Console.WriteLine("Dame un numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Este es el factorial de {num}: {Factorial(num)}");

            Console.WriteLine("Dame un numero:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Este es el fibonacci en la posicion {num}: {Fibonacci(num)}");
        }

    }
}