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
    public partial class FrmInventario : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;

        public string data
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

        public FrmInventario()
        {
            InitializeComponent();
            this.tt_Mensagem.SetToolTip(this.txt_NumInventario, "Insira o ID do Funcionário");
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
            this.txt_NumInventario.Text = string.Empty;
            this.txt_TipoEquipamento.Text = string.Empty;
            this.txt_ModelEquipamento.Text = string.Empty;
            this.txt_NumSerial.Text = string.Empty;
            this.cmb_ConfStatus.Text = string.Empty;
            this.txt_IdFuncionario.Text = string.Empty;
            this.txt_IpEquipamento.Text = string.Empty;
            this.txt_LocalEquipamento.Text = string.Empty;
            this.txt_Descricao.Text = string.Empty;
        }
        
        private void OcultarColunas()
        {
            this.dtg_BuscarEquipamento.Columns[0].Visible = false;
        }

        //Habilitar os text box
        private void Habilitar(bool valor)
        {
            this.txt_NumInventario.ReadOnly = !valor;
            this.txt_TipoEquipamento.ReadOnly = !valor;
            this.txt_ModelEquipamento.ReadOnly = !valor;
            this.txt_NumSerial.ReadOnly = !valor;
            this.cmb_ConfStatus.Enabled = valor;
            this.txt_IdFuncionario.ReadOnly = !valor;
            this.txt_IpEquipamento.ReadOnly = !valor;
            this.txt_LocalEquipamento.ReadOnly = !valor;
            this.txt_Descricao.ReadOnly = !valor;
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
            this.dtg_BuscarEquipamento.DataSource = NInventario.Mostrar();
            this.OcultarColunas();
            lbl_TotalRegistro.Text = "Total de Registros: " + Convert.ToString(dtg_BuscarEquipamento.Rows.Count);
        }

        //Buscar pelo tipo
        private void BuscarTipo()
        {
            this.dtg_BuscarEquipamento.DataSource = NInventario.BuscarEquipamento(this.cmb_BuscarEquipamento.Text);
            this.OcultarColunas();
            lbl_TotalRegistro.Text = "Total de Registros: " + Convert.ToString(dtg_BuscarEquipamento.Rows.Count);
        }


        //Configuração da Aba Pesquisa

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (chk_TodosEquipamentos.Checked == true)
            {
                this.Mostrar();
                this.chk_TodosEquipamentos.Checked = false;
            }
            else if (cmb_BuscarEquipamento.Text != "" && chk_TodosEquipamentos.Checked == false)
            {
                this.BuscarTipo();
            }
            else
            {
                MessageBox.Show("Selecione a informação do tipo de Busca", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtg_BuscarEquipamento_DoubleClick(object sender, EventArgs e)
        {
            this.txt_NumInventario.Text = Convert.ToString(this.dtg_BuscarEquipamento.CurrentRow.Cells["numero_inventario"].Value);
            this.txt_TipoEquipamento.Text = Convert.ToString(this.dtg_BuscarEquipamento.CurrentRow.Cells["tipo_equipamento"].Value);
            this.txt_ModelEquipamento.Text = Convert.ToString(this.dtg_BuscarEquipamento.CurrentRow.Cells["modelo_equipamento"].Value);
            this.txt_NumSerial.Text = Convert.ToString(this.dtg_BuscarEquipamento.CurrentRow.Cells["numero_serial"].Value);
            this.cmb_ConfStatus.Text = Convert.ToString(this.dtg_BuscarEquipamento.CurrentRow.Cells["status_equipamento"].Value);
            this.txt_IdFuncionario.Text = Convert.ToString(this.dtg_BuscarEquipamento.CurrentRow.Cells["id_funcionario"].Value);
            this.txt_IpEquipamento.Text = Convert.ToString(this.dtg_BuscarEquipamento.CurrentRow.Cells["ip_equipamento"].Value);
            this.txt_LocalEquipamento.Text = Convert.ToString(this.dtg_BuscarEquipamento.CurrentRow.Cells["localizacao"].Value);
            this.txt_Descricao.Text = Convert.ToString(this.dtg_BuscarEquipamento.CurrentRow.Cells["descricao"].Value);

            this.tbc_Inventario.SelectedIndex = 1;
            this.HabilitarBotao();
            
        }

        private void dtg_BuscarEquipamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtg_BuscarEquipamento.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkExcluir = (DataGridViewCheckBoxCell)dtg_BuscarEquipamento.Rows[e.RowIndex].Cells["Excluir"];
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
                    int numInventario;
                    string resp = "";

                    foreach (DataGridViewRow row in dtg_BuscarEquipamento.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            numInventario = Convert.ToInt32(row.Cells[1].Value);
                            resp = NInventario.Excluir(numInventario);

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
                    this.chk_DeleteEquipamento.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chk_DeleteEquipamento_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_DeleteEquipamento.Checked)
            {
                this.dtg_BuscarEquipamento.Columns[0].Visible = true;

            }
            else
            {
                this.dtg_BuscarEquipamento.Columns[0].Visible = false;
            }
        }


        //Configuração da Aba Configurações

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
            this.eEditar = true;
            this.eNovo = false;
            this.HabilitarBotao();
            this.Habilitar(true);
            this.txt_NumInventario.Enabled = false;

        }

        private void btn_ConfNovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.HabilitarBotao();
            this.Limpar();
            this.Habilitar(true);
            this.txt_NumInventario.Enabled = true;
            this.txt_NumInventario.Focus();
        }

        private void btn_ConfSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                bool checkinfo = false;

                if (this.txt_NumInventario.Text == string.Empty)
                {
                    errorIcone.SetError(txt_NumInventario, "Insira o Número do Inventário");
                    checkinfo = true;
                }
                if (this.txt_TipoEquipamento.Text == string.Empty)
                {
                    errorIcone.SetError(txt_TipoEquipamento, "Insira o tipo do Equipamento");
                    checkinfo = true;
                }
                if (this.txt_ModelEquipamento.Text == string.Empty)
                {
                    errorIcone.SetError(txt_ModelEquipamento, "Insira o modelo do Equipamento");
                    checkinfo = true;
                }
                if (this.txt_NumSerial.Text == string.Empty)
                {
                    errorIcone.SetError(txt_NumSerial, "Insira o o número serial do Equipamento");
                    checkinfo = true;
                }
                if (this.cmb_ConfStatus.Text == string.Empty)
                {
                    errorIcone.SetError(cmb_ConfStatus, "Insira o Status do Equipamento");
                    checkinfo = true;
                }
                if (this.txt_IdFuncionario.Text == string.Empty)
                {
                    errorIcone.SetError(txt_IdFuncionario, "Insira o ID do Funcionário");
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
                        resp = NInventario.Inserir(Convert.ToInt32(this.txt_NumInventario.Text.Trim()),
                                                   this.txt_TipoEquipamento.Text.Trim(),
                                                   this.txt_ModelEquipamento.Text.Trim(),
                                                   this.txt_NumSerial.Text.Trim(),
                                                   this.cmb_ConfStatus.Text.Trim(),
                                                   this.txt_IdFuncionario.Text.Trim(),
                                                   this.txt_IpEquipamento.Text.Trim(),
                                                   this.txt_LocalEquipamento.Text.Trim(),
                                                   this.txt_Descricao.Text.Trim());
                    }
                    else 
                    {
                        resp = NInventario.Editar(Convert.ToInt32(this.txt_NumInventario.Text.Trim()),
                                                   this.txt_TipoEquipamento.Text.Trim(),
                                                   this.txt_ModelEquipamento.Text.Trim(),
                                                   this.txt_NumSerial.Text.Trim(),
                                                   this.cmb_ConfStatus.Text.Trim(),
                                                   this.txt_IdFuncionario.Text.Trim(),
                                                   this.txt_IpEquipamento.Text.Trim(),
                                                   this.txt_LocalEquipamento.Text.Trim(),
                                                   this.txt_Descricao.Text.Trim());
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
                        MensagemError(resp);
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

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mBRMESSTOCK_BuscarTipoInventario.sp_BuscarTipoInventario' table. You can move, or remove it, as needed.
            this.sp_BuscarTipoInventarioTableAdapter.Fill(this.mBRMESSTOCK_BuscarTipoInventario.sp_BuscarTipoInventario);
            this.cmb_BuscarEquipamento.Text = string.Empty;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.tmData.Start();

            this.Habilitar(false);
            this.HabilitarBotao();
            this.OcultarColunas();
        }

        private void tmData_Tick(object sender, EventArgs e)
        {
            lbl_DataAtual.Text = "Data: " + data + " Horas: " + hora + ":" + segundos;
        }

        private void cmb_BuscarEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
