namespace TIGEST
{
    partial class Frm_RecursosAtivos
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Prd_LoadProcess = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Voltar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.Dgv_DataRecursos = new System.Windows.Forms.DataGridView();
            this.Gpr_FiltroData = new System.Windows.Forms.GroupBox();
            this.Clm_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_NumeroSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_NumeroBp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_RespAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_UserResp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_AtivoAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_DataInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_CarregarQwerty = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DataRecursos)).BeginInit();
            this.Gpr_FiltroData.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Prd_LoadProcess});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1423, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(99, 19);
            this.toolStripStatusLabel1.Text = "TIGEST 0.1 Build 1";
            // 
            // Prd_LoadProcess
            // 
            this.Prd_LoadProcess.Name = "Prd_LoadProcess";
            this.Prd_LoadProcess.Size = new System.Drawing.Size(100, 18);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Menu,
            this.Menu_Voltar,
            this.Menu_Sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1423, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Menu
            // 
            this.Menu_Menu.Name = "Menu_Menu";
            this.Menu_Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu_Menu.Text = "Menu";
            // 
            // Menu_Voltar
            // 
            this.Menu_Voltar.Name = "Menu_Voltar";
            this.Menu_Voltar.Size = new System.Drawing.Size(49, 20);
            this.Menu_Voltar.Text = "Voltar";
            this.Menu_Voltar.Click += new System.EventHandler(this.Menu_Voltar_Click);
            // 
            // Menu_Sair
            // 
            this.Menu_Sair.Name = "Menu_Sair";
            this.Menu_Sair.Size = new System.Drawing.Size(38, 20);
            this.Menu_Sair.Text = "Sair";
            // 
            // Dgv_DataRecursos
            // 
            this.Dgv_DataRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DataRecursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_Nome,
            this.Clm_Categoria,
            this.Clm_Tipo,
            this.Clm_Departamento,
            this.Clm_Local,
            this.Clm_NumeroSerie,
            this.Clm_Observacao,
            this.Clm_NumeroBp,
            this.Clm_RespAdd,
            this.Clm_UserResp,
            this.Clm_AtivoAd,
            this.Clm_DataInc,
            this.Clm_Ativo});
            this.Dgv_DataRecursos.Location = new System.Drawing.Point(12, 142);
            this.Dgv_DataRecursos.Name = "Dgv_DataRecursos";
            this.Dgv_DataRecursos.RowHeadersWidth = 51;
            this.Dgv_DataRecursos.Size = new System.Drawing.Size(1390, 439);
            this.Dgv_DataRecursos.TabIndex = 2;
            // 
            // Gpr_FiltroData
            // 
            this.Gpr_FiltroData.Controls.Add(this.Btn_CarregarQwerty);
            this.Gpr_FiltroData.Location = new System.Drawing.Point(12, 27);
            this.Gpr_FiltroData.Name = "Gpr_FiltroData";
            this.Gpr_FiltroData.Size = new System.Drawing.Size(1390, 106);
            this.Gpr_FiltroData.TabIndex = 3;
            this.Gpr_FiltroData.TabStop = false;
            this.Gpr_FiltroData.Text = "Filtros";
            // 
            // Clm_Nome
            // 
            this.Clm_Nome.HeaderText = "Nome";
            this.Clm_Nome.Name = "Clm_Nome";
            this.Clm_Nome.ReadOnly = true;
            // 
            // Clm_Categoria
            // 
            this.Clm_Categoria.HeaderText = "Categoria";
            this.Clm_Categoria.Name = "Clm_Categoria";
            this.Clm_Categoria.ReadOnly = true;
            // 
            // Clm_Tipo
            // 
            this.Clm_Tipo.HeaderText = "Tipo";
            this.Clm_Tipo.Name = "Clm_Tipo";
            this.Clm_Tipo.ReadOnly = true;
            // 
            // Clm_Departamento
            // 
            this.Clm_Departamento.HeaderText = "Departamento";
            this.Clm_Departamento.Name = "Clm_Departamento";
            this.Clm_Departamento.ReadOnly = true;
            // 
            // Clm_Local
            // 
            this.Clm_Local.HeaderText = "Local";
            this.Clm_Local.Name = "Clm_Local";
            this.Clm_Local.ReadOnly = true;
            // 
            // Clm_NumeroSerie
            // 
            this.Clm_NumeroSerie.HeaderText = "Número de série";
            this.Clm_NumeroSerie.Name = "Clm_NumeroSerie";
            this.Clm_NumeroSerie.ReadOnly = true;
            // 
            // Clm_Observacao
            // 
            this.Clm_Observacao.HeaderText = "Observacao";
            this.Clm_Observacao.Name = "Clm_Observacao";
            this.Clm_Observacao.ReadOnly = true;
            // 
            // Clm_NumeroBp
            // 
            this.Clm_NumeroBp.HeaderText = "Bem Patrimônial";
            this.Clm_NumeroBp.Name = "Clm_NumeroBp";
            this.Clm_NumeroBp.ReadOnly = true;
            // 
            // Clm_RespAdd
            // 
            this.Clm_RespAdd.HeaderText = "Responsável";
            this.Clm_RespAdd.Name = "Clm_RespAdd";
            this.Clm_RespAdd.ReadOnly = true;
            // 
            // Clm_UserResp
            // 
            this.Clm_UserResp.HeaderText = "Usuário Responsável";
            this.Clm_UserResp.Name = "Clm_UserResp";
            this.Clm_UserResp.ReadOnly = true;
            // 
            // Clm_AtivoAd
            // 
            this.Clm_AtivoAd.HeaderText = "Status AD";
            this.Clm_AtivoAd.Name = "Clm_AtivoAd";
            this.Clm_AtivoAd.ReadOnly = true;
            // 
            // Clm_DataInc
            // 
            this.Clm_DataInc.HeaderText = "Data Incluído";
            this.Clm_DataInc.Name = "Clm_DataInc";
            this.Clm_DataInc.ReadOnly = true;
            // 
            // Clm_Ativo
            // 
            this.Clm_Ativo.HeaderText = "Status Ativos";
            this.Clm_Ativo.Name = "Clm_Ativo";
            this.Clm_Ativo.ReadOnly = true;
            // 
            // Btn_CarregarQwerty
            // 
            this.Btn_CarregarQwerty.Location = new System.Drawing.Point(19, 28);
            this.Btn_CarregarQwerty.Name = "Btn_CarregarQwerty";
            this.Btn_CarregarQwerty.Size = new System.Drawing.Size(75, 23);
            this.Btn_CarregarQwerty.TabIndex = 0;
            this.Btn_CarregarQwerty.Text = "Carregar";
            this.Btn_CarregarQwerty.UseVisualStyleBackColor = true;
            this.Btn_CarregarQwerty.Click += new System.EventHandler(this.Btn_CarregarQwerty_Click);
            // 
            // Frm_RecursosAtivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 688);
            this.Controls.Add(this.Gpr_FiltroData);
            this.Controls.Add(this.Dgv_DataRecursos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_RecursosAtivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Recursos";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DataRecursos)).EndInit();
            this.Gpr_FiltroData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar Prd_LoadProcess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Voltar;
        private System.Windows.Forms.ToolStripMenuItem Menu_Sair;
        private System.Windows.Forms.DataGridView Dgv_DataRecursos;
        private System.Windows.Forms.GroupBox Gpr_FiltroData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_NumeroSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_NumeroBp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_RespAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_UserResp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_AtivoAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_DataInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Ativo;
        private System.Windows.Forms.Button Btn_CarregarQwerty;
    }
}