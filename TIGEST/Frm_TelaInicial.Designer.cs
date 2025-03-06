namespace TIGEST
{
    partial class Frm_TelaInicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Prb_LoadProcess = new System.Windows.Forms.ToolStripProgressBar();
            this.Btn_Ativos = new System.Windows.Forms.Button();
            this.Btn_AdmRecursos = new System.Windows.Forms.Button();
            this.Btn_Relatorios = new System.Windows.Forms.Button();
            this.Btn_GestaoUsuarios = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Menu,
            this.Menu_Sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Menu
            // 
            this.Menu_Menu.Name = "Menu_Menu";
            this.Menu_Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu_Menu.Text = "Menu";
            // 
            // Menu_Sair
            // 
            this.Menu_Sair.Name = "Menu_Sair";
            this.Menu_Sair.Size = new System.Drawing.Size(38, 20);
            this.Menu_Sair.Text = "Sair";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Status,
            this.Prb_LoadProcess});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1182, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Status
            // 
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(99, 17);
            this.lbl_Status.Text = "TIGEST 0.1 Build 1";
            // 
            // Prb_LoadProcess
            // 
            this.Prb_LoadProcess.Name = "Prb_LoadProcess";
            this.Prb_LoadProcess.Size = new System.Drawing.Size(100, 16);
            // 
            // Btn_Ativos
            // 
            this.Btn_Ativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ativos.Location = new System.Drawing.Point(45, 78);
            this.Btn_Ativos.Name = "Btn_Ativos";
            this.Btn_Ativos.Size = new System.Drawing.Size(348, 64);
            this.Btn_Ativos.TabIndex = 2;
            this.Btn_Ativos.Text = "Lista de Ativos";
            this.Btn_Ativos.UseVisualStyleBackColor = true;
            this.Btn_Ativos.Click += new System.EventHandler(this.Btn_Ativos_Click);
            // 
            // Btn_AdmRecursos
            // 
            this.Btn_AdmRecursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AdmRecursos.Location = new System.Drawing.Point(45, 178);
            this.Btn_AdmRecursos.Name = "Btn_AdmRecursos";
            this.Btn_AdmRecursos.Size = new System.Drawing.Size(348, 64);
            this.Btn_AdmRecursos.TabIndex = 3;
            this.Btn_AdmRecursos.Text = "Administração de  Recursos";
            this.Btn_AdmRecursos.UseMnemonic = false;
            this.Btn_AdmRecursos.UseVisualStyleBackColor = true;
            // 
            // Btn_Relatorios
            // 
            this.Btn_Relatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Relatorios.Location = new System.Drawing.Point(45, 286);
            this.Btn_Relatorios.Name = "Btn_Relatorios";
            this.Btn_Relatorios.Size = new System.Drawing.Size(348, 64);
            this.Btn_Relatorios.TabIndex = 4;
            this.Btn_Relatorios.Text = "Relatórios";
            this.Btn_Relatorios.UseVisualStyleBackColor = true;
            // 
            // Btn_GestaoUsuarios
            // 
            this.Btn_GestaoUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GestaoUsuarios.Location = new System.Drawing.Point(45, 389);
            this.Btn_GestaoUsuarios.Name = "Btn_GestaoUsuarios";
            this.Btn_GestaoUsuarios.Size = new System.Drawing.Size(348, 64);
            this.Btn_GestaoUsuarios.TabIndex = 5;
            this.Btn_GestaoUsuarios.Text = "Usuários";
            this.Btn_GestaoUsuarios.UseVisualStyleBackColor = true;
            // 
            // Frm_TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 629);
            this.Controls.Add(this.Btn_GestaoUsuarios);
            this.Controls.Add(this.Btn_Relatorios);
            this.Controls.Add(this.Btn_AdmRecursos);
            this.Controls.Add(this.Btn_Ativos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_TelaInicial";
            this.Text = "Menu Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Sair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Status;
        private System.Windows.Forms.ToolStripProgressBar Prb_LoadProcess;
        private System.Windows.Forms.Button Btn_Ativos;
        private System.Windows.Forms.Button Btn_AdmRecursos;
        private System.Windows.Forms.Button Btn_Relatorios;
        private System.Windows.Forms.Button Btn_GestaoUsuarios;
    }
}