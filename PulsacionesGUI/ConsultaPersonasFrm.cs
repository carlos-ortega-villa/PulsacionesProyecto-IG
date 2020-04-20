using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PulsacionesGUI
{
    public partial class ConsultaPersonasFrm : Form
      {  
        PersonaService personaService = new PersonaService(); 
        public ConsultaPersonasFrm()
        {
            InitializeComponent();
        }
      

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            string Id = Idtxt.Text;
            RespuestaBusqueda respuesta = personaService.Buscar(Id);
            MessageBox.Show(respuesta.Mensaje);
            if (respuesta.Mensaje != null)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
