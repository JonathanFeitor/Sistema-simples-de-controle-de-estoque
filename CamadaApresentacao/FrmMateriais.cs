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
using System.Globalization;

namespace CamadaApresentacao
{
    public partial class FrmMateriais : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;

        public string  data
        {
            get { return DateTime.Now.ToShortDateString(); }
        }
        public string hora
        {
            get { return DateTime.Now.ToShortTimeString(); }
        }
        public string segundos
        {
            get { return DateTime.Now.Second.ToString(); }
        }

        public FrmMateriais()
        {
            InitializeComponent();
            this.tt_Mensagem.SetToolTip(this.txt_ConfIdMateriais, "Insira o ID do Material");
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
            this.txt_ConfIdMateriais.Text = string.Empty;
            this.txt_MovIdMateriais.Text = string.Empty;
            this.txt_ConfTipoMateriais.Text = string.Empty;
            this.txt_MovTipoMateriais.Text = string.Empty;
            this.txt_ConfModeloMateriais.Text = string.Empty;
            this.txt_MovModeloMateriais.Text = string.Empty;
            this.txt_ConfQuantidadeMateriais.Text = string.Empty;
            this.txt_MovQuantidadeMateriais.Text = string.Empty;
            this.txt_ConfIdFuncionario.Text = string.Empty;
            this.txt_ConfDescicaoMateriais.Text = string.Empty;
        }

        private void OcultarColunas()
        {
            this.dtg_BuscarMateriais.Columns[0].Visible = false;
        }

        //Habilitar os text box
        private void Habilitar(bool valor)
        {
            this.txt_ConfIdMateriais.ReadOnly = !valor;
            this.txt_ConfTipoMateriais.Enabled = valor;
            this.txt_ConfModeloMateriais.ReadOnly = !valor;
            this.txt_ConfQuantidadeMateriais.ReadOnly = !valor;
            this.txt_ConfIdFuncionario.ReadOnly = !valor;
            this.txt_ConfDescicaoMateriais.ReadOnly = !valor;
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
            this.dtg_BuscarMateriais.DataSource = NMateriais.Mostra();
            this.OcultarColunas();
            lbl_Total.Text = "Total de Registros: " + Convert.ToString(dtg_BuscarMateriais.Rows.Count);
        }

        //Buscar pelo tipo
        private void BuscarTipo()
        {
            this.dtg_BuscarMateriais.DataSource = NMateriais.BuscarMateriais(this.cmb_BuscarMateriais.Text);
            this.OcultarColunas();
            lbl_Total.Text = "Total de Registros: " + Convert.ToString(dtg_BuscarMateriais.Rows.Count);
        }



        private void tb3_MovimentacaoMateriais_Click(object sender, EventArgs e)
        {
            
        }


