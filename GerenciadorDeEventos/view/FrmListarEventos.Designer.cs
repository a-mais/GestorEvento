namespace GerenciadorDeEventos
{
    partial class FrmListarEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarEventos));
            dgvEventos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            SuspendLayout();
            // 
            // dgvEventos
            // 
            dgvEventos.BackgroundColor = Color.MediumSlateBlue;
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.Dock = DockStyle.Fill;
            dgvEventos.GridColor = Color.FromArgb(192, 64, 0);
            dgvEventos.Location = new Point(0, 0);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.Size = new Size(800, 450);
            dgvEventos.TabIndex = 0;
            dgvEventos.CellContentClick += dgvEventos_CellContentClick;
            // 
            // FrmListarEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEventos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmListarEventos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Eventos";
            WindowState = FormWindowState.Maximized;
            Load += FrmListarEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEventos;
    }
}