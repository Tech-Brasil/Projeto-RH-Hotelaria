namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca
{
    partial class frmBuscarPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_fundo = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Confirmar = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_SubTitulo = new System.Windows.Forms.Label();
            this.cBox_Pes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pnl_fundo.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_fundo
            // 
            this.pnl_fundo.Controls.Add(this.btn_Cancelar);
            this.pnl_fundo.Controls.Add(this.btn_Confirmar);
            this.pnl_fundo.Controls.Add(this.lbl_SubTitulo);
            this.pnl_fundo.Controls.Add(this.cBox_Pes);
            this.pnl_fundo.Controls.Add(this.pnl_Top);
            this.pnl_fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fundo.Location = new System.Drawing.Point(0, 0);
            this.pnl_fundo.Name = "pnl_fundo";
            this.pnl_fundo.Size = new System.Drawing.Size(400, 150);
            this.pnl_fundo.TabIndex = 1;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Animated = true;
            this.btn_Cancelar.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.BorderRadius = 2;
            this.btn_Cancelar.BorderThickness = 1;
            this.btn_Cancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancelar.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Location = new System.Drawing.Point(143, 113);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 25);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Animated = true;
            this.btn_Confirmar.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Confirmar.BorderRadius = 2;
            this.btn_Confirmar.BorderThickness = 1;
            this.btn_Confirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Confirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Confirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Confirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Confirmar.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Confirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Confirmar.ForeColor = System.Drawing.Color.Black;
            this.btn_Confirmar.Location = new System.Drawing.Point(277, 113);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(110, 25);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // lbl_SubTitulo
            // 
            this.lbl_SubTitulo.AutoSize = true;
            this.lbl_SubTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_SubTitulo.Location = new System.Drawing.Point(13, 46);
            this.lbl_SubTitulo.Name = "lbl_SubTitulo";
            this.lbl_SubTitulo.Size = new System.Drawing.Size(138, 20);
            this.lbl_SubTitulo.TabIndex = 2;
            this.lbl_SubTitulo.Text = "Selecione a Pessoa";
            // 
            // cBox_Pes
            // 
            this.cBox_Pes.AutoRoundedCorners = true;
            this.cBox_Pes.BackColor = System.Drawing.Color.Transparent;
            this.cBox_Pes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBox_Pes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Pes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBox_Pes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBox_Pes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.cBox_Pes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBox_Pes.ItemHeight = 30;
            this.cBox_Pes.Location = new System.Drawing.Point(17, 69);
            this.cBox_Pes.Name = "cBox_Pes";
            this.cBox_Pes.Size = new System.Drawing.Size(370, 36);
            this.cBox_Pes.TabIndex = 1;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_Top.Controls.Add(this.lbl_Titulo);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(400, 43);
            this.pnl_Top.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(3, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(76, 25);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Pessoal";
            // 
            // frmBuscarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.pnl_fundo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarPessoa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBuscarPessoa_Load);
            this.pnl_fundo.ResumeLayout(false);
            this.pnl_fundo.PerformLayout();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fundo;
        private Guna.UI2.WinForms.Guna2Button btn_Cancelar;
        private Guna.UI2.WinForms.Guna2Button btn_Confirmar;
        private System.Windows.Forms.Label lbl_SubTitulo;
        private Guna.UI2.WinForms.Guna2ComboBox cBox_Pes;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}