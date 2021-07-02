using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class FrmMeuMessageBox : Form
    {
        public FrmMeuMessageBox()
        {
            InitializeComponent();
        }

        private string resp = "";

        public string Resp { get => resp; set => resp = value; }

        private void FrmMeuMessageBox_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            lbl_Pergunta.Text = "Escolha uma opção abaixo, para continuar o processo: ";
        }

        public static DialogResult Checar()
        {
            var msgBox = new FrmMeuMessageBox();
            msgBox.btn_Editar.Text = "Editar";
            msgBox.btn_Movimentacao.Text = "Movimentação";
            msgBox.ShowDialog();
            return msgBox.DialogResult;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Resp = "Editar";
            Close();
        }

        private void btn_Movimentacao_Click(object sender, EventArgs e)
        {
            Resp = "Movimentacao";
            Close();
        }
    }
}
