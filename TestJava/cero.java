/*  EJERCICIO:
 - Crea un comentario en el código y coloca la URL del sitio web oficial del
   lenguaje de programación que has seleccionado.
 - Representa las diferentes sintaxis que existen de crear comentarios
   en el lenguaje (en una línea, varias...).
 - Crea una variable (y una constante si el lenguaje lo soporta).
 - Crea variables representando todos los tipos de datos primitivos
   del lenguaje (cadenas de texto, enteros, booleanos...).
 - Imprime por terminal el texto: "¡Hola, [y el nombre de tu lenguaje]!"
*/
 
// Pagina oficial de documentacion de Java:  https://docs.oracle.com/javase/tutorial/tutorialLearningPaths.html

// Esto es un comentario de una sola linea

/*
    Esto es un comentario
    de varias lineas
*/

class cero {
    public static void main(String[] args) {
        // Tipos de datos primitivos
        
        String cadena = "Hola";             // Cadena de texto
        int entero = 1;                     // Entero de 32 bits
        boolean booleano = true;            // Booleano de 1 bit
        char caracter = 'a';                // Caracter de 16 bits
        byte byte1 = 1;                     // Entero de 8 bits
        short short1 = 1;                   // Entero de 16 bits
        long long1 = 1;                     // Entero de 64 bits
        float float1 = 1.0f;                // Decimal de 32 bits
        double double1 = 1.0;               // Decimal de 64 bits

        // Formas de escribir numeros enteros
        int decimalValue = 26;              // Valor decimal
        int hexadecimalValue = 0x1a;        // Valor hexadecimal
        int binaryValue = 0b11010;          // Valor binario

        // Creacion de variables y constantes
        final int CONSTANTE = 1;            // Constante
        final String CONSTANTE_CADENA = "Hola"; // Constante de cadena de texto

        System.out.println("Hola Mundo");
    }
}
