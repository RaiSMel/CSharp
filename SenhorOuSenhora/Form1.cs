using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenhorSenhora
{
    public partial class frmSrSra : Form
    {
        public frmSrSra()
        {
            InitializeComponent();
        }


        private void radMas_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radFemi_CheckedChanged(object sender, EventArgs e)
        {
           


        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            string sr;
            sr = "";
            if (radFemi.Checked == true)
            {
                
                sr = "Senhora ";
            }
            else if (radMas.Checked == true)
            {
            
                sr = "Senhor ";
            }

            lblimprimir.Text = "Seja Bem-Vindo " + sr + txtnome.Text;
        }
    }
}
