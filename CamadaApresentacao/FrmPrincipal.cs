using CamadaNegocio;
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
    public partial class FrmPrincipal : Form
    {
        private string _idFuncionario;

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

        public string IdFuncionario { get => _idFuncionario; set => _idFuncionario = value; }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Contrutor
        public void SalvarIdFuncionario(string idFuncionario)
        {
            this.IdFuncionario = idFuncionario;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lbl_IdFuncionario.Text = this._idFuncionario;
            this.tmData.Start();
            this.MaximizeBox = false;
            //this.MinimizeBox = false;

        }

        private void lbl_DataAtual_Click(object sender, EventArgs e)
        {

        }

        private void materiaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMateriais mta = new FrmMateriais();
            mta.ShowDialog();
        }

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario inv = new FrmInventario();
            inv.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario fun = new FrmFuncionario();
            fun.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformacaoSobreSistema infSistema = new FrmInformacaoSobreSistema();
            infSistema.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tmData_Tick(object sender, EventArgs e)
        {
            lbl_DataAtual.Text = "Data: " + data + " Horas: " + hora + ":" + segundos;
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void samanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioMateriais RelMateriais = new FrmRelatorioMateriais();
            RelMateriais.ShowDialog();
        }

        private void inventárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelatorioInventario RelatorioInventario = new FrmRelatorioInventario();
            RelatorioInventario.ShowDialog();
        }
    }
}
