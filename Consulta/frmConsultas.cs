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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultorioDataSet.Paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.consultorioDataSet.Paciente);
            // TODO: esta linha de código carrega dados na tabela 'consultorioDataSet.Medico'. Você pode movê-la ou removê-la conforme necessário.
            this.medicoTableAdapter.Fill(this.consultorioDataSet.Medico);
            // TODO: esta linha de código carrega dados na tabela 'consultorioDataSet.Consulta'. Você pode movê-la ou removê-la conforme necessário.
            this.consultaTableAdapter.Fill(this.consultorioDataSet.Consulta);

        }

        private void horaInicioDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {

                Close();

            }
        }

        private void tlBtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void horaInicioDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmConsultas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {

                Close();

            }
        }
    }
}
