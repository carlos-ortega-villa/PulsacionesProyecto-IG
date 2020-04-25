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


namespace PulsacionesGUI
{
    public partial class ListadoConsultaForm : Form
    {
        PersonaService personaService = new PersonaService();
        RespuestaConsulta respuesta = new RespuestaConsulta();
        Campos campos = new Campos();
        string TotalHombres;
        string TotalMujeres;
        string TotalPersonas;
       
        public ListadoConsultaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Consultar()
        {
            dataGridView1.DataSource = null;
            respuesta = personaService.Consultar();
            TotalPersonas = personaService.TotalizarPersonas().ToString();
            TotalHombres = personaService.TotalizarPorSexo("M").ToString();
            TotalMujeres = personaService.TotalizarPorSexo("F").ToString();
            VerificarConsulta();
        }
        private void VerificarConsulta()
        {
            if (campos.Limpio(TipoCmb))
            {
                Respuestas.VerAdvertencia(Respuestas.Mensaje[2]);
            }
            else
            {
                ConsultarPorTipo();
            }
        }
        private void LlenarCampos()
        {
            Hombrestxt.Text = TotalHombres;
            Mujerestxt.Text = TotalMujeres;
          Todostxt.Text = TotalPersonas;
        }
        private void ConsultarPorTipo()
        {
            if (TipoCmb.SelectedIndex == 0)
            {
                dataGridView1.DataSource = respuesta.Personas;
            }
            else if (TipoCmb.SelectedIndex == 1)
            {
                dataGridView1.DataSource = personaService.ConsultarPorSexo("M");
                TotalMujeres = "0";
                TotalPersonas = TotalHombres;
            }
            else
            {
                dataGridView1.DataSource = personaService.ConsultarPorSexo("F");
                TotalHombres = "0";
                TotalPersonas = TotalMujeres;
            }
            LlenarCampos();
        }
       
        private void TipoConsultaCmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Consultar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
