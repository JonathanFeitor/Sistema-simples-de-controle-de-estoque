namespace CamadaApresentacao
{
    partial class FrmRelatorioInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioInventario));
            this.grp_RelatorioInventario = new System.Windows.Forms.GroupBox();
            this.dtg_RelatorioInventario = new System.Windows.Forms.DataGridView();
            this.lbl_BuscarTipo = new System.Windows.Forms.Label();
            this.cmb_BuscarTipo = new System.Windows.Forms.ComboBox();
            this.spBuscarTipoInventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mBRMESSTOCKBuscarTipoInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mBRMESSTOCK_BuscarTipoInventario = new CamadaApresentacao.MBRMESSTOCK_BuscarTipoInventario();
            this.cmb_StatusEquipamento = new System.Windows.Forms.ComboBox();
            this.lbl_StatusEquipamento = new System.Windows.Forms.Label();
            this.lbl_TotalDataGrid = new System.Windows.Forms.Label();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.spBuscarTipoInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BuscarTipoInventarioTableAdapter = new CamadaApresentacao.MBRMESSTOCK_BuscarTipoInventarioTableAdapters.sp_BuscarTipoInventarioTableAdapter();
            this.chk_TodosEquipamentos = new System.Windows.Forms.CheckBox();
            this.grp_RelatorioInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RelatorioInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarTipoInventarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBRMESSTOCKBuscarTipoInventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBRMESSTOCK_BuscarTipoInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarTipoInventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_RelatorioInventario
            // 
            this.grp_RelatorioInventario.BackColor = System.Drawing.SystemColors.Window;
            this.grp_RelatorioInventario.Controls.Add(this.dtg_RelatorioInventario);
            this.grp_RelatorioInventario.ForeColor = System.Drawing.Color.White;
            this.grp_RelatorioInventario.Location = new System.Drawing.Point(12, 88);
            this.grp_RelatorioInventario.Name = "grp_RelatorioInventario";
            this.grp_RelatorioInventario.Size = new System.Drawing.Size(1127, 512);
            this.grp_RelatorioInventario.TabIndex = 0;
            this.grp_RelatorioInventario.TabStop = false;
            // 
            // dtg_RelatorioInventario
            // 
            this.dtg_RelatorioInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_RelatorioInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_RelatorioInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_RelatorioInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_RelatorioInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_RelatorioInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_RelatorioInventario.Location = new System.Drawing.Point(-3, -3);
            this.dtg_RelatorioInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_RelatorioInventario.Name = "dtg_RelatorioInventario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_RelatorioInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_RelatorioInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_RelatorioInventario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_RelatorioInventario.RowTemplate.Height = 24;
            this.dtg_RelatorioInventario.Size = new System.Drawing.Size(1132, 519);
            this.dtg_RelatorioInventario.TabIndex = 12;
            // 
            // lbl_BuscarTipo
            // 
            this.lbl_BuscarTipo.AutoSize = true;
            this.lbl_BuscarTipo.Location = new System.Drawing.Point(12, 29);
            this.lbl_BuscarTipo.Name = "lbl_BuscarTipo";
            this.lbl_BuscarTipo.Size = new System.Drawing.Size(87, 13);
            this.lbl_BuscarTipo.TabIndex = 1;
            this.lbl_BuscarTipo.Text = "Selecione o Tipo";
            this.lbl_BuscarTipo.Click += new System.EventHandler(this.lbl_BuscarTipo_Click);
            // 
            // cmb_BuscarTipo
            // 
            this.cmb_BuscarTipo.DataSource = this.spBuscarTipoInventarioBindingSource1;
            this.cmb_BuscarTipo.DisplayMember = "tipo_equipamento";
            this.cmb_BuscarTipo.FormattingEnabled = true;
            this.cmb_BuscarTipo.Location = new System.Drawing.Point(105, 26);
            this.cmb_BuscarTipo.Name = "cmb_BuscarTipo";
            this.cmb_BuscarTipo.Size = new System.Drawing.Size(201, 21);
            this.cmb_BuscarTipo.TabIndex = 2;
            this.cmb_BuscarTipo.ValueMember = "tipo_equipamento";
            // 
            // spBuscarTipoInventarioBindingSource1
            // 
            this.spBuscarTipoInventarioBindingSource1.DataMember = "sp_BuscarTipoInventario";
            this.spBuscarTipoInventarioBindingSource1.DataSource = this.mBRMESSTOCKBuscarTipoInventarioBindingSource;
            // 
            // mBRMESSTOCKBuscarTipoInventarioBindingSource
            // 
            this.mBRMESSTOCKBuscarTipoInventarioBindingSource.DataSource = this.mBRMESSTOCK_BuscarTipoInventario;
            this.mBRMESSTOCKBuscarTipoInventarioBindingSource.Position = 0;
            // 
            // mBRMESSTOCK_BuscarTipoInventario
            // 
            this.mBRMESSTOCK_BuscarTipoInventario.DataSetName = "MBRMESSTOCK_BuscarTipoInventario";
            this.mBRMESSTOCK_BuscarTipoInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_StatusEquipamento
            // 
            this.cmb_StatusEquipamento.FormattingEnabled = true;
            this.cmb_StatusEquipamento.Items.AddRange(new object[] {
            "SIM",
            "NAO",
            "TODOS"});
            this.cmb_StatusEquipamento.Location = new System.Drawing.Point(441, 26);
            this.cmb_StatusEquipamento.Name = "cmb_StatusEquipamento";
            this.cmb_StatusEquipamento.Size = new System.Drawing.Size(201, 21);
            this.cmb_StatusEquipamento.TabIndex = 4;
            // 
            // lbl_StatusEquipamento
            // 
            this.lbl_StatusEquipamento.AutoSize = true;
            this.lbl_StatusEquipamento.Location = new System.Drawing.Point(329, 29);
            this.lbl_StatusEquipamento.Name = "lbl_StatusEquipamento";
            this.lbl_StatusEquipamento.Size = new System.Drawing.Size(106, 13);
            this.lbl_StatusEquipamento.TabIndex = 3;
            this.lbl_StatusEquipamento.Text = "Equipamento em uso";
            // 
            // lbl_TotalDataGrid
            // 
            this.lbl_TotalDataGrid.AutoSize = true;
            this.lbl_TotalDataGrid.Location = new System.Drawing.Point(773, 61);
            this.lbl_TotalDataGrid.Name = "lbl_TotalDataGrid";
            this.lbl_TotalDataGrid.Size = new System.Drawing.Size(31, 13);
            this.lbl_TotalDataGrid.TabIndex = 5;
            this.lbl_TotalDataGrid.Text = "Total";
            // 
            // btn_Excel
            // 
            this.btn_Excel.Location = new System.Drawing.Point(1027, 26);
            this.btn_Excel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(112, 48);
            this.btn_Excel.TabIndex = 8;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(911, 26);
            this.btn_Pesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(112, 48);
            this.btn_Pesquisar.TabIndex = 7;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // spBuscarTipoInventarioBindingSource
            // 
            this.spBuscarTipoInventarioBindingSource.DataMember = "sp_BuscarTipoInventario";
            this.spBuscarTipoInventarioBindingSource.DataSource = this.mBRMESSTOCKBuscarTipoInventarioBindingSource;
            // 
            // sp_BuscarTipoInventarioTableAdapter
            // 
            this.sp_BuscarTipoInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // chk_TodosEquipamentos
            // 
            this.chk_TodosEquipamentos.AutoSize = true;
            this.chk_TodosEquipamentos.Location = new System.Drawing.Point(105, 57);
            this.chk_TodosEquipamentos.Name = "chk_TodosEquipamentos";
            this.chk_TodosEquipamentos.Size = new System.Drawing.Size(56, 17);
            this.chk_TodosEquipamentos.TabIndex = 9;
            this.chk_TodosEquipamentos.Text = "Todos";
            this.chk_TodosEquipamentos.UseVisualStyleBackColor = true;
            // 
            // FrmRelatorioInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 612);
            this.Controls.Add(this.chk_TodosEquipamentos);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.lbl_TotalDataGrid);
            this.Controls.Add(this.cmb_StatusEquipamento);
            this.Controls.Add(this.lbl_StatusEquipamento);
            this.Controls.Add(this.cmb_BuscarTipo);
            this.Controls.Add(this.lbl_BuscarTipo);
            this.Controls.Add(this.grp_RelatorioInventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorioInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Relatório Inventário";
            this.Load += new System.EventHandler(this.FrmRelatorioInventario_Load);
            this.grp_RelatorioInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RelatorioInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarTipoInventarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBRMESSTOCKBuscarTipoInventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBRMESSTOCK_BuscarTipoInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarTipoInventarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_RelatorioInventario;
        private System.Windows.Forms.Label lbl_BuscarTipo;
        private System.Windows.Forms.ComboBox cmb_BuscarTipo;
        private System.Windows.Forms.ComboBox cmb_StatusEquipamento;
        private System.Windows.Forms.Label lbl_StatusEquipamento;
        private System.Windows.Forms.Label lbl_TotalDataGrid;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.BindingSource mBRMESSTOCKBuscarTipoInventarioBindingSource;
        private MBRMESSTOCK_BuscarTipoInventario mBRMESSTOCK_BuscarTipoInventario;
        private System.Windows.Forms.BindingSource spBuscarTipoInventarioBindingSource;
        private MBRMESSTOCK_BuscarTipoInventarioTableAdapters.sp_BuscarTipoInventarioTableAdapter sp_BuscarTipoInventarioTableAdapter;
        private System.Windows.Forms.BindingSource spBuscarTipoInventarioBindingSource1;
        private System.Windows.Forms.DataGridView dtg_RelatorioInventario;
        private System.Windows.Forms.CheckBox chk_TodosEquipamentos;
    }
}