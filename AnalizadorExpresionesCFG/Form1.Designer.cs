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
            this.tabPageArbolDerivacion = new System.Windows.Forms.TabPage();
            this.tabPageTablaDerivacion = new System.Windows.Forms.TabPage();
            this.tabPageHistorialExpresiones = new System.Windows.Forms.TabPage();
            this.labelExpresion = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelHistorial = new System.Windows.Forms.Label();
            this.tabPrincipal.SuspendLayout();
            this.tabPageHistorialExpresiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxExpresionMatematica
            // 
            this.textBoxExpresionMatematica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxExpresionMatematica.Location = new System.Drawing.Point(57, 38);
            this.textBoxExpresionMatematica.Name = "textBoxExpresionMatematica";
            this.textBoxExpresionMatematica.Size = new System.Drawing.Size(552, 28);
            this.textBoxExpresionMatematica.TabIndex = 0;
            // 
            // buttonEvaluar
            // 
            this.buttonEvaluar.Location = new System.Drawing.Point(630, 38);
            this.buttonEvaluar.Name = "buttonEvaluar";
            this.buttonEvaluar.Size = new System.Drawing.Size(117, 28);
            this.buttonEvaluar.TabIndex = 1;
            this.buttonEvaluar.Text = "Evaluar";
            this.buttonEvaluar.UseVisualStyleBackColor = true;
            this.buttonEvaluar.Click += new System.EventHandler(this.buttonEvaluar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(630, 72);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(117, 28);
            this.buttonLimpiar.TabIndex = 2;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxResultado.Location = new System.Drawing.Point(152, 117);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ReadOnly = true;
            this.textBoxResultado.Size = new System.Drawing.Size(390, 26);
            this.textBoxResultado.TabIndex = 3;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPageExpresionMatematica);
            this.tabPrincipal.Controls.Add(this.tabPageArbolDerivacion);
            this.tabPrincipal.Controls.Add(this.tabPageTablaDerivacion);
            this.tabPrincipal.Controls.Add(this.tabPageHistorialExpresiones);
            this.tabPrincipal.Location = new System.Drawing.Point(24, 168);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(749, 314);
            this.tabPrincipal.TabIndex = 4;
            // 
            // tabPageExpresionMatematica
            // 
            this.tabPageExpresionMatematica.Location = new System.Drawing.Point(4, 25);
            this.tabPageExpresionMatematica.Name = "tabPageExpresionMatematica";
            this.tabPageExpresionMatematica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExpresionMatematica.Size = new System.Drawing.Size(741, 285);
            this.tabPageExpresionMatematica.TabIndex = 0;
            this.tabPageExpresionMatematica.Text = "Expresión matemática";
            this.tabPageExpresionMatematica.UseVisualStyleBackColor = true;
            // 
            // tabPageArbolDerivacion
            // 
            this.tabPageArbolDerivacion.Location = new System.Drawing.Point(4, 25);
            this.tabPageArbolDerivacion.Name = "tabPageArbolDerivacion";
            this.tabPageArbolDerivacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArbolDerivacion.Size = new System.Drawing.Size(741, 285);
            this.tabPageArbolDerivacion.TabIndex = 1;
            this.tabPageArbolDerivacion.Text = "Árbol de derivación";
            this.tabPageArbolDerivacion.UseVisualStyleBackColor = true;
            this.tabPageArbolDerivacion.Click += new System.EventHandler(this.tabControlPrincipal_Click);
            // 
            // tabPageTablaDerivacion
            // 
            this.tabPageTablaDerivacion.Location = new System.Drawing.Point(4, 25);
            this.tabPageTablaDerivacion.Name = "tabPageTablaDerivacion";
            this.tabPageTablaDerivacion.Size = new System.Drawing.Size(741, 230);
            this.tabPageTablaDerivacion.TabIndex = 2;
            this.tabPageTablaDerivacion.Text = "Tabla de derivación";
            this.tabPageTablaDerivacion.UseVisualStyleBackColor = true;
            // 
            // tabPageHistorialExpresiones
            // 
            this.tabPageHistorialExpresiones.Controls.Add(this.labelHistorial);
            this.tabPageHistorialExpresiones.Location = new System.Drawing.Point(4, 25);
            this.tabPageHistorialExpresiones.Name = "tabPageHistorialExpresiones";
            this.tabPageHistorialExpresiones.Size = new System.Drawing.Size(741, 285);
            this.tabPageHistorialExpresiones.TabIndex = 3;
            this.tabPageHistorialExpresiones.Text = "Historial de expresiones";
            this.tabPageHistorialExpresiones.UseVisualStyleBackColor = true;
            // 
            // labelExpresion
            // 
            this.labelExpresion.AutoSize = true;
            this.labelExpresion.Location = new System.Drawing.Point(54, 19);
            this.labelExpresion.Name = "labelExpresion";
            this.labelExpresion.Size = new System.Drawing.Size(140, 16);
            this.labelExpresion.TabIndex = 5;
            this.labelExpresion.Text = "Expresión matemática";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(150, 98);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(69, 16);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelHistorial
            // 
            this.labelHistorial.AutoSize = true;
            this.labelHistorial.Location = new System.Drawing.Point(254, 21);
            this.labelHistorial.Name = "labelHistorial";
            this.labelHistorial.Size = new System.Drawing.Size(219, 16);
            this.labelHistorial.TabIndex = 0;
            this.labelHistorial.Text = "Historial de expresiones evaluadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelExpresion);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonEvaluar);
            this.Controls.Add(this.textBoxExpresionMatematica);
            this.Name = "Form1";
            this.Text = "Evaluación de expresiones matemáticas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageHistorialExpresiones.ResumeLayout(false);
            this.tabPageHistorialExpresiones.PerformLayout();
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
    }
}

