using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Dinheiro
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }

        private void radDDola_CheckedChanged(object sender, EventArgs e)
        {
            if (radDDola.Checked == true)
            {
                radPReal.Checked = true;
            }
        }

        private void radDReal_CheckedChanged(object sender, EventArgs e)
        {
            if (radDReal.Checked == true)
            {
                radPDola.Checked = true;
            }
        }

        private void radPDola_CheckedChanged(object sender, EventArgs e)
        {
            if (radPDola.Checked == true)
            {
                radDReal.Checked = true;
            }
        }

        private void radPReal_CheckedChanged(object sender, EventArgs e)
        {
            if (radPReal.Checked == true)
            {
                radDDola.Checked = true;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double Cotacao, resultado, quanCamb;

            Cotacao = Convert.ToDouble(txtCotação.Text);
            quanCamb = Convert.ToDouble(txtQuantia.Text);


            if (radPDola.Checked == true && radDReal.Checked == true)
            {
                resultado = quanCamb / Cotacao;

                MessageBox.Show("Valor convertido para Dolares é de: $ " + resultado.ToString("0.00"), "Valor Convertido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radDDola.Checked == true && radPReal.Checked == true)
            {
                resultado = Cotacao * quanCamb;
                MessageBox.Show("Valor convertido para Reais é de: R$ " + resultado.ToString("0.00"), "Valor Convertido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            else
            {
                MessageBox.Show("dados para conversão insuficientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            } 
    }
}
