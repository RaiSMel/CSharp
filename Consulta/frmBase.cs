using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultas
{
    public partial class frmBase : Form
    {
        public int _nCodGenerico;
        public enum StatusCadastro
        {
            scInserindo,
            scNavagando,
            scEditando
        }

        public StatusCadastro sStatus;
        public frmBase()
        {
            InitializeComponent();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            sStatus = StatusCadastro.scNavagando;
            LimpaControles();
            HabilitaDesabilitaControles(false);
        }

        private void tlBtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void LimpaControles()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                    (ctr as TextBox).Text = "";

                if (ctr is ComboBox)
                    (ctr as ComboBox).SelectedIndex = -1;
                if (ctr is ListBox)
                    (ctr as ListBox).SelectedIndex = -1;
                if (ctr is RadioButton)
                    (ctr as RadioButton).Checked = false;
                if (ctr is CheckedListBox)
                {
                    foreach (ListControl item in (ctr as CheckedListBox).Items)
                        item.SelectedIndex = -1;
                }
            }
        }

        public virtual bool Salvar()
        {
            return false;
        }

        public virtual bool Excluir()
        {
            return false;
        }

    public virtual bool Localizar()
        {
            return false;
        }

        private void tlBtnExcluir_Click(object sender, EventArgs e)
        {
            if (Excluir())
            {
                sStatus = StatusCadastro.scNavagando;
                LimpaControles();
                MessageBox.Show("Registro excluido com sucesso", "Aviso do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O registro não foi excluido, por favor verifique os erros!", "Aviso do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tlBtnSalvar_Click(object sender, EventArgs e)
        {
            if (Salvar())
            {
                sStatus = StatusCadastro.scNavagando;
                LimpaControles();
                MessageBox.Show("Registro salvo com sucesso", "Aviso do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("O registro não foi salvo, por favor verifique os erros!", "Aviso do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tlBtnLocalizar_Click(object sender, EventArgs e)
        { 
            if(Localizar())
            {

            sStatus = StatusCadastro.scInserindo;
             HabilitaDesabilitaControles(true);
            LimpaControles();
            }
        }

        private void tlBtnNovo_Click(object sender, EventArgs e)
        {
            if(Localizar())
            {
                sStatus = StatusCadastro.scEditando;
            }
        }
        private void HabilitaDesabilitaControles(bool bValue)
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is ToolStrip)
                    continue;

                ctr.Enabled = bValue;
            }

            tlBtnNovo.Enabled = (sStatus == StatusCadastro.scNavagando);

            tlBtnSalvar.Enabled = (sStatus == StatusCadastro.scNavagando ||
                sStatus == StatusCadastro.scInserindo);

            tlBtnExcluir.Enabled = (sStatus == StatusCadastro.scEditando);

            tlBtnLocalizar.Enabled = (sStatus == StatusCadastro.scNavagando);

            tlBtnFechar.Enabled = true;
        }
    }
}
