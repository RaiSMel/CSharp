using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeTemperatura
{
    public partial class frmConvTemp : Form
    {
        public frmConvTemp()
        {
            InitializeComponent();
        }

        private void radDCel_CheckedChanged(object sender, EventArgs e)
        {
            if (radDCel.Checked == true)
            {
                radPCel.Visible = false;
                radPFahr.Visible = true;
                radPKel.Visible = true;
                radPCel.Checked = false;
            }
        }

        private void radDKel_CheckedChanged(object sender, EventArgs e)
        {
            if (radDKel.Checked == true)
            {
                radPCel.Visible = true;
                radPFahr.Visible = true;
                radPKel.Visible = false;
                radPKel.Checked = false;
            }
        }

        private void radDFahr_CheckedChanged(object sender, EventArgs e)
        {
            if (radDFahr.Checked == true)
            {
                radPCel.Visible = true;
                radPFahr.Visible = false;
                radPKel.Visible = true;
                radPFahr.Checked = false;
            }
        }

        private void BtnConverter_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado: ";

            double entrada, resul;

            entrada = Convert.ToDouble(txtEntrada.Text);

            resul = 0;


            if (radDCel.Checked == true && radPFahr.Checked == true)
            {
                resul = entrada * 1.8 + 32;
            }
            else if (radDFahr.Checked == true && radPCel.Checked == true)
            {
                resul = (entrada - 32) / 1.8;
            }
            else if (radDCel.Checked == true && radPKel.Checked == true)
            {
                resul = entrada + 273.15;
            }
            else if (radDKel.Checked == true && radPCel.Checked == true)
            {
                resul = entrada - 273.15;
            }
            else if (radDFahr.Checked == true && radPKel.Checked == true)
            {
                resul = (entrada - 32) / 1.8 + 273.15;
            }
            else if (radDKel.Checked == true && radPFahr.Checked == true)
            {
                resul = (entrada - 273.15) * 1.8 + 32;
            }

            lblResultado.Text += resul.ToString("0.00");  
        }
    }
}
