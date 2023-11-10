using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troco
{
    public partial class frmDinNecessario : Form
    {
        public frmDinNecessario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Imprimir;

            Imprimir = " Nota/Moeda - Quantidade  ";



            double resto, valor;

            resto = 0;
            valor = Convert.ToDouble(txtVal.Text);

            if (valor >= 200)
            {
                int n200 = (int)valor / 200;
                Imprimir += "| 200 - " + n200.ToString("0");
                valor = (double)valor % 200;

            }
            if (valor >= 100 && valor < 200)
            {
                int n100 = (int)valor / 100;
                Imprimir += "| 100 - " + n100.ToString("0");
                valor = (double)valor % 100; }
            
            if (valor >= 50 && valor < 100)
            {
                int n50 = (int)valor / 50;
                Imprimir += "| 50 - " + n50.ToString("0");
                valor = (double)valor % 50;

            }
            if (valor >= 20 && valor < 50)
            {
                int n20 = (int)valor / 20;
                Imprimir += "| 20 - " + n20.ToString("0");
                valor = (double)valor % 20;

            }
            if (valor >= 9 && valor < 20)
            {
                int n10 = (int)valor / 10;
                Imprimir += "| 10 - " + n10.ToString("0");
                valor = (double)valor % 10;
            }
            if (valor >= 5 && valor < 10)
                {
                    int n5 = (int)valor / 5;
                    Imprimir += "| 5 - " + n5.ToString("0");
                    valor = (double)valor % 5;
                }
            if (valor >= 2 && valor< 5)
                {
                     int n2 = (int)valor / 2;
                     Imprimir += "| 2 - " + n2.ToString("0");
                     valor = (double) valor % 2; }
            if (valor >= 1 && valor < 2)
            {
                int n1 = (int)valor / 1;
                Imprimir += "| 1 - " + n1.ToString("0");
                valor = (double)valor % 1;
            }
            if (valor >= 0.5 && valor < 1)
            {
                double n05 = (double)valor / 0.5;
                n05 = (int)n05;
                Imprimir += "| 0,5 - " + n05.ToString("0");
                valor = (double)valor % 0.5;
            }
            if (valor >= 0.25 && valor < 0.5)
            {
                double n025 = (double)valor / 0.25;
                n025 = (int)n025;
                Imprimir += "| 0,25 - " + n025.ToString("0");
                valor = (double)valor % 0.25;
            }
            if (valor >= 0.10 && valor < 0.25)
            {
                double n01 = (double)valor / 0.10;
                n01 = (int)n01;
                Imprimir += "| 0,10 - " + n01.ToString("0");
                valor = (double)valor % 0.1;
            }
            if (valor >= 0.00 && valor < 0.10)
            {
                double n005 = (double)valor / 0.05;
                Imprimir += "| 0,05 - " + n005.ToString("0");
            }

                lblRes.Text = Imprimir;
        }
    }
}
