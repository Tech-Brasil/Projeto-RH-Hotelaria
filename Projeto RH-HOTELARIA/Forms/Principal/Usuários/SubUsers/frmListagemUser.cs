using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Models.SYS.LocalSYS.Enum;
using Projeto_RH_HOTELARIA.Services;
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
    public partial class frmListagemUser : Form
    {
        #region private field
        private bool pesquisaAtiva = false;
        private readonly SYS_UsuarioService _usuarioService = new SYS_UsuarioService(new SYS_UsuarioRepository());
        public frmListagemUser()
        {
            InitializeComponent();
        }
        #region load
        private void frmListagemUser_Load(object sender, EventArgs e)
        {
            UIStyle.ArredondarPanelV2(pnl_top, 0, 0, 30, 30);
            UIStyle.ArredondarPanel(pnl_conteudo, 40);
            UIStyle.EstilizarDGV_V2(dgv_Listar);

            c_Box_Cargo.Items.Clear();
            c_Box_Cargo.Items.Add("");
            c_Box_Cargo.Items.Add(UserRole.Administrador);
            c_Box_Cargo.Items.Add(UserRole.TI);
            c_Box_Cargo.Items.Add(UserRole.Auditor);
            c_Box_Cargo.Items.Add(UserRole.GerenteRH);
            c_Box_Cargo.Items.Add(UserRole.AnalistaRH);
            c_Box_Cargo.Items.Add(UserRole.AtendenteRH);
            c_Box_Cargo.Items.Add(UserRole.Financeiro);
            c_Box_Cargo.Items.Add(UserRole.GerenteGeral);
            c_Box_Cargo.Items.Add(UserRole.Supervisor);
            c_Box_Cargo.Items.Add(UserRole.Recepcionista);
            c_Box_Cargo.Items.Add(UserRole.Convidado);

        }


        #endregion

        #region Events - Buttons

        #region Ativar/Desativar
        private void btn_AtiPesquisa_Click(object sender, EventArgs e)
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
                btn_AtiPesquisa.Enabled = false;

                txtBox_Login.Clear();
                txtBox_RG.Clear();
                c_Box_Cargo.SelectedIndex = -1;

                dgv_Listar.DataSource = false;
                dgv_Listar.Rows.Clear();
            }


        }
        private void AtualizarListagem()
        {
            if (!pesquisaAtiva)
            {
                return;
            }
            var usuario = _usuarioService.ListarTodos();
            if (!string.IsNullOrWhiteSpace(txtBox_RG.Text))
            {
                usuario = usuario.Where(u => u.RG.Contains(txtBox_RG.Text)).ToList();
            }
            if (!string.IsNullOrWhiteSpace(txtBox_Login.Text)) {
                usuario = usuario.Where(u => u.Login.Contains(txtBox_Login.Text)).ToList();
            }
            if (c_Box_Cargo.SelectedItem != null && c_Box_Cargo.SelectedItem.ToString() != "")
            {
                usuario = usuario.Where(u => u.Role == c_Box_Cargo.SelectedItem.ToString()).ToList();
            }
            dgv_Listar.Rows.Clear();
            foreach(var u in usuario)
            {
                dgv_Listar.Rows.Add(
                    u.UsuarioId,
                    u.RG,
                    u.Login,
                    u.Role,
                    u.CriadoEm.ToString("dd/MM/yyyy HH:mm")
                    );

            }

        }
        #endregion



        #endregion

        #region Events - Filtro
        private void txtBox_Login_TextChanged(object sender, EventArgs e)
        {
            if (!pesquisaAtiva)
            {
                return;
            }
            AtualizarListagem();
        }
        private void txtBox_RG_TextChanged(object sender, EventArgs e)
        {
            if (!pesquisaAtiva)
            {
                return;
            }
            AtualizarListagem();
        }
        private void c_Box_Cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pesquisaAtiva)
            {
                return;
            }
            AtualizarListagem();
        }

        #endregion

        #region DataGridView
        private void dgv_Listar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!pesquisaAtiva)
            {
                btn_AtiPesquisa.Enabled = false;
                return;
            }
            btn_AtiPesquisa.Enabled = false;
        }


        #endregion

        #endregion

        
    }
}
