using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class frmCalculoPeso : Form
    {
        public frmCalculoPeso()
        {
            InitializeComponent();
        }

        private void btnCalcularPes_Click(object sender, EventArgs e)
        {
            if (txtAltura.Text != "")
             {
                double Altura, ResPes;

                Altura = Convert.ToDouble(txtAltura.Text);

                if (rdbMas.Checked == true)
                {
                    ResPes = 72.7 * Altura - 58;
                    MessageBox.Show("Seu peso ideal é: " + ResPes.ToString("0.00"), "Peso ideal", MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                }
                else if (rdbFem.Checked == true)
                {
                    ResPes = 62.1 * Altura - 44.8;
                    MessageBox.Show("Seu peso ideal é: " + ResPes.ToString("0.00"), "Peso ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolher entre gênero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
                }
              }
            else
            {
                MessageBox.Show("Colocar idade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
