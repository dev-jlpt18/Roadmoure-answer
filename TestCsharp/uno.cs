/*
 EJERCICIO:
 - Crea ejemplos utilizando todos los tipos de operadores de tu lenguaje:
   Aritméticos, lógicos, de comparación, asignación, identidad, pertenencia, bits...
   (Ten en cuenta que cada lenguaje puede poseer unos diferentes)
 - Utilizando las operaciones con operadores que tú quieras, crea ejemplos
   que representen todos los tipos de estructuras de control que existan
   en tu lenguaje:
   Condicionales, iterativas, excepciones...
 - Debes hacer print por consola del resultado de todos los ejemplos.

 DIFICULTAD EXTRA (opcional):
 Crea un programa que imprima por consola todos los números comprendidos
 entre 10 y 55 (incluidos), pares, y que no son ni el 16 ni múltiplos de 3.

 Seguro que al revisar detenidamente las posibilidades has descubierto algo nuevo.
*/
using System;

namespace Program 
{
    class Operadores
    {
        static void Main(string[] args) 
        {
            // Ejemplos de operadores aritméticos
            int suma = 5 + 3;
            int resta = 5 - 3;
            int multiplicacion = 5 * 3;
            int division = 5 / 3;
            int modulo = 5 % 3;

            Console.WriteLine("Operadores aritméticos:");
            Console.WriteLine($"Suma: 5 + 3 = {suma}");
            Console.WriteLine($"Resta: 5 - 3 = {resta}");
            Console.WriteLine($"Multiplicación: 5 * 3 = {multiplicacion}");
            Console.WriteLine($"División: 5 / 3 = {division}");
            Console.WriteLine($"Módulo: 5 % 3 = {modulo}");

            // Ejemplos de operadores lógicos
            bool and = true && false;
            bool or = true || false;
            bool not = !true;

            Console.WriteLine("Operadores lógicos:");
            Console.WriteLine($"AND: true && false = {and}");
            Console.WriteLine($"OR: true || false = {or}");
            Console.WriteLine($"NOT: !true = {not}");

            // Ejemplos de operadores de comparación
            bool igual = 5 == 3;
            bool diferente = 5 != 3;
            bool mayor = 5 > 3;
            bool menor = 5 < 3;
            bool mayorIgual = 5 >= 3;
            bool menorIgual = 5 <= 3;

            Console.WriteLine("Operadores de comparación:");
            Console.WriteLine($"Igual: 5 == 3 = {igual}");
            Console.WriteLine($"Diferente: 5 != 3 = {diferente}");
            Console.WriteLine($"Mayor: 5 > 3 = {mayor}");
            Console.WriteLine($"Menor: 5 < 3 = {menor}");
            Console.WriteLine($"Mayor o igual: 5 >= 3 = {mayorIgual}");
            Console.WriteLine($"Menor o igual: 5 <= 3 = {menorIgual}");

            // Ejemplos de operadores de asignación
            int asignacion = 5;
            asignacion += 3;
            asignacion -= 2;
            asignacion *= 2;
            asignacion /= 3;
            asignacion %= 2;

            Console.WriteLine("Operadores de asignación:");
            Console.WriteLine($"Asignación: 5 += 3 -= 2 *= 2 /= 3 %= 2 = {asignacion}");

            // Ejemplos de operadores de bits
            int a = 5; // 101
            int b = 3; // 011

            int noBit = ~a; // 11111111111111111111111111111010
            int andBit = a & b; // 001
            int orBit = a | b; // 111
            int xorBit = a ^ b; // 110
            int desplazamientoIzquierda = a << 1; // 1010
            int desplazamientoDerecha = a >> 1; // 10

            Console.WriteLine("Operadores de bits:");
            Console.WriteLine($"NOT: ~5 = {noBit}");
            Console.WriteLine($"AND: 5 & 3 = {andBit}");
            Console.WriteLine($"OR: 5 | 3 = {orBit}");
            Console.WriteLine($"XOR: 5 ^ 3 = {xorBit}");
            Console.WriteLine($"Desplazamiento a la izquierda: 5 << 1 = {desplazamientoIzquierda}");
            Console.WriteLine($"Desplazamiento a la derecha: 5 >> 1 = {desplazamientoDerecha}");

            // Ejemplos de estructuras de control
            Console.WriteLine("Estructuras de control:");

            // Condicionales
            if (suma > resta)
            {
                Console.WriteLine("Suma es mayor que resta");
            }
            else
            {
                Console.WriteLine("Resta es mayor o igual que suma");
            }

            // Iterativas
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteración {i}");
            }
            int iterador = 0;

            while(true)
            {
                if (iterador < 5)
                {
                    Console.WriteLine("Aun no llega a 5 en while");
                    iterador++;
                }
                else 
                {
                    Console.WriteLine("Llegamos al 5 while");
                }
            }

            iterador = 0;
            do
            {
                if (iterador < 5)
                {
                    Console.WriteLine("Aun no llega a 5 en do while");
                    iterador++;
                }
                else 
                {
                    Console.WriteLine("Llegamos al 5 do while");
                }
            } while (true);

            // Excepciones
            try
            {
                int[] myNumbers = {1, 2, 3};
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo salio mal");
            }

            // Dificultad extra
            for (int i = 10; i <= 55; i++) 
            {
                if (i % 2 == 0 && i != 16 && i % 3 != 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
