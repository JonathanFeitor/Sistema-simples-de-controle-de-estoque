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
using Microsoft.Office.Interop.Excel;

namespace CamadaApresentacao
{
    public partial class FrmRelatorioMateriais : Form
    {
        public FrmRelatorioMateriais()
        {
            InitializeComponent();
        }

        //Buscar Relatorio Materiais
        private void MostrarRelatorioMateriais()
        {
            string Movimentacao = "";
            
            if(cmb_TipoMovimentacao.Text == "Todos")
            {
                Movimentacao = "Todos";
                this.dtg_RelatorioMaterial.DataSource = NRelatorio.MostrarRelatorioMateriais(this.cmb_TipoMaterial.Text, Movimentacao,
                Convert.ToDateTime(dateTime_Data1.Text), Convert.ToDateTime(dateTime_Data2.Text));
                dtg_RelatorioMaterial.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;              

            }
            else

            if (cmb_TipoMovimentacao.Text == "Entrada")
            {
                Movimentacao = "ENTRADA";
                this.dtg_RelatorioMaterial.DataSource = NRelatorio.MostrarRelatorioMateriais(this.cmb_TipoMaterial.Text, Movimentacao,
                Convert.ToDateTime(dateTime_Data1.Text), Convert.ToDateTime(dateTime_Data2.Text));
                dtg_RelatorioMaterial.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;

            }
            else
            {
             
                Movimentacao = "SAIDA";
                this.dtg_RelatorioMaterial.DataSource = NRelatorio.MostrarRelatorioMateriais(this.cmb_TipoMaterial.Text, Movimentacao,
                Convert.ToDateTime(dateTime_Data1.Text), Convert.ToDateTime(dateTime_Data2.Text));
                dtg_RelatorioMaterial.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
               
            }

            this.lbl_QuantidadeMaterial.Visible = true;
            this.lbl_TotalMovimentacao.Visible = true;

            lbl_TotalMovimentacao.Text = "Total de Registros: " + Convert.ToString(dtg_RelatorioMaterial.Rows.Count - 1);

            lbl_QuantidadeMaterial.Text = "Total de Materiais: " + Convert.ToString(dtg_RelatorioMaterial.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToInt32(i.Cells["Quantidade"].Value)));
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (cmb_TipoMaterial.Text == "" || dateTime_Data1.Text == "" || dateTime_Data2.Text == "" || cmb_TipoMovimentacao.Text == "")
            {
                MessageBox.Show("Favor checar as opções abaixo: \n\n*Selecionar Tipo\n*Selecionar Datas", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.MostrarRelatorioMateriais();
            }
            
        }

        private void FrmRelatorioMateriais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mBRMESSTOCKRelatorioBuscarTipoMateriais.sp_RelatorioMateriaisBuscarTipo' table. You can move, or remove it, as needed.
            this.sp_RelatorioMateriaisBuscarTipoTableAdapter.Fill(this.mBRMESSTOCKRelatorioBuscarTipoMateriais.sp_RelatorioMateriaisBuscarTipo);
            this.cmb_TipoMaterial.Text = string.Empty;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.lbl_QuantidadeMaterial.Visible = false;
            this.lbl_TotalMovimentacao.Visible = false;
        }

        private void dtg_RelatorioMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_TotalMovimentacao_Click(object sender, EventArgs e)
        {

        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

            if(dtg_RelatorioMaterial.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dtg_RelatorioMaterial.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dtg_RelatorioMaterial.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dtg_RelatorioMaterial.Rows.Count - 1; i++)
                    {
                        for(int j = 0; j < dtg_RelatorioMaterial.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dtg_RelatorioMaterial.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    XcelApp.Columns.AutoFit();
                   
                    XcelApp.Visible = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    XcelApp.Quit();
                }
                
            }
        }
    }
}
