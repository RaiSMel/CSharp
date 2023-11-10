using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtAltura.Text == "" || txtMassa.Text == "")
            {
                MessageBox.Show("Dados incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                string val, pes;
                val = "";
                pes = "";

                if (cmbGen.SelectedIndex == 0)
                {

                    val = " o senhor ";
                }
                else if (cmbGen.SelectedIndex == 1)
                {

                    val = " a senhora ";
                }
                else
                {
                    val = " você ";
                }

                this.ClientSize = new System.Drawing.Size(354, 400);

                double altura, massa, imc;

                altura = Convert.ToDouble(txtAltura.Text);
                massa = Convert.ToDouble(txtMassa.Text);

                imc = massa / (altura * altura);

                if (imc < 17)
                {
                    pes = "muito abaixo do peso";
                    picPuro.Visible = true;
                }
                else if (imc >= 17 && imc < 18.5)
                {
                    pes = "abaixo do peso";
                    picPuro.Visible = true;
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    pes = " com peso Normal";
                    picMinto.Visible = true;
                }
                else if (imc >= 25 && imc < 30)
                {
                    pes = "acima do peso";
                    picSnorl.Visible = true;
                }
                else if (imc >= 30 && imc < 35)
                {
                    pes = "com obesidade I";
                    picSnorl.Visible = true;
                }
                else if (imc >= 35 && imc < 40)
                {
                    pes = "com obesidade II";
                    picSnorl.Visible = true;
                }
                else if (imc >= 40)
                {
                    pes = "com obesidade III";
                    picSnorl.Visible = true;
                }

                lblRes.Text = val + "está " + pes + "\r\n imc igual à : " + imc.ToString("0.00"); 

            }
            
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(354, 180);
            lblRes.Text = "";
            picMinto.Visible = false;
            picPuro.Visible = false;
            picSnorl.Visible = false;
            txtAltura.Text = "";
            txtMassa.Text = "";
            cmbGen.Text = "Selecionar" ;
        }
    }
}
