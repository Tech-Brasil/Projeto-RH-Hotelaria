namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers.Busca
{
    partial class frmBuscarDocPessoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_DocPes = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.pnl_fundo.Controls.Add(this.label1);
            this.pnl_fundo.Controls.Add(this.cBox_DocPes);
            this.pnl_fundo.Controls.Add(this.pnl_Top);
            this.pnl_fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fundo.Location = new System.Drawing.Point(0, 0);
            this.pnl_fundo.Name = "pnl_fundo";
            this.pnl_fundo.Size = new System.Drawing.Size(400, 150);
            this.pnl_fundo.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o documento da Pessoa";
            // 
            // cBox_DocPes
            // 
            this.cBox_DocPes.AutoRoundedCorners = true;
            this.cBox_DocPes.BackColor = System.Drawing.Color.Transparent;
            this.cBox_DocPes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBox_DocPes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_DocPes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBox_DocPes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBox_DocPes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.cBox_DocPes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBox_DocPes.ItemHeight = 30;
            this.cBox_DocPes.Location = new System.Drawing.Point(17, 69);
            this.cBox_DocPes.Name = "cBox_DocPes";
            this.cBox_DocPes.Size = new System.Drawing.Size(370, 36);
            this.cBox_DocPes.TabIndex = 1;
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
            this.lbl_Titulo.Size = new System.Drawing.Size(186, 25);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Documento Pessoal";
            // 
            // frmBuscarDocPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.pnl_fundo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarDocPessoa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBuscarDocPessoa_Load);
            this.pnl_fundo.ResumeLayout(false);
            this.pnl_fundo.PerformLayout();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fundo;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_Titulo;
        private Guna.UI2.WinForms.Guna2ComboBox cBox_DocPes;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Cancelar;
        private Guna.UI2.WinForms.Guna2Button btn_Confirmar;
    }
}