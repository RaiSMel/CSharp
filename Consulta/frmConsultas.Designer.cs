
namespace Consultas
{
    partial class frmConsultas
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
            System.Windows.Forms.Label idConsultaLabel;
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label dataConsultaLabel;
            System.Windows.Forms.Label horaInicioLabel;
            System.Windows.Forms.Label horaFimLabel;
            System.Windows.Forms.Label observacoesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.consultorioDataSet = new Consultas.ConsultorioDataSet();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaTableAdapter = new Consultas.ConsultorioDataSetTableAdapters.ConsultaTableAdapter();
            this.tableAdapterManager = new Consultas.ConsultorioDataSetTableAdapters.TableAdapterManager();
            this.consultaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.consultaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tlBtnFechar = new System.Windows.Forms.ToolStripButton();
            this.idConsultaLabel1 = new System.Windows.Forms.Label();
            this.idPacienteComboBox = new System.Windows.Forms.ComboBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idMedicoComboBox = new System.Windows.Forms.ComboBox();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataConsultaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaFimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.medicoTableAdapter = new Consultas.ConsultorioDataSetTableAdapters.MedicoTableAdapter();
            this.pacienteTableAdapter = new Consultas.ConsultorioDataSetTableAdapters.PacienteTableAdapter();
            idConsultaLabel = new System.Windows.Forms.Label();
            idPacienteLabel = new System.Windows.Forms.Label();
            idMedicoLabel = new System.Windows.Forms.Label();
            dataConsultaLabel = new System.Windows.Forms.Label();
            horaInicioLabel = new System.Windows.Forms.Label();
            horaFimLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).BeginInit();
            this.consultaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idConsultaLabel
            // 
            idConsultaLabel.AutoSize = true;
            idConsultaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            idConsultaLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idConsultaLabel.Location = new System.Drawing.Point(167, 40);
            idConsultaLabel.Name = "idConsultaLabel";
            idConsultaLabel.Size = new System.Drawing.Size(133, 26);
            idConsultaLabel.TabIndex = 1;
            idConsultaLabel.Text = "Id Consulta:";
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            idPacienteLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPacienteLabel.Location = new System.Drawing.Point(167, 83);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(130, 26);
            idPacienteLabel.TabIndex = 3;
            idPacienteLabel.Text = "Id Paciente:";
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            idMedicoLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idMedicoLabel.Location = new System.Drawing.Point(167, 125);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(115, 26);
            idMedicoLabel.TabIndex = 5;
            idMedicoLabel.Text = "Id Medico:";
            // 
            // dataConsultaLabel
            // 
            dataConsultaLabel.AutoSize = true;
            dataConsultaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataConsultaLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataConsultaLabel.Location = new System.Drawing.Point(167, 172);
            dataConsultaLabel.Name = "dataConsultaLabel";
            dataConsultaLabel.Size = new System.Drawing.Size(161, 26);
            dataConsultaLabel.TabIndex = 7;
            dataConsultaLabel.Text = "Data Consulta:";
            // 
            // horaInicioLabel
            // 
            horaInicioLabel.AutoSize = true;
            horaInicioLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            horaInicioLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaInicioLabel.Location = new System.Drawing.Point(167, 222);
            horaInicioLabel.Name = "horaInicioLabel";
            horaInicioLabel.Size = new System.Drawing.Size(125, 26);
            horaInicioLabel.TabIndex = 9;
            horaInicioLabel.Text = "Hora Inicio:";
            // 
            // horaFimLabel
            // 
            horaFimLabel.AutoSize = true;
            horaFimLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            horaFimLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaFimLabel.Location = new System.Drawing.Point(167, 268);
            horaFimLabel.Name = "horaFimLabel";
            horaFimLabel.Size = new System.Drawing.Size(109, 26);
            horaFimLabel.TabIndex = 11;
            horaFimLabel.Text = "Hora Fim:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            observacoesLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacoesLabel.Location = new System.Drawing.Point(167, 312);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(154, 26);
            observacoesLabel.TabIndex = 13;
            observacoesLabel.Text = "Observacoes:";
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "ConsultorioDataSet";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataMember = "Consulta";
            this.consultaBindingSource.DataSource = this.consultorioDataSet;
            // 
            // consultaTableAdapter
            // 
            this.consultaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = this.consultaTableAdapter;
            this.tableAdapterManager.MedicoTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Consultas.ConsultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consultaBindingNavigator
            // 
            this.consultaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultaBindingNavigator.BindingSource = this.consultaBindingSource;
            this.consultaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consultaBindingNavigatorSaveItem,
            this.tlBtnFechar});
            this.consultaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultaBindingNavigator.Name = "consultaBindingNavigator";
            this.consultaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.consultaBindingNavigator.TabIndex = 0;
            this.consultaBindingNavigator.Text = "bindingNavigator1";
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
            // consultaBindingNavigatorSaveItem
            // 
            this.consultaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaBindingNavigatorSaveItem.Image")));
            this.consultaBindingNavigatorSaveItem.Name = "consultaBindingNavigatorSaveItem";
            this.consultaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.consultaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.consultaBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultaBindingNavigatorSaveItem_Click);
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
            // idConsultaLabel1
            // 
            this.idConsultaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idConsultaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "IdConsulta", true));
            this.idConsultaLabel1.Font = new System.Drawing.Font("Arial", 15.75F);
            this.idConsultaLabel1.Location = new System.Drawing.Point(342, 41);
            this.idConsultaLabel1.Name = "idConsultaLabel1";
            this.idConsultaLabel1.Size = new System.Drawing.Size(200, 23);
            this.idConsultaLabel1.TabIndex = 2;
            // 
            // idPacienteComboBox
            // 
            this.idPacienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultaBindingSource, "IdPaciente", true));
            this.idPacienteComboBox.DataSource = this.pacienteBindingSource;
            this.idPacienteComboBox.DisplayMember = "NomePaciente";
            this.idPacienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idPacienteComboBox.Font = new System.Drawing.Font("Arial", 15.75F);
            this.idPacienteComboBox.FormattingEnabled = true;
            this.idPacienteComboBox.Location = new System.Drawing.Point(342, 81);
            this.idPacienteComboBox.Name = "idPacienteComboBox";
            this.idPacienteComboBox.Size = new System.Drawing.Size(200, 32);
            this.idPacienteComboBox.TabIndex = 4;
            this.idPacienteComboBox.ValueMember = "IdPaciente";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.consultorioDataSet;
            // 
            // idMedicoComboBox
            // 
            this.idMedicoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultaBindingSource, "IdMedico", true));
            this.idMedicoComboBox.DataSource = this.medicoBindingSource;
            this.idMedicoComboBox.DisplayMember = "NomeMedico";
            this.idMedicoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idMedicoComboBox.Font = new System.Drawing.Font("Arial", 15.75F);
            this.idMedicoComboBox.FormattingEnabled = true;
            this.idMedicoComboBox.Location = new System.Drawing.Point(342, 123);
            this.idMedicoComboBox.Name = "idMedicoComboBox";
            this.idMedicoComboBox.Size = new System.Drawing.Size(200, 32);
            this.idMedicoComboBox.TabIndex = 6;
            this.idMedicoComboBox.ValueMember = "IdMedico";
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.consultorioDataSet;
            // 
            // dataConsultaDateTimePicker
            // 
            this.dataConsultaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource, "DataConsulta", true));
            this.dataConsultaDateTimePicker.Font = new System.Drawing.Font("Arial", 15.75F);
            this.dataConsultaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataConsultaDateTimePicker.Location = new System.Drawing.Point(342, 169);
            this.dataConsultaDateTimePicker.Name = "dataConsultaDateTimePicker";
            this.dataConsultaDateTimePicker.Size = new System.Drawing.Size(200, 32);
            this.dataConsultaDateTimePicker.TabIndex = 8;
            // 
            // horaInicioDateTimePicker
            // 
            this.horaInicioDateTimePicker.CustomFormat = "HH:mm";
            this.horaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource, "HoraInicio", true));
            this.horaInicioDateTimePicker.Font = new System.Drawing.Font("Arial", 15.75F);
            this.horaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaInicioDateTimePicker.Location = new System.Drawing.Point(342, 219);
            this.horaInicioDateTimePicker.Name = "horaInicioDateTimePicker";
            this.horaInicioDateTimePicker.Size = new System.Drawing.Size(200, 32);
            this.horaInicioDateTimePicker.TabIndex = 10;
            this.horaInicioDateTimePicker.ValueChanged += new System.EventHandler(this.horaInicioDateTimePicker_ValueChanged);
            // 
            // horaFimDateTimePicker
            // 
            this.horaFimDateTimePicker.CustomFormat = "HH:mm";
            this.horaFimDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource, "HoraFim", true));
            this.horaFimDateTimePicker.Font = new System.Drawing.Font("Arial", 15.75F);
            this.horaFimDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaFimDateTimePicker.Location = new System.Drawing.Point(342, 265);
            this.horaFimDateTimePicker.Name = "horaFimDateTimePicker";
            this.horaFimDateTimePicker.Size = new System.Drawing.Size(200, 32);
            this.horaFimDateTimePicker.TabIndex = 12;
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "Observacoes", true));
            this.observacoesTextBox.Font = new System.Drawing.Font("Arial", 15.75F);
            this.observacoesTextBox.Location = new System.Drawing.Point(342, 313);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(200, 89);
            this.observacoesTextBox.TabIndex = 14;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idConsultaLabel);
            this.Controls.Add(this.idConsultaLabel1);
            this.Controls.Add(idPacienteLabel);
            this.Controls.Add(this.idPacienteComboBox);
            this.Controls.Add(idMedicoLabel);
            this.Controls.Add(this.idMedicoComboBox);
            this.Controls.Add(dataConsultaLabel);
            this.Controls.Add(this.dataConsultaDateTimePicker);
            this.Controls.Add(horaInicioLabel);
            this.Controls.Add(this.horaInicioDateTimePicker);
            this.Controls.Add(horaFimLabel);
            this.Controls.Add(this.horaFimDateTimePicker);
            this.Controls.Add(observacoesLabel);
            this.Controls.Add(this.observacoesTextBox);
            this.Controls.Add(this.consultaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).EndInit();
            this.consultaBindingNavigator.ResumeLayout(false);
            this.consultaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConsultorioDataSet consultorioDataSet;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private ConsultorioDataSetTableAdapters.ConsultaTableAdapter consultaTableAdapter;
        private ConsultorioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consultaBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton tlBtnFechar;
        private System.Windows.Forms.Label idConsultaLabel1;
        private System.Windows.Forms.ComboBox idPacienteComboBox;
        private System.Windows.Forms.ComboBox idMedicoComboBox;
        private System.Windows.Forms.DateTimePicker dataConsultaDateTimePicker;
        private System.Windows.Forms.DateTimePicker horaInicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker horaFimDateTimePicker;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ConsultorioDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ConsultorioDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
    }
}