using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void TxtBox_Usuario_Leave(object sender, EventArgs e)
        {
            if (TxtBox_Usuario.Text == "")
            {
                TxtBox_Usuario.Text = "USUARIO";
                TxtBox_Usuario.ForeColor = Color.LightGray;
            }
        }
        private void TxtBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtBox_Usuario.Text == "USUARIO")
            {
                TxtBox_Usuario.Text = "";
                TxtBox_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void TxtBox_Senha_Enter(object sender, EventArgs e)
        {
            if (TxtBox_Senha.Text == "SENHA")
            {
                TxtBox_Senha.Text = "";
                TxtBox_Senha.ForeColor = Color.LightGray;
                TxtBox_Senha.UseSystemPasswordChar = true;
            }
        }

        private void TxtBox_Senha_Leave(object sender, EventArgs e)
        {
            if (TxtBox_Senha.Text == "")
            {
                TxtBox_Senha.Text = "SENHA";
                TxtBox_Senha.ForeColor = Color.LightGray;
                TxtBox_Senha.UseSystemPasswordChar = false;
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
