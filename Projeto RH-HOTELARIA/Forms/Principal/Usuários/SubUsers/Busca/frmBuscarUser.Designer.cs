namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca
{
    partial class frmBuscarUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl_BuscUser = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage_Buscar = new System.Windows.Forms.TabPage();
            this.gBox_User = new System.Windows.Forms.GroupBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.txtBox_RG = new System.Windows.Forms.TextBox();
            this.txtBox_Login = new System.Windows.Forms.TextBox();
            this.lbl_RG = new System.Windows.Forms.Label();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.btn_Can1 = new System.Windows.Forms.Button();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.tabPage_Resultado = new System.Windows.Forms.TabPage();
            this.dgv_Resultado = new System.Windows.Forms.DataGridView();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Bottom2 = new System.Windows.Forms.Panel();
            this.btn_Can2 = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.tabControl_BuscUser.SuspendLayout();
            this.tabPage_Buscar.SuspendLayout();
            this.gBox_User.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.tabPage_Resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado)).BeginInit();
            this.pnl_Bottom2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_BuscUser
            // 
            this.tabControl_BuscUser.Controls.Add(this.tabPage_Buscar);
            this.tabControl_BuscUser.Controls.Add(this.tabPage_Resultado);
            this.tabControl_BuscUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_BuscUser.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl_BuscUser.Location = new System.Drawing.Point(0, 0);
            this.tabControl_BuscUser.Name = "tabControl_BuscUser";
            this.tabControl_BuscUser.SelectedIndex = 0;
            this.tabControl_BuscUser.Size = new System.Drawing.Size(409, 311);
            this.tabControl_BuscUser.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl_BuscUser.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl_BuscUser.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl_BuscUser.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl_BuscUser.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl_BuscUser.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl_BuscUser.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl_BuscUser.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl_BuscUser.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl_BuscUser.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl_BuscUser.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl_BuscUser.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControl_BuscUser.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl_BuscUser.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl_BuscUser.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl_BuscUser.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl_BuscUser.TabIndex = 1;
            this.tabControl_BuscUser.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl_BuscUser.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage_Buscar
            // 
            this.tabPage_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_Buscar.Controls.Add(this.gBox_User);
            this.tabPage_Buscar.Controls.Add(this.pnl_Bottom);
            this.tabPage_Buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_Buscar.Location = new System.Drawing.Point(4, 44);
            this.tabPage_Buscar.Name = "tabPage_Buscar";
            this.tabPage_Buscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Buscar.Size = new System.Drawing.Size(401, 263);
            this.tabPage_Buscar.TabIndex = 0;
            this.tabPage_Buscar.Text = "Buscar";
            // 
            // gBox_User
            // 
            this.gBox_User.BackColor = System.Drawing.SystemColors.Control;
            this.gBox_User.Controls.Add(this.guna2Separator2);
            this.gBox_User.Controls.Add(this.guna2Separator1);
            this.gBox_User.Controls.Add(this.lbl_Login);
            this.gBox_User.Controls.Add(this.txtBox_RG);
            this.gBox_User.Controls.Add(this.txtBox_Login);
            this.gBox_User.Controls.Add(this.lbl_RG);
            this.gBox_User.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_User.Location = new System.Drawing.Point(3, 3);
            this.gBox_User.Name = "gBox_User";
            this.gBox_User.Size = new System.Drawing.Size(395, 221);
            this.gBox_User.TabIndex = 1;
            this.gBox_User.TabStop = false;
            this.gBox_User.Text = "Buscar o Usuário";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(0, 105);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(395, 10);
            this.guna2Separator2.TabIndex = 9;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 63);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(395, 10);
            this.guna2Separator1.TabIndex = 8;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(34, 82);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(37, 15);
            this.lbl_Login.TabIndex = 5;
            this.lbl_Login.Text = "Login";
            // 
            // txtBox_RG
            // 
            this.txtBox_RG.Enabled = false;
            this.txtBox_RG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_RG.Location = new System.Drawing.Point(121, 34);
            this.txtBox_RG.Name = "txtBox_RG";
            this.txtBox_RG.Size = new System.Drawing.Size(192, 23);
            this.txtBox_RG.TabIndex = 4;
            // 
            // txtBox_Login
            // 
            this.txtBox_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Login.Location = new System.Drawing.Point(121, 81);
            this.txtBox_Login.Name = "txtBox_Login";
            this.txtBox_Login.Size = new System.Drawing.Size(192, 23);
            this.txtBox_Login.TabIndex = 3;
            // 
            // lbl_RG
            // 
            this.lbl_RG.AutoSize = true;
            this.lbl_RG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RG.Location = new System.Drawing.Point(34, 35);
            this.lbl_RG.Name = "lbl_RG";
            this.lbl_RG.Size = new System.Drawing.Size(24, 15);
            this.lbl_RG.TabIndex = 1;
            this.lbl_RG.Text = "RG";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Bottom.Controls.Add(this.btn_Can1);
            this.pnl_Bottom.Controls.Add(this.btn_Procurar);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(3, 225);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(395, 35);
            this.pnl_Bottom.TabIndex = 0;
            // 
            // btn_Can1
            // 
            this.btn_Can1.Location = new System.Drawing.Point(189, 3);
            this.btn_Can1.Name = "btn_Can1";
            this.btn_Can1.Size = new System.Drawing.Size(90, 25);
            this.btn_Can1.TabIndex = 2;
            this.btn_Can1.Text = "Cancelar";
            this.btn_Can1.UseVisualStyleBackColor = true;
            this.btn_Can1.Click += new System.EventHandler(this.Cancelar);
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.Location = new System.Drawing.Point(296, 3);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(90, 25);
            this.btn_Procurar.TabIndex = 1;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.UseVisualStyleBackColor = true;
            this.btn_Procurar.Click += new System.EventHandler(this.btn_Procurar_Click);
            // 
            // tabPage_Resultado
            // 
            this.tabPage_Resultado.Controls.Add(this.dgv_Resultado);
            this.tabPage_Resultado.Controls.Add(this.pnl_Bottom2);
            this.tabPage_Resultado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Resultado.Location = new System.Drawing.Point(4, 44);
            this.tabPage_Resultado.Name = "tabPage_Resultado";
            this.tabPage_Resultado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Resultado.Size = new System.Drawing.Size(401, 263);
            this.tabPage_Resultado.TabIndex = 1;
            this.tabPage_Resultado.Text = "Resultado";
            this.tabPage_Resultado.UseVisualStyleBackColor = true;
            // 
            // dgv_Resultado
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Resultado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Resultado.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Resultado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RG,
            this.Login,
            this.Role,
            this.Ativo});
            this.dgv_Resultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Resultado.Location = new System.Drawing.Point(3, 3);
            this.dgv_Resultado.Name = "dgv_Resultado";
            this.dgv_Resultado.Size = new System.Drawing.Size(395, 222);
            this.dgv_Resultado.TabIndex = 2;
            // 
            // RG
            // 
            this.RG.Frozen = true;
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            // 
            // Login
            // 
            this.Login.Frozen = true;
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            // 
            // Role
            // 
            this.Role.Frozen = true;
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // Ativo
            // 
            this.Ativo.Frozen = true;
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            // 
            // pnl_Bottom2
            // 
            this.pnl_Bottom2.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_Bottom2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Bottom2.Controls.Add(this.btn_Can2);
            this.pnl_Bottom2.Controls.Add(this.btn_Confirmar);
            this.pnl_Bottom2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom2.Location = new System.Drawing.Point(3, 225);
            this.pnl_Bottom2.Name = "pnl_Bottom2";
            this.pnl_Bottom2.Size = new System.Drawing.Size(395, 35);
            this.pnl_Bottom2.TabIndex = 1;
            // 
            // btn_Can2
            // 
            this.btn_Can2.Location = new System.Drawing.Point(189, 3);
            this.btn_Can2.Name = "btn_Can2";
            this.btn_Can2.Size = new System.Drawing.Size(90, 25);
            this.btn_Can2.TabIndex = 2;
            this.btn_Can2.Text = "Cancelar";
            this.btn_Can2.UseVisualStyleBackColor = true;
            this.btn_Can2.Click += new System.EventHandler(this.Cancelar);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(296, 3);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(90, 25);
            this.btn_Confirmar.TabIndex = 1;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // frmBuscarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 311);
            this.Controls.Add(this.tabControl_BuscUser);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Usuário";
            this.Load += new System.EventHandler(this.frmBuscarUser_Load);
            this.tabControl_BuscUser.ResumeLayout(false);
            this.tabPage_Buscar.ResumeLayout(false);
            this.gBox_User.ResumeLayout(false);
            this.gBox_User.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.tabPage_Resultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado)).EndInit();
            this.pnl_Bottom2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControl_BuscUser;
        private System.Windows.Forms.TabPage tabPage_Buscar;
        private System.Windows.Forms.GroupBox gBox_User;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox txtBox_RG;
        private System.Windows.Forms.TextBox txtBox_Login;
        private System.Windows.Forms.Label lbl_RG;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button btn_Can1;
        private System.Windows.Forms.Button btn_Procurar;
        private System.Windows.Forms.TabPage tabPage_Resultado;
        private System.Windows.Forms.DataGridView dgv_Resultado;
        private System.Windows.Forms.Panel pnl_Bottom2;
        private System.Windows.Forms.Button btn_Can2;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
    }
}