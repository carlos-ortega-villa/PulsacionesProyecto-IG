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
    public partial class ModificarPersonaForm : Form
    {
        PersonaService Service = new PersonaService();
        Buscador buscador = new Buscador();
        RespuestaBusqueda respuestaBusqueda = new RespuestaBusqueda();
        Persona Persona = new Persona();
        Campos campos = new Campos();
        public ModificarPersonaForm()
        {
            InitializeComponent();
            ConsultarBtn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscador.BuscarPersona(IdentificacionTxt, this);

        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            if (!campos.Limpio(this))
            {
                ModificarPersona();
                Respuestas.VerInformacion(respuestaBusqueda.Mensaje);
            }
            else
            {
                if (campos.Limpio(this, ""))
                {
                    Respuestas.VerAdvertencia(Respuestas.Mensaje[1]);
                }
                else if (campos.Limpio(IdentificacionTxt))
                {
                    BloquearCampos();
                    Respuestas.VerAdvertencia(Respuestas.Mensaje[0]);
                }

            }
        }
        public void VerificarBusqueda(Persona persona)
        {
            button2.Enabled = false;
            IdentificacionTxt.Enabled = false;
            Persona = persona;
            PermitirCampos();
            ConsultarBtn.Enabled = true;
        }
        private void ModificarPersona()
        {
            Persona.Identificacion = IdentificacionTxt.Text;
           Persona.Nombre = NombreTxt.Text;
            Persona.Edad = int.Parse(EdadTxt.Text);
            Persona.Sexo = SexoCmb.Text;
            Persona.CalcularPulsacion();
            PulsacionTxt.Text = Persona.Pulsacion.ToString();
            respuestaBusqueda = Service.Modificar(Persona);
        }
        private void PermitirCampos()
        {
            NombreTxt.Enabled = true;
            NombreTxt.ReadOnly = false;
            EdadTxt.Enabled = true;
            EdadTxt.ReadOnly = false;
            SexoCmb.Enabled = true;
        }
        private void BloquearCampos()
        {
            NombreTxt.Enabled = false;
            NombreTxt.ReadOnly = true;
            EdadTxt.Enabled = false;
            EdadTxt.ReadOnly = true;
            SexoCmb.Enabled = false;
            button2.Enabled = false;
        }

        private void IdentificacionTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscador.BuscarPersona(IdentificacionTxt, this);
            }
        }
    }
}
