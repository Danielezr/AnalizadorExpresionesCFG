// Analizador léxico para expresiones matemáticas.
// Lee la expresión de izquierda a derecha y la separa en tokens:
// números, operadores, paréntesis y token final FIN.

using System;
using System.Collections.Generic;

namespace AnalizadorExpresionesCFG
{
    public class AnalizadorLexico
    {
        private string expresion;
        private int posicion;
        private List<Token> tokens;

        public List<Token> Analizar(string expresionOriginal)
        {
            if (string.IsNullOrWhiteSpace(expresionOriginal))
            {
                throw new Exception("La expresión no puede estar vacía.");
            }

            expresion = expresionOriginal;
            posicion = 0;
            tokens = new List<Token>();

            while (posicion < expresion.Length)
            {
                char actual = expresion[posicion];

                if (char.IsWhiteSpace(actual))
                {
                    posicion++;
                }

                else if (char.IsDigit(actual) || actual == '.')
                {
                    tokens.Add(LeerNumero());
                }

                else if (actual == '+')
                {
                    tokens.Add(new Token("+", TipoToken.OperadorSuma, posicion));
                    posicion++;
                }

                else if (actual == '-')
                {
                    if (DebeSerNumeroNegativo())
                    {
                        tokens.Add(LeerNumero());
                    }
                    else
                    {
                        tokens.Add(new Token("-", TipoToken.OperadorResta, posicion));
                        posicion++;
                    }
                }

                else if (actual == 'X' || actual == 'x' || actual == '*')
                {
                    tokens.Add(new Token(actual.ToString(), TipoToken.OperadorMultiplicacion, posicion));
                    posicion++;
                }

                else if (actual == '/')
                {
                    tokens.Add(new Token("/", TipoToken.OperadorDivision, posicion));
                    posicion++;
                }

                else if (actual == '^')
                {
                    tokens.Add(new Token("^", TipoToken.OperadorPotencia, posicion));
                    posicion++;
                }

                else if (actual == '(')
                {
                    tokens.Add(new Token("(", TipoToken.ParentesisIzquierdo, posicion));
                    posicion++;
                }

                else if (actual == ')')
                {
                    tokens.Add(new Token(")", TipoToken.ParentesisDerecho, posicion));
                    posicion++;
                }

                else
                {
                    throw new Exception("Carácter no reconocido '" + actual + "' en la posición " + posicion + ".");
                }

            }

            tokens.Add(new Token("FIN", TipoToken.Fin, posicion));

            return tokens;
        }

        // Lee un número completo antes de crear el token.
        // Acepta enteros y decimales como 25, 3.14, 0.5 y .5.
        private Token LeerNumero()
        {
            int inicio = posicion;
            bool tienePunto = false;
            bool tieneDigito = false;

            if (expresion[posicion] == '-')
            {
                posicion++;
            }

            while (posicion < expresion.Length)
            {
                char actual = expresion[posicion];

                if (char.IsDigit(actual))
                {
                    tieneDigito = true;
                    posicion++;
                }
                else if (actual == '.')
                {
                    if (tienePunto)
                    {
                        throw new Exception("Número decimal inválido en la posición " + posicion + ".");
                    }

                    tienePunto = true;
                    posicion++;
                }
                else
                {
                    break;
                }
            }

            string valor = expresion.Substring(inicio, posicion - inicio);

            if (!tieneDigito)
            {
                throw new Exception("Número decimal inválido en la posición " + inicio + ".");
            }

            if (valor.EndsWith("."))
            {
                throw new Exception("Número decimal inválido en la posición " + inicio + ".");
            }

            return new Token(valor, TipoToken.Numero, inicio);
        }

        private bool DebeSerNumeroNegativo()
        {
            if (posicion + 1 >= expresion.Length)
            {
                return false;
            }

            char siguiente = expresion[posicion + 1];

            if (!char.IsDigit(siguiente) && siguiente != '.')
            {
                return false;
            }

            if (tokens.Count == 0)
            {
                return true;
            }

            TipoToken tipoAnterior = tokens[tokens.Count - 1].Tipo;

            return tipoAnterior == TipoToken.OperadorSuma ||
                   tipoAnterior == TipoToken.OperadorResta ||
                   tipoAnterior == TipoToken.OperadorMultiplicacion ||
                   tipoAnterior == TipoToken.OperadorDivision ||
                   tipoAnterior == TipoToken.OperadorPotencia ||
                   tipoAnterior == TipoToken.ParentesisIzquierdo;
        }

    }
}