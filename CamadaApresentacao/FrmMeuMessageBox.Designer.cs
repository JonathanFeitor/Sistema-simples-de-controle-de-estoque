namespace CamadaApresentacao
{
    partial class FrmMeuMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeuMessageBox));
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Movimentacao = new System.Windows.Forms.Button();
            this.lbl_Informacao = new System.Windows.Forms.Label();
            this.lbl_Pergunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(100, 99);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(143, 66);
            this.btn_Editar.TabIndex = 0;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Movimentacao
            // 
            this.btn_Movimentacao.Location = new System.Drawing.Point(247, 99);
            this.btn_Movimentacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Movimentacao.Name = "btn_Movimentacao";
            this.btn_Movimentacao.Size = new System.Drawing.Size(141, 66);
            this.btn_Movimentacao.TabIndex = 1;
            this.btn_Movimentacao.Text = "Movimentação";
            this.btn_Movimentacao.UseVisualStyleBackColor = true;
            this.btn_Movimentacao.Click += new System.EventHandler(this.btn_Movimentacao_Click);
            // 
            // lbl_Informacao
            // 
            this.lbl_Informacao.AutoSize = true;
            this.lbl_Informacao.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Informacao.Location = new System.Drawing.Point(191, 7);
            this.lbl_Informacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Informacao.Name = "lbl_Informacao";
            this.lbl_Informacao.Size = new System.Drawing.Size(100, 23);
            this.lbl_Informacao.TabIndex = 2;
            this.lbl_Informacao.Text = "Informação";
            this.lbl_Informacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Pergunta
            // 
            this.lbl_Pergunta.AutoSize = true;
            this.lbl_Pergunta.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pergunta.Location = new System.Drawing.Point(28, 57);
            this.lbl_Pergunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Pergunta.Name = "lbl_Pergunta";
            this.lbl_Pergunta.Size = new System.Drawing.Size(42, 17);
            this.lbl_Pergunta.TabIndex = 3;
            this.lbl_Pergunta.Text = "label2";
            this.lbl_Pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMeuMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 176);
            this.Controls.Add(this.lbl_Pergunta);
            this.Controls.Add(this.lbl_Informacao);
            this.Controls.Add(this.btn_Movimentacao);
            this.Controls.Add(this.btn_Editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMeuMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informação";
            this.Load += new System.EventHandler(this.FrmMeuMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Movimentacao;
        private System.Windows.Forms.Label lbl_Informacao;
        private System.Windows.Forms.Label lbl_Pergunta;
    }
}