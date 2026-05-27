using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorExpresionesCFG
{
    public class AnalizadorSintactico
    {
        private List<Token> tokens;
        private int posicion;

        //aca atacas tu daniel
        public NodoDerivacion RaizArbol { get; private set; }
        public List<PasoDerivacion> HistorialDerivacion { get; private set; }
        private Token TokenActual => tokens[posicion];

        public AnalizadorSintactico(List<Token> tokens)
        {
            this.tokens = tokens;
            this.posicion = 0;
            this.HistorialDerivacion = new List<PasoDerivacion>();
        }

        public double Parsear()
        {
            RaizArbol = new NodoDerivacion("Expresion");
            double resultado = Expresion(RaizArbol);

            if(TokenActual.Tipo != TipoToken.Fin)
            {
                throw new Exception($"Error de sintaxis: Token inesperado '{TokenActual.Valor}' en la posición {TokenActual.Posicion}.");
            }
            return resultado;
        }
        private void Avanzar()
        {
            if (posicion < tokens.Count - 1)
            {
                posicion++;
            }
        }
        private void Coincidir(TipoToken tipoEsperado)
        {
            if(TokenActual.Tipo == tipoEsperado)
            {
                Avanzar();
            }
            else
            {
                throw new Exception($"Error de sintaxis: Se esperaba un token de tipo '{tipoEsperado}' pero se encontró '{TokenActual.Valor}' en la posición {TokenActual.Posicion}.");
            }
        }
        private double Expresion(NodoDerivacion nodoPadre)
        {
            NodoDerivacion nodoTermino = new NodoDerivacion("Termino");
            nodoPadre.AgregarHijo(nodoTermino);

            double resultado = Termino(nodoTermino);

            while (TokenActual.Tipo == TipoToken.OperadorSuma || TokenActual.Tipo == TipoToken.OperadorResta)
            {
                Token tokenOperador = TokenActual;
                nodoPadre.AgregarHijo(new NodoDerivacion(tokenOperador.Valor));
                Avanzar();

                NodoDerivacion nodoTerminoDer = new NodoDerivacion("Termino");
                nodoPadre.AgregarHijo(nodoTerminoDer);

                if(tokenOperador.Tipo == TipoToken.OperadorSuma)
                {
                    HistorialDerivacion.Add(new PasoDerivacion("Expresion -> Expresion + Termino", ""));
                    resultado += Termino(nodoTerminoDer);
                }
                else
                {
                    HistorialDerivacion.Add(new PasoDerivacion("Expresion -> Expresion - Termino", ""));
                    resultado -= Termino(nodoTerminoDer);
                }
            }
            return resultado;
        }
        private double Termino(NodoDerivacion nodoPadre)
        {
            NodoDerivacion nodoPotencia = new NodoDerivacion("Potencia");
            nodoPadre.AgregarHijo(nodoPotencia);

            double resultado = Potencia(nodoPotencia);

            while (TokenActual.Tipo == TipoToken.OperadorMultiplicacion || TokenActual.Tipo == TipoToken.OperadorDivision)
            {
                Token tokenOperador = TokenActual;
                nodoPadre.AgregarHijo(new NodoDerivacion(tokenOperador.Valor));
                Avanzar();

                NodoDerivacion nodoPotenciaDer = new NodoDerivacion("Potencia");
                nodoPadre.AgregarHijo(nodoPotenciaDer);

                if (tokenOperador.Tipo == TipoToken.OperadorMultiplicacion)
                {
                    HistorialDerivacion.Add(new PasoDerivacion("Termino -> Termino * Potencia", ""));
                    resultado *= Potencia(nodoPotenciaDer);
                }
                else
                {
                    HistorialDerivacion.Add(new PasoDerivacion("Termino -> Termino / Potencia", ""));
                    double divisor = Potencia(nodoPotenciaDer);

                    if (divisor == 0)
                    {
                        throw new DivideByZeroException("Error matemático: no se puede dividir entre cero.");
                    }

                    resultado /= divisor;
                }
            }

            return resultado;
        }
        private double Potencia(NodoDerivacion nodoPadre)
        {
            NodoDerivacion nodoFactor = new NodoDerivacion("Factor");
            nodoPadre.AgregarHijo(nodoFactor);

            double resultado = Factor(nodoFactor);

            if (TokenActual.Tipo == TipoToken.OperadorPotencia)
            {
                Token tokenOperador = TokenActual;
                nodoPadre.AgregarHijo(new NodoDerivacion(tokenOperador.Valor));
                Avanzar();

                NodoDerivacion nodoPotenciaDer = new NodoDerivacion("Potencia");
                nodoPadre.AgregarHijo(nodoPotenciaDer);

                HistorialDerivacion.Add(new PasoDerivacion("Potencia -> Factor ^ Potencia", ""));

                double exponente = Potencia(nodoPotenciaDer);
                resultado = Math.Pow(resultado, exponente);
            }

            return resultado;
        }

        private double Factor(NodoDerivacion nodoPadre)
        {
            if (TokenActual.Tipo == TipoToken.ParentesisIzquierdo)
            {
                nodoPadre.AgregarHijo(new NodoDerivacion("("));
                Avanzar();

                NodoDerivacion nodoExp = new NodoDerivacion("Expresion");
                nodoPadre.AgregarHijo(nodoExp);
                double resultado = Expresion(nodoExp);

                Coincidir(TipoToken.ParentesisDerecho);
                nodoPadre.AgregarHijo(new NodoDerivacion(")"));
                HistorialDerivacion.Add(new PasoDerivacion("Factor -> (Expresion)", ""));
                return resultado;
            }
            else if (TokenActual.Tipo == TipoToken.Numero)
            {
                double valor = double.Parse(TokenActual.Valor);
                nodoPadre.AgregarHijo(new NodoDerivacion($"Numero ({valor})"));
                HistorialDerivacion.Add(new PasoDerivacion($"Factor -> Numero -> {valor}", ""));
                Avanzar();
                return valor;
            }
            else
            {
                throw new Exception($"Error de sintaxis: Factor inválido, se encontró '{TokenActual.Valor}' en la posición {TokenActual.Posicion}.");
            }
        }
    }
}