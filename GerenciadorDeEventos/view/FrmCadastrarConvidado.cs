using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GerenciadorDeEventos.controller;
using GerenciadorDeEventos.model.dto;

namespace GerenciadorDeEventos
{
    public partial class FrmCadastrarConvidado : Form
    {
        public FrmCadastrarConvidado()
        {
            InitializeComponent();
        }

        // Método já existente para tratar alterações no TextBox (mantido vazio para evitar erros)
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Método vazio (pode ser implementado conforme necessidade)
        }

        // Método já existente para tratar a mudança do RadioButton (mantido vazio para evitar erros)
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Método vazio (pode ser implementado conforme necessidade)
        }

        // Método de clique do ToolStripButton para cadastrar o convidado
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria o objeto DTO para o convidado
                ConvidadoDTO novoConvidado = new ConvidadoDTO();
                // Captura os dados dos controles (supondo que os controles existem no formulário)
                novoConvidado.Nome = txtNome.Text;
                novoConvidado.Idade = int.Parse(txtIdade.Text);
                // Gera automaticamente o número do convite
                novoConvidado.NumConvite = GerarNumeroConvite();
                // Verifica o RadioButton para definir o sexo
                novoConvidado.Sexo = rbM.Checked ? "M" : "F";

                // Obtém o evento selecionado do ComboBox
                int idEvento = Convert.ToInt32(cmbEvento.SelectedValue);

                // Chama o controller para cadastrar o convidado e associá-lo ao evento
                ConvidadoController convidadoController = new ConvidadoController();
                convidadoController.CadastrarConvidado(novoConvidado, idEvento);

                MessageBox.Show("Convidado cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o convidado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método de load do formulário para popular o ComboBox com os eventos
        private void FrmCadastrarConvidado_Load(object sender, EventArgs e)
        {
            try
            {
                EventoController eventoController = new EventoController();
                List<EventoDTO> eventos = eventoController.ListarEventos();
                cmbEvento.DataSource = eventos;
                cmbEvento.DisplayMember = "Nome";   // Exibe o nome do evento
                cmbEvento.ValueMember = "IdEvento";   // Usa o id do evento como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os eventos: " + ex.Message);
            }
        }

        // Método para limpar os campos após cadastro
        private void LimparCampos()
        {
            txtNome.Clear();
            txtIdade.Clear();
            // Como o número do convite é gerado automaticamente, não há necessidade de limpar um campo correspondente.
            // Redefine o ComboBox para o primeiro item, se houver
            if (cmbEvento.Items.Count > 0)
                cmbEvento.SelectedIndex = 0;
            // Redefine os RadioButtons conforme necessário
            rbM.Checked = true;
            rbF.Checked = false;
        }

        // Método para gerar automaticamente o número do convite
        private int GerarNumeroConvite()
        {
            // Exemplo: gera um número aleatório entre 100 e 999.
            Random rnd = new Random();
            return rnd.Next(1, 1000);
        }

        private void rbM_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
