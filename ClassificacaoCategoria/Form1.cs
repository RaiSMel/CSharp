using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassificacaoDeCategoria
{
    public partial class frmCategoriaNadador : Form
    {
        public frmCategoriaNadador()
        {
            InitializeComponent();
        }

        private void btnFaixetaria_Click(object sender, EventArgs e)
        {
            string Categoria;

            if (cmbCategoria.SelectedIndex == 0)
            {
                Categoria = "Infatil A";
            }
            else if (cmbCategoria.SelectedIndex == 1)
            {
                Categoria = "Infatil B";
            }
            else if (cmbCategoria.SelectedIndex == 2)
            {
                Categoria = "Juvenil A";
            }
            else if (cmbCategoria.SelectedIndex == 3)
            {
                Categoria = "Juvenil B";
            }
            else if (cmbCategoria.SelectedIndex == 4)      
            {
                Categoria = "Senior";
            }
            else
            {
                Categoria = "Não definida";
            }

            MessageBox.Show("Categoria do nadador é: " + Categoria, "Categoria Do Nadador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
