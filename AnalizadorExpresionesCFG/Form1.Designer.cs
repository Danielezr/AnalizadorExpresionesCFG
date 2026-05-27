namespace AnalizadorExpresionesCFG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxExpresionMatematica = new System.Windows.Forms.TextBox();
            this.buttonEvaluar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageExpresionMatematica = new System.Windows.Forms.TabPage();
            this.Doble_Cero = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.Potencia = new System.Windows.Forms.Button();
            this.AC = new System.Windows.Forms.Button();
            this.Parentesis_der = new System.Windows.Forms.Button();
            this.Parentesis_izq = new System.Windows.Forms.Button();
            this.Dos = new System.Windows.Forms.Button();
            this.Uno = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Tres = new System.Windows.Forms.Button();
            this.Seis = new System.Windows.Forms.Button();
            this.Cinco = new System.Windows.Forms.Button();
            this.Cuatro = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.Nueve = new System.Windows.Forms.Button();
            this.Ocho = new System.Windows.Forms.Button();
            this.Siete = new System.Windows.Forms.Button();
            this.tabPageArbolDerivacion = new System.Windows.Forms.TabPage();
            this.tabPageTablaDerivacion = new System.Windows.Forms.TabPage();
            this.tabPageHistorialExpresiones = new System.Windows.Forms.TabPage();
            this.listBoxHistorial = new System.Windows.Forms.ListBox();
            this.labelHistorial = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewTokens = new System.Windows.Forms.DataGridView();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelExpresion = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.treeViewDerivacion = new System.Windows.Forms.TreeView();
            this.dataGridViewDerivacion = new System.Windows.Forms.DataGridView();
            this.tabPrincipal.SuspendLayout();
            this.tabPageExpresionMatematica.SuspendLayout();
            this.tabPageArbolDerivacion.SuspendLayout();
            this.tabPageTablaDerivacion.SuspendLayout();
            this.tabPageHistorialExpresiones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTokens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDerivacion)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxExpresionMatematica
            // 
            this.textBoxExpresionMatematica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxExpresionMatematica.Location = new System.Drawing.Point(57, 38);
            this.textBoxExpresionMatematica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExpresionMatematica.Name = "textBoxExpresionMatematica";
            this.textBoxExpresionMatematica.Size = new System.Drawing.Size(552, 28);
            this.textBoxExpresionMatematica.TabIndex = 0;
            this.textBoxExpresionMatematica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExpresionMatematica_KeyPress);
            // 
            // buttonEvaluar
            // 
            this.buttonEvaluar.Location = new System.Drawing.Point(629, 38);
            this.buttonEvaluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEvaluar.Name = "buttonEvaluar";
            this.buttonEvaluar.Size = new System.Drawing.Size(117, 28);
            this.buttonEvaluar.TabIndex = 1;
            this.buttonEvaluar.Text = "Evaluar";
            this.buttonEvaluar.UseVisualStyleBackColor = true;
            this.buttonEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(629, 71);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(117, 28);
            this.buttonLimpiar.TabIndex = 2;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxResultado.Location = new System.Drawing.Point(56, 117);
            this.textBoxResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ReadOnly = true;
            this.textBoxResultado.Size = new System.Drawing.Size(553, 26);
            this.textBoxResultado.TabIndex = 3;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPageExpresionMatematica);
            this.tabPrincipal.Controls.Add(this.tabPageArbolDerivacion);
            this.tabPrincipal.Controls.Add(this.tabPageTablaDerivacion);
            this.tabPrincipal.Controls.Add(this.tabPageHistorialExpresiones);
            this.tabPrincipal.Controls.Add(this.tabPage1);
            this.tabPrincipal.Location = new System.Drawing.Point(24, 167);
            this.tabPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(749, 314);
            this.tabPrincipal.TabIndex = 4;
            // 
            // tabPageExpresionMatematica
            // 
            this.tabPageExpresionMatematica.Controls.Add(this.Doble_Cero);
            this.tabPageExpresionMatematica.Controls.Add(this.btnNum0);
            this.tabPageExpresionMatematica.Controls.Add(this.button10);
            this.tabPageExpresionMatematica.Controls.Add(this.button13);
            this.tabPageExpresionMatematica.Controls.Add(this.Potencia);
            this.tabPageExpresionMatematica.Controls.Add(this.AC);
            this.tabPageExpresionMatematica.Controls.Add(this.Parentesis_der);
            this.tabPageExpresionMatematica.Controls.Add(this.Parentesis_izq);
            this.tabPageExpresionMatematica.Controls.Add(this.Dos);
            this.tabPageExpresionMatematica.Controls.Add(this.Uno);
            this.tabPageExpresionMatematica.Controls.Add(this.Resta);
            this.tabPageExpresionMatematica.Controls.Add(this.Tres);
            this.tabPageExpresionMatematica.Controls.Add(this.Seis);
            this.tabPageExpresionMatematica.Controls.Add(this.Cinco);
            this.tabPageExpresionMatematica.Controls.Add(this.Cuatro);
            this.tabPageExpresionMatematica.Controls.Add(this.Division);
            this.tabPageExpresionMatematica.Controls.Add(this.Multiplicacion);
            this.tabPageExpresionMatematica.Controls.Add(this.Nueve);
            this.tabPageExpresionMatematica.Controls.Add(this.Ocho);
            this.tabPageExpresionMatematica.Controls.Add(this.Siete);
            this.tabPageExpresionMatematica.Location = new System.Drawing.Point(4, 25);
            this.tabPageExpresionMatematica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageExpresionMatematica.Name = "tabPageExpresionMatematica";
            this.tabPageExpresionMatematica.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageExpresionMatematica.Size = new System.Drawing.Size(741, 285);
            this.tabPageExpresionMatematica.TabIndex = 0;
            this.tabPageExpresionMatematica.Text = "Expresión matemática";
            this.tabPageExpresionMatematica.UseVisualStyleBackColor = true;
            // 
            // Doble_Cero
            // 
            this.Doble_Cero.Location = new System.Drawing.Point(259, 210);
            this.Doble_Cero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Doble_Cero.Name = "Doble_Cero";
            this.Doble_Cero.Size = new System.Drawing.Size(105, 39);
            this.Doble_Cero.TabIndex = 19;
            this.Doble_Cero.Text = "00";
            this.Doble_Cero.UseVisualStyleBackColor = true;
            this.Doble_Cero.Click += new System.EventHandler(this.btnNum00_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.AccessibleName = "btnNum0";
            this.btnNum0.Location = new System.Drawing.Point(140, 210);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(105, 39);
            this.btnNum0.TabIndex = 18;
            this.btnNum0.Tag = "btnNum0";
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(497, 212);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 39);
            this.button10.TabIndex = 17;
            this.button10.Text = "+";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(379, 210);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(105, 39);
            this.button13.TabIndex = 16;
            this.button13.Text = ".";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // Potencia
            // 
            this.Potencia.Location = new System.Drawing.Point(497, 28);
            this.Potencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(105, 39);
            this.Potencia.TabIndex = 15;
            this.Potencia.Text = "^";
            this.Potencia.UseVisualStyleBackColor = true;
            this.Potencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // AC
            // 
            this.AC.Location = new System.Drawing.Point(379, 28);
            this.AC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(105, 39);
            this.AC.TabIndex = 14;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = true;
            this.AC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // Parentesis_der
            // 
            this.Parentesis_der.Location = new System.Drawing.Point(259, 28);
            this.Parentesis_der.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Parentesis_der.Name = "Parentesis_der";
            this.Parentesis_der.Size = new System.Drawing.Size(105, 39);
            this.Parentesis_der.TabIndex = 13;
            this.Parentesis_der.Text = ")";
            this.Parentesis_der.UseVisualStyleBackColor = true;
            this.Parentesis_der.Click += new System.EventHandler(this.btnParDer_Click);
            // 
            // Parentesis_izq
            // 
            this.Parentesis_izq.Location = new System.Drawing.Point(140, 28);
            this.Parentesis_izq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Parentesis_izq.Name = "Parentesis_izq";
            this.Parentesis_izq.Size = new System.Drawing.Size(105, 39);
            this.Parentesis_izq.TabIndex = 12;
            this.Parentesis_izq.Tag = "";
            this.Parentesis_izq.Text = "(";
            this.Parentesis_izq.UseVisualStyleBackColor = true;
            this.Parentesis_izq.Click += new System.EventHandler(this.btnParIzq_Click);
            // 
            // Dos
            // 
            this.Dos.Location = new System.Drawing.Point(259, 165);
            this.Dos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dos.Name = "Dos";
            this.Dos.Size = new System.Drawing.Size(105, 39);
            this.Dos.TabIndex = 11;
            this.Dos.Text = "2";
            this.Dos.UseVisualStyleBackColor = true;
            this.Dos.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // Uno
            // 
            this.Uno.Location = new System.Drawing.Point(140, 165);
            this.Uno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Uno.Name = "Uno";
            this.Uno.Size = new System.Drawing.Size(105, 39);
            this.Uno.TabIndex = 10;
            this.Uno.Text = "1";
            this.Uno.UseVisualStyleBackColor = true;
            this.Uno.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // Resta
            // 
            this.Resta.Location = new System.Drawing.Point(497, 166);
            this.Resta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(105, 39);
            this.Resta.TabIndex = 9;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // Tres
            // 
            this.Tres.Location = new System.Drawing.Point(379, 166);
            this.Tres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(105, 39);
            this.Tres.TabIndex = 8;
            this.Tres.Text = "3";
            this.Tres.UseVisualStyleBackColor = true;
            this.Tres.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // Seis
            // 
            this.Seis.Location = new System.Drawing.Point(379, 121);
            this.Seis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Seis.Name = "Seis";
            this.Seis.Size = new System.Drawing.Size(105, 39);
            this.Seis.TabIndex = 7;
            this.Seis.Text = "6";
            this.Seis.UseVisualStyleBackColor = true;
            this.Seis.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // Cinco
            // 
            this.Cinco.Location = new System.Drawing.Point(259, 121);
            this.Cinco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cinco.Name = "Cinco";
            this.Cinco.Size = new System.Drawing.Size(105, 39);
            this.Cinco.TabIndex = 6;
            this.Cinco.Text = "5";
            this.Cinco.UseVisualStyleBackColor = true;
            this.Cinco.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // Cuatro
            // 
            this.Cuatro.Location = new System.Drawing.Point(140, 121);
            this.Cuatro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cuatro.Name = "Cuatro";
            this.Cuatro.Size = new System.Drawing.Size(105, 39);
            this.Cuatro.TabIndex = 5;
            this.Cuatro.Text = "4";
            this.Cuatro.UseVisualStyleBackColor = true;
            this.Cuatro.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(497, 74);
            this.Division.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(105, 39);
            this.Division.TabIndex = 4;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.Location = new System.Drawing.Point(497, 121);
            this.Multiplicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(105, 39);
            this.Multiplicacion.TabIndex = 3;
            this.Multiplicacion.Text = "X";
            this.Multiplicacion.UseVisualStyleBackColor = true;
            this.Multiplicacion.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // Nueve
            // 
            this.Nueve.Location = new System.Drawing.Point(379, 74);
            this.Nueve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nueve.Name = "Nueve";
            this.Nueve.Size = new System.Drawing.Size(105, 39);
            this.Nueve.TabIndex = 2;
            this.Nueve.Text = "9";
            this.Nueve.UseVisualStyleBackColor = true;
            this.Nueve.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // Ocho
            // 
            this.Ocho.Location = new System.Drawing.Point(259, 74);
            this.Ocho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ocho.Name = "Ocho";
            this.Ocho.Size = new System.Drawing.Size(105, 39);
            this.Ocho.TabIndex = 1;
            this.Ocho.Text = "8";
            this.Ocho.UseVisualStyleBackColor = true;
            this.Ocho.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // Siete
            // 
            this.Siete.Location = new System.Drawing.Point(140, 74);
            this.Siete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Siete.Name = "Siete";
            this.Siete.Size = new System.Drawing.Size(105, 39);
            this.Siete.TabIndex = 0;
            this.Siete.Text = "7";
            this.Siete.UseVisualStyleBackColor = true;
            this.Siete.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // tabPageArbolDerivacion
            // 
            this.tabPageArbolDerivacion.Controls.Add(this.treeViewDerivacion);
            this.tabPageArbolDerivacion.Location = new System.Drawing.Point(4, 25);
            this.tabPageArbolDerivacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageArbolDerivacion.Name = "tabPageArbolDerivacion";
            this.tabPageArbolDerivacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageArbolDerivacion.Size = new System.Drawing.Size(741, 285);
            this.tabPageArbolDerivacion.TabIndex = 1;
            this.tabPageArbolDerivacion.Text = "Árbol de derivación";
            this.tabPageArbolDerivacion.UseVisualStyleBackColor = true;
            // 
            // tabPageTablaDerivacion
            // 
            this.tabPageTablaDerivacion.Controls.Add(this.dataGridViewDerivacion);
            this.tabPageTablaDerivacion.Location = new System.Drawing.Point(4, 25);
            this.tabPageTablaDerivacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTablaDerivacion.Name = "tabPageTablaDerivacion";
            this.tabPageTablaDerivacion.Size = new System.Drawing.Size(741, 285);
            this.tabPageTablaDerivacion.TabIndex = 2;
            this.tabPageTablaDerivacion.Text = "Tabla de derivación";
            this.tabPageTablaDerivacion.UseVisualStyleBackColor = true;
            // 
            // tabPageHistorialExpresiones
            // 
            this.tabPageHistorialExpresiones.Controls.Add(this.listBoxHistorial);
            this.tabPageHistorialExpresiones.Controls.Add(this.labelHistorial);
            this.tabPageHistorialExpresiones.Location = new System.Drawing.Point(4, 25);
            this.tabPageHistorialExpresiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageHistorialExpresiones.Name = "tabPageHistorialExpresiones";
            this.tabPageHistorialExpresiones.Size = new System.Drawing.Size(741, 285);
            this.tabPageHistorialExpresiones.TabIndex = 3;
            this.tabPageHistorialExpresiones.Text = "Historial de expresiones";
            this.tabPageHistorialExpresiones.UseVisualStyleBackColor = true;
            // 
            // listBoxHistorial
            // 
            this.listBoxHistorial.FormattingEnabled = true;
            this.listBoxHistorial.ItemHeight = 16;
            this.listBoxHistorial.Location = new System.Drawing.Point(19, 38);
            this.listBoxHistorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxHistorial.Name = "listBoxHistorial";
            this.listBoxHistorial.Size = new System.Drawing.Size(700, 228);
            this.listBoxHistorial.TabIndex = 1;
            // 
            // labelHistorial
            // 
            this.labelHistorial.AutoSize = true;
            this.labelHistorial.Location = new System.Drawing.Point(261, 12);
            this.labelHistorial.Name = "labelHistorial";
            this.labelHistorial.Size = new System.Drawing.Size(219, 16);
            this.labelHistorial.TabIndex = 0;
            this.labelHistorial.Text = "Historial de expresiones evaluadas";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewTokens);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(741, 285);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Analizador Lexico";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTokens
            // 
            this.dataGridViewTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valor,
            this.Tipo,
            this.Posicion});
            this.dataGridViewTokens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTokens.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewTokens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTokens.Name = "dataGridViewTokens";
            this.dataGridViewTokens.RowHeadersVisible = false;
            this.dataGridViewTokens.RowHeadersWidth = 51;
            this.dataGridViewTokens.RowTemplate.Height = 24;
            this.dataGridViewTokens.Size = new System.Drawing.Size(735, 281);
            this.dataGridViewTokens.TabIndex = 20;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.MinimumWidth = 6;
            this.Posicion.Name = "Posicion";
            // 
            // labelExpresion
            // 
            this.labelExpresion.AutoSize = true;
            this.labelExpresion.Location = new System.Drawing.Point(53, 18);
            this.labelExpresion.Name = "labelExpresion";
            this.labelExpresion.Size = new System.Drawing.Size(140, 16);
            this.labelExpresion.TabIndex = 5;
            this.labelExpresion.Text = "Expresión matemática";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(285, 82);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(69, 16);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "Resultado";
            // 
            // treeViewDerivacion
            // 
            this.treeViewDerivacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDerivacion.Location = new System.Drawing.Point(3, 2);
            this.treeViewDerivacion.Name = "treeViewDerivacion";
            this.treeViewDerivacion.Size = new System.Drawing.Size(735, 281);
            this.treeViewDerivacion.TabIndex = 0;
            this.treeViewDerivacion.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDerivacion_AfterSelect);
            // 
            // dataGridViewDerivacion
            // 
            this.dataGridViewDerivacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDerivacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDerivacion.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDerivacion.Name = "dataGridViewDerivacion";
            this.dataGridViewDerivacion.RowHeadersWidth = 51;
            this.dataGridViewDerivacion.RowTemplate.Height = 24;
            this.dataGridViewDerivacion.Size = new System.Drawing.Size(741, 285);
            this.dataGridViewDerivacion.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelExpresion);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonEvaluar);
            this.Controls.Add(this.textBoxExpresionMatematica);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Evaluación de expresiones matemáticas";
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageExpresionMatematica.ResumeLayout(false);
            this.tabPageArbolDerivacion.ResumeLayout(false);
            this.tabPageTablaDerivacion.ResumeLayout(false);
            this.tabPageHistorialExpresiones.ResumeLayout(false);
            this.tabPageHistorialExpresiones.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTokens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDerivacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxExpresionMatematica;
        private System.Windows.Forms.Button buttonEvaluar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPageExpresionMatematica;
        private System.Windows.Forms.TabPage tabPageArbolDerivacion;
        private System.Windows.Forms.TabPage tabPageTablaDerivacion;
        private System.Windows.Forms.TabPage tabPageHistorialExpresiones;
        private System.Windows.Forms.Label labelExpresion;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelHistorial;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button Nueve;
        private System.Windows.Forms.Button Ocho;
        private System.Windows.Forms.Button Siete;
        private System.Windows.Forms.Button Potencia;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button Parentesis_der;
        private System.Windows.Forms.Button Parentesis_izq;
        private System.Windows.Forms.Button Dos;
        private System.Windows.Forms.Button Uno;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Tres;
        private System.Windows.Forms.Button Seis;
        private System.Windows.Forms.Button Cinco;
        private System.Windows.Forms.Button Cuatro;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Doble_Cero;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ListBox listBoxHistorial;
        private System.Windows.Forms.DataGridView dataGridViewTokens;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.TreeView treeViewDerivacion;
        private System.Windows.Forms.DataGridView dataGridViewDerivacion;
    }
}

