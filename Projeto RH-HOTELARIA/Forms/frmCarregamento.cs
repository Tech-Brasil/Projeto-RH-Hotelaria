using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_RH_HOTELARIA.Data.Repository;

namespace Projeto_RH_HOTELARIA.Forms
{
    public partial class frmCarregamento : Form
    {
        SYS_UsuarioRepository teste = new SYS_UsuarioRepository();

        public frmCarregamento()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            timer1.Tick += TimeTick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
       

        private void TimeTick(object sender, EventArgs e)
        {
            if (progrBar_Carregamento.Value < 100)
            {
                progrBar_Carregamento.Value += 1;

                switch (progrBar_Carregamento.Value)
                {
                    case 2:
                        lb_Logo.Left = 80;
                        progrBar_Carregamento.ProgressColor = Color.Red;
                        progrBar_Carregamento.ProgressColor2 = Color.Red;
                        lb_Logo.Text = "Conectando ao banco...";
                        break;
                    case 25:
                        lb_Logo.Left = 40;
                        picBox_F2.Visible = true;
                        progrBar_Carregamento.ProgressColor = Color.Orange;
                        progrBar_Carregamento.ProgressColor2 = Color.Orange;
                        lb_Logo.Text = "Carregando módulos do sistema...";
                        break;
                    case 50:
                        lb_Logo.Left = 80;
                        picBox_F3.Visible = true;
                        progrBar_Carregamento.ProgressColor = Color.Yellow;
                        progrBar_Carregamento.ProgressColor2 = Color.Yellow;
                        lb_Logo.Text = "Preparando interface...";
                        break;
                    case 75:
                        lb_Logo.Left = 110;
                        picBox_F4.Visible = true;
                        progrBar_Carregamento.ProgressColor = Color.Green;
                        progrBar_Carregamento.ProgressColor2 = Color.Green;
                        lb_Logo.Text = "RH HOTELARIA";
                        break;
                }
            }
            else
            {
                timer1.Stop();
                Login.FrmLogin login = new Login.FrmLogin();
                login.Show();
                Hide();
            }
        }

        
    }
}
