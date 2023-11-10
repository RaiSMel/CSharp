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
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultorioDataSet.Paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.consultorioDataSet.Paciente);

        }

        

        private void frmPaciente_KeyDown(object sender, KeyEventArgs e)
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
    }
}
