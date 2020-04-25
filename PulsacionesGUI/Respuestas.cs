using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsacionesGUI
{
    class Respuestas
    {
        public static string[] Mensaje = { "Verifique de que no hayan campos vacios, por favor",
            "No se ha digitado ningun valor, por favor Digite un valor",
            "Por favor elija una opcion"};
        public string getMessage(int Index)
        {
            return Mensaje[Index];
        }
        public static void VerInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "!!!Operacion Realizada Con Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void VerError(string mensaje)
        {
            MessageBox.Show(mensaje, "!!!Error al momento de ejecutar!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       
        public static void VerAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "!!!Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
