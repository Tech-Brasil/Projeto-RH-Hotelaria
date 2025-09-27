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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        #region menus
        private void AbrirForm(Form frm)
        {
            pnl_Conteudo.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnl_Conteudo.Controls.Add(frm);
            frm.Show();
        }
        #endregion

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUsuarioCadastrar());
        }
    }
}
