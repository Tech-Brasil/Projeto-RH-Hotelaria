namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários
{
    partial class frmUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cadastro = new System.Windows.Forms.Button();
            this.pnl_Conteudo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Cadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 319);
            this.panel1.TabIndex = 0;
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastro.Image = global::Projeto_RH_HOTELARIA.Properties.Resources.icon_CadastroUser;
            this.btn_Cadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cadastro.Location = new System.Drawing.Point(5, 10);
            this.btn_Cadastro.Name = "btn_Cadastro";
            this.btn_Cadastro.Size = new System.Drawing.Size(85, 68);
            this.btn_Cadastro.TabIndex = 2;
            this.btn_Cadastro.Text = "Formulário de cadastro";
            this.btn_Cadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cadastro.UseVisualStyleBackColor = true;
            this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cadastro_Click);
            // 
            // pnl_Conteudo
            // 
            this.pnl_Conteudo.BackColor = System.Drawing.SystemColors.Menu;
            this.pnl_Conteudo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Conteudo.Location = new System.Drawing.Point(97, 0);
            this.pnl_Conteudo.Name = "pnl_Conteudo";
            this.pnl_Conteudo.Size = new System.Drawing.Size(404, 319);
            this.pnl_Conteudo.TabIndex = 1;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(501, 319);
            this.Controls.Add(this.pnl_Conteudo);
            this.Controls.Add(this.panel1);
            this.Name = "frmUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Usuários";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cadastro;
        private System.Windows.Forms.Panel pnl_Conteudo;
    }
}