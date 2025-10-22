using Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void ConfigurarLayout()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(232, 232, 232);
        }

        private void btn_Manager_Click(object sender, EventArgs e)
        {
            var frmGerenciar = new frmGerenciarContas();

            var mainForm = (frmMain)Application.OpenForms["frmMain"];
            mainForm.AbrirFormNoPainel(frmGerenciar);
        }
    }
}
