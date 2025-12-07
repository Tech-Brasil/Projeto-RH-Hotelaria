using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Models.RH;
using Projeto_RH_HOTELARIA.Services;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca
{
    public partial class frmBuscarRG : Form
    {
        private readonly RH_DocumentosPessoaService _docService;

        public frmBuscarRG()
        {
            InitializeComponent();
            _docService = new RH_DocumentosPessoaService(new RH_DocumentosPessoaRepository());
        }

        private void frmBuscarRG_Load(object sender, EventArgs e)
        {
            UIStyle.EstilizarDGV(dgv_Resultado);
        }

        #region Cancelar
        private void Cancelar(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Procurar
        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_Nome.Text) &&
                string.IsNullOrWhiteSpace(txtBox_CPF.Text) &&
                string.IsNullOrWhiteSpace(txtBox_RG.Text) &&
                string.IsNullOrWhiteSpace(txtBox_PIS.Text))
            {
                MessageBox.Show("Você precisa preencher ao menos um campo para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dgv_Resultado.Rows.Clear();

                var documentos = _docService.ListarTodos();
                var filtrados = documentos.Where(d =>
                    (string.IsNullOrWhiteSpace(txtBox_Nome.Text) ||
                        d.PessoaNome.Contains(txtBox_Nome.Text)) &&
                    (string.IsNullOrWhiteSpace(txtBox_CPF.Text) ||
                        d.CPF.Contains(txtBox_CPF.Text)) &&
                    (string.IsNullOrWhiteSpace(txtBox_RG.Text) ||
                        d.RG.Contains(txtBox_RG.Text)) &&
                    (string.IsNullOrWhiteSpace(txtBox_PIS.Text) ||
                        (d.PIS != null && d.PIS.Contains(txtBox_PIS.Text)))
                    ).ToList();

                foreach (var doc in filtrados)
                {
                    dgv_Resultado.Rows.Add(
                        doc.RG,
                        doc.PessoaNome,
                        doc.CPF,
                        doc.TituloEleitor,
                        doc.PIS,
                        doc.CNH_Numero
                    );
                }

                if (filtrados.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tabControl_BuscRG.SelectedTab = tabPage_Resultado;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar documentos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Confirmar
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (dgv_Resultado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para confirmar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            string RG = dgv_Resultado.SelectedRows[0].Cells["RG"].Value.ToString();

            var documento = new RH_DocumentosPessoa
            {
                RG = RG
            };

            this.Tag = documento;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        #endregion

    }
}
