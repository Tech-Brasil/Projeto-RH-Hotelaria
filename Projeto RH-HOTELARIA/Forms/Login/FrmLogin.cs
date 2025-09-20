using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Forms.Principal;
using Projeto_RH_HOTELARIA.Services;
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
        UsuarioService user = new UsuarioService(new SYS_UsuarioRepository());

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btn_Logar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBox_User.Text) || string.IsNullOrWhiteSpace(txtBox_Senha.Text))
                {
                    txtBox_User.Focus();
                    MessageBox.Show("Por favor, preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                    frmMain mainForm = new frmMain();
                    mainForm.Show();
                    this.Close();

                //var usuario = user.Autenticar(txtBox_User.Text.Trim(), txtBox_Senha.Text);
                //if (usuario != null)
                //{
                //    MessageBox.Show($"Bem-vindo {usuario.Login}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    frmMain mainForm = new frmMain(usuario);
                //    mainForm.Show();
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("Login ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar logar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
