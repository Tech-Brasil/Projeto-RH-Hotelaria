namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers
{
    partial class frmPermissoes
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_CategoriaT = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pnl_Conteudo = new System.Windows.Forms.Panel();
            this.dgv_Listagem = new System.Windows.Forms.DataGridView();
            this.pnl_Funcao = new System.Windows.Forms.Panel();
            this.btn_AtiPesquisa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Selecionar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_Cargo = new System.Windows.Forms.ComboBox();
            this.txtBox_RG = new System.Windows.Forms.TextBox();
            this.UsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CriadoEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Top.SuspendLayout();
            this.pnl_Conteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listagem)).BeginInit();
            this.pnl_Funcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_Top.Controls.Add(this.lbl_CategoriaT);
            this.pnl_Top.Controls.Add(this.lbl_Titulo);
            this.pnl_Top.Location = new System.Drawing.Point(12, 12);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(840, 94);
            this.pnl_Top.TabIndex = 1;
            // 
            // lbl_CategoriaT
            // 
            this.lbl_CategoriaT.AutoSize = true;
            this.lbl_CategoriaT.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CategoriaT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoriaT.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_CategoriaT.Location = new System.Drawing.Point(17, 43);
            this.lbl_CategoriaT.Name = "lbl_CategoriaT";
            this.lbl_CategoriaT.Size = new System.Drawing.Size(324, 21);
            this.lbl_CategoriaT.TabIndex = 1;
            this.lbl_CategoriaT.Text = "Configure funções e permissões dos usuários";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Titulo.Location = new System.Drawing.Point(5, 11);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(357, 32);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Gerenciamento de Permissões";
            // 
            // pnl_Conteudo
            // 
            this.pnl_Conteudo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Conteudo.Controls.Add(this.dgv_Listagem);
            this.pnl_Conteudo.Controls.Add(this.pnl_Funcao);
            this.pnl_Conteudo.Location = new System.Drawing.Point(12, 138);
            this.pnl_Conteudo.Name = "pnl_Conteudo";
            this.pnl_Conteudo.Size = new System.Drawing.Size(840, 531);
            this.pnl_Conteudo.TabIndex = 2;
            // 
            // dgv_Listagem
            // 
            this.dgv_Listagem.AllowUserToAddRows = false;
            this.dgv_Listagem.AllowUserToDeleteRows = false;
            this.dgv_Listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioId,
            this.RG,
            this.Login,
            this.Role,
            this.Ativo,
            this.CriadoEm});
            this.dgv_Listagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Listagem.Location = new System.Drawing.Point(0, 99);
            this.dgv_Listagem.MultiSelect = false;
            this.dgv_Listagem.Name = "dgv_Listagem";
            this.dgv_Listagem.ReadOnly = true;
            this.dgv_Listagem.Size = new System.Drawing.Size(840, 432);
            this.dgv_Listagem.TabIndex = 1;
            this.dgv_Listagem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Listagem_CellClick);
            // 
            // pnl_Funcao
            // 
            this.pnl_Funcao.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Funcao.Controls.Add(this.btn_AtiPesquisa);
            this.pnl_Funcao.Controls.Add(this.btn_Selecionar);
            this.pnl_Funcao.Controls.Add(this.guna2Separator1);
            this.pnl_Funcao.Controls.Add(this.label2);
            this.pnl_Funcao.Controls.Add(this.label1);
            this.pnl_Funcao.Controls.Add(this.cBox_Cargo);
            this.pnl_Funcao.Controls.Add(this.txtBox_RG);
            this.pnl_Funcao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Funcao.Location = new System.Drawing.Point(0, 0);
            this.pnl_Funcao.Name = "pnl_Funcao";
            this.pnl_Funcao.Size = new System.Drawing.Size(840, 99);
            this.pnl_Funcao.TabIndex = 0;
            // 
            // btn_AtiPesquisa
            // 
            this.btn_AtiPesquisa.Animated = true;
            this.btn_AtiPesquisa.BackColor = System.Drawing.Color.LightGray;
            this.btn_AtiPesquisa.BorderColor = System.Drawing.Color.DimGray;
            this.btn_AtiPesquisa.BorderThickness = 1;
            this.btn_AtiPesquisa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AtiPesquisa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AtiPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AtiPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AtiPesquisa.FillColor = System.Drawing.Color.LightGray;
            this.btn_AtiPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btn_AtiPesquisa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_AtiPesquisa.Image = global::Projeto_RH_HOTELARIA.Properties.Resources.icon_Fechar;
            this.btn_AtiPesquisa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtiPesquisa.Location = new System.Drawing.Point(694, 14);
            this.btn_AtiPesquisa.Name = "btn_AtiPesquisa";
            this.btn_AtiPesquisa.Size = new System.Drawing.Size(130, 35);
            this.btn_AtiPesquisa.TabIndex = 9;
            this.btn_AtiPesquisa.Text = "Desativado";
            this.btn_AtiPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtiPesquisa.Click += new System.EventHandler(this.btn_AtiPesquisa_Click);
            // 
            // btn_Selecionar
            // 
            this.btn_Selecionar.Animated = true;
            this.btn_Selecionar.BackColor = System.Drawing.Color.LightGray;
            this.btn_Selecionar.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Selecionar.BorderThickness = 1;
            this.btn_Selecionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Selecionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Selecionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Selecionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Selecionar.Enabled = false;
            this.btn_Selecionar.FillColor = System.Drawing.Color.LightGray;
            this.btn_Selecionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Selecionar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Selecionar.Image = global::Projeto_RH_HOTELARIA.Properties.Resources.icon_selecionar;
            this.btn_Selecionar.Location = new System.Drawing.Point(21, 68);
            this.btn_Selecionar.Name = "btn_Selecionar";
            this.btn_Selecionar.Size = new System.Drawing.Size(110, 25);
            this.btn_Selecionar.TabIndex = 6;
            this.btn_Selecionar.Text = "Selecionar";
            this.btn_Selecionar.Click += new System.EventHandler(this.btn_Selecionar_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 55);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(834, 10);
            this.guna2Separator1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "RG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cargo";
            // 
            // cBox_Cargo
            // 
            this.cBox_Cargo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Cargo.FormattingEnabled = true;
            this.cBox_Cargo.Location = new System.Drawing.Point(325, 26);
            this.cBox_Cargo.Name = "cBox_Cargo";
            this.cBox_Cargo.Size = new System.Drawing.Size(165, 23);
            this.cBox_Cargo.TabIndex = 1;
            this.cBox_Cargo.SelectedIndexChanged += new System.EventHandler(this.cBox_Cargo_SelectedIndexChanged);
            // 
            // txtBox_RG
            // 
            this.txtBox_RG.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_RG.Location = new System.Drawing.Point(21, 26);
            this.txtBox_RG.Name = "txtBox_RG";
            this.txtBox_RG.Size = new System.Drawing.Size(165, 23);
            this.txtBox_RG.TabIndex = 0;
            this.txtBox_RG.TextChanged += new System.EventHandler(this.txtBox_RG_TextChanged);
            // 
            // UsuarioId
            // 
            this.UsuarioId.HeaderText = "ID";
            this.UsuarioId.Name = "UsuarioId";
            this.UsuarioId.ReadOnly = true;
            this.UsuarioId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.HeaderText = "Cargo";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Ativo
            // 
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            // 
            // CriadoEm
            // 
            this.CriadoEm.HeaderText = "Data de Criação";
            this.CriadoEm.Name = "CriadoEm";
            this.CriadoEm.ReadOnly = true;
            // 
            // frmPermissoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.pnl_Conteudo);
            this.Controls.Add(this.pnl_Top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPermissoes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPermissoes_Load);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.pnl_Conteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listagem)).EndInit();
            this.pnl_Funcao.ResumeLayout(false);
            this.pnl_Funcao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_CategoriaT;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Panel pnl_Conteudo;
        private System.Windows.Forms.Panel pnl_Funcao;
        private System.Windows.Forms.TextBox txtBox_RG;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox_Cargo;
        private Guna.UI2.WinForms.Guna2Button btn_Selecionar;
        private System.Windows.Forms.DataGridView dgv_Listagem;
        private Guna.UI2.WinForms.Guna2Button btn_AtiPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriadoEm;
    }
}