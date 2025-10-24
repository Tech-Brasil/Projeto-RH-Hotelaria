using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Data.Repository;
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
    public partial class frmRG : Form
    {
        
        public frmRG()
        {
            InitializeComponent();
        }

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            try
            {
                string rg = string.IsNullOrWhiteSpace(txtBox_RG.Text) ? null : txtBox_RG.Text.Trim();
                string nome = string.IsNullOrWhiteSpace(txtBox_CPF.Text) ? null : txtBox_CPF.Text.Trim();

                

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

                tab_RG.SelectedTab = page_Resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
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
