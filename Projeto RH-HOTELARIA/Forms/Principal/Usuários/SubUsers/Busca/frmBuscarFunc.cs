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
        public frmBuscarFunc()
        {
            InitializeComponent();
        }


        private void btn_can1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            try
            {




                dgv_Resultado.Rows.Clear();
                //foreach (var func in resultado)
                //{
                //    dgv_Resultado.Rows.Add(
                //        func.RG,
                //        func.Nome,
                //        func.DataNascimento.ToShortDateString(),
                //        func.Cargo,
                //        func.Departamento,
                //        func.DataAdmissao.ToShortDateString(),
                //        func.DataDemissao?.ToShortDateString() ?? "Ativo",
                //        func.Salario.ToString("C2")
                //    );
                //}

                tabContol_Funcionario.SelectedTab = page_resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (dgv_Resultado.SelectedRows.Count > 0)
            {
                string rg = dgv_Resultado.SelectedRows[0].Cells["RG"].Value.ToString();
                string nome = dgv_Resultado.SelectedRows[0].Cells["Nome"].Value.ToString();

                this.Tag = new { RG = rg, Nome = nome };
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
