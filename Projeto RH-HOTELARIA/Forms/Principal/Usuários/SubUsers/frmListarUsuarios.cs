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
    public partial class frmListarUsuarios : Form
    {
        public frmListarUsuarios()
        {
            InitializeComponent();
        }


        #region Load
        private void frmListarUsuarios_Load(object sender, EventArgs e)
        {
            UIStyle.ArredondarPanel(pnl_top, 40);
            UIStyle.ArredondarPanel(pnl_conteudo, 40);
        }

        #endregion
    }
}
