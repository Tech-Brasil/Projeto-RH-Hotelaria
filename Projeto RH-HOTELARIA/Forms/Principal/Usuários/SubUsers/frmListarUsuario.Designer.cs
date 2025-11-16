namespace Projeto_RH_HOTELARIA.Forms.Principal.Usuários.SubUsers
{
    partial class frmListarUsuario
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pnl_Conteudo = new System.Windows.Forms.Panel();
            this.pnl_Fundo.SuspendLayout();
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
            this.pnl_Fundo.TabIndex = 0;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Top.Location = new System.Drawing.Point(12, 12);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(840, 100);
            this.pnl_Top.TabIndex = 1;
            // 
            // pnl_Conteudo
            // 
            this.pnl_Conteudo.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Conteudo.Location = new System.Drawing.Point(12, 177);
            this.pnl_Conteudo.Name = "pnl_Conteudo";
            this.pnl_Conteudo.Size = new System.Drawing.Size(840, 492);
            this.pnl_Conteudo.TabIndex = 2;
            // 
            // frmListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.pnl_Fundo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListarUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListarUsuario";
            this.Load += new System.EventHandler(this.frmListarUsuario_Load);
            this.pnl_Fundo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fundo;
        private System.Windows.Forms.Panel pnl_Conteudo;
        private System.Windows.Forms.Panel pnl_Top;
    }
}