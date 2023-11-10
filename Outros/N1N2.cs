using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class frmWhile : Form
    {
        public frmWhile()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i = 1, tot;
            tot = 0;

            while (i <= 100)
            {
                tot += i;
                i++;
            }

            lstResultado.Items.Add(tot.ToString());
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            {
                lstResul2.Items.Clear();

                double N1 = Convert.ToDouble(txtN1.Text), N2 = Convert.ToDouble(txtN2.Text), tot = 0;
                if (N1 < N2)
                {
                    for (; N1 <= N2; N1++)
                    {
                        tot += N1;
                    }
                    lstResul2.Items.Add(tot.ToString());
                    lstResul2.Items.Add((tot / N2).ToString());
                }
                else
                {
                    MessageBox.Show("N1 tem de ser menor que o N2", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
