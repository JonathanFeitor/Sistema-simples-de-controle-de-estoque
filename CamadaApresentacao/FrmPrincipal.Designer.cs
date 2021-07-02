namespace CamadaApresentacao
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lbl_DataAtual = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.samanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmData = new System.Windows.Forms.Timer(this.components);
            this.lbl_IdFuncionario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DataAtual
            // 
            this.lbl_DataAtual.AutoSize = true;
            this.lbl_DataAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataAtual.Location = new System.Drawing.Point(9, 559);
            this.lbl_DataAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DataAtual.Name = "lbl_DataAtual";
            this.lbl_DataAtual.Size = new System.Drawing.Size(64, 25);
            this.lbl_DataAtual.TabIndex = 2;
            this.lbl_DataAtual.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 14F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1186, 31);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // controleToolStripMenuItem
            // 
            this.controleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiaisToolStripMenuItem,
            this.inventárioToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            this.controleToolStripMenuItem.Size = new System.Drawing.Size(88, 27);
            this.controleToolStripMenuItem.Text = "Controle";
            // 
            // materiaisToolStripMenuItem
            // 
            this.materiaisToolStripMenuItem.Name = "materiaisToolStripMenuItem";
            this.materiaisToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.materiaisToolStripMenuItem.Text = "Materiais";
            this.materiaisToolStripMenuItem.Click += new System.EventHandler(this.materiaisToolStripMenuItem_Click);
            // 
            // inventárioToolStripMenuItem
            // 
            this.inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            this.inventárioToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.inventárioToolStripMenuItem.Text = "Inventário";
            this.inventárioToolStripMenuItem.Click += new System.EventHandler(this.inventárioToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.samanaToolStripMenuItem,
            this.inventárioToolStripMenuItem1});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(91, 27);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // samanaToolStripMenuItem
            // 
            this.samanaToolStripMenuItem.Name = "samanaToolStripMenuItem";
            this.samanaToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.samanaToolStripMenuItem.Text = "Materiais";
            this.samanaToolStripMenuItem.Click += new System.EventHandler(this.samanaToolStripMenuItem_Click);
            // 
            // inventárioToolStripMenuItem1
            // 
            this.inventárioToolStripMenuItem1.Name = "inventárioToolStripMenuItem1";
            this.inventárioToolStripMenuItem1.Size = new System.Drawing.Size(160, 28);
            this.inventárioToolStripMenuItem1.Text = "Inventário";
            this.inventárioToolStripMenuItem1.Click += new System.EventHandler(this.inventárioToolStripMenuItem1_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçõesToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(67, 27);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // informaçõesToolStripMenuItem
            // 
            this.informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            this.informaçõesToolStripMenuItem.Size = new System.Drawing.Size(178, 28);
            this.informaçõesToolStripMenuItem.Text = "Informações";
            this.informaçõesToolStripMenuItem.Click += new System.EventHandler(this.informaçõesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(51, 27);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1168, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tmData
            // 
            this.tmData.Tick += new System.EventHandler(this.tmData_Tick);
            // 
            // lbl_IdFuncionario
            // 
            this.lbl_IdFuncionario.AutoSize = true;
            this.lbl_IdFuncionario.Location = new System.Drawing.Point(934, 47);
            this.lbl_IdFuncionario.Name = "lbl_IdFuncionario";
            this.lbl_IdFuncionario.Size = new System.Drawing.Size(76, 13);
            this.lbl_IdFuncionario.TabIndex = 6;
            this.lbl_IdFuncionario.Text = "ID Funcionário";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 612);
            this.Controls.Add(this.lbl_IdFuncionario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_DataAtual);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle Estoque";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_DataAtual;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem samanaToolStripMenuItem;
        private System.Windows.Forms.Timer tmData;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_IdFuncionario;
    }
}