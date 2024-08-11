/*
* EJERCICIO:
* - Muestra ejemplos de asignación de variables "por valor" y "por referencia", según
*   su tipo de dato.
* - Muestra ejemplos de funciones con variables que se les pasan "por valor" y 
*   "por referencia", y cómo se comportan en cada caso en el momento de ser modificadas.
* (Entender estos conceptos es algo esencial en la gran mayoría de lenguajes)
*
* DIFICULTAD EXTRA (opcional):
* Crea dos programas que reciban dos parámetros (cada uno) definidos como variables anteriormente.
* - Cada programa recibe, en un caso, dos parámetros por valor, y en otro caso, por referencia.
*   Estos parámetros los intercambia entre ellos en su interior, los retorna, y su retorno
*   se asigna a dos variables diferentes a las originales. A continuación, imprime el valor de las
*   variables originales y las nuevas, comprobando que se ha invertido su valor en las segundas.
*   Comprueba también que se ha conservado el valor original en las primeras.
*/

using System;

namespace Program 
{
    class Referencia
    {
        static void Main(string[] args) 
        {
            // Ejemplo de asignación por valor
            int a = 5;
            int b = a;
            b = 10;
            Console.WriteLine("Asignación por valor:");
            Console.WriteLine($"a = {a}, b = {b}"); // a = 5, b = 10

            // Ejemplo de asignación por referencia
            int[] array1 = { 1, 2, 3 };
            int[] array2 = array1;
            array2[0] = 10;
            Console.WriteLine("Asignación por referencia:");
            Console.WriteLine($"array1[0] = {array1[0]}, array2[0] = {array2[0]}"); // array1[0] = 10, array2[0] = 10

            // Ejemplo de paso de parámetros por valor
            int x = 5;
            ModificarPorValor(x);
            Console.WriteLine("Paso de parámetros por valor:");
            Console.WriteLine($"x = {x}"); // x = 5

            // Ejemplo de paso de parámetros por referencia
            int y = 5;
            ModificarPorReferencia(ref y);
            Console.WriteLine("Paso de parámetros por referencia:");
            Console.WriteLine($"y = {y}"); // y = 10
            // Dificultad extra

            x = 18;
            y = 28;

            (a, b) = SwapPorValor(x,y);

            Console.WriteLine($"Valores antes del cambio: x:{x} y  y:{y}");
            Console.WriteLine($"Swap por valor: a:{a}, b:{b}");
            Console.WriteLine($"Valores despues del cambio por valor: x:{x} y  y:{y}");
            
            Console.WriteLine($"Valores antes del cambio por referencia: x:{x} y  y:{y}");
            var (c, d) = SwapPorReferencia(ref x,ref y);
            Console.WriteLine($"Swap por referencia: c:{c}, d:{d}");
            Console.WriteLine($"Valores despues del cambio por referencia: x:{x} y  y:{y}");
        }
        static (int, int) SwapPorValor(int num1, int num2) 
        {
            int swap = num1;
            num1 = num2;
            num2 = swap;

            return (num1, num2);
        }

        static (int, int) SwapPorReferencia(ref int num1, ref int num2) 
        {
            int swap = num1;
            num1 = num2;
            num2 = swap;

            return (num1, num2);
        }
        static void ModificarPorValor(int num)
        {
            num = 10;
        }
        
        static void ModificarPorReferencia(ref int num)
        {
            num = 10;
        }

        static void ActualizarIn(in int num)
        {
            //num += 5; //Da Error 
            Console.WriteLine($"el valor es: {num}");
        }

        // Cuando pasamos un Objeto/Tipo creado por nosotros mismos, 
        // este siempre se pasa por referencia. Con lo que, si lo actualizamos dentro de la función, 
        //se actualizara fuera de ella.
    }
}