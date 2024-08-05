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

using System;

namespace Program
{
    class Estructuras  
    {
        // Funciones de la agenda
        static void insertar(Dictionary<string, int> diccionario)
        {
            Console.WriteLine("Ingrese el nombre del contacto: ");
            string key = Console.ReadLine();
            try
            {
                Console.WriteLine("Ingrese el numero telefonico del contacto: ");
                string value = Console.ReadLine();
                if (value.Length < 11)
                {
                    diccionario.Add(key, Convert.ToInt32(value));
                } else
                {
                    Console.WriteLine("El numero telefonico no puede tener mas de 11 digitos");
                }
            } catch (FormatException e)
            {
                Console.WriteLine("El numero telefonico debe ser un numero entero");
            } catch (ArgumentException e)
            {
                Console.WriteLine("El contacto ya existe");
            }
        }

        static void borrar(Dictionary<string, int> diccionario)
        {
            Console.WriteLine("Ingrese el nombre del contacto a eliminar: ");
            string key = Console.ReadLine();
            try
            {
                
                diccionario.Remove(key);
                Console.WriteLine("Contacto eliminado");
            } catch (Exception e)
            {
                Console.WriteLine("El contacto no existe");
            }
        }

        static void actualizar(Dictionary<string, int> diccionario)
        {
            Console.WriteLine("Ingrese el nombre del contacto a actualizar: ");
            string key = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo numero telefonico del contacto: ");
            string value = Console.ReadLine();
            try
            {
                if (value.Length > 11)
                {
                    Console.WriteLine("El numero telefonico no puede tener mas de 11 digitos");
                    return;
                } else
                {
                   diccionario[key] = Convert.ToInt32(value);
                   Console.WriteLine("Contacto actualizado"); 
                }
            } catch (FormatException e)
            {
                Console.WriteLine("El numero telefonico debe ser un numero entero");
            } catch (KeyNotFoundException e)
            {
                Console.WriteLine("El contacto no existe");
            }
        }

        static int buscar(Dictionary<string, int> diccionario)
        {
            Console.WriteLine("Ingrese el nombre del contacto a buscar: ");
            string key = Console.ReadLine();
            foreach (KeyValuePair<string, int> kvp in diccionario)
            {
                if (kvp.Key == key)
                {
                    Console.WriteLine("Nombre= {0}, Numero Telefonico = {1}", kvp.Key, kvp.Value);
                    return 0;
                }
            }
            Console.WriteLine("El contacto no existe");
            return 0;
        }

        static void mostrar(Dictionary<string, int> diccionario)
        {
            Console.WriteLine("Contactos:");
            foreach (KeyValuePair<string, int> kvp in diccionario)
            {
                Console.WriteLine("Nombre= {0}, Numero Telefonico = {1}", kvp.Key, kvp.Value);
            }
        }

        // Funcion para el ejemplo de lista
        static void print(List<int> lista)
        {
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            // Las principales estructuras en la programacion son:
            // - Arreglos
            // - Listas
            // - Diccionarios
            // - Colas
            // - Pilas
            // - Conjuntos
            // - Matrices

            // Arreglos 
            int[] arreglo = new int[5];
            arreglo[0] = 1;
            arreglo[1] = 2;
            arreglo[2] = 3;
            arreglo[3] = 4;
            arreglo[4] = 5;

            Console.WriteLine("Arreglo: "); // Leer
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            // Listas
            List<int> lista = new List<int>();

            // Insercion, borrado, actualizacion y ordenacion

            lista.Add(1); // Insertar
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            Console.WriteLine("Insertar Lista:"); // Leer
            print(lista);

            lista.Remove(2); // Borrar
            Console.WriteLine("Borrar Lista:"); // Leer
            print(lista);

            lista[0] = 5; // Actualizar
            Console.WriteLine("Actualizar Lista:"); // Leer

            print(lista);

            lista.Sort(); // Ordenar
            Console.WriteLine("Ordenar Lista:"); // Leer
            print(lista);

            // Diccionarios

            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            diccionario.Add("uno", 1); // Insertar
            diccionario.Add("dos", 2);

            Console.WriteLine("Insertar Diccionario:"); // Leer
            foreach (KeyValuePair<string, int> kvp in diccionario)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            diccionario.Remove("uno"); // Borrar
            Console.WriteLine("Borrar Diccionario:"); // Leer
            foreach (KeyValuePair<string, int> kvp in diccionario)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            diccionario["dos"] = 5; // Actualizar

            Console.WriteLine("Actualizar Diccionario:"); // Leer   
            foreach (KeyValuePair<string, int> kvp in diccionario)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            // Colas

            Queue<int> cola = new Queue<int>();

            cola.Enqueue(1); // Insertar
            cola.Enqueue(2);

            Console.WriteLine("Insertar Cola:"); // Leer
            foreach (int i in cola)
            {
                Console.WriteLine(i);
            }

            cola.Dequeue(); // Borrar
            Console.WriteLine("Borrar Cola:"); // Leer
            foreach (int i in cola)
            {
                Console.WriteLine(i);
            }

            // Pilas

            Stack<int> pila = new Stack<int>();

            pila.Push(1); // Insertar
            pila.Push(2);

            Console.WriteLine("Insertar Pila:"); // Leer
            foreach (int i in pila)
            {
                Console.WriteLine(i);
            }

            pila.Pop(); // Borrar
            Console.WriteLine("Borrar Pila:"); // Leer
            foreach (int i in pila)
            {
                Console.WriteLine(i);
            }

            // Conjuntos

            HashSet<int> conjunto = new HashSet<int>();

            conjunto.Add(1); // Insertar
            conjunto.Add(2);
            conjunto.Add(3);
            conjunto.Add(2);

            Console.WriteLine("Insertar Conjunto:"); // Leer
            foreach (int i in conjunto)
            {
                Console.WriteLine(i);
            }

            conjunto.Remove(1); // Borrar
            Console.WriteLine("Borrar Conjunto:"); // Leer
            foreach (int i in conjunto)
            {
                Console.WriteLine(i);
            }

            // Matrices

            int[,] matriz = new int[2, 2];

            matriz[0, 0] = 1; // Insertar
            matriz[0, 1] = 2;
            matriz[1, 0] = 3;
            matriz[1, 1] = 4;

            Console.WriteLine("Insertar Matriz:"); // Leer
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }

            // Dificultad Extra

            Dictionary<string, int> agenda = new Dictionary<string, int>();
            int opcion = 0;
            do 
            {
                Console.WriteLine("Agenda de Contactos:");
                Console.WriteLine("1. Insertar Contacto");
                Console.WriteLine("2. Buscar Contacto");
                Console.WriteLine("3. Actualizar Contacto");
                Console.WriteLine("4. Eliminar Contacto");
                Console.WriteLine("5. Mostrar Contactos");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Seleccione una opcion: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion > 6 || opcion < 1)
                    {
                        Console.WriteLine("Opcion no valida, debe ser un numero entre 1 y 5");
                    } else if (opcion == 1)
                    {
                        insertar(agenda);
                    } else if (opcion == 2)
                    {
                        buscar(agenda);
                    } else if (opcion == 3)
                    {
                        actualizar(agenda);
                    } else if (opcion == 4)
                    {
                        borrar(agenda);
                    } else if (opcion == 5)
                    {
                        mostrar(agenda);
                    } else 
                    {
                        Console.WriteLine("Saliendo");
                    }
                } catch (Exception e)
                {
                    Console.WriteLine("Opcion no valida, debe ser un numero entero");
                }
            } 
            while (opcion != 6);
        }
    }

}