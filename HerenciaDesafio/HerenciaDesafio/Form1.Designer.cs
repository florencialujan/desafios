namespace HerenciaDesafio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.precioBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nuevo = new System.Windows.Forms.RadioButton();
            this.usado = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.sPiso = new System.Windows.Forms.RadioButton();
            this.sLocal = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.nPiso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cantVentanas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BotonCalcular = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pCalculado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para cotizar la propiedad, rellene correctamente los siguientes campos:";
            // 
            // direccion
            // 
            this.direccion.BackColor = System.Drawing.SystemColors.Menu;
            this.direccion.Location = new System.Drawing.Point(18, 80);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(203, 20);
            this.direccion.TabIndex = 1;
            this.direccion.TextChanged += new System.EventHandler(this.direccion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion:";
            // 
            // precioBase
            // 
            this.precioBase.BackColor = System.Drawing.SystemColors.Menu;
            this.precioBase.Location = new System.Drawing.Point(450, 80);
            this.precioBase.Name = "precioBase";
            this.precioBase.Size = new System.Drawing.Size(83, 20);
            this.precioBase.TabIndex = 3;
            this.precioBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.precioBase.TextChanged += new System.EventHandler(this.precioBase_TextChanged);
            this.precioBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compruebaSoloNumeros);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = " Precio base:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad de m2:";
            // 
            // m2
            // 
            this.m2.BackColor = System.Drawing.SystemColors.Menu;
            this.m2.Location = new System.Drawing.Point(286, 80);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(76, 20);
            this.m2.TabIndex = 6;
            this.m2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m2.TextChanged += new System.EventHandler(this.m2_TextChanged);
            this.m2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compruebaSoloNumeros);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estado de Inmueble:";
            // 
            // nuevo
            // 
            this.nuevo.AutoSize = true;
            this.nuevo.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo.Location = new System.Drawing.Point(34, 24);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(115, 22);
            this.nuevo.TabIndex = 8;
            this.nuevo.TabStop = true;
            this.nuevo.Text = "Nuevo (-15 años)";
            this.nuevo.UseVisualStyleBackColor = true;
            // 
            // usado
            // 
            this.usado.AutoSize = true;
            this.usado.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usado.Location = new System.Drawing.Point(203, 24);
            this.usado.Name = "usado";
            this.usado.Size = new System.Drawing.Size(117, 22);
            this.usado.TabIndex = 9;
            this.usado.TabStop = true;
            this.usado.Text = "Usado (+15 años)";
            this.usado.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de Inmueble:";
            // 
            // sPiso
            // 
            this.sPiso.AutoSize = true;
            this.sPiso.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPiso.Location = new System.Drawing.Point(34, 12);
            this.sPiso.Name = "sPiso";
            this.sPiso.Size = new System.Drawing.Size(48, 22);
            this.sPiso.TabIndex = 11;
            this.sPiso.Text = "Piso";
            this.sPiso.UseVisualStyleBackColor = true;
            this.sPiso.CheckedChanged += new System.EventHandler(this.sPiso_CheckedChanged);
            // 
            // sLocal
            // 
            this.sLocal.AutoSize = true;
            this.sLocal.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLocal.Location = new System.Drawing.Point(203, 12);
            this.sLocal.Name = "sLocal";
            this.sLocal.Size = new System.Drawing.Size(52, 22);
            this.sLocal.TabIndex = 12;
            this.sLocal.Text = "Local";
            this.sLocal.UseVisualStyleBackColor = true;
            this.sLocal.CheckedChanged += new System.EventHandler(this.sLocal_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ingrese el n° de piso:";
            // 
            // nPiso
            // 
            this.nPiso.BackColor = System.Drawing.SystemColors.Menu;
            this.nPiso.Location = new System.Drawing.Point(305, 222);
            this.nPiso.Name = "nPiso";
            this.nPiso.Size = new System.Drawing.Size(40, 20);
            this.nPiso.TabIndex = 14;
            this.nPiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compruebaSoloNumeros);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(363, 221);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ingrese la cant. de ventanas:";
            // 
            // cantVentanas
            // 
            this.cantVentanas.BackColor = System.Drawing.SystemColors.Menu;
            this.cantVentanas.Location = new System.Drawing.Point(521, 222);
            this.cantVentanas.Name = "cantVentanas";
            this.cantVentanas.Size = new System.Drawing.Size(40, 20);
            this.cantVentanas.TabIndex = 16;
            this.cantVentanas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cantVentanas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compruebaSoloNumeros);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuevo);
            this.groupBox1.Controls.Add(this.usado);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(210, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 61);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sPiso);
            this.groupBox2.Controls.Add(this.sLocal);
            this.groupBox2.Location = new System.Drawing.Point(210, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 40);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCalcular.Location = new System.Drawing.Point(240, 277);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(132, 30);
            this.BotonCalcular.TabIndex = 19;
            this.BotonCalcular.Text = "Calcular precio ";
            this.BotonCalcular.UseVisualStyleBackColor = true;
            this.BotonCalcular.Click += new System.EventHandler(this.BotonCalcular_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(410, 283);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Precio calculado:";
            // 
            // pCalculado
            // 
            this.pCalculado.BackColor = System.Drawing.SystemColors.Menu;
            this.pCalculado.Location = new System.Drawing.Point(507, 283);
            this.pCalculado.Name = "pCalculado";
            this.pCalculado.Size = new System.Drawing.Size(73, 20);
            this.pCalculado.TabIndex = 21;
            this.pCalculado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(592, 339);
            this.Controls.Add(this.pCalculado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BotonCalcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cantVentanas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nPiso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.precioBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizador de Inmueble";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox direccion;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precioBase;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m2;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton nuevo;
        private System.Windows.Forms.RadioButton usado;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton sPiso;
        private System.Windows.Forms.RadioButton sLocal;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nPiso;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cantVentanas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BotonCalcular;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pCalculado;
    }
}

