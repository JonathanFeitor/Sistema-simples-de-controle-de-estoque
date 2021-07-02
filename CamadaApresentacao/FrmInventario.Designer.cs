namespace CamadaApresentacao
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.lbl_ControleInventario = new System.Windows.Forms.Label();
            this.tt_Mensagem = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_Inventario = new System.Windows.Forms.GroupBox();
            this.tbc_Inventario = new System.Windows.Forms.TabControl();
            this.tbp_BuscarFuncionario = new System.Windows.Forms.TabPage();
            this.lbl_AbaBuscarEquipamento = new System.Windows.Forms.Label();
            this.cmb_BuscarEquipamento = new System.Windows.Forms.ComboBox();
            this.chk_DeleteEquipamento = new System.Windows.Forms.CheckBox();
            this.chk_TodosEquipamentos = new System.Windows.Forms.CheckBox();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.lbl_TotalRegistro = new System.Windows.Forms.Label();
            this.lbl_BuscarFuncionario = new System.Windows.Forms.Label();
            this.dtg_BuscarEquipamento = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbp_ConfFuncionario = new System.Windows.Forms.TabPage();
            this.cmb_ConfStatus = new System.Windows.Forms.ComboBox();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.txt_LocalEquipamento = new System.Windows.Forms.TextBox();
            this.txt_IpEquipamento = new System.Windows.Forms.TextBox();
            this.txt_IdFuncionario = new System.Windows.Forms.TextBox();
            this.txt_NumSerial = new System.Windows.Forms.TextBox();
            this.txt_ModelEquipamento = new System.Windows.Forms.TextBox();
            this.txt_TipoEquipamento = new System.Windows.Forms.TextBox();
            this.txt_NumInventario = new System.Windows.Forms.TextBox();
            this.lbl_DataAtual = new System.Windows.Forms.Label();
            this.lbl_Localizacao = new System.Windows.Forms.Label();
            this.lbl_IpEquipamento = new System.Windows.Forms.Label();
            this.lbl_IdFuncionario = new System.Windows.Forms.Label();
            this.btn_ConfCancelar = new System.Windows.Forms.Button();
            this.btn_ConfSalvar = new System.Windows.Forms.Button();
            this.btn_ConfEditar = new System.Windows.Forms.Button();
            this.btn_ConfNovo = new System.Windows.Forms.Button();
            this.lbl_StatusEquipamento = new System.Windows.Forms.Label();
            this.lbl_NumSerial = new System.Windows.Forms.Label();
            this.lbl_ModelEquipamento = new System.Windows.Forms.Label();
            this.lbl_TipoEquipamento = new System.Windows.Forms.Label();
            this.lbl_NumInventario = new System.Windows.Forms.Label();
            this.lbl_ConfEquipamento = new System.Windows.Forms.Label();
            this.tmData = new System.Windows.Forms.Timer(this.components);
            this.mBRMESSTOCK_BuscarTipoInventario = new CamadaApresentacao.MBRMESSTOCK_BuscarTipoInventario();
            this.spBuscarTipoInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BuscarTipoInventarioTableAdapter = new CamadaApresentacao.MBRMESSTOCK_BuscarTipoInventarioTableAdapters.sp_BuscarTipoInventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.grp_Inventario.SuspendLayout();
            this.tbc_Inventario.SuspendLayout();
            this.tbp_BuscarFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BuscarEquipamento)).BeginInit();
            this.tbp_ConfFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mBRMESSTOCK_BuscarTipoInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarTipoInventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ControleInventario
            // 
            this.lbl_ControleInventario.AutoSize = true;
            this.lbl_ControleInventario.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ControleInventario.Location = new System.Drawing.Point(9, 25);
            this.lbl_ControleInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ControleInventario.Name = "lbl_ControleInventario";
            this.lbl_ControleInventario.Size = new System.Drawing.Size(129, 18);
            this.lbl_ControleInventario.TabIndex = 6;
            this.lbl_ControleInventario.Text = "Controle Inventário";
            // 
            // tt_Mensagem
            // 
            this.tt_Mensagem.IsBalloon = true;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // grp_Inventario
            // 
            this.grp_Inventario.Controls.Add(this.tbc_Inventario);
            this.grp_Inventario.Location = new System.Drawing.Point(9, 66);
            this.grp_Inventario.Margin = new System.Windows.Forms.Padding(2);
            this.grp_Inventario.Name = "grp_Inventario";
            this.grp_Inventario.Padding = new System.Windows.Forms.Padding(2);
            this.grp_Inventario.Size = new System.Drawing.Size(1094, 455);
            this.grp_Inventario.TabIndex = 7;
            this.grp_Inventario.TabStop = false;
            // 
            // tbc_Inventario
            // 
            this.tbc_Inventario.Controls.Add(this.tbp_BuscarFuncionario);
            this.tbc_Inventario.Controls.Add(this.tbp_ConfFuncionario);
            this.tbc_Inventario.Location = new System.Drawing.Point(0, 1);
            this.tbc_Inventario.Margin = new System.Windows.Forms.Padding(2);
            this.tbc_Inventario.Name = "tbc_Inventario";
            this.tbc_Inventario.SelectedIndex = 0;
            this.tbc_Inventario.Size = new System.Drawing.Size(1094, 453);
            this.tbc_Inventario.TabIndex = 2;
            // 
            // tbp_BuscarFuncionario
            // 
            this.tbp_BuscarFuncionario.Controls.Add(this.lbl_AbaBuscarEquipamento);
            this.tbp_BuscarFuncionario.Controls.Add(this.cmb_BuscarEquipamento);
            this.tbp_BuscarFuncionario.Controls.Add(this.chk_DeleteEquipamento);
            this.tbp_BuscarFuncionario.Controls.Add(this.chk_TodosEquipamentos);
            this.tbp_BuscarFuncionario.Controls.Add(this.btn_Deletar);
            this.tbp_BuscarFuncionario.Controls.Add(this.btn_Buscar);
            this.tbp_BuscarFuncionario.Controls.Add(this.lbl_TotalRegistro);
            this.tbp_BuscarFuncionario.Controls.Add(this.lbl_BuscarFuncionario);
            this.tbp_BuscarFuncionario.Controls.Add(this.dtg_BuscarEquipamento);
            this.tbp_BuscarFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tbp_BuscarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.tbp_BuscarFuncionario.Name = "tbp_BuscarFuncionario";
            this.tbp_BuscarFuncionario.Padding = new System.Windows.Forms.Padding(2);
            this.tbp_BuscarFuncionario.Size = new System.Drawing.Size(1086, 427);
            this.tbp_BuscarFuncionario.TabIndex = 0;
            this.tbp_BuscarFuncionario.Text = "Pesquisar";
            this.tbp_BuscarFuncionario.UseVisualStyleBackColor = true;
            // 
            // lbl_AbaBuscarEquipamento
            // 
            this.lbl_AbaBuscarEquipamento.AutoSize = true;
            this.lbl_AbaBuscarEquipamento.Location = new System.Drawing.Point(17, 11);
            this.lbl_AbaBuscarEquipamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AbaBuscarEquipamento.Name = "lbl_AbaBuscarEquipamento";
            this.lbl_AbaBuscarEquipamento.Size = new System.Drawing.Size(90, 13);
            this.lbl_AbaBuscarEquipamento.TabIndex = 25;
            this.lbl_AbaBuscarEquipamento.Text = "Buscar Inventário";
            // 
            // cmb_BuscarEquipamento
            // 
            this.cmb_BuscarEquipamento.DataSource = this.spBuscarTipoInventarioBindingSource;
            this.cmb_BuscarEquipamento.DisplayMember = "tipo_equipamento";
            this.cmb_BuscarEquipamento.FormattingEnabled = true;
            this.cmb_BuscarEquipamento.Location = new System.Drawing.Point(172, 40);
            this.cmb_BuscarEquipamento.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_BuscarEquipamento.Name = "cmb_BuscarEquipamento";
            this.cmb_BuscarEquipamento.Size = new System.Drawing.Size(222, 21);
            this.cmb_BuscarEquipamento.TabIndex = 24;
            this.cmb_BuscarEquipamento.ValueMember = "tipo_equipamento";
            this.cmb_BuscarEquipamento.SelectedIndexChanged += new System.EventHandler(this.cmb_BuscarEquipamento_SelectedIndexChanged);
            // 
            // chk_DeleteEquipamento
            // 
            this.chk_DeleteEquipamento.AutoSize = true;
            this.chk_DeleteEquipamento.Location = new System.Drawing.Point(770, 39);
            this.chk_DeleteEquipamento.Margin = new System.Windows.Forms.Padding(2);
            this.chk_DeleteEquipamento.Name = "chk_DeleteEquipamento";
            this.chk_DeleteEquipamento.Size = new System.Drawing.Size(60, 17);
            this.chk_DeleteEquipamento.TabIndex = 23;
            this.chk_DeleteEquipamento.Text = "Deletar";
            this.chk_DeleteEquipamento.UseVisualStyleBackColor = true;
            this.chk_DeleteEquipamento.CheckedChanged += new System.EventHandler(this.chk_DeleteEquipamento_CheckedChanged);
            // 
            // chk_TodosEquipamentos
            // 
            this.chk_TodosEquipamentos.AutoSize = true;
            this.chk_TodosEquipamentos.Location = new System.Drawing.Point(422, 43);
            this.chk_TodosEquipamentos.Margin = new System.Windows.Forms.Padding(2);
            this.chk_TodosEquipamentos.Name = "chk_TodosEquipamentos";
            this.chk_TodosEquipamentos.Size = new System.Drawing.Size(56, 17);
            this.chk_TodosEquipamentos.TabIndex = 22;
            this.chk_TodosEquipamentos.Text = "Todos";
            this.chk_TodosEquipamentos.UseVisualStyleBackColor = true;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.AllowDrop = true;
            this.btn_Deletar.Location = new System.Drawing.Point(958, 22);
            this.btn_Deletar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(111, 49);
            this.btn_Deletar.TabIndex = 21;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.AllowDrop = true;
            this.btn_Buscar.Location = new System.Drawing.Point(843, 22);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(111, 49);
            this.btn_Buscar.TabIndex = 20;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // lbl_TotalRegistro
            // 
            this.lbl_TotalRegistro.AutoSize = true;
            this.lbl_TotalRegistro.Location = new System.Drawing.Point(421, 13);
            this.lbl_TotalRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TotalRegistro.Name = "lbl_TotalRegistro";
            this.lbl_TotalRegistro.Size = new System.Drawing.Size(31, 13);
            this.lbl_TotalRegistro.TabIndex = 15;
            this.lbl_TotalRegistro.Text = "Total";
            // 
            // lbl_BuscarFuncionario
            // 
            this.lbl_BuscarFuncionario.AutoSize = true;
            this.lbl_BuscarFuncionario.Location = new System.Drawing.Point(17, 42);
            this.lbl_BuscarFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BuscarFuncionario.Name = "lbl_BuscarFuncionario";
            this.lbl_BuscarFuncionario.Size = new System.Drawing.Size(152, 13);
            this.lbl_BuscarFuncionario.TabIndex = 14;
            this.lbl_BuscarFuncionario.Text = "Selecione o Tipo Equipamento";
            // 
            // dtg_BuscarEquipamento
            // 
            this.dtg_BuscarEquipamento.AllowUserToAddRows = false;
            this.dtg_BuscarEquipamento.AllowUserToDeleteRows = false;
            this.dtg_BuscarEquipamento.AllowUserToOrderColumns = true;
            this.dtg_BuscarEquipamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_BuscarEquipamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_BuscarEquipamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_BuscarEquipamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir});
            this.dtg_BuscarEquipamento.Location = new System.Drawing.Point(-1, 76);
            this.dtg_BuscarEquipamento.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_BuscarEquipamento.MultiSelect = false;
            this.dtg_BuscarEquipamento.Name = "dtg_BuscarEquipamento";
            this.dtg_BuscarEquipamento.ReadOnly = true;
            this.dtg_BuscarEquipamento.RowHeadersWidth = 51;
            this.dtg_BuscarEquipamento.RowTemplate.Height = 24;
            this.dtg_BuscarEquipamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_BuscarEquipamento.Size = new System.Drawing.Size(1088, 354);
            this.dtg_BuscarEquipamento.TabIndex = 13;
            this.dtg_BuscarEquipamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_BuscarEquipamento_CellContentClick);
            this.dtg_BuscarEquipamento.DoubleClick += new System.EventHandler(this.dtg_BuscarEquipamento_DoubleClick);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.MinimumWidth = 6;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 44;
            // 
            // tbp_ConfFuncionario
            // 
            this.tbp_ConfFuncionario.Controls.Add(this.cmb_ConfStatus);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_Descricao);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_Descricao);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_LocalEquipamento);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_IpEquipamento);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_IdFuncionario);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_NumSerial);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_ModelEquipamento);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_TipoEquipamento);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_NumInventario);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_DataAtual);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_Localizacao);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_IpEquipamento);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_IdFuncionario);
            this.tbp_ConfFuncionario.Controls.Add(this.btn_ConfCancelar);
            this.tbp_ConfFuncionario.Controls.Add(this.btn_ConfSalvar);
            this.tbp_ConfFuncionario.Controls.Add(this.btn_ConfEditar);
            this.tbp_ConfFuncionario.Controls.Add(this.btn_ConfNovo);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_StatusEquipamento);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_NumSerial);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_ModelEquipamento);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_TipoEquipamento);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_NumInventario);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_ConfEquipamento);
            this.tbp_ConfFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tbp_ConfFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.tbp_ConfFuncionario.Name = "tbp_ConfFuncionario";
            this.tbp_ConfFuncionario.Padding = new System.Windows.Forms.Padding(2);
            this.tbp_ConfFuncionario.Size = new System.Drawing.Size(1086, 427);
            this.tbp_ConfFuncionario.TabIndex = 1;
            this.tbp_ConfFuncionario.Text = "Configuração";
            this.tbp_ConfFuncionario.UseVisualStyleBackColor = true;
            // 
            // cmb_ConfStatus
            // 
            this.cmb_ConfStatus.FormattingEnabled = true;
            this.cmb_ConfStatus.Items.AddRange(new object[] {
            "SIM",
            "NAO"});
            this.cmb_ConfStatus.Location = new System.Drawing.Point(194, 293);
            this.cmb_ConfStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_ConfStatus.Name = "cmb_ConfStatus";
            this.cmb_ConfStatus.Size = new System.Drawing.Size(94, 21);
            this.cmb_ConfStatus.TabIndex = 42;
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Location = new System.Drawing.Point(431, 237);
            this.lbl_Descricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(55, 13);
            this.lbl_Descricao.TabIndex = 41;
            this.lbl_Descricao.Text = "Descrição";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(534, 235);
            this.txt_Descricao.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(534, 120);
            this.txt_Descricao.TabIndex = 40;
            // 
            // txt_LocalEquipamento
            // 
            this.txt_LocalEquipamento.Location = new System.Drawing.Point(534, 176);
            this.txt_LocalEquipamento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_LocalEquipamento.Name = "txt_LocalEquipamento";
            this.txt_LocalEquipamento.Size = new System.Drawing.Size(218, 20);
            this.txt_LocalEquipamento.TabIndex = 39;
            // 
            // txt_IpEquipamento
            // 
            this.txt_IpEquipamento.Location = new System.Drawing.Point(534, 121);
            this.txt_IpEquipamento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IpEquipamento.Name = "txt_IpEquipamento";
            this.txt_IpEquipamento.Size = new System.Drawing.Size(218, 20);
            this.txt_IpEquipamento.TabIndex = 38;
            // 
            // txt_IdFuncionario
            // 
            this.txt_IdFuncionario.Location = new System.Drawing.Point(534, 66);
            this.txt_IdFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdFuncionario.Name = "txt_IdFuncionario";
            this.txt_IdFuncionario.Size = new System.Drawing.Size(218, 20);
            this.txt_IdFuncionario.TabIndex = 37;
            // 
            // txt_NumSerial
            // 
            this.txt_NumSerial.Location = new System.Drawing.Point(194, 235);
            this.txt_NumSerial.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NumSerial.Name = "txt_NumSerial";
            this.txt_NumSerial.Size = new System.Drawing.Size(218, 20);
            this.txt_NumSerial.TabIndex = 36;
            // 
            // txt_ModelEquipamento
            // 
            this.txt_ModelEquipamento.Location = new System.Drawing.Point(194, 176);
            this.txt_ModelEquipamento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ModelEquipamento.Name = "txt_ModelEquipamento";
            this.txt_ModelEquipamento.Size = new System.Drawing.Size(218, 20);
            this.txt_ModelEquipamento.TabIndex = 35;
            // 
            // txt_TipoEquipamento
            // 
            this.txt_TipoEquipamento.Location = new System.Drawing.Point(194, 121);
            this.txt_TipoEquipamento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TipoEquipamento.Name = "txt_TipoEquipamento";
            this.txt_TipoEquipamento.Size = new System.Drawing.Size(218, 20);
            this.txt_TipoEquipamento.TabIndex = 34;
            // 
            // txt_NumInventario
            // 
            this.txt_NumInventario.Location = new System.Drawing.Point(194, 66);
            this.txt_NumInventario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NumInventario.Name = "txt_NumInventario";
            this.txt_NumInventario.Size = new System.Drawing.Size(218, 20);
            this.txt_NumInventario.TabIndex = 33;
            // 
            // lbl_DataAtual
            // 
            this.lbl_DataAtual.AutoSize = true;
            this.lbl_DataAtual.Location = new System.Drawing.Point(71, 354);
            this.lbl_DataAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DataAtual.Name = "lbl_DataAtual";
            this.lbl_DataAtual.Size = new System.Drawing.Size(30, 13);
            this.lbl_DataAtual.TabIndex = 32;
            this.lbl_DataAtual.Text = "Data";
            // 
            // lbl_Localizacao
            // 
            this.lbl_Localizacao.AutoSize = true;
            this.lbl_Localizacao.Location = new System.Drawing.Point(431, 178);
            this.lbl_Localizacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Localizacao.Name = "lbl_Localizacao";
            this.lbl_Localizacao.Size = new System.Drawing.Size(64, 13);
            this.lbl_Localizacao.TabIndex = 31;
            this.lbl_Localizacao.Text = "Localização";
            // 
            // lbl_IpEquipamento
            // 
            this.lbl_IpEquipamento.AutoSize = true;
            this.lbl_IpEquipamento.Location = new System.Drawing.Point(431, 124);
            this.lbl_IpEquipamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_IpEquipamento.Name = "lbl_IpEquipamento";
            this.lbl_IpEquipamento.Size = new System.Drawing.Size(82, 13);
            this.lbl_IpEquipamento.TabIndex = 30;
            this.lbl_IpEquipamento.Text = "IP Equipamento";
            // 
            // lbl_IdFuncionario
            // 
            this.lbl_IdFuncionario.AutoSize = true;
            this.lbl_IdFuncionario.Location = new System.Drawing.Point(431, 68);
            this.lbl_IdFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_IdFuncionario.Name = "lbl_IdFuncionario";
            this.lbl_IdFuncionario.Size = new System.Drawing.Size(76, 13);
            this.lbl_IdFuncionario.TabIndex = 29;
            this.lbl_IdFuncionario.Text = "ID Funcionário";
            // 
            // btn_ConfCancelar
            // 
            this.btn_ConfCancelar.Location = new System.Drawing.Point(963, 380);
            this.btn_ConfCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConfCancelar.Name = "btn_ConfCancelar";
            this.btn_ConfCancelar.Size = new System.Drawing.Size(104, 36);
            this.btn_ConfCancelar.TabIndex = 28;
            this.btn_ConfCancelar.Text = "Cancelar";
            this.btn_ConfCancelar.UseVisualStyleBackColor = true;
            this.btn_ConfCancelar.Click += new System.EventHandler(this.btn_ConfCancelar_Click);
            // 
            // btn_ConfSalvar
            // 
            this.btn_ConfSalvar.Location = new System.Drawing.Point(854, 379);
            this.btn_ConfSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConfSalvar.Name = "btn_ConfSalvar";
            this.btn_ConfSalvar.Size = new System.Drawing.Size(104, 36);
            this.btn_ConfSalvar.TabIndex = 27;
            this.btn_ConfSalvar.Text = "Salvar";
            this.btn_ConfSalvar.UseVisualStyleBackColor = true;
            this.btn_ConfSalvar.Click += new System.EventHandler(this.btn_ConfSalvar_Click);
            // 
            // btn_ConfEditar
            // 
            this.btn_ConfEditar.Location = new System.Drawing.Point(746, 379);
            this.btn_ConfEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConfEditar.Name = "btn_ConfEditar";
            this.btn_ConfEditar.Size = new System.Drawing.Size(104, 36);
            this.btn_ConfEditar.TabIndex = 26;
            this.btn_ConfEditar.Text = "Editar";
            this.btn_ConfEditar.UseVisualStyleBackColor = true;
            this.btn_ConfEditar.Click += new System.EventHandler(this.btn_ConfEditar_Click);
            // 
            // btn_ConfNovo
            // 
            this.btn_ConfNovo.Location = new System.Drawing.Point(637, 379);
            this.btn_ConfNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConfNovo.Name = "btn_ConfNovo";
            this.btn_ConfNovo.Size = new System.Drawing.Size(104, 36);
            this.btn_ConfNovo.TabIndex = 25;
            this.btn_ConfNovo.Text = "Novo";
            this.btn_ConfNovo.UseVisualStyleBackColor = true;
            this.btn_ConfNovo.Click += new System.EventHandler(this.btn_ConfNovo_Click);
            // 
            // lbl_StatusEquipamento
            // 
            this.lbl_StatusEquipamento.AutoSize = true;
            this.lbl_StatusEquipamento.Location = new System.Drawing.Point(71, 296);
            this.lbl_StatusEquipamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StatusEquipamento.Name = "lbl_StatusEquipamento";
            this.lbl_StatusEquipamento.Size = new System.Drawing.Size(44, 13);
            this.lbl_StatusEquipamento.TabIndex = 5;
            this.lbl_StatusEquipamento.Text = "Em Uso";
            // 
            // lbl_NumSerial
            // 
            this.lbl_NumSerial.AutoSize = true;
            this.lbl_NumSerial.Location = new System.Drawing.Point(71, 237);
            this.lbl_NumSerial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NumSerial.Name = "lbl_NumSerial";
            this.lbl_NumSerial.Size = new System.Drawing.Size(73, 13);
            this.lbl_NumSerial.TabIndex = 4;
            this.lbl_NumSerial.Text = "Número Serial";
            // 
            // lbl_ModelEquipamento
            // 
            this.lbl_ModelEquipamento.AutoSize = true;
            this.lbl_ModelEquipamento.Location = new System.Drawing.Point(71, 178);
            this.lbl_ModelEquipamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ModelEquipamento.Name = "lbl_ModelEquipamento";
            this.lbl_ModelEquipamento.Size = new System.Drawing.Size(107, 13);
            this.lbl_ModelEquipamento.TabIndex = 3;
            this.lbl_ModelEquipamento.Text = "Modelo Equipamento";
            // 
            // lbl_TipoEquipamento
            // 
            this.lbl_TipoEquipamento.AutoSize = true;
            this.lbl_TipoEquipamento.Location = new System.Drawing.Point(71, 124);
            this.lbl_TipoEquipamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TipoEquipamento.Name = "lbl_TipoEquipamento";
            this.lbl_TipoEquipamento.Size = new System.Drawing.Size(93, 13);
            this.lbl_TipoEquipamento.TabIndex = 2;
            this.lbl_TipoEquipamento.Text = "Tipo Equipamento";
            // 
            // lbl_NumInventario
            // 
            this.lbl_NumInventario.AutoSize = true;
            this.lbl_NumInventario.Location = new System.Drawing.Point(71, 68);
            this.lbl_NumInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NumInventario.Name = "lbl_NumInventario";
            this.lbl_NumInventario.Size = new System.Drawing.Size(94, 13);
            this.lbl_NumInventario.TabIndex = 1;
            this.lbl_NumInventario.Text = "Número Inventário";
            // 
            // lbl_ConfEquipamento
            // 
            this.lbl_ConfEquipamento.AutoSize = true;
            this.lbl_ConfEquipamento.Location = new System.Drawing.Point(12, 17);
            this.lbl_ConfEquipamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ConfEquipamento.Name = "lbl_ConfEquipamento";
            this.lbl_ConfEquipamento.Size = new System.Drawing.Size(135, 13);
            this.lbl_ConfEquipamento.TabIndex = 0;
            this.lbl_ConfEquipamento.Text = "Configuração Equipamento";
            // 
            // tmData
            // 
            this.tmData.Tick += new System.EventHandler(this.tmData_Tick);
            // 
            // mBRMESSTOCK_BuscarTipoInventario
            // 
            this.mBRMESSTOCK_BuscarTipoInventario.DataSetName = "MBRMESSTOCK_BuscarTipoInventario";
            this.mBRMESSTOCK_BuscarTipoInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spBuscarTipoInventarioBindingSource
            // 
            this.spBuscarTipoInventarioBindingSource.DataMember = "sp_BuscarTipoInventario";
            this.spBuscarTipoInventarioBindingSource.DataSource = this.mBRMESSTOCK_BuscarTipoInventario;
            // 
            // sp_BuscarTipoInventarioTableAdapter
            // 
            this.sp_BuscarTipoInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 531);
            this.Controls.Add(this.grp_Inventario);
            this.Controls.Add(this.lbl_ControleInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Inventário";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.grp_Inventario.ResumeLayout(false);
            this.tbc_Inventario.ResumeLayout(false);
            this.tbp_BuscarFuncionario.ResumeLayout(false);
            this.tbp_BuscarFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BuscarEquipamento)).EndInit();
            this.tbp_ConfFuncionario.ResumeLayout(false);
            this.tbp_ConfFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mBRMESSTOCK_BuscarTipoInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarTipoInventarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ControleInventario;
        private System.Windows.Forms.ToolTip tt_Mensagem;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.GroupBox grp_Inventario;
        private System.Windows.Forms.TabControl tbc_Inventario;
        private System.Windows.Forms.TabPage tbp_BuscarFuncionario;
        private System.Windows.Forms.Label lbl_AbaBuscarEquipamento;
        private System.Windows.Forms.ComboBox cmb_BuscarEquipamento;
        private System.Windows.Forms.CheckBox chk_DeleteEquipamento;
        private System.Windows.Forms.CheckBox chk_TodosEquipamentos;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lbl_TotalRegistro;
        private System.Windows.Forms.Label lbl_BuscarFuncionario;
        private System.Windows.Forms.DataGridView dtg_BuscarEquipamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.TabPage tbp_ConfFuncionario;
        private System.Windows.Forms.ComboBox cmb_ConfStatus;
        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.TextBox txt_LocalEquipamento;
        private System.Windows.Forms.TextBox txt_IpEquipamento;
        private System.Windows.Forms.TextBox txt_IdFuncionario;
        private System.Windows.Forms.TextBox txt_NumSerial;
        private System.Windows.Forms.TextBox txt_ModelEquipamento;
        private System.Windows.Forms.TextBox txt_TipoEquipamento;
        private System.Windows.Forms.TextBox txt_NumInventario;
        private System.Windows.Forms.Label lbl_DataAtual;
        private System.Windows.Forms.Label lbl_Localizacao;
        private System.Windows.Forms.Label lbl_IpEquipamento;
        private System.Windows.Forms.Label lbl_IdFuncionario;
        private System.Windows.Forms.Button btn_ConfCancelar;
        private System.Windows.Forms.Button btn_ConfSalvar;
        private System.Windows.Forms.Button btn_ConfEditar;
        private System.Windows.Forms.Button btn_ConfNovo;
        private System.Windows.Forms.Label lbl_StatusEquipamento;
        private System.Windows.Forms.Label lbl_NumSerial;
        private System.Windows.Forms.Label lbl_ModelEquipamento;
        private System.Windows.Forms.Label lbl_TipoEquipamento;
        private System.Windows.Forms.Label lbl_NumInventario;
        private System.Windows.Forms.Label lbl_ConfEquipamento;
        private System.Windows.Forms.Timer tmData;
        private MBRMESSTOCK_BuscarTipoInventario mBRMESSTOCK_BuscarTipoInventario;
        private System.Windows.Forms.BindingSource spBuscarTipoInventarioBindingSource;
        private MBRMESSTOCK_BuscarTipoInventarioTableAdapters.sp_BuscarTipoInventarioTableAdapter sp_BuscarTipoInventarioTableAdapter;
    }
}