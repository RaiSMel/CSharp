using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargosSalá
{
    public partial class frmCargos : Form
    {
        public frmCargos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AumentoTexto = "";
            double valor = Convert.ToDouble(txtSalario.Text),Aument = 0;

            if (cmbCargo.SelectedItem == "Auxiliar")
            {
                Aument = valor * 0.1;
                AumentoTexto = "Teve aumento de 10%";
            }
            else if (cmbCargo.SelectedItem == "Gerente")
            {
                Aument = valor * 0.05;
                AumentoTexto = "Teve aumento de 5%";
            }
            else if (cmbCargo.SelectedItem == "Outros")
            {
                Aument = valor * 0.04;
                AumentoTexto = "Teve aumento de 4%";
            }
            else if (cmbCargo.SelectedItem == "Técnico")
            {
                Aument = valor * 0.075;
                AumentoTexto = "Teve aumento de 7,5%";
            }
            else
            {
                MessageBox.Show("Cargo invalido");
            }

            txtResultado.Text += " " + lblNome.Text + txtNome.Text +
                "\r\n Cargo : " + cmbCargo.SelectedItem.ToString() +
                "\r\n Salário : " + txtSalario.Text +
                "\r\n " + AumentoTexto + ", Equivalente á: R$" + Aument.ToString() +
                "\r\n Novo salário: R$" + (valor + Aument).ToString() + "\r\n\r\n\r\n";

            txtSalario.Clear();
            txtNome.Clear();
            cmbCargo.Text = "Selecionar";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSalario.Clear();
            cmbCargo.Text = "Selecionar";
            txtResultado.Clear();
        }
    }
}
