using CamadaNegocio;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace CamadaApresentacao
{
    public partial class FrmRelatorioInventario : Form
    {
        public FrmRelatorioInventario()
        {
            InitializeComponent();
        }

        public void MostrarRelatorioInventarioTodos()
        {
            this.dtg_RelatorioInventario.DataSource = NRelatorio.MostraRelatorioInventario("TODOS", this.cmb_StatusEquipamento.Text);

            this.dtg_RelatorioInventario.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;

            lbl_TotalDataGrid.Text = "Total de Registros: " + Convert.ToString(dtg_RelatorioInventario.Rows.Count - 1);

        }

        public void MostrarRelatorioInventario()
        {
            this.dtg_RelatorioInventario.DataSource = NRelatorio.MostraRelatorioInventario(this.cmb_BuscarTipo.Text, this.cmb_StatusEquipamento.Text);

            this.dtg_RelatorioInventario.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
            
            lbl_TotalDataGrid.Text = "Total de Registros: " + Convert.ToString(dtg_RelatorioInventario.Rows.Count - 1);

        }

        private void lbl_BuscarTipo_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmRelatorioInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mBRMESSTOCK_BuscarTipoInventario.sp_BuscarTipoInventario' table. You can move, or remove it, as needed.
            this.sp_BuscarTipoInventarioTableAdapter.Fill(this.mBRMESSTOCK_BuscarTipoInventario.sp_BuscarTipoInventario);
            this.cmb_BuscarTipo.Text = string.Empty;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if(chk_TodosEquipamentos.Checked == true && this.cmb_StatusEquipamento.Text != string.Empty)
            {
                this.MostrarRelatorioInventarioTodos();
            }
            else
            if (this.cmb_BuscarTipo.Text != string.Empty && this.cmb_StatusEquipamento.Text != string.Empty && this.chk_TodosEquipamentos.Checked == false)
            {
                this.MostrarRelatorioInventario();
            }
            else
            if (this.chk_TodosEquipamentos.Checked == false && this.cmb_StatusEquipamento.Text == string.Empty ||
                this.chk_TodosEquipamentos.Checked == false && this.cmb_StatusEquipamento.Text != string.Empty ||
                this.chk_TodosEquipamentos.Checked == true && this.cmb_StatusEquipamento.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher todos os campos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("Favor preencher todos os campos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

            if (dtg_RelatorioInventario.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dtg_RelatorioInventario.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dtg_RelatorioInventario.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dtg_RelatorioInventario.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dtg_RelatorioInventario.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dtg_RelatorioInventario.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    XcelApp.Columns.AutoFit();

                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    XcelApp.Quit();
                }

            }
        }
    }
}
