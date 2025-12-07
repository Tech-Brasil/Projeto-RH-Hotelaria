using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Models.SYS;
using Projeto_RH_HOTELARIA.Models.SYS.LocalSYS.Enum;
using Projeto_RH_HOTELARIA.Services;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Alterar
{
    public partial class frmAlterarUser : Form
    {
        #region Private Fields
        private string login = null;
        private string password = null;
        private readonly SYS_UsuarioService _usuarioService = new SYS_UsuarioService(new SYS_UsuarioRepository());
        #endregion

        public frmAlterarUser(string Login)
        {
            InitializeComponent();
            login = Login;
        }


        #region Load    
        private void frmAlterarUser_Load(object sender, EventArgs e)
        {
            UIStyle.ArredondarPanelV2(pnl_Conteudo, 20, 20, 15, 15);

            var usuario = _usuarioService.BuscarPorLogin(login);

            txtBox_ID.Text = usuario.UsuarioId.ToString();
            txtBox_Login.Text = usuario.Login;
            txtBox_RG.Text = usuario.RG;
            password = usuario.SenhaHash;

            cBox_Cargo.SelectedItem = (UserRole)Enum.Parse(typeof(UserRole), usuario.Role);
            if (usuario.Ativo)
            {
                chBox_Ativo.Checked = true;
            }
            else
            {
                chBox_Ativo.Checked = true;
            }

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

        #region Events

        #region Confirmar
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_Login.Text) &&
                string.IsNullOrWhiteSpace(txtBox_RG.Text))
            {
                MessageBox.Show("Você precisa preencher ao menos um campo para buscar o Usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(cBox_Cargo.SelectedItem == null)
            {
                MessageBox.Show("Você precisa selecionar um cargo para o Usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = new SYS_Usuario
            {
                UsuarioId = int.Parse(txtBox_ID.Text),
                Login = txtBox_Login.Text,
                RG = txtBox_RG.Text,
                SenhaHash = password,
                Role = cBox_Cargo.SelectedItem.ToString(),
                Ativo = chBox_Ativo.Checked
            };

            try
            {
                _usuarioService.Alterar(usuario);
                MessageBox.Show("Usuário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
        #endregion

        #region Fechar Form
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion


    }
}
