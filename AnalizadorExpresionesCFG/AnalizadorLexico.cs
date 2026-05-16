//Lee la expresión de izquierda a derecha.
//Si encuentra espacios, los ignora.
//Si encuentra cualquier otra cosa, marca error.

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
                else if (char.IsDigit(actual))
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
                    tokens.Add(new Token("-", TipoToken.OperadorResta, posicion));
                    posicion++;
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

        //esta funcion sirve para que si un numero tiene más de un dígito, este se leea completamente antes de crear el token.
        private Token LeerNumero()
        {
            int inicio = posicion;
            bool tienePunto = false;

            while (posicion < expresion.Length)
            {
                char actual = expresion[posicion];

                if (char.IsDigit(actual))
                {
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

                    if (posicion >= expresion.Length || !char.IsDigit(expresion[posicion]))
                    {
                        throw new Exception("Número decimal inválido en la posición " + posicion + ".");
                    }
                }
                else
                {
                    break;
                }
            }

            string valor = expresion.Substring(inicio, posicion - inicio);

            return new Token(valor, TipoToken.Numero, inicio);
        }
    }
}