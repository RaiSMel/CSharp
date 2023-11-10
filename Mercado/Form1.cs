using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class frmMercadinho : Form
    {
        public frmMercadinho()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Resul = 0;
            // 1111111111
            if (chbcupua.Checked == true)
            {
                Resul += Convert.ToDouble(txtCupua.Text) * Convert.ToDouble(lblCupua.Text);
            }
            //22222222
            if (chbBolac.Checked == true)
            {
                Resul += Convert.ToDouble(txtBolac.Text) * Convert.ToDouble(lblBolac.Text);
            }
            //333333333
            if (chbInham.Checked == true)
            {
                Resul += Convert.ToDouble(txtInham.Text) * Convert.ToDouble(lblInham.Text);
            }
            ///444444444
            if (chbPinico.Checked == true)
            {
                Resul += Convert.ToDouble(txtPinico.Text) * Convert.ToDouble(lblPinico.Text);
            }
            //55555555
            if (chbRapa.Checked == true)
            {
                Resul += Convert.ToDouble(txtRapa.Text) * Convert.ToDouble(lblRapa.Text);
            }
            //66666666666
            if (chbSaba.Checked == true)
            {
                Resul += Convert.ToDouble(txtSaba.Text) * Convert.ToDouble(lblSaba.Text);
            }
            //77777777777
            if (chbSandali.Checked == true)
            {
                Resul += Convert.ToDouble(txtSanda.Text) * Convert.ToDouble(lblSanda.Text);
            }

            lblResultado.Text = "A soma total dos produtos é igual à: " + Resul.ToString("0.00");

        }

        private void lblPinico_Click(object sender, EventArgs e)
        {

        }
    }
}
