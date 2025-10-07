using Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca;
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
    public partial class frmUsuarioCadastrar : Form
    {
        public frmUsuarioCadastrar()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            frmRG rg = new frmRG();
            rg.ShowDialog();
        }
    }
}
