namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers
{
    partial class frmListagemUser
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_titulo2 = new System.Windows.Forms.Label();
            this.lbl_titulo1 = new System.Windows.Forms.Label();
            this.pnl_conteudo = new System.Windows.Forms.Panel();
            this.dgv_Listar = new System.Windows.Forms.DataGridView();
            this.UsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CriadoEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_fumcao = new System.Windows.Forms.Panel();
            this.btn_AtiPesquisa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.lbl_Rg = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.c_Box_Cargo = new System.Windows.Forms.ComboBox();
            this.txtBox_RG = new System.Windows.Forms.TextBox();
            this.txtBox_Login = new System.Windows.Forms.TextBox();
            this.pnl_top.SuspendLayout();
            this.pnl_conteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listar)).BeginInit();
            this.pnl_fumcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_top.Controls.Add(this.lbl_titulo2);
            this.pnl_top.Controls.Add(this.lbl_titulo1);
            this.pnl_top.Location = new System.Drawing.Point(12, 12);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(840, 94);
            this.pnl_top.TabIndex = 0;
            // 
            // lbl_titulo2
            // 
            this.lbl_titulo2.AutoSize = true;
            this.lbl_titulo2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_titulo2.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_titulo2.Location = new System.Drawing.Point(17, 43);
            this.lbl_titulo2.Name = "lbl_titulo2";
            this.lbl_titulo2.Size = new System.Drawing.Size(246, 21);
            this.lbl_titulo2.TabIndex = 1;
            this.lbl_titulo2.Text = "Listagem de Usuários cadastrados";
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_titulo1.Location = new System.Drawing.Point(5, 11);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(182, 32);
            this.lbl_titulo1.TabIndex = 0;
            this.lbl_titulo1.Text = "Listar Usuários";
            // 
            // pnl_conteudo
            // 
            this.pnl_conteudo.Controls.Add(this.dgv_Listar);
            this.pnl_conteudo.Controls.Add(this.pnl_fumcao);
            this.pnl_conteudo.Location = new System.Drawing.Point(12, 138);
            this.pnl_conteudo.Name = "pnl_conteudo";
            this.pnl_conteudo.Size = new System.Drawing.Size(840, 531);
            this.pnl_conteudo.TabIndex = 1;
            // 
            // dgv_Listar
            // 
            this.dgv_Listar.AllowUserToAddRows = false;
            this.dgv_Listar.AllowUserToDeleteRows = false;
            this.dgv_Listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioId,
            this.UsuarioLogin,
            this.UsuarioRg,
            this.Role,
            this.CriadoEm});
            this.dgv_Listar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Listar.Location = new System.Drawing.Point(0, 100);
            this.dgv_Listar.Name = "dgv_Listar";
            this.dgv_Listar.ReadOnly = true;
            this.dgv_Listar.Size = new System.Drawing.Size(840, 431);
            this.dgv_Listar.TabIndex = 1;
            this.dgv_Listar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Listar_CellClick);
            // 
            // UsuarioId
            // 
            this.UsuarioId.HeaderText = "ID";
            this.UsuarioId.Name = "UsuarioId";
            this.UsuarioId.ReadOnly = true;
            // 
            // UsuarioLogin
            // 
            this.UsuarioLogin.HeaderText = "Login";
            this.UsuarioLogin.Name = "UsuarioLogin";
            this.UsuarioLogin.ReadOnly = true;
            // 
            // UsuarioRg
            // 
            this.UsuarioRg.HeaderText = "RG";
            this.UsuarioRg.Name = "UsuarioRg";
            this.UsuarioRg.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.HeaderText = "Cargo";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // CriadoEm
            // 
            this.CriadoEm.HeaderText = "Data de Criação";
            this.CriadoEm.Name = "CriadoEm";
            this.CriadoEm.ReadOnly = true;
            // 
            // pnl_fumcao
            // 
            this.pnl_fumcao.BackColor = System.Drawing.Color.LightGray;
            this.pnl_fumcao.Controls.Add(this.btn_AtiPesquisa);
            this.pnl_fumcao.Controls.Add(this.guna2Separator1);
            this.pnl_fumcao.Controls.Add(this.lbl_Role);
            this.pnl_fumcao.Controls.Add(this.lbl_Rg);
            this.pnl_fumcao.Controls.Add(this.lbl_Login);
            this.pnl_fumcao.Controls.Add(this.c_Box_Cargo);
            this.pnl_fumcao.Controls.Add(this.txtBox_RG);
            this.pnl_fumcao.Controls.Add(this.txtBox_Login);
            this.pnl_fumcao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_fumcao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.pnl_fumcao.Location = new System.Drawing.Point(0, 0);
            this.pnl_fumcao.Name = "pnl_fumcao";
            this.pnl_fumcao.Size = new System.Drawing.Size(840, 100);
            this.pnl_fumcao.TabIndex = 0;
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
            this.btn_AtiPesquisa.Location = new System.Drawing.Point(691, 10);
            this.btn_AtiPesquisa.Name = "btn_AtiPesquisa";
            this.btn_AtiPesquisa.Size = new System.Drawing.Size(130, 35);
            this.btn_AtiPesquisa.TabIndex = 10;
            this.btn_AtiPesquisa.Text = "Desativado";
            this.btn_AtiPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtiPesquisa.Click += new System.EventHandler(this.btn_AtiPesquisa_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 55);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(834, 10);
            this.guna2Separator1.TabIndex = 6;
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Role.Location = new System.Drawing.Point(474, 6);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(44, 17);
            this.lbl_Role.TabIndex = 5;
            this.lbl_Role.Text = "Cargo";
            // 
            // lbl_Rg
            // 
            this.lbl_Rg.AutoSize = true;
            this.lbl_Rg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Rg.Location = new System.Drawing.Point(238, 6);
            this.lbl_Rg.Name = "lbl_Rg";
            this.lbl_Rg.Size = new System.Drawing.Size(25, 17);
            this.lbl_Rg.TabIndex = 4;
            this.lbl_Rg.Text = "RG";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Login.Location = new System.Drawing.Point(18, 6);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(41, 17);
            this.lbl_Login.TabIndex = 3;
            this.lbl_Login.Text = "Login";
            // 
            // c_Box_Cargo
            // 
            this.c_Box_Cargo.FormattingEnabled = true;
            this.c_Box_Cargo.Location = new System.Drawing.Point(477, 26);
            this.c_Box_Cargo.Name = "c_Box_Cargo";
            this.c_Box_Cargo.Size = new System.Drawing.Size(165, 25);
            this.c_Box_Cargo.TabIndex = 2;
            this.c_Box_Cargo.SelectedIndexChanged += new System.EventHandler(this.c_Box_Cargo_SelectedIndexChanged);
            // 
            // txtBox_RG
            // 
            this.txtBox_RG.Location = new System.Drawing.Point(246, 26);
            this.txtBox_RG.Name = "txtBox_RG";
            this.txtBox_RG.Size = new System.Drawing.Size(165, 25);
            this.txtBox_RG.TabIndex = 1;
            this.txtBox_RG.TextChanged += new System.EventHandler(this.txtBox_RG_TextChanged);
            // 
            // txtBox_Login
            // 
            this.txtBox_Login.Location = new System.Drawing.Point(21, 26);
            this.txtBox_Login.Name = "txtBox_Login";
            this.txtBox_Login.Size = new System.Drawing.Size(165, 25);
            this.txtBox_Login.TabIndex = 0;
            this.txtBox_Login.TextChanged += new System.EventHandler(this.txtBox_Login_TextChanged);
            // 
            // frmListagemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.pnl_conteudo);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmListagemUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListagemUser";
            this.Load += new System.EventHandler(this.frmListagemUser_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_conteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listar)).EndInit();
            this.pnl_fumcao.ResumeLayout(false);
            this.pnl_fumcao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_conteudo;
        private System.Windows.Forms.Panel pnl_fumcao;
        private System.Windows.Forms.Label lbl_titulo2;
        private System.Windows.Forms.Label lbl_titulo1;
        private System.Windows.Forms.ComboBox c_Box_Cargo;
        private System.Windows.Forms.TextBox txtBox_RG;
        private System.Windows.Forms.TextBox txtBox_Login;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Label lbl_Rg;
        private System.Windows.Forms.Label lbl_Login;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btn_AtiPesquisa;
        private System.Windows.Forms.DataGridView dgv_Listar;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriadoEm;
    }
}