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
public class uno {
    public static void main(String[] args) {
        // Operador aritmetico
        int a = 10;
        int b = 5;
        System.out.println("Operador aritmetico");
        System.out.println("Suma: " + (a + b));
        System.out.println("Resta: " + (a - b));
        System.out.println("Multiplicacion: " + (a * b));
        System.out.println("Division: "+ (a/b));
        System.out.println("Modulo: "+ (a % b));

        // Operador logico
        boolean c = true;
        boolean d = false;
        System.out.println("Operador logico");
        System.out.println("AND: " + (c && d));
        System.out.println("OR: " + (c || d));
        System.out.println("NOT: " + (!c));

        // Operador de comparacion y de igualdad

        System.out.println("Operador de comparacion");
        System.out.println("Igualdad: " + (a == b));
        System.out.println("Desigualdad: " + (a != b));
        System.out.println("Mayor que: " + (a > b));
        System.out.println("Menor que: " + (a < b));
        System.out.println("Mayor igual que: " + (a >= b));
        System.out.println("Menor igual que: " + (a <= b));  
        
        // Operador de asignacion

        int x = 10; // Asigna el valor 10 a la variable x.
        String mensaje = "Hola"; // Asigna la cadena "Hola" a la variable mensaje.
        x += 5; // Incrementa el valor de x en 5 unidades (x ahora es 15).

        // Operador ternario
        c = (a > b) ? true : false;
        System.out.println("El resultado obtenido es: "+ c);

        // Operador de bits

        System.out.println("Operador de bits");
        System.out.println("AND: " + (a & b));
        System.out.println("OR: " + (a | b));
        System.out.println("XOR: " + (a ^ b));

        // Operador de desplazamiento

        System.out.println("Operador de desplazamiento");
        System.out.println("Desplazamiento a la izquierda: " + (a << 1));
        System.out.println("Desplazamiento a la derecha: " + (a >> 1));

        // Operador condicional 

        System.out.println("Operador condicional");
        System.out.println("Condicion: " + ((a > b) ? "a es mayor que b" : "a es menor que b"));
        System.out.println("Caso dos de los condiciones ");
        if (a > b) {
            System.out.println("a es mayor que b");
        } else {
            System.out.println("a es menor que b");
        }

        // Operadores de iteradores

        System.out.println("Operadores de iteradores");
        
        System.out.println("Operador For: ");
        
        for (int i = 0; i < 4; i++) {
            System.out.println("Iterador: " + i);
        }
        
        System.out.println("Operador While: ");
        
        int iterador = 0;
        while (iterador < 4) {
            System.out.println("Iterador: " + iterador);
            iterador++;
        }

        System.out.println("Operador Do While: ");

        iterador = 0;
        do {
            System.out.println("Iterador: " + iterador);
            iterador++;
        } while (iterador < 4);

        // Operadores de excepciones

        System.out.println("Operadores de excepciones");

        try {
            int division = a / 0;
        } catch (ArithmeticException e) {
            System.out.println("Error: " + e.getMessage());
        }

        // Dificultad extra
        a = 10;
        while (a <= 55) {
            if (a % 2 == 0 && a != 16 && a % 3 != 0) {
                System.out.println("Numero: " + a);
            }
            a++;
        }
    }
}
