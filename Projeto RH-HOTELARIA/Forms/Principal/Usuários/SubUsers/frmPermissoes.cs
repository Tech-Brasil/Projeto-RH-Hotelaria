using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Alterar;
using Projeto_RH_HOTELARIA.Models.SYS.LocalSYS.Enum;
using Projeto_RH_HOTELARIA.Services;
using Projeto_RH_HOTELARIA.Utils;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers
{
    public partial class frmPermissoes : Form
    {
        #region Private Fields
        private bool pesquisaAtiva = false;
        private readonly SYS_UsuarioService _usuarioService = new SYS_UsuarioService(new SYS_UsuarioRepository());
        #endregion

        public frmPermissoes()
        {
            InitializeComponent();
        }


        #region Load
        private void frmPermissoes_Load(object sender, System.EventArgs e)
        {
            //UIStyle.ArredondarPanel(pnl_Top, 40);
            UIStyle.ArredondarPanelV2(pnl_Top, 0, 0, 30, 30);
            UIStyle.ArredondarPanel(pnl_Conteudo, 40);
            UIStyle.EstilizarDGV_V2(dgv_Listagem);

            cBox_Cargo.Items.Clear();
            cBox_Cargo.Items.Add("");
            cBox_Cargo.Items.Add(UserRole.Administrador);
            cBox_Cargo.Items.Add(UserRole.TI);
            cBox_Cargo.Items.Add(UserRole.Auditor);
            cBox_Cargo.Items.Add(UserRole.AnalistaRH);
            cBox_Cargo.Items.Add(UserRole.Recepcionista);
            cBox_Cargo.Items.Add(UserRole.Financeiro);
            cBox_Cargo.Items.Add(UserRole.Convidado);
        }
        #endregion

        #region Events - Buttons

        #region Ativar/Desativar
        private void btn_AtiPesquisa_Click(object sender, System.EventArgs e)
        {
            pesquisaAtiva = !pesquisaAtiva;

            if (pesquisaAtiva)
            {
                btn_AtiPesquisa.Text = "Ativado";
                btn_AtiPesquisa.Image = Properties.Resources.icon_ok1;

                AtualizarListagem();
            }
            else
            {
                btn_AtiPesquisa.Text = "Desativado";
                btn_AtiPesquisa.Image = Properties.Resources.icon_Fechar;
                btn_Selecionar.Enabled = false; 

                txtBox_RG.Clear();
                cBox_Cargo.SelectedIndex = -1;

                dgv_Listagem.DataSource = null;
                dgv_Listagem.Rows.Clear();
            }
        }

        private void AtualizarListagem()
        {
            if (!pesquisaAtiva)
                return;

            var usuarios = _usuarioService.ListarTodos();

            // Filtro RG
            if (!string.IsNullOrWhiteSpace(txtBox_RG.Text))
                usuarios = usuarios.Where(u => u.RG.Contains(txtBox_RG.Text)).ToList();

            // Filtro Cargo/Role
            if (cBox_Cargo.SelectedItem != null && cBox_Cargo.SelectedItem.ToString() != "")
                usuarios = usuarios.Where(u => u.Role == cBox_Cargo.SelectedItem.ToString()).ToList();

            // Popular no grid
            dgv_Listagem.Rows.Clear();

            foreach (var u in usuarios)
            {
                dgv_Listagem.Rows.Add(
                    u.UsuarioId,
                    u.RG,
                    u.Login,
                    u.Role,
                    u.Ativo ? "Ativo" : "Inativo",
                    u.CriadoEm.ToString("dd/MM/yyyy HH:mm")
                );
            }
        }
        #endregion

        #region Selecionar
        private void btn_Selecionar_Click(object sender, System.EventArgs e)
        {
            if (!pesquisaAtiva)
            {
                MessageBox.Show("Ative a pesquisa antes de selecionar um usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgv_Listagem.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum usuário selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loginSelecionado = dgv_Listagem.SelectedRows[0].Cells["Login"].Value.ToString();
            MessageBox.Show($"Usuário '{loginSelecionado}' selecionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (var frmPermissoesDetalhes = new frmAlterarUser(loginSelecionado))
            {
                if(frmPermissoesDetalhes.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Permissões atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarListagem();
                }
            }

        }
        #endregion

        #endregion

        #region Events - Filtros
        private void txtBox_RG_TextChanged(object sender, System.EventArgs e)
        {
            if (!pesquisaAtiva)
                return;

            AtualizarListagem();
        }

        private void cBox_Cargo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!pesquisaAtiva)
                return;

            AtualizarListagem();    
        }
        #endregion

        #region Events - Outros

        #region DataGridView
        private void dgv_Listagem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!pesquisaAtiva)
            {
                btn_Selecionar.Enabled = false;
                return;
            }


            btn_Selecionar.Enabled = true;
        }
        #endregion

        #endregion

    }
}
