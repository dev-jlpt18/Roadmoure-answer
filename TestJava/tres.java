/*
* EJERCICIO:
* - Muestra ejemplos de creación de todas las estructuras soportadas por defecto en tu lenguaje.
* - Utiliza operaciones de inserción, borrado, actualización y ordenación.
*
* DIFICULTAD EXTRA (opcional):
* Crea una agenda de contactos por terminal.
* - Debes implementar funcionalidades de búsqueda, inserción, actualización y eliminación de contactos.
* - Cada contacto debe tener un nombre y un número de teléfono.
* - El programa solicita en primer lugar cuál es la operación que se quiere realizar, y a continuación
*   los datos necesarios para llevarla a cabo.
* - El programa no puede dejar introducir números de teléfono no númericos y con más de 11 dígitos.
*   (o el número de dígitos que quieras)
* - También se debe proponer una operación de finalización del programa.
*/
import java.util.Collections;
import java.util.Set;
import java.util.HashSet;
import java.util.Deque;
import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.Dictionary;
import java.util.Enumeration;
import java.util.Hashtable;
import java.util.Queue;
import java.util.Scanner;

class tres {

    static void buscar(Dictionary<String, Integer> agenda, Scanner scanner) {
        System.out.println("Introduzca el nombre del contacto a buscar: ");
        String nombre = scanner.nextLine();

        if (agenda.get(nombre) != null) {
            System.out.println("El contacto " + nombre + " tiene el número " + agenda.get(nombre));
        } else {
            System.out.println("El contacto " + nombre + " no existe");
        }

        System.out.println("-------------");
    }

    static void insertar(Dictionary<String, Integer> agenda,  Scanner scanner) {
        System.out.println("Ingrese el nombre del contacto: ");
        String nombre = scanner.nextLine();

        System.out.println("Ingrese el número de teléfono: ");
        try {
            String number = scanner.nextLine();
            if (number.length() > 11) {
                System.out.println("El número de teléfono no puede tener más de 11 dígitos");
            } else {
                int telefono = Integer.parseInt(number);
                agenda.put(nombre, telefono);
            }
        } catch (NumberFormatException e) {
            System.out.println("El número de teléfono no es valido");
        }
        System.out.println("-------------");
    }

    static void actualizar(Dictionary<String, Integer> agenda, Scanner scanner) {
        System.out.println("Ingrese el contacto a actualizar: ");
        String nombre = scanner.nextLine();

        try {
            if (agenda.get(nombre) != null) {
                System.out.println("Ingrese el nuevo número de teléfono: ");
                String number = scanner.nextLine();
                if (number.length() > 11) {
                    System.out.println("El número de teléfono no puede tener más de 11 dígitos");
                } else {
                    int telefono = Integer.parseInt(number);
                    agenda.put(nombre, telefono);
                }
            } else {
                System.out.println("El contacto " + nombre + " no existe");
            }
        } catch (NumberFormatException e) {
            System.out.println("El numero ingresado no es valido ");            
        } 
        System.out.println("-------------");
    }

    static void eliminar(Dictionary<String, Integer> agenda, Scanner scanner) {
        System.out.println("Ingrese el contacto a eliminar: ");
        String nombre = scanner.nextLine();

        if (agenda.get(nombre) != null) {
            agenda.remove(nombre);
            System.out.println("El contacto " + nombre + " ha sido eliminado");
        } else {
            System.out.println("El contacto " + nombre + " no existe");
        }
        System.out.println("-------------");
    }
    
    static void mostrar(Dictionary<String, Integer> agenda) {
        System.out.println("Mostrando contactos: ");
        for (Enumeration<String> k = agenda.keys(); k.hasMoreElements();) {
            String key = k.nextElement();
            System.out.println("Nombre: " + key + " - Teléfono: " + agenda.get(key));
        }
        System.out.println("-------------");
    }

