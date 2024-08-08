/*
* EJERCICIO:
* Muestra ejemplos de todas las operaciones que puedes realizar con cadenas de caracteres
* en tu lenguaje. Algunas de esas operaciones podrían ser (busca todas las que puedas):
* - Acceso a caracteres específicos, subcadenas, longitud, concatenación, repetición, recorrido,
*   conversión a mayúsculas y minúsculas, reemplazo, división, unión, interpolación, verificación...
*
* DIFICULTAD EXTRA (opcional):
* Crea un programa que analice dos palabras diferentes y realice comprobaciones
* para descubrir si son:
* - Palíndromos
* - Anagramas
* - Isogramas
*/

namespace Program
{
    class Cadenas {

        static bool Palindromo(string cadena , string cadena2) 
        {
            cadena = cadena.ToLower();
            cadena2 = cadena2.ToLower();

            cadena = cadena.Replace(" ", "");
            cadena2 = cadena2.Replace(" ", "");

            char[] array = cadena.ToCharArray();
            Array.Reverse(array);
            string invertida = new string(array);
            
            return cadena.Equals(invertida);
        }

        static bool Anagrama(string cadena , string cadena2) 
        {
            char[] array = cadena.ToCharArray();
            Array.Sort(array);
            char[] array2 = cadena2.ToCharArray();
            Array.Sort(array2);
            string ordenada = new string(array);
            string ordenada2 = new string(array2);
            return ordenada.Equals(ordenada2);

        }

