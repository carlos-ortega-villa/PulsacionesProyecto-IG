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
    public partial class RegistroPersonaFrm : Form
    {
        PersonaService personaService = new PersonaService();
        Campos campos = new Campos();
        Persona persona = new Persona();
        RespuestaBusqueda respuesta;
        public RegistroPersonaFrm()
        {
            InitializeComponent();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
         if(!campos.Limpio(this))  
         { 
            RegistroPersona();
            if (respuesta.Persona == null)
            {
                Respuestas.VerInformacion(respuesta.Mensaje);
            }
            else
            {
                Respuestas.VerError(respuesta.Mensaje);
            }
         }
            else
            {
               Respuestas.VerAdvertencia(Respuestas.Mensaje[1]);
            }
        }


        private void RegistroPersona()
        {
            Persona persona = new Persona();
            persona.Identificacion = IdentificacionTxt.Text;
            persona.Nombre = NombreTxt.Text;
            persona.Edad = int.Parse(EdadTxt.Text);
            persona.Sexo = SexoCmb.Text;
            persona.CalcularPulsacion();
            PulsacionTxt.Text = persona.Pulsacion.ToString();
            respuesta = personaService.Guardar(persona);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
