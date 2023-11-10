﻿
namespace Consultas
{
    partial class frmMedico
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
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label nomeMedicoLabel;
            System.Windows.Forms.Label cRMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedico));
            this.consultorioDataSet = new Consultas.ConsultorioDataSet();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoTableAdapter = new Consultas.ConsultorioDataSetTableAdapters.MedicoTableAdapter();
            this.tableAdapterManager = new Consultas.ConsultorioDataSetTableAdapters.TableAdapterManager();
            this.medicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.medicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tlBtnFechar = new System.Windows.Forms.ToolStripButton();
            this.idMedicoLabel1 = new System.Windows.Forms.Label();
            this.nomeMedicoTextBox = new System.Windows.Forms.TextBox();
            this.cRMTextBox = new System.Windows.Forms.TextBox();
            idMedicoLabel = new System.Windows.Forms.Label();
            nomeMedicoLabel = new System.Windows.Forms.Label();
            cRMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingNavigator)).BeginInit();
            this.medicoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            idMedicoLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idMedicoLabel.Location = new System.Drawing.Point(201, 106);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(103, 27);
            idMedicoLabel.TabIndex = 1;
            idMedicoLabel.Text = "Id Medico:";
            // 
            // nomeMedicoLabel
            // 
            nomeMedicoLabel.AutoSize = true;
            nomeMedicoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nomeMedicoLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeMedicoLabel.Location = new System.Drawing.Point(201, 135);
            nomeMedicoLabel.Name = "nomeMedicoLabel";
            nomeMedicoLabel.Size = new System.Drawing.Size(135, 27);
            nomeMedicoLabel.TabIndex = 3;
            nomeMedicoLabel.Text = "Nome Medico:";
            // 
            // cRMLabel
            // 
            cRMLabel.AutoSize = true;
            cRMLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            cRMLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cRMLabel.Location = new System.Drawing.Point(201, 161);
            cRMLabel.Name = "cRMLabel";
            cRMLabel.Size = new System.Drawing.Size(59, 27);
            cRMLabel.TabIndex = 5;
            cRMLabel.Text = "CRM:";
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "ConsultorioDataSet";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.consultorioDataSet;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.MedicoTableAdapter = this.medicoTableAdapter;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Consultas.ConsultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicoBindingNavigator
            // 
            this.medicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicoBindingNavigator.BindingSource = this.medicoBindingSource;
            this.medicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.medicoBindingNavigatorSaveItem,
            this.tlBtnFechar});
            this.medicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicoBindingNavigator.Name = "medicoBindingNavigator";
            this.medicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.medicoBindingNavigator.TabIndex = 0;
            this.medicoBindingNavigator.Text = "bindingNavigator1";
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
            // medicoBindingNavigatorSaveItem
            // 
            this.medicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicoBindingNavigatorSaveItem.Image")));
            this.medicoBindingNavigatorSaveItem.Name = "medicoBindingNavigatorSaveItem";
            this.medicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.medicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicoBindingNavigatorSaveItem_Click);
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
            // idMedicoLabel1
            // 
            this.idMedicoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idMedicoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "IdMedico", true));
            this.idMedicoLabel1.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.idMedicoLabel1.Location = new System.Drawing.Point(400, 106);
            this.idMedicoLabel1.Name = "idMedicoLabel1";
            this.idMedicoLabel1.Size = new System.Drawing.Size(198, 23);
            this.idMedicoLabel1.TabIndex = 2;
            // 
            // nomeMedicoTextBox
            // 
            this.nomeMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "NomeMedico", true));
            this.nomeMedicoTextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.nomeMedicoTextBox.Location = new System.Drawing.Point(400, 132);
            this.nomeMedicoTextBox.Name = "nomeMedicoTextBox";
            this.nomeMedicoTextBox.Size = new System.Drawing.Size(198, 32);
            this.nomeMedicoTextBox.TabIndex = 4;
            // 
            // cRMTextBox
            // 
            this.cRMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "CRM", true));
            this.cRMTextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.cRMTextBox.Location = new System.Drawing.Point(400, 158);
            this.cRMTextBox.Name = "cRMTextBox";
            this.cRMTextBox.Size = new System.Drawing.Size(198, 32);
            this.cRMTextBox.TabIndex = 6;
            // 
            // frmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idMedicoLabel);
            this.Controls.Add(this.idMedicoLabel1);
            this.Controls.Add(nomeMedicoLabel);
            this.Controls.Add(this.nomeMedicoTextBox);
            this.Controls.Add(cRMLabel);
            this.Controls.Add(this.cRMTextBox);
            this.Controls.Add(this.medicoBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedico";
            this.Text = "Cadastrar Medico";
            this.Load += new System.EventHandler(this.frmMedico_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMedico_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingNavigator)).EndInit();
            this.medicoBindingNavigator.ResumeLayout(false);
            this.medicoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConsultorioDataSet consultorioDataSet;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ConsultorioDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private ConsultorioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton medicoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idMedicoLabel1;
        private System.Windows.Forms.TextBox nomeMedicoTextBox;
        private System.Windows.Forms.TextBox cRMTextBox;
        private System.Windows.Forms.ToolStripButton tlBtnFechar;
    }
}