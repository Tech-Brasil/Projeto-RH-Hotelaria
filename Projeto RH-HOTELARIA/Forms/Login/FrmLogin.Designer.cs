namespace Projeto_RH_HOTELARIA.Forms.Login
{
    partial class FrmLogin
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
            this.TxtBox_Usuario = new System.Windows.Forms.TextBox();
            this.TxtBox_Senha = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox_Usuario
            // 
            this.TxtBox_Usuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtBox_Usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Usuario.ForeColor = System.Drawing.Color.DimGray;
            this.TxtBox_Usuario.Location = new System.Drawing.Point(123, 157);
            this.TxtBox_Usuario.Name = "TxtBox_Usuario";
            this.TxtBox_Usuario.Size = new System.Drawing.Size(412, 26);
            this.TxtBox_Usuario.TabIndex = 1;
            this.TxtBox_Usuario.Text = "USUÁRIO";
            this.TxtBox_Usuario.Enter += new System.EventHandler(this.TxtBoxUsuario_Enter);
            this.TxtBox_Usuario.Leave += new System.EventHandler(this.TxtBox_Usuario_Leave);
            // 
            // TxtBox_Senha
            // 
            this.TxtBox_Senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Senha.ForeColor = System.Drawing.Color.DimGray;
            this.TxtBox_Senha.Location = new System.Drawing.Point(123, 250);
            this.TxtBox_Senha.Name = "TxtBox_Senha";
            this.TxtBox_Senha.Size = new System.Drawing.Size(412, 26);
            this.TxtBox_Senha.TabIndex = 2;
            this.TxtBox_Senha.Text = "SENHA";
            this.TxtBox_Senha.Enter += new System.EventHandler(this.TxtBox_Senha_Enter);
            this.TxtBox_Senha.Leave += new System.EventHandler(this.TxtBox_Senha_Leave);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(123, 326);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(406, 40);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "LOGIN";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.TxtBox_Senha);
            this.Controls.Add(this.TxtBox_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Opacity = 0.9D;
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBox_Usuario;
        private System.Windows.Forms.TextBox TxtBox_Senha;
        private System.Windows.Forms.Button Btn_Login;
    }
}