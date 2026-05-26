# Analizador de Expresiones CFG

Proyecto final de la materia **Teoría de Autómatas**.

Este proyecto consiste en desarrollar una aplicación en **C# con Windows Forms** para capturar, analizar y evaluar expresiones matemáticas basadas en una gramática libre de contexto.

## Integrantes

- Daniel Espinoza
- Hiram Licea

## Descripción general

El programa tiene como objetivo permitir al usuario ingresar expresiones matemáticas y posteriormente evaluarlas siguiendo una gramática definida para operaciones aritméticas.

La aplicación busca soportar expresiones con:

- Números enteros
- Números decimales
- Números positivos y negativos
- Suma
- Resta
- Multiplicación
- División
- Potencia
- Paréntesis anidados

---

## Historial de Avances

### Avance 3: Analizador léxico
En esta actualización se integró un analizador léxico que explora la entrada matemática y reconoce todas las unidades sintácticas (agrupaciones lógicas). 

El programa ahora es capaz de:
- Separar la expresión en tokens individuales (números, operadores, paréntesis y el token FIN).
- Mostrar en una tabla interactiva de la interfaz el **Valor**, el **Tipo** y la **Posición** exacta de cada token generado.
- Detectar y notificar errores léxicos de manera segura, como la inserción de caracteres no reconocidos (ej. letras) o formatos decimales inválidos (ej. `3..14`).

### Avance 4 / Proyecto Final: Analizador sintáctico
En esta etapa final se integró el analizador sintáctico utilizando el enfoque de **Descenso Recursivo**. Se implementó una gramática sin recursión a la izquierda para procesar los tokens generados por el analizador léxico.

Características principales de esta versión:
- **Evaluación gramatical:** Verifica que la estructura matemática de la expresión sea correcta mediante los métodos `Expresion`, `Termino` y `Factor`, respetando la precedencia de operadores.
- **Árbol de derivación:** Genera un Árbol de Sintaxis Abstracta (AST) de la expresión ingresada, visualizado dinámicamente mediante un control `TreeView`.
- **Tabla de derivación:** Registra y muestra paso a paso las reglas de producción aplicadas durante el análisis.
- **Manejo de errores:** Atrapa errores sintácticos indicando exactamente el token inesperado y su posición en la cadena.
- **Historial:** Mantiene un registro de las expresiones correctamente evaluadas durante la sesión.
