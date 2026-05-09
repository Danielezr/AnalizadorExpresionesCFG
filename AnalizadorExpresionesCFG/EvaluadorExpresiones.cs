using System;
using System.Globalization;

namespace AnalizadorExpresionesCFG
{
    public class EvaluadorExpresiones
    {
        private string expresion;
        private int posicion;

        public double Evaluar(string expresionOriginal)
        {
            if (string.IsNullOrWhiteSpace(expresionOriginal))
            {
                throw new Exception("La expresión no puede estar vacía.");
            }

            expresion = PrepararExpresion(expresionOriginal);  //manda la expresion original a la funcion preparar expresion para limpiarla
            posicion = 0;

            double resultado = Expresion();

            if (HayCaracteres())
            {
                throw new Exception("Caracter inesperado: " + CaracterActual());
            }

            return resultado;
        }

        private string PrepararExpresion(string expresionOriginal) //Funcion para limpia y preparar la expresion para su evaluacion.
        {
            return expresionOriginal
                .Replace(" ", "")
                .Replace("X", "*")
                .Replace("x", "*"); //reemplaza espacios y 'X' por '*' para facilitar la evaluación de multiplicaciones
        }

        private bool HayCaracteres()
        {
            return posicion < expresion.Length;
        }

        private char CaracterActual()
        {
            if (HayCaracteres())
            {
                return expresion[posicion];
            }

            return '\0';
        }

        private double LeerNumero()
        {
            int inicioNumero = posicion;
            bool yaTienePunto = false;

            while (HayCaracteres() && (char.IsDigit(CaracterActual()) || CaracterActual() == '.'))
            {
                if (CaracterActual() == '.')
                {
                    if (yaTienePunto)
                    {
                        throw new Exception("Número decimal inválido.");
                    }

                    yaTienePunto = true;
                }

                posicion++;
            }

            string textoNumero = expresion.Substring(inicioNumero, posicion - inicioNumero);

            if (textoNumero == "" || textoNumero == ".")
            {
                throw new Exception("Número inválido.");
            }

            if (!double.TryParse(textoNumero, NumberStyles.Float, CultureInfo.InvariantCulture, out double numero))
            {
                throw new Exception("Número inválido: " + textoNumero);
            }

            return numero;
        }

        private double Factor()
        {
            if (!HayCaracteres())
            {
                throw new Exception("Se esperaba un número o paréntesis.");
            }

            if (CaracterActual() == '+')
            {
                posicion++;
                return Factor();
            }

            if (CaracterActual() == '-')
            {
                posicion++;
                return -Factor();
            }

            if (CaracterActual() == '(')
            {
                posicion++;

                double resultado = Expresion();

                if (!HayCaracteres() || CaracterActual() != ')')
                {
                    throw new Exception("Falta cerrar paréntesis.");
                }

                posicion++;

                return resultado;
            }

            return LeerNumero();
        }

        private double Expresion()
        {
            double resultado = Termino();

            while (HayCaracteres() && (CaracterActual() == '+' || CaracterActual() == '-'))
            {
                char operador = CaracterActual();
                posicion++;

                double siguienteNumero = Termino();

                if (operador == '+')
                {
                    resultado += siguienteNumero;
                }
                else
                {
                    resultado -= siguienteNumero;
                }
            }

            return resultado;
        }

        private double Termino()
        {
            double resultado = Potencia();

            while (HayCaracteres() && (CaracterActual() == '*' || CaracterActual() == '/'))
            {
                char operador = CaracterActual();
                posicion++;

                double siguienteFactor = Potencia();

                if (operador == '*')
                {
                    resultado *= siguienteFactor;
                }
                else
                {
                    if (siguienteFactor == 0)
                    {
                        throw new Exception("No se puede dividir entre cero.");
                    }

                    resultado /= siguienteFactor;
                }
            }

            return resultado;
        }

        private double Potencia()
        {
            double basePotencia = Factor();

            if (HayCaracteres() && CaracterActual() == '^')
            {
                posicion++;

                double exponente = Potencia();

                return Math.Pow(basePotencia, exponente);
            }

            return basePotencia;
        }
    }
}