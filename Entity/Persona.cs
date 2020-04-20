using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Edad{ get; set; }
        public decimal Pulsacion { get; set; }

      
        public void CalcularPulsacion()
        {
            if (Sexo.ToUpper() == "F")
            {
                Pulsacion = (220 - Edad) / 10;
            }
            else if (Sexo.ToUpper() == "M")
            {
                Pulsacion = (210 - Edad) / 10;
            }
            else
            {
                Pulsacion = 0;
            }

        }
        public override string ToString()
        {
            return $"{Identificacion};{Nombre};{Edad};{Sexo};{Pulsacion}";
        }
    }
}
