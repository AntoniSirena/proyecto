using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calcular_Area_Trigonometrica
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        // boton Calcular area del Cuadrado
        private void btnCuadrado_Click(object sender, EventArgs e)
        {

            Double valor1 = Double.Parse(textVal1.Text);
            Double valor2 = Double.Parse(textVal2.Text);
            Double valor3 = Double.Parse(textVal3.Text);
            Double valor4 = Double.Parse(textVal4.Text);
            Double resultado = 0;
            Double resultadofinal = 0;

            Cuadrado cuadrado1 = new Cuadrado();

            cuadrado1.Val1 = valor1;
            cuadrado1.Val2 = valor2;
            cuadrado1.Val3 = valor3;
            cuadrado1.Val4 = valor4;

            resultado = (valor1 + valor2 + valor3 + valor4) / 4;
            resultadofinal = resultado * resultado;

            textResCuad.Text = Convert.ToString(resultadofinal);

            

        }

        // Boton limpiar campos del cuadrado
        private void button1_Click(object sender, EventArgs e)
        {

            this.textVal1.Text = String.Empty;
            this.textVal2.Text = String.Empty;
            this.textVal3.Text = String.Empty;
            this.textVal4.Text = String.Empty;
            this.textResCuad.Text = String.Empty;
            this.textVal1.Focus();

        }

        // boton para calcular el area del Rectangulo
        private void btnCalcRect_Click(object sender, EventArgs e)
        {

            Double b = Double.Parse(textBase.Text);
            Double a = Double.Parse(textAltura.Text);
            Double resultado = 0;

            Rectangulo rectangulo1 = new Rectangulo();

            rectangulo1.Bas = b;
            rectangulo1.Altura = a;

            resultado = b * a;

            textResRect.Text = Convert.ToString(resultado);


        }

        // Boton limpiar campos del Rectangulo
        private void btnLimpRect_Click(object sender, EventArgs e)
        {
            this.textBase.Text = String.Empty;
            this.textAltura.Text = String.Empty;
            this.textResRect.Text = String.Empty;
            this.textBase.Focus();
        }

        // boton para calcular el area del Triangulo
        private void btnCalcularTriang_Click(object sender, EventArgs e)
        {

            Double bas_Triang = Double.Parse(textBaseTriang.Text);
            Double altur_Triang = Double.Parse(textBaseTriang.Text);
            Double resultado = 0;

            Triangulo triangulo1 = new Triangulo();

            triangulo1.Base_triang = bas_Triang;
            triangulo1.Altura_triang = altur_Triang;

            resultado = (bas_Triang * altur_Triang) / 2;

            textResultTriang.Text = Convert.ToString(resultado);


        }

        // Boton limpiar campos del Triangulo
        private void btnLimpiarTriang_Click(object sender, EventArgs e)
        {
            this.textBaseTriang.Text = String.Empty;
            this.textAltTriang.Text = String.Empty;
            this.textResultTriang.Text = String.Empty;
            this.textBaseTriang.Focus();

        }

        // Boton limpiar campos del circulo
        private void btnLimpCiruculo_Click(object sender, EventArgs e)
        {
            this.textRadio.Text = String.Empty;
            this.textResultCircul.Text = String.Empty;
            this.textRadio.Focus();
        }

        // boton para calcular el area del Circulo
        private void btnCalculCirculo_Click(object sender, EventArgs e)
        {
            Double rad = Double.Parse(textRadio.Text);

            Double resultado = 0;
            Double resultadofinal= 0;

            Circulo circulo1 = new Circulo();

            circulo1.Radio = rad;

            resultado = rad * rad;

            resultadofinal = 3.14 * resultado;


            textResultCircul.Text = Convert.ToString(resultadofinal);


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }



    }
}
