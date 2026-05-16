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
                else
                {
                    throw new Exception("Carácter no reconocido '" + actual + "' en la posición " + posicion + ".");
                }
            }

            tokens.Add(new Token("FIN", TipoToken.Fin, posicion));

            return tokens;
        }
    }
}