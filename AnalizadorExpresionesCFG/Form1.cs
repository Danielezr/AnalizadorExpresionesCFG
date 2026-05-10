using System;
using System.Windows.Forms;

namespace AnalizadorExpresionesCFG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //LOGICA
        private void AgregarTexto(string texto)
        {
            textBoxExpresionMatematica.Text += texto;
        }

        private void LimpiarCampos()
        {
            textBoxExpresionMatematica.Text = string.Empty;
            textBoxResultado.Text = string.Empty;
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
                EvaluadorExpresiones evaluador = new EvaluadorExpresiones();
                double resultado = evaluador.Evaluar(textBoxExpresionMatematica.Text);
                textBoxResultado.Text = resultado.ToString();

                string entradaHistorial = textBoxExpresionMatematica.Text + " = " + resultado.ToString();
                listBoxHistorial.Items.Add(entradaHistorial);
            }
            catch (Exception error)
            {
                textBoxResultado.Clear();
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
    }
}