using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_nota
{
    public partial class frmCalcula : Form
    {
        public frmCalcula()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Double Um, Dois, Tres, media;

            Um = Convert.ToDouble(txtUm.Text);
            Dois = Convert.ToDouble(txtDois.Text);
            Tres = Convert.ToDouble(txtTres.Text);

            media = (Um + Dois + Tres) / 3;

            if ( media >= 7 && media <= 10)
             { MessageBox.Show("média do aluno: " + media.ToString("0.00") + "\n Aprovado"); }

            else if (media < 7 && media >= 4)
             { MessageBox.Show("média do aluno: " + media.ToString("0.00") + "\n Em Prova Final"); }

            else
            { MessageBox.Show("média do aluno: " + media.ToString("0.00") + "\n Reprovado"); }

        }
    }
}
