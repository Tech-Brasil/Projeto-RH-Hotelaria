using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca;
using Projeto_RH_HOTELARIA.Models.RH;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers
{
    public partial class frmGerenciarContas : Form
    {
        SYS_UsuarioRepository usuario;

        public frmGerenciarContas()
        {
            InitializeComponent();
        }

        private void btn_Fbuscar_Click(object sender, EventArgs e)
        {
            using (var func = new frmBuscarFunc())
            {
                if (func.ShowDialog() == DialogResult.OK)
                {
                    if(func.Tag is RH_Funcionario funcionario)
                    {

                        txtBox_Fnome.Text = funcionario.PessoaNome;
                        txtBox_Fcargo.Text = funcionario.Cargo;
                        txtBox_Fdepartamento.Text = funcionario.Departamento;
                        dateTime_FdataAdmissao.Text = funcionario.DataAdmissao.ToShortDateString();
                        dateTime_FDemi.Text = funcionario.DataDemissao?.ToShortDateString() ?? "";

                        if (funcionario.Foto != null && funcionario.Foto.Length > 0)
                            pic_FFoto.Image = ImageUtil.BytesToImage(funcionario.Foto);
                        else
                            pic_FFoto.Image = Properties.Resources.icon_photo;

                    }
                }
            }
        }


    }
}
