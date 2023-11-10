using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Double n1, n2, res;

            n1 = Convert.ToDouble(txtn1.Text);
            n2 = Convert.ToDouble(txtn2.Text);

            if (n2 == 0)
                MessageBox.Show("Nenhum número é divisivel por zero");
            else {
                res = n1 / n2;
                MessageBox.Show("O resultado é igual à: " + res.ToString()); }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