    static void agenda() {
        // Crear una agenda
        String entrada = "";
        int i = 0;
        Scanner sc = new Scanner(System.in);
        System.out.println("Agenda de contactos: ");
        Dictionary<String, Integer> agenda = new Hashtable<>(); 
        do {
            try {
                System.out.println("1. Buscar contacto");
                System.out.println("2. Insertar contacto");
                System.out.println("3. Actualizar contacto");
                System.out.println("4. Eliminar contacto");
                System.out.println("5. Mostrar contactos");
                System.out.println("6. Salir");

                System.out.println("Introduzca una opción: ");
                entrada = sc.nextLine();
                i = Integer.parseInt(entrada);
                switch(i) {
                    case 1:
                        buscar(agenda, sc);
                        break;
                    case 2:
                        insertar(agenda, sc);
                        break;
                    case 3:
                        actualizar(agenda, sc);
                        break;
                    case 4:
                        eliminar(agenda, sc);
                    break;
                    case 5:
                        mostrar(agenda);
                        break;
                    case 6:
                        System.out.println("Salir");
                        break;
                    default:
                        System.out.println("Error: Opción no válida");
                        break;
                }
            } catch (NumberFormatException e) {
                System.out.println("Error: No es un entero");
            }
            
        } while(i != 6);
        sc.close();
    }
    public static void main(String[] args) {
        // Las principales estructuras en la programacion son:
        // - Arreglos
        // - Listas
        // - Diccionarios
        // - Colas
        // - Pilas
        // - Conjuntos
        // - Matrices
        
        // Arreglos:
        int[] arreglo = {1, 2, 3, 4, 5};
        System.out.println("Arreglo: ");
        for (int i = 0; i < arreglo.length; i++) {
            System.out.println(arreglo[i]);
        }
        System.out.println("-------------");

        // Listas:
        // Listas en Java son implementadas por la clase ArrayList
        // Se pueden agregar, eliminar y actualizar elementos
        // Se pueden ordenar
        // Se pueden recorrer
        // Se pueden buscar elementos
        // Se pueden obtener elementos por índice
        // Se pueden obtener el tamaño de la lista

        // Crear una lista e insertar elemento
        ArrayList<String> lista = new ArrayList<String>();
        lista.add("Elemento 1");
        lista.add("Elemento 3");
        lista.add("Elemento 2");
        lista.add("Elemento 4");
        // Eliminar un elemento
        lista.remove("Elemento 2");

        // Actualizar un elemento
        lista.set(1, "Elemento 5");

        // Recorrer la lista
        System.out.println("Lista: ");
        for (String elemento : lista) {
            System.out.println(elemento);
        }
        System.out.println("-------------");
        
        // Ordenar la lista
        Collections.sort(lista);
        System.out.println("Lista ordenada: ");
        for (String elemento : lista) {
            System.out.println(elemento);
        }

        System.out.println("-------------");

        // Diccionarios:
        // Diccionarios en Java son implementados por la clase Hashtable
        // Se pueden agregar, eliminar y actualizar elementos

        // Crear un diccionario e insertar elementos
        Dictionary<String, Integer> diccionario = new Hashtable<>();
        diccionario.put("Elemento 1", 1);
        diccionario.put("Elemento 2", 2);
        diccionario.put("Elemento 3", 3);
        diccionario.put("Elemento 4", 4);

        // Eliminar un elemento
        diccionario.remove("Elemento 2");

        // Actualizar un elemento
        diccionario.put("Elemento 3", 5);

        // Recorrer el diccionario
        System.out.println("Diccionario: ");
        for (Enumeration<String> k = diccionario.keys(); k.hasMoreElements();) {
            String key = k.nextElement();
            System.out.println("Key: " + key + " - Value: " + diccionario.get(key));
        }


        // Buscar un elemento 
        if (diccionario.get("Elemento 1") != null) {
            System.out.println("El elemento 1 tiene el valor " + diccionario.get("Elemento 1"));
        } else {
            System.out.println("El elemento 1 no existe");
        }   

        System.out.println("-------------");

        // Colas
        // Colas en Java son implementadas por la clase LinkedList
        // Se pueden agregar y eliminar elementos
        // Se pueden recorrer

        // Crear una cola e insertar elementos
        Queue<String> cola = new LinkedList<>();
        cola.add("Elemento 1");
        cola.add("Elemento 2");
        cola.add("Elemento 3");
        cola.add("Elemento 4");

        // Eliminar un elemento
        cola.remove();

        // Recorrer la cola
        System.out.println("Cola: ");
        for (String elemento : cola) {
            System.out.println(elemento);
        }
        System.out.println("-------------");
        // Pila
        // Pilas en Java son implementadas por la clase Stack
        // Se pueden agregar y eliminar elementos
        // Se pueden recorrer

        // Crear una pila e insertar elementos
        Deque<String> pila = new ArrayDeque<>();
        pila.push("Elemento 1");
        pila.push("Elemento 2");
        pila.push("Elemento 3");
        pila.push("Elemento 4");

        // Eliminar un elemento
        pila.pop();

        // Recorrer la pila
        System.out.println("Pila: ");
        for (String elemento : pila) {
            System.out.println(elemento);
        }

        System.out.println("-------------");

        // Conjuntos
        // Conjuntos en Java son implementados por la clase HashSet
        // Se pueden agregar y eliminar elementos

        // Crear un conjunto e insertar elementos
        
        Set<String> conjunto = new HashSet<>();
        System.out.println("Conjunto:");
        conjunto.add("Elemento 10");
        conjunto.add("Elemento 12");
        conjunto.add("Elemento 11");
        conjunto.add("Elemento 12");
        conjunto.add("Elemento 13");

        // Eliminar
        conjunto.remove("Elemento 10");

        for (String elemento : conjunto) {
            System.out.println(elemento);
        }

        // Dificultad extra
        agenda();
    }
}