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

import java.util.Arrays;

class cuatro {
    static boolean Palindromo(String palabra, String palabra2) {
        palabra = palabra.toLowerCase().replace(" ", "");
        palabra2 = palabra2.toLowerCase().replace(" ", "");

        int index = 0;
        int index_invertido = palabra2.length() - 1;

        if (palabra.length() != palabra2.length()) {
            return false;
        }

        while (index < palabra.length()) {
            if (palabra.charAt(index) != palabra2.charAt(index_invertido)) {
                return false;
            }
            index++;
            index_invertido--;
        }

        return true;
    }

    static boolean Anagramas(String palabra, String palabra2) {

        char[] arreglo = palabra.replace(" ", "").toCharArray();
        char[] arreglo2 = palabra2.replace(" ", "").toCharArray();        

        Arrays.sort(arreglo);
        Arrays.sort(arreglo2);

        for (int i = 0; i < arreglo.length; i++) {
            if (arreglo[i] != arreglo2[i]) {
                return false;
            }
        }

        return true;
    }

    static boolean Isogramas(String palabra, String palabra2) {
        
        char[] arreglo = palabra.replace(" ", "").toCharArray();
        char[] arreglo2 = palabra2.replace(" ", "").toCharArray();        
        int contador;
        
        for (int i = 0; i < arreglo.length; i++) {
            contador = 0;
            for (int j = 0; j < arreglo2.length; j++) {
                if (arreglo[i] == arreglo2[j]) {
                    contador++;
                } 
            }

            if(contador > 1) {
                return false;
            }
        }

        return true;
    }
    public static void main(String[] args) {
        String cadena = "Hola Mundo";
        
        // Acceso a caracteres específicos
        char primerCaracter = cadena.charAt(0); // 'H'
        System.out.println("Primer carácter: " + primerCaracter);

        // Subcadenas
        String subcadena = cadena.substring(0, 4); // "Hola"
        System.out.println("Subcadena: " + subcadena);

        // Longitud
        int longitud = cadena.length(); // 10
        System.out.println("Longitud: " + longitud);

        // Concatenación
        String concatenada = cadena + " desde Java"; // "Hola Mundo desde Java"
        System.out.println("Concatenada: " + concatenada);

        // Repetición
        String repetida = "A".repeat(5); // "AAAAA"
        System.out.println("Repetida: " + repetida);

        // Recorrido
        System.out.println("Recorrido:");
        for (char c : cadena.toCharArray()) {
            System.out.println(c);
        }

        // Conversión a mayúsculas y minúsculas
        String mayusculas = cadena.toUpperCase(); // "HOLA MUNDO"
        String minusculas = cadena.toLowerCase(); // "hola mundo"
        System.out.println("Mayúsculas: " + mayusculas);
        System.out.println("Minúsculas: " + minusculas);

        // Reemplazo
        String reemplazada = cadena.replace("Mundo", "Java"); // "Hola Java"
        System.out.println("Reemplazada: " + reemplazada);

        // División
        String[] palabras = cadena.split(" "); // ["Hola", "Mundo"]
        System.out.println("División:");
        for (String palabra : palabras) {
            System.out.println(palabra);
        }

        // Unión
        String unida = String.join(", ", palabras); // "Hola, Mundo"
        System.out.println("Unida: " + unida);

        // Interpolación
        String nombre = "Juan";
        int edad = 30;
        String interpolada = String.format("Nombre: %s, Edad: %d", nombre, edad); // "Nombre: Juan, Edad: 30"
        System.out.println("Interpolada: " + interpolada);

        // Verificación de contenido
        boolean contiene = cadena.contains("Mundo"); // true
        boolean empiezaCon = cadena.startsWith("Hola"); // true
        boolean terminaCon = cadena.endsWith("Java"); // false
        System.out.println("Contiene 'Mundo': " + contiene);
        System.out.println("Empieza con 'Hola': " + empiezaCon);
        System.out.println("Termina con 'Java': " + terminaCon);

        // Eliminar espacios en blanco
        String conEspacios = "  Hola Mundo  ";
        String sinEspacios = conEspacios.trim(); // "Hola Mundo"
        System.out.println("Sin espacios: " + sinEspacios);

        // Comparación
        boolean iguales = cadena.equals("Hola Mundo"); // true
        int comparacion = cadena.compareTo("Hola Mundo"); // 0 (igual)
        System.out.println("Iguales: " + iguales);
        System.out.println("Comparación: " + comparacion);

        // Conversión a array de caracteres
        char[] caracteres = cadena.toCharArray(); // ['H', 'o', 'l', 'a', ' ', 'M', 'u', 'n', 'd', 'o']
        System.out.println("Array de caracteres:");
        for (char c : caracteres) {
            System.out.println(c);
        }

        // Formateo
        String formateada = String.format("Nombre: %s, Edad: %d", nombre, edad); // "Nombre: Juan, Edad: 30"
        System.out.println("Formateada: " + formateada);

        // Insertar
        StringBuilder sb = new StringBuilder(cadena);
        sb.insert(5, "Java "); // "Hola Java Mundo"
        String insertada = sb.toString();
        System.out.println("Insertada: " + insertada);

        // Eliminar
        String eliminada = cadena.substring(0, 5) + cadena.substring(11); // "Hola"
        System.out.println("Eliminada: " + eliminada);

        // Comparación sin sensibilidad a mayúsculas
        boolean igualesSinMayusculas = cadena.equalsIgnoreCase("hola mundo"); // true
        System.out.println("Iguales sin mayúsculas: " + igualesSinMayusculas);

        // Reversión
        String invertida = new StringBuilder(cadena).reverse().toString(); // "odnuM aloH"
        System.out.println("Invertida: " + invertida);

        // Dificultad extra
        String palabra = "Anita lava la tina";
        String palabra2 = "Anita lava la tina";
        System.out.println(Palindromo(palabra, palabra2));

        palabra = "roma";
        palabra2 = "amor";
        System.out.println(Anagramas(palabra, palabra2));

        palabra = "roma";
        palabra2 = "amor";
        System.out.println(Isogramas(palabra, palabra2));
    }
}