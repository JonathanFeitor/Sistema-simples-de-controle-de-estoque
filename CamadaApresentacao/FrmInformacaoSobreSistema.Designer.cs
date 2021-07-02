namespace CamadaApresentacao
{
    partial class FrmInformacaoSobreSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformacaoSobreSistema));
            this.lbl_Informacao = new System.Windows.Forms.Label();
            this.grp_Informacao = new System.Windows.Forms.GroupBox();
            this.lb_Informacao = new System.Windows.Forms.ListBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.grp_Informacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Informacao
            // 
            this.lbl_Informacao.AutoSize = true;
            this.lbl_Informacao.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Informacao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Informacao.Location = new System.Drawing.Point(476, 18);
            this.lbl_Informacao.Name = "lbl_Informacao";
            this.lbl_Informacao.Size = new System.Drawing.Size(130, 31);
            this.lbl_Informacao.TabIndex = 0;
            this.lbl_Informacao.Text = "Informação";
            this.lbl_Informacao.Click += new System.EventHandler(this.lbl_Informacao_Click);
            // 
            // grp_Informacao
            // 
            this.grp_Informacao.BackColor = System.Drawing.SystemColors.Window;
            this.grp_Informacao.Controls.Add(this.lb_Informacao);
            this.grp_Informacao.Location = new System.Drawing.Point(12, 65);
            this.grp_Informacao.Name = "grp_Informacao";
            this.grp_Informacao.Size = new System.Drawing.Size(1104, 437);
            this.grp_Informacao.TabIndex = 1;
            this.grp_Informacao.TabStop = false;
            // 
            // lb_Informacao
            // 
            this.lb_Informacao.FormattingEnabled = true;
            this.lb_Informacao.ItemHeight = 16;
            this.lb_Informacao.Items.AddRange(new object[] {
            "",
            "Sistema criado para controle de estoque e inventário.",
            "",
            "",
            " * Aba Controle Materiais",
            "    - Controla movimentação de materiais e adição ou exclusão dos mesmos;",
            "",
            " * Aba Controle Inventário",
            "    - Controla a adição ou exclusão de equipamentos e em qual linha/ departamento" +
                " os quipamentos estão alocados;",
            "",
            " * Aba Usuário",
            "    - Controla an adição e exclusão de usuários do sistema;",
            "",
            " * Aba Relatórios Materiais",
            "    - Nesta aba é possível emitir um relatório da quantidade de materiais que ent" +
                "raram ou sairam nos períodos semanal, mensal e anual;",
            "",
            " * Aba Relatório Inventário",
            "    - Nesta aba é possível saber quais os equipamentos estão em uso ou estoque e " +
                "quais as linhas os mesmos estão alocados. Também é poissível saber quais ",
            "    estão quebrados;",
            "",
            "Para  mais informações contatar o desenvolvedor responsável. "});
            this.lb_Informacao.Location = new System.Drawing.Point(0, 9);
            this.lb_Informacao.Name = "lb_Informacao";
            this.lb_Informacao.Size = new System.Drawing.Size(1104, 420);
            this.lb_Informacao.TabIndex = 0;
            this.lb_Informacao.SelectedIndexChanged += new System.EventHandler(this.lb_Informacao_SelectedIndexChanged);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(459, 508);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(147, 52);
            this.btn_Ok.TabIndex = 2;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // FrmInformacaoSobreSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 572);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.grp_Informacao);
            this.Controls.Add(this.lbl_Informacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInformacaoSobreSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INFORMAÇÂO SOBRE O SISTEMA";
            this.Load += new System.EventHandler(this.FrmInformacaoSobreSistema_Load);
            this.grp_Informacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Informacao;
        private System.Windows.Forms.GroupBox grp_Informacao;
        private System.Windows.Forms.ListBox lb_Informacao;
        private System.Windows.Forms.Button btn_Ok;
    }
}