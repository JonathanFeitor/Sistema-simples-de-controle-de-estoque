using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //Mostrar mensagem de confirmação
        private void MensagemOK(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensagem de erro
        private void MensagemError(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            FrmPrincipal formPrincipal = new FrmPrincipal();
            formPrincipal.SalvarIdFuncionario(txt_Login.Text);

            NLogin Logar = new NLogin();
            NSenhaMD5Hash cript = new NSenhaMD5Hash();
                               
            Logar.Acessar(txt_Login.Text, cript.CriptografarSenha(txt_Senha.Text));
            if (Logar.mensagem.Equals(""))
            {
                if (Logar.check == true)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos, verifique login e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Logar.mensagem);
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
