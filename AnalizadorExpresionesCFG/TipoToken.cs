namespace AnalizadorExpresionesCFG
{

    //enum para representar los tipos de tokens que se pueden encontrar en la expresión matemática.
    public enum TipoToken
    {
        Numero,
        OperadorSuma,
        OperadorResta,
        OperadorMultiplicacion,
        OperadorDivision,
        OperadorPotencia,
        ParentesisIzquierdo,
        ParentesisDerecho,
        Fin
    }
}