namespace GerenciadorDeEventos
{
    partial class FrmCadastrarEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarEvento));
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDescricao = new TextBox();
            label5 = new Label();
            txtLocal = new TextBox();
            label6 = new Label();
            dtpDataHora = new DateTimePicker();
            groupBox1 = new GroupBox();
            cmbDuracao = new ComboBox();
            label7 = new Label();
            cmbCategoria = new ComboBox();
            toolStrip1 = new ToolStrip();
            tsBCadastrarEvento = new ToolStripButton();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(21, 78);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Evento";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(26, 137);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(636, 23);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(26, 113);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(16, 30);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(26, 221);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(26, 247);
            txtDescricao.MaxLength = 255;
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(636, 96);
            txtDescricao.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(232, 166);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 8;
            label5.Text = "Local";
            label5.Click += label5_Click;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(232, 193);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(430, 23);
            txtLocal.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(26, 166);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 10;
            label6.Text = "Data e Hora";
            // 
            // dtpDataHora
            // 
            dtpDataHora.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDataHora.Format = DateTimePickerFormat.Custom;
            dtpDataHora.Location = new Point(29, 192);
            dtpDataHora.Name = "dtpDataHora";
            dtpDataHora.Size = new Size(167, 23);
            dtpDataHora.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbDuracao);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(26, 365);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(636, 121);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Extras";
            // 
            // cmbDuracao
            // 
            cmbDuracao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDuracao.FormattingEnabled = true;
            cmbDuracao.Items.AddRange(new object[] { "1 Hora", "2 Horas", "3 Horas", "4 Horas", "8 Horas", "24 Horas", "48 Horas", "72 Horas" });
            cmbDuracao.Location = new Point(261, 53);
            cmbDuracao.Name = "cmbDuracao";
            cmbDuracao.Size = new Size(146, 29);
            cmbDuracao.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(261, 30);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 6;
            label7.Text = "Duração";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Festa", "Casamento", "Praia", "Show", "Formatura", "Apresentação" });
            cmbCategoria.Location = new Point(16, 53);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(222, 29);
            cmbCategoria.TabIndex = 5;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsBCadastrarEvento });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 71);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsBCadastrarEvento
            // 
            tsBCadastrarEvento.AccessibleDescription = "Salvar Evento";
            tsBCadastrarEvento.AccessibleName = "Salvar Evento";
            tsBCadastrarEvento.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBCadastrarEvento.Image = (Image)resources.GetObject("tsBCadastrarEvento.Image");
            tsBCadastrarEvento.ImageScaling = ToolStripItemImageScaling.None;
            tsBCadastrarEvento.ImageTransparentColor = Color.Magenta;
            tsBCadastrarEvento.Name = "tsBCadastrarEvento";
            tsBCadastrarEvento.Size = new Size(68, 68);
            tsBCadastrarEvento.Text = "Salvar Evento";
            tsBCadastrarEvento.Click += toolStripButton1_Click;
            // 
            // FrmCadastrarEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 536);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Controls.Add(dtpDataHora);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtLocal);
            Controls.Add(label4);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCadastrarEvento";
            Text = "Cadastrar Evento";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDescricao;
        private Label label5;
        private TextBox txtLocal;
        private Label label6;
        private DateTimePicker dtpDataHora;
        private GroupBox groupBox1;
        private ComboBox cmbDuracao;
        private Label label7;
        private ComboBox cmbCategoria;
        private ToolStrip toolStrip1;
        private ToolStripButton tsBCadastrarEvento;
    }
}