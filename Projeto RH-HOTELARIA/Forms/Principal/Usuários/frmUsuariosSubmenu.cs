using Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários
{
    public partial class frmUsuariosSubmenu : Form
    {
        public frmUsuariosSubmenu()
        {
            InitializeComponent();
            ConfigurarLayout();
        }


        #region Configurações de Formulário
        private void ConfigurarLayout()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(232, 232, 232);
        }
        #endregion

        #region Button

        private void btn_Manager_Click(object sender, EventArgs e)
        {
            var frmGerenciar = new frmGerenciarContas();

            var mainForm = (frmMain)Application.OpenForms["frmMain"];
            mainForm.AbrirFormNoPainel(frmGerenciar);
        }

        private void btn_Senha_Click(object sender, EventArgs e)
        {
            var frmAlteraSenha = new frmAlterarSenha();

            var mainForm = (frmMain)Application.OpenForms["frmMain"];
            mainForm.AbrirFormNoPainel(frmAlteraSenha);
        }

        private void btn_Permissao_Click(object sender, EventArgs e)
        {
            var frmPermissoes = new frmPermissoes();

            var mainForm = (frmMain)Application.OpenForms["frmMain"];
            mainForm.AbrirFormNoPainel(frmPermissoes);
        }

        private void btn_AtivarDesativar_Click(object sender, EventArgs e)
        {
            var frmAtivarDesativar = new frmAtivDesaUser();

            var mainForm = (frmMain)Application.OpenForms["frmMain"];
            mainForm.AbrirFormNoPainel(frmAtivarDesativar);
        }
        private void btn_Listar_Click(object sender, EventArgs e)
        {
            var frmListagemUser = new frmListagemUser();

            var mainForm = (frmMain)Application.OpenForms["frmMain"];
            mainForm.AbrirFormNoPainel(frmListagemUser);
        }


        #endregion


    }
}
