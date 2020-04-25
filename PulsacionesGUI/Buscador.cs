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
    class Buscador
    {
        Campos campos = new Campos();
        RespuestaBusqueda buscar = new RespuestaBusqueda();
        PersonaService persona = new PersonaService();

        public void  BuscarPersona(TextBox text, Control control)
        {
            if (!campos.Limpio(text))
            {
                string Id = text.Text;
                buscar = persona.Buscar(Id);
                Verificar(control);
            }
            else
            {
                Respuestas.VerAdvertencia(Respuestas.Mensaje[1]);
            }

            
        }
        public void TipodeControl(Control control)
        {
            if (control is ConsultaPersonasFrm)
            {
                campos.LlenarCampos(control, buscar.Persona);
            }
            else if (control is EliminarPersonaForm)
            {
                campos.LlenarCampos(control, buscar.Persona);
                EliminarPersonaForm eliminarPersonaFrm = (EliminarPersonaForm)control;
                eliminarPersonaFrm.ConfirmarBusqueda(buscar.Persona);
            }
            else
            {
                ModificarPersonaForm modificarPersona=(ModificarPersonaForm)control;
                ModificarPersonaForm.VerificarBusqueda(buscar.Persona);
            }
        }
        public void Verificar(Control control)
        {
            if (buscar.Persona!= null)
            {
                TipodeControl(control);
                Respuestas.VerInformacion(buscar.Mensaje);
            }
            else
            {
                campos.VaciarCampos(control);
                Respuestas.VerError(buscar.Mensaje);
            }
        }
      
    }
}
