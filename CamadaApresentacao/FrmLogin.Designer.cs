namespace CamadaApresentacao
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_IdFuncionario = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.btn_Logar = new System.Windows.Forms.Button();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(230, 37);
            this.txt_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(145, 20);
            this.txt_Login.TabIndex = 0;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(230, 89);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(145, 20);
            this.txt_Senha.TabIndex = 1;
            // 
            // lbl_IdFuncionario
            // 
            this.lbl_IdFuncionario.AutoSize = true;
            this.lbl_IdFuncionario.Location = new System.Drawing.Point(152, 40);
            this.lbl_IdFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_IdFuncionario.Name = "lbl_IdFuncionario";
            this.lbl_IdFuncionario.Size = new System.Drawing.Size(76, 13);
            this.lbl_IdFuncionario.TabIndex = 2;
            this.lbl_IdFuncionario.Text = "ID Funcionario";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(152, 92);
            this.lbl_Senha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_Senha.TabIndex = 3;
            this.lbl_Senha.Text = "Senha";
            // 
            // btn_Logar
            // 
            this.btn_Logar.Location = new System.Drawing.Point(217, 150);
            this.btn_Logar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Size = new System.Drawing.Size(80, 33);
            this.btn_Logar.TabIndex = 4;
            this.btn_Logar.Text = "Logar";
            this.btn_Logar.UseVisualStyleBackColor = true;
            this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(302, 150);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 33);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CamadaApresentacao.Properties.Resources.userpassword_deusuari_787;
            this.pictureBox1.Location = new System.Drawing.Point(17, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 146);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 193);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Logar);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_IdFuncionario);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_IdFuncionario;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Button btn_Logar;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}