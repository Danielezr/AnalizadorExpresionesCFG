namespace AnalizadorExpresionesCFG
{
    public class Token
    {
        public string Valor { get; private set; }
        public TipoToken Tipo { get; private set; }
        public int Posicion { get; private set; }

        public Token(string valor, TipoToken tipo, int posicion)
        {
            Valor = valor;
            Tipo = tipo;
            Posicion = posicion;
        }

        public override string ToString()
        {
            return "Valor: " + Valor + " | Tipo: " + Tipo + " | Posición: " + Posicion;
        }
    }
}