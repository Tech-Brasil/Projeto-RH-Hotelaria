using Projeto_RH_HOTELARIA.Forms.Principal.Funcionario;
using Projeto_RH_HOTELARIA.Forms.Principal.Usuários;
using Projeto_RH_HOTELARIA.Models.SYS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal
{
    public partial class frmMain : Form
    {
       // private SYS_Usuario _usuario;
        public frmMain(/*SYS_Usuario usuario*/)
        {
            InitializeComponent();
            //_usuario = usuario; 
        }

        #region Eventos

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            frmUsuariosSubmenu usuariosSubmenu = new frmUsuariosSubmenu();
            AbrirForm(usuariosSubmenu);
        }

        private void btn_Funcionario_Click(object sender, EventArgs e)
        {
            frmFuncionarioSubMenu funcionarioSubMenu = new frmFuncionarioSubMenu();
            AbrirForm(funcionarioSubMenu);
        }

        #endregion

        #region Panel

        private void AbrirForm(Form frm)
        {
            pnl_Submenu.Visible = true;
            pnl_Submenu.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnl_Submenu.Controls.Add(frm);
            frm.Show();
        }

        public void AbrirFormNoPainel(Form formFilho)
        {
            pnl_Conteudo.Visible = true;
            pnl_Conteudo.Controls.Clear();

            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;

            pnl_Conteudo.Controls.Add(formFilho);
            formFilho.Show();
        }

        public Panel PnlConteudo
        {
            get { return pnl_Conteudo; }
        }

        public void LimparPainel()
        {
            pnl_Conteudo.Controls.Clear();
            pnl_Conteudo.Visible = false;
        }

        #endregion


    }
}
