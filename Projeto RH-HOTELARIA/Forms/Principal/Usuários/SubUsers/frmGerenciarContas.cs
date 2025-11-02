using Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers
{
    public partial class frmGerenciarContas : Form
    {
        public frmGerenciarContas()
        {
            InitializeComponent();
        }

        private void rdb_Ativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Fbuscar_Click(object sender, EventArgs e)
        {
            frmBuscarFunc func = new frmBuscarFunc();
            func.ShowDialog();
        }
    }
}
