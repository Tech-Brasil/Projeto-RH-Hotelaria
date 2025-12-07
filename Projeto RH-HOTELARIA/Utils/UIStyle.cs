using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA.Utils
{
    public static class UIStyle
    {

        public static void AplicarTitulo(Label lbl, string texto)
        {
            lbl.Text = texto;
            lbl.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold);
            lbl.ForeColor = Color.White;
        }

        public static void AplicarCategoria(Label lbl, string texto)
        {
            lbl.Text = texto;
            lbl.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            lbl.ForeColor = Color.DimGray;
        }

        #region Panel
        public static void ArredondarPanel(Panel panel, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(panel.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(panel.Width - raio, panel.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, panel.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);
        }

        #region Panel V2
        public static void ArredondarPanelV2(
            Panel panel,
            int topLeft,
            int topRight,
            int bottomRight,
            int bottomLeft)
        {
            int w = panel.Width;
            int h = panel.Height;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            if (topLeft > 0)
                path.AddArc(0, 0, topLeft, topLeft, 180, 90);
            else
                path.AddLine(0, 0, 0, 0);

            if (topRight > 0)
                path.AddArc(w - topRight, 0, topRight, topRight, 270, 90);
            else
                path.AddLine(w, 0, w, 0);

            if (bottomRight > 0)
                path.AddArc(w - bottomRight, h - bottomRight, bottomRight, bottomRight, 0, 90);
            else
                path.AddLine(w, h, w, h);

            if (bottomLeft > 0)
                path.AddArc(0, h - bottomLeft, bottomLeft, bottomLeft, 90, 90);
            else
                path.AddLine(0, h, 0, h);

            path.CloseFigure();

            panel.Region = new Region(path);

            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            };
        }

        #endregion

        #endregion

        #region DataGridView
        public static void EstilizarDGV(DataGridView dgv)
        {
            // Configuração geral
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 250);
            dgv.BackgroundColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 150, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.Padding = new Padding(4, 4, 4, 4);

            // Cabeçalho
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 35;

            // Linhas
            dgv.RowTemplate.Height = 35;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; <-- Defeito: pode cortar conteúdo importante

            // Bordas suaves
            dgv.GridColor = Color.FromArgb(230, 230, 230);
        }
        #endregion

        #region DataGridView v0.2
        public static void EstilizarDGV_V2(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.MultiSelect = false;

            dgv.DoubleBuffered(true);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 248, 250);
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 228, 236);
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 8.5f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv.ColumnHeadersHeight = 32;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 4, 8, 4);

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 48);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.Padding = new Padding(8, 3, 8, 3);

            dgv.RowTemplate.Height = 34;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(220, 220, 220);

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
        }
        #endregion

    }

    public static class ControlExtensions
    {
        public static void DoubleBuffered(this Control control, bool enable)
        {
            var prop = control.GetType().GetProperty(
                "DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic);

            prop?.SetValue(control, enable, null);
        }
    }
}
