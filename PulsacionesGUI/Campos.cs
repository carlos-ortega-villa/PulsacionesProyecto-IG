using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace PulsacionesGUI
{
    class Campos
    {

        public void VaciarCampos(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is ComboBox)
                {
                    ((ComboBox)txt).Text = "";
                }

                else if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
            }
        }
        public bool Limpio(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    if (((TextBox)txt).Text.Length.Equals(0) && ((TextBox)txt).Name != "PulsacionesTxt")
                    {
                        return true;
                    }
                }
                else if (txt is ComboBox)
                {
                    if (((ComboBox)txt).Text.Length.Equals(0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool Limpio(Control control, string Diferenciador)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    if (((TextBox)txt).Text.Length.Equals(0) && ((TextBox)txt).Name != "PulsacionesTxt"
                        && ((TextBox)txt).Name != "IdentificacionTxt")
                    {
                        return true;
                    }
                }
                else if (txt is ComboBox)
                {
                    if (((ComboBox)txt).Text.Length.Equals(0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool Limpio(TextBox textBox)
        {
            if (textBox.Text.Length.Equals(0))
            {
                return true;
            }
            return false;
        }
        public bool Limpio(ComboBox comboBox)
        {
            if (comboBox.Text.Length.Equals(0))
            {
                return true;
            }
            return false;
        }
        public void LlenarCampos(Control control, Persona persona)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    RegistroCampos((TextBox)txt, persona);
                }
                else if (txt is ComboBox)
                {
                   RegistroCampos((ComboBox)txt, persona);
                }
            }
        }
        public void RegistroCampos(TextBox txt, Persona persona)
        {
            switch (txt.Name)
            {
                case "IdentificacionTxt":
                    txt.Text = persona.Identificacion;
                    break;
                case "NombreTxt":
                    txt.Text = persona.Nombre;
                    break;
                case "EdadTxt":
                    txt.Text = persona.Edad.ToString();
                    break;
                case "PulsacionesTxt":
                    txt.Text = persona.Pulsacion.ToString();
                    break;
            }
        }
        public void RegistroCampos(ComboBox txt, Persona persona)
        {
            txt.Text = persona.Sexo;
        }
    }
}
