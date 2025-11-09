using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Models.RH;
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

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca
{
    public partial class frmBuscarFunc : Form
    {
        private readonly RH_FuncionarioService _funcService;

        public frmBuscarFunc()
        {
            InitializeComponent();
            _funcService = new RH_FuncionarioService(new RH_FuncionarioRepository());
        }
        private void frmBuscarFunc_Load(object sender, EventArgs e)
        {

            dgv_Resultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Resultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Resultado.MultiSelect = false;
            dgv_Resultado.ReadOnly = true;

            dgv_Resultado.AutoGenerateColumns = false;
            dgv_Resultado.Columns.Clear();

            dgv_Resultado.Columns.Add("FuncionarioId", "ID");
            dgv_Resultado.Columns["FuncionarioId"].Visible = false;

            dgv_Resultado.Columns.Add("PessoaNome", "Nome");
            dgv_Resultado.Columns.Add("Cargo", "Cargo");
            dgv_Resultado.Columns.Add("Departamento", "Departamento");
            dgv_Resultado.Columns.Add("DataAdmissao", "Data Admissão");
            dgv_Resultado.Columns.Add("DataDemissao", "Data Demissão");
            dgv_Resultado.Columns.Add("Salario", "Salário");

            DataGridViewCheckBoxColumn colAtivo = new DataGridViewCheckBoxColumn
            {
                Name = "Ativo",
                HeaderText = "Ativo",
                TrueValue = true,
                FalseValue = false
            };
            dgv_Resultado.Columns.Add(colAtivo);
        }

        private void btn_can1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = _funcService.ListarTodos();

                dgv_Resultado.Rows.Clear();
                foreach (var func in resultado)
                {
                    dgv_Resultado.Rows.Add(
                    func.FuncionarioId,
                    func.PessoaNome,
                    func.Cargo,
                    func.Departamento,
                    func.DataAdmissao.ToShortDateString(),
                    func.DataDemissao?.ToShortDateString() ?? "Ativo",
                    func.Salario.ToString("C2"),
                    func.Ativo
                    );
                }

                tabContol_Funcionario.SelectedTab = page_resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            if (dgv_Resultado.SelectedRows.Count > 0)
            {
                string pessoaNome = dgv_Resultado.SelectedRows[0].Cells["PessoaNome"].Value.ToString();
                string cargo = dgv_Resultado.SelectedRows[0].Cells["Cargo"].Value.ToString();
                string departamento = dgv_Resultado.SelectedRows[0].Cells["Departamento"].Value.ToString();
                string dataAdmissao = dgv_Resultado.SelectedRows[0].Cells["DataAdmissao"].Value.ToString();
                string dataDemissao = dgv_Resultado.SelectedRows[0].Cells["DataDemissao"].Value.ToString();
                string salario = dgv_Resultado.SelectedRows[0].Cells["Salario"].Value.ToString();

                var funcionario = new RH_Funcionario
                {
                    PessoaNome = pessoaNome,
                    Cargo = cargo,
                    Departamento = departamento,
                    DataAdmissao = DateTime.Parse(dataAdmissao),
                    DataDemissao = dataDemissao == "Ativo" ? (DateTime?)null : DateTime.Parse(dataDemissao),
                    Salario = decimal.Parse(salario, System.Globalization.NumberStyles.Currency)
                };

                this.Tag = funcionario;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para confirmar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
