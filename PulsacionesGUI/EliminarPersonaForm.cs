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
    public partial class EliminarPersonaForm : Form
    {
        PersonaService Service = new PersonaService();
        Buscador buscador = new Buscador();
        RespuestaBusqueda respuestaBusqueda = new RespuestaBusqueda();
        Persona Persona = new Persona();
        Campos campos = new Campos();
        public EliminarPersonaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            buscador.BuscarPersona(Idtxt, this);
        }
        public void ConfirmarBusqueda(Persona persona)
        {
            Persona = persona;
            button2.Enabled = true;
            campos.LlenarCampos(this, Persona);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!campos.Limpio(Idtxt))
            {
                EliminarPersona();
                if (respuestaBusqueda.Persona != null)
                {
                    Respuestas.VerInformacion(respuestaBusqueda.Mensaje);
                }
                else
                {
                   Respuestas.VerError(respuestaBusqueda.Mensaje);
                }
            }
            else
            {
               Respuestas.VerAdvertencia(Respuestas.Mensaje[1]);
            }
        }
        private void EliminarPersona()
        {
           respuestaBusqueda = Service.Eliminar(Persona.Identificacion);

        }
        private void IdentificacionTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               buscador.BuscarPersona(Idtxt, this);
            }
        }
    }
}
