namespace Calcular_Area_Trigonometrica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textResCuad = new System.Windows.Forms.TextBox();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textVal4 = new System.Windows.Forms.TextBox();
            this.textVal3 = new System.Windows.Forms.TextBox();
            this.textVal2 = new System.Windows.Forms.TextBox();
            this.textVal1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpRect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textResRect = new System.Windows.Forms.TextBox();
            this.btnCalcRect = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.textBase = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarTriang = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textResultTriang = new System.Windows.Forms.TextBox();
            this.btnCalcularTriang = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textAltTriang = new System.Windows.Forms.TextBox();
            this.textBaseTriang = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLimpCiruculo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textResultCircul = new System.Windows.Forms.TextBox();
            this.btnCalculCirculo = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textRadio = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textResCuad);
            this.groupBox1.Controls.Add(this.btnCuadrado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textVal4);
            this.groupBox1.Controls.Add(this.textVal3);
            this.groupBox1.Controls.Add(this.textVal2);
            this.groupBox1.Controls.Add(this.textVal1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area de un Cuadrado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(189, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpiar Campos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(163, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "El Resultado es:";
            // 
            // textResCuad
            // 
            this.textResCuad.BackColor = System.Drawing.Color.White;
            this.textResCuad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textResCuad.Location = new System.Drawing.Point(248, 43);
            this.textResCuad.Multiline = true;
            this.textResCuad.Name = "textResCuad";
            this.textResCuad.Size = new System.Drawing.Size(63, 23);
            this.textResCuad.TabIndex = 9;
            this.textResCuad.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.ForeColor = System.Drawing.Color.Blue;
            this.btnCuadrado.Location = new System.Drawing.Point(189, 72);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(122, 30);
            this.btnCuadrado.TabIndex = 8;
            this.btnCuadrado.Text = "Calcular";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor1";
            // 
            // textVal4
            // 
            this.textVal4.Location = new System.Drawing.Point(73, 124);
            this.textVal4.Name = "textVal4";
            this.textVal4.Size = new System.Drawing.Size(66, 20);
            this.textVal4.TabIndex = 3;
            // 
            // textVal3
            // 
            this.textVal3.Location = new System.Drawing.Point(73, 98);
            this.textVal3.Name = "textVal3";
            this.textVal3.Size = new System.Drawing.Size(66, 20);
            this.textVal3.TabIndex = 2;
            // 
            // textVal2
            // 
            this.textVal2.Location = new System.Drawing.Point(73, 72);
            this.textVal2.Name = "textVal2";
            this.textVal2.Size = new System.Drawing.Size(66, 20);
            this.textVal2.TabIndex = 1;
            // 
            // textVal1
            // 
            this.textVal1.Location = new System.Drawing.Point(73, 49);
            this.textVal1.Name = "textVal1";
            this.textVal1.Size = new System.Drawing.Size(66, 20);
            this.textVal1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.btnLimpRect);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textResRect);
            this.groupBox2.Controls.Add(this.btnCalcRect);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textAltura);
            this.groupBox2.Controls.Add(this.textBase);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Area de un Rectangulo";
            // 
            // btnLimpRect
            // 
            this.btnLimpRect.ForeColor = System.Drawing.Color.Red;
            this.btnLimpRect.Location = new System.Drawing.Point(189, 114);
            this.btnLimpRect.Name = "btnLimpRect";
            this.btnLimpRect.Size = new System.Drawing.Size(122, 30);
            this.btnLimpRect.TabIndex = 11;
            this.btnLimpRect.Text = "Limpiar Campos";
            this.btnLimpRect.UseVisualStyleBackColor = true;
            this.btnLimpRect.Click += new System.EventHandler(this.btnLimpRect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(163, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "El Resultado es:";
            // 
            // textResRect
            // 
            this.textResRect.BackColor = System.Drawing.Color.White;
            this.textResRect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textResRect.Location = new System.Drawing.Point(248, 43);
            this.textResRect.Multiline = true;
            this.textResRect.Name = "textResRect";
            this.textResRect.Size = new System.Drawing.Size(63, 23);
            this.textResRect.TabIndex = 9;
            // 
            // btnCalcRect
            // 
            this.btnCalcRect.ForeColor = System.Drawing.Color.Blue;
            this.btnCalcRect.Location = new System.Drawing.Point(189, 72);
            this.btnCalcRect.Name = "btnCalcRect";
            this.btnCalcRect.Size = new System.Drawing.Size(122, 30);
            this.btnCalcRect.TabIndex = 8;
            this.btnCalcRect.Text = "Calcular";
            this.btnCalcRect.UseVisualStyleBackColor = true;
            this.btnCalcRect.Click += new System.EventHandler(this.btnCalcRect_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Altura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Base";
            // 
            // textAltura
            // 
            this.textAltura.Location = new System.Drawing.Point(73, 72);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(66, 20);
            this.textAltura.TabIndex = 1;
            // 
            // textBase
            // 
            this.textBase.Location = new System.Drawing.Point(73, 46);
            this.textBase.Name = "textBase";
            this.textBase.Size = new System.Drawing.Size(66, 20);
            this.textBase.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.btnLimpiarTriang);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textResultTriang);
            this.groupBox3.Controls.Add(this.btnCalcularTriang);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textAltTriang);
            this.groupBox3.Controls.Add(this.textBaseTriang);
            this.groupBox3.Location = new System.Drawing.Point(359, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 156);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Area de un Triangulo";
            // 
            // btnLimpiarTriang
            // 
            this.btnLimpiarTriang.ForeColor = System.Drawing.Color.Red;
            this.btnLimpiarTriang.Location = new System.Drawing.Point(189, 114);
            this.btnLimpiarTriang.Name = "btnLimpiarTriang";
            this.btnLimpiarTriang.Size = new System.Drawing.Size(122, 30);
            this.btnLimpiarTriang.TabIndex = 11;
            this.btnLimpiarTriang.Text = "Limpiar Campos";
            this.btnLimpiarTriang.UseVisualStyleBackColor = true;
            this.btnLimpiarTriang.Click += new System.EventHandler(this.btnLimpiarTriang_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(163, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "El Resultado es:";
            // 
            // textResultTriang
            // 
            this.textResultTriang.BackColor = System.Drawing.Color.White;
            this.textResultTriang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textResultTriang.Location = new System.Drawing.Point(248, 43);
            this.textResultTriang.Multiline = true;
            this.textResultTriang.Name = "textResultTriang";
            this.textResultTriang.Size = new System.Drawing.Size(63, 23);
            this.textResultTriang.TabIndex = 9;
            // 
            // btnCalcularTriang
            // 
            this.btnCalcularTriang.ForeColor = System.Drawing.Color.Blue;
            this.btnCalcularTriang.Location = new System.Drawing.Point(189, 72);
            this.btnCalcularTriang.Name = "btnCalcularTriang";
            this.btnCalcularTriang.Size = new System.Drawing.Size(122, 30);
            this.btnCalcularTriang.TabIndex = 8;
            this.btnCalcularTriang.Text = "Calcular";
            this.btnCalcularTriang.UseVisualStyleBackColor = true;
            this.btnCalcularTriang.Click += new System.EventHandler(this.btnCalcularTriang_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Altura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Base";
            // 
            // textAltTriang
            // 
            this.textAltTriang.Location = new System.Drawing.Point(73, 72);
            this.textAltTriang.Name = "textAltTriang";
            this.textAltTriang.Size = new System.Drawing.Size(66, 20);
            this.textAltTriang.TabIndex = 1;
            // 
            // textBaseTriang
            // 
            this.textBaseTriang.Location = new System.Drawing.Point(73, 46);
            this.textBaseTriang.Name = "textBaseTriang";
            this.textBaseTriang.Size = new System.Drawing.Size(66, 20);
            this.textBaseTriang.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.btnLimpCiruculo);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textResultCircul);
            this.groupBox4.Controls.Add(this.btnCalculCirculo);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textRadio);
            this.groupBox4.Location = new System.Drawing.Point(359, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 156);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Area de un Circulo";
            // 
            // btnLimpCiruculo
            // 
            this.btnLimpCiruculo.ForeColor = System.Drawing.Color.Red;
            this.btnLimpCiruculo.Location = new System.Drawing.Point(189, 114);
            this.btnLimpCiruculo.Name = "btnLimpCiruculo";
            this.btnLimpCiruculo.Size = new System.Drawing.Size(122, 30);
            this.btnLimpCiruculo.TabIndex = 11;
            this.btnLimpCiruculo.Text = "Limpiar Campos";
            this.btnLimpCiruculo.UseVisualStyleBackColor = true;
            this.btnLimpCiruculo.Click += new System.EventHandler(this.btnLimpCiruculo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(163, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "El Resultado es:";
            // 
            // textResultCircul
            // 
            this.textResultCircul.BackColor = System.Drawing.Color.White;
            this.textResultCircul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textResultCircul.Location = new System.Drawing.Point(248, 43);
            this.textResultCircul.Multiline = true;
            this.textResultCircul.Name = "textResultCircul";
            this.textResultCircul.Size = new System.Drawing.Size(63, 23);
            this.textResultCircul.TabIndex = 9;
            // 
            // btnCalculCirculo
            // 
            this.btnCalculCirculo.ForeColor = System.Drawing.Color.Blue;
            this.btnCalculCirculo.Location = new System.Drawing.Point(189, 75);
            this.btnCalculCirculo.Name = "btnCalculCirculo";
            this.btnCalculCirculo.Size = new System.Drawing.Size(122, 30);
            this.btnCalculCirculo.TabIndex = 8;
            this.btnCalculCirculo.Text = "Calcular";
            this.btnCalculCirculo.UseVisualStyleBackColor = true;
            this.btnCalculCirculo.Click += new System.EventHandler(this.btnCalculCirculo_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Radio";
            // 
            // textRadio
            // 
            this.textRadio.Location = new System.Drawing.Point(73, 46);
            this.textRadio.Name = "textRadio";
            this.textRadio.Size = new System.Drawing.Size(66, 20);
            this.textRadio.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(289, 376);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 39);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir de la APP";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(704, 427);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calcular Areas de Figuras Trigonometricas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textVal4;
        private System.Windows.Forms.TextBox textVal3;
        private System.Windows.Forms.TextBox textVal2;
        private System.Windows.Forms.TextBox textVal1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textResCuad;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpRect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textResRect;
        private System.Windows.Forms.Button btnCalcRect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.TextBox textBase;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLimpiarTriang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textResultTriang;
        private System.Windows.Forms.Button btnCalcularTriang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textAltTriang;
        private System.Windows.Forms.TextBox textBaseTriang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLimpCiruculo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textResultCircul;
        private System.Windows.Forms.Button btnCalculCirculo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textRadio;
        private System.Windows.Forms.Button btnSalir;
    }
}

