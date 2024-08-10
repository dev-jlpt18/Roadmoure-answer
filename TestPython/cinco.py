""" 
EJERCICIO:
- Muestra ejemplos de asignación de variables "por valor" y "por referencia", según
  su tipo de dato.
- Muestra ejemplos de funciones con variables que se les pasan "por valor" y 
  "por referencia", y cómo se comportan en cada caso en el momento de ser modificadas.
(Entender estos conceptos es algo esencial en la gran mayoría de lenguajes)
DIFICULTAD EXTRA (opcional):
Crea dos programas que reciban dos parámetros (cada uno) definidos como variables anteriormente.
- Cada programa recibe, en un caso, dos parámetros por valor, y en otro caso, por referencia.
  Estos parámetros los intercambia entre ellos en su interior, los retorna, y su retorno
  se asigna a dos variables diferentes a las originales. A continuación, imprime el valor de las
  variables originales y las nuevas, comprobando que se ha invertido su valor en las segundas.
  Comprueba también que se ha conservado el valor original en las primeras.

"""
# Ejemplo de asignación por valor
a = 5
b = a
b = 10
print("Asignación por valor:")
print(f"a = {a}, b = {b}")  # a = 5, b = 10

# Ejemplo de asignación por referencia
array1 = [1, 2, 3]
array2 = array1
array2[0] = 10
print("Asignación por referencia:")
print(f"array1[0] = {array1[0]}, array2[0] = {array2[0]}")  # array1[0] = 10, array2[0] = 10

# Ejemplo de paso de parámetros por valor
def modificar_por_valor(num):
    num = 10

x = 5
modificar_por_valor(x)
print("Paso de parámetros por valor:")
print(f"x = {x}")  # x = 5

# Ejemplo de paso de parámetros por referencia
def modificar_por_referencia(lst):
    lst[0] = 10

y = [5]
modificar_por_referencia(y)
print("Paso de parámetros por referencia:")
print(f"y[0] = {y[0]}")  # y[0] = 10

# DIFICULTAD EXTRA (opcional)
# Programa que intercambia dos parámetros por valor
def intercambiar_por_valor(val1, val2):
    return val2, val1

# Programa que intercambia dos parámetros por referencia
def intercambiar_por_referencia(ref1, ref2):
    ref1[0], ref2[0] = ref2[0], ref1[0]
    return ref1, ref2

# Variables originales
m = 1
n = 2
# Intercambio por valor
m_nuevo, n_nuevo = intercambiar_por_valor(m, n)
print("Intercambio por valor:")
print(f"Originales: m = {m}, n = {n}")  # m = 1, n = 2
print(f"Nuevas: m_nuevo = {m_nuevo}, n_nuevo = {n_nuevo}")  # m_nuevo = 2, n_nuevo = 1

# Variables originales
p = [1]
q = [2]
# Intercambio por referencia
p_nuevo, q_nuevo = intercambiar_por_referencia(p, q)
print("Intercambio por referencia:")
print(f"Originales: p = {p[0]}, q = {q[0]}")  # p = 2, q = 1
print(f"Nuevas: p_nuevo = {p_nuevo[0]}, q_nuevo = {q_nuevo[0]}")  # p_nuevo = 2, q_nuevo = 1