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
    public partial class FrmFuncionario : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;

        public FrmFuncionario()
        {
            InitializeComponent();
            this.tt_Mensagem.SetToolTip(this.txt_IdFuncionario, "Insira o ID do Funcionário");
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

        //Limpar Campos
        private void Limpar()
        {
            this.txt_IdFuncionario.Text = string.Empty;
            this.txt_NomeFuncionario.Text = string.Empty;
            this.txt_CargoFuncionario.Text = string.Empty;
            this.txt_TelFuncionario.Text = string.Empty;
            this.txt_SenhaFuncionario.Text = string.Empty;
        }

        private void OcultarColunas()
        {
            this.dtg_BuscarFuncionario.Columns[0].Visible = false;
        }

        //Habilitar os text box
        private void Habilitar(bool valor)
        {
            this.txt_IdFuncionario.ReadOnly = !valor;
            this.txt_NomeFuncionario.ReadOnly = ! valor;
            this.txt_CargoFuncionario.ReadOnly = !valor;
            this.txt_CargoFuncionario.ReadOnly = !valor;
            this.txt_TelFuncionario.ReadOnly = !valor;
            this.txt_SenhaFuncionario.ReadOnly = !valor;
        }

        //Habilitar Botões
        private void HabilitarBotao()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btn_ConfNovo.Enabled = false;
                this.btn_ConfSalvar.Enabled = true;
                this.btn_ConfEditar.Enabled = false;
                this.btn_ConfCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btn_ConfNovo.Enabled = true;
                this.btn_ConfSalvar.Enabled = false;
                this.btn_ConfEditar.Enabled = true;
                this.btn_ConfCancelar.Enabled = false;
            }
        }

        //Mostrar no Data Grid
        private void Mostrar()
        {
            this.dtg_BuscarFuncionario.DataSource = NFuncionario.Mostrar();
            this.OcultarColunas();
            this.dtg_BuscarFuncionario.Columns[5].Visible = false;
            lbl_TotalRegistro.Text = "Total de Registros: " + Convert.ToString(dtg_BuscarFuncionario.Rows.Count);
        }

        //Buscar pelo tipo
        private void BuscarTipo()
        {
            this.dtg_BuscarFuncionario.DataSource = NFuncionario.BuscarFuncionario(this.cmb_BuscarFuncionario.Text);
            this.OcultarColunas();
            this.dtg_BuscarFuncionario.Columns[5].Visible = false;
            lbl_TotalRegistro.Text = "Total de Registros: " + Convert.ToString(dtg_BuscarFuncionario.Rows.Count);
        }


        //Configuração da Aba Pesquisa
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (chk_TodosFuncionarios.Checked == true)
            {
                this.Mostrar();
                this.chk_TodosFuncionarios.Checked = false;
            }
            else if (cmb_BuscarFuncionario.Text != "" && chk_TodosFuncionarios.Checked == false)
            {
                this.BuscarTipo();
            }
            else
            {
                MessageBox.Show("Selecione a informação do tipo de Busca", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtg_BuscarFuncionario_DoubleClick(object sender, EventArgs e)
        {
            this.txt_IdFuncionario.Text = Convert.ToString(this.dtg_BuscarFuncionario.CurrentRow.Cells["id_funcionario"].Value);
            this.txt_NomeFuncionario.Text = Convert.ToString(this.dtg_BuscarFuncionario.CurrentRow.Cells["nome"].Value);
            this.txt_CargoFuncionario.Text = Convert.ToString(this.dtg_BuscarFuncionario.CurrentRow.Cells["cargo"].Value);
            this.txt_TelFuncionario.Text = Convert.ToString(this.dtg_BuscarFuncionario.CurrentRow.Cells["telefone"].Value);
            this.txt_SenhaFuncionario.Text = "";

            this.tbc_Funcionario.SelectedIndex = 1;
            this.HabilitarBotao();
            this.txt_IdFuncionario.Enabled = false;
        }

        private void dtg_BuscarFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtg_BuscarFuncionario.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkExcluir = (DataGridViewCheckBoxCell)dtg_BuscarFuncionario.Rows[e.RowIndex].Cells["Excluir"];
                ChkExcluir.Value = !Convert.ToBoolean(ChkExcluir.Value);
            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja apagar os registros selecionados", "Sistema Estoque",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcao == DialogResult.OK)
                {
                    string idFuncionario;
                    string resp = "";

                    foreach (DataGridViewRow row in dtg_BuscarFuncionario.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            idFuncionario = Convert.ToString(row.Cells[1].Value);
                            resp = NFuncionario.Excluir(idFuncionario);

                            if (resp.Equals("OK"))
                            {
                                this.MensagemOK("Registros excluidos com sucesso.");
                            }
                            else
                            {
                                this.MensagemError(resp);
                            }
                        }
                    }
                    this.Mostrar();
                    this.chk_DeleteFuncionario.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chk_DeleteFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_DeleteFuncionario.Checked)
            {
                this.dtg_BuscarFuncionario.Columns[0].Visible = true;

            }
            else
            {
                this.dtg_BuscarFuncionario.Columns[0].Visible = false;
            }
        }


        //Configurações da Aba Configuração Funcionario
        private void btn_ConfCancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.HabilitarBotao();
            this.Habilitar(false);
            this.Limpar();
        }

        private void btn_ConfEditar_Click(object sender, EventArgs e)
        {
            if (txt_IdFuncionario.Text.Equals(""))
            {
                this.MensagemError("Selecione o ID do Funcionário.");
            }
            else
            {
                this.eEditar = true;
                this.HabilitarBotao();
                this.Habilitar(true);
                this.txt_IdFuncionario.Enabled = false;
            }
        }

        private void btn_ConfNovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.HabilitarBotao();
            this.Limpar();
            this.Habilitar(true);
            this.txt_IdFuncionario.Focus();
            this.txt_IdFuncionario.Enabled = true;
        }

        private void btn_ConfSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                bool checkinfo = false;

                NSenhaMD5Hash cript = new NSenhaMD5Hash();

                if (this.txt_IdFuncionario.Text == string.Empty)
                {
                    errorIcone.SetError(txt_IdFuncionario, "Insira o ID do Funcionário");
                    checkinfo = true;
                }
                if (this.txt_NomeFuncionario.Text == string.Empty)
                {
                    errorIcone.SetError(txt_NomeFuncionario, "Insira o nome do Funcionário");
                    checkinfo = true;
                }
                if (this.txt_SenhaFuncionario.Text == string.Empty)
                {
                    errorIcone.SetError(txt_SenhaFuncionario, "Insira uma senha de acesso");
                    checkinfo = true;
                }
                if (checkinfo == true)
                {
                    MensagemError("Preencha todos os campos");
                }
                else
                {
                    if (this.eNovo)
                    {
                        resp = NFuncionario.Inserir(this.txt_IdFuncionario.Text.Trim(),
                                                   this.txt_NomeFuncionario.Text.Trim(),
                                                   this.txt_CargoFuncionario.Text.Trim(),
                                                   this.txt_TelFuncionario.Text.Trim(),
                                                   cript.CriptografarSenha(this.txt_SenhaFuncionario.Text.Trim()));

                    }
                    else
                    {
                        resp = NFuncionario.Editar(this.txt_IdFuncionario.Text.Trim(),
                                                   this.txt_NomeFuncionario.Text.Trim(),
                                                   this.txt_CargoFuncionario.Text.Trim(),
                                                   this.txt_TelFuncionario.Text.Trim(),
                                                   cript.CriptografarSenha(this.txt_SenhaFuncionario.Text.Trim()));
                    }
                    if (resp.Equals("OK"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOK("Registro salvo com sucesso.");
                        }
                        else
                        {
                            this.MensagemOK("Registro editado com sucesso.");
                        }
                    }
                    else
                    {
                        this.MensagemError(resp);
                    }
                    this.eNovo = false;
                    this.eEditar = false;
                    this.HabilitarBotao();
                    this.Limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mBRMESSTOCK_BuscarIdFuncionario.sp_BuscarIDFuncionario' table. You can move, or remove it, as needed.
            this.sp_BuscarIDFuncionarioTableAdapter.Fill(this.mBRMESSTOCK_BuscarIdFuncionario.sp_BuscarIDFuncionario);
            this.cmb_BuscarFuncionario.Text = string.Empty;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Habilitar(false);
            this.HabilitarBotao();
            this.OcultarColunas();
        }
        

    }
}
