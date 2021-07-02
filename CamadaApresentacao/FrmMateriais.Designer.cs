namespace CamadaApresentacao
{
    partial class FrmMateriais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMateriais));
            this.grp_Materiais = new System.Windows.Forms.GroupBox();
            this.tbc_Materiais = new System.Windows.Forms.TabControl();
            this.tb1_BuscarMateriais = new System.Windows.Forms.TabPage();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.chk_DeleteMateriais = new System.Windows.Forms.CheckBox();
            this.chk_TodosMateriais = new System.Windows.Forms.CheckBox();
            this.lbl_BuscarTipoMateriais = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_BuscarMateriais = new System.Windows.Forms.ComboBox();
            this.spBuscarTipoMateriaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mBRMESSTOCK_BuscarTipoMateriais = new CamadaApresentacao.MBRMESSTOCK_BuscarTipoMateriais();
            this.dtg_BuscarMateriais = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tb2_ConfiguracaoMateriais = new System.Windows.Forms.TabPage();
            this.txt_ConfDescicaoMateriais = new System.Windows.Forms.TextBox();
            this.txt_ConfIdFuncionario = new System.Windows.Forms.TextBox();
            this.txt_ConfQuantidadeMateriais = new System.Windows.Forms.TextBox();
            this.txt_ConfModeloMateriais = new System.Windows.Forms.TextBox();
            this.txt_ConfTipoMateriais = new System.Windows.Forms.TextBox();
            this.txt_ConfIdMateriais = new System.Windows.Forms.TextBox();
            this.lbl_ConfDataAtual = new System.Windows.Forms.Label();
            this.lbl_ConfDescricaoMateriais = new System.Windows.Forms.Label();
            this.lbl_ConfIdFuncionario = new System.Windows.Forms.Label();
            this.lbl_ConfQuantidadeMateriais = new System.Windows.Forms.Label();
            this.lbl_ConfModeloMateriais = new System.Windows.Forms.Label();
            this.lbl_ConfTipoMateriais = new System.Windows.Forms.Label();
            this.lbl_ConfIdMateriais = new System.Windows.Forms.Label();
            this.lbl_ConfiguracaoMateriais = new System.Windows.Forms.Label();
            this.btn_ConfCancelar = new System.Windows.Forms.Button();
            this.btn_ConfSalvar = new System.Windows.Forms.Button();
            this.btn_ConfEditar = new System.Windows.Forms.Button();
            this.btn_ConfNovo = new System.Windows.Forms.Button();
            this.tb3_MovimentacaoMateriais = new System.Windows.Forms.TabPage();
            this.btn_MovCancelar = new System.Windows.Forms.Button();
            this.btn_MovSalvar = new System.Windows.Forms.Button();
            this.chk_MovSaidaMateriais = new System.Windows.Forms.CheckBox();
            this.chk_MovEntradaMateriais = new System.Windows.Forms.CheckBox();
            this.txt_MovQuantidadeMateriais = new System.Windows.Forms.TextBox();
            this.txt_MovModeloMateriais = new System.Windows.Forms.TextBox();
            this.txt_MovTipoMateriais = new System.Windows.Forms.TextBox();
            this.txt_MovIdMateriais = new System.Windows.Forms.TextBox();
            this.lbl_MovDataAtual = new System.Windows.Forms.Label();
            this.lbl_MovQuantidadeMateriais = new System.Windows.Forms.Label();
            this.lbl_MovModeloMateriais = new System.Windows.Forms.Label();
            this.lbl_MovTipoMateriais = new System.Windows.Forms.Label();
            this.lbl_MovIdMateriais = new System.Windows.Forms.Label();
            this.lbl_MovimantacaoMateriais = new System.Windows.Forms.Label();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.tt_Mensagem = new System.Windows.Forms.ToolTip(this.components);
            this.tmData = new System.Windows.Forms.Timer(this.components);
            this.lbl_ControleMateriais = new System.Windows.Forms.Label();
            this.sp_BuscarTipoMateriaisTableAdapter = new CamadaApresentacao.MBRMESSTOCK_BuscarTipoMateriaisTableAdapters.sp_BuscarTipoMateriaisTableAdapter();
            this.grp_Materiais.SuspendLayout();
            this.tbc_Materiais.SuspendLayout();
            this.tb1_BuscarMateriais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarTipoMateriaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBRMESSTOCK_BuscarTipoMateriais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BuscarMateriais)).BeginInit();
            this.tb2_ConfiguracaoMateriais.SuspendLayout();
            this.tb3_MovimentacaoMateriais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Materiais
            // 
            this.grp_Materiais.Controls.Add(this.tbc_Materiais);
            this.grp_Materiais.Location = new System.Drawing.Point(9, 54);
            this.grp_Materiais.Margin = new System.Windows.Forms.Padding(2);
            this.grp_Materiais.Name = "grp_Materiais";
            this.grp_Materiais.Padding = new System.Windows.Forms.Padding(2);
            this.grp_Materiais.Size = new System.Drawing.Size(1094, 466);
            this.grp_Materiais.TabIndex = 0;
            this.grp_Materiais.TabStop = false;
            this.grp_Materiais.Text = "groupBox1";
            // 
            // tbc_Materiais
            // 
            this.tbc_Materiais.Controls.Add(this.tb1_BuscarMateriais);
            this.tbc_Materiais.Controls.Add(this.tb2_ConfiguracaoMateriais);
            this.tbc_Materiais.Controls.Add(this.tb3_MovimentacaoMateriais);
            this.tbc_Materiais.Location = new System.Drawing.Point(0, 0);
            this.tbc_Materiais.Margin = new System.Windows.Forms.Padding(2);
            this.tbc_Materiais.Name = "tbc_Materiais";
            this.tbc_Materiais.SelectedIndex = 0;
            this.tbc_Materiais.Size = new System.Drawing.Size(1094, 466);
            this.tbc_Materiais.TabIndex = 0;
            // 
            // tb1_BuscarMateriais
            // 
            this.tb1_BuscarMateriais.BackColor = System.Drawing.Color.White;
            this.tb1_BuscarMateriais.Controls.Add(this.lbl_Total);
            this.tb1_BuscarMateriais.Controls.Add(this.btn_Deletar);
            this.tb1_BuscarMateriais.Controls.Add(this.btn_Buscar);
            this.tb1_BuscarMateriais.Controls.Add(this.chk_DeleteMateriais);
            this.tb1_BuscarMateriais.Controls.Add(this.chk_TodosMateriais);
            this.tb1_BuscarMateriais.Controls.Add(this.lbl_BuscarTipoMateriais);
            this.tb1_BuscarMateriais.Controls.Add(this.label1);
            this.tb1_BuscarMateriais.Controls.Add(this.cmb_BuscarMateriais);
            this.tb1_BuscarMateriais.Controls.Add(this.dtg_BuscarMateriais);
            this.tb1_BuscarMateriais.Location = new System.Drawing.Point(4, 22);
            this.tb1_BuscarMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.tb1_BuscarMateriais.Name = "tb1_BuscarMateriais";
            this.tb1_BuscarMateriais.Padding = new System.Windows.Forms.Padding(2);
            this.tb1_BuscarMateriais.Size = new System.Drawing.Size(1086, 440);
            this.tb1_BuscarMateriais.TabIndex = 0;
            this.tb1_BuscarMateriais.Text = "Pesquisar";
            this.tb1_BuscarMateriais.Click += new System.EventHandler(this.tb1_BuscarMateriais_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(312, 13);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(99, 13);
            this.lbl_Total.TabIndex = 20;
            this.lbl_Total.Text = "Total de Registros: ";
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Location = new System.Drawing.Point(972, 25);
            this.btn_Deletar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(111, 49);
            this.btn_Deletar.TabIndex = 19;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(856, 25);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(111, 49);
            this.btn_Buscar.TabIndex = 18;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // chk_DeleteMateriais
            // 
            this.chk_DeleteMateriais.AutoSize = true;
            this.chk_DeleteMateriais.Location = new System.Drawing.Point(756, 50);
            this.chk_DeleteMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.chk_DeleteMateriais.Name = "chk_DeleteMateriais";
            this.chk_DeleteMateriais.Size = new System.Drawing.Size(60, 17);
            this.chk_DeleteMateriais.TabIndex = 17;
            this.chk_DeleteMateriais.Text = "Deletar";
            this.chk_DeleteMateriais.UseVisualStyleBackColor = true;
            this.chk_DeleteMateriais.CheckedChanged += new System.EventHandler(this.chk_DeleteMateriais_CheckedChanged);
            // 
            // chk_TodosMateriais
            // 
            this.chk_TodosMateriais.AutoSize = true;
            this.chk_TodosMateriais.Location = new System.Drawing.Point(314, 50);
            this.chk_TodosMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.chk_TodosMateriais.Name = "chk_TodosMateriais";
            this.chk_TodosMateriais.Size = new System.Drawing.Size(56, 17);
            this.chk_TodosMateriais.TabIndex = 16;
            this.chk_TodosMateriais.Text = "Todos";
            this.chk_TodosMateriais.UseVisualStyleBackColor = true;
            // 
            // lbl_BuscarTipoMateriais
            // 
            this.lbl_BuscarTipoMateriais.AutoSize = true;
            this.lbl_BuscarTipoMateriais.Location = new System.Drawing.Point(15, 50);
            this.lbl_BuscarTipoMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BuscarTipoMateriais.Name = "lbl_BuscarTipoMateriais";
            this.lbl_BuscarTipoMateriais.Size = new System.Drawing.Size(87, 13);
            this.lbl_BuscarTipoMateriais.TabIndex = 15;
            this.lbl_BuscarTipoMateriais.Text = "Selecione o Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar Materiais";
            // 
            // cmb_BuscarMateriais
            // 
            this.cmb_BuscarMateriais.DataSource = this.spBuscarTipoMateriaisBindingSource;
            this.cmb_BuscarMateriais.DisplayMember = "tipo";
            this.cmb_BuscarMateriais.FormattingEnabled = true;
            this.cmb_BuscarMateriais.Location = new System.Drawing.Point(105, 48);
            this.cmb_BuscarMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_BuscarMateriais.Name = "cmb_BuscarMateriais";
            this.cmb_BuscarMateriais.Size = new System.Drawing.Size(194, 21);
            this.cmb_BuscarMateriais.TabIndex = 13;
            this.cmb_BuscarMateriais.ValueMember = "tipo";
            // 
            // spBuscarTipoMateriaisBindingSource
            // 
            this.spBuscarTipoMateriaisBindingSource.DataMember = "sp_BuscarTipoMateriais";
            this.spBuscarTipoMateriaisBindingSource.DataSource = this.mBRMESSTOCK_BuscarTipoMateriais;
            // 
            // mBRMESSTOCK_BuscarTipoMateriais
            // 
            this.mBRMESSTOCK_BuscarTipoMateriais.DataSetName = "MBRMESSTOCK_BuscarTipoMateriais";
            this.mBRMESSTOCK_BuscarTipoMateriais.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtg_BuscarMateriais
            // 
            this.dtg_BuscarMateriais.AllowUserToAddRows = false;
            this.dtg_BuscarMateriais.AllowUserToDeleteRows = false;
            this.dtg_BuscarMateriais.AllowUserToOrderColumns = true;
            this.dtg_BuscarMateriais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_BuscarMateriais.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_BuscarMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_BuscarMateriais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir});
            this.dtg_BuscarMateriais.Location = new System.Drawing.Point(0, 79);
            this.dtg_BuscarMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_BuscarMateriais.MultiSelect = false;
            this.dtg_BuscarMateriais.Name = "dtg_BuscarMateriais";
            this.dtg_BuscarMateriais.ReadOnly = true;
            this.dtg_BuscarMateriais.RowHeadersWidth = 51;
            this.dtg_BuscarMateriais.RowTemplate.Height = 24;
            this.dtg_BuscarMateriais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_BuscarMateriais.Size = new System.Drawing.Size(1085, 362);
            this.dtg_BuscarMateriais.TabIndex = 12;
            this.dtg_BuscarMateriais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_BuscarMateriais_CellContentClick);
            this.dtg_BuscarMateriais.DoubleClick += new System.EventHandler(this.dtg_BuscarMateriais_DoubleClick);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.MinimumWidth = 6;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 44;
            // 
            // tb2_ConfiguracaoMateriais
            // 
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.txt_ConfDescicaoMateriais);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.txt_ConfIdFuncionario);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.txt_ConfQuantidadeMateriais);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.txt_ConfModeloMateriais);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.txt_ConfTipoMateriais);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.txt_ConfIdMateriais);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.lbl_ConfDataAtual);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.lbl_ConfDescricaoMateriais);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.lbl_ConfIdFuncionario);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.lbl_ConfQuantidadeMateriais);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.lbl_ConfModeloMateriais);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.lbl_ConfTipoMateriais);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.lbl_ConfIdMateriais);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.lbl_ConfiguracaoMateriais);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.btn_ConfCancelar);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.btn_ConfSalvar);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.btn_ConfEditar);
            this.tb2_ConfiguracaoMateriais.Controls.Add(this.btn_ConfNovo);
            this.tb2_ConfiguracaoMateriais.Location = new System.Drawing.Point(4, 22);
            this.tb2_ConfiguracaoMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.tb2_ConfiguracaoMateriais.Name = "tb2_ConfiguracaoMateriais";
            this.tb2_ConfiguracaoMateriais.Padding = new System.Windows.Forms.Padding(2);
            this.tb2_ConfiguracaoMateriais.Size = new System.Drawing.Size(1086, 440);
            this.tb2_ConfiguracaoMateriais.TabIndex = 1;
            this.tb2_ConfiguracaoMateriais.Text = "Configurações";
            this.tb2_ConfiguracaoMateriais.UseVisualStyleBackColor = true;
            // 
            // txt_ConfDescicaoMateriais
            // 
            this.txt_ConfDescicaoMateriais.Location = new System.Drawing.Point(527, 186);
            this.txt_ConfDescicaoMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ConfDescicaoMateriais.Multiline = true;
            this.txt_ConfDescicaoMateriais.Name = "txt_ConfDescicaoMateriais";
            this.txt_ConfDescicaoMateriais.Size = new System.Drawing.Size(548, 161);
            this.txt_ConfDescicaoMateriais.TabIndex = 38;
            // 
            // txt_ConfIdFuncionario
            // 
            this.txt_ConfIdFuncionario.Location = new System.Drawing.Point(527, 119);
            this.txt_ConfIdFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ConfIdFuncionario.Name = "txt_ConfIdFuncionario";
            this.txt_ConfIdFuncionario.Size = new System.Drawing.Size(209, 20);
            this.txt_ConfIdFuncionario.TabIndex = 37;
            // 
            // txt_ConfQuantidadeMateriais
            // 
            this.txt_ConfQuantidadeMateriais.Location = new System.Drawing.Point(527, 54);
            this.txt_ConfQuantidadeMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ConfQuantidadeMateriais.Name = "txt_ConfQuantidadeMateriais";
            this.txt_ConfQuantidadeMateriais.Size = new System.Drawing.Size(98, 20);
            this.txt_ConfQuantidadeMateriais.TabIndex = 36;
            // 
            // txt_ConfModeloMateriais
            // 
            this.txt_ConfModeloMateriais.Location = new System.Drawing.Point(168, 189);
            this.txt_ConfModeloMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ConfModeloMateriais.Name = "txt_ConfModeloMateriais";
            this.txt_ConfModeloMateriais.Size = new System.Drawing.Size(209, 20);
            this.txt_ConfModeloMateriais.TabIndex = 35;
            // 
            // txt_ConfTipoMateriais
            // 
            this.txt_ConfTipoMateriais.Location = new System.Drawing.Point(168, 120);
            this.txt_ConfTipoMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ConfTipoMateriais.Name = "txt_ConfTipoMateriais";
            this.txt_ConfTipoMateriais.Size = new System.Drawing.Size(209, 20);
            this.txt_ConfTipoMateriais.TabIndex = 34;
            // 
            // txt_ConfIdMateriais
            // 
            this.txt_ConfIdMateriais.Location = new System.Drawing.Point(168, 55);
            this.txt_ConfIdMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ConfIdMateriais.Name = "txt_ConfIdMateriais";
            this.txt_ConfIdMateriais.Size = new System.Drawing.Size(209, 20);
            this.txt_ConfIdMateriais.TabIndex = 33;
            // 
            // lbl_ConfDataAtual
            // 
            this.lbl_ConfDataAtual.AutoSize = true;
            this.lbl_ConfDataAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfDataAtual.Location = new System.Drawing.Point(18, 392);
            this.lbl_ConfDataAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ConfDataAtual.Name = "lbl_ConfDataAtual";
            this.lbl_ConfDataAtual.Size = new System.Drawing.Size(44, 20);
            this.lbl_ConfDataAtual.TabIndex = 32;
            this.lbl_ConfDataAtual.Text = "Data";
            // 
            // lbl_ConfDescricaoMateriais
            // 
            this.lbl_ConfDescricaoMateriais.AutoSize = true;
            this.lbl_ConfDescricaoMateriais.Location = new System.Drawing.Point(436, 188);
            this.lbl_ConfDescricaoMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ConfDescricaoMateriais.Name = "lbl_ConfDescricaoMateriais";
            this.lbl_ConfDescricaoMateriais.Size = new System.Drawing.Size(55, 13);
            this.lbl_ConfDescricaoMateriais.TabIndex = 31;
            this.lbl_ConfDescricaoMateriais.Text = "Descrição";
            // 
            // lbl_ConfIdFuncionario
            // 
            this.lbl_ConfIdFuncionario.AutoSize = true;
            this.lbl_ConfIdFuncionario.Location = new System.Drawing.Point(436, 121);
            this.lbl_ConfIdFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ConfIdFuncionario.Name = "lbl_ConfIdFuncionario";
            this.lbl_ConfIdFuncionario.Size = new System.Drawing.Size(76, 13);
            this.lbl_ConfIdFuncionario.TabIndex = 30;
            this.lbl_ConfIdFuncionario.Text = "ID Funcionário";
            // 
            // lbl_ConfQuantidadeMateriais
            // 
            this.lbl_ConfQuantidadeMateriais.AutoSize = true;
            this.lbl_ConfQuantidadeMateriais.Location = new System.Drawing.Point(436, 56);
            this.lbl_ConfQuantidadeMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ConfQuantidadeMateriais.Name = "lbl_ConfQuantidadeMateriais";
            this.lbl_ConfQuantidadeMateriais.Size = new System.Drawing.Size(62, 13);
            this.lbl_ConfQuantidadeMateriais.TabIndex = 29;
            this.lbl_ConfQuantidadeMateriais.Text = "Quantidade";
            // 
            // lbl_ConfModeloMateriais
            // 
            this.lbl_ConfModeloMateriais.AutoSize = true;
            this.lbl_ConfModeloMateriais.Location = new System.Drawing.Point(67, 190);
            this.lbl_ConfModeloMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ConfModeloMateriais.Name = "lbl_ConfModeloMateriais";
            this.lbl_ConfModeloMateriais.Size = new System.Drawing.Size(82, 13);
            this.lbl_ConfModeloMateriais.TabIndex = 28;
            this.lbl_ConfModeloMateriais.Text = "Modelo Material";
            // 
            // lbl_ConfTipoMateriais
            // 
            this.lbl_ConfTipoMateriais.AutoSize = true;
            this.lbl_ConfTipoMateriais.Location = new System.Drawing.Point(67, 121);
            this.lbl_ConfTipoMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ConfTipoMateriais.Name = "lbl_ConfTipoMateriais";
            this.lbl_ConfTipoMateriais.Size = new System.Drawing.Size(68, 13);
            this.lbl_ConfTipoMateriais.TabIndex = 27;
            this.lbl_ConfTipoMateriais.Text = "Tipo Material";
            // 
            // lbl_ConfIdMateriais
            // 
            this.lbl_ConfIdMateriais.AutoSize = true;
            this.lbl_ConfIdMateriais.Location = new System.Drawing.Point(67, 58);
            this.lbl_ConfIdMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ConfIdMateriais.Name = "lbl_ConfIdMateriais";
            this.lbl_ConfIdMateriais.Size = new System.Drawing.Size(58, 13);
            this.lbl_ConfIdMateriais.TabIndex = 26;
            this.lbl_ConfIdMateriais.Text = "ID Material";
            // 
            // lbl_ConfiguracaoMateriais
            // 
            this.lbl_ConfiguracaoMateriais.AutoSize = true;
            this.lbl_ConfiguracaoMateriais.Location = new System.Drawing.Point(18, 11);
            this.lbl_ConfiguracaoMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ConfiguracaoMateriais.Name = "lbl_ConfiguracaoMateriais";
            this.lbl_ConfiguracaoMateriais.Size = new System.Drawing.Size(120, 13);
            this.lbl_ConfiguracaoMateriais.TabIndex = 25;
            this.lbl_ConfiguracaoMateriais.Text = "Configurações Materiais";
            // 
            // btn_ConfCancelar
            // 
            this.btn_ConfCancelar.Location = new System.Drawing.Point(970, 392);
            this.btn_ConfCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConfCancelar.Name = "btn_ConfCancelar";
            this.btn_ConfCancelar.Size = new System.Drawing.Size(104, 36);
            this.btn_ConfCancelar.TabIndex = 24;
            this.btn_ConfCancelar.Text = "Cancelar";
            this.btn_ConfCancelar.UseVisualStyleBackColor = true;
            this.btn_ConfCancelar.Click += new System.EventHandler(this.btn_ConfCancelar_Click);
            // 
            // btn_ConfSalvar
            // 
            this.btn_ConfSalvar.Location = new System.Drawing.Point(861, 392);
            this.btn_ConfSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConfSalvar.Name = "btn_ConfSalvar";
            this.btn_ConfSalvar.Size = new System.Drawing.Size(104, 36);
            this.btn_ConfSalvar.TabIndex = 23;
            this.btn_ConfSalvar.Text = "Salvar";
            this.btn_ConfSalvar.UseVisualStyleBackColor = true;
            this.btn_ConfSalvar.Click += new System.EventHandler(this.btn_ConfSalvar_Click);
            // 
            // btn_ConfEditar
            // 
            this.btn_ConfEditar.Location = new System.Drawing.Point(752, 392);
            this.btn_ConfEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConfEditar.Name = "btn_ConfEditar";
            this.btn_ConfEditar.Size = new System.Drawing.Size(104, 36);
            this.btn_ConfEditar.TabIndex = 22;
            this.btn_ConfEditar.Text = "Editar";
            this.btn_ConfEditar.UseVisualStyleBackColor = true;
            this.btn_ConfEditar.Click += new System.EventHandler(this.btn_ConfEditar_Click);
            // 
            // btn_ConfNovo
            // 
            this.btn_ConfNovo.Location = new System.Drawing.Point(644, 392);
            this.btn_ConfNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConfNovo.Name = "btn_ConfNovo";
            this.btn_ConfNovo.Size = new System.Drawing.Size(104, 36);
            this.btn_ConfNovo.TabIndex = 21;
            this.btn_ConfNovo.Text = "Novo";
            this.btn_ConfNovo.UseVisualStyleBackColor = true;
            this.btn_ConfNovo.Click += new System.EventHandler(this.btn_ConfNovo_Click);
            // 
            // tb3_MovimentacaoMateriais
            // 
            this.tb3_MovimentacaoMateriais.Controls.Add(this.btn_MovCancelar);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.btn_MovSalvar);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.chk_MovSaidaMateriais);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.chk_MovEntradaMateriais);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.txt_MovQuantidadeMateriais);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.txt_MovModeloMateriais);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.txt_MovTipoMateriais);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.txt_MovIdMateriais);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.lbl_MovDataAtual);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.lbl_MovQuantidadeMateriais);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.lbl_MovModeloMateriais);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.lbl_MovTipoMateriais);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.lbl_MovIdMateriais);
            this.tb3_MovimentacaoMateriais.Controls.Add(this.lbl_MovimantacaoMateriais);
            this.tb3_MovimentacaoMateriais.Location = new System.Drawing.Point(4, 22);
            this.tb3_MovimentacaoMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.tb3_MovimentacaoMateriais.Name = "tb3_MovimentacaoMateriais";
            this.tb3_MovimentacaoMateriais.Padding = new System.Windows.Forms.Padding(2);
            this.tb3_MovimentacaoMateriais.Size = new System.Drawing.Size(1086, 440);
            this.tb3_MovimentacaoMateriais.TabIndex = 2;
            this.tb3_MovimentacaoMateriais.Text = "Movimentação";
            this.tb3_MovimentacaoMateriais.UseVisualStyleBackColor = true;
            this.tb3_MovimentacaoMateriais.Click += new System.EventHandler(this.tb3_MovimentacaoMateriais_Click);
            // 
            // btn_MovCancelar
            // 
            this.btn_MovCancelar.Location = new System.Drawing.Point(971, 392);
            this.btn_MovCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MovCancelar.Name = "btn_MovCancelar";
            this.btn_MovCancelar.Size = new System.Drawing.Size(104, 36);
            this.btn_MovCancelar.TabIndex = 28;
            this.btn_MovCancelar.Text = "Cancelar";
            this.btn_MovCancelar.UseVisualStyleBackColor = true;
            this.btn_MovCancelar.Click += new System.EventHandler(this.btn_MovCancelar_Click);
            // 
            // btn_MovSalvar
            // 
            this.btn_MovSalvar.Location = new System.Drawing.Point(862, 392);
            this.btn_MovSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MovSalvar.Name = "btn_MovSalvar";
            this.btn_MovSalvar.Size = new System.Drawing.Size(104, 36);
            this.btn_MovSalvar.TabIndex = 27;
            this.btn_MovSalvar.Text = "Salvar";
            this.btn_MovSalvar.UseVisualStyleBackColor = true;
            this.btn_MovSalvar.Click += new System.EventHandler(this.btn_MovSalvar_Click);
            // 
            // chk_MovSaidaMateriais
            // 
            this.chk_MovSaidaMateriais.AutoSize = true;
            this.chk_MovSaidaMateriais.Location = new System.Drawing.Point(619, 169);
            this.chk_MovSaidaMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.chk_MovSaidaMateriais.Name = "chk_MovSaidaMateriais";
            this.chk_MovSaidaMateriais.Size = new System.Drawing.Size(55, 17);
            this.chk_MovSaidaMateriais.TabIndex = 11;
            this.chk_MovSaidaMateriais.Text = "Saída";
            this.chk_MovSaidaMateriais.UseVisualStyleBackColor = true;
            // 
            // chk_MovEntradaMateriais
            // 
            this.chk_MovEntradaMateriais.AutoSize = true;
            this.chk_MovEntradaMateriais.Location = new System.Drawing.Point(494, 170);
            this.chk_MovEntradaMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.chk_MovEntradaMateriais.Name = "chk_MovEntradaMateriais";
            this.chk_MovEntradaMateriais.Size = new System.Drawing.Size(63, 17);
            this.chk_MovEntradaMateriais.TabIndex = 10;
            this.chk_MovEntradaMateriais.Text = "Entrada";
            this.chk_MovEntradaMateriais.UseVisualStyleBackColor = true;
            // 
            // txt_MovQuantidadeMateriais
            // 
            this.txt_MovQuantidadeMateriais.Location = new System.Drawing.Point(572, 53);
            this.txt_MovQuantidadeMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MovQuantidadeMateriais.Name = "txt_MovQuantidadeMateriais";
            this.txt_MovQuantidadeMateriais.Size = new System.Drawing.Size(98, 20);
            this.txt_MovQuantidadeMateriais.TabIndex = 9;
            // 
            // txt_MovModeloMateriais
            // 
            this.txt_MovModeloMateriais.Location = new System.Drawing.Point(209, 169);
            this.txt_MovModeloMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MovModeloMateriais.Name = "txt_MovModeloMateriais";
            this.txt_MovModeloMateriais.Size = new System.Drawing.Size(216, 20);
            this.txt_MovModeloMateriais.TabIndex = 8;
            // 
            // txt_MovTipoMateriais
            // 
            this.txt_MovTipoMateriais.Location = new System.Drawing.Point(209, 109);
            this.txt_MovTipoMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MovTipoMateriais.Name = "txt_MovTipoMateriais";
            this.txt_MovTipoMateriais.Size = new System.Drawing.Size(216, 20);
            this.txt_MovTipoMateriais.TabIndex = 7;
            // 
            // txt_MovIdMateriais
            // 
            this.txt_MovIdMateriais.Location = new System.Drawing.Point(209, 53);
            this.txt_MovIdMateriais.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MovIdMateriais.Name = "txt_MovIdMateriais";
            this.txt_MovIdMateriais.Size = new System.Drawing.Size(216, 20);
            this.txt_MovIdMateriais.TabIndex = 6;
            // 
            // lbl_MovDataAtual
            // 
            this.lbl_MovDataAtual.AutoSize = true;
            this.lbl_MovDataAtual.Location = new System.Drawing.Point(491, 111);
            this.lbl_MovDataAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MovDataAtual.Name = "lbl_MovDataAtual";
            this.lbl_MovDataAtual.Size = new System.Drawing.Size(30, 13);
            this.lbl_MovDataAtual.TabIndex = 5;
            this.lbl_MovDataAtual.Text = "Data";
            // 
            // lbl_MovQuantidadeMateriais
            // 
            this.lbl_MovQuantidadeMateriais.AutoSize = true;
            this.lbl_MovQuantidadeMateriais.Location = new System.Drawing.Point(491, 55);
            this.lbl_MovQuantidadeMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MovQuantidadeMateriais.Name = "lbl_MovQuantidadeMateriais";
            this.lbl_MovQuantidadeMateriais.Size = new System.Drawing.Size(62, 13);
            this.lbl_MovQuantidadeMateriais.TabIndex = 4;
            this.lbl_MovQuantidadeMateriais.Text = "Quantidade";
            // 
            // lbl_MovModeloMateriais
            // 
            this.lbl_MovModeloMateriais.AutoSize = true;
            this.lbl_MovModeloMateriais.Location = new System.Drawing.Point(86, 173);
            this.lbl_MovModeloMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MovModeloMateriais.Name = "lbl_MovModeloMateriais";
            this.lbl_MovModeloMateriais.Size = new System.Drawing.Size(82, 13);
            this.lbl_MovModeloMateriais.TabIndex = 3;
            this.lbl_MovModeloMateriais.Text = "Modelo Material";
            // 
            // lbl_MovTipoMateriais
            // 
            this.lbl_MovTipoMateriais.AutoSize = true;
            this.lbl_MovTipoMateriais.Location = new System.Drawing.Point(86, 113);
            this.lbl_MovTipoMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MovTipoMateriais.Name = "lbl_MovTipoMateriais";
            this.lbl_MovTipoMateriais.Size = new System.Drawing.Size(68, 13);
            this.lbl_MovTipoMateriais.TabIndex = 2;
            this.lbl_MovTipoMateriais.Text = "Tipo Material";
            // 
            // lbl_MovIdMateriais
            // 
            this.lbl_MovIdMateriais.AutoSize = true;
            this.lbl_MovIdMateriais.Location = new System.Drawing.Point(86, 57);
            this.lbl_MovIdMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MovIdMateriais.Name = "lbl_MovIdMateriais";
            this.lbl_MovIdMateriais.Size = new System.Drawing.Size(58, 13);
            this.lbl_MovIdMateriais.TabIndex = 1;
            this.lbl_MovIdMateriais.Text = "ID Material";
            // 
            // lbl_MovimantacaoMateriais
            // 
            this.lbl_MovimantacaoMateriais.AutoSize = true;
            this.lbl_MovimantacaoMateriais.Location = new System.Drawing.Point(18, 12);
            this.lbl_MovimantacaoMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MovimantacaoMateriais.Name = "lbl_MovimantacaoMateriais";
            this.lbl_MovimantacaoMateriais.Size = new System.Drawing.Size(122, 13);
            this.lbl_MovimantacaoMateriais.TabIndex = 0;
            this.lbl_MovimantacaoMateriais.Text = "Movimentação Materiais";
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // tt_Mensagem
            // 
            this.tt_Mensagem.IsBalloon = true;
            // 
            // tmData
            // 
            this.tmData.Tick += new System.EventHandler(this.tmData_Tick);
            // 
            // lbl_ControleMateriais
            // 
            this.lbl_ControleMateriais.AutoSize = true;
            this.lbl_ControleMateriais.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ControleMateriais.Location = new System.Drawing.Point(14, 17);
            this.lbl_ControleMateriais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ControleMateriais.Name = "lbl_ControleMateriais";
            this.lbl_ControleMateriais.Size = new System.Drawing.Size(123, 18);
            this.lbl_ControleMateriais.TabIndex = 4;
            this.lbl_ControleMateriais.Text = "Controle Materiais";
            // 
            // sp_BuscarTipoMateriaisTableAdapter
            // 
            this.sp_BuscarTipoMateriaisTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMateriais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 531);
            this.Controls.Add(this.lbl_ControleMateriais);
            this.Controls.Add(this.grp_Materiais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMateriais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Materiais";
            this.Load += new System.EventHandler(this.FrmMateriais_Load);
            this.grp_Materiais.ResumeLayout(false);
            this.tbc_Materiais.ResumeLayout(false);
            this.tb1_BuscarMateriais.ResumeLayout(false);
            this.tb1_BuscarMateriais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarTipoMateriaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBRMESSTOCK_BuscarTipoMateriais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BuscarMateriais)).EndInit();
            this.tb2_ConfiguracaoMateriais.ResumeLayout(false);
            this.tb2_ConfiguracaoMateriais.PerformLayout();
            this.tb3_MovimentacaoMateriais.ResumeLayout(false);
            this.tb3_MovimentacaoMateriais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Materiais;
        private System.Windows.Forms.TabControl tbc_Materiais;
        private System.Windows.Forms.TabPage tb1_BuscarMateriais;
        private System.Windows.Forms.TabPage tb2_ConfiguracaoMateriais;
        private System.Windows.Forms.TabPage tb3_MovimentacaoMateriais;
        private System.Windows.Forms.CheckBox chk_DeleteMateriais;
        private System.Windows.Forms.CheckBox chk_TodosMateriais;
        private System.Windows.Forms.Label lbl_BuscarTipoMateriais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_BuscarMateriais;
        private System.Windows.Forms.DataGridView dtg_BuscarMateriais;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.ToolTip tt_Mensagem;
        private System.Windows.Forms.TextBox txt_ConfDescicaoMateriais;
        private System.Windows.Forms.TextBox txt_ConfIdFuncionario;
        private System.Windows.Forms.TextBox txt_ConfQuantidadeMateriais;
        private System.Windows.Forms.TextBox txt_ConfModeloMateriais;
        private System.Windows.Forms.TextBox txt_ConfTipoMateriais;
        private System.Windows.Forms.TextBox txt_ConfIdMateriais;
        private System.Windows.Forms.Label lbl_ConfDataAtual;
        private System.Windows.Forms.Label lbl_ConfDescricaoMateriais;
        private System.Windows.Forms.Label lbl_ConfIdFuncionario;
        private System.Windows.Forms.Label lbl_ConfQuantidadeMateriais;
        private System.Windows.Forms.Label lbl_ConfModeloMateriais;
        private System.Windows.Forms.Label lbl_ConfTipoMateriais;
        private System.Windows.Forms.Label lbl_ConfIdMateriais;
        private System.Windows.Forms.Label lbl_ConfiguracaoMateriais;
        private System.Windows.Forms.Button btn_ConfCancelar;
        private System.Windows.Forms.Button btn_ConfSalvar;
        private System.Windows.Forms.Button btn_ConfEditar;
        private System.Windows.Forms.Button btn_ConfNovo;
        private System.Windows.Forms.CheckBox chk_MovSaidaMateriais;
        private System.Windows.Forms.CheckBox chk_MovEntradaMateriais;
        private System.Windows.Forms.TextBox txt_MovQuantidadeMateriais;
        private System.Windows.Forms.TextBox txt_MovModeloMateriais;
        private System.Windows.Forms.TextBox txt_MovTipoMateriais;
        private System.Windows.Forms.TextBox txt_MovIdMateriais;
        private System.Windows.Forms.Label lbl_MovDataAtual;
        private System.Windows.Forms.Label lbl_MovQuantidadeMateriais;
        private System.Windows.Forms.Label lbl_MovModeloMateriais;
        private System.Windows.Forms.Label lbl_MovTipoMateriais;
        private System.Windows.Forms.Label lbl_MovIdMateriais;
        private System.Windows.Forms.Label lbl_MovimantacaoMateriais;
        private System.Windows.Forms.Button btn_MovCancelar;
        private System.Windows.Forms.Button btn_MovSalvar;
        private System.Windows.Forms.Timer tmData;
        private System.Windows.Forms.Label lbl_ControleMateriais;
        private MBRMESSTOCK_BuscarTipoMateriais mBRMESSTOCK_BuscarTipoMateriais;
        private System.Windows.Forms.BindingSource spBuscarTipoMateriaisBindingSource;
        private MBRMESSTOCK_BuscarTipoMateriaisTableAdapters.sp_BuscarTipoMateriaisTableAdapter sp_BuscarTipoMateriaisTableAdapter;
    }
}