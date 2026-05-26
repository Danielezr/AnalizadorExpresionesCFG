using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorExpresionesCFG
{
    public class NodoDerivacion
    {
        public string Valor { get; set; }
        public List<NodoDerivacion> Hijos { get; set; }

        public NodoDerivacion(string valor)
        {
            Valor = valor;
            Hijos = new List<NodoDerivacion>();
        }

        public void AgregarHijo(NodoDerivacion hijo)
        {
            Hijos.Add(hijo);
        }
    }
}
