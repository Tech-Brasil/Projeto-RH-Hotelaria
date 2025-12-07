using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Models.RH;
using Projeto_RH_HOTELARIA.Services;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca
{
    public partial class frmBuscarDocPessoa : Form
    {

        string RG = null;
        public frmBuscarDocPessoa(string rg)
        {
            RG = rg;
            InitializeComponent();
        }

        private void frmBuscarDocPessoa_Load(object sender, EventArgs e)
        {
            UIStyle.ArredondarPanel(pnl_fundo, 15);

            var service = new RH_DocumentosPessoaService(new RH_DocumentosPessoaRepository());
            var documento = service.BuscarPorRG(RG);

            if(documento != null)
            {
                cBox_DocPes.Items.Add(documento);
            }
        }

        #region Button

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (cBox_DocPes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item.");
                return;
            }

            this.Tag = cBox_DocPes.SelectedItem;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion
    }
}
