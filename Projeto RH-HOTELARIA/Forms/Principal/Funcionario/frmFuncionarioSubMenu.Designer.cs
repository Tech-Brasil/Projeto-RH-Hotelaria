namespace Projeto_RH_HOTELARIA.Forms.Principal.Funcionario
{
    partial class frmFuncionarioSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarioSubMenu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_SubTitulo = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.btn_Manager = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ListarFunc = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AlterarCargo = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(4, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 3);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(4, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 3);
            this.panel1.TabIndex = 6;
            // 
            // lbl_SubTitulo
            // 
            this.lbl_SubTitulo.AutoSize = true;
            this.lbl_SubTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_SubTitulo.Location = new System.Drawing.Point(-1, 9);
            this.lbl_SubTitulo.Name = "lbl_SubTitulo";
            this.lbl_SubTitulo.Size = new System.Drawing.Size(130, 30);
            this.lbl_SubTitulo.TabIndex = 5;
            this.lbl_SubTitulo.Text = "Funcionário";
            this.lbl_SubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Categoria.Location = new System.Drawing.Point(9, 45);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(124, 27);
            this.lbl_Categoria.TabIndex = 8;
            this.lbl_Categoria.Text = "Gerenciamento";
            this.lbl_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Categoria.UseCompatibleTextRendering = true;
            // 
            // btn_Manager
            // 
            this.btn_Manager.Animated = true;
            this.btn_Manager.BackColor = System.Drawing.Color.Transparent;
            this.btn_Manager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Manager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Manager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Manager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Manager.FillColor = System.Drawing.Color.Transparent;
            this.btn_Manager.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Manager.ForeColor = System.Drawing.Color.Gray;
            this.btn_Manager.Image = global::Projeto_RH_HOTELARIA.Properties.Resources.icon_subGerenciamento;
            this.btn_Manager.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Manager.Location = new System.Drawing.Point(4, 75);
            this.btn_Manager.Name = "btn_Manager";
            this.btn_Manager.Size = new System.Drawing.Size(178, 32);
            this.btn_Manager.TabIndex = 9;
            this.btn_Manager.Text = "Gerenciar Funcionário";
            this.btn_Manager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Manager.Click += new System.EventHandler(this.btn_Manager_Click);
            // 
            // btn_ListarFunc
            // 
            this.btn_ListarFunc.Animated = true;
            this.btn_ListarFunc.BackColor = System.Drawing.Color.Transparent;
            this.btn_ListarFunc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ListarFunc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ListarFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ListarFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ListarFunc.FillColor = System.Drawing.Color.Transparent;
            this.btn_ListarFunc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ListarFunc.ForeColor = System.Drawing.Color.Gray;
            this.btn_ListarFunc.Image = global::Projeto_RH_HOTELARIA.Properties.Resources.icon_subGerenciamento;
            this.btn_ListarFunc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ListarFunc.Location = new System.Drawing.Point(4, 113);
            this.btn_ListarFunc.Name = "btn_ListarFunc";
            this.btn_ListarFunc.Size = new System.Drawing.Size(178, 32);
            this.btn_ListarFunc.TabIndex = 10;
            this.btn_ListarFunc.Text = "Listar Funcionário";
            this.btn_ListarFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ListarFunc.Click += new System.EventHandler(this.btn_ListarFunc_Click);
            // 
            // btn_AlterarCargo
            // 
            this.btn_AlterarCargo.Animated = true;
            this.btn_AlterarCargo.BackColor = System.Drawing.Color.Transparent;
            this.btn_AlterarCargo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AlterarCargo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AlterarCargo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AlterarCargo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AlterarCargo.FillColor = System.Drawing.Color.Transparent;
            this.btn_AlterarCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_AlterarCargo.ForeColor = System.Drawing.Color.Gray;
            this.btn_AlterarCargo.Image = global::Projeto_RH_HOTELARIA.Properties.Resources.icon_subGerenciamento;
            this.btn_AlterarCargo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AlterarCargo.Location = new System.Drawing.Point(4, 151);
            this.btn_AlterarCargo.Name = "btn_AlterarCargo";
            this.btn_AlterarCargo.Size = new System.Drawing.Size(178, 32);
            this.btn_AlterarCargo.TabIndex = 11;
            this.btn_AlterarCargo.Text = "Alterar Cargo";
            this.btn_AlterarCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AlterarCargo.Click += new System.EventHandler(this.btn_AlterarCargo_Click);
            // 
            // frmFuncionarioSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(184, 642);
            this.Controls.Add(this.btn_AlterarCargo);
            this.Controls.Add(this.btn_ListarFunc);
            this.Controls.Add(this.btn_Manager);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_SubTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFuncionarioSubMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmFuncionarioSubMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_SubTitulo;
        private System.Windows.Forms.Label lbl_Categoria;
        private Guna.UI2.WinForms.Guna2Button btn_Manager;
        private Guna.UI2.WinForms.Guna2Button btn_ListarFunc;
        private Guna.UI2.WinForms.Guna2Button btn_AlterarCargo;
    }
}