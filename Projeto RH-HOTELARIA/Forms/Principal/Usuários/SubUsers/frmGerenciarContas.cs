using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca;
using Projeto_RH_HOTELARIA.Models.RH;
using Projeto_RH_HOTELARIA.Models.SYS;
using Projeto_RH_HOTELARIA.Models.SYS.LocalSYS.Enum;
using Projeto_RH_HOTELARIA.Services;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers
{
    public partial class frmGerenciarContas : Form
    {
        private SYS_UsuarioService service = new SYS_UsuarioService(new SYS_UsuarioRepository());
        private string PNome = null;
        public frmGerenciarContas()
        {
            InitializeComponent();
        }

        #region Load
        private void frmGerenciarContas_Load(object sender, EventArgs e)
        {
            UIStyle.ArredondarPanel(pnl_Top, 25);
            UIStyle.ArredondarPanel(pnl_Conteudo, 25);
            UIStyle.ArredondarPanel(pnl_Login, 15);
            UIStyle.ArredondarPanel(pnl_Foto, 45);
            UIStyle.ArredondarPanel(pnl_DocPessoal, 15);
            UIStyle.ArredondarPanel(pnl_Pessoa, 15);

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

        #region CRUD

        #region Cadastro
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_RG.Text)
                || string.IsNullOrWhiteSpace(txtBox_Login.Text)
                || string.IsNullOrWhiteSpace(txtBox_Senha.Text)
                || cBox_Cargo.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = Criptografia.HashSenha(txtBox_Senha.Text);

            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuarioExistente = service.BuscarPorLogin(txtBox_Login.Text);
            if (usuarioExistente != null)
            {
                MessageBox.Show("Já existe um usuário cadastrado com este Login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var senhaHash = result.Hash;

            var usuario = new SYS_Usuario
            {
                RG = txtBox_RG.Text,
                Login = txtBox_Login.Text.Trim(),
                SenhaHash = senhaHash,
                Role = cBox_Cargo.SelectedItem.ToString(),
                Ativo = rBtn_Ativo.Checked
            };

            try
            {
                service.Inserir(usuario);
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Buscar
        private void btn_Buscar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Editar
        private void btn_Editar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Deletar
        private void btn_Deletar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Button

        private void btn_buscarRG(object sender, EventArgs e)
        {
            using (var rg = new frmBuscarRG())
            {
                if (rg.ShowDialog() == DialogResult.OK)
                {
                    var doc = rg.Tag as RH_DocumentosPessoa;
                    if (doc != null)
                    {
                        txtBox_RG.Text = doc.RG;
                    }

                    pnl_DocPessoal.Visible = true;
                }
            }
        }

        private void Ibtn_DocPessoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_RG.Text))
            {
                MessageBox.Show("O RG está Vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var DocPessoa = new frmBuscarDocPessoa(txtBox_RG.Text))
            {
                if (DocPessoa.ShowDialog() == DialogResult.OK)
                {
                    var doc = DocPessoa.Tag as RH_DocumentosPessoa;

                    if (doc != null)
                    {
                        lbl_CTPS_Numero.Text += doc.CTPS_Numero;
                        lbl_CTPS_Serie.Text += doc.CTPS_Serie;
                        lbl_CNH_Numero.Text += doc.CNH_Numero;
                        lbl_CNH_Categoria.Text += doc.CNH_Categoria;
                        lbl_CNH_Validade.Text +=
                            doc.CNH_Validade?.ToString("dd/MM/yyyy") ?? "00/00/0000";

                        lbl_PIS.Text += doc.PIS;
                        lbl_CPF.Text += doc.CPF;
                        lbl_RG.Text += doc.RG;
                        lbl_TituloEleitor.Text += doc.TituloEleitor;
                        lbl_Nome.Text += doc.PessoaNome;
                        PNome = doc.PessoaNome;
                    }

                    Ibtn_DocPessoa.Enabled = false;
                    pnl_Pessoa.Visible = true;
                }
            }
        }

        private void Ibtn_DbPessoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_RG.Text))
            {
                MessageBox.Show("O RG está Vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var Pessoa = new frmBuscarPessoa(PNome))
            {
                if (Pessoa.ShowDialog() == DialogResult.OK)
                {
                    var pess = Pessoa.Tag as RH_Pessoa;

                    if (pess != null)
                    {
                        lbl_PNome.Text += pess.Nome;
                        lbl_PData.Text += pess.DataNascimento;
                        lbl_Genero.Text += pess.Genero;
                        lbl_EstadoC.Text += pess.EstadoCivil;
                        lbl_PNacionalidade.Text += pess.Nacionalidade;
                        lbl_PEndereco.Text += pess.EnderecoId;
                    }
                }

                Ibtn_DbPessoa.Enabled = false;
            }
        }

        #endregion

        #endregion

        #region função
        private void LimparCampos()
        {
            txtBox_RG.Clear();
            txtBox_Login.Clear();
            txtBox_Senha.Clear();
            cBox_Cargo.SelectedIndex = -1;
            rBtn_Ativo.Checked = false;
            rBtn_Inativo.Checked = false;
            pnl_DocPessoal.Visible = false;
            pnl_Pessoa.Visible = false;
        }
        #endregion

    }
}
