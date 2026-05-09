using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorExpresionesCFG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tabControlPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //funcion que se ejecuta al hacer click en evaluar.
        private void buttonEvaluar_Click(object sender, EventArgs e)
        {
            try
            {
                EvaluadorExpresiones evaluador = new EvaluadorExpresiones(); 

                double resultado = evaluador.Evaluar(textBoxExpresionMatematica.Text);  //esta linea toma la expresion que el usario escribio y la manda al evaluador para que la procese y devuelva el resultado

                textBoxResultado.Text = resultado.ToString(); //ponemos el resultado en la caja de resultado
            }
            catch (Exception error)
            {
                textBoxResultado.Clear();
                MessageBox.Show(error.Message, "Error en la expresión");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "X";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "^";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "-";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "/";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "1";
        }

        private void Siete_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "7";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "0";
        }

        private void Doble_Cero_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "00";
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "3";
        }

        private void Cuatro_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "4";
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "6";
        }

        private void Ocho_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "8";
        }

        private void Nueve_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "9";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "+";
        }

        private void Parentesis_izq_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += "(";
        }

        private void Parentesis_der_Click(object sender, EventArgs e)
        {
            textBoxExpresionMatematica.Text += ")";
        }

        //Funcion que limpia el campo de texto de la expresion matematica
        private void LimpiarCampos() 
        {
            textBoxExpresionMatematica.Text = String.Empty;
        }

        private void AC_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void textBoxExpresionMatematica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '*')
            {
                e.KeyChar = 'X';
            }
            else if (e.KeyChar == 'x')
            {
                e.KeyChar = 'X';
            }
        }
    }
}
