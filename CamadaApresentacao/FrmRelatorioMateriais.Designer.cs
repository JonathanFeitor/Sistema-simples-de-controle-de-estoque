namespace CamadaApresentacao
{
    partial class FrmRelatorioMateriais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioMateriais));
            this.grp_RelatorioMaterial = new System.Windows.Forms.GroupBox();
            this.dtg_RelatorioMaterial = new System.Windows.Forms.DataGridView();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.lbl_TipoMaterial = new System.Windows.Forms.Label();
            this.lbl_Data1 = new System.Windows.Forms.Label();
            this.dateTime_Data1 = new System.Windows.Forms.DateTimePicker();
            this.dateTime_Data2 = new System.Windows.Forms.DateTimePicker();
            this.cmb_TipoMaterial = new System.Windows.Forms.ComboBox();
            this.spRelatorioMateriaisBuscarTipoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mBRMESSTOCKRelatorioBuscarTipoMateriais = new CamadaApresentacao.MBRMESSTOCKRelatorioBuscarTipoMateriais();
            this.spRelatorioMateriaisBuscarTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_TotalMovimentacao = new System.Windows.Forms.Label();
            this.lbl_QuantidadeMaterial = new System.Windows.Forms.Label();
            this.sp_RelatorioMateriaisBuscarTipoTableAdapter = new CamadaApresentacao.MBRMESSTOCKRelatorioBuscarTipoMateriaisTableAdapters.sp_RelatorioMateriaisBuscarTipoTableAdapter();
            this.lbl_Media = new System.Windows.Forms.Label();
            this.cmb_TipoMovimentacao = new System.Windows.Forms.ComboBox();
            this.lbl_TipoMovimentacao = new System.Windows.Forms.Label();
            this.grp_RelatorioMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RelatorioMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRelatorioMateriaisBuscarTipoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBRMESSTOCKRelatorioBuscarTipoMateriais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRelatorioMateriaisBuscarTipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_RelatorioMaterial
            // 
            this.grp_RelatorioMaterial.BackColor = System.Drawing.SystemColors.Window;
            this.grp_RelatorioMaterial.Controls.Add(this.dtg_RelatorioMaterial);
            this.grp_RelatorioMaterial.Location = new System.Drawing.Point(9, 83);
            this.grp_RelatorioMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RelatorioMaterial.Name = "grp_RelatorioMaterial";
            this.grp_RelatorioMaterial.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RelatorioMaterial.Size = new System.Drawing.Size(1132, 519);
            this.grp_RelatorioMaterial.TabIndex = 0;
            this.grp_RelatorioMaterial.TabStop = false;
            // 
            // dtg_RelatorioMaterial
            // 
            this.dtg_RelatorioMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_RelatorioMaterial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_RelatorioMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_RelatorioMaterial.Location = new System.Drawing.Point(0, 0);
            this.dtg_RelatorioMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_RelatorioMaterial.Name = "dtg_RelatorioMaterial";
            this.dtg_RelatorioMaterial.RowHeadersWidth = 51;
            this.dtg_RelatorioMaterial.RowTemplate.Height = 24;
            this.dtg_RelatorioMaterial.Size = new System.Drawing.Size(1132, 519);
            this.dtg_RelatorioMaterial.TabIndex = 0;
            this.dtg_RelatorioMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_RelatorioMaterial_CellContentClick);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(913, 22);
            this.btn_Pesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(112, 48);
            this.btn_Pesquisar.TabIndex = 1;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Excel
            // 
            this.btn_Excel.Location = new System.Drawing.Point(1029, 22);
            this.btn_Excel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(112, 48);
            this.btn_Excel.TabIndex = 2;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // lbl_TipoMaterial
            // 
            this.lbl_TipoMaterial.AutoSize = true;
            this.lbl_TipoMaterial.Location = new System.Drawing.Point(12, 23);
            this.lbl_TipoMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TipoMaterial.Name = "lbl_TipoMaterial";
            this.lbl_TipoMaterial.Size = new System.Drawing.Size(118, 13);
            this.lbl_TipoMaterial.TabIndex = 3;
            this.lbl_TipoMaterial.Text = "Selecione Tipo Material";
            // 
            // lbl_Data1
            // 
            this.lbl_Data1.AutoSize = true;
            this.lbl_Data1.Location = new System.Drawing.Point(329, 23);
            this.lbl_Data1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Data1.Name = "lbl_Data1";
            this.lbl_Data1.Size = new System.Drawing.Size(99, 13);
            this.lbl_Data1.TabIndex = 4;
            this.lbl_Data1.Text = "Selecione as Datas";
            // 
            // dateTime_Data1
            // 
            this.dateTime_Data1.Location = new System.Drawing.Point(431, 22);
            this.dateTime_Data1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime_Data1.Name = "dateTime_Data1";
            this.dateTime_Data1.Size = new System.Drawing.Size(226, 20);
            this.dateTime_Data1.TabIndex = 6;
            // 
            // dateTime_Data2
            // 
            this.dateTime_Data2.Location = new System.Drawing.Point(661, 22);
            this.dateTime_Data2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime_Data2.Name = "dateTime_Data2";
            this.dateTime_Data2.Size = new System.Drawing.Size(226, 20);
            this.dateTime_Data2.TabIndex = 7;
            // 
            // cmb_TipoMaterial
            // 
            this.cmb_TipoMaterial.DataSource = this.spRelatorioMateriaisBuscarTipoBindingSource1;
            this.cmb_TipoMaterial.DisplayMember = "tipo";
            this.cmb_TipoMaterial.FormattingEnabled = true;
            this.cmb_TipoMaterial.Location = new System.Drawing.Point(154, 20);
            this.cmb_TipoMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_TipoMaterial.Name = "cmb_TipoMaterial";
            this.cmb_TipoMaterial.Size = new System.Drawing.Size(162, 21);
            this.cmb_TipoMaterial.TabIndex = 8;
            this.cmb_TipoMaterial.ValueMember = "tipo";
            // 
            // spRelatorioMateriaisBuscarTipoBindingSource1
            // 
            this.spRelatorioMateriaisBuscarTipoBindingSource1.DataMember = "sp_RelatorioMateriaisBuscarTipo";
            this.spRelatorioMateriaisBuscarTipoBindingSource1.DataSource = this.mBRMESSTOCKRelatorioBuscarTipoMateriais;
            // 
            // mBRMESSTOCKRelatorioBuscarTipoMateriais
            // 
            this.mBRMESSTOCKRelatorioBuscarTipoMateriais.DataSetName = "MBRMESSTOCKRelatorioBuscarTipoMateriais";
            this.mBRMESSTOCKRelatorioBuscarTipoMateriais.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spRelatorioMateriaisBuscarTipoBindingSource
            // 
            this.spRelatorioMateriaisBuscarTipoBindingSource.DataMember = "sp_RelatorioMateriaisBuscarTipo";
            // 
            // lbl_TotalMovimentacao
            // 
            this.lbl_TotalMovimentacao.AutoSize = true;
            this.lbl_TotalMovimentacao.Location = new System.Drawing.Point(329, 57);
            this.lbl_TotalMovimentacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TotalMovimentacao.Name = "lbl_TotalMovimentacao";
            this.lbl_TotalMovimentacao.Size = new System.Drawing.Size(119, 13);
            this.lbl_TotalMovimentacao.TabIndex = 21;
            this.lbl_TotalMovimentacao.Text = "Total de Movimentação";
            this.lbl_TotalMovimentacao.Click += new System.EventHandler(this.lbl_TotalMovimentacao_Click);
            // 
            // lbl_QuantidadeMaterial
            // 
            this.lbl_QuantidadeMaterial.AutoSize = true;
            this.lbl_QuantidadeMaterial.Location = new System.Drawing.Point(497, 57);
            this.lbl_QuantidadeMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_QuantidadeMaterial.Name = "lbl_QuantidadeMaterial";
            this.lbl_QuantidadeMaterial.Size = new System.Drawing.Size(122, 13);
            this.lbl_QuantidadeMaterial.TabIndex = 24;
            this.lbl_QuantidadeMaterial.Text = "Quantidade de Materiais";
            // 
            // sp_RelatorioMateriaisBuscarTipoTableAdapter
            // 
            this.sp_RelatorioMateriaisBuscarTipoTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_Media
            // 
            this.lbl_Media.AutoSize = true;
            this.lbl_Media.Location = new System.Drawing.Point(819, 57);
            this.lbl_Media.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Media.Name = "lbl_Media";
            this.lbl_Media.Size = new System.Drawing.Size(36, 13);
            this.lbl_Media.TabIndex = 25;
            this.lbl_Media.Text = "Média";
            // 
            // cmb_TipoMovimentacao
            // 
            this.cmb_TipoMovimentacao.FormattingEnabled = true;
            this.cmb_TipoMovimentacao.Items.AddRange(new object[] {
            "Todos",
            "Entrada",
            "Saida"});
            this.cmb_TipoMovimentacao.Location = new System.Drawing.Point(154, 54);
            this.cmb_TipoMovimentacao.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_TipoMovimentacao.Name = "cmb_TipoMovimentacao";
            this.cmb_TipoMovimentacao.Size = new System.Drawing.Size(162, 21);
            this.cmb_TipoMovimentacao.TabIndex = 27;
            // 
            // lbl_TipoMovimentacao
            // 
            this.lbl_TipoMovimentacao.AutoSize = true;
            this.lbl_TipoMovimentacao.Location = new System.Drawing.Point(12, 57);
            this.lbl_TipoMovimentacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TipoMovimentacao.Name = "lbl_TipoMovimentacao";
            this.lbl_TipoMovimentacao.Size = new System.Drawing.Size(127, 13);
            this.lbl_TipoMovimentacao.TabIndex = 26;
            this.lbl_TipoMovimentacao.Text = "Selecione Movimentação";
            // 
            // FrmRelatorioMateriais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 612);
            this.Controls.Add(this.cmb_TipoMovimentacao);
            this.Controls.Add(this.lbl_TipoMovimentacao);
            this.Controls.Add(this.lbl_Media);
            this.Controls.Add(this.lbl_QuantidadeMaterial);
            this.Controls.Add(this.lbl_TotalMovimentacao);
            this.Controls.Add(this.cmb_TipoMaterial);
            this.Controls.Add(this.dateTime_Data2);
            this.Controls.Add(this.dateTime_Data1);
            this.Controls.Add(this.lbl_Data1);
            this.Controls.Add(this.lbl_TipoMaterial);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.grp_RelatorioMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRelatorioMateriais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Relatório";
            this.Load += new System.EventHandler(this.FrmRelatorioMateriais_Load);
            this.grp_RelatorioMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RelatorioMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRelatorioMateriaisBuscarTipoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBRMESSTOCKRelatorioBuscarTipoMateriais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRelatorioMateriaisBuscarTipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_RelatorioMaterial;
        private System.Windows.Forms.DataGridView dtg_RelatorioMaterial;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Label lbl_TipoMaterial;
        private System.Windows.Forms.Label lbl_Data1;
        private System.Windows.Forms.DateTimePicker dateTime_Data1;
        private System.Windows.Forms.DateTimePicker dateTime_Data2;
        private System.Windows.Forms.ComboBox cmb_TipoMaterial;
        private System.Windows.Forms.Label lbl_TotalMovimentacao;
        private System.Windows.Forms.Label lbl_QuantidadeMaterial;
        private System.Windows.Forms.BindingSource spRelatorioMateriaisBuscarTipoBindingSource;
        private MBRMESSTOCKRelatorioBuscarTipoMateriais mBRMESSTOCKRelatorioBuscarTipoMateriais;
        private System.Windows.Forms.BindingSource spRelatorioMateriaisBuscarTipoBindingSource1;
        private MBRMESSTOCKRelatorioBuscarTipoMateriaisTableAdapters.sp_RelatorioMateriaisBuscarTipoTableAdapter sp_RelatorioMateriaisBuscarTipoTableAdapter;
        private System.Windows.Forms.Label lbl_Media;
        private System.Windows.Forms.ComboBox cmb_TipoMovimentacao;
        private System.Windows.Forms.Label lbl_TipoMovimentacao;
    }
}