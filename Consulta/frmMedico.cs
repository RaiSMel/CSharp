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
    public partial class frmMedico : Form
    {
        public frmMedico()
        {
            InitializeComponent();
        }

        private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultorioDataSet.Medico'. Você pode movê-la ou removê-la conforme necessário.
            this.medicoTableAdapter.Fill(this.consultorioDataSet.Medico);

        }

        private void frmMedico_KeyDown(object sender, KeyEventArgs e)
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
