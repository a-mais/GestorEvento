namespace GerenciadorDeEventos
{
    partial class FrmCadastrarConvidado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarConvidado));
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtIdade = new TextBox();
            gbSexo = new GroupBox();
            rbF = new RadioButton();
            rbM = new RadioButton();
            label4 = new Label();
            cmbEvento = new ComboBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            gbSexo.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(28, 125);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(28, 148);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(607, 23);
            txtNome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(24, 81);
            label1.Name = "label1";
            label1.Size = new Size(253, 32);
            label1.TabIndex = 5;
            label1.Text = "Cadastrar Convidado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(28, 174);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 7;
            label3.Text = "Idade";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(28, 197);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(94, 23);
            txtIdade.TabIndex = 6;
            // 
            // gbSexo
            // 
            gbSexo.Controls.Add(rbF);
            gbSexo.Controls.Add(rbM);
            gbSexo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbSexo.ForeColor = SystemColors.ControlLightLight;
            gbSexo.Location = new Point(152, 177);
            gbSexo.Name = "gbSexo";
            gbSexo.Size = new Size(238, 100);
            gbSexo.TabIndex = 10;
            gbSexo.TabStop = false;
            gbSexo.Text = "Sexo";
            // 
            // rbF
            // 
            rbF.AutoSize = true;
            rbF.Location = new Point(120, 43);
            rbF.Name = "rbF";
            rbF.Size = new Size(36, 25);
            rbF.TabIndex = 1;
            rbF.Text = "F";
            rbF.UseVisualStyleBackColor = true;
            rbF.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbM
            // 
            rbM.AutoSize = true;
            rbM.Checked = true;
            rbM.Location = new Point(62, 43);
            rbM.Name = "rbM";
            rbM.Size = new Size(43, 25);
            rbM.TabIndex = 0;
            rbM.TabStop = true;
            rbM.Text = "M";
            rbM.UseVisualStyleBackColor = true;
            rbM.CheckedChanged += rbM_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(28, 286);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 12;
            label4.Text = "Evento";
            // 
            // cmbEvento
            // 
            cmbEvento.FormattingEnabled = true;
            cmbEvento.Location = new Point(28, 309);
            cmbEvento.Name = "cmbEvento";
            cmbEvento.Size = new Size(607, 23);
            cmbEvento.TabIndex = 13;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 71);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(68, 68);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // FrmCadastrarConvidado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(cmbEvento);
            Controls.Add(label4);
            Controls.Add(gbSexo);
            Controls.Add(label3);
            Controls.Add(txtIdade);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCadastrarConvidado";
            Text = "Cadastrar Convidado";
            WindowState = FormWindowState.Maximized;
            Load += FrmCadastrarConvidado_Load;
            gbSexo.ResumeLayout(false);
            gbSexo.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Label label3;
        private TextBox txtIdade;
        private GroupBox gbSexo;
        private RadioButton rbF;
        private RadioButton rbM;
        private Label label4;
        private ComboBox cmbEvento;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}