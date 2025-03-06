namespace GerenciadorDeEventos
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            barraApp = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            eventoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarEventoToolStripMenuItem = new ToolStripMenuItem();
            exibirEventosToolStripMenuItem = new ToolStripMenuItem();
            convidadosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarConvidadoToolStripMenuItem = new ToolStripMenuItem();
            listarConvidadosDeUmEventoToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            barraApp.SuspendLayout();
            SuspendLayout();
            // 
            // barraApp
            // 
            barraApp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barraApp.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, ajudaToolStripMenuItem, sairToolStripMenuItem });
            barraApp.Location = new Point(0, 0);
            barraApp.Name = "barraApp";
            barraApp.Size = new Size(672, 38);
            barraApp.TabIndex = 1;
            barraApp.Text = "barraApp";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eventoToolStripMenuItem, convidadosToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(79, 34);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // eventoToolStripMenuItem
            // 
            eventoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarEventoToolStripMenuItem, exibirEventosToolStripMenuItem });
            eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            eventoToolStripMenuItem.Size = new Size(194, 34);
            eventoToolStripMenuItem.Text = "Evento";
            // 
            // cadastrarEventoToolStripMenuItem
            // 
            cadastrarEventoToolStripMenuItem.Name = "cadastrarEventoToolStripMenuItem";
            cadastrarEventoToolStripMenuItem.Size = new Size(243, 34);
            cadastrarEventoToolStripMenuItem.Text = "Cadastrar Evento";
            cadastrarEventoToolStripMenuItem.Click += cadastrarEventoToolStripMenuItem_Click;
            // 
            // exibirEventosToolStripMenuItem
            // 
            exibirEventosToolStripMenuItem.Name = "exibirEventosToolStripMenuItem";
            exibirEventosToolStripMenuItem.Size = new Size(243, 34);
            exibirEventosToolStripMenuItem.Text = "Exibir Eventos";
            exibirEventosToolStripMenuItem.Click += exibirEventosToolStripMenuItem_Click;
            // 
            // convidadosToolStripMenuItem
            // 
            convidadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarConvidadoToolStripMenuItem, listarConvidadosDeUmEventoToolStripMenuItem });
            convidadosToolStripMenuItem.Name = "convidadosToolStripMenuItem";
            convidadosToolStripMenuItem.Size = new Size(194, 34);
            convidadosToolStripMenuItem.Text = "Convidados";
            // 
            // cadastrarConvidadoToolStripMenuItem
            // 
            cadastrarConvidadoToolStripMenuItem.Name = "cadastrarConvidadoToolStripMenuItem";
            cadastrarConvidadoToolStripMenuItem.Size = new Size(383, 34);
            cadastrarConvidadoToolStripMenuItem.Text = "Cadastrar Convidado";
            cadastrarConvidadoToolStripMenuItem.Click += cadastrarConvidadoToolStripMenuItem_Click;
            // 
            // listarConvidadosDeUmEventoToolStripMenuItem
            // 
            listarConvidadosDeUmEventoToolStripMenuItem.Name = "listarConvidadosDeUmEventoToolStripMenuItem";
            listarConvidadosDeUmEventoToolStripMenuItem.Size = new Size(383, 34);
            listarConvidadosDeUmEventoToolStripMenuItem.Text = "Listar Convidados de um Evento";
            listarConvidadosDeUmEventoToolStripMenuItem.Click += listarConvidadosDeUmEventoToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(79, 34);
            ajudaToolStripMenuItem.Text = "Ajuda";
            ajudaToolStripMenuItem.Click += ajudaToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(59, 34);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(672, 425);
            Controls.Add(barraApp);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = barraApp;
            Name = "FrmPrincipal";
            Text = "GestorEvento+";
            WindowState = FormWindowState.Maximized;
            barraApp.ResumeLayout(false);
            barraApp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip barraApp;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem eventoToolStripMenuItem;
        private ToolStripMenuItem cadastrarEventoToolStripMenuItem;
        private ToolStripMenuItem exibirEventosToolStripMenuItem;
        private ToolStripMenuItem convidadosToolStripMenuItem;
        private ToolStripMenuItem cadastrarConvidadoToolStripMenuItem;
        private ToolStripMenuItem listarConvidadosDeUmEventoToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