        //Configuração da Aba Pesquisa
        private void dtg_BuscarMateriais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtg_BuscarMateriais.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkExcluir = (DataGridViewCheckBoxCell)dtg_BuscarMateriais.Rows[e.RowIndex].Cells["Excluir"];
                ChkExcluir.Value = !Convert.ToBoolean(ChkExcluir.Value);
            }
        }

        private void dtg_BuscarMateriais_DoubleClick(object sender, EventArgs e)
        {
            FrmMeuMessageBox infcheck = new FrmMeuMessageBox();

            infcheck.ShowDialog();

            if(infcheck.Resp == "Editar")
            {
                this.txt_ConfIdMateriais.Text = Convert.ToString(this.dtg_BuscarMateriais.CurrentRow.Cells["id_material"].Value);
                this.txt_ConfTipoMateriais.Text = Convert.ToString(this.dtg_BuscarMateriais.CurrentRow.Cells["tipo"].Value);
                this.txt_ConfModeloMateriais.Text = Convert.ToString(this.dtg_BuscarMateriais.CurrentRow.Cells["modelo"].Value);
                this.txt_ConfQuantidadeMateriais.Text = Convert.ToString(this.dtg_BuscarMateriais.CurrentRow.Cells["quantidade"].Value);
                this.txt_ConfIdFuncionario.Text = Convert.ToString(this.dtg_BuscarMateriais.CurrentRow.Cells["id_funcionario"].Value);
                this.txt_ConfDescicaoMateriais.Text = Convert.ToString(this.dtg_BuscarMateriais.CurrentRow.Cells["descricao"].Value);

                this.tbc_Materiais.SelectedIndex = 1;
                this.HabilitarBotao();
            }
            else
            {
                this.txt_MovIdMateriais.Text = Convert.ToString(this.dtg_BuscarMateriais.CurrentRow.Cells["id_material"].Value);
                this.txt_MovTipoMateriais.Text = Convert.ToString(this.dtg_BuscarMateriais.CurrentRow.Cells["tipo"].Value);
                this.txt_MovModeloMateriais.Text = Convert.ToString(this.dtg_BuscarMateriais.CurrentRow.Cells["modelo"].Value);

                this.tbc_Materiais.SelectedIndex = 2;
                this.txt_MovIdMateriais.Enabled = false;
                this.txt_MovTipoMateriais.Enabled = false;
                this.txt_MovModeloMateriais.Enabled = false;
                
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (chk_TodosMateriais.Checked == true)
            {
                this.Mostrar();
                this.chk_TodosMateriais.Checked = false;
            }
            else if (cmb_BuscarMateriais.Text != "ALL")
            {
                this.BuscarTipo();
            }
            else
            {
                MessageBox.Show("Selecione a informação do tipo de Busca", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chk_DeleteMateriais_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_DeleteMateriais.Checked)
            {
                this.dtg_BuscarMateriais.Columns[0].Visible = true;

            }
            else
            {
                this.dtg_BuscarMateriais.Columns[0].Visible = false;
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
                    int idMateriais;
                    string resp = "";

                    foreach (DataGridViewRow row in dtg_BuscarMateriais.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            idMateriais = Convert.ToInt32(row.Cells[1].Value);
                            resp = NMateriais.Excluir(idMateriais);

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
                    this.chk_DeleteMateriais.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        //Configurações da Aba Configuração Materiais
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
            if (txt_ConfTipoMateriais.Text.Equals(""))
            {
                this.MensagemError("Selecione o Tipo Material para ser alterado.");
            }
            else
            {
                this.eEditar = true;
                this.HabilitarBotao();
                this.Habilitar(true);
                this.txt_ConfIdMateriais.Enabled = false;
                this.txt_ConfQuantidadeMateriais.Enabled = false;
            }
        }

        private void btn_ConfNovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.HabilitarBotao();
            this.Limpar();
            this.Habilitar(true);
            this.txt_ConfTipoMateriais.Focus();
            this.txt_ConfIdMateriais.Enabled = false;
        }

        private void btn_ConfSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                bool checkInfo = false;

                if (this.txt_ConfTipoMateriais.Text == string.Empty)
                {
                    errorIcone.SetError(txt_ConfTipoMateriais, "Insira o Tipo de Material");
                    checkInfo = true;
                }
                if(this.txt_ConfModeloMateriais.Text == string.Empty)
                {
                    errorIcone.SetError(txt_ConfModeloMateriais, "Insira o Modelo do Material");
                    checkInfo = true;
                }
                if (this.txt_ConfQuantidadeMateriais.Text == string.Empty)
                {
                    errorIcone.SetError(txt_ConfQuantidadeMateriais, "Insira o valor da Quantidade de Materiais");
                    checkInfo = true;
                }
                if (this.txt_ConfIdFuncionario.Text == string.Empty)
                {
                    errorIcone.SetError(txt_ConfIdFuncionario, "Insira o ID do Funcionário");
                    checkInfo = true;
                }
                if(checkInfo == true)
                {
                    MensagemError("Preencha todos os campos");
                }
                else
                {
                    if (this.eNovo)
                    {
                        resp = NMateriais.Inserir(this.txt_ConfTipoMateriais.Text.Trim(),
                                                   this.txt_ConfModeloMateriais.Text.Trim(),
                                                   Convert.ToInt32(this.txt_ConfQuantidadeMateriais.Text.Trim()),
                                                   this.txt_ConfIdFuncionario.Text.Trim(),
                                                   this.txt_ConfDescicaoMateriais.Text.Trim());
                                                   
                    }
                    else
                    {
                        resp = NMateriais.Editar(Convert.ToInt32(this.txt_ConfIdMateriais.Text.Trim()),
                                                   this.txt_ConfTipoMateriais.Text.Trim(),
                                                   this.txt_ConfModeloMateriais.Text.Trim(),
                                                   this.txt_ConfIdFuncionario.Text.Trim(),
                                                   this.txt_ConfDescicaoMateriais.Text.Trim());
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
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        //Configurações da Aba Movimentação
        private void btn_MovSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                bool checkInfo = false;

                if(txt_MovQuantidadeMateriais.Text == string.Empty)
                {
                    errorIcone.SetError(txt_MovQuantidadeMateriais, "Insira a quantidade de Materiais");
                    checkInfo = true;
                }
                if(checkInfo == true)
                {
                    MensagemError("Preencha todos os campos");
                }
                else
                {
                    if (chk_MovEntradaMateriais.Checked == true && chk_MovSaidaMateriais.Checked == false)
                    {
                        resp = NMateriais.SomaQuantidade(Convert.ToInt32(this.txt_MovIdMateriais.Text.Trim()),
                                                            this.txt_MovTipoMateriais.Text.Trim(),
                                                            this.txt_MovModeloMateriais.Text.Trim(),
                                                            Convert.ToInt32(this.txt_MovQuantidadeMateriais.Text.Trim()));
                    }
                    else if(chk_MovSaidaMateriais.Checked == true && chk_MovEntradaMateriais.Checked == false)
                    {
                        resp = NMateriais.SubQuantidade(Convert.ToInt32(this.txt_MovIdMateriais.Text.Trim()),
                                                            this.txt_MovTipoMateriais.Text.Trim(),
                                                            this.txt_MovModeloMateriais.Text.Trim(),
                                                            Convert.ToInt32(this.txt_MovQuantidadeMateriais.Text.Trim()));
                    }
                    else
                    {
                        MessageBox.Show("Clique nas opções de entrada ou saída", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (resp.Equals("OK"))
                    {
                        if (chk_MovEntradaMateriais.Checked == true)
                        {
                            this.MensagemOK("Registro inserido com sucesso");
                        }
                        else
                        {
                            this.MensagemOK("Registro inserido com sucesso");
                        }
                    }
                    else
                    {
                        this.MensagemError(resp);
                    }
                    this.Limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            this.chk_MovEntradaMateriais.Checked = false;
            this.chk_MovSaidaMateriais.Checked = false;
            this.Mostrar();
            
        }

        private void btn_MovCancelar_Click(object sender, EventArgs e)
        {
            this.Limpar();
        }


        //Inicialização do Formulário
        private void FrmMateriais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mBRMESSTOCK_BuscarTipoMateriais.sp_BuscarTipoMateriais' table. You can move, or remove it, as needed.
            this.sp_BuscarTipoMateriaisTableAdapter.Fill(this.mBRMESSTOCK_BuscarTipoMateriais.sp_BuscarTipoMateriais);
            this.cmb_BuscarMateriais.Text = string.Empty;
            this.txt_MovIdMateriais.Enabled = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            tmData.Start();

            this.Habilitar(false);
            this.HabilitarBotao();
            this.OcultarColunas();
        }

        private void tmData_Tick(object sender, EventArgs e)
        {
            lbl_ConfDataAtual.Text = "Data: " + data + " Horas: " + hora +":" + segundos;
            lbl_MovDataAtual.Text = "Data: " + data + "Horas: " + hora + ":" + segundos;
        }

        private void tb1_BuscarMateriais_Click(object sender, EventArgs e)
        {

        }
    }
}
