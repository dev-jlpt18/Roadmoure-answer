"""

EJERCICIO:
Muestra ejemplos de todas las operaciones que puedes realizar con cadenas de caracteres
en tu lenguaje. Algunas de esas operaciones podrían ser (busca todas las que puedas):
- Acceso a caracteres específicos, subcadenas, longitud, concatenación, repetición, recorrido,
  conversión a mayúsculas y minúsculas, reemplazo, división, unión, interpolación, verificación...

DIFICULTAD EXTRA (opcional):
Crea un programa que analice dos palabras diferentes y realice comprobaciones
para descubrir si son:
- Palíndromos
- Anagramas
- Isogramas


"""

def Palindromo(palabra:str, palabra2:str)->bool:
    palabra = palabra.replace(" ","").lower()
    palabra2 = palabra2.replace(" ", "").lower()

    if not len(palabra) == len(palabra2):
        return False
    
    lista = list(palabra)
    lista.reverse()
    palabra = "".join(lista)

    return  True if palabra == palabra2 else False

def Anagramas(palabra:str, palabra2:str)->bool:
    palabra = palabra.replace(" ","").lower()
    palabra2 = palabra2.replace(" ", "").lower()  

    if not len(palabra) == len(palabra2):
        return False
    
    lista = list(palabra)
    lista2 = list(palabra2)

    lista.sort()
    lista2.sort()

    return  True if lista == lista else False

def Isogramas(palabra:str, palabra2:str)->bool:
    palabra = palabra.replace(" ","").lower()
    palabra2 = palabra2.replace(" ", "").lower()

    if not len(palabra) == len(palabra2):
        return False
    
    for char in palabra:
        if palabra2.count(char) > 1:
            return False
    return True

if __name__ == "__main__":

    # Ejemplos de operaciones con cadenas de caracteres

    # Acceso a caracteres específicos
    cadena = "Hola Mundo"
    print(cadena[0])  # 'H'
    print(cadena[-1])  # 'o'

    # Subcadenas
    print(cadena[0:4])  # 'Hola'
    print(cadena[5:])  # 'Mundo'

    # Longitud
    print(len(cadena))  # 10

    # Concatenación
    cadena2 = "Python"
    print(cadena + " " + cadena2)  # 'Hola Mundo Python'

    # Repetición
    print(cadena * 3)  # 'Hola MundoHola MundoHola Mundo'

    # Recorrido
    for char in cadena:
        print(char)

    # Conversión a mayúsculas y minúsculas
    print(cadena.upper())  # 'HOLA MUNDO'
    print(cadena.lower())  # 'hola mundo'

    # Reemplazo
    print(cadena.replace("Hola", "Adiós"))  # 'Adiós Mundo'

    # División
    palabras = cadena.split(" ")
    print(palabras)  # ['Hola', 'Mundo']

    # Unión
    print(" ".join(palabras))  # 'Hola Mundo'

    # Interpolación
    nombre = "Juan"
    edad = 30
    print(f"Me llamo {nombre} y tengo {edad} años.")  # 'Me llamo Juan y tengo 30 años.'

    # Verificación
    print(cadena.startswith("Hola"))  # True
    print(cadena.endswith("Mundo"))  # True
    print("Mundo" in cadena)  # True
    print("Python" not in cadena)  # True


    print(Palindromo("aloh","hola"))
    print(Anagramas("amor", "roma"))
    print(Isogramas("dios", "mano"))