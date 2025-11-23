using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Models.RH;
using Projeto_RH_HOTELARIA.Services;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca
{
    public partial class frmBuscarPessoa : Form
    {
        string Nome = null;
        public frmBuscarPessoa(string Pnome)
        {
            Nome = Pnome;
            InitializeComponent();
        }

        private void frmBuscarPessoa_Load(object sender, EventArgs e)
        {
            UIStyle.ArredondarPanel(pnl_fundo, 15);

            var service = new RH_PessoaService(new RH_PessoaRepository());
            var pessoa = service.BuscarPorNome(Nome);

            if (pessoa != null)
            {
                cBox_Pes.Items.Add(pessoa);
            }
            else
            {
                MessageBox.Show("Nada foi Encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #region Button
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (cBox_Pes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item.");
                return;
            }

            this.Tag = cBox_Pes.SelectedItem;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
