""" 
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

"""
# Operadores aritmeticos
print("Operadores aritmeticos: ")
# Suma
suma = 10 + 5
print(suma)

# Resta
resta = 10 - 5
print(resta)

# Multiplicacion
multiplicacion = 10 * 5
print(multiplicacion)

# Division
division = 10 / 5
print(division)

# Modulo
modulo = 10 % 5
print(modulo)

# Exponente
exponente = 10 ** 5
print(exponente)

# Division entera
division_entera = 10 // 5
print(division_entera)

# Operadores de comparacion
print("Operadores comparacion: ")
# Igual
igual = 10 == 5
print(igual)

# Diferente
diferente = 10 != 5
print(diferente)

# Mayor que
mayor_que = 10 > 5
print(mayor_que)

# Menor que
menor_que = 10 < 5
print(menor_que)

# Mayor o igual que
mayor_o_igual_que = 10 >= 5
print(mayor_o_igual_que)

# Menor o igual que
menor_o_igual_que = 10 <= 5
print(menor_o_igual_que)

# Operadores logicos
print("Operadores logicos: ")
# And
and_logico = True and False
print(and_logico)

# Or
or_logico = True or False
print(or_logico)

# Not
not_logico = not True
print(not_logico)

# Operadores de asignacion
print("Operadores de asignacion: ")
# Asignacion
asignacion = 10
print(asignacion)

# Suma y asignacion

suma_asignacion = 10
suma_asignacion += 5
print(suma_asignacion)

# Resta y asignacion

resta_asignacion = 10
resta_asignacion -= 5
print(resta_asignacion)

# Multiplicacion y asignacion

multiplicacion_asignacion = 10
multiplicacion_asignacion *= 5
print(multiplicacion_asignacion)

# Division y asignacion

division_asignacion = 10
division_asignacion /= 5
print(division_asignacion)

# Modulo y asignacion

modulo_asignacion = 10
modulo_asignacion %= 5
print(modulo_asignacion)

# Exponente y asignacion

exponente_asignacion = 10
exponente_asignacion **= 5
print(exponente_asignacion)

# Division entera y asignacion

division_entera_asignacion = 10
division_entera_asignacion //= 5
print(division_entera_asignacion)

# Operadores de identidad
print("Operadores de identidad: ")
# Is
is_identidad = 10 is 5
print(is_identidad)

# Is not
is_not_identidad = 10 is not 5
print(is_not_identidad)

# Operadores de pertenencia
print("Operadores de pertenencia: ")
# In
in_pertenencia = 10 in [1, 2, 3, 4, 5]
print(in_pertenencia)

# Not in

not_in_pertenencia = 10 not in [1, 2, 3, 4, 5]
print(not_in_pertenencia)

# Operadores de bits
print("Operadores de bits: ")
# And

and_bits = 10 & 5
print(and_bits)

# Or

or_bits = 10 | 5
print(or_bits)

# Xor

xor_bits = 10 ^ 5
print(xor_bits)

# Not

not_bits = ~10
print(not_bits)

# Desplazamiento a la izquierda

desplazamiento_izquierda = 10 << 5
print(desplazamiento_izquierda)

# Desplazamiento a la derecha

desplazamiento_derecha = 10 >> 5

print(desplazamiento_derecha)

# Estructuras de control
print("Estructuras de control: ")
# Condicionales
print("Condicionales: ")

# If

if 10 > 5:
    print("10 es mayor que 5")
else:
    print("10 no es mayor que 5")

# Elif

if 10 > 5:
    print("10 es mayor que 5")
elif 10 < 5:
    print("10 es menor que 5")
else:
    print("10 es igual a 5")

# Iterativas

print("Iterativas: ")
# For
print("For: ")
for i in range(10):
    print(i)

# While
print("While: ")
i = 0
while i < 10:
    print(i)
    i += 1

# Excepciones

print("Excepciones: ")
# Try

try:
    print(10 / 0)
except ZeroDivisionError:
    print("No se puede dividir por 0")

# Finally

# Dificultad extra
a = 10
while a <= 55:
    if (a % 2 == 0 and a != 16 and a % 3 != 0):
        print(a)
    a += 1