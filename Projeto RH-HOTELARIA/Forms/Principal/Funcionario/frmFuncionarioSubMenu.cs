using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Funcionario
{
    public partial class frmFuncionarioSubMenu : Form
    {
        public frmFuncionarioSubMenu()
        {
            InitializeComponent();
            ConfigurarLayout();
        }

        private void frmFuncionarioSubMenu_Load(object sender, EventArgs e)
        {

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
            var frmGerenciar = new SubFuncionario.frmGerenciarFunc();

            var mainForm = (frmMain)Application.OpenForms["frmMain"];
            mainForm.AbrirFormNoPainel(frmGerenciar);
        }

        private void btn_ListarFunc_Click(object sender, EventArgs e)
        {
            var frmListarFunc = new SubFuncionario.frmListarFunc();

            var mainForm = (frmMain)Application.OpenForms["frmMain"];
            mainForm.AbrirFormNoPainel(frmListarFunc);
        }

        private void btn_AlterarCargo_Click(object sender, EventArgs e)
        {
            var frmAlterarCargo = new SubFuncionario.frmFuncCargo();

            var mainForm = (frmMain)Application.OpenForms["frmMain"];
            mainForm.AbrirFormNoPainel(frmAlterarCargo);
        }
        #endregion

    }
}
