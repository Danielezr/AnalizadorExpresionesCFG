using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorExpresionesCFG
{
    public class PasoDerivacion
    {
        public string Regla { get; set; }
        public string ExpresionActual { get; set; }

        public PasoDerivacion(string reglas, string expresionActual)
            {
            Regla = reglas;
            ExpresionActual = expresionActual;
        }
    }
}
