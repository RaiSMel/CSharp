using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Consultas.dsConsultaTableAdapters;


namespace Consultas
{
    public partial class frmPacienteHerdado : Consultas.frmBase
    {
        public frmPacienteHerdado()
        {
            InitializeComponent();
        }

        public override bool Salvar()
        {
            bool bSalvar = false;
            dsConsultaTableAdapters.PacienteTableAdapter ta = new PacienteTableAdapter();
            if (sStatus == StatusCadastro.scInserindo)
            {
                bSalvar = (ta.Insert(txtNome.Text, txtTelefone.Text) > 0);
            }
            else if(sStatus == StatusCadastro.scEditando)
            {
                bSalvar = (ta.Update(txtNome.Text, txtTelefone.Text, int.Parse(lblCodigo.Text)) > 0);

            }
            return bSalvar;


        }

        public override bool Excluir()
        {
            bool bExcluir = false;
            dsConsultaTableAdapters.PacienteTableAdapter ta = new PacienteTableAdapter();

            bExcluir = (ta.Delete(int.Parse(lblCodigo.Text)) > 0);

            return bExcluir;
        }

        public override bool Localizar()
        {
            return base.Localizar();
        }

        public override void carregaV
        {
            dsConsulta.PacienteDataTable dt = new dsConsulta.PacienteDataTable();
            PacienteTableAdapter ta = new PacienteTableAdapter();
            dt = ta.PesquisaID(_nCodGenerico);

            if (dt.Rows.Count  > 0)
            {
                lblCodigo.Text = dt.Rows[0]["IdPaciente"].ToString();
            }
        }
    }
}
