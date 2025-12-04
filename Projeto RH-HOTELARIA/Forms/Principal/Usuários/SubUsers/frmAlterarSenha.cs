using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca;
using Projeto_RH_HOTELARIA.Models.SYS;
using Projeto_RH_HOTELARIA.Models.SYS.LocalSYS.Enum;
using Projeto_RH_HOTELARIA.Services;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers
{
    public partial class frmAlterarSenha : Form
    {
        private readonly SYS_UsuarioService _UsuarioService = new SYS_UsuarioService(new SYS_UsuarioRepository());
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        #region Load
        private void frmAlterarSenha_Load(object sender, EventArgs e)
        {
            UIStyle.ArredondarPanel(pnl_Top, 25);
            UIStyle.ArredondarPanel(pnl_Conteudo, 25);
            UIStyle.ArredondarPanel(pnl_LoginUser, 20);
            UIStyle.ArredondarPanel(pnl_Senha, 20);

            cBox_Cargo.Items.Clear();
            cBox_Cargo.Items.Add(UserRole.Administrador);
            cBox_Cargo.Items.Add(UserRole.TI);
            cBox_Cargo.Items.Add(UserRole.Auditor);
            cBox_Cargo.Items.Add(UserRole.AnalistaRH);
            cBox_Cargo.Items.Add(UserRole.Recepcionista);
            cBox_Cargo.Items.Add(UserRole.Financeiro);
            cBox_Cargo.Items.Add(UserRole.Convidado);
        }
        #endregion

        #region Functions

        #region Buscar
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            pnl_LoginUser.Visible = true;
            using (var user = new frmBuscarUser())
            {
                if (user.ShowDialog() == DialogResult.OK)
                {
                    var result = user.Tag as SYS_Usuario;

                    if (result != null)
                    {
                        txtBox_RG.Text = result.RG;
                        txtBox_Login.Text = result.Login;
                        txtBox_Senha.Text = result.SenhaHash;
                        cBox_Cargo.SelectedItem = Enum.Parse(typeof(UserRole), result.Role);
                    }
                }
            }  
            
            pnl_Senha.Visible = true;

            txtBox_SenhaAtual.Enabled = true;
            txtBox_NVSenha.Enabled = true;
            txtBox_ConSenha.Enabled = true;
        }

        #endregion

        #region Confirmar
        private void btn_conf_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBox_SenhaAtual.Text) ||
               string.IsNullOrWhiteSpace(txtBox_NVSenha.Text) ||
               string.IsNullOrWhiteSpace(txtBox_ConSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos." , "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!Validacoes.SenhaValida(txtBox_NVSenha.Text) && Validacoes.SenhaValida(txtBox_ConSenha.Text))
            {
                MessageBox.Show("A senha informada não é válida! Ela deve conter ao menos 8 caracteres, incluindo letras maiúsculas, minúsculas, números e caracteres especiais.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox_NVSenha.Focus();
                return;
            }

            if(txtBox_NVSenha.Text != txtBox_ConSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, verifique e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                var usuario = _UsuarioService.BuscarPorLogin(txtBox_Login.Text);
                if(usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool senhaAtualValida = Criptografia.Verificar(txtBox_SenhaAtual.Text, usuario.SenhaHash);
                if (!senhaAtualValida)
                {
                    MessageBox.Show("A senha atual está incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBox_SenhaAtual.Focus();
                    return;
                }

                var hashResult = Criptografia.HashSenha(txtBox_NVSenha.Text);
                if(!hashResult.Success)
                {
                    MessageBox.Show($"Erro ao gerar hash da nova senha: {hashResult.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                usuario.SenhaHash = hashResult.Hash;
                _UsuarioService.Alterar(usuario);

                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpar();

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao alterar a senha: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region limpar
        private void Limpar()
        {
            txtBox_RG.Clear();
            txtBox_Login.Clear();
            txtBox_Senha.Clear();
            txtBox_SenhaAtual.Clear();
            txtBox_NVSenha.Clear();
            txtBox_ConSenha.Clear();
            cBox_Cargo.SelectedIndex = -1;
            pnl_LoginUser.Visible = false;
            pnl_Senha.Visible = false;
        }
        #endregion

        #endregion

    }
}
