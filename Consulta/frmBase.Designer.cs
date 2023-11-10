
namespace Consultas
{
    partial class frmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlBtnNovo = new System.Windows.Forms.ToolStripButton();
            this.tlBtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.tlBtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tlBtnLocalizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlBtnFechar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLblMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlBtnNovo,
            this.tlBtnExcluir,
            this.tlBtnSalvar,
            this.tlBtnLocalizar,
            this.toolStripSeparator1,
            this.tlBtnFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlBtnNovo
            // 
            this.tlBtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnNovo.Image")));
            this.tlBtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnNovo.Name = "tlBtnNovo";
            this.tlBtnNovo.Size = new System.Drawing.Size(56, 22);
            this.tlBtnNovo.Text = "Novo";
            this.tlBtnNovo.Click += new System.EventHandler(this.tlBtnNovo_Click);
            // 
            // tlBtnExcluir
            // 
            this.tlBtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnExcluir.Image")));
            this.tlBtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnExcluir.Name = "tlBtnExcluir";
            this.tlBtnExcluir.Size = new System.Drawing.Size(62, 22);
            this.tlBtnExcluir.Text = "Excluir";
            this.tlBtnExcluir.Click += new System.EventHandler(this.tlBtnExcluir_Click);
            // 
            // tlBtnSalvar
            // 
            this.tlBtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnSalvar.Image")));
            this.tlBtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnSalvar.Name = "tlBtnSalvar";
            this.tlBtnSalvar.Size = new System.Drawing.Size(58, 22);
            this.tlBtnSalvar.Text = "Salvar";
            this.tlBtnSalvar.Click += new System.EventHandler(this.tlBtnSalvar_Click);
            // 
            // tlBtnLocalizar
            // 
            this.tlBtnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnLocalizar.Image")));
            this.tlBtnLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnLocalizar.Name = "tlBtnLocalizar";
            this.tlBtnLocalizar.Size = new System.Drawing.Size(73, 22);
            this.tlBtnLocalizar.Text = "Localizar";
            this.tlBtnLocalizar.Click += new System.EventHandler(this.tlBtnLocalizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tlBtnFechar
            // 
            this.tlBtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnFechar.Image")));
            this.tlBtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnFechar.Name = "tlBtnFechar";
            this.tlBtnFechar.Size = new System.Drawing.Size(62, 22);
            this.tlBtnFechar.Text = "Fechar";
            this.tlBtnFechar.Click += new System.EventHandler(this.tlBtnFechar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblMensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssLblMensagem
            // 
            this.tssLblMensagem.Name = "tssLblMensagem";
            this.tssLblMensagem.Size = new System.Drawing.Size(0, 17);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBase";
            this.Text = "Base";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBase_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlBtnNovo;
        private System.Windows.Forms.ToolStripButton tlBtnExcluir;
        private System.Windows.Forms.ToolStripButton tlBtnSalvar;
        private System.Windows.Forms.ToolStripButton tlBtnLocalizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlBtnFechar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssLblMensagem;
    }
}