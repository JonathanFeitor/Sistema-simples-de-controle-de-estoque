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
    public partial class FrmInformacaoSobreSistema : Form
    {
        public FrmInformacaoSobreSistema()
        {
            InitializeComponent();
        }

        private void lb_Informacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Informacao_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInformacaoSobreSistema_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
