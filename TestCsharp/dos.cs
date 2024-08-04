/*
* EJERCICIO:
* - Crea ejemplos de funciones básicas que representen las diferentes
*   posibilidades del lenguaje:
*   Sin parámetros ni retorno, con uno o varios parámetros, con retorno...
* - Comprueba si puedes crear funciones dentro de funciones.
* - Utiliza algún ejemplo de funciones ya creadas en el lenguaje.
* - Pon a prueba el concepto de variable LOCAL y GLOBAL.
* - Debes hacer print por consola del resultado de todos los ejemplos.
*   (y tener en cuenta que cada lenguaje puede poseer más o menos posibilidades)
*
* DIFICULTAD EXTRA (opcional):
* Crea una función que reciba dos parámetros de tipo cadena de texto y retorne un número.
* - La función imprime todos los números del 1 al 100. Teniendo en cuenta que:
*   - Si el número es múltiplo de 3, muestra la cadena de texto del primer parámetro.
*   - Si el número es múltiplo de 5, muestra la cadena de texto del segundo parámetro.
*   - Si el número es múltiplo de 3 y de 5, muestra las dos cadenas de texto concatenadas.
*   - La función retorna el número de veces que se ha impreso el número en lugar de los textos.
*
* Presta especial atención a la sintaxis que debes utilizar en cada uno de los casos.
* Cada lenguaje sigue una convenciones que debes de respetar para que el código se entienda.
*/

using System;

namespace Program
{
    class Funciones 
    {
        static void FuncionSinParametrosNiRetorno()
        {
            Console.WriteLine("Funcion sin parametros ni retorno");
        }

        static void FuncionConParametros(int a, int b)
        {
            Console.WriteLine("Funcion con parametros: " + a + " " + b);
        }

        static int FuncionConRetorno(int a, int b)
        {
            return a + b;
        }
        
        // Dificultad extra
        static int cantidadDeImpresiones (string a, string b) 
        {
            int contador = 0;
            int iterador = 1;
            while (iterador <= 100)
            {
                if (iterador % 3 == 0 && iterador % 5 == 0)
                {
                    Console.WriteLine(a + b);
                } else if (iterador % 3 == 0)
                {
                    Console.WriteLine(a);
                } else if (iterador % 5 == 0)
                {
                    Console.WriteLine(b);
                } else
                {
                    Console.WriteLine(iterador);
                    contador++;
                }
                iterador++;
            }
            return contador;
        }
        static void Main(string[] args)
        {
            FuncionSinParametrosNiRetorno();
            FuncionConParametros(1, 2);
            Console.WriteLine("Funcion con retorno: " + FuncionConRetorno(1, 2));
            Console.WriteLine("Cantidad de impresiones: " + cantidadDeImpresiones("First", "Second"));
        }
    }
}