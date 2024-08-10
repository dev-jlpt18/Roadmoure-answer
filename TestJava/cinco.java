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

public class cinco {

    public static void main(String[] args) {
        // Ejemplo de asignación por valor
        int a = 5;
        int b = a;
        b = 10;
        System.out.println("Asignación por valor:");
        System.out.println("a = " + a + ", b = " + b); // a = 5, b = 10

        // Ejemplo de asignación por referencia
        int[] array1 = {1, 2, 3};
        int[] array2 = array1;
        array2[0] = 10;
        System.out.println("Asignación por referencia:");
        System.out.println("array1[0] = " + array1[0] + ", array2[0] = " + array2[0]); // array1[0] = 10, array2[0] = 10

        // Ejemplo de paso de parámetros por valor
        int x = 5;
        modificarPorValor(x);
        System.out.println("Paso de parámetros por valor:");
        System.out.println("x = " + x); // x = 5

        // Ejemplo de paso de parámetros por referencia
        int[] y = {5};
        modificarPorReferencia(y);
        System.out.println("Paso de parámetros por referencia:");
        System.out.println("y[0] = " + y[0]); // y[0] = 10

    }

    static void modificarPorValor(int num) {
        num = 10;
    }

    static void modificarPorReferencia(int[] num) {
        num[0] = 10;
    }
}