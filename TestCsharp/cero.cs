
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
 
// Pagina oficial de documentacion de C#: https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/

// Esto es un comentario de una sola linea

/*
    Esto es un comentario
    de varias lineas
*/
using System;

namespace Program
{
  class Hello
  {
    static void Main(string[] args)
    {
      // Tipos de datos enteros y punto flotante

      sbyte enteroSbyte = 10;              // 8 bits
      byte enteroByte = 10;                // 8 bits
      short enteroShort = 10;              // 16 bits
      ushort enteroShortSinSigno = 10;     // 16 bits
      int entero = 10;                     // 32 bits
      uint enteroSinSigno = 10;            // 32 bits
      long enteroLargo = 10;               // 64 bits
      ulong enteroLargoSinSigno = 10;      // 64 bits
      nint enteroNint = 10;                // 32 o 64 bits
      nuint enteroNuint = 10;              // 32 o 64 bits


      float flotante = 10.5f;              // 32 bits
      double flotanteDoble = 10.5;         // 64 bits
      decimal flotanteDecimal = 10.5m;     // 128 bits

      /* 
          Para indicar el maxino y minimo valor de un tipo de dato se puede hacer de la siguiente manera:
          Console.WriteLine("El valor máximo de un entero es: " + tipo.MaxValue);
          Console.WriteLine("El valor mínimo de un entero es: " + tipo.MinValue);

          Y para realizar conversiones se debe:
          int entero = (long)10;
          long enteroLargo = (tipo)10;

      */

      // Tipos de literales enteros

      var decimalLiteral = 42;             // Entero
      var hexLiteral = 0x2A;               // Hexadecimal
      var binaryLiteral = 0b_0010_1010;    // Binario

      // Tipos de datos booleanos

      bool check = true;

      // Tipos de datos de texto
    
      char letra = 'A';                   // Caracter Unicode de 16 bits
      string texto = "Hola Mundo!";      // Cadena de texto
      const string textoConstante = "Hola C#!"; // Cadena de texto constante
      const int enteroConstante = 2024;     // Entero constante

      Console.WriteLine(texto); 
      Console.WriteLine(textoConstante);
      // Forma de usar el ?: 
      Console.WriteLine(check ? "Checked" : "Not checked");  // output: Checked
      Console.WriteLine(false ? "Checked" : "Not checked");  // output: Not checked
    }
  }
}