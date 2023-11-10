using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double ian, imi, ime, idi, iho, isem;

            ian = Convert.ToDouble(txtAno.Text);

            ime = ian * 12;
            idi = (365 * ian) + (ian / 4);
            isem = idi / 7;
            iho = idi * 24;
            imi = iho * 60;
                
            MessageBox.Show("\nIdade em anos: " + ian.ToString("0") +
                            "\nIdade em meses: " + ime.ToString("0") + 
                            "\nIdade em semanas: " + isem.ToString("0") + 
                            "\nIdade em dias: " + idi.ToString("0") +
                            "\nIdade em horas: " + iho.ToString("0") +
                            "\nIdade em minutos: " + imi.ToString("0"), "Conversor de idade", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAno.Clear();
        }

        private void btnFech_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
