namespace Projeto_RH_HOTELARIA.Forms.Principal.Funcionario.SubFuncionario
{
    partial class frmGerenciarFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarFunc));
            this.pnl_Fundo = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.SeparatorV_01 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.SeparatorV_02 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.SeparatorH_01 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_CategoriaT = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Buscar = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Conteudo = new System.Windows.Forms.Panel();
            this.pnl_Func = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_FuncC = new System.Windows.Forms.Label();
            this.txtBox_Nome = new System.Windows.Forms.TextBox();
            this.cBox_CargoF = new System.Windows.Forms.ComboBox();
            this.cBox_Departamento = new System.Windows.Forms.ComboBox();
            this.dTime_Admissao = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_SalarioFunc = new System.Windows.Forms.Label();
            this.lbl_DepartamentoFunc = new System.Windows.Forms.Label();
            this.lbl_DataFunc = new System.Windows.Forms.Label();
            this.lbl_CargoFunc = new System.Windows.Forms.Label();
            this.lbl_NomeFunc = new System.Windows.Forms.Label();
            this.pnl_Fundo.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            this.pnl_Conteudo.SuspendLayout();
            this.pnl_Func.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Fundo
            // 
            this.pnl_Fundo.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_Fundo.Controls.Add(this.pnl_Conteudo);
            this.pnl_Fundo.Controls.Add(this.pnl_Top);
            this.pnl_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fundo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Fundo.Name = "pnl_Fundo";
            this.pnl_Fundo.Size = new System.Drawing.Size(864, 681);
            this.pnl_Fundo.TabIndex = 3;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_Top.Controls.Add(this.SeparatorV_01);
            this.pnl_Top.Controls.Add(this.SeparatorV_02);
            this.pnl_Top.Controls.Add(this.SeparatorH_01);
            this.pnl_Top.Controls.Add(this.lbl_CategoriaT);
            this.pnl_Top.Controls.Add(this.lbl_Titulo);
            this.pnl_Top.Controls.Add(this.btn_Buscar);
            this.pnl_Top.Location = new System.Drawing.Point(12, 12);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(840, 130);
            this.pnl_Top.TabIndex = 1;
            // 
            // SeparatorV_01
            // 
            this.SeparatorV_01.Location = new System.Drawing.Point(263, 92);
            this.SeparatorV_01.Name = "SeparatorV_01";
            this.SeparatorV_01.Size = new System.Drawing.Size(10, 35);
            this.SeparatorV_01.TabIndex = 8;
            // 
            // SeparatorV_02
            // 
            this.SeparatorV_02.Location = new System.Drawing.Point(134, 92);
            this.SeparatorV_02.Name = "SeparatorV_02";
            this.SeparatorV_02.Size = new System.Drawing.Size(10, 35);
            this.SeparatorV_02.TabIndex = 7;
            // 
            // SeparatorH_01
            // 
            this.SeparatorH_01.Location = new System.Drawing.Point(3, 78);
            this.SeparatorH_01.Name = "SeparatorH_01";
            this.SeparatorH_01.Size = new System.Drawing.Size(834, 10);
            this.SeparatorH_01.TabIndex = 6;
            // 
            // lbl_CategoriaT
            // 
            this.lbl_CategoriaT.AutoSize = true;
            this.lbl_CategoriaT.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CategoriaT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoriaT.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_CategoriaT.Location = new System.Drawing.Point(17, 43);
            this.lbl_CategoriaT.Name = "lbl_CategoriaT";
            this.lbl_CategoriaT.Size = new System.Drawing.Size(419, 21);
            this.lbl_CategoriaT.TabIndex = 1;
            this.lbl_CategoriaT.Text = "Configure permissôes e dados dos funcionário cadastrados";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Titulo.Location = new System.Drawing.Point(5, 11);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(366, 32);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Gerenciamento de Funcionário\r\n";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Animated = true;
            this.btn_Buscar.AutoRoundedCorners = true;
            this.btn_Buscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Buscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Buscar.FillColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.35F, System.Drawing.FontStyle.Bold);
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Image = global::Projeto_RH_HOTELARIA.Properties.Resources.icon_BuscarUser;
            this.btn_Buscar.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Buscar.Location = new System.Drawing.Point(21, 91);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(107, 36);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            // 
            // pnl_Conteudo
            // 
            this.pnl_Conteudo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Conteudo.Controls.Add(this.pnl_Func);
            this.pnl_Conteudo.Location = new System.Drawing.Point(12, 164);
            this.pnl_Conteudo.Name = "pnl_Conteudo";
            this.pnl_Conteudo.Size = new System.Drawing.Size(840, 505);
            this.pnl_Conteudo.TabIndex = 2;
            // 
            // pnl_Func
            // 
            this.pnl_Func.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Func.Controls.Add(this.lbl_NomeFunc);
            this.pnl_Func.Controls.Add(this.lbl_CargoFunc);
            this.pnl_Func.Controls.Add(this.lbl_DataFunc);
            this.pnl_Func.Controls.Add(this.lbl_DepartamentoFunc);
            this.pnl_Func.Controls.Add(this.lbl_SalarioFunc);
            this.pnl_Func.Controls.Add(this.textBox2);
            this.pnl_Func.Controls.Add(this.dTime_Admissao);
            this.pnl_Func.Controls.Add(this.cBox_Departamento);
            this.pnl_Func.Controls.Add(this.cBox_CargoF);
            this.pnl_Func.Controls.Add(this.txtBox_Nome);
            this.pnl_Func.Controls.Add(this.panel1);
            this.pnl_Func.Location = new System.Drawing.Point(11, 13);
            this.pnl_Func.Name = "pnl_Func";
            this.pnl_Func.Size = new System.Drawing.Size(462, 266);
            this.pnl_Func.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.lbl_FuncC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 45);
            this.panel1.TabIndex = 0;
            // 
            // lbl_FuncC
            // 
            this.lbl_FuncC.AutoSize = true;
            this.lbl_FuncC.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FuncC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FuncC.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_FuncC.Location = new System.Drawing.Point(156, 6);
            this.lbl_FuncC.Name = "lbl_FuncC";
            this.lbl_FuncC.Size = new System.Drawing.Size(150, 32);
            this.lbl_FuncC.TabIndex = 9;
            this.lbl_FuncC.Text = "Funcionário";
            // 
            // txtBox_Nome
            // 
            this.txtBox_Nome.Location = new System.Drawing.Point(10, 73);
            this.txtBox_Nome.Name = "txtBox_Nome";
            this.txtBox_Nome.Size = new System.Drawing.Size(209, 22);
            this.txtBox_Nome.TabIndex = 1;
            // 
            // cBox_CargoF
            // 
            this.cBox_CargoF.FormattingEnabled = true;
            this.cBox_CargoF.Location = new System.Drawing.Point(267, 74);
            this.cBox_CargoF.Name = "cBox_CargoF";
            this.cBox_CargoF.Size = new System.Drawing.Size(176, 21);
            this.cBox_CargoF.TabIndex = 2;
            // 
            // cBox_Departamento
            // 
            this.cBox_Departamento.FormattingEnabled = true;
            this.cBox_Departamento.Location = new System.Drawing.Point(10, 129);
            this.cBox_Departamento.Name = "cBox_Departamento";
            this.cBox_Departamento.Size = new System.Drawing.Size(176, 21);
            this.cBox_Departamento.TabIndex = 3;
            // 
            // dTime_Admissao
            // 
            this.dTime_Admissao.Location = new System.Drawing.Point(252, 125);
            this.dTime_Admissao.Name = "dTime_Admissao";
            this.dTime_Admissao.Size = new System.Drawing.Size(182, 22);
            this.dTime_Admissao.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 22);
            this.textBox2.TabIndex = 5;
            // 
            // lbl_SalarioFunc
            // 
            this.lbl_SalarioFunc.AutoSize = true;
            this.lbl_SalarioFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalarioFunc.Location = new System.Drawing.Point(10, 177);
            this.lbl_SalarioFunc.Name = "lbl_SalarioFunc";
            this.lbl_SalarioFunc.Size = new System.Drawing.Size(43, 15);
            this.lbl_SalarioFunc.TabIndex = 6;
            this.lbl_SalarioFunc.Text = "Salário";
            // 
            // lbl_DepartamentoFunc
            // 
            this.lbl_DepartamentoFunc.AutoSize = true;
            this.lbl_DepartamentoFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DepartamentoFunc.Location = new System.Drawing.Point(10, 113);
            this.lbl_DepartamentoFunc.Name = "lbl_DepartamentoFunc";
            this.lbl_DepartamentoFunc.Size = new System.Drawing.Size(84, 15);
            this.lbl_DepartamentoFunc.TabIndex = 7;
            this.lbl_DepartamentoFunc.Text = "Departamento";
            // 
            // lbl_DataFunc
            // 
            this.lbl_DataFunc.AutoSize = true;
            this.lbl_DataFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataFunc.Location = new System.Drawing.Point(249, 109);
            this.lbl_DataFunc.Name = "lbl_DataFunc";
            this.lbl_DataFunc.Size = new System.Drawing.Size(103, 15);
            this.lbl_DataFunc.TabIndex = 8;
            this.lbl_DataFunc.Text = "Data de Admissão";
            // 
            // lbl_CargoFunc
            // 
            this.lbl_CargoFunc.AutoSize = true;
            this.lbl_CargoFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CargoFunc.Location = new System.Drawing.Point(268, 58);
            this.lbl_CargoFunc.Name = "lbl_CargoFunc";
            this.lbl_CargoFunc.Size = new System.Drawing.Size(38, 15);
            this.lbl_CargoFunc.TabIndex = 9;
            this.lbl_CargoFunc.Text = "Cargo";
            // 
            // lbl_NomeFunc
            // 
            this.lbl_NomeFunc.AutoSize = true;
            this.lbl_NomeFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeFunc.Location = new System.Drawing.Point(10, 57);
            this.lbl_NomeFunc.Name = "lbl_NomeFunc";
            this.lbl_NomeFunc.Size = new System.Drawing.Size(40, 15);
            this.lbl_NomeFunc.TabIndex = 10;
            this.lbl_NomeFunc.Text = "Nome";
            // 
            // frmGerenciarFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.pnl_Fundo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciarFunc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Fundo.ResumeLayout(false);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.pnl_Conteudo.ResumeLayout(false);
            this.pnl_Func.ResumeLayout(false);
            this.pnl_Func.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fundo;
        private System.Windows.Forms.Panel pnl_Top;
        private Guna.UI2.WinForms.Guna2VSeparator SeparatorV_01;
        private Guna.UI2.WinForms.Guna2VSeparator SeparatorV_02;
        private Guna.UI2.WinForms.Guna2Separator SeparatorH_01;
        private System.Windows.Forms.Label lbl_CategoriaT;
        private System.Windows.Forms.Label lbl_Titulo;
        private Guna.UI2.WinForms.Guna2Button btn_Buscar;
        private System.Windows.Forms.Panel pnl_Conteudo;
        private System.Windows.Forms.Panel pnl_Func;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_FuncC;
        private System.Windows.Forms.Label lbl_NomeFunc;
        private System.Windows.Forms.Label lbl_CargoFunc;
        private System.Windows.Forms.Label lbl_DataFunc;
        private System.Windows.Forms.Label lbl_DepartamentoFunc;
        private System.Windows.Forms.Label lbl_SalarioFunc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dTime_Admissao;
        private System.Windows.Forms.ComboBox cBox_Departamento;
        private System.Windows.Forms.ComboBox cBox_CargoF;
        private System.Windows.Forms.TextBox txtBox_Nome;
    }
}