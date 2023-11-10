using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoCred
{
    public partial class frmVerCre : Form
    {
        public frmVerCre()
        {
            InitializeComponent();
        }

        private void btnVeriCre_Click(object sender, EventArgs e)
        {
            double SalMed, Res;

            SalMed = Convert.ToDouble(txtSalMed.Text);
            Res = 0;

            if (SalMed <= 200)
            {
                MessageBox.Show("Saldo Mensal insuficiente para obtenção de crédito", "Verificador de crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (SalMed > 200 && SalMed <= 400)
            {
                Res = SalMed + SalMed * 0.2;
                MessageBox.Show("Saldo Mensal suficiente para obtenção de crédito \n\n O crédito máximo é igual à: " +
                    Res.ToString("0.00"), "Verificador de crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (SalMed > 400 && SalMed <= 600)
            {
                Res = SalMed + SalMed * 0.3;
                MessageBox.Show("Saldo Mensal suficiente para obtenção de crédito \n\n O crédito máximo é igual à: " +
                    Res.ToString("0.00"), "Verificador de crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (SalMed > 60)
            {
                Res = SalMed + SalMed * 0.4;
                MessageBox.Show("Saldo Mensal suficiente para obtenção de crédito \n\n O crédito máximo é igual à: " +
                    Res.ToString("0.00"), "Verificador de crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
