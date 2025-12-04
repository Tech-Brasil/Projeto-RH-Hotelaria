using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Models.SYS;
using Projeto_RH_HOTELARIA.Services;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca
{
    public partial class frmBuscarUser : Form
    {
        private readonly SYS_UsuarioService _UsuarioService;

        public frmBuscarUser()
        {
            InitializeComponent();
            _UsuarioService = new SYS_UsuarioService(new SYS_UsuarioRepository());
        }

        #region Load
        private void frmBuscarUser_Load(object sender, EventArgs e)
        {
            UIStyle.EstilizarDGV(dgv_Resultado);
        }
        #endregion

        #region Cancelar
        private void Cancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Button

        #region Procurar
        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_Login.Text) && 
                string.IsNullOrWhiteSpace(txtBox_RG.Text))
            {
                MessageBox.Show("Você precisa preencher ao menos um campo para buscar o Usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dgv_Resultado.Rows.Clear();

                var users = _UsuarioService.ListarTodos();
                var filtrados = users.Where(d =>
                    (string.IsNullOrWhiteSpace(txtBox_RG.Text) || d.RG.Contains(txtBox_RG.Text)) &&
                    (string.IsNullOrWhiteSpace(txtBox_Login.Text) || d.Login.Contains(txtBox_Login.Text))
                    ).ToList();

                foreach (var user in filtrados)
                {
                    dgv_Resultado.Rows.Add(
                        user.RG,
                        user.Login,
                        user.Role,
                        user.Ativo
                    );
                }

                if (filtrados.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tabControl_BuscUser.SelectedTab = tabPage_Resultado;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Confirmar
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (dgv_Resultado.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum usuário selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string RG = dgv_Resultado.SelectedRows[0].Cells["RG"].Value.ToString();
            string Login = dgv_Resultado.SelectedRows[0].Cells["Login"].Value.ToString();
            string Role = dgv_Resultado.SelectedRows[0].Cells["Role"].Value.ToString();

            var usuario = _UsuarioService.BuscarPorLogin(Login);

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Tag = usuario;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        #endregion

        #endregion


    }
}
