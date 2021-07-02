namespace CamadaApresentacao
{
    partial class FrmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.grp_FrmFuncionario = new System.Windows.Forms.GroupBox();
            this.tbc_Funcionario = new System.Windows.Forms.TabControl();
            this.tbp_BuscarFuncionario = new System.Windows.Forms.TabPage();
            this.lbl_AbaBuscarFuncionario = new System.Windows.Forms.Label();
            this.cmb_BuscarFuncionario = new System.Windows.Forms.ComboBox();
            this.chk_DeleteFuncionario = new System.Windows.Forms.CheckBox();
            this.chk_TodosFuncionarios = new System.Windows.Forms.CheckBox();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.lbl_TotalRegistro = new System.Windows.Forms.Label();
            this.lbl_BuscarFuncionario = new System.Windows.Forms.Label();
            this.dtg_BuscarFuncionario = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbp_ConfFuncionario = new System.Windows.Forms.TabPage();
            this.btn_ConfCancelar = new System.Windows.Forms.Button();
            this.btn_ConfSalvar = new System.Windows.Forms.Button();
            this.btn_ConfEditar = new System.Windows.Forms.Button();
            this.btn_ConfNovo = new System.Windows.Forms.Button();
            this.txt_SenhaFuncionario = new System.Windows.Forms.TextBox();
            this.txt_TelFuncionario = new System.Windows.Forms.TextBox();
            this.txt_CargoFuncionario = new System.Windows.Forms.TextBox();
            this.txt_NomeFuncionario = new System.Windows.Forms.TextBox();
            this.txt_IdFuncionario = new System.Windows.Forms.TextBox();
            this.lbl_SenhaFuncionario = new System.Windows.Forms.Label();
            this.lbl_TelFuncionario = new System.Windows.Forms.Label();
            this.lbl_CargoFuncionario = new System.Windows.Forms.Label();
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.lbl_IdFuncionario = new System.Windows.Forms.Label();
            this.lbl_ConfFuncionario = new System.Windows.Forms.Label();
            this.lbl_ControleFuncionario = new System.Windows.Forms.Label();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.tt_Mensagem = new System.Windows.Forms.ToolTip(this.components);
            this.mBRMESSTOCK_BuscarIdFuncionario = new CamadaApresentacao.MBRMESSTOCK_BuscarIdFuncionario();
            this.spBuscarIDFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BuscarIDFuncionarioTableAdapter = new CamadaApresentacao.MBRMESSTOCK_BuscarIdFuncionarioTableAdapters.sp_BuscarIDFuncionarioTableAdapter();
            this.grp_FrmFuncionario.SuspendLayout();
            this.tbc_Funcionario.SuspendLayout();
            this.tbp_BuscarFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BuscarFuncionario)).BeginInit();
            this.tbp_ConfFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBRMESSTOCK_BuscarIdFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarIDFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_FrmFuncionario
            // 
            this.grp_FrmFuncionario.BackColor = System.Drawing.SystemColors.Window;
            this.grp_FrmFuncionario.Controls.Add(this.tbc_Funcionario);
            this.grp_FrmFuncionario.Location = new System.Drawing.Point(9, 67);
            this.grp_FrmFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.grp_FrmFuncionario.Name = "grp_FrmFuncionario";
            this.grp_FrmFuncionario.Padding = new System.Windows.Forms.Padding(2);
            this.grp_FrmFuncionario.Size = new System.Drawing.Size(1094, 453);
            this.grp_FrmFuncionario.TabIndex = 0;
            this.grp_FrmFuncionario.TabStop = false;
            // 
            // tbc_Funcionario
            // 
            this.tbc_Funcionario.Controls.Add(this.tbp_BuscarFuncionario);
            this.tbc_Funcionario.Controls.Add(this.tbp_ConfFuncionario);
            this.tbc_Funcionario.Location = new System.Drawing.Point(0, 0);
            this.tbc_Funcionario.Margin = new System.Windows.Forms.Padding(2);
            this.tbc_Funcionario.Name = "tbc_Funcionario";
            this.tbc_Funcionario.SelectedIndex = 0;
            this.tbc_Funcionario.Size = new System.Drawing.Size(1089, 453);
            this.tbc_Funcionario.TabIndex = 0;
            // 
            // tbp_BuscarFuncionario
            // 
            this.tbp_BuscarFuncionario.Controls.Add(this.lbl_AbaBuscarFuncionario);
            this.tbp_BuscarFuncionario.Controls.Add(this.cmb_BuscarFuncionario);
            this.tbp_BuscarFuncionario.Controls.Add(this.chk_DeleteFuncionario);
            this.tbp_BuscarFuncionario.Controls.Add(this.chk_TodosFuncionarios);
            this.tbp_BuscarFuncionario.Controls.Add(this.btn_Deletar);
            this.tbp_BuscarFuncionario.Controls.Add(this.btn_Buscar);
            this.tbp_BuscarFuncionario.Controls.Add(this.lbl_TotalRegistro);
            this.tbp_BuscarFuncionario.Controls.Add(this.lbl_BuscarFuncionario);
            this.tbp_BuscarFuncionario.Controls.Add(this.dtg_BuscarFuncionario);
            this.tbp_BuscarFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tbp_BuscarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.tbp_BuscarFuncionario.Name = "tbp_BuscarFuncionario";
            this.tbp_BuscarFuncionario.Padding = new System.Windows.Forms.Padding(2);
            this.tbp_BuscarFuncionario.Size = new System.Drawing.Size(1081, 427);
            this.tbp_BuscarFuncionario.TabIndex = 0;
            this.tbp_BuscarFuncionario.Text = "Pesquisar";
            this.tbp_BuscarFuncionario.UseVisualStyleBackColor = true;
            // 
            // lbl_AbaBuscarFuncionario
            // 
            this.lbl_AbaBuscarFuncionario.AutoSize = true;
            this.lbl_AbaBuscarFuncionario.Location = new System.Drawing.Point(17, 11);
            this.lbl_AbaBuscarFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AbaBuscarFuncionario.Name = "lbl_AbaBuscarFuncionario";
            this.lbl_AbaBuscarFuncionario.Size = new System.Drawing.Size(98, 13);
            this.lbl_AbaBuscarFuncionario.TabIndex = 25;
            this.lbl_AbaBuscarFuncionario.Text = "Buscar Funcionário";
            // 
            // cmb_BuscarFuncionario
            // 
            this.cmb_BuscarFuncionario.DataSource = this.spBuscarIDFuncionarioBindingSource;
            this.cmb_BuscarFuncionario.DisplayMember = "id_funcionario";
            this.cmb_BuscarFuncionario.FormattingEnabled = true;
            this.cmb_BuscarFuncionario.Location = new System.Drawing.Point(96, 37);
            this.cmb_BuscarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_BuscarFuncionario.Name = "cmb_BuscarFuncionario";
            this.cmb_BuscarFuncionario.Size = new System.Drawing.Size(222, 21);
            this.cmb_BuscarFuncionario.TabIndex = 24;
            this.cmb_BuscarFuncionario.ValueMember = "id_funcionario";
            // 
            // chk_DeleteFuncionario
            // 
            this.chk_DeleteFuncionario.AutoSize = true;
            this.chk_DeleteFuncionario.Location = new System.Drawing.Point(770, 39);
            this.chk_DeleteFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.chk_DeleteFuncionario.Name = "chk_DeleteFuncionario";
            this.chk_DeleteFuncionario.Size = new System.Drawing.Size(60, 17);
            this.chk_DeleteFuncionario.TabIndex = 23;
            this.chk_DeleteFuncionario.Text = "Deletar";
            this.chk_DeleteFuncionario.UseVisualStyleBackColor = true;
            this.chk_DeleteFuncionario.CheckedChanged += new System.EventHandler(this.chk_DeleteFuncionario_CheckedChanged);
            // 
            // chk_TodosFuncionarios
            // 
            this.chk_TodosFuncionarios.AutoSize = true;
            this.chk_TodosFuncionarios.Location = new System.Drawing.Point(345, 41);
            this.chk_TodosFuncionarios.Margin = new System.Windows.Forms.Padding(2);
            this.chk_TodosFuncionarios.Name = "chk_TodosFuncionarios";
            this.chk_TodosFuncionarios.Size = new System.Drawing.Size(56, 17);
            this.chk_TodosFuncionarios.TabIndex = 22;
            this.chk_TodosFuncionarios.Text = "Todos";
            this.chk_TodosFuncionarios.UseVisualStyleBackColor = true;
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
            this.lbl_TotalRegistro.Location = new System.Drawing.Point(344, 11);
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
            this.lbl_BuscarFuncionario.Size = new System.Drawing.Size(77, 13);
            this.lbl_BuscarFuncionario.TabIndex = 14;
            this.lbl_BuscarFuncionario.Text = "Selecione o ID";
            // 
            // dtg_BuscarFuncionario
            // 
            this.dtg_BuscarFuncionario.AllowUserToAddRows = false;
            this.dtg_BuscarFuncionario.AllowUserToDeleteRows = false;
            this.dtg_BuscarFuncionario.AllowUserToOrderColumns = true;
            this.dtg_BuscarFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_BuscarFuncionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_BuscarFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_BuscarFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir});
            this.dtg_BuscarFuncionario.Location = new System.Drawing.Point(-1, 76);
            this.dtg_BuscarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_BuscarFuncionario.MultiSelect = false;
            this.dtg_BuscarFuncionario.Name = "dtg_BuscarFuncionario";
            this.dtg_BuscarFuncionario.ReadOnly = true;
            this.dtg_BuscarFuncionario.RowHeadersWidth = 51;
            this.dtg_BuscarFuncionario.RowTemplate.Height = 24;
            this.dtg_BuscarFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_BuscarFuncionario.Size = new System.Drawing.Size(1087, 358);
            this.dtg_BuscarFuncionario.TabIndex = 13;
            this.dtg_BuscarFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_BuscarFuncionario_CellContentClick);
            this.dtg_BuscarFuncionario.DoubleClick += new System.EventHandler(this.dtg_BuscarFuncionario_DoubleClick);
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
            this.tbp_ConfFuncionario.Controls.Add(this.btn_ConfCancelar);
            this.tbp_ConfFuncionario.Controls.Add(this.btn_ConfSalvar);
            this.tbp_ConfFuncionario.Controls.Add(this.btn_ConfEditar);
            this.tbp_ConfFuncionario.Controls.Add(this.btn_ConfNovo);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_SenhaFuncionario);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_TelFuncionario);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_CargoFuncionario);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_NomeFuncionario);
            this.tbp_ConfFuncionario.Controls.Add(this.txt_IdFuncionario);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_SenhaFuncionario);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_TelFuncionario);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_CargoFuncionario);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_NomeFuncionario);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_IdFuncionario);
            this.tbp_ConfFuncionario.Controls.Add(this.lbl_ConfFuncionario);
            this.tbp_ConfFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tbp_ConfFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.tbp_ConfFuncionario.Name = "tbp_ConfFuncionario";
            this.tbp_ConfFuncionario.Padding = new System.Windows.Forms.Padding(2);
            this.tbp_ConfFuncionario.Size = new System.Drawing.Size(1081, 427);
            this.tbp_ConfFuncionario.TabIndex = 1;
            this.tbp_ConfFuncionario.Text = "Configuração";
            this.tbp_ConfFuncionario.UseVisualStyleBackColor = true;
            // 
            // btn_ConfCancelar
            // 
            this.btn_ConfCancelar.Location = new System.Drawing.Point(963, 379);
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
            // txt_SenhaFuncionario
            // 
            this.txt_SenhaFuncionario.Location = new System.Drawing.Point(187, 293);
            this.txt_SenhaFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SenhaFuncionario.Name = "txt_SenhaFuncionario";
            this.txt_SenhaFuncionario.PasswordChar = '*';
            this.txt_SenhaFuncionario.Size = new System.Drawing.Size(227, 20);
            this.txt_SenhaFuncionario.TabIndex = 10;
            // 
            // txt_TelFuncionario
            // 
            this.txt_TelFuncionario.Location = new System.Drawing.Point(187, 235);
            this.txt_TelFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TelFuncionario.Name = "txt_TelFuncionario";
            this.txt_TelFuncionario.Size = new System.Drawing.Size(227, 20);
            this.txt_TelFuncionario.TabIndex = 9;
            // 
            // txt_CargoFuncionario
            // 
            this.txt_CargoFuncionario.Location = new System.Drawing.Point(187, 176);
            this.txt_CargoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CargoFuncionario.Name = "txt_CargoFuncionario";
            this.txt_CargoFuncionario.Size = new System.Drawing.Size(227, 20);
            this.txt_CargoFuncionario.TabIndex = 8;
            // 
            // txt_NomeFuncionario
            // 
            this.txt_NomeFuncionario.Location = new System.Drawing.Point(187, 121);
            this.txt_NomeFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NomeFuncionario.Name = "txt_NomeFuncionario";
            this.txt_NomeFuncionario.Size = new System.Drawing.Size(227, 20);
            this.txt_NomeFuncionario.TabIndex = 7;
            // 
            // txt_IdFuncionario
            // 
            this.txt_IdFuncionario.Location = new System.Drawing.Point(187, 66);
            this.txt_IdFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdFuncionario.Name = "txt_IdFuncionario";
            this.txt_IdFuncionario.Size = new System.Drawing.Size(227, 20);
            this.txt_IdFuncionario.TabIndex = 6;
            // 
            // lbl_SenhaFuncionario
            // 
            this.lbl_SenhaFuncionario.AutoSize = true;
            this.lbl_SenhaFuncionario.Location = new System.Drawing.Point(71, 296);
            this.lbl_SenhaFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SenhaFuncionario.Name = "lbl_SenhaFuncionario";
            this.lbl_SenhaFuncionario.Size = new System.Drawing.Size(90, 13);
            this.lbl_SenhaFuncionario.TabIndex = 5;
            this.lbl_SenhaFuncionario.Text = "Senha de acesso";
            // 
            // lbl_TelFuncionario
            // 
            this.lbl_TelFuncionario.AutoSize = true;
            this.lbl_TelFuncionario.Location = new System.Drawing.Point(71, 237);
            this.lbl_TelFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TelFuncionario.Name = "lbl_TelFuncionario";
            this.lbl_TelFuncionario.Size = new System.Drawing.Size(49, 13);
            this.lbl_TelFuncionario.TabIndex = 4;
            this.lbl_TelFuncionario.Text = "Telefone";
            // 
            // lbl_CargoFuncionario
            // 
            this.lbl_CargoFuncionario.AutoSize = true;
            this.lbl_CargoFuncionario.Location = new System.Drawing.Point(71, 178);
            this.lbl_CargoFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CargoFuncionario.Name = "lbl_CargoFuncionario";
            this.lbl_CargoFuncionario.Size = new System.Drawing.Size(43, 13);
            this.lbl_CargoFuncionario.TabIndex = 3;
            this.lbl_CargoFuncionario.Text = "Função";
            // 
            // lbl_NomeFuncionario
            // 
            this.lbl_NomeFuncionario.AutoSize = true;
            this.lbl_NomeFuncionario.Location = new System.Drawing.Point(71, 124);
            this.lbl_NomeFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NomeFuncionario.Name = "lbl_NomeFuncionario";
            this.lbl_NomeFuncionario.Size = new System.Drawing.Size(35, 13);
            this.lbl_NomeFuncionario.TabIndex = 2;
            this.lbl_NomeFuncionario.Text = "Nome";
            // 
            // lbl_IdFuncionario
            // 
            this.lbl_IdFuncionario.AutoSize = true;
            this.lbl_IdFuncionario.Location = new System.Drawing.Point(71, 68);
            this.lbl_IdFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_IdFuncionario.Name = "lbl_IdFuncionario";
            this.lbl_IdFuncionario.Size = new System.Drawing.Size(76, 13);
            this.lbl_IdFuncionario.TabIndex = 1;
            this.lbl_IdFuncionario.Text = "ID Funcionário";
            // 
            // lbl_ConfFuncionario
            // 
            this.lbl_ConfFuncionario.AutoSize = true;
            this.lbl_ConfFuncionario.Location = new System.Drawing.Point(12, 17);
            this.lbl_ConfFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ConfFuncionario.Name = "lbl_ConfFuncionario";
            this.lbl_ConfFuncionario.Size = new System.Drawing.Size(128, 13);
            this.lbl_ConfFuncionario.TabIndex = 0;
            this.lbl_ConfFuncionario.Text = "Configuração Funcionário";
            // 
            // lbl_ControleFuncionario
            // 
            this.lbl_ControleFuncionario.AutoSize = true;
            this.lbl_ControleFuncionario.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ControleFuncionario.Location = new System.Drawing.Point(9, 24);
            this.lbl_ControleFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ControleFuncionario.Name = "lbl_ControleFuncionario";
            this.lbl_ControleFuncionario.Size = new System.Drawing.Size(138, 18);
            this.lbl_ControleFuncionario.TabIndex = 5;
            this.lbl_ControleFuncionario.Text = "Controle Funcionário";
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // tt_Mensagem
            // 
            this.tt_Mensagem.IsBalloon = true;
            // 
            // mBRMESSTOCK_BuscarIdFuncionario
            // 
            this.mBRMESSTOCK_BuscarIdFuncionario.DataSetName = "MBRMESSTOCK_BuscarIdFuncionario";
            this.mBRMESSTOCK_BuscarIdFuncionario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spBuscarIDFuncionarioBindingSource
            // 
            this.spBuscarIDFuncionarioBindingSource.DataMember = "sp_BuscarIDFuncionario";
            this.spBuscarIDFuncionarioBindingSource.DataSource = this.mBRMESSTOCK_BuscarIdFuncionario;
            // 
            // sp_BuscarIDFuncionarioTableAdapter
            // 
            this.sp_BuscarIDFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 531);
            this.Controls.Add(this.lbl_ControleFuncionario);
            this.Controls.Add(this.grp_FrmFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Funcionário";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.grp_FrmFuncionario.ResumeLayout(false);
            this.tbc_Funcionario.ResumeLayout(false);
            this.tbp_BuscarFuncionario.ResumeLayout(false);
            this.tbp_BuscarFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BuscarFuncionario)).EndInit();
            this.tbp_ConfFuncionario.ResumeLayout(false);
            this.tbp_ConfFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBRMESSTOCK_BuscarIdFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarIDFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_FrmFuncionario;
        private System.Windows.Forms.TabControl tbc_Funcionario;
        private System.Windows.Forms.TabPage tbp_BuscarFuncionario;
        private System.Windows.Forms.TabPage tbp_ConfFuncionario;
        private System.Windows.Forms.DataGridView dtg_BuscarFuncionario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.Label lbl_TotalRegistro;
        private System.Windows.Forms.Label lbl_BuscarFuncionario;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lbl_ConfFuncionario;
        private System.Windows.Forms.TextBox txt_SenhaFuncionario;
        private System.Windows.Forms.TextBox txt_TelFuncionario;
        private System.Windows.Forms.TextBox txt_CargoFuncionario;
        private System.Windows.Forms.TextBox txt_NomeFuncionario;
        private System.Windows.Forms.TextBox txt_IdFuncionario;
        private System.Windows.Forms.Label lbl_SenhaFuncionario;
        private System.Windows.Forms.Label lbl_TelFuncionario;
        private System.Windows.Forms.Label lbl_CargoFuncionario;
        private System.Windows.Forms.Label lbl_NomeFuncionario;
        private System.Windows.Forms.Label lbl_IdFuncionario;
        private System.Windows.Forms.Button btn_ConfCancelar;
        private System.Windows.Forms.Button btn_ConfSalvar;
        private System.Windows.Forms.Button btn_ConfEditar;
        private System.Windows.Forms.Button btn_ConfNovo;
        private System.Windows.Forms.ComboBox cmb_BuscarFuncionario;
        private System.Windows.Forms.CheckBox chk_DeleteFuncionario;
        private System.Windows.Forms.CheckBox chk_TodosFuncionarios;
        private System.Windows.Forms.Label lbl_AbaBuscarFuncionario;
        private System.Windows.Forms.Label lbl_ControleFuncionario;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.ToolTip tt_Mensagem;
        private MBRMESSTOCK_BuscarIdFuncionario mBRMESSTOCK_BuscarIdFuncionario;
        private System.Windows.Forms.BindingSource spBuscarIDFuncionarioBindingSource;
        private MBRMESSTOCK_BuscarIdFuncionarioTableAdapters.sp_BuscarIDFuncionarioTableAdapter sp_BuscarIDFuncionarioTableAdapter;
    }
}