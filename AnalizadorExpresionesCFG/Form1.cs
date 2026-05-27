using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AnalizadorExpresionesCFG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridViewDerivacion.AllowUserToAddRows = false;
            dataGridViewDerivacion.AllowUserToDeleteRows = false;
            dataGridViewDerivacion.ReadOnly = true;
            dataGridViewDerivacion.RowHeadersVisible = false;
        }

        //LOGICA
        private void AgregarTexto(string texto)
        {
            textBoxExpresionMatematica.Text += texto;
        }

        private void MostrarTokens(List<Token>tokens)
        {
            dataGridViewTokens.Rows.Clear();
            foreach (var token in tokens)
            {
                dataGridViewTokens.Rows.Add(token.Valor, token.Tipo.ToString(), token.Posicion);
            }
        }

        //FUNCION PARA LIMPIAR LOS CAMPOS DE TEXTO, EL DATA GRID VIEW DE TOKENS, EL TREEVIEW DE DERIVACION Y EL DATA GRID VIEW DE DERIVACION
        private void LimpiarCampos()
        {
            textBoxExpresionMatematica.Text = string.Empty;
            textBoxResultado.Text = string.Empty;

            if (dataGridViewTokens != null)
            {
                dataGridViewTokens.Rows.Clear();
            }

            if (treeViewDerivacion != null)
            {
                treeViewDerivacion.Nodes.Clear();
            }

            if (dataGridViewDerivacion != null)
            {
                dataGridViewDerivacion.Rows.Clear();
                dataGridViewDerivacion.Columns.Clear();
            }
        }

        private void EvaluarExpresionDesdeFormulario()
        {
            if (string.IsNullOrWhiteSpace(textBoxExpresionMatematica.Text))
            {
                MessageBox.Show("La expresión no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dataGridViewTokens.Rows.Clear();
                textBoxResultado.Clear();

                AnalizadorLexico lexer = new AnalizadorLexico();
                List<Token> listaTokens = lexer.Analizar(textBoxExpresionMatematica.Text);

                MostrarTokens(listaTokens);

                AnalizadorSintactico parser = new AnalizadorSintactico(listaTokens);
                double resultado = parser.Parsear();

                // Mostrar el árbol de derivación en el TreeView
                MostrarArbol(parser.RaizArbol);
                MostrarTablaDerivacion(parser.HistorialDerivacion);

                textBoxResultado.Text = resultado.ToString();

                string entradaHistorial = textBoxExpresionMatematica.Text + " = " + resultado.ToString();
                listBoxHistorial.Items.Add(entradaHistorial);
            }
            catch (Exception error)
            {
                textBoxResultado.Clear();
                treeViewDerivacion.Nodes.Clear(); // Limpiar el TreeView en caso de error
                dataGridViewDerivacion.Rows.Clear();

                MessageBox.Show(error.Message, "Error en la expresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //INTERFAZ
        private void btnEvaluar_Click(object sender, EventArgs e) { EvaluarExpresionDesdeFormulario(); }
        private void btnLimpiar_Click(object sender, EventArgs e) { LimpiarCampos(); }
        private void btnAC_Click(object sender, EventArgs e) { LimpiarCampos(); }

        //BOTONES - OPERACIONES
        private void btnSuma_Click(object sender, EventArgs e) { AgregarTexto("+"); }
        private void btnResta_Click(object sender, EventArgs e) { AgregarTexto("-"); }
        private void btnMultiplicar_Click(object sender, EventArgs e) { AgregarTexto("X"); }
        private void btnPunto_Click(object sender, EventArgs e) { AgregarTexto("."); }
        private void btnDivision_Click(object sender, EventArgs e) { AgregarTexto("/"); }
        private void btnPotencia_Click(object sender, EventArgs e) { AgregarTexto("^"); }
        private void btnParIzq_Click(object sender, EventArgs e) { AgregarTexto("("); }
        private void btnParDer_Click(object sender, EventArgs e) { AgregarTexto(")"); }

        //BOTONES - NUMEROS
        private void btnNum0_Click(object sender, EventArgs e) { AgregarTexto("0"); }
        private void btnNum00_Click(object sender, EventArgs e) { AgregarTexto("00"); }
        private void btnNum1_Click(object sender, EventArgs e) { AgregarTexto("1"); }
        private void btnNum2_Click(object sender, EventArgs e) { AgregarTexto("2"); }
        private void btnNum3_Click(object sender, EventArgs e) { AgregarTexto("3"); }
        private void btnNum4_Click(object sender, EventArgs e) { AgregarTexto("4"); }
        private void btnNum5_Click(object sender, EventArgs e) { AgregarTexto("5"); }
        private void btnNum6_Click(object sender, EventArgs e) { AgregarTexto("6"); }
        private void btnNum7_Click(object sender, EventArgs e) { AgregarTexto("7"); }
        private void btnNum8_Click(object sender, EventArgs e) { AgregarTexto("8"); }
        private void btnNum9_Click(object sender, EventArgs e) { AgregarTexto("9"); }
        

        private void textBoxExpresionMatematica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '*' || e.KeyChar == 'x') e.KeyChar = 'X';
        }

        private void dataGridViewTokens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeViewDerivacion_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        
        //FUNCION PARA MOSTRAR EL ARBOL DE DERIVACION EN EL TREEVIEW
        private void MostrarArbol(NodoDerivacion raiz)
        {
            treeViewDerivacion.Nodes.Clear();

            if (raiz == null)
            {
                return;
            }

            TreeNode nodoPrincipal = ConvertirNodoATreeNode(raiz);
            treeViewDerivacion.Nodes.Add(nodoPrincipal);
            treeViewDerivacion.ExpandAll();
        }

        //FUNCION RECURSIVA PARA CONVERTIR LOS NODOS DE DERIVACION EN NODOS VISUALES PARA EL TREEVIEW
        private TreeNode ConvertirNodoATreeNode(NodoDerivacion nodo)
        {
            TreeNode nodoVisual = new TreeNode(nodo.Valor);

            foreach (NodoDerivacion hijo in nodo.Hijos)
            {
                nodoVisual.Nodes.Add(ConvertirNodoATreeNode(hijo));
            }

            return nodoVisual;
        }

        private void MostrarTablaDerivacion(List<PasoDerivacion> pasos)
        {
            dataGridViewDerivacion.Rows.Clear();
            dataGridViewDerivacion.Columns.Clear();

            dataGridViewDerivacion.Columns.Add("Regla", "Regla aplicada");
            dataGridViewDerivacion.Columns.Add("ExpresionActual", "Expresión actual");

            foreach (PasoDerivacion paso in pasos)
            {
                dataGridViewDerivacion.Rows.Add(paso.Regla, paso.ExpresionActual);
            }

            dataGridViewDerivacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}