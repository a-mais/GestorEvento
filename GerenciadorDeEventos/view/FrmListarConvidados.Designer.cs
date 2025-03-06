namespace GerenciadorDeEventos.view
{
    partial class FrmListarConvidados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarConvidados));
            cmbEvento = new ComboBox();
            btnBuscar = new Button();
            dgvConvidados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConvidados).BeginInit();
            SuspendLayout();
            // 
            // cmbEvento
            // 
            cmbEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEvento.FormattingEnabled = true;
            cmbEvento.Location = new Point(12, 12);
            cmbEvento.Name = "cmbEvento";
            cmbEvento.Size = new Size(299, 23);
            cmbEvento.TabIndex = 0;
            cmbEvento.SelectedIndexChanged += cmbEvento_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(317, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvConvidados
            // 
            dgvConvidados.BackgroundColor = Color.MediumSlateBlue;
            dgvConvidados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConvidados.Location = new Point(0, 47);
            dgvConvidados.Name = "dgvConvidados";
            dgvConvidados.Size = new Size(1864, 892);
            dgvConvidados.TabIndex = 2;
            // 
            // FrmListarConvidados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvConvidados);
            Controls.Add(btnBuscar);
            Controls.Add(cmbEvento);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmListarConvidados";
            Text = "Listar Convidados do Evento";
            WindowState = FormWindowState.Maximized;
            Load += FrmListarConvidados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConvidados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbEvento;
        private Button btnBuscar;
        private DataGridView dgvConvidados;
    }
}