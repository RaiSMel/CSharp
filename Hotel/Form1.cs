using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double dias, taxa, res;

            dias = Convert.ToDouble(txtDias.Text);

            if (dias > 15)
            {
                taxa = 5.50;
            }
            else if (dias == 15)
            {
                taxa = 6;
            }
            else
            {
                taxa = 8;
            }

            res = (dias * 60) + (dias * taxa);

            MessageBox.Show("O valor total é de: " + res.ToString(), "Valor da estadia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
