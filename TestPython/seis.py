"""
EJERCICIO:
Entiende el concepto de recursividad creando una función recursiva que imprima
números del 100 al 0.

DIFICULTAD EXTRA (opcional):
Utiliza el concepto de recursividad para:
- Calcular el factorial de un número concreto (la función recibe ese número).
- Calcular el valor de un elemento concreto (según su posición) en la 
  sucesión de Fibonacci (la función recibe la posición).

"""

def ImprimirNumeros(num:int):
    for i in range(num,0,-1):
        print(i)

def Factorial(num:int):
    if num > 1:
        return Factorial(num-1)*num
    else:
        return 1

def Fibonacci(num:int):
    if num == 1:
        return 0
    elif num == 2:
        return 1
    else: 
        return Fibonacci(num-1)+ Fibonacci(num-2)
    
ImprimirNumeros(100)
num = int(input("Dame un numero: "))

print(f"Este es el factorial de {num}: {Factorial(num)}")
num = int(input("Dame un numero: "))
print(f"Este es el fibonacci en la posicion {num}: {Fibonacci(num)}")