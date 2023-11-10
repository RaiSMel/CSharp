using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmClassificador : Form
    {
        public frmClassificador()
        {
            InitializeComponent();
        }

        private void btnClassifi_Click(object sender, EventArgs e)
        {
            double idade;

            idade = Convert.ToDouble(txtIdade.Text);

            if (idade >= 5 && idade <=10)
            {
                txtClassificacao.Text += txtNome.Text + "    Infantil \r\n";
                txtIdade.Clear();
                txtNome.Clear();
            }
            else if (idade >= 11 && idade <= 15)
            {
                txtClassificacao.Text += txtNome.Text + "    Juvenil \r\n";
                txtIdade.Clear();
                txtNome.Clear();
            }
            else if (idade >= 16 && idade <= 20)
            {
                txtClassificacao.Text += txtNome.Text + "    Senior \r\n";
                txtIdade.Clear();
                txtNome.Clear();
            }
            else if (idade >= 21 && idade <= 25)
            {
                txtClassificacao.Text += txtNome.Text + "    Profissional \r\n";
                txtIdade.Clear();
                txtNome.Clear();
            }
            else
            {
                MessageBox.Show("Idade não adequa-se aos padrôes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdade.Clear();
                txtNome.Clear();
            }
        }
    }
}
