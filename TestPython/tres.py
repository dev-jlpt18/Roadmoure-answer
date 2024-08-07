"""
    EJERCICIO:
    - Muestra ejemplos de creación de todas las estructuras soportadas por defecto en tu lenguaje.
    - Utiliza operaciones de inserción, borrado, actualización y ordenación.

    DIFICULTAD EXTRA (opcional):
    Crea una agenda de contactos por terminal.
    - Debes implementar funcionalidades de búsqueda, inserción, actualización y eliminación de contactos.
    - Cada contacto debe tener un nombre y un número de teléfono.
    - El programa solicita en primer lugar cuál es la operación que se quiere realizar, y a continuación
    los datos necesarios para llevarla a cabo.
    - El programa no puede dejar introducir números de teléfono no númericos y con más de 11 dígitos.
    (o el número de dígitos que quieras)
    - También se debe proponer una operación de finalización del programa.
"""
def buscar_contacto(agenda):
    if len(agenda) == 0:
        print("No hay contactos en la agenda")
        return
    else:
        nombre = input("Introduce el nombre del contacto a buscar: ")
        for contacto in agenda:
            if nombre == contacto:
                print("Nombre: ", nombre)
                print("Teléfono: ", agenda[contacto])
                return
        print("El contacto no existe en la agenda")

def insertar_contacto(agenda):
    nombre = input("Introduce el nombre del contacto: ")
    telefono = input("Introduce el teléfono del contacto: ")
    try:
        if len(telefono) > 11:
            print("El número de teléfono debe tener 10 dígitos")
            return
        else:
            telefono = int(telefono)
            agenda[nombre] = telefono
            
    except ValueError:
        print("El número de teléfono debe ser numérico")
        return


def actualizar_contacto(agenda):
    nombre = input("Introduce el nombre del contacto a actualizar: ")
    telefono = input("Introduce el nuevo teléfono del contacto: ")
    try:
        if len(telefono) > 11:
            print("El número de teléfono debe tener 10 dígitos")
            return
        else:
            telefono = int(telefono)
            agenda[nombre] = telefono
    except ValueError:
        print("El número de teléfono debe ser numérico")
        return
    except KeyError:
        print("El contacto no existe en la agenda")

def eliminar_contacto(agenda):
    nombre = input("Introduce el nombre del contacto a eliminar: ")
    try:
        agenda.pop(nombre)
    except KeyError:
        print("El contacto no existe en la agenda")

def listar_contactos(agenda):
    if len(agenda) == 0:
        print("No hay contactos en la agenda")
    else:
        for contacto in agenda:
            print("Nombre: ", contacto)
            print("Teléfono: ", agenda[contacto])

def agenda():
    agenda = { "Juan": 1234567890, "Pedro": 9876543210 }
    while True:
        print("Agenda de contactos:")
        print("1.- Buscar contacto")
        print("2.- Insertar contacto")
        print("3.- Actualizar contacto")
        print("4.- Eliminar contacto")
        print("5.- Listar contactos")
        print("6.- Salir")
        try:
            opcion = int(input("¿Qué operación deseas realizar?: "))
            if opcion == 1:
                buscar_contacto(agenda)
            elif opcion == 2:
                insertar_contacto(agenda)
            elif opcion == 3:
                actualizar_contacto(agenda)
            elif opcion == 4:
                eliminar_contacto(agenda)
            elif opcion == 5:
                listar_contactos(agenda)
            elif opcion == 6:
                break
            else:
                print("")
        except ValueError:
            print("El valor introducido no es un número")

if __name__ == '__main__':
    # Creación de estructuras, python soporta listas, tuplas, conjuntos y diccionarios
    # Tiene los métodos append, remove, update y sort para las listas

    lista = [1, 2, 3, 4, 5]

    lista.append(6)
    lista.remove(3)
    lista.sort()
    lista.reverse()
    # Tiene los metodos add, remove y update para los conjuntos
    conjunto = {1, 2, 3, 4, 5}

    conjunto.add(6)
    conjunto.remove(3)
    conjunto.update({7, 8, 9})
    # Tiene los metodos update, remove y sort para las tuplas
    tupla = (1, 2, 3, 4, 5)

    lista = list(tupla)
    lista.append(6)
    lista.remove(3)
    lista.sort()
    tupla = tuple(lista)
    # Tiene los metodos get, update, remove y sort para los diccionarios
    diccionario = { "uno": 1, "dos": 2, "tres": 3, "cuatro": 4, "cinco": 5 }

    diccionario["seis"] = 6
    diccionario.pop("tres")
    diccionario.update({ "siete": 7, "ocho": 8, "nueve": 9 })
    diccionario = dict(sorted(diccionario.items()))
    
    agenda()