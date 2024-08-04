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
class dos {
    static void funcionSinParametros() {
        System.out.println("Función sin parámetros");
    }

    static void funcionConParametros(int a, int b) {
        System.out.println("Función con parámetros: " + a + " y " + b);
    }

    static int funcionConRetorno(int a, int b) {
        return a + b;
    }

    static String funcionConOtroTipoDeRetorno(String a) {
        String c = "Hola "+ a;
        return c;
    }
    // Dificultad extra

    static int cantidadDeImpresiones(String a, String b) {
        int contador = 0;
        for (int i = 1; i <= 100; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                System.out.println(a + b);
            } else if (i % 3 == 0) {
                System.out.println(a);
            } else if (i % 5 == 0) {
                System.out.println(b);
            } else {
                System.out.println(i);
                contador++;
            }
        }
        return contador;
    }
    public static void main(String[] args) {
        funcionSinParametros();
        funcionConParametros(1, 2);
        System.out.println("Función con retorno: " + funcionConRetorno(1, 2));
        System.out.println(funcionConOtroTipoDeRetorno("Mundo"));
        System.out.println("Cantidad de impresiones: " + cantidadDeImpresiones("Pescado ", "Frito"));
    }
}