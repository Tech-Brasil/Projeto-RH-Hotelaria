namespace Projeto_RH_HOTELARIA.Forms.Principal
{
    partial class frmMain
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
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarListarCargosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarDocumentosCNHCTPSEtcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.endereçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manterEndereçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarListarDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benefíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associarBenefíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarBenefíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folhaDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarFolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFolhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afastamentosFériasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAfastamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAfastamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admissõesPorPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demissõesPorPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aniversariantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferênciasDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Bottom.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Bottom.Controls.Add(this.lbl_Date);
            this.pnl_Bottom.Controls.Add(this.lbl_User);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 455);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(1032, 30);
            this.pnl_Bottom.TabIndex = 0;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(729, 6);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(176, 14);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Data e Hora: 00/00/0000  00:00:00";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(10, 6);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(88, 14);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "Usuário: TESTE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.endereçosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.benefíciosToolStripMenuItem,
            this.folhaDePagamentoToolStripMenuItem,
            this.afastamentosFériasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "MnPrincipal";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarUsuáriosToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem,
            this.cargosToolStripMenuItem1});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // gerenciarUsuáriosToolStripMenuItem
            // 
            this.gerenciarUsuáriosToolStripMenuItem.Name = "gerenciarUsuáriosToolStripMenuItem";
            this.gerenciarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gerenciarUsuáriosToolStripMenuItem.Text = "Gerenciar Usuários";
            this.gerenciarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarUsuáriosToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // cargosToolStripMenuItem1
            // 
            this.cargosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarListarCargosToolStripMenuItem1});
            this.cargosToolStripMenuItem1.Name = "cargosToolStripMenuItem1";
            this.cargosToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.cargosToolStripMenuItem1.Text = "Cargos";
            // 
            // cadastrarListarCargosToolStripMenuItem1
            // 
            this.cadastrarListarCargosToolStripMenuItem1.Name = "cadastrarListarCargosToolStripMenuItem1";
            this.cadastrarListarCargosToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.cadastrarListarCargosToolStripMenuItem1.Text = "Cadastrar/Listar Cargos";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionárioToolStripMenuItem,
            this.listarFuncionáriosToolStripMenuItem,
            this.relatóriosDeFuncionáriosToolStripMenuItem,
            this.documentosToolStripMenuItem1});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            this.cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            this.cadastrarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar Funcionário";
            // 
            // listarFuncionáriosToolStripMenuItem
            // 
            this.listarFuncionáriosToolStripMenuItem.Name = "listarFuncionáriosToolStripMenuItem";
            this.listarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.listarFuncionáriosToolStripMenuItem.Text = "Listar Funcionários";
            // 
            // relatóriosDeFuncionáriosToolStripMenuItem
            // 
            this.relatóriosDeFuncionáriosToolStripMenuItem.Name = "relatóriosDeFuncionáriosToolStripMenuItem";
            this.relatóriosDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.relatóriosDeFuncionáriosToolStripMenuItem.Text = "Relatórios de Funcionários";
            // 
            // documentosToolStripMenuItem1
            // 
            this.documentosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarDocumentosCNHCTPSEtcToolStripMenuItem1});
            this.documentosToolStripMenuItem1.Name = "documentosToolStripMenuItem1";
            this.documentosToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.documentosToolStripMenuItem1.Text = "Documentos";
            // 
            // gerenciarDocumentosCNHCTPSEtcToolStripMenuItem1
            // 
            this.gerenciarDocumentosCNHCTPSEtcToolStripMenuItem1.Name = "gerenciarDocumentosCNHCTPSEtcToolStripMenuItem1";
            this.gerenciarDocumentosCNHCTPSEtcToolStripMenuItem1.Size = new System.Drawing.Size(303, 22);
            this.gerenciarDocumentosCNHCTPSEtcToolStripMenuItem1.Text = "Gerenciar Documentos (CNH, CTPS, etc.)";
            // 
            // endereçosToolStripMenuItem
            // 
            this.endereçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manterEndereçosToolStripMenuItem});
            this.endereçosToolStripMenuItem.Name = "endereçosToolStripMenuItem";
            this.endereçosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.endereçosToolStripMenuItem.Text = "Endereços ";
            // 
            // manterEndereçosToolStripMenuItem
            // 
            this.manterEndereçosToolStripMenuItem.Name = "manterEndereçosToolStripMenuItem";
            this.manterEndereçosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.manterEndereçosToolStripMenuItem.Text = "Manter Endereços";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarListarDepartamentosToolStripMenuItem});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // cadastrarListarDepartamentosToolStripMenuItem
            // 
            this.cadastrarListarDepartamentosToolStripMenuItem.Name = "cadastrarListarDepartamentosToolStripMenuItem";
            this.cadastrarListarDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.cadastrarListarDepartamentosToolStripMenuItem.Text = "Cadastrar/Listar Departamentos";
            // 
            // benefíciosToolStripMenuItem
            // 
            this.benefíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associarBenefíciosToolStripMenuItem,
            this.gerenciarBenefíciosToolStripMenuItem});
            this.benefíciosToolStripMenuItem.Name = "benefíciosToolStripMenuItem";
            this.benefíciosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.benefíciosToolStripMenuItem.Text = "Benefícios";
            // 
            // associarBenefíciosToolStripMenuItem
            // 
            this.associarBenefíciosToolStripMenuItem.Name = "associarBenefíciosToolStripMenuItem";
            this.associarBenefíciosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.associarBenefíciosToolStripMenuItem.Text = "Associar Benefícios";
            // 
            // gerenciarBenefíciosToolStripMenuItem
            // 
            this.gerenciarBenefíciosToolStripMenuItem.Name = "gerenciarBenefíciosToolStripMenuItem";
            this.gerenciarBenefíciosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gerenciarBenefíciosToolStripMenuItem.Text = "Gerenciar Benefícios";
            // 
            // folhaDePagamentoToolStripMenuItem
            // 
            this.folhaDePagamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarFolhaToolStripMenuItem,
            this.consultarFolhasToolStripMenuItem});
            this.folhaDePagamentoToolStripMenuItem.Name = "folhaDePagamentoToolStripMenuItem";
            this.folhaDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.folhaDePagamentoToolStripMenuItem.Text = "Folha de Pagamento";
            // 
            // gerarFolhaToolStripMenuItem
            // 
            this.gerarFolhaToolStripMenuItem.Name = "gerarFolhaToolStripMenuItem";
            this.gerarFolhaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.gerarFolhaToolStripMenuItem.Text = "Gerar Folha";
            // 
            // consultarFolhasToolStripMenuItem
            // 
            this.consultarFolhasToolStripMenuItem.Name = "consultarFolhasToolStripMenuItem";
            this.consultarFolhasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.consultarFolhasToolStripMenuItem.Text = "Consultar Folhas";
            // 
            // afastamentosFériasToolStripMenuItem
            // 
            this.afastamentosFériasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAfastamentoToolStripMenuItem,
            this.consultarAfastamentosToolStripMenuItem});
            this.afastamentosFériasToolStripMenuItem.Name = "afastamentosFériasToolStripMenuItem";
            this.afastamentosFériasToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.afastamentosFériasToolStripMenuItem.Text = "Afastamentos/Férias";
            // 
            // registrarAfastamentoToolStripMenuItem
            // 
            this.registrarAfastamentoToolStripMenuItem.Name = "registrarAfastamentoToolStripMenuItem";
            this.registrarAfastamentoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.registrarAfastamentoToolStripMenuItem.Text = "Registrar Afastamento";
            // 
            // consultarAfastamentosToolStripMenuItem
            // 
            this.consultarAfastamentosToolStripMenuItem.Name = "consultarAfastamentosToolStripMenuItem";
            this.consultarAfastamentosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.consultarAfastamentosToolStripMenuItem.Text = "Consultar Afastamentos";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admissõesPorPeríodoToolStripMenuItem,
            this.demissõesPorPeríodoToolStripMenuItem,
            this.aniversariantesToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // admissõesPorPeríodoToolStripMenuItem
            // 
            this.admissõesPorPeríodoToolStripMenuItem.Name = "admissõesPorPeríodoToolStripMenuItem";
            this.admissõesPorPeríodoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.admissõesPorPeríodoToolStripMenuItem.Text = "Admissões por período";
            // 
            // demissõesPorPeríodoToolStripMenuItem
            // 
            this.demissõesPorPeríodoToolStripMenuItem.Name = "demissõesPorPeríodoToolStripMenuItem";
            this.demissõesPorPeríodoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.demissõesPorPeríodoToolStripMenuItem.Text = "Demissões por período";
            // 
            // aniversariantesToolStripMenuItem
            // 
            this.aniversariantesToolStripMenuItem.Name = "aniversariantesToolStripMenuItem";
            this.aniversariantesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.aniversariantesToolStripMenuItem.Text = "Aniversariantes";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarSenhaToolStripMenuItem,
            this.preferênciasDoSistemaToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // trocarSenhaToolStripMenuItem
            // 
            this.trocarSenhaToolStripMenuItem.Name = "trocarSenhaToolStripMenuItem";
            this.trocarSenhaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.trocarSenhaToolStripMenuItem.Text = "Trocar Senha";
            // 
            // preferênciasDoSistemaToolStripMenuItem
            // 
            this.preferênciasDoSistemaToolStripMenuItem.Name = "preferênciasDoSistemaToolStripMenuItem";
            this.preferênciasDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.preferênciasDoSistemaToolStripMenuItem.Text = "Preferências do Sistema";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 485);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Bottom.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endereçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benefíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folhaDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afastamentosFériasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarListarCargosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manterEndereçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarListarDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarDocumentosCNHCTPSEtcToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem associarBenefíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarBenefíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarFolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFolhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAfastamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAfastamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admissõesPorPeríodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demissõesPorPeríodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aniversariantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferênciasDoSistemaToolStripMenuItem;
    }
}