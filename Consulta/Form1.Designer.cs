
namespace Consultas
{
    partial class frmConsultorio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultorio));
            this.tlMenu = new System.Windows.Forms.ToolStrip();
            this.tlBtnMedico = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPaciente = new System.Windows.Forms.ToolStripButton();
            this.tlBtnConsultas = new System.Windows.Forms.ToolStripButton();
            this.tlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMenu
            // 
            this.tlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlBtnMedico,
            this.tsBtnPaciente,
            this.tlBtnConsultas});
            this.tlMenu.Location = new System.Drawing.Point(0, 0);
            this.tlMenu.Name = "tlMenu";
            this.tlMenu.Size = new System.Drawing.Size(133, 450);
            this.tlMenu.TabIndex = 0;
            // 
            // tlBtnMedico
            // 
            this.tlBtnMedico.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnMedico.Image")));
            this.tlBtnMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnMedico.Name = "tlBtnMedico";
            this.tlBtnMedico.Size = new System.Drawing.Size(130, 20);
            this.tlBtnMedico.Text = "Cadastrar medico";
            this.tlBtnMedico.Click += new System.EventHandler(this.tlBtnMedico_Click);
            // 
            // tsBtnPaciente
            // 
            this.tsBtnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPaciente.Image")));
            this.tsBtnPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPaciente.Name = "tsBtnPaciente";
            this.tsBtnPaciente.Size = new System.Drawing.Size(130, 20);
            this.tsBtnPaciente.Text = "Cadastrar paciente";
            this.tsBtnPaciente.Click += new System.EventHandler(this.tsBtnPaciente_Click);
            // 
            // tlBtnConsultas
            // 
            this.tlBtnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnConsultas.Image")));
            this.tlBtnConsultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnConsultas.Name = "tlBtnConsultas";
            this.tlBtnConsultas.Size = new System.Drawing.Size(130, 20);
            this.tlBtnConsultas.Text = "Cadastrar Consultas";
            this.tlBtnConsultas.Click += new System.EventHandler(this.tlBtnConsultas_Click);
            // 
            // frmConsultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultorio";
            this.Text = "Consultorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.tlMenu.ResumeLayout(false);
            this.tlMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlMenu;
        private System.Windows.Forms.ToolStripButton tlBtnMedico;
        private System.Windows.Forms.ToolStripButton tsBtnPaciente;
        private System.Windows.Forms.ToolStripButton tlBtnConsultas;
    }
}

