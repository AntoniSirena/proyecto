using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Area_Trigonometrica
{
    class Triangulo
    {
        private Double base_triang = 0;
        private  Double altura_triang = 0;

        public Double Base_triang
        {
            get { return base_triang; }
            set { base_triang = value; }
        }

        public Double Altura_triang
        {
            get { return altura_triang; }
            set { altura_triang = value; }
        }


        public Triangulo()
        {

        }


        public Triangulo( Double p_base_triang, Double p_altura_triang)
        {
            p_base_triang = base_triang;
            p_altura_triang = altura_triang;

        }
    }
}
