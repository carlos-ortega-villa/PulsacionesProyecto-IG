using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsacionesGUI
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }

    
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPersonaFrm registroPersonaFrm = new RegistroPersonaFrm();
            registroPersonaFrm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPersonasFrm consultaPersonasFrm = new ConsultaPersonasFrm();
            consultaPersonasFrm.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarPersonaForm modificarPersonaForm = new ModificarPersonaForm();
            modificarPersonaForm.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarPersonaForm eliminarPersonaForm = new EliminarPersonaForm();
            eliminarPersonaForm.Show();
        }
    }
}
