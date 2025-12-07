namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers
{
    partial class frmListarUsuarios
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
            this.pnl_Fundo = new System.Windows.Forms.Panel();
            this.pnl_conteudo = new System.Windows.Forms.Panel();
            this.pnl_Funcao = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Dgv_Listagem = new System.Windows.Forms.DataGridView();
            this.UsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CriadoEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Fundo.SuspendLayout();
            this.pnl_conteudo.SuspendLayout();
            this.pnl_Funcao.SuspendLayout();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Fundo
            // 
            this.pnl_Fundo.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_Fundo.Controls.Add(this.pnl_conteudo);
            this.pnl_Fundo.Controls.Add(this.pnl_top);
            this.pnl_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fundo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Fundo.Name = "pnl_Fundo";
            this.pnl_Fundo.Size = new System.Drawing.Size(864, 681);
            this.pnl_Fundo.TabIndex = 0;
            // 
            // pnl_conteudo
            // 
            this.pnl_conteudo.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_conteudo.Controls.Add(this.Dgv_Listagem);
            this.pnl_conteudo.Controls.Add(this.pnl_Funcao);
            this.pnl_conteudo.Location = new System.Drawing.Point(12, 124);
            this.pnl_conteudo.Name = "pnl_conteudo";
            this.pnl_conteudo.Size = new System.Drawing.Size(840, 545);
            this.pnl_conteudo.TabIndex = 1;
            // 
            // pnl_Funcao
            // 
            this.pnl_Funcao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.pnl_Funcao.Controls.Add(this.guna2Button1);
            this.pnl_Funcao.Controls.Add(this.label4);
            this.pnl_Funcao.Controls.Add(this.textBox2);
            this.pnl_Funcao.Controls.Add(this.guna2Separator1);
            this.pnl_Funcao.Controls.Add(this.label3);
            this.pnl_Funcao.Controls.Add(this.label2);
            this.pnl_Funcao.Controls.Add(this.comboBox1);
            this.pnl_Funcao.Controls.Add(this.textBox1);
            this.pnl_Funcao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Funcao.Location = new System.Drawing.Point(0, 0);
            this.pnl_Funcao.Name = "pnl_Funcao";
            this.pnl_Funcao.Size = new System.Drawing.Size(840, 109);
            this.pnl_Funcao.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Login";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 22);
            this.textBox2.TabIndex = 5;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(3, 59);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(834, 10);
            this.guna2Separator1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "RG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cargo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(461, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 0;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Controls.Add(this.lbl_Titulo);
            this.pnl_top.Location = new System.Drawing.Point(12, 12);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(840, 85);
            this.pnl_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste todos os usuarios cadastrados";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Titulo.Location = new System.Drawing.Point(18, 10);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(182, 32);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Listar Usuarios";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Projeto_RH_HOTELARIA.Properties.Resources.icon_Fechar;
            this.guna2Button1.Location = new System.Drawing.Point(690, 13);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(134, 39);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Desativado";
            // 
            // Dgv_Listagem
            // 
            this.Dgv_Listagem.AllowUserToAddRows = false;
            this.Dgv_Listagem.AllowUserToDeleteRows = false;
            this.Dgv_Listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioId,
            this.RG,
            this.Login,
            this.Role,
            this.CriadoEm});
            this.Dgv_Listagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Listagem.Location = new System.Drawing.Point(0, 109);
            this.Dgv_Listagem.Name = "Dgv_Listagem";
            this.Dgv_Listagem.ReadOnly = true;
            this.Dgv_Listagem.Size = new System.Drawing.Size(840, 436);
            this.Dgv_Listagem.TabIndex = 1;
            // 
            // UsuarioId
            // 
            this.UsuarioId.HeaderText = "ID";
            this.UsuarioId.Name = "UsuarioId";
            this.UsuarioId.ReadOnly = true;
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
            // CriadoEm
            // 
            this.CriadoEm.HeaderText = "Data de Criação";
            this.CriadoEm.Name = "CriadoEm";
            this.CriadoEm.ReadOnly = true;
            // 
            // frmListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.pnl_Fundo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarUsuarios";
            this.Text = "frmListarUsuarios";
            this.Load += new System.EventHandler(this.frmListarUsuarios_Load);
            this.pnl_Fundo.ResumeLayout(false);
            this.pnl_conteudo.ResumeLayout(false);
            this.pnl_Funcao.ResumeLayout(false);
            this.pnl_Funcao.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fundo;
        private System.Windows.Forms.Panel pnl_conteudo;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Funcao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView Dgv_Listagem;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriadoEm;
    }
}