        static bool Isograma(string cadena , string cadena2) 
        {
            cadena = cadena.ToLower();
            cadena2 = cadena2.ToLower();
            for (int i = 0; i < cadena.Length; i++)
            {
                int conteo = 0;
                for (int j = 0; j < cadena2.Length; j++)
                {
                    if (cadena[i] == cadena2[j])
                    {
                        conteo++;
                    }
                }

                if (conteo > 1)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            // Acceso a caracteres específicos, subcadenas, longitud, concatenación, repetición, recorrido,
            // conversión a mayúsculas y minúsculas, reemplazo, división, unión, interpolación, verificación.
            
            // Acceso a caracteres específicos
            Console.WriteLine("Acceso a caracteres específicos:");
            string cadena = "Hola Mundo";
            char primerCaracter = cadena[0]; // 'H'
            Console.WriteLine(cadena);
            Console.WriteLine("*************************");
            
            // Subcadenas
            Console.WriteLine("Subcadenas:");
            string subcadena = cadena.Substring(0, 4); // "Hola"
            Console.WriteLine(subcadena);
            Console.WriteLine("*************************");
            
            // Longitud
            Console.WriteLine("Longitud:");
            int longitud = cadena.Length; // 10
            Console.WriteLine(longitud);
            Console.WriteLine("*************************");
            
            // Concatenación
            Console.WriteLine("Concatenación:");
            string cadenaConcatenada = cadena + " desde C#"; // "Hola Mundo desde C#"
            Console.WriteLine(cadenaConcatenada);
            Console.WriteLine("*************************");
            
            // Repetición
            Console.WriteLine("Repetición:");
            string cadenaRepetida = new string('a', 3); // "aaa"
            Console.WriteLine(cadenaRepetida);
            Console.WriteLine("*************************");
            
            // Recorrido
            Console.WriteLine("Recorrido:");
            foreach (char caracter in cadena)
            {
                Console.WriteLine(caracter);
            }
            Console.WriteLine("*************************");
            
            // Conversión a mayúsculas y minúsculas
            Console.WriteLine("Conversión a mayúsculas y minúsculas:");
            string mayusculas = cadena.ToUpper(); // "HOLA MUNDO"
            string minusculas = cadena.ToLower(); // "hola mundo"
            Console.WriteLine(mayusculas);
            Console.WriteLine(minusculas);
            Console.WriteLine("*************************");
            
            // Reemplazo
            Console.WriteLine("Reemplazo:");
            string reemplazo = cadena.Replace("Hola", "Adiós"); // "Adiós Mundo"
            Console.WriteLine(reemplazo);
            Console.WriteLine("*************************");
            
            // División
            Console.WriteLine("División:");
            string[] division = cadena.Split(' '); // ["Hola", "Mundo"]
            Console.WriteLine(division);
            Console.WriteLine("*************************");
            
            // Unión
            Console.WriteLine("Unión:");
            string union = string.Join(" ", division); // "Hola Mundo"
            Console.WriteLine(union);
            Console.WriteLine("*************************");
            
            // Interpolación
            Console.WriteLine("Interpolación:");
            string interpolacion = $"La cadena es: {cadena}";
            Console.WriteLine(interpolacion);
            Console.WriteLine("*************************");

            // Verificación
            Console.WriteLine("Verificación:");
            bool contiene = cadena.Contains("Mundo"); // true
            bool empiezaCon = cadena.StartsWith("Hola"); // true
            bool terminaCon = cadena.EndsWith("C#"); // false
            Console.WriteLine(contiene);
            Console.WriteLine(empiezaCon);
            Console.WriteLine(terminaCon);
            Console.WriteLine("*************************");

            // Verificación de espacios
            Console.WriteLine("Verificación de espacios:");
            string conEspacios = "  Hola Mundo  .";
            string sinEspacios = conEspacios.Trim(); // "Hola Mundo"
            string izquierda = conEspacios.TrimStart(); // "Hola Mundo  "
            string derecha = conEspacios.TrimEnd(); // "  Hola Mundo"
            Console.WriteLine(conEspacios);
            Console.WriteLine(sinEspacios);
            Console.WriteLine(izquierda);
            Console.WriteLine(derecha);
            Console.WriteLine("*************************");

            // Búsqueda 
            Console.WriteLine("Búsqueda:");
            int indice = cadena.IndexOf("o"); // 5
            int ultimoIndice = cadena.LastIndexOf("o"); // 7
            Console.WriteLine(indice);
            Console.WriteLine(ultimoIndice);
            Console.WriteLine("*************************");

            // Comparación
            Console.WriteLine("Comparación:");
            bool iguales = cadena.Equals("Hola Mundo"); // true
            int comparacion = string.Compare(cadena, "Hola Mundo"); // 0 (igual)
            Console.WriteLine(iguales);
            Console.WriteLine(comparacion);
            Console.WriteLine("*************************");

            // Conversion a array de caracteres
            Console.WriteLine("Conversion a array de caracteres:");
            char[] caracteres = cadena.ToCharArray(); // ['H', 'o', 'l', 'a', ' ', 'M', 'u', 'n', 'd', 'o']
            Console.WriteLine(caracteres);
            Console.WriteLine("*************************");

            // Formateo
            Console.WriteLine("Formateo:");
            string nombre = "Juan";
            int edad = 30;
            string formateada = string.Format("Nombre: {0}, Edad: {1}", nombre, edad); // "Nombre: Juan, Edad: 30"
            Console.WriteLine(formateada);
            Console.WriteLine("*************************");

            // Insertar
            Console.WriteLine("Insertar:");
            string insertada = cadena.Insert(5, "C# "); // "Hola C# Mundo"
            Console.WriteLine(insertada);
            Console.WriteLine("*************************");

            // Eliminar
            Console.WriteLine("Eliminar:");
            string eliminada = cadena.Remove(5, 5); // "Hola"
            Console.WriteLine(eliminada);
            Console.WriteLine("*************************");

            //Comparación sin sensibilidad a mayúsculas:
            Console.WriteLine("Comparación sin sensibilidad a mayúsculas:");
            bool igualesSinMayusculas = cadena.Equals("hola mundo", StringComparison.OrdinalIgnoreCase); // true
            Console.WriteLine(igualesSinMayusculas);
            Console.WriteLine("*************************");
            // Reversion
            
            Console.WriteLine("Reversion:");
            char[] array = cadena.ToCharArray();
            Array.Reverse(array);
            string invertida = new string(array); // "odnuM aloH"
            Console.WriteLine(invertida);
            Console.WriteLine("*************************");

            // Palíndromo
            Console.WriteLine("Palíndromo:");
            cadena = "anita lava la tina";
            string cadena2 = "Anita lava la tina";
            bool palindromo = Palindromo(cadena , cadena2); // true
            Console.WriteLine(palindromo);
            Console.WriteLine("*************************");

            // Anagrama
            Console.WriteLine("Anagrama:");
            cadena = "amor";
            cadena2 = "roma";
            bool anagrama = Anagrama(cadena , cadena2); // true
            Console.WriteLine(anagrama);
            Console.WriteLine("*************************");

            // Isograma
            Console.WriteLine("Isograma:");
            cadena = "murcielago";
            cadena2 = "murcielago";
            bool isograma = Isograma(cadena , cadena2); // true
            Console.WriteLine(isograma);
        }
    }
}