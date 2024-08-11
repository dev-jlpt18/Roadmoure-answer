/*
* EJERCICIO:
* Entiende el concepto de recursividad creando una función recursiva que imprima
* números del 100 al 0.
*
* DIFICULTAD EXTRA (opcional):
* Utiliza el concepto de recursividad para:
* - Calcular el factorial de un número concreto (la función recibe ese número).
* - Calcular el valor de un elemento concreto (según su posición) en la 
*   sucesión de Fibonacci (la función recibe la posición).
*/

import java.util.Scanner;

public class seis {
    static void ImprimirNumeros(int num) {
        if (num > 1) {
            System.out.println("Numero: "+ num);
            ImprimirNumeros(num-1);
        } else {
            System.out.println("Numero: "+ num);
        }
    }

    static int Factorial(int num) {
        if (num == 1 || num == 0) {
            return 1;
        } else {
            return Factorial(num-1)*num;
        }
    }

    static int Fibonacci(int num) {
        if (num == 1) {
            return 0;
        } else if (num == 2) {
            return 1;
        } else {
            return Fibonacci(num-1) + Fibonacci(num-2);
        }  
    }
    public static void main(String[] args) {
        int num;
        Scanner sc = new Scanner(System.in);
        System.out.println("Ingrese un numero: ");
        num = Integer.parseInt(sc.nextLine());
        System.out.println("El factorial de "+num + " es:"+ Factorial(num));
        System.out.println("Ingrese un numero: ");
        num = Integer.parseInt(sc.nextLine());
        System.out.println("El fibonacci de la posicion "+num + " es: "+ Fibonacci(num));
        sc.close();
    }
}
