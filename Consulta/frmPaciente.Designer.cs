
namespace Consultas
{
    partial class frmPaciente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label nomePacienteLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            this.consultorioDataSet = new Consultas.ConsultorioDataSet();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new Consultas.ConsultorioDataSetTableAdapters.PacienteTableAdapter();
            this.tableAdapterManager = new Consultas.ConsultorioDataSetTableAdapters.TableAdapterManager();
            this.pacienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pacienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tlBtnFechar = new System.Windows.Forms.ToolStripButton();
            this.idPacienteLabel1 = new System.Windows.Forms.Label();
            this.nomePacienteTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            idPacienteLabel = new System.Windows.Forms.Label();
            nomePacienteLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).BeginInit();
            this.pacienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            idPacienteLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPacienteLabel.Location = new System.Drawing.Point(164, 121);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(130, 26);
            idPacienteLabel.TabIndex = 1;
            idPacienteLabel.Text = "Id Paciente:";
            // 
            // nomePacienteLabel
            // 
            nomePacienteLabel.AutoSize = true;
            nomePacienteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nomePacienteLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomePacienteLabel.Location = new System.Drawing.Point(164, 150);
            nomePacienteLabel.Name = "nomePacienteLabel";
            nomePacienteLabel.Size = new System.Drawing.Size(170, 26);
            nomePacienteLabel.TabIndex = 3;
            nomePacienteLabel.Text = "Nome Paciente:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            telefoneLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(164, 176);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(104, 26);
            telefoneLabel.TabIndex = 5;
            telefoneLabel.Text = "Telefone:";
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "ConsultorioDataSet";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.consultorioDataSet;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.MedicoTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Consultas.ConsultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacienteBindingNavigator
            // 
            this.pacienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacienteBindingNavigator.BindingSource = this.pacienteBindingSource;
            this.pacienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pacienteBindingNavigatorSaveItem,
            this.tlBtnFechar});
            this.pacienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacienteBindingNavigator.Name = "pacienteBindingNavigator";
            this.pacienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacienteBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.pacienteBindingNavigator.TabIndex = 0;
            this.pacienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pacienteBindingNavigatorSaveItem
            // 
            this.pacienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacienteBindingNavigatorSaveItem.Image")));
            this.pacienteBindingNavigatorSaveItem.Name = "pacienteBindingNavigatorSaveItem";
            this.pacienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pacienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pacienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacienteBindingNavigatorSaveItem_Click);
            // 
            // tlBtnFechar
            // 
            this.tlBtnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlBtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnFechar.Image")));
            this.tlBtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnFechar.Name = "tlBtnFechar";
            this.tlBtnFechar.Size = new System.Drawing.Size(46, 22);
            this.tlBtnFechar.Text = "Fechar";
            this.tlBtnFechar.Click += new System.EventHandler(this.tlBtnFechar_Click);
            // 
            // idPacienteLabel1
            // 
            this.idPacienteLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idPacienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "IdPaciente", true));
            this.idPacienteLabel1.Font = new System.Drawing.Font("Arial", 15.75F);
            this.idPacienteLabel1.Location = new System.Drawing.Point(347, 121);
            this.idPacienteLabel1.Name = "idPacienteLabel1";
            this.idPacienteLabel1.Size = new System.Drawing.Size(148, 23);
            this.idPacienteLabel1.TabIndex = 2;
            this.idPacienteLabel1.Text = "label1";
            // 
            // nomePacienteTextBox
            // 
            this.nomePacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "NomePaciente", true));
            this.nomePacienteTextBox.Font = new System.Drawing.Font("Arial", 15.75F);
            this.nomePacienteTextBox.Location = new System.Drawing.Point(347, 147);
            this.nomePacienteTextBox.Name = "nomePacienteTextBox";
            this.nomePacienteTextBox.Size = new System.Drawing.Size(148, 32);
            this.nomePacienteTextBox.TabIndex = 4;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "Telefone", true));
            this.telefoneTextBox.Font = new System.Drawing.Font("Arial", 15.75F);
            this.telefoneTextBox.Location = new System.Drawing.Point(347, 173);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(148, 32);
            this.telefoneTextBox.TabIndex = 6;
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idPacienteLabel);
            this.Controls.Add(this.idPacienteLabel1);
            this.Controls.Add(nomePacienteLabel);
            this.Controls.Add(this.nomePacienteTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.pacienteBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPaciente";
            this.Text = "Cadastrar paciente";
            this.Load += new System.EventHandler(this.frmPaciente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPaciente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).EndInit();
            this.pacienteBindingNavigator.ResumeLayout(false);
            this.pacienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConsultorioDataSet consultorioDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ConsultorioDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private ConsultorioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pacienteBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idPacienteLabel1;
        private System.Windows.Forms.TextBox nomePacienteTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.ToolStripButton tlBtnFechar;
    }
}