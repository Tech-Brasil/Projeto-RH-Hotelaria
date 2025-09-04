using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Forms
{
    public partial class frmCarregamento : Form
    {
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
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

            }
            else
            {
                timer1.Stop();
                Login.FrmLogin login = new Login.FrmLogin();
                login.Show();
                this.Hide();
            }
        }

        
    }
}
