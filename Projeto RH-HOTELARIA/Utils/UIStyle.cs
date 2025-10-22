using System.Drawing;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Utils
{
    public static class UIStyle
    {
        public static void AplicarHover(Guna.UI2.WinForms.Guna2Button botao)
        {
            botao.HoverState.FillColor = Color.FromArgb(215, 215, 215);
            botao.HoverState.ForeColor = Color.FromArgb(0, 90, 180);
        }

        public static void AplicarPadrao(Guna.UI2.WinForms.Guna2Button botao)
        {
            botao.FillColor = Color.FromArgb(232, 232, 232);
            botao.ForeColor = Color.Gray;
            botao.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
            botao.TextAlign = HorizontalAlignment.Left;
            botao.Animated = true;
        }

        public static void ConfigurarBotao(Guna.UI2.WinForms.Guna2Button botao)
        {
            AplicarPadrao(botao);
            AplicarHover(botao);
        }

        public static void AplicarTitulo(Label lbl, string texto)
        {
            lbl.Text = texto;
            lbl.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold);
            lbl.ForeColor = Color.Gray;
        }

        public static void AplicarCategoria(Label lbl, string texto)
        {
            lbl.Text = texto;
            lbl.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            lbl.ForeColor = Color.DimGray;
        }
    }
}
