using Projeto_RH_HOTELARIA.Data.Repository;
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

namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers
{
    public partial class frmListarUsuario : Form
    {
        private readonly SYS_UsuarioService _UsuarioService;
        public frmListarUsuario()
        {
            InitializeComponent();
            _UsuarioService = new SYS_UsuarioService(new SYS_UsuarioRepository());
        }
        private void CarregarUsuarios()
        {
            guna2DataGridViewUsuario.DataSource = _UsuarioService.ListarTodos().ToList();

        }
        private void FiltrarUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                CarregarUsuarios();
                return;
            }

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuario();
        }

        private void frmListarUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }
    }
}
