namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca
{
    partial class frmRG
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
            this.tab_RG = new System.Windows.Forms.TabControl();
            this.page_Procurar = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_CPF = new System.Windows.Forms.TextBox();
            this.txtBox_RG = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.page_Resultado = new System.Windows.Forms.TabPage();
            this.dgv_Resultado = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Can2 = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAdmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDemissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_RG.SuspendLayout();
            this.page_Procurar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.page_Resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_RG
            // 
            this.tab_RG.Controls.Add(this.page_Procurar);
            this.tab_RG.Controls.Add(this.page_Resultado);
            this.tab_RG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_RG.Location = new System.Drawing.Point(0, 0);
            this.tab_RG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tab_RG.Name = "tab_RG";
            this.tab_RG.SelectedIndex = 0;
            this.tab_RG.Size = new System.Drawing.Size(362, 244);
            this.tab_RG.TabIndex = 0;
            // 
            // page_Procurar
            // 
            this.page_Procurar.BackColor = System.Drawing.SystemColors.Menu;
            this.page_Procurar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.page_Procurar.Controls.Add(this.label2);
            this.page_Procurar.Controls.Add(this.label1);
            this.page_Procurar.Controls.Add(this.txtBox_CPF);
            this.page_Procurar.Controls.Add(this.txtBox_RG);
            this.page_Procurar.Controls.Add(this.panel1);
            this.page_Procurar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.page_Procurar.Location = new System.Drawing.Point(4, 23);
            this.page_Procurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.page_Procurar.Name = "page_Procurar";
            this.page_Procurar.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.page_Procurar.Size = new System.Drawing.Size(354, 217);
            this.page_Procurar.TabIndex = 0;
            this.page_Procurar.Text = "Procurar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "RG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPF";
            // 
            // txtBox_CPF
            // 
            this.txtBox_CPF.Location = new System.Drawing.Point(71, 99);
            this.txtBox_CPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox_CPF.Name = "txtBox_CPF";
            this.txtBox_CPF.Size = new System.Drawing.Size(172, 20);
            this.txtBox_CPF.TabIndex = 2;
            // 
            // txtBox_RG
            // 
            this.txtBox_RG.Location = new System.Drawing.Point(71, 42);
            this.txtBox_RG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox_RG.Name = "txtBox_RG";
            this.txtBox_RG.Size = new System.Drawing.Size(172, 20);
            this.txtBox_RG.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Procurar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 179);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 31);
            this.panel1.TabIndex = 0;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(150, 3);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(88, 25);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.Location = new System.Drawing.Point(245, 3);
            this.btn_Procurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(88, 25);
            this.btn_Procurar.TabIndex = 1;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.UseVisualStyleBackColor = true;
            this.btn_Procurar.Click += new System.EventHandler(this.btn_Procurar_Click);
            // 
            // page_Resultado
            // 
            this.page_Resultado.Controls.Add(this.dgv_Resultado);
            this.page_Resultado.Controls.Add(this.panel2);
            this.page_Resultado.Location = new System.Drawing.Point(4, 23);
            this.page_Resultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.page_Resultado.Name = "page_Resultado";
            this.page_Resultado.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.page_Resultado.Size = new System.Drawing.Size(354, 217);
            this.page_Resultado.TabIndex = 1;
            this.page_Resultado.Text = "Resultado";
            this.page_Resultado.UseVisualStyleBackColor = true;
            // 
            // dgv_Resultado
            // 
            this.dgv_Resultado.AllowUserToAddRows = false;
            this.dgv_Resultado.AllowUserToDeleteRows = false;
            this.dgv_Resultado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Resultado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Resultado.ColumnHeadersHeight = 40;
            this.dgv_Resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RG,
            this.Nome,
            this.DataNascimento,
            this.Cargo,
            this.Departamento,
            this.DataAdmissao,
            this.DataDemissao,
            this.Salario});
            this.dgv_Resultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Resultado.EnableHeadersVisualStyles = false;
            this.dgv_Resultado.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_Resultado.Location = new System.Drawing.Point(4, 3);
            this.dgv_Resultado.MultiSelect = false;
            this.dgv_Resultado.Name = "dgv_Resultado";
            this.dgv_Resultado.ReadOnly = true;
            this.dgv_Resultado.RowHeadersVisible = false;
            this.dgv_Resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Resultado.Size = new System.Drawing.Size(346, 180);
            this.dgv_Resultado.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Can2);
            this.panel2.Controls.Add(this.btn_Confirmar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 183);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 31);
            this.panel2.TabIndex = 3;
            // 
            // btn_Can2
            // 
            this.btn_Can2.Location = new System.Drawing.Point(150, 3);
            this.btn_Can2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Can2.Name = "btn_Can2";
            this.btn_Can2.Size = new System.Drawing.Size(88, 25);
            this.btn_Can2.TabIndex = 2;
            this.btn_Can2.Text = "Cancelar";
            this.btn_Can2.UseVisualStyleBackColor = true;
            this.btn_Can2.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(245, 3);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(88, 25);
            this.btn_Confirmar.TabIndex = 1;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Width = 30;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 50;
            // 
            // DataNascimento
            // 
            this.DataNascimento.HeaderText = "Data de Nascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 45;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // DataAdmissao
            // 
            this.DataAdmissao.HeaderText = "Data de Admissão";
            this.DataAdmissao.Name = "DataAdmissao";
            this.DataAdmissao.ReadOnly = true;
            // 
            // DataDemissao
            // 
            this.DataDemissao.HeaderText = "Data de Demissão";
            this.DataDemissao.Name = "DataDemissao";
            this.DataDemissao.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salário";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            this.Salario.Width = 50;
            // 
            // frmRG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(362, 244);
            this.Controls.Add(this.tab_RG);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRG";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurar RG";
            this.tab_RG.ResumeLayout(false);
            this.page_Procurar.ResumeLayout(false);
            this.page_Procurar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.page_Resultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_RG;
        private System.Windows.Forms.TabPage page_Procurar;
        private System.Windows.Forms.TabPage page_Resultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Procurar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_CPF;
        private System.Windows.Forms.TextBox txtBox_RG;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Can2;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.DataGridView dgv_Resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAdmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDemissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
    }
}