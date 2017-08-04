using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Area_Trigonometrica
{
    class Circulo
    {
       private Double radio = 0;

        public Double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public Circulo()
        {

        }

        public Circulo( Double p_radio)
        {
            p_radio = radio;
            
        }


    }
}
