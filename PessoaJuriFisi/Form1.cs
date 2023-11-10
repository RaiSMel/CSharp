using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FisiJuri
{
    public partial class frmFisiJuri : Form
    {
        public frmFisiJuri()
        {
            InitializeComponent();
        }

        private void cmbPesFisJur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPesFisJur.SelectedIndex == 0)
            {
                lblCpfCnpj.Text = "CPF :";
            }
            else if (cmbPesFisJur.SelectedIndex == 1)
            {
                lblCpfCnpj.Text = "CNPJ :";
            }
            else
            {
                MessageBox.Show("Escolher entre Pessoa Jurídica ou Física", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
