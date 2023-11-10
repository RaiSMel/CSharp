using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultas
{
    public partial class frmConsultorio : Form
    {
        public frmConsultorio()
        {
            InitializeComponent();
        }

        private void tlBtnMedico_Click(object sender, EventArgs e)
        {
            frmMedico medico = new frmMedico();
            medico.ShowDialog();
        }

        private void tsBtnPaciente_Click(object sender, EventArgs e)
        {
            frmPaciente paciente = new frmPaciente();
            paciente.ShowDialog();
        }

        private void tlBtnConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas consultas = new frmConsultas();
            consultas.ShowDialog();
        }
    }
}
