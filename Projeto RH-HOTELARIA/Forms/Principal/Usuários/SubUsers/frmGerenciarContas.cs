using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca;
using Projeto_RH_HOTELARIA.Models.RH;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers
{
    public partial class frmGerenciarContas : Form
    {
        SYS_UsuarioRepository usuario;

        public frmGerenciarContas()
        {
            InitializeComponent();
        }

        private void frmGerenciarContas_Load(object sender, EventArgs e)
        {
            UIStyle.ArredondarPanel(pnl_Top, 25);
            UIStyle.ArredondarPanel(pnl_Conteudo, 25);
            UIStyle.ArredondarPanel(pnl_Login, 15);
            UIStyle.ArredondarPanel(pnl_Foto, 30);
            UIStyle.ArredondarPanel(pnl_DocPessoal, 15);
            UIStyle.ArredondarPanel(pnl_Pessoa, 15);
        }


        private void btn_buscarRG(object sender, EventArgs e)
        {
            using (var rg = new frmBuscarRG())
            {
                if (rg.ShowDialog() == DialogResult.OK)
                {
                    var doc = rg.Tag as RH_DocumentosPessoa;
                    if (doc != null)
                    {
                        txtBox_RG.Text = doc.RG;
                    }
                }
            }
        }

    }
}